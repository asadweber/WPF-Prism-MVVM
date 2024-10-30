using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.SecurityModels;
using CLL.Localization;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Web.Core.Frame.CustomIdentityManagers;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Dto.UseCaseRequests;
using Web.Core.Frame.Dto.UseCaseResponses;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.Interfaces.Services;
using Web.Core.Frame.Interfaces.UseCases;


namespace Web.Core.Frame.UseCases
{
    public sealed class ChangePasswordUseCase : IChangePasswordUseCase
    {
        private readonly IJwtTokenValidator _jwtTokenValidator;
        private readonly ApplicationUserManager<owin_userEntity> _userManager;
        private readonly ILogger<ChangePasswordUseCase> _logger;
        private readonly IStringLocalizer _sharedLocalizer;
        private readonly IJwtFactory _jwtFactory;
        


        public ChangePasswordUseCase(
            IJwtTokenValidator jwtTokenValidator,
            ApplicationUserManager<owin_userEntity> userManager,
            IJwtFactory jwtFactory
            ,  IStringLocalizerFactory factory,
            ILoggerFactory loggerFactory)
        {
            _jwtTokenValidator = jwtTokenValidator;
            _userManager = userManager;
            _jwtFactory = jwtFactory;
            
            _logger = loggerFactory.CreateLogger<ChangePasswordUseCase>();
            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _sharedLocalizer = factory.Create("SharedResource", assemblyName.Name);
        }

        public async Task<bool> Handle(ChangePasswordRequest message, IOutputPort<ChangePasswordResponse> outputPort)
        {
            var success = string.Empty;

            if (!string.IsNullOrEmpty(message.UserName) && !string.IsNullOrEmpty(message.Password))
            {
                if (message.Newpassword != message.ConfirmNewpassword)
                {
                    success = "credential missmatched.";
                    outputPort.Handle(new ChangePasswordResponse(new AjaxResponse(success), false, success));
                    return false;
                };

                var ss = _sharedLocalizer["INVALID_VERFICATION_CODE"].Value;
                // ensure we have a user with the given user name
                var user = await _userManager.FindByNameAsync(message.UserName);
                if (user != null)
                {
                    // validate password
                    if (await _userManager.CheckPasswordAsync(user, message.Password))
                    {
                        var idr3esult = await _userManager.ChangePasswordAsyncs(user, message.ConfirmNewpassword);

                        success = "Password updated successfully.";
                        outputPort.Handle(new ChangePasswordResponse(new AjaxResponse(success), true, null));
                        return true;
                    }
                }
            }

            success = "Invalid username or password";
            outputPort.Handle(new ChangePasswordResponse(new Error("403", success), false, success));
            return false;
        }



    }
}
