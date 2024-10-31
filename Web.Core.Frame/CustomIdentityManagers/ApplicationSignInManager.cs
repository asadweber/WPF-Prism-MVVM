using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using BDO.Core.DataAccessObjects.SecurityModels;
using Microsoft.Extensions.Configuration;
using BDO.Core.DataAccessObjects.CommonEntities;
using Web.Core.Frame.Interfaces.Services;

namespace Web.Core.Frame.CustomIdentityManagers
{
    public class ApplicationSignInManager<TUser> : SignInManager<owin_userEntity> where TUser : class
    {

        private readonly ApplicationUserManager<owin_userEntity> _userManager;
        private readonly IHttpContextAccessor _contextAccessor;
        private HttpContext _context;
        private IAuthenticationSchemeProvider _schemes;
        public virtual Microsoft.Extensions.Logging.ILogger Logger { get; set; }
        public ApplicationUserManager<owin_userEntity> UserManager { get; set; }
        public IUserClaimsPrincipalFactory<owin_userEntity> ClaimsFactory { get; set; }
        public IdentityOptions Options { get; set; }

        /// <summary>
        /// Context
        /// </summary>
        public HttpContext Context
        {
            get
            {
                var context = _context ?? _contextAccessor?.HttpContext;
                if (context == null)
                {
                    throw new InvalidOperationException("HttpContext must not be null.");
                }
                return context;
            }
            set
            {
                _context = value;
            }
        }

        private readonly IConfiguration _config;
        private readonly hrwebapiconnectionsettings _objhrwebapiSettigns;
        //private readonly IHttpClientHR _ihttpclienthr;


        public ApplicationSignInManager(

            ApplicationUserManager<owin_userEntity> userManager,
            IHttpContextAccessor contextAccessor,
            IUserClaimsPrincipalFactory<owin_userEntity> claimsFactory,
            IOptions<IdentityOptions> optionsAccessor,
            ILogger<SignInManager<owin_userEntity>> logger,
            IAuthenticationSchemeProvider schemes,
            IUserConfirmation<owin_userEntity> confirmation,
            IConfiguration config
            //,IHttpClientHR ihttpclienthr
        )
        : base(userManager, contextAccessor, claimsFactory, optionsAccessor, logger, schemes, confirmation)
        {
            if (userManager == null)
            {
                throw new ArgumentNullException(nameof(userManager));
            }
            if (contextAccessor == null)
            {
                throw new ArgumentNullException(nameof(contextAccessor));
            }
            if (claimsFactory == null)
            {
                throw new ArgumentNullException(nameof(claimsFactory));
            }

            UserManager = userManager;
            _contextAccessor = contextAccessor;
            ClaimsFactory = claimsFactory;
            Options = optionsAccessor?.Value ?? new IdentityOptions();
            Logger = logger;
            _schemes = schemes;
            _config = config;
            _objhrwebapiSettigns = _config.GetSection(nameof(hrwebapiconnectionsettings)).Get<hrwebapiconnectionsettings>();
            //_ihttpclienthr = ihttpclienthr;
        }

        public override async Task<ClaimsPrincipal> CreateUserPrincipalAsync(owin_userEntity user) => await ClaimsFactory.CreateAsync(user);

        public override async Task<SignInResult> PasswordSignInAsync(string username, string password, bool isPersistent, bool lockoutOnFailure)
        {
            var user = await UserManager.FindByNameAsync(username);
            if (user == null)
            {
                return SignInResult.Failed;
            }

            return await PasswordSignInAsync(user, password, isPersistent, lockoutOnFailure);
        }


        public override async Task<SignInResult> PasswordSignInAsync(owin_userEntity user, string password,bool isPersistent, bool lockoutOnFailure)
        {
            var attempt = await CheckPasswordSignInAsync(user, password, lockoutOnFailure);
            return attempt.Succeeded
                ? await SignInOrTwoFactorAsync(user, isPersistent)
                : attempt;
        }

        /// <summary>
        /// CheckPasswordSignInAsync
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <param name="lockoutOnFailure"></param>
        /// <returns></returns>
        public override async Task<SignInResult> CheckPasswordSignInAsync(owin_userEntity user, string password, bool lockoutOnFailure)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            var error = await PreSignInCheck(user);
            if (error != null)
            {
                return error;
            }

            if (await UserManager.CheckPasswordAsync(user, password))
            {
                var alwaysLockout = AppContext.TryGetSwitch("Microsoft.AspNetCore.Identity.CheckPasswordSignInAlwaysResetLockoutOnSuccess", out var enabled) && enabled;
                // Only reset the lockout when TFA is not enabled when not in quirks mode
                if (alwaysLockout || !await IsTfaEnabled(user))
                {
                    await ResetLockout(user);
                }

                return SignInResult.Success;
            }
            Logger.LogWarning(2, "User {userId} failed to provide the correct password.", await UserManager.GetUserIdAsync(user));

