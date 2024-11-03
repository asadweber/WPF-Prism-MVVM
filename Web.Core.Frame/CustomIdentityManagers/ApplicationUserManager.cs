using AppConfig.EncryptionHandler;
using BDO.Core.Base;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.SecurityModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using Web.Core.Frame.CustomStores;
using Web.Core.Frame.Dto.GatewayResponses.Repositories;
using Web.Core.Frame.Dto.UseCaseRequests;
using Web.Core.Frame.Dto.UseCaseResponses;
using Web.Core.Frame.Interfaces.Services;

namespace Web.Core.Frame.CustomIdentityManagers
{
    public class ApplicationUserManager<TUser> : UserManager<owin_userEntity> where TUser : class
    {
        private IServiceProvider _services;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ISecCapFillerFromJWTClaim _seccapfillerfromjwtclaim; 
        private readonly IConfiguration _config;
        private readonly IStringCompression _stringCompression;


        private static readonly RandomNumberGenerator _rng = RandomNumberGenerator.Create();
        public ApplicationUserManager(
                        IUserStore<owin_userEntity> store,
                        IOptions<IdentityOptions> optionsAccessor,
                        IPasswordHasher<owin_userEntity> passwordHasher,
                        IEnumerable<IUserValidator<owin_userEntity>> userValidators,
                        IEnumerable<IPasswordValidator<owin_userEntity>> passwordValidators,
                        ILookupNormalizer keyNormalizer,
                        IdentityErrorDescriber errors,
                        IServiceProvider services,
                        ILogger<UserManager<owin_userEntity>> logger,
                        IHttpContextAccessor contextAccessor,
                        IConfiguration config
            , ISecCapFillerFromJWTClaim seccapfillerfromjwtclaim
            , IStringCompression stringCompression) :
            base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {

            _config = config;
            _seccapfillerfromjwtclaim = seccapfillerfromjwtclaim;
            _stringCompression = stringCompression;

            if (store == null)
            {
                throw new ArgumentNullException(nameof(store));
            }
            Store = store;
            Options = optionsAccessor?.Value ?? new IdentityOptions();
            PasswordHasher = passwordHasher;
            KeyNormalizer = keyNormalizer;
            ErrorDescriber = errors;
            Logger = logger;
            if (userValidators != null)
            {
                foreach (var v in userValidators)
                {
                    UserValidators.Add(v);
                }
            }
            if (passwordValidators != null)
            {
                foreach (var v in passwordValidators)
                {
                    PasswordValidators.Add(v);
                }
            }

            _contextAccessor = contextAccessor;
            _services = services;

            if (services != null)
            {
                foreach (var providerName in Options.Tokens.ProviderMap.Keys)
                {
                    var description = Options.Tokens.ProviderMap[providerName];

                    var provider = (description.ProviderInstance ?? services.GetRequiredService(description.ProviderType))
                        as IUserTwoFactorTokenProvider<owin_userEntity>;
                    if (provider != null)
                    {
                        RegisterTokenProvider(providerName, provider);
                    }
                }
            }

            if (Options.Stores.ProtectPersonalData)
            {
                if (!(Store is IProtectedUserStore<TUser>))
                {
                    //throw new InvalidOperationException(Resources.StoreNotIProtectedUserStore);
                }
                if (services.GetService<ILookupProtector>() == null)
                {
                    //throw new InvalidOperationException(Resources.NoPersonalDataProtector);
                }
            }
        }



        public async Task<owin_userEntity> CheckUserExists(string userName, string password, string hrprofileJsonString)
        {
            ThrowIfDisposed();
            if (userName == null)
            {
                throw new ArgumentNullException(nameof(userName));
            }

            var user = await Store.FindByNameAsync(userName, CancellationToken);
            if (user != null)
                return user;
            else
            {
                var cast = Store as CustomUserStore;
                hrprofileJsonString = _stringCompression.UnZip(hrprofileJsonString);
                //GetMilShortInfoByBasicMilEntity objUserHRProfile = JsonConvert.DeserializeObject<GetMilShortInfoByBasicMilEntity>(hrprofileJsonString);
                //objUserHRProfile.jobresponsibility = string.Empty;
                //objUserHRProfile.unitrole = string.Empty;
                //objUserHRProfile.jobresponsibility = password;

                //user = await cast.createUserProfileAsync(objUserHRProfile, CancellationToken);
                return await Store.FindByNameAsync(userName, CancellationToken); 
            }    
        }



