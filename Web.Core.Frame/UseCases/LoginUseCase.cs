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


                        var accessToken=await _jwtFactory.GenerateEncodedToken(user, userrole.ToList());
                        accessToken.RefreshToken = refreshToken;

                        // generate access token
                        outputPort.Handle(new LoginResponse(accessToken, true));

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

        public async Task<bool> HandleForSahel(LoginRequest message, IOutputPort<LoginResponse> outputPort)
        {

            if (!string.IsNullOrEmpty(message.UserName) && !string.IsNullOrEmpty(message.Password))
            {
                string hrTokenJsonString = string.Empty;
                string hrprofileJsonString = string.Empty;
                bool ADLogin = false;

              



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

                        var accessToken = await _jwtFactory.GenerateEncodedToken(user, userrole.ToList(), hrTokenJsonString, hrprofileJsonString);

                        accessToken.RefreshToken = refreshToken;

                        outputPort.Handle(new LoginResponse(accessToken, true));

                        return true;
                    }
                }
                else
                {
                    //create profile and login - ad - db cross matches. required
                    //WORK. RON.
                }
            }

            //outputPort.Handle(new LoginResponse(new[] { new Error("login_failure", "Invalid username or password.") }));

            outputPort.Handle(new LoginResponse(new[] { new Error("login_failure", "Invalid username or password.") }));
            return false;
        }
    }
}