            if (UserManager.SupportsUserLockout && lockoutOnFailure)
            {
                // If lockout is requested, increment access failed count which might lock out the user
                await UserManager.AccessFailedAsync(user);
                if (await UserManager.IsLockedOutAsync(user))
                {
                    return await LockedOut(user);
                }
            }
            return SignInResult.Failed;
        }


        private async Task<bool> IsTfaEnabled(owin_userEntity user)
            => UserManager.SupportsUserTwoFactor &&
            await UserManager.GetTwoFactorEnabledAsync(user) &&
            (await UserManager.GetValidTwoFactorProvidersAsync(user)).Count > 0;


        public override Task SignInAsync(owin_userEntity user, bool isPersistent, string authenticationMethod = null)
        {
            return SignInAsync(user, new AuthenticationProperties { IsPersistent = isPersistent }, authenticationMethod);
        }

        public async Task SignInAsync(owin_userEntity user, AuthenticationProperties authenticationProperties, string authenticationMethod = null)
        {
            //claims
            var userPrincipal = await CreateUserPrincipalAsync(user);
            // Review: should we guard against CreateUserPrincipal returning null?
            if (authenticationMethod != null)
            {
                userPrincipal.Identities.First().AddClaim(new Claim(ClaimTypes.AuthenticationMethod, authenticationMethod));
            }
            await Context.SignInAsync(IdentityConstants.ApplicationScheme,
                userPrincipal,
                authenticationProperties ?? new AuthenticationProperties());
        }


        public override bool IsSignedIn(ClaimsPrincipal principal)
        {
            if (principal == null)
            {
                throw new ArgumentNullException(nameof(principal));
            }
            return principal?.Identities != null &&
                principal.Identities.Any(i => i.AuthenticationType == IdentityConstants.ApplicationScheme);
        }

        public override async Task<bool> CanSignInAsync(owin_userEntity user)
        {
            if (Options.SignIn.RequireConfirmedEmail && !(await UserManager.IsEmailConfirmedAsync(user)))
            {
                Logger.LogWarning(0, "User {userId} cannot sign in without a confirmed email.", await UserManager.GetUserIdAsync(user));
                return false;
            }
            if (Options.SignIn.RequireConfirmedPhoneNumber && !(await UserManager.IsPhoneNumberConfirmedAsync(user)))
            {
                Logger.LogWarning(1, "User {userId} cannot sign in without a confirmed phone number.", await UserManager.GetUserIdAsync(user));
                return false;
            }

            return true;
        }


        public  async Task<SignInResult> PasswordSignInAsync(string username, string password, bool isPersistent, bool lockoutOnFailure,bool isPaci)
        {
            var user = await UserManager.FindByNameAsync(username);
            if (user == null)
            {
                return SignInResult.Failed;
            }

            return await PasswordSignInAsync(user, password, isPersistent, lockoutOnFailure, isPaci);
        }


        public async Task<SignInResult> PasswordSignInAsync(owin_userEntity user, string password,bool isPersistent, bool lockoutOnFailure, bool isPaci)
        {
            var attempt = await CheckPasswordSignInAsync(user, password, lockoutOnFailure, isPaci);
            return attempt.Succeeded ? await SignInOrTwoFactorAsync(user, isPersistent) : attempt;
        }

        /// <summary>
        /// CheckPasswordSignInAsync
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <param name="lockoutOnFailure"></param>
        /// <returns></returns>
        public  async Task<SignInResult> CheckPasswordSignInAsync(owin_userEntity user, string password, bool lockoutOnFailure,bool isPaci)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            var error = await PreSignInCheck(user);
            if (error != null)
            {
                return error;
            }

            if (isPaci)
            {
                var alwaysLockout = AppContext.TryGetSwitch("Microsoft.AspNetCore.Identity.CheckPasswordSignInAlwaysResetLockoutOnSuccess", out var enabled) && enabled;
                // Only reset the lockout when TFA is not enabled when not in quirks mode
                if (alwaysLockout || !await IsTfaEnabled(user))
                {
                    await ResetLockout(user);
                }

                return SignInResult.Success;
            }
            Logger.LogWarning(2, "User {userId} failed to provide the correct password.", await UserManager.GetUserIdAsync(user));

            if (UserManager.SupportsUserLockout && lockoutOnFailure)
            {
                // If lockout is requested, increment access failed count which might lock out the user
                await UserManager.AccessFailedAsync(user);
                if (await UserManager.IsLockedOutAsync(user))
                {
                    return await LockedOut(user);
                }
            }
            return SignInResult.Failed;
        }



    }
}
