using BDO.Core.DataAccessObjects.SecurityModels;
using CLL.Localization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System.Reflection;
using System.Threading.Tasks;
using Web.Core.Frame.CustomIdentityManagers;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Dto.UseCaseRequests;
using Web.Core.Frame.Dto.UseCaseResponses;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.Interfaces.Services;
using Web.Core.Frame.Interfaces.UseCases;
using System.Linq;
using Microsoft.Extensions.Configuration;
using BDO.Core.DataAccessObjects.CommonEntities;

namespace Web.Core.Frame.UseCases
{
    public sealed class LoginUseCase : ILoginUseCase
    {
        private readonly ApplicationUserManager<owin_userEntity> _userManager;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IJwtFactory _jwtFactory;
        private readonly ITokenFactory _tokenFactory;
        private readonly IStringLocalizer _sharedLocalizer;
        private readonly ILogger<LoginUseCase> _logger;
        private readonly IConfiguration _config;
        private readonly hrwebapiconnectionsettings _objhrwebapiSettigns;

        private readonly IHttpClientHR _ihttpclienthr;

        public LoginUseCase(
            IHttpContextAccessor contextAccessor,
            ApplicationUserManager<owin_userEntity> userManager,
            IJwtFactory jwtFactory,
            ITokenFactory tokenFactory,
            IStringLocalizerFactory factory,
            ILoggerFactory loggerFactory
            , IHttpClientHR ihttpclienthr
            , IConfiguration config)
        {
            _contextAccessor = contextAccessor;
            _userManager = userManager;
            _jwtFactory = jwtFactory;
            _tokenFactory = tokenFactory;
            _logger = loggerFactory.CreateLogger<LoginUseCase>();
            _config = config;

            _objhrwebapiSettigns = _config.GetSection(nameof(hrwebapiconnectionsettings)).Get<hrwebapiconnectionsettings>();

            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _sharedLocalizer = factory.Create("SharedResource", assemblyName.Name);

            _ihttpclienthr = ihttpclienthr;
        }

        public async Task<bool> Handle(LoginRequest message, IOutputPort<LoginResponse> outputPort)
        {
            if (!string.IsNullOrEmpty(message.UserName) && !string.IsNullOrEmpty(message.Password))
            {
                string hrTokenJsonString = string.Empty;
                string hrprofileJsonString = string.Empty;
                bool ADLogin = false;

                if (_objhrwebapiSettigns.isRequired)
                {
                    hrTokenJsonString = await _ihttpclienthr.LoginToHRAPIService();
                    hrprofileJsonString = await _ihttpclienthr.CheckUserExists(message.UserName);
                    if (string.IsNullOrEmpty(hrprofileJsonString))
                    {
                        outputPort.Handle(new LoginResponse(new[] { new Error("login_failure", "Invalid username or HR user profile does not exists .") }));
                        return false;
                    }
                }

                //AD AUTH CHECK HERE
                if (_objhrwebapiSettigns.isAdCheckRequired)
                {
                    if (!string.IsNullOrEmpty(_objhrwebapiSettigns.LDAPURL)) ADLogin = await _ihttpclienthr.LDAPAuthentication(message.UserName, message.Password);
                    if (!ADLogin)
                    {
                        outputPort.Handle(new LoginResponse(new[] { new Error("login_failure", "Invalid username or HR user profile does not exists .") }));
                        return false;
                    }
                    else
                    {
                        // GET HR Token FROM API
                        if (_objhrwebapiSettigns.isRequired)
                        {

                            hrprofileJsonString = await _ihttpclienthr.GetMilitaryShortProfileFromHR(message.UserName, hrTokenJsonString);
                            if (string.IsNullOrEmpty(hrprofileJsonString))
                            {
                                outputPort.Handle(new LoginResponse(new[] { new Error("login_failure", "Invalid username or HR user profile does not exists .") }));
                                return false;
                            }
                        }
                    }
                }

                var ss = _sharedLocalizer["INVALID_VERFICATION_CODE"].Value;
                // ensure we have a user with the given user name
                var user = await _userManager.FindByNameAsync(message.UserName);
                if (user != null)
                {
                    // validate password
                    if (await _userManager.CheckPasswordAsync(user, message.Password))
                    {
                        var userrole = await _userManager.GetRolesAsync(user);

                        // generate refresh token
                        var refreshToken = _tokenFactory.GenerateToken();
                        user.AddRefreshToken(refreshToken, user.userid.GetValueOrDefault(), message.RemoteIpAddress);
                        await _userManager.UpdateAsync(user);

                        // generate access token
                        outputPort.Handle(new LoginResponse(await _jwtFactory.GenerateEncodedToken(user, userrole.ToList(), hrTokenJsonString, hrprofileJsonString), refreshToken, true));
                        return true;
                    }
                }
                else
                {
                    //create profile and login - ad - db cross matches. required
                    //WORK. RON.
                }
            }
            outputPort.Handle(new LoginResponse(new[] { new Error("login_failure", "Invalid username or password.") }));
            return false;
        }
    }
}
