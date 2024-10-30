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
using BDO.Core.DataAccessObjects.Models;
using BDO.DataAccessObjects.ApiModels;
using BDO.DataAccessObjects.ExtendedEntities;
using Microsoft.AspNetCore.Identity;
using AppConfig.HelperClasses;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using BDO.Core.Base;
using BDO;
using CLL.LLClasses.Models;

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
        private readonly IHttpClientHR _ihttpclienthr;
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
            , IHttpClientHR ihttpclienthr,
IHttpClientPACIAuth iHttpClientPACIAuth,
IStringCompression stringCompression)
        {
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

            _ihttpclienthr = ihttpclienthr;
            _iHttpClientPACIAuth = iHttpClientPACIAuth;
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


        public async Task<bool> GetFrontUserCivilIDValidated(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort)
        {
            bool state = false;
            try
            {
                CancellationToken cancellationToken = new CancellationToken();
                //owin_userEntity objUser = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.GetFacadeCreate(_contextAccessor).GetSingleExtByPKeyEX(message.Obj_owin_user, cancellationToken);
                var objUser = await BFC.Core.FacadeCreatorObjects.General.kns_tran_registrationprofileFCC.GetFacadeCreate(_contextAccessor)
                          .CheckIsAlreadyRegister(new kns_tran_registrationprofileEntity() { civilid = message.Obj_owin_user.username }, cancellationToken);


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

        public async Task<bool> CivilIdValidateFromCDUsingPaciAPI(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort)
        {
            try
            {
                CancellationToken cancellationToken = new CancellationToken();
                owin_userEntity Obj_owin_user = new owin_userEntity();
                Obj_owin_user.BaseSecurityParam = new BDO.Core.Base.SecurityCapsule();
                Obj_owin_user.BaseSecurityParam = message.Obj_PACIAuthRequest.BaseSecurityParam;
                Obj_owin_user.username = message.Obj_PACIAuthRequest.civilid;

                kns_importfrompaciexcelEntity objUser = await BFC.Core.FacadeCreatorObjects.General.kns_importfrompaciexcelFCC.GetFacadeCreate(_contextAccessor)
                .ValidateCivilID(new kns_importfrompaciexcelEntity() { civilid = message.Obj_PACIAuthRequest.civilid }, cancellationToken);


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


        public async Task<bool> WebFrontCivilIdValidateUsingPaciAPI(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort)
        {
            try
            {
                CancellationToken cancellationToken = new CancellationToken();
                owin_userEntity Obj_owin_user = new owin_userEntity();
                Obj_owin_user.BaseSecurityParam = new BDO.Core.Base.SecurityCapsule();
                Obj_owin_user.BaseSecurityParam = message.Obj_PACIAuthRequest.BaseSecurityParam;
                Obj_owin_user.username = message.Obj_PACIAuthRequest.civilid;

                var objUser = await BFC.Core.FacadeCreatorObjects.General.kns_tran_registrationprofileFCC.GetFacadeCreate(_contextAccessor)
                       .CheckIsAlreadyRegister(new kns_tran_registrationprofileEntity() { civilid = Obj_owin_user.username }, cancellationToken);


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
        private async Task SetClaimsIdentity(kns_tran_registrationprofileEntity profile)
        {
            DateTime dt = DateTime.Now;
            AppConfig.HelperClasses.transactioncodeGen objTransCode = new AppConfig.HelperClasses.transactioncodeGen();
            string TransID = objTransCode.GetRandomAlphaNumericStringForTransactionActivity("TRANWF", dt);

            CancellationToken cancellationToken = new CancellationToken();
            string kns_batchId = String.Empty;
            string batchno = String.Empty;
            string BatchStatus = String.Empty;
            string registrationstatus = String.Empty;
            string Medicalstatus = String.Empty;
            string trainingstatus = String.Empty;
            int MedicalResult = 0;

            long? KNSNo = (long?)null;

            kns_batchEntity Userkns_batch = new kns_batchEntity();
            var kns_batch = BFC.Core.FacadeCreatorObjects.General.kns_batchFCC.GetFacadeCreate(_contextAccessor).GetAll(new kns_batchEntity() { isactive = 1 }, cancellationToken).Result;

            var kns_batchDetails = BFC.Core.FacadeCreatorObjects.General.kns_batchdetailFCC.GetFacadeCreate(_contextAccessor)
                          .GetAll(new kns_batchdetailEntity() { basicinfoid = profile.basicinfoid }, cancellationToken).Result;//, batchid=kns_batch.FirstOrDefault().batchid, isactive=1,status=1

            string planorderdetailid = String.Empty;
            if (kns_batchDetails != null && kns_batchDetails.Count > 0)
            {
                var currentBatchId = kns_batchDetails.OrderByDescending(p => p.planorderdetailid).FirstOrDefault().batchid;

                KNSNo = kns_batchDetails.OrderByDescending(p => p.planorderdetailid).FirstOrDefault().KnsNo;


                Userkns_batch = ((List<kns_batchEntity>)BFC.Core.FacadeCreatorObjects.General.kns_batchFCC.GetFacadeCreate(_contextAccessor)
                              .GetAll(new kns_batchEntity() { batchid = currentBatchId }, cancellationToken).Result).FirstOrDefault();

                planorderdetailid = kns_batchDetails.FirstOrDefault().planorderdetailid.ToString();

                var kns_MedicalList = BFC.Core.FacadeCreatorObjects.General.kns_medicalFCC.GetFacadeCreate(_contextAccessor)
                          .GetAll(new kns_medicalEntity() { basicinfoid = kns_batchDetails.FirstOrDefault().basicinfoid, batchid = kns_batch.FirstOrDefault().batchid, medicalresult = (int)MedicalResultEnum.Unfit }, cancellationToken);
                var kns_MedicalListnew = kns_MedicalList.Result;

                if (kns_MedicalList != null && kns_MedicalListnew.Count() > 0)
                {
                    var kns_Medical = kns_MedicalListnew.FirstOrDefault();
                    if (kns_Medical.medicalid != null)
                    {
                        Medicalstatus = kns_Medical.medicalid.ToString();

                        MedicalResult = kns_Medical.medicalresult;


                    }
                }
            }
            if (kns_batch != null && kns_batch.Count > 0)
            {
                kns_batchId = kns_batch.FirstOrDefault().batchid.ToString();
                batchno = kns_batch.FirstOrDefault().batchno.ToString();
                BatchStatus = kns_batch.FirstOrDefault().isactive.ToString();
                registrationstatus = profile.registrationstatus == 1 ? "Created" : profile.registrationstatus == 2 ? "Updated" : "Registered";
                trainingstatus = profile.trainingstatus.ToString();
            }

            SecurityCapsule _securityCapsule = new SecurityCapsule();
            _securityCapsule.masteruserid = profile.basicinfoid;
            _securityCapsule.actioname = "Login";
            _securityCapsule.controllername = "Account";
            _securityCapsule.createdbyusername = profile.civilid;
            _securityCapsule.updatedbyusername = profile.civilid;
            //_securityCapsule.ipaddress = message.Objkns_tran_registrationprofile.peraddstreet;
            _securityCapsule.createddate = dt;
            _securityCapsule.updateddate = dt;
            //_securityCapsule.sessionid = message.Objkns_tran_registrationprofile.peraddhousingno;
            _securityCapsule.transid = TransID;


            var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, profile.civilid),
                        new Claim("BasicInfoId",Convert.ToString(profile.basicinfoid)),
                        new Claim("FullName", profile.fullname),
                        new Claim(ClaimTypes.Role, "Applicant"),
                        new Claim("batchid",kns_batchId),
                        new Claim("batchno",batchno),
                        new Claim("planorderdetailid",planorderdetailid),
                        new Claim("batchstatus",BatchStatus),
                        new Claim("registrationstatus",registrationstatus),
                        new Claim("trainingstatus",trainingstatus),
                        new Claim("Medicalstatus",Medicalstatus),
                        new Claim("MedicalResult",Convert.ToString( MedicalResult)),
                        new Claim("TransID",TransID),
                        new Claim("secobject",JsonConvert.SerializeObject(_securityCapsule))
                    };
            if (Userkns_batch != null)
            {
                claims.Add(new Claim("userbatchid", Userkns_batch.batchid.ToString()));
                claims.Add(new Claim("userbatchno", Userkns_batch.batchno.ToString()));
            }
            else
            {
                claims.Add(new Claim("userbatchid", "0"));
                claims.Add(new Claim("userbatchno", "0"));
            }
           
           
            claims.Add(new Claim("KNSNo", KNSNo.HasValue? KNSNo.ToString():string.Empty));

            
         var claimsIdentity = new ClaimsIdentity(
                claims, IdentityConstants.ApplicationScheme);


            var authProperties = new AuthenticationProperties
            {
                IsPersistent = false,
            };

            await _contextAccessor.HttpContext.SignInAsync(
                IdentityConstants.ApplicationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);

        }

        public async Task<bool> LoginWebFrontPACIRequest(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort)
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

                var ResultDetails = JsonConvert.DeserializeObject<ResultDetails>(message.Obj_owin_user.concurrencystamp);
                var PersonalData = JsonConvert.DeserializeObject<PersonalData>(message.Obj_owin_user.securitystamp);

                if ((ResultDetails.UserCivilNo != PersonalData.CivilID) && (ResultDetails.UserCivilNo != message.Obj_owin_user.masprivatekey))
                {
                    outputPort.Error(new Auth_Response(new AjaxResponse("500", _sharedLocalizer["INVALID_LOGIN_ATTEMPT"].Value, CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleInformation, ""
                         ), false, _sharedLocalizer["INVALID_LOGIN_ATTEMPT"].Value));
                    return false;
                }

                PaciKeyParamsValuesEntity objKeyParam = JsonConvert.DeserializeObject<PaciKeyParamsValuesEntity>(objEnc.decryptSimple(message.Obj_owin_user.emailaddress));
                //  message.Obj_owin_user.pkeyex = long.Parse(objKeyParam.CivilID);
                message.Obj_owin_user.username = objKeyParam.CivilID;
                //owin_userEntity objUser = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.GetFacadeCreate(_contextAccessor).GetSingleExtByPKeyEX(message.Obj_owin_user, cancellationToken);
                var profile = await BFC.Core.FacadeCreatorObjects.General.kns_tran_registrationprofileFCC.GetFacadeCreate(_contextAccessor)
                     .CheckIsAlreadyRegister(new kns_tran_registrationprofileEntity() { civilid = message.Obj_owin_user.username, password = message.Obj_owin_user.password }, cancellationToken);


                //var CheckUser = _userManager.CheckUserExists(objUser.civilid, objUser.password, hrprofileJsonString);
                //var returnUrl = message.Obj_owin_user.ReturnUrl;
                //var user = await _userManager.FindByNameAsync(objUser.civilid);

                if (profile != null)
                {
                    state = true;
                    clsPrivateKeys objClsPrivate = new clsPrivateKeys();
                    if (profile.registrationstatus >= (int)RegistrationStatusEnm.Account_Submited)
                    {
                        profile.redirecturl = $"/Registered/ProfileDetails";
                    }
                    else
                    {
                        profile.redirecturl = $"/Registered/Profile{objClsPrivate.EncodeParams("basicinfoid", profile.basicinfoid.ToString())}";
                    }



                    await SetClaimsIdentity(profile);

                    outputPort.Login(new Auth_Response(new AjaxResponse("200", _sharedLocalizer["VERIFY"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, profile.redirecturl
                        ), true, null));
                    return state;
                }
                else
                {
                    _logger.LogWarning(2, "User not found.");
                    state = false;

                    outputPort.Login(new Auth_Response(new AjaxResponse("500", _sharedLocalizer["INVALID_LOGIN_ATTEMPT"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                       ), true, null));


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

        public async Task<bool> LoginWebFrontWithPassword(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort)
        {
            bool state = false;
            AppConfig.EncryptionHandler.EncryptionHelper objEnc = new AppConfig.EncryptionHandler.EncryptionHelper();
            try
            {
                string hrTokenJsonString = string.Empty;
                string hrprofileJsonString = string.Empty;
                bool ADLogin = false;
                CancellationToken cancellationToken = new CancellationToken();

                var profile = await BFC.Core.FacadeCreatorObjects.General.kns_tran_registrationprofileFCC.GetFacadeCreate(_contextAccessor)
                     .CheckIsAlreadyRegister(new kns_tran_registrationprofileEntity() { civilid = message.Obj_owin_user.username, password = message.Obj_owin_user.password }, cancellationToken);


                //var CheckUser = _userManager.CheckUserExists(objUser.civilid, objUser.password, hrprofileJsonString);
                //var returnUrl = message.Obj_owin_user.ReturnUrl;
                //var user = await _userManager.FindByNameAsync(objUser.civilid);

                if (profile != null)
                {
                    state = true;
                    clsPrivateKeys objClsPrivate = new clsPrivateKeys();
                    if (profile.registrationstatus >= (int)RegistrationStatusEnm.Account_Submited)
                    {
                        profile.redirecturl = $"/Registered/ProfileDetails";
                    }
                    else
                    {
                        profile.redirecturl = $"/Registered/Profile{objClsPrivate.EncodeParams("basicinfoid", profile.basicinfoid.ToString())}";
                    }



                    await SetClaimsIdentity(profile);

                    outputPort.Login(new Auth_Response(new AjaxResponse("200", _sharedLocalizer["VERIFY"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, profile.redirecturl
                        ), true, null));
                    return state;
                }
                else
                {
                    _logger.LogWarning(2, "User not found.");
                    state = false;

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


        public async Task<bool> SyncProfileAuthRequestByCivilId(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort)
        {
            try
            {
                CancellationToken cancellationToken = new CancellationToken();
                owin_userEntity Obj_owin_user = new owin_userEntity();
                Obj_owin_user.BaseSecurityParam = new BDO.Core.Base.SecurityCapsule();
                Obj_owin_user.BaseSecurityParam = message.Obj_PACIAuthRequest.BaseSecurityParam;
                Obj_owin_user.username = message.Obj_PACIAuthRequest.civilid;



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