        /// <summary>
        /// UpdateUserPasswordResetInfo
        /// </summary>
        /// <param name="user"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public async Task<long> UpdateUserPasswordResetInfo(owin_userEntity user, string code)
        {
            ThrowIfDisposed();
            CancellationToken cancellationToken = new CancellationToken();
            var savedResult = await BFC.Core.FacadeCreatorObjects.Security.owin_userpasswordresetinfoFCC.GetFacadeCreate(_contextAccessor).Add(new owin_userpasswordresetinfoEntity()
            {
                sessionid = user.BaseSecurityParam.sessionid,
                userid = user.userid,
                masteruserid = user.masteruserid,
                sessiontoken = code,
                username = user.username,
                isactive = true,
                BaseSecurityParam = user.BaseSecurityParam
            }, cancellationToken);

            if (savedResult > 0)
                return savedResult;
            else
                throw new InvalidCredentialException("User Password Reset history could not added");
        }

       


        /// <summary>
        /// CheckPasswordAsync
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public override async Task<bool> CheckPasswordAsync(owin_userEntity user, string password)
        {
            ThrowIfDisposed();
            CancellationToken cancellationToken = new CancellationToken();
            user.password = password;
            var result = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.GetFacadeCreate(_contextAccessor).UserSignInAsync(user, cancellationToken);
            var success = false;
            if (result != null)
            {
                success = true;
            }
            if (!success)
            {
                Logger.LogWarning(0, "Invalid password for user {userId}.", await GetUserIdAsync(user));
            }
            return success;
        }

        public async Task<long> UserSignInLogUpdateAsync(owin_userEntity user)
        {
            var claimsIdentity = _contextAccessor.HttpContext.User.Identity as ClaimsIdentity;

            if (claimsIdentity.Claims.Count() > 0)
            {
                var _securityCapsule = JsonConvert.DeserializeObject<SecurityCapsule>(claimsIdentity.Claims.ToList().Where(p => p.Type == "secobject").FirstOrDefault().Value);
                user.BaseSecurityParam = _securityCapsule;
            }

            ThrowIfDisposed();
            CancellationToken cancellationToken = new CancellationToken();
            var result = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.GetFacadeCreate(_contextAccessor).UserSignInLogUpdateAsync(user, cancellationToken);
            if (result > 0)
            {
                return result;
            }
            else
            {
                Logger.LogWarning(0, "Invalid password for user {userId}.", await GetUserIdAsync(user));
            }
            return result;
        }

       

        public async Task<string> GetSecFilledFromClaimsPrincipal(ClaimsPrincipal User)
        {
            var sec = User.FindFirst("secobject");

            if (sec != null)
                return sec.Value.ToString();
            else
                throw new NotSupportedException("not updated logout data.");
        }


        public override async Task<owin_userEntity> FindByNameAsync(string userName)
        {
            ThrowIfDisposed();
            if (userName == null)
            {
                throw new ArgumentNullException(nameof(userName));
            }

            var user = await Store.FindByNameAsync(userName, CancellationToken);

            // Need to potentially check all keys
            if (user == null && Options.Stores.ProtectPersonalData)
            {
                var keyRing = _services.GetService<ILookupProtectorKeyRing>();
                var protector = _services.GetService<ILookupProtector>();
                if (keyRing != null && protector != null)
                {
                    foreach (var key in keyRing.GetAllKeyIds())
                    {
                        var oldKey = protector.Protect(key, userName);
                        user = await Store.FindByNameAsync(oldKey, CancellationToken);
                        if (user != null)
                        {
                            return user;
                        }
                    }
                }
            }
            return user;
        }

        public async Task<owin_userEntity> GetUserIdAsyncByUserID(string userid)
        {
            ThrowIfDisposed();
            owin_userEntity objuser = new owin_userEntity();
            objuser.userid = new Guid(userid);

            CancellationToken cancellationToken = new CancellationToken();
            var user = await BFC.Core.FacadeCreatorObjects.Security.owin_userFCC.GetFacadeCreate(_contextAccessor).GetSingle(objuser, cancellationToken);

            if (user != null)
                return user;
            else
                throw new InvalidCredentialException("Oops!!!");
        }

        public async Task<CreateUserResponse> Create(string firstName, string lastName, string email, string userName, string password)
        {
            //var appUser = new owin_userEntity { emailaddress = email, username = userName };
            //var identityResult = await _userManager.CreateAsync(appUser, password);

            //if (!identityResult.Succeeded) return new CreateUserResponse(appUser.Id, false, identityResult.Errors.Select(e => new Error(e.Code, e.Description)));

            //var user = new User(firstName, lastName, appUser.Id, appUser.UserName);
            //_appDbContext.Users.Add(user);
            //await _appDbContext.SaveChangesAsync();

            return new CreateUserResponse("SUCCEED"); // CreateUserResponse(appUser.GetUserId, identityResult.Succeeded, identityResult.Succeeded ? null : identityResult.Errors.Select(e => new Error(e.Code, e.Description)));
        }


