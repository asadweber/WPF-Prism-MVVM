using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.SecurityModels;
using CLL.Localization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Reflection;
using Web.Core.Frame.CustomIdentityManagers;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.Interfaces.Services;
using Web.Core.Frame.Interfaces.UseCases;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.UseCases
{
    public sealed class Auth_UseCase : IAuth_UseCase
    {
        private readonly IJwtTokenValidator _jwtTokenValidator;

        private readonly IOptions<ApplicationGlobalSettings> _applicationGlobalSettings;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IJwtFactory _jwtFactory;
        private readonly IStringLocalizer _sharedLocalizer;
        private readonly ILogger<Auth_UseCase> _logger;
        private readonly IEmailSender _emailSender;
        private readonly IHostingEnvironment _environment;

        private readonly IConfiguration _config;

        private readonly ApplicationUserManager<owin_userEntity> _userManager;
        private readonly ApplicationSignInManager<owin_userEntity> _signInManager;

        private readonly IStringCompression _stringCompression;


        public Error _errors { get; set; }

        public Auth_UseCase(
            IJwtTokenValidator jwtTokenValidator,
            IHttpContextAccessor contextAccessor,
            IJwtFactory jwtFactory,
            IStringLocalizerFactory factory,
            ILoggerFactory loggerFactory,
            IEmailSender emailSender,
            IHostingEnvironment environment,
            ApplicationUserManager<owin_userEntity> userManager,
            ApplicationSignInManager<owin_userEntity> signInManager,
            IOptions<ApplicationGlobalSettings> applicationGlobalSettings
            , IConfiguration config,
IStringCompression stringCompression)
        {
            _jwtTokenValidator = jwtTokenValidator;
            _contextAccessor = contextAccessor;
            _config = config;
            _jwtFactory = jwtFactory;
            _logger = loggerFactory.CreateLogger<Auth_UseCase>();
            _emailSender = emailSender;
            _environment = environment;


            _userManager = userManager;
            _signInManager = signInManager;

            _applicationGlobalSettings = applicationGlobalSettings;

            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _sharedLocalizer = factory.Create("SharedResource", assemblyName.Name);

            _stringCompression = stringCompression;
        }

        public Task<bool> Handle(Auth_Request message, IOutputPort<Auth_Response> outputPort)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> LoginWebRequest(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort)
        {
            bool state = false;
            try
            {        
               
                string hrTokenJsonString = string.Empty;
                string hrprofileJsonString = string.Empty;
				/*
                bool ADLogin = false;

                if (_objhrwebapiSettigns.isRequired)
                {
                    hrTokenJsonString = await _ihttpclienthr.LoginToHRAPIService();
                    hrprofileJsonString = await _ihttpclienthr.CheckUserExists(message.Obj_owin_user.emailaddress);
                    if (string.IsNullOrEmpty(hrprofileJsonString))
                    {
                        outputPort.Error(new Auth_Response(
                            new AjaxResponse("403", _sharedLocalizer["INVALID_LOGIN_ATTEMPT"].Value, CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleInformation, ""),
                            false,
                            _sharedLocalizer["INVALID_LOGIN_ATTEMPT"].Value));
                        return false;
                    }
                }

                //AD AUTH CHECK HERE
                if (_objhrwebapiSettigns.isAdCheckRequired)
                {
                    if (!string.IsNullOrEmpty(_objhrwebapiSettigns.LDAPURL)) ADLogin = await _ihttpclienthr.LDAPAuthentication(message.Obj_owin_user.emailaddress, message.Obj_owin_user.password);
                    if (!ADLogin)
                    {
                        outputPort.Error(new Auth_Response(new AjaxResponse("403", _sharedLocalizer["INVALID_LOGIN_ATTEMPT"].Value, CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleInformation, ""
                        ), false, _sharedLocalizer["INVALID_LOGIN_ATTEMPT"].Value));
                        return false;
                    }
                    else
                    {
                        // GET HR Token FROM API
                        if (_objhrwebapiSettigns.isRequired)
                        {

                            hrprofileJsonString = await _ihttpclienthr.GetMilitaryShortProfileFromHR(message.Obj_owin_user.emailaddress, hrTokenJsonString);
                            if (string.IsNullOrEmpty(hrprofileJsonString))
                            {
                                outputPort.Error(new Auth_Response(
                                    new AjaxResponse("403", _sharedLocalizer["INVALID_LOGIN_ATTEMPT"].Value, CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleInformation, ""),
                                    false,
                                    _sharedLocalizer["INVALID_LOGIN_ATTEMPT"].Value));
                                return false;
                            }
                        }
                    }
                }

                 */
				var CheckUser = _userManager.CheckUserExists(message.Obj_owin_user.emailaddress, message.Obj_owin_user.password, hrprofileJsonString);
                var returnUrl = message.Obj_owin_user.ReturnUrl;
                var user = await _userManager.FindByNameAsync(message.Obj_owin_user.emailaddress);
                user.profileJson = hrprofileJsonString;
                user.apitokenJson = hrTokenJsonString;
                user.ReturnUrl = returnUrl;

                var result = await _signInManager.PasswordSignInAsync(user, message.Obj_owin_user.password,
                    message.Obj_owin_user.AllowRememberLogin, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    _logger.LogInformation(1, "User logged in.");
                    state = true;
                }
                else if (result.IsLockedOut)
                {
                    _logger.LogWarning(2, "User account locked out.");
                    state = false;
                }
                else
                {
                    //ModelState.AddModelError(string.Empty, _sharedLocalizer["INVALID_LOGIN_ATTEMPT"]);
                    state = false;
                }
                if (state)
                {
                    outputPort.Login(new Auth_Response(new AjaxResponse("200", _sharedLocalizer["VERIFY"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                    return state;
                }
                else
                {
                    outputPort.Error(new Auth_Response(new AjaxResponse("403", _sharedLocalizer["INVALID_LOGIN_ATTEMPT"].Value, CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleInformation, ""
                        ), false, _sharedLocalizer["INVALID_LOGIN_ATTEMPT"].Value));
                    return state;
                }
            }
            catch (Exception ex)
            {
                Auth_Response objResponse = new Auth_Response(false, _sharedLocalizer["DATA_DELETE_ERROR"], new Error(
                         "500",
                         ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.ForgetPassword(objResponse);
                return true;
            }
        }

        public async Task<bool> ForgetPasswordRequest(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            string authcode = string.Empty;
            try
            {
                authcode = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.GetFacadeCreate(_contextAccessor).ForgetPasswordRequest(message.Obj_owin_user, cancellationToken);
                if (!string.IsNullOrEmpty(authcode))
                {
                    string html = System.IO.File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "EmailTemplate/forgetPasswordAuthCode" + Thread.CurrentThread.CurrentCulture.ToString().ToUpper() + ".html"));
                    html = html.Replace("{authocode}", authcode);
                    html = html.Replace("{resetpasswordurl}", _applicationGlobalSettings.Value.PassResetURL + authcode);

                    _emailSender.SendEmailAsync(message.Obj_owin_user.emailaddress, _sharedLocalizer["RESET_YOUR_PASSWORD"].Value, html);
                }
                outputPort.ForgetPasswordAjax(new Auth_Response(new AjaxResponse("200", _sharedLocalizer["FORGETPASSWORDEMAIL"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, ""
                    ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Auth_Response objResponse = new Auth_Response(false, _sharedLocalizer["DATA_DELETE_ERROR"], new Error(
                         "500",
                         ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.ForgetPassword(objResponse);
                return true;
            }
        }

        public async Task<bool> PasswordRequestAuthTokenValidated(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            string authcode = string.Empty;
            IList<owin_userpasswordresetinfoEntity> objResObj = new List<owin_userpasswordresetinfoEntity>();
            try
            {
                objResObj = await BFC.Core.FacadeCreatorObjects.Security.owin_userpasswordresetinfoFCC.GetFacadeCreate(_contextAccessor).GetAll(new owin_userpasswordresetinfoEntity()
                {
                    sessiontoken = message.Obj_owin_user.code,
                    isactive = true
                }, cancellationToken);

                if (objResObj != null && objResObj.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                Auth_Response objResponse = new Auth_Response(false, _sharedLocalizer["DATA_DELETE_ERROR"], new Error(
                         "500",
                         ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.ForgetPassword(objResponse);
                return true;
            }
        }


        public async Task<bool> ResetPassword(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort)
        {
            bool state = false;
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                var returnUrl = message.Obj_owin_user.ReturnUrl;
                var user = await _userManager.FindByNameAsync(message.Obj_owin_user.emailaddress);
                if (user == null)
                {
                    outputPort.Login(new Auth_Response(new AjaxResponse("400", _sharedLocalizer["INVALID_REQUEST"].Value, CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleInformation, ""
                        ), false, _sharedLocalizer["INVALID_REQUEST"].Value));
                    return false;
                }
                else
                {
                    IList<owin_userpasswordresetinfoEntity> objResObj = new List<owin_userpasswordresetinfoEntity>();

                    objResObj = await BFC.Core.FacadeCreatorObjects.Security.owin_userpasswordresetinfoFCC.GetFacadeCreate(_contextAccessor).GetAll(new owin_userpasswordresetinfoEntity()
                    {
                        sessiontoken = message.Obj_owin_user.password,
                        isactive = true
                    }, cancellationToken);

                    if (objResObj != null && objResObj.Count > 0)
                    {
                        message.Obj_owin_user.code = message.Obj_owin_user.password;
                        message.Obj_owin_user.password = message.Obj_owin_user.confirmpassword;
                        message.Obj_owin_user.masteruserid = user.masteruserid;
                        message.Obj_owin_user.userid = user.userid;

                        long? i = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.
                            GetFacadeCreate(_contextAccessor).UserResetPasswordAsync(message.Obj_owin_user, cancellationToken);
                        if (i > 0)
                        {
                            outputPort.Login(new Auth_Response(new AjaxResponse("200", _sharedLocalizer["RESET_PASSWORD_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                                ), true, null));
                            return true;
                        }
                        else
                        {
                            outputPort.Login(new Auth_Response(new AjaxResponse("500", _sharedLocalizer["DATA_PERSISTANCE_ERROR"].Value, CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleInformation, ""
                        ), false, _sharedLocalizer["DATA_PERSISTANCE_ERROR"].Value));
                            return false;
                        }
                    }
                    else
                    {
                        outputPort.Login(new Auth_Response(new AjaxResponse("400", _sharedLocalizer["INVALID_REQUEST"].Value, CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleInformation, ""
                          ), false, _sharedLocalizer["INVALID_REQUEST"].Value));
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Auth_Response objResponse = new Auth_Response(false, _sharedLocalizer["DATA_DELETE_ERROR"], new Error(
                         "500",
                         ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.ForgetPassword(objResponse);
                return true;
            }
        }

        public async Task<bool> ChangePassword(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort)
        {
            bool state = false;
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                var returnUrl = message.Obj_owin_user.ReturnUrl;
                var user = await _userManager.FindByNameAsync(message.Obj_owin_user.username);
                if (user == null)
                {
                    outputPort.Login(new Auth_Response(new AjaxResponse("403", _sharedLocalizer["INVALID_REQUEST"].Value, CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleInformation, ""
                        ), false, _sharedLocalizer["INVALID_REQUEST"].Value));
                    return false;
                }
                else
                {
                    owin_userEntity i = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.
                        GetFacadeCreate(_contextAccessor).ChangePasswordRequest(message.Obj_owin_user, cancellationToken);
                    if (i != null)
                    {
                        outputPort.Login(new Auth_Response(new AjaxResponse("401", _sharedLocalizer["RESET_PASSWORD_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                            ), true, null));
                        return true;
                    }
                    else
                    {
                        outputPort.Error(new Auth_Response(new AjaxResponse("403", _sharedLocalizer["INVALID_REQUEST"].Value, CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleInformation, ""
                    ), false, _sharedLocalizer["INVALID_REQUEST"].Value));
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Auth_Response objResponse = new Auth_Response(false, _sharedLocalizer["DATA_DELETE_ERROR"], new Error(
                         "500",
                         ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.ForgetPassword(objResponse);
                return true;
            }
        }

    }
}
