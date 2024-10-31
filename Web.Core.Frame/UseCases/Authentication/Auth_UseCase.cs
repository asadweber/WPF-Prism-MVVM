using BDO.DataAccessObjects.ApiModels;
using CLL.Localization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.Interfaces.Services;
using Web.Core.Frame.Interfaces.UseCases;
using Web.Core.Frame.Dto;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Options;
using Web.Core.Frame.CustomIdentityManagers;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Dto.UseCaseRequests;
using Web.Core.Frame.Dto.UseCaseResponses;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using Microsoft.Extensions.Configuration;
using BDO.Core.DataAccessObjects.CommonEntities;
using BDO.DataAccessObjects.ExtendedEntities;
using BDO.DataAccessObjects.ExtendedEntities;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using DocumentFormat.OpenXml.Spreadsheet;
using BDO.Core.Base;
using Microsoft.AspNetCore.Identity;
using System.Net.Mail;
using BDO.Base;
using RestSharp;

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
        private readonly hrwebapiconnectionsettings _objhrwebapiSettigns;

        private readonly ApplicationUserManager<owin_userEntity> _userManager;
        private readonly ApplicationSignInManager<owin_userEntity> _signInManager;
        //private readonly IHttpClientHR _ihttpclienthr;
        private readonly KAFPaciServiceSettings _kAFPaciServiceSettings;

        private readonly IHttpClientPACIAuth _iHttpClientPACIAuth;

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
            , IConfiguration config
            //, IHttpClientHR ihttpclienthr
            , IHttpClientPACIAuth iHttpClientPACIAuth
            , IStringCompression stringCompression)
        {
            _stringCompression = stringCompression;
            _jwtTokenValidator = jwtTokenValidator;
            _contextAccessor = contextAccessor;
            _config = config;
            _jwtFactory = jwtFactory;
            _logger = loggerFactory.CreateLogger<Auth_UseCase>();
            _emailSender = emailSender;
            _environment = environment;

            _objhrwebapiSettigns = _config.GetSection(nameof(hrwebapiconnectionsettings)).Get<hrwebapiconnectionsettings>();

            _userManager = userManager;
            _signInManager = signInManager;

            _applicationGlobalSettings = applicationGlobalSettings; 

            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _sharedLocalizer = factory.Create("SharedResource", assemblyName.Name);

            //_ihttpclienthr = ihttpclienthr;
            _iHttpClientPACIAuth = iHttpClientPACIAuth;
            _kAFPaciServiceSettings = _config.GetSection(nameof(KAFPaciServiceSettings)).Get<KAFPaciServiceSettings>();

        }

        public Task<bool> Handle(Auth_Request message, IOutputPort<Auth_Response> outputPort)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> LoginFromWebFrontWebRequest(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort)
        {
            bool state = false;
            try
            {
                string hrTokenJsonString = string.Empty;
                string hrprofileJsonString = string.Empty;
                bool ADLogin = false;

               var CheckUser = _userManager.CheckUserExists(message.Obj_owin_user.emailaddress, message.Obj_owin_user.password, hrprofileJsonString);

                var returnUrl = message.Obj_owin_user.ReturnUrl;
                var user = await _userManager.FindByNameAsync(message.Obj_owin_user.emailaddress);
                bool IsInUserRole = await _userManager.IsInRoleAsync(user, ApplicationUserRoleEnum.User.ToString());

                if (user != null && IsInUserRole)
                {
                    var userT = user;
                    userT.password = string.Empty;
                    userT.passwordkey = string.Empty;
                    userT.passwordsalt = string.Empty;
                    userT.passwordvector = string.Empty;
                    userT.masprivatekey = string.Empty;
                    userT.maspublickey = string.Empty;

                    user.profileJson = _stringCompression.Zip(JsonConvert.SerializeObject(userT));
                    user.ReturnUrl = returnUrl;
                    user.apitokenJson = hrTokenJsonString;


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
                }
                else
                {
                    _logger.LogWarning(2, "User not found.");
                    state = false;
                }

                if (state)
                {
                    var ReturnUrl = string.IsNullOrEmpty(user.ReturnUrl) ? "/" : user.ReturnUrl;
                    outputPort.Login(new Auth_Response(new AjaxResponse("200", _sharedLocalizer["VERIFY"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, ReturnUrl
                        ), true, null));
                    return state;
                }
                else
                {
                    outputPort.Error(new Auth_Response(new AjaxResponse("500", _sharedLocalizer["INVALID_LOGIN_ATTEMPT"].Value, CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleInformation, ""
                        ), false, _sharedLocalizer["INVALID_LOGIN_ATTEMPT"].Value));
                    return state;
                }
            }
            catch (Exception ex)
            {
                Auth_Response objResponse = new Auth_Response(new AjaxResponse("500", _sharedLocalizer["INVALID_LOGIN_ATTEMPT"].Value, CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleInformation, ""
                        ), false, _sharedLocalizer["INVALID_LOGIN_ATTEMPT"].Value);
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Error(objResponse);
                return true;
            }
        }


        public async Task<bool> LoginWebRequest(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort)
        {
            bool state = false;
            try
            { 
                string hrTokenJsonString = string.Empty;
                string hrprofileJsonString = string.Empty;
                bool ADLogin = false;

               // var CheckUser = _userManager.CheckUserExists(message.Obj_owin_user.emailaddress, message.Obj_owin_user.password, hrprofileJsonString);

                var returnUrl = message.Obj_owin_user.ReturnUrl;
                var user = await _userManager.FindByNameAsync(message.Obj_owin_user.emailaddress);
				bool IsInUserRole = await _userManager.IsInRoleAsync(user, ApplicationUserRoleEnum.User.ToString());

				if (user != null && !IsInUserRole)
                {
                    var userT = user;
                    userT.password = string.Empty;
                    userT.passwordkey = string.Empty;
                    userT.passwordsalt = string.Empty;
                    userT.passwordvector = string.Empty;
                    userT.masprivatekey = string.Empty;
                    userT.maspublickey = string.Empty;

                    user.profileJson = _stringCompression.Zip(JsonConvert.SerializeObject(userT));
                    user.ReturnUrl = returnUrl;
                    user.apitokenJson = hrTokenJsonString;


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
                }
                else 
                {
                    _logger.LogWarning(2, "User not found.");
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
                    outputPort.Error(new Auth_Response(new AjaxResponse("500", _sharedLocalizer["INVALID_LOGIN_ATTEMPT"].Value, CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleInformation, ""
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
        public async Task<bool> LoginWebPACIRequest(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort)
        {
            bool state = false;
            AppConfig.EncryptionHandler.EncryptionHelper objEnc = new AppConfig.EncryptionHandler.EncryptionHelper();
            try
            {
                string hrTokenJsonString = string.Empty;
                string hrprofileJsonString = string.Empty;
                bool ADLogin = false;
                CancellationToken cancellationToken = new CancellationToken();

                if (string.IsNullOrEmpty(message.Obj_owin_user.securitystamp) || string.IsNullOrEmpty(message.Obj_owin_user.concurrencystamp))
                {
                    outputPort.Error(new Auth_Response(new AjaxResponse("500", _sharedLocalizer["INVALID_LOGIN_ATTEMPT"].Value, CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleInformation, ""
                         ), false, _sharedLocalizer["INVALID_LOGIN_ATTEMPT"].Value));
                    return false;
                }

                var ResultDetails = JsonConvert.DeserializeObject<ResultDetails>(objEnc.decryptSimple(message.Obj_owin_user.concurrencystamp));
                var PersonalData = JsonConvert.DeserializeObject<PersonalData>(objEnc.decryptSimple(message.Obj_owin_user.securitystamp));

                if ((ResultDetails.UserCivilNo != PersonalData.CivilID) && (ResultDetails.UserCivilNo != message.Obj_owin_user.masprivatekey))
                {
                    outputPort.Error(new Auth_Response(new AjaxResponse("500", _sharedLocalizer["INVALID_LOGIN_ATTEMPT"].Value, CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleInformation, ""
                         ), false, _sharedLocalizer["INVALID_LOGIN_ATTEMPT"].Value));
                    return false;
                }

                PaciKeyParamsValuesEntity objKeyParam = JsonConvert.DeserializeObject<PaciKeyParamsValuesEntity>(objEnc.decryptSimple(message.Obj_owin_user.emailaddress));
              //  message.Obj_owin_user.pkeyex = long.Parse(objKeyParam.CivilID);
                message.Obj_owin_user.username = objKeyParam.CivilID;
                owin_userEntity objUser = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.GetFacadeCreate(_contextAccessor).GetSingleExtByPKeyEX(message.Obj_owin_user, cancellationToken);
                
                var CheckUser = _userManager.CheckUserExists(objUser.username, objUser.password, hrprofileJsonString);
                var returnUrl = message.Obj_owin_user.ReturnUrl;
                var user = await _userManager.FindByNameAsync(objUser.username);

                if (user != null)
                {
                    var userT = user;
                    userT.password = string.Empty;
                    userT.passwordkey = string.Empty;
                    userT.passwordsalt = string.Empty;
                    userT.passwordvector = string.Empty;
                    userT.masprivatekey = string.Empty;
                    userT.maspublickey = string.Empty;

                    user.profileJson = _stringCompression.Zip(JsonConvert.SerializeObject(userT));
                    user.ReturnUrl = returnUrl;
                    user.apitokenJson = hrTokenJsonString;


                    var result = SignInResult.Success;
                    result = await _signInManager.PasswordSignInAsync(user, user.password,
                        message.Obj_owin_user.AllowRememberLogin, lockoutOnFailure: false,true);
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
                }
                else
                {
                    _logger.LogWarning(2, "User not found.");
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
                    outputPort.Error(new Auth_Response(new AjaxResponse("500", _sharedLocalizer["INVALID_LOGIN_ATTEMPT"].Value, CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleInformation, ""
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


        public async Task<bool> CheckApplicantAccountActivation(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            bool state = false;
            try
            {

                var ActivationCode = await BFC.Core.FacadeCreatorObjects.General.cnf_smsactivationcodeFCC.GetFacadeCreate(_contextAccessor).
                    CheckActivation(new BDO.Core.DataAccessObjects.Models.cnf_smsactivationcodeEntity() {UserName= message.Obj_owin_user.emailaddress }, cancellationToken);
                if (ActivationCode == null)
                {
                    Auth_Response objResponse = new Auth_Response(
                     new AjaxResponse("200", _sharedLocalizer["ACCOUNT_ACTIVE"].Value, "true", "", "", message.Obj_owin_user.emailaddress),
                     true,
                     _sharedLocalizer["ACCOUNT_ACTIVE"].Value);
                    outputPort.AccountActivation(objResponse);

                    return true;
                }
                else
                {
                    Auth_Response objResponse = new Auth_Response(
                     new AjaxResponse("200", _sharedLocalizer["ACCOUNT_NOT_ACTIVE"].Value, "false", "", "/AccountVarification/AccountVerification?civilId="+message.Obj_owin_user.emailaddress, message.Obj_owin_user.emailaddress),
                     false,
                     _sharedLocalizer["ACCOUNT_NOT_ACTIVE"].Value);
                    outputPort.AccountActivation(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }



        public async Task<bool> ForgetPasswordRequest(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
           // string authcode = string.Empty;
            try
            {
                (string authcode,string emailaddress,string PhoneNumber) = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.GetFacadeCreate(_contextAccessor).ForgetPasswordRequest(message.Obj_owin_user, cancellationToken);
                if (!string.IsNullOrEmpty(authcode))
                {
                    
                    string html = System.IO.File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "EmailTemplate/forgetPasswordAuthCode" + Thread.CurrentThread.CurrentCulture.ToString().ToUpper() + ".html"));
                    html = html.Replace("{authocode}", authcode);
                    html = html.Replace("{resetpasswordurl}", _applicationGlobalSettings.Value.PassResetURL + authcode);

                    EmailEntity objEmail = new EmailEntity();
                    objEmail.toEmail = emailaddress;
                    objEmail.subject = _sharedLocalizer["RESET_YOUR_PASSWORD"].Value;
                    objEmail.message = html;
                    _emailSender.SendEmailAsync(objEmail);
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

        public async Task<bool> ForgetPasswordFromFrontRequest(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            // string authcode = string.Empty;
            try
            {
                (string authcode, string emailaddress, string PhoneNumber) = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.GetFacadeCreate(_contextAccessor).ForgetPasswordRequestFromFront(message.Obj_owin_user, cancellationToken);
                if (!string.IsNullOrEmpty(authcode))
                {

                    string html = System.IO.File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "EmailTemplate/forgetPasswordAuthCode" + Thread.CurrentThread.CurrentCulture.ToString().ToUpper() + ".html"));
                    html.Replace("{currentdatetime}", DateTime.Now.ToString("dd-MM-yyyy"));
                    html = html.Replace("{authocode}", authcode);
                    html = html.Replace("{resetpasswordurl}", _applicationGlobalSettings.Value.PassResetURL);

                    try
                    {
                        if (_kAFPaciServiceSettings.IsEnable)
                        {
                            using (RestClient client = new RestClient($"{_kAFPaciServiceSettings.WebApiAddress}Auth/login"))
                            {
                                RestRequest Shahilrequest = new RestRequest() { Method = Method.Post };
                                //Add Headers  
                                Shahilrequest.AddHeader("Content-Type", "application/json");
                                var body = new
                                {
                                    username = _kAFPaciServiceSettings.UserName,
                                    password = _kAFPaciServiceSettings.Password
                                };

                                Shahilrequest.AddJsonBody(body);

                                var apiresponse = client.Execute(Shahilrequest);
                                if (apiresponse.IsSuccessStatusCode)
                                {
                                    var accee = JsonConvert.DeserializeObject<SahilAccesstoken>(apiresponse.Content);

                                    using (var notificationClient = new RestClient($"{_kAFPaciServiceSettings.WebApiAddress}NotificationRequestRecipientList/SendNotificationToSingleUser"))
                                    {
                                        Shahilrequest = new RestRequest() { Method = Method.Post };
                                        Shahilrequest.AddHeader("Content-Type", "application/json");
                                        Shahilrequest.AddHeader("Authorization", $"Bearer {accee.accessToken.token}");

                                        var NotificationBody = new
                                        {
                                            applicationid = _kAFPaciServiceSettings.ApplicationId,
                                            notificationrequestid = 0,
                                            recipientcivilid = message.Obj_owin_user.username,
                                            recipientmobile = PhoneNumber,
                                            recipientemail = emailaddress,

                                            msgsubject = "VC:Password Reset",
                                            msgsubjectar = "إعادة تعيين كلمة المرور",

                                            msg = $"Your password reset Authorization Code is {authcode}",
                                            msgar = $"Your password reset Authorization Code is {authcode}",

                                            messagebodyemail = html,
                                            messagebodyemailar = html,

                                            sendsms = message.Obj_owin_user.SendBySMS,
                                            senddigitalidnotification = message.Obj_owin_user.SendByDigitalId,
                                            sendemail = message.Obj_owin_user.SendByEmail
                                        };

                                        Shahilrequest.AddJsonBody(NotificationBody);
                                        var NotificationApiresponse = notificationClient.Execute(Shahilrequest);

                                    }

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }

                }

                string Replymess = string.Empty;
                if (message.Obj_owin_user.SendBySMS)
                    Replymess = _sharedLocalizer["FORGETPASSWORDSMS"].Value;
                else if (message.Obj_owin_user.SendByDigitalId)
                    Replymess = _sharedLocalizer["FORGETPASSWORDDIGITAL"].Value;
                else if (message.Obj_owin_user.SendByEmail)
                    Replymess = _sharedLocalizer["FORGETPASSWORDEMAIL"].Value;
                

                outputPort.ForgetPasswordAjax(new Auth_Response(new AjaxResponse("200", Replymess, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/Account/PasswordReset"
                    ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Auth_Response objResponse = new Auth_Response(false, _sharedLocalizer["DATA_DELETE_ERROR"], new Error(
                         "500",
                         _sharedLocalizer["USER_NOT_FOUND"]));
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
                    Auth_Response objResponse = new Auth_Response(false, _sharedLocalizer["INVALID_USER_REQUEST"], new Error(
                         "500",
                         _sharedLocalizer["INVALID_USER_REQUEST"].Value));
                    outputPort.Login(objResponse);
                    return false;
                }
                else
                {
                    owin_userpasswordresetinfoEntity objResObj = new owin_userpasswordresetinfoEntity();

                    objResObj = await BFC.Core.FacadeCreatorObjects.Security.owin_userpasswordresetinfoFCC.GetFacadeCreate(_contextAccessor).GetSingle(new owin_userpasswordresetinfoEntity()
                    {
                        sessiontoken = message.Obj_owin_user.password,
                        username = message.Obj_owin_user.emailaddress
                    }, cancellationToken);

                    if (objResObj != null)
                    {
                        message.Obj_owin_user.code = message.Obj_owin_user.password;
                        message.Obj_owin_user.password = message.Obj_owin_user.confirmpassword;
                        message.Obj_owin_user.masteruserid = user.masteruserid;
                        message.Obj_owin_user.userid = user.userid;

                        long? i = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.
                            GetFacadeCreate(_contextAccessor).UserResetPasswordAsync(message.Obj_owin_user, cancellationToken);
                        if (i > 0)
                        {
                            outputPort.Login(new Auth_Response(new AjaxResponse("200", _sharedLocalizer["RESET_PASSWORD_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/Account/Login"
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
                        Auth_Response objResponse = new Auth_Response(false, _sharedLocalizer["DATA_DELETE_ERROR"], new Error(
                         "500",
                         _sharedLocalizer["INVALID_OTP_REQUEST"].Value));
                        outputPort.Login(objResponse);
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
                    outputPort.Error(new Auth_Response(new AjaxResponse("404", "User / Email Address Not Found", CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleInformation, ""
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
                        outputPort.Error(new Auth_Response(new AjaxResponse("401", _sharedLocalizer["PASSWORD_NOT_SAME"].Value, CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleInformation, ""
                    ), false, _sharedLocalizer["PASSWORD_NOT_SAME"].Value));
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



        public async Task<bool> GetQRCodeFromPACIToAuthenticate(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort)
        {
            try
            {
                PACIQRCodeAuthenticationEntity objRet = new PACIQRCodeAuthenticationEntity();
                objRet = await _iHttpClientPACIAuth.GetQRCodeFromPACIToAuthenticate(message.Obj_PACIAuthRequest);
                outputPort.Login(new Auth_Response(new AjaxResponse(objRet), true, null));
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
        public async Task<bool> CivilIdValidateUsingPaciAPI(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort)
        {
            try
            {
                CancellationToken cancellationToken = new CancellationToken();
                owin_userEntity Obj_owin_user = new owin_userEntity();
                Obj_owin_user.BaseSecurityParam = new BDO.Core.Base.SecurityCapsule();
                Obj_owin_user.BaseSecurityParam = message.Obj_PACIAuthRequest.BaseSecurityParam;
                Obj_owin_user.username = message.Obj_PACIAuthRequest.civilid;

                owin_userEntity objUser = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.GetFacadeCreate(_contextAccessor).
                    GetSingleExtByPKeyEX(Obj_owin_user, cancellationToken);

                if (objUser != null)
                {

                    SignInAjaxResponse objRet = new SignInAjaxResponse();
                    objRet = await _iHttpClientPACIAuth.SendAuthRequestToAuthenticate(message.Obj_PACIAuthRequest);

                    var objData = new
                    {
                        civilID = objRet.data.CivilId,
                        PaciSigninRequestInfoSerial = objRet.data.PaciSigninRequestInfoSerial,
                        KeyParam = objRet.data.KeyParam,
                        result = objRet.data.Result,
                        status = 200
                    };
                    outputPort.Login(new Auth_Response(new AjaxResponse(objData), true, null));
                    return true;
                }
                else
                {
                    outputPort.Error(new Auth_Response(new AjaxResponse("403", _sharedLocalizer["INVALID_CIVILID"].Value, CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleInformation, ""
                          ), false, _sharedLocalizer["INVALID_CIVILID"].Value));
                    return false;
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

        public async Task<bool> GetCivilIDValidated(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort)
        {
            bool state = false;
            try
            {
                CancellationToken cancellationToken = new CancellationToken();
                owin_userEntity objUser = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.GetFacadeCreate(_contextAccessor).GetSingleExtByPKeyEX(message.Obj_owin_user, cancellationToken);
                if (objUser == null)
                    state = false;
                else
                    state = true;

                if (state)
                {
                    outputPort.Login(new Auth_Response(new AjaxResponse("200", _sharedLocalizer["VERIFY"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                    return state;
                }
                else
                {
                    outputPort.Error(new Auth_Response(new AjaxResponse("403", _sharedLocalizer["INVALID_CIVILID"].Value, CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleInformation, ""
                          ), false, _sharedLocalizer["INVALID_CIVILID"].Value));
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
    }
}