        /// <summary>
        /// ResetPasswordAsync
        /// </summary>
        /// <param name="user"></param>
        /// <param name="token"></param>
        /// <param name="newPassword"></param>
        /// <returns></returns>
        public override async Task<IdentityResult> ResetPasswordAsync(owin_userEntity user, string token, string newPassword)
        {
            CancellationToken cancellationToken = new CancellationToken();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            // Make sure the token is valid and the stamp matches
            if (!await VerifyUserTokenAsync(user, Options.Tokens.PasswordResetTokenProvider, ResetPasswordTokenPurpose, token))
            {
                return IdentityResult.Failed(ErrorDescriber.InvalidToken());
            }

            var alist = await BFC.Core.FacadeCreatorObjects.Security.owin_userpasswordresetinfoFCC.GetFacadeCreate(_contextAccessor).GetAll(new owin_userpasswordresetinfoEntity()
            {
                userid = user.userid,
                sessiontoken = user.code,
                isactive = true
            }, cancellationToken);
            if (alist == null || alist.Count <= 0)
            {
                return IdentityResult.Failed(ErrorDescriber.RecoveryCodeRedemptionFailed());
            }

            var result = await UpdatePasswordHash(user, newPassword, validatePassword: true);
            if (!result.Succeeded)
            {
                return result;
            }
            return await UpdateUserAsync(user);
        }


        protected virtual Task<IdentityResult> UpdatePasswordHash(owin_userEntity user, string newPassword, bool validatePassword)
            => UpdatePasswordHash(GetPasswordStore(), user, newPassword, validatePassword);

        private async Task<IdentityResult> UpdatePasswordHash(IUserPasswordStore<owin_userEntity> passwordStore,
            owin_userEntity user, string newPassword, bool validatePassword = true)
        {
            if (validatePassword)
            {
                var validate = await ValidatePasswordAsync(user, newPassword);
                if (!validate.Succeeded)
                {
                    return validate;
                }
            }
            var hash = newPassword != null ? PasswordHasher.HashPassword(user, newPassword) : null;


            await passwordStore.SetPasswordHashAsync(user, hash, CancellationToken);
            return IdentityResult.Success;
        }

        private IUserPasswordStore<owin_userEntity> GetPasswordStore()
        {
            var cast = Store as CustomUserStore;
            if (cast == null)
            {
                throw new NotSupportedException("StoreNotIUserPasswordStore");
            }
            return cast;
        }

        private IUserLockoutStore<owin_userEntity> GetUserLockoutStore()
        {
            var cast = Store as CustomUserStore;
            if (cast == null)
            {
                throw new NotSupportedException("StoreNotIUserLockoutStore");
            }
            return cast;
        }

        public async Task<IdentityResult> SetLockoutEndDateAsync(owin_userEntity user, DateTimeOffset? lockoutEnd)
        {
            ThrowIfDisposed();
            var store = GetUserLockoutStore();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            if (!await store.GetLockoutEnabledAsync(user, CancellationToken))
            {
                Logger.LogWarning(11, "Lockout for user {userId} failed because lockout is not enabled for this user.", await GetUserIdAsync(user));
                return IdentityResult.Failed(ErrorDescriber.UserLockoutNotEnabled());
            }
            await store.SetLockoutEndDateAsync(user, lockoutEnd, CancellationToken);
            return await store.UpdateAsync(user, CancellationToken);
        }


        public async Task<SignInResult> SignInAsyncFromExternalApp(LoginResponse objResponse, LoginRequest message)
        {
            CancellationToken cancellationToken = new CancellationToken();
            if (objResponse == null || message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            owin_userEntity user = new owin_userEntity();
            user.userid = new System.Guid(message.Password);
            user.username = message.UserName;

            await SaveLoginTrain(objResponse.AccessToken, objResponse.AccessToken.RefreshToken, message.RemoteIpAddress,
                user);

            Logger.LogWarning(2, "User {userId} failed to provide the correct password.", message.Password);
            return SignInResult.Success;
        }


        public async Task<long> SaveLoginTrain(AccessToken AccessToken,
            string RefreshToken,
            string RemoteIpAddress,
            owin_userEntity user)
        {
            CancellationToken cancellationToken = new CancellationToken();

            //ronty fix
            //tran_loginEntity objTran = new tran_loginEntity()
            //{
            //    BaseSecurityParam = _seccapfillerfromjwtclaim.SetCap(AccessToken.Token, RemoteIpAddress,
            //    out DateTime? tokenValidFromTime,
            //    out DateTime? tokenValidToTime),
            //    parentserialloginid = null,
            //    samaccount = user.username,
            //    samemail = user.username,
            //    userid = user.userid,
            //    logindate = tokenValidFromTime.GetValueOrDefault(DateTime.Now),
            //    logintoken = AccessToken.Token,
            //    expires = tokenValidToTime.GetValueOrDefault(DateTime.Now),
            //    refreshtoken = RefreshToken,
            //    tokenissuedate = tokenValidFromTime.GetValueOrDefault(DateTime.Now),
            //    remarks = "Logged in from SP",
            //};

            //return await BFC.Core.FacadeCreatorObjects.Security.tran_loginFCC.GetFacadeCreate(_contextAccessor).Add(objTran, cancellationToken);

            return -99;
        }


        public async Task<List<RefreshToken>> LoadAsyncRefreshToken(owin_userEntity user)
        {
            CancellationToken cancellationToken = new CancellationToken();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            //var objTran = await BFC.Core.FacadeCreatorObjects.Security.tran_loginFCC.GetFacadeCreate(_contextAccessor).
            //    GetAllTokenByUser(new tran_loginEntity()
            //    {
            //        userid = user.userid
            //    }, cancellationToken);

            var objTran = new List<RefreshToken>(); 
            Logger.LogWarning(2, "User {userId} failed to provide the correct password.", user.userid);

            return objTran.ToList();
        }


        public virtual async Task<long> loginowin_userlogintrail(SecurityCapsule securityCapsule)
        {
            ThrowIfDisposed();
            long resLoginAdd = -99;

            CancellationToken cancellationToken = new CancellationToken();
            resLoginAdd = await BFC.Core.FacadeCreatorObjects.Security.owin_userlogintrailFCC.GetFacadeCreate(_contextAccessor).Add(new owin_userlogintrailEntity()
            {
                userid = securityCapsule.userid,
                masteruserid = securityCapsule.masteruserid,
                loginfrom = "Web App",
                logindate = securityCapsule.createddate,
                logoutdate = null,
                machineip = securityCapsule.ipaddress,
                loginstatus = "LOGIN",
                loginstatusbit = true,
                sessionid = securityCapsule.sessionid,
                usertoken = securityCapsule.transid,
                BaseSecurityParam = securityCapsule

            }, cancellationToken);

            return resLoginAdd;
        }

        /// <summary>
        /// updateowin_userlogintrail
        /// </summary>
        /// <param name="claimsIdentity"></param>
        /// <param name="resLoginSeriale"></param>
        /// <returns></returns>
        public virtual async Task<long> logoutowin_userlogintrail(ClaimsIdentity claimsIdentity)
        {
            SecurityCapsule _securityCapsule = new SecurityCapsule();
            long resLoginUpdate = -99;
            if (claimsIdentity.Claims.Count() > 0)
            {
                var resLoginSeriale = claimsIdentity.FindFirst("resLoginSerial").Value;
                var secobject = claimsIdentity.FindFirst("secobject").Value;

                EncryptionHelper objEnc = new EncryptionHelper();
                var authSettings = _config.GetSection(nameof(AuthSettings)).Get<AuthSettings>();
                string strserialize = objEnc.Decrypt(secobject, true, authSettings.SecretKey);
                _securityCapsule = JsonConvert.DeserializeObject<SecurityCapsule>(strserialize);
                if (_securityCapsule != null)
                {
                    CancellationToken cancellationToken = new CancellationToken();
                    resLoginUpdate = await BFC.Core.FacadeCreatorObjects.Security.owin_userlogintrailFCC.GetFacadeCreate(_contextAccessor).Update(new owin_userlogintrailEntity()
                    {
                        masteruserid = _securityCapsule.masteruserid,
                        serialno = long.Parse(resLoginSeriale),
                        userid = _securityCapsule.userid,
                        loginfrom = "Web App",
                        logindate = _securityCapsule.createddate,
                        logoutdate = DateTime.Now,
                        machineip = _securityCapsule.ipaddress,
                        loginstatus = "LOGOUT",
                        loginstatusbit = false,
                        sessionid = _securityCapsule.sessionid,
                        usertoken = _securityCapsule.transid,
                        BaseSecurityParam = _securityCapsule

                    }, cancellationToken);
                }
            }
            return resLoginUpdate;
        }
    }
}
