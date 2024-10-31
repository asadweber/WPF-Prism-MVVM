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
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.Interfaces.Services;
using Web.Core.Frame.Dto;
using AppConfig.HelperClasses;
using Web.Core.Frame.Helpers;
using System.Security.Claims;
using static AppConfig.HelperClasses.applicationEnamNConstants;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces.UseCases.Registration;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.Dto.UseCaseRequests.Registration;
using System.Globalization;
using System.Data.Common;
using AppConfig.EncryptionHandler;
using Microsoft.AspNet.SignalR.Client.Http;
using BDO.Core.Base;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;
using CLL.LLClasses.Models;
using Microsoft.AspNetCore.Identity;
using Web.Core.Frame.CustomIdentityManagers;
using BDO.DataAccessObjects.Enums;
using NLog.LayoutRenderers.Wrappers;
using BDO.DataAccessObjects.VCRegistration;
using BDO.Base;
using RestSharp;
using BDO.DataAccessObjects.ExtendedEntities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.IO;
using CLL.LLClasses;
using DocumentFormat.OpenXml.Vml;
using IDAC.Core.IDataAccessObjects.Security.ExtendedPartial;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.EMMA;
using DocumentFormat.OpenXml.Spreadsheet;
using System.DirectoryServices.ActiveDirectory;
//using static ClosedXML.Excel.XLPredefinedFormat;

namespace Web.Core.Frame.UseCases.Registration
{
    public sealed partial class VCRegistrationUseCase : IVCRegistrationUseCase
    {
        private readonly IOptions<ApplicationGlobalSettings> _applicationGlobalSettings;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IJwtFactory _jwtFactory;
        private readonly IStringLocalizer _sharedLocalizer;
        private readonly ILogger<Reg_BasicInfoUseCase> _logger;
        private dataTableButtonPanel objDTBtnPanel = new dataTableButtonPanel();
        public Error _errors { get; set; }
        private readonly ApplicationUserManager<owin_userEntity> _userManager;
        private readonly KAFPaciServiceSettings _kAFPaciServiceSettings;
        private readonly IConfiguration _config;

        private readonly IFileUploadClient fileuploadclient;
        private readonly FtpServerSetting ftpServerSetting;

        public VCRegistrationUseCase(IConfiguration config,
            IHttpContextAccessor contextAccessor,
            IJwtFactory jwtFactory,
            IStringLocalizerFactory factory,
            ILoggerFactory loggerFactory,
            ApplicationUserManager<owin_userEntity> userManager,
            IOptions<ApplicationGlobalSettings> applicationGlobalSettings,
            IFileUploadClient fileuploadclient,
            IOptions<FtpServerSetting> ftpServerSetting
            )
        {
            _contextAccessor = contextAccessor;
            _jwtFactory = jwtFactory;
            _logger = loggerFactory.CreateLogger<Reg_BasicInfoUseCase>();

            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _sharedLocalizer = factory.Create("SharedResource", assemblyName.Name);
            _userManager = userManager;
            _config = config;
            _kAFPaciServiceSettings = _config.GetSection(nameof(KAFPaciServiceSettings)).Get<KAFPaciServiceSettings>();
            _applicationGlobalSettings = applicationGlobalSettings;
            this.ftpServerSetting = ftpServerSetting.Value;
            this.fileuploadclient = fileuploadclient;
        }

        public Task<bool> Handle(VCRegistrationRequest message, IOutputPort<VCRegistrationResponse> outputPort)
        {
            throw new NotImplementedException();
        }

        #region PreRegistration Validation Policy
        public async Task<bool> ValidateMobileNumber(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                var MobileNumber = message.validationParameter.MobileNumber;

                reg_basicinfoEntity oblist = await BFC.Core.FacadeCreatorObjects.General.reg_basicinfoFCC.GetFacadeCreate(_contextAccessor)
                .ValidateMobileNumber(new reg_basicinfoEntity() { mob1 = MobileNumber }, cancellationToken);

                if (oblist != null)
                {
                    VCRegistrationResponse objResponse = new VCRegistrationResponse(
                       new AjaxResponse("200", @CLL.LLClasses.Models._PreRegistrationResource.MobileNumberExistsErrorMsg, "false", "", ""),
                       false,
                       @CLL.LLClasses.Models._PreRegistrationResource.MobileNumberExistsErrorMsg);

                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.ValidationPolicy(objResponse);
                    return false;

                }
                else
                {
                    VCRegistrationResponse objResponse = new VCRegistrationResponse(
                        new AjaxResponse("200", "Number is valid. Not Exists", "true", "", ""),
                        true,
                        "Number is valid. Not Exists");

                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.ValidationPolicy(objResponse);
                    return true;
                }
            }
            catch (Exception ex)
            {
                VCRegistrationResponse objResponse = new VCRegistrationResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.ValidationPolicy(objResponse);
                return false;
            }
        }

        public async Task<bool> ValidateEmailAddress(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                var EmailAddress = message.validationParameter.EmailAddress;

                reg_basicinfoEntity oblist = await BFC.Core.FacadeCreatorObjects.General.reg_basicinfoFCC.GetFacadeCreate(_contextAccessor)
                .ValidateEmailAddress(new reg_basicinfoEntity() { email = EmailAddress }, cancellationToken);

                if (oblist != null)
                {
                    VCRegistrationResponse objResponse = new VCRegistrationResponse(
                       new AjaxResponse("200", @CLL.LLClasses.Models._PreRegistrationResource.EmailExistsErrorMsg, "false", "", ""),
                       false,
                       @CLL.LLClasses.Models._PreRegistrationResource.EmailExistsErrorMsg);

                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.ValidationPolicy(objResponse);
                    return false;

                }
                else
                {
                    VCRegistrationResponse objResponse = new VCRegistrationResponse(
                        new AjaxResponse("200", "Email is valid. Not Exists", "true", "", ""),
                        true,
                        "Email is valid. Not Exists");

                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.ValidationPolicy(objResponse);
                    return true;
                }
            }
            catch (Exception ex)
            {
                VCRegistrationResponse objResponse = new VCRegistrationResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.ValidationPolicy(objResponse);
                return false;
            }
        }

        public async Task<bool> ValidateCivilIdPolicy(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                //Age Calculation
                var firstch = message.validationParameter.CivilId.Substring(0, 1);
                string dtStrFromCivilIDTmp = message.validationParameter.CivilId.Substring(1, 6);
                var Year = dtStrFromCivilIDTmp.Substring(0, 2);
                if (firstch == "2")
                {
                    Year = "19" + Year;
                }
                else if (firstch == "3")
                {
                    Year = "20" + Year;
                }
                string dtStrFromCivilID = dtStrFromCivilIDTmp.Substring(4, 2) + "-" + dtStrFromCivilIDTmp.Substring(2, 2) + "-" + CultureInfo.CurrentCulture.Calendar.ToFourDigitYear(int.Parse(Year));
                DateTime dtFromCivilID = DateTime.ParseExact(dtStrFromCivilID, "dd-MM-yyyy", null);

                // Calculate the age.
                DateTime zeroTime = new DateTime(1, 1, 1);
                TimeSpan span = DateTime.Today - dtFromCivilID;
                int years = (zeroTime + span).Year - 1;
                int months = (zeroTime + span).Month - 1;
                int days = (zeroTime + span).Day;
                //int dtDifferenceYear = DateTime.Today.Year - dtFromCivilID.Year;
                int dtDifferenceYear = (int)((DateTime.Now - dtFromCivilID).TotalDays / 365.242199);

                reg_basicinfoEntity oblist = await BFC.Core.FacadeCreatorObjects.General.reg_basicinfoFCC.GetFacadeCreate(_contextAccessor)
                .ValidateCivilIdPolicy(CivilId: message.validationParameter.CivilId, BatchId: message.validationParameter.BatchId, cancellationToken);

                if (oblist != null)
                {
                    VCRegistrationResponse objResponse = new VCRegistrationResponse(
                       new AjaxResponse("200", @CLL.LLClasses.Models._PreRegistrationResource.CivilIdExistingAlert, "false", "", "/Account/Login"),
                       false,
                       @CLL.LLClasses.Models._PreRegistrationResource.CivilIdExistingAlert);

                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.ValidationPolicy(objResponse);
                    return false;

                }
                else
                {
                    if (dtDifferenceYear >= 18 || (message.validationParameter.isSpecialRegistration != null && message.validationParameter.isSpecialRegistration == true))
                    {
                        gen_batchEntity selectedBatch = await BFC.Core.FacadeCreatorObjects.General.gen_batchFCC.GetFacadeCreate(_contextAccessor).
                            GetBatchById(new gen_batchEntity() { batchid = message.validationParameter.BatchId }, cancellationToken);

                        if (selectedBatch != null)
                        {
                            DateOnly batchStartDate = DateOnly.FromDateTime((System.DateTime)selectedBatch.startdate);
                            DateOnly batchEndDate = DateOnly.FromDateTime((System.DateTime)selectedBatch.enddate);
                            DateOnly todayDate = DateOnly.FromDateTime(DateTime.Now);

                            if ((selectedBatch.isactive == false || (batchStartDate > todayDate || batchEndDate < todayDate))
                                && message.validationParameter.isSpecialRegistration == false)
                            {
                                string messageStr = "التسجيل مغلق <br/> Registration is closed";
                                VCRegistrationResponse objResponse = new VCRegistrationResponse(new AjaxResponse("200", messageStr, "false", "Error", ""), false, messageStr);
                                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                                outputPort.ValidationPolicy(objResponse);
                                return false;
                            }
                            else if ((((dtDifferenceYear < selectedBatch.lowerage)
                                || ((years > selectedBatch.maxage) || (years == selectedBatch.maxage && (months > 0 || days > 0)))))
                              && message.validationParameter.isSpecialRegistration == false)
                            {
                                string messageStr = string.Empty;
                                if ((dtDifferenceYear < selectedBatch.lowerage))
                                {
                                    messageStr = "<span>العمر الأدنى للتسجيل " + selectedBatch.lowerage.ToString() + "<span/> <br/> Minimum age is " + selectedBatch.lowerage.ToString();
                                }
                                else if ((years > selectedBatch.maxage) || (years == selectedBatch.maxage && (months > 0 || days > 0)))
                                {
                                    messageStr = "<span>العمر الاقصى للتسجيل " + selectedBatch.maxage.ToString() + "<span/> <br/> Maximum age is " + selectedBatch.maxage.ToString();
                                }
                                VCRegistrationResponse objResponse = new VCRegistrationResponse(new AjaxResponse("200", messageStr, "false", "", ""), false, messageStr);
                                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                                outputPort.ValidationPolicy(objResponse);
                                return false;
                            }
                            else
                            {
                                var returnJson = new { civilId = message.validationParameter.CivilId, dob = dtStrFromCivilID };
                                VCRegistrationResponse objResponse = new VCRegistrationResponse(
                                    new AjaxResponse(returnJson),
                                    true);
                                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                                outputPort.ValidationPolicy(objResponse);
                                return true;
                            }
                        }
                        else
                        {
                            var returnJson = new { civilId = message.validationParameter.CivilId, dob = dtStrFromCivilID };
                            VCRegistrationResponse objResponse = new VCRegistrationResponse(
                                new AjaxResponse(returnJson),
                                true);
                            _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                            outputPort.ValidationPolicy(objResponse);
                            return true;
                        }
                    }
                    else
                    {
                        string messageStr = string.Empty;
                        messageStr = "<span>العمر الأدنى للتسجيل 18<span/> <br/> Minimum age is 18";
                        var objResponse = new VCRegistrationResponse(new AjaxResponse("200", messageStr, "false", "", ""), false, messageStr);
                        _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                        outputPort.ValidationPolicy(objResponse);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                var objResponse = new VCRegistrationResponse(
                        new AjaxResponse("200", "Invalid CivilId.",
                        CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleInformation, "/"
                    ), false, "Invalid CivilId.");

                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.ValidationPolicy(objResponse);
                return false;
            }
        }

        public async Task<bool> ValidateAgefromCivilId(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                //Age Calculation
                var firstch = message.validationParameter.CivilId.Substring(0, 1);
                string dtStrFromCivilIDTmp = message.validationParameter.CivilId.Substring(1, 6);
                var Year = dtStrFromCivilIDTmp.Substring(0, 2);
                if (firstch == "2")
                {
                    Year = "19" + Year;
                }
                else if (firstch == "3")
                {
                    Year = "20" + Year;
                }
                string dtStrFromCivilID = dtStrFromCivilIDTmp.Substring(4, 2) + "-" + dtStrFromCivilIDTmp.Substring(2, 2) + "-" + CultureInfo.CurrentCulture.Calendar.ToFourDigitYear(int.Parse(Year));
                DateTime dtFromCivilID = DateTime.ParseExact(dtStrFromCivilID, "dd-MM-yyyy", null);
                // Calculate the age.
                DateTime zeroTime = new DateTime(1, 1, 1);
                TimeSpan span = DateTime.Today - dtFromCivilID;
                int years = (zeroTime + span).Year - 1;
                int months = (zeroTime + span).Month - 1;
                int days = (zeroTime + span).Day;
                int dtDifferenceYear = (int)((DateTime.Now - dtFromCivilID).TotalDays / 365.242199);

                if (dtDifferenceYear >= 18 || (message.validationParameter.isSpecialRegistration != null && message.validationParameter.isSpecialRegistration == true))
                {
                    gen_batchEntity selectedBatch = await BFC.Core.FacadeCreatorObjects.General.gen_batchFCC.GetFacadeCreate(_contextAccessor).
                        GetBatchById(new gen_batchEntity() { batchid = message.validationParameter.BatchId }, cancellationToken);

                    if (selectedBatch != null)
                    {
                        DateOnly batchStartDate = DateOnly.FromDateTime((System.DateTime)selectedBatch.startdate);
                        DateOnly batchEndDate = DateOnly.FromDateTime((System.DateTime)selectedBatch.enddate);
                        DateOnly todayDate = DateOnly.FromDateTime(DateTime.Now);

                        bool isRollbackedFromAdmin = message.validationParameter.isRollbackedFromAdmin == true ? true : false;

                        if ((selectedBatch.isactive == false || (batchStartDate > todayDate || batchEndDate < todayDate))
                        && message.validationParameter.isSpecialRegistration == false
                        && isRollbackedFromAdmin == false)
                        {
                            string messageStr = "التسجيل مغلق <br/> Registration is closed";
                            VCRegistrationResponse objResponse = new VCRegistrationResponse(new AjaxResponse("200", messageStr, "false", "Error", ""), false, messageStr);
                            _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                            outputPort.ValidationPolicy(objResponse);
                            return false;
                        }
                        else if ((((dtDifferenceYear < selectedBatch.lowerage) ||
                          ((years > selectedBatch.maxage) || (years == selectedBatch.maxage && (months > 0 || days > 0)))))
                          && message.validationParameter.isSpecialRegistration == false
                          && isRollbackedFromAdmin == false)
                        {
                            string messageStr = string.Empty;
                            if ((dtDifferenceYear < selectedBatch.lowerage))
                            {
                                messageStr = "<span>العمر الأدنى للتسجيل " + selectedBatch.lowerage.ToString() + "<span/> <br/> Minimum age is " + selectedBatch.lowerage.ToString();
                            }
                            else if ((years > selectedBatch.maxage) || (years == selectedBatch.maxage && (months > 0 || days > 0)))
                            {
                                messageStr = "<span>العمر الاقصى للتسجيل " + selectedBatch.maxage.ToString() + "<span/> <br/> Maximum age is " + selectedBatch.maxage.ToString();
                            }
                            VCRegistrationResponse objResponse = new VCRegistrationResponse(new AjaxResponse("200", messageStr, "false", "", ""), false, messageStr);
                            _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                            outputPort.ValidationPolicy(objResponse);
                            return false;
                        }
                        else
                        {
                            var returnJson = new { civilId = message.validationParameter.CivilId, dob = dtStrFromCivilID };
                            VCRegistrationResponse objResponse = new VCRegistrationResponse(
                                new AjaxResponse(returnJson),
                                true);
                            _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                            outputPort.ValidationPolicy(objResponse);
                            return true;
                        }
                    }
                    else
                    {
                        var returnJson = new { civilId = message.validationParameter.CivilId, dob = dtStrFromCivilID };
                        VCRegistrationResponse objResponse = new VCRegistrationResponse(
                            new AjaxResponse(returnJson),
                            true);
                        _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                        outputPort.ValidationPolicy(objResponse);
                        return true;
                    }
                }
                else
                {
                    string messageStr = string.Empty;
                    messageStr = "<span>العمر الأدنى للتسجيل 18<span/> <br/> Minimum age is 18";
                    var objResponse = new VCRegistrationResponse(new AjaxResponse("200", messageStr, "false", "", ""), false, messageStr);
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.ValidationPolicy(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                var objResponse = new VCRegistrationResponse(
                        new AjaxResponse("200", "Invalid CivilId.",
                        CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleInformation, "/"
                    ), false, "Invalid CivilId.");

                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.ValidationPolicy(objResponse);
                return false;
            }
        }

        public async Task<bool> ValidateAgefromCivilIdAdmin(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                //Age Calculation
                var firstch = message.validationParameter.CivilId.Substring(0, 1);
                string dtStrFromCivilIDTmp = message.validationParameter.CivilId.Substring(1, 6);
                var Year = dtStrFromCivilIDTmp.Substring(0, 2);
                if (firstch == "2")
                {
                    Year = "19" + Year;
                }
                else if (firstch == "3")
                {
                    Year = "20" + Year;
                }
                string dtStrFromCivilID = dtStrFromCivilIDTmp.Substring(4, 2) + "-" + dtStrFromCivilIDTmp.Substring(2, 2) + "-" + CultureInfo.CurrentCulture.Calendar.ToFourDigitYear(int.Parse(Year));
                DateTime dtFromCivilID = DateTime.ParseExact(dtStrFromCivilID, "dd-MM-yyyy", null);
                // Calculate the age.
                DateTime zeroTime = new DateTime(1, 1, 1);
                TimeSpan span = DateTime.Today - dtFromCivilID;
                int years = (zeroTime + span).Year - 1;
                int months = (zeroTime + span).Month - 1;
                int days = (zeroTime + span).Day;
                int dtDifferenceYear = (int)((DateTime.Now - dtFromCivilID).TotalDays / 365.242199);

                if (dtDifferenceYear >= 18 || (message.validationParameter.isSpecialRegistration != null && message.validationParameter.isSpecialRegistration == true))
                {
                    gen_batchEntity selectedBatch = await BFC.Core.FacadeCreatorObjects.General.gen_batchFCC.GetFacadeCreate(_contextAccessor).
                    GetBatchById(new gen_batchEntity() { batchid = message.validationParameter.BatchId }, cancellationToken);

                    if (selectedBatch != null &&
                      (((dtDifferenceYear < selectedBatch.lowerage) ||
                      ((years > selectedBatch.maxage) || (years == selectedBatch.maxage && (months > 0 || days > 0)))))
                      && message.validationParameter.isSpecialRegistration == false)
                    {
                        string messageStr = string.Empty;
                        if ((dtDifferenceYear < selectedBatch.lowerage))
                        {
                            messageStr = "<span>العمر الأدنى للتسجيل " + selectedBatch.lowerage.ToString() + "<span/> <br/> Minimum age is " + selectedBatch.lowerage.ToString();
                        }
                        else if ((years > selectedBatch.maxage) || (years == selectedBatch.maxage && (months > 0 || days > 0)))
                        {
                            messageStr = "<span>العمر الاقصى للتسجيل " + selectedBatch.maxage.ToString() + "<span/> <br/> Maximum age is " + selectedBatch.maxage.ToString();
                        }
                        VCRegistrationResponse objResponse = new VCRegistrationResponse(new AjaxResponse("200", messageStr, "false", "", ""), false, messageStr);

                        _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                        outputPort.ValidationPolicy(objResponse);

                        return false;
                    }
                    else
                    {
                        var returnJson = new { civilId = message.validationParameter.CivilId, dob = dtStrFromCivilID };
                        VCRegistrationResponse objResponse = new VCRegistrationResponse(
                            new AjaxResponse(returnJson),
                            true);
                        _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                        outputPort.ValidationPolicy(objResponse);
                        return true;
                    }
                }
                else
                {
                    string messageStr = string.Empty;
                    messageStr = "<span>العمر الأدنى للتسجيل 18<span/> <br/> Minimum age is 18";
                    var objResponse = new VCRegistrationResponse(new AjaxResponse("200", messageStr, "false", "", ""), false, messageStr);
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.ValidationPolicy(objResponse);
                    return false;
                }

            }
            catch (Exception ex)
            {
                var objResponse = new VCRegistrationResponse(
                        new AjaxResponse("200", "Invalid CivilId.",
                        CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleInformation, "/"
                    ), false, "Invalid CivilId.");

                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.ValidationPolicy(objResponse);
                return false;
            }
        }

        public async Task<bool> ValidateCivilIdPolicyForSpecialRegistration(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                //Age Calculation
                var firstch = message.validationParameter.CivilId.Substring(0, 1);
                string dtStrFromCivilIDTmp = message.validationParameter.CivilId.Substring(1, 6);
                var Year = dtStrFromCivilIDTmp.Substring(0, 2);
                if (firstch == "2")
                {
                    Year = "19" + Year;
                }
                else if (firstch == "3")
                {
                    Year = "20" + Year;
                }
                string dtStrFromCivilID = dtStrFromCivilIDTmp.Substring(4, 2) + "-" + dtStrFromCivilIDTmp.Substring(2, 2) + "-" + CultureInfo.CurrentCulture.Calendar.ToFourDigitYear(int.Parse(Year));
                DateTime dtFromCivilID = DateTime.ParseExact(dtStrFromCivilID, "dd-MM-yyyy", null);

                // Calculate the age.
                DateTime zeroTime = new DateTime(1, 1, 1);
                TimeSpan span = DateTime.Today - dtFromCivilID;
                int years = (zeroTime + span).Year - 1;
                int months = (zeroTime + span).Month - 1;
                int days = (zeroTime + span).Day;
                int dtDifferenceYear = (int)((DateTime.Now - dtFromCivilID).TotalDays / 365.242199);

                if (dtDifferenceYear >= 18 || (message.validationParameter.isSpecialRegistration != null && message.validationParameter.isSpecialRegistration == true))
                {
                    var returnJson = new { civilId = message.validationParameter.CivilId, dob = dtStrFromCivilID };
                    VCRegistrationResponse objResponse = new VCRegistrationResponse(
                        new AjaxResponse(returnJson),
                        true);
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.ValidationPolicy(objResponse);
                    return true;
                }
                else
                {
                    string messageStr = string.Empty;
                    messageStr = "<span>العمر الأدنى للتسجيل 18<span/> <br/> Minimum age is 18";
                    var objResponse = new VCRegistrationResponse(new AjaxResponse("200", messageStr, "false", "", ""), false, messageStr);
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.ValidationPolicy(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                var objResponse = new VCRegistrationResponse(
                        new AjaxResponse("200", "Invalid CivilId.",
                        CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleInformation, "/"
                    ), false, "Invalid CivilId.");

                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.ValidationPolicy(objResponse);
                return false;
            }
        }

        #endregion

        #region Preregistration Action & Save

        public async Task<bool> CreateRegistrationUser(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                message.CreateUser.isanonymous = false;
                message.CreateUser.isapproved = true;
                message.CreateUser.locked = false;

                (string publicKey, string privateKey) rsaKey = Encipher.GenerateRSAKeyPair();
                message.CreateUser.masprivatekey = rsaKey.privateKey;
                message.CreateUser.maspublickey = rsaKey.publicKey;
                message.CreateUser.roleid = (long)ApplicationUserRoleEnum.User;// User

                message.CreateUser._applicationGlobalSettings = _applicationGlobalSettings;

                i = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.GetFacadeCreate(_contextAccessor)
                  .createuser(message.CreateUser, cancellationToken);


                if (i > 0)
                {
                    var objResponse = new VCRegistrationResponse(
                            new AjaxResponse("200", _sharedLocalizer["DATA_SAVE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/AccountVarification/AccountVerification?civilId=" + message.CreateUser.username),
                            true, null);
                    outputPort.SavePreRegistration(objResponse);
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    return true;
                }
                else
                {

                    var objResponse = new VCRegistrationResponse(
                         new AjaxResponse("500", _sharedLocalizer["DATA_SAVE_ERROR"].Value,
                         CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleGenericError, "/"
                     ), false, "");
                    outputPort.ValidationPolicy(objResponse);
                    _logger.LogWarning(JsonConvert.SerializeObject(objResponse));
                    return false;
                }
            }
            catch (Exception ex)
            {
                var objResponse = new VCRegistrationResponse(
                    new AjaxResponse("500", ex.Message,
                    CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleGenericError, "/"
                ), false, ex.Message);
                outputPort.ValidationPolicy(objResponse);
                _logger.LogError(JsonConvert.SerializeObject(objResponse));
                return false;


            }
        }

        public async Task<bool> CreateSpecialRegistrationUser(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                // Set Owin User data
                message.registrationViewModel.OwinUser.isanonymous = false;
                message.registrationViewModel.OwinUser.isapproved = true;
                message.registrationViewModel.OwinUser.locked = false;
                (string publicKey, string privateKey) rsaKey = Encipher.GenerateRSAKeyPair();
                message.registrationViewModel.OwinUser.masprivatekey = rsaKey.privateKey;
                message.registrationViewModel.OwinUser.maspublickey = rsaKey.publicKey;
                message.registrationViewModel.OwinUser.roleid = (long)ApplicationUserRoleEnum.User;// User
                message.registrationViewModel.OwinUser._applicationGlobalSettings = _applicationGlobalSettings;

                // Set Basic Info data
                message.registrationViewModel.BasicInfo.fullname = $"{message.registrationViewModel.BasicInfo.name1} {message.registrationViewModel.BasicInfo.name2} {message.registrationViewModel.BasicInfo.name3} {message.registrationViewModel.BasicInfo.name4} {message.registrationViewModel.BasicInfo.name5}";
                message.registrationViewModel.BasicInfo.CurrentState = BaseEntity.EntityState.Added;
                message.registrationViewModel.BasicInfo.civilid = message.registrationViewModel.OwinUser.username;

                //Set Additional Data 
                message.registrationViewModel.CurrentRegistration.CurrentState = BaseEntity.EntityState.Added;
                message.registrationViewModel.CurrentRegistration.isactive = true;
                message.registrationViewModel.CurrentRegistration.isfinal = false;
                message.registrationViewModel.CurrentRegistration.applicationdate = DateTime.Now;

                message.registrationViewModel.PaciServiceSettings = _kAFPaciServiceSettings;
                message.registrationViewModel._applicationGlobalSettings = _applicationGlobalSettings;

                i = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.GetFacadeCreate(_contextAccessor)
                  .createSpecialRegistrationUser(message.registrationViewModel, cancellationToken);

                if (i > 0)
                {
                    var objResponse = new VCRegistrationResponse(
                            new AjaxResponse("200", _sharedLocalizer["DATA_SAVE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/AccountVarification/AccountVerification?civilId=" + message.registrationViewModel.OwinUser.username),
                            true, null);
                    outputPort.SavePreRegistration(objResponse);
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    return true;
                }
                else
                {

                    var objResponse = new VCRegistrationResponse(
                         new AjaxResponse("500", _sharedLocalizer["DATA_SAVE_ERROR"].Value,
                         CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleGenericError, "/"
                     ), false, "");
                    outputPort.ValidationPolicy(objResponse);
                    _logger.LogWarning(JsonConvert.SerializeObject(objResponse));
                    return false;
                }
            }
            catch (Exception ex)
            {
                var objResponse = new VCRegistrationResponse(
                    new AjaxResponse("500", ex.Message,
                    CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleGenericError, "/"
                ), false, ex.Message);
                outputPort.ValidationPolicy(objResponse);
                _logger.LogError(JsonConvert.SerializeObject(objResponse));
                return false;


            }
        }

        public async Task<bool> SavePreRegistration(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                message.registrationViewModel._applicationGlobalSettings = _applicationGlobalSettings;

                i = await BFC.Core.FacadeCreatorObjects.General.reg_basicinfoFCC.GetFacadeCreate(_contextAccessor)
                    .SavePreRegistration(message.registrationViewModel, cancellationToken);

                if (i > 0)
                {

                    var objResponse = new VCRegistrationResponse(
                            new AjaxResponse("200", _sharedLocalizer["DATA_SAVE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/PostRegistration/PostRegistrationLanding"
                    ), true, null);
                    outputPort.SavePreRegistration(objResponse);
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    return true;
                }
                else
                {
                    var objResponse = new VCRegistrationResponse(
                         new AjaxResponse("500", _sharedLocalizer["DATA_SAVE_ERROR"].Value,
                         CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleGenericError, "/"
                     ), false, "");
                    outputPort.ValidationPolicy(objResponse);
                    _logger.LogWarning(JsonConvert.SerializeObject(objResponse));
                    return false;
                }
            }
            catch (Exception ex)
            {
                //if (message.registrationViewModel.BasicInfo.DocumentList != null)
                //{
                //    foreach (var basicDoc in message.registrationViewModel.BasicInfo.DocumentList)
                //    {
                //        fileuploadclient.DeleteFileFTP(basicDoc.foldercontentid, basicDoc.filename, basicDoc.extension);
                //    }
                //}
                bool datetimeerror = ex.Message.Contains("DateTime", StringComparison.OrdinalIgnoreCase);
                var objResponse = new VCRegistrationResponse(
                    new AjaxResponse("500", (datetimeerror == false ? ex.Message : _sharedLocalizer["DATE_TIME_ERROR"].Value),
                    CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleGenericError, "/"
                ), false, (datetimeerror == false ? ex.Message : _sharedLocalizer["DATE_TIME_ERROR"].Value));
                outputPort.ValidationPolicy(objResponse);
                _logger.LogError(JsonConvert.SerializeObject(objResponse));
                return false;


            }
        }

        public async Task<bool> SaveDocument(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                message.registrationViewModel._applicationGlobalSettings = _applicationGlobalSettings;

                //File Upload: Basic Profile
                bool allowFileUpload = await UploadDocument(message.registrationViewModel.strModelForigenKey, message.registrationViewModel.Documents);

                if (allowFileUpload)
                {
                    i = await BFC.Core.FacadeCreatorObjects.General.reg_studentfilestorageFCC.GetFacadeCreate(_contextAccessor)
                    .SaveList(message.registrationViewModel.Documents, cancellationToken);

                    var objResponse = new VCRegistrationResponse(
                            new AjaxResponse("200", _sharedLocalizer["DATA_SAVE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                    ), true, null);
                    outputPort.SaveDocument(objResponse);
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    return true;
                }
                else
                {
                    if (message.registrationViewModel.Documents != null)
                    {
                        foreach (var basicDoc in message.registrationViewModel.Documents)
                        {
                            fileuploadclient.DeleteFileFTP(basicDoc.foldercontentid, basicDoc.filename, basicDoc.extension);
                        }
                    }
                    var objResponse = new VCRegistrationResponse(false, _sharedLocalizer["FILE_FORMAT_NOT_SUPPORTED"].Value, new Error("415", _sharedLocalizer["FILE_FORMAT_NOT_SUPPORTED"].Value));
                    outputPort.SaveDocument(objResponse);
                    _logger.LogError(JsonConvert.SerializeObject(objResponse));
                    return false;
                }
            }
            catch (Exception ex)
            {
                if (message.registrationViewModel.Documents != null)
                {
                    foreach (var basicDoc in message.registrationViewModel.Documents)
                    {
                        fileuploadclient.DeleteFileFTP(basicDoc.foldercontentid, basicDoc.filename, basicDoc.extension);
                    }
                }

                var objResponse = new VCRegistrationResponse(
                    new AjaxResponse("500", ex.Message,
                    CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleGenericError, "/"
                ), false, ex.Message);
                outputPort.SaveDocument(objResponse);
                _logger.LogError(JsonConvert.SerializeObject(objResponse));
                return false;
            }
        }

        private async Task<bool> UploadDocument(string civilid, List<reg_studentfilestorageEntity> DocumentList)
        {

            try
            {
                if (DocumentList != null && DocumentList.Count > 0)
                {
                    bool allowFileUpload = true;
                    string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tiff", ".tif", ".pdf" };

                    foreach (var basicDoc in DocumentList.Where(q => q.CurrentState == BaseEntity.EntityState.Added || q.CurrentState == BaseEntity.EntityState.Changed))
                    {
                        if (!Array.Exists(imageExtensions, ext => ext.Equals(basicDoc.extension.ToLower(), StringComparison.OrdinalIgnoreCase)))
                        {
                            allowFileUpload = false;
                            break;
                        }
                    }

                    if (allowFileUpload)
                    {
                        var Document_FolderName = $"Document_{civilid}";
                        fileuploadclient.FolderCheckFTP(Document_FolderName);
                        foreach (var basicDoc in DocumentList.Where(q => q.CurrentState == BaseEntity.EntityState.Added))
                        {
                            basicDoc.foldercontentid = Document_FolderName;
                            basicDoc.filename = Guid.NewGuid().ToString("N").ToUpper();
                            basicDoc.filepath = fileuploadclient.UploadFileFTP(Convert.FromBase64String(basicDoc.base64file), Document_FolderName, basicDoc.filename, basicDoc.extension);
                        }
                        foreach (var basicDoc in DocumentList.Where(q => q.CurrentState == BaseEntity.EntityState.Deleted))
                        {
                            basicDoc.foldercontentid = Document_FolderName;
                            fileuploadclient.DeleteFileFTP(basicDoc.foldercontentid, basicDoc.filename, basicDoc.extension);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }



        #endregion

        #region Account Verification & Re-Sent Code
        public async Task<bool> AccountVarification(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            bool state = false;
            try
            {
                var Profile = await BFC.Core.FacadeCreatorObjects.Security.owin_userFCC.GetFacadeCreate(_contextAccessor).GetSingle(new owin_userEntity() { username = message.smsactivationcode.UserName }, cancellationToken);
                if (Profile.userid.HasValue)
                {

                    var ActivationCode = await BFC.Core.FacadeCreatorObjects.General.cnf_smsactivationcodeFCC.GetFacadeCreate(_contextAccessor).
                        CheckActivation(new BDO.Core.DataAccessObjects.Models.cnf_smsactivationcodeEntity() { UserName = message.smsactivationcode.UserName, smscode = message.smsactivationcode.smscode }, cancellationToken);
                    if (ActivationCode == null)
                    {
                        VCRegistrationResponse objResponse = new VCRegistrationResponse(
                         new AjaxResponse("200", _sharedLocalizer["ACCOUNT_VERIFIED"].Value, "success", "", "/Account/Login"),
                         true,
                         _sharedLocalizer["ACCOUNT_ACTIVE"].Value);
                        outputPort.ValidationPolicy(objResponse);

                        return false;
                    }
                    else
                    {
                        if (ActivationCode.smscode != message.smsactivationcode.smscode)
                        {
                            VCRegistrationResponse objResponse = new VCRegistrationResponse(
                            new AjaxResponse("200", _sharedLocalizer["PROVIDED_CODE_INCORRECT"].Value, "false", "", ""),
                            false,
                            _sharedLocalizer["PROVIDED_CODE_INCORRECT"].Value);
                            outputPort.ValidationPolicy(objResponse);
                            return false;
                        }
                        else
                        {
                            cnf_smsactivationtransectionEntity obj = new cnf_smsactivationtransectionEntity();
                            obj.smscodeid = ActivationCode.smscodeid;
                            obj.providedcode = message.smsactivationcode.smscode;
                            obj.issuccess = true;

                            obj.BaseSecurityParam = new SecurityCapsule();
                            var user = await _userManager.FindByNameAsync(message.smsactivationcode.UserName);
                            if (user != null)
                            {
                                obj.BaseSecurityParam.createdbyusername = Convert.ToString(user.userid);
                                obj.BaseSecurityParam.createddate = DateTime.Now;
                                transactioncodeGen objTranIDGen = new transactioncodeGen();
                                obj.BaseSecurityParam.transid = objTranIDGen.GetRandomAlphaNumericStringForTransactionActivity("TRAN", DateTime.Now);
                            }
                            long i = await BFC.Core.FacadeCreatorObjects.General.cnf_smsactivationtransectionFCC.GetFacadeCreate(this._contextAccessor).
                                AddExt(obj, cancellationToken);

                            if (i > 0)
                            {
                                VCRegistrationResponse objResponse = new VCRegistrationResponse(
                                new AjaxResponse("200", _sharedLocalizer["ACCOUNT_VERIFICATION_SUCCESSFUL"].Value, "success", "", "/Account/Login"),
                                true,
                                _sharedLocalizer["ACCOUNT_VERIFICATION_SUCCESSFUL"].Value);
                                outputPort.SaveVarification(objResponse);
                                return true;
                            }
                            else
                            {
                                VCRegistrationResponse objResponse = new VCRegistrationResponse(
                                new AjaxResponse("200", _sharedLocalizer["ACCOUNT_VERIFICATION_FAIL"].Value, "false", "", ""),
                                false,
                                _sharedLocalizer["ACCOUNT_VERIFICATION_FAIL"].Value);
                                outputPort.SaveVarification(objResponse);
                                return false;
                            }
                        }
                    }
                }
                else
                {
                    VCRegistrationResponse objResponse = new VCRegistrationResponse(
                               new AjaxResponse("200", _sharedLocalizer["INVALID_USER_INFO"].Value, "false", "", ""),
                               false,
                               _sharedLocalizer["INVALID_USER_INFO"].Value);
                    outputPort.SaveVarification(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(JsonConvert.SerializeObject(ex.Message));
                VCRegistrationResponse objResponse = new VCRegistrationResponse(
                                new AjaxResponse("200", "Oops. Error in System: " + ex.Message, "false", "", ""),
                                false,
                                "Oops. Error in System");
                outputPort.SaveVarification(objResponse);
                return false;
            }
        }

        public async Task<bool> ReSentVarificationCode(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            bool state = false;
            try
            {
                var Profile = await BFC.Core.FacadeCreatorObjects.Security.owin_userFCC.GetFacadeCreate(_contextAccessor).GetSingle(new owin_userEntity() { username = message.smsactivationcode.UserName }, cancellationToken);
                if (Profile.userid.HasValue)
                {
                    var ActivationCode = await BFC.Core.FacadeCreatorObjects.General.cnf_smsactivationcodeFCC.GetFacadeCreate(_contextAccessor).
                    CheckActivation(new BDO.Core.DataAccessObjects.Models.cnf_smsactivationcodeEntity() { UserName = message.smsactivationcode.UserName, smscode = message.smsactivationcode.smscode }, cancellationToken);
                    if (ActivationCode == null)
                    {
                        VCRegistrationResponse objResponse = new VCRegistrationResponse(
                         new AjaxResponse("500", _sharedLocalizer["ACCOUNT_VERIFIED"].Value, "false", "", "/Account/Login"),
                         false,
                         "");
                        outputPort.ValidationPolicy(objResponse);

                        return false;
                    }
                    else
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

                                        string html = System.IO.File.ReadAllText(System.IO.Path.Combine(Environment.CurrentDirectory, "EmailTemplate/AccountVarification" + Thread.CurrentThread.CurrentCulture.ToString().ToUpper() + ".html"));
                                        html.Replace("{currentdatetime}", DateTime.Now.ToString("dd-MM-yyyy"));
                                        html = html.Replace("{authocode}", Convert.ToString(ActivationCode.smscode));
                                        html = html.Replace("{resetpasswordurl}", _applicationGlobalSettings.Value.AccountVarificationURL + $"?civilId={Profile.username}");

                                        var NotificationBody = new
                                        {
                                            applicationid = _kAFPaciServiceSettings.ApplicationId,
                                            notificationrequestid = 0,
                                            recipientcivilid = Profile.username,
                                            recipientmobile = Profile.tempmob,
                                            recipientemail = Profile.emailaddress,

                                            msgsubject = "VC:Account Activation",
                                            msgsubjectar = "تفعيل حساب خدمة التوظيف التطوعي",

                                            msg = $"Your account activation code is {ActivationCode.smscode}",
                                            msgar = $"Your account activation code is {ActivationCode.smscode}",

                                            messagebodyemail = html,
                                            messagebodyemailar = html,

                                            sendsms = message.smsactivationcode.SendBySMS,
                                            senddigitalidnotification = message.smsactivationcode.SendByDigitalId,
                                            sendemail = message.smsactivationcode.SendByEmail
                                        };

                                        Shahilrequest.AddJsonBody(NotificationBody);
                                        var NotificationApiresponse = notificationClient.Execute(Shahilrequest);

                                    }
                                }
                            }
                        }
                        string Replymess = string.Empty;
                        if (message.smsactivationcode.SendBySMS)
                            Replymess = _sharedLocalizer["AccountActivationSMS"].Value;
                        else if (message.smsactivationcode.SendByDigitalId)
                            Replymess = _sharedLocalizer["AccountActivationDIGITAL"].Value;
                        else if (message.smsactivationcode.SendByEmail)
                            Replymess = _sharedLocalizer["AccountActivationEMAIL"].Value;

                        VCRegistrationResponse objResponse = new VCRegistrationResponse(
                            new AjaxResponse("200", Replymess, "success", "", "/AccountVarification/AccountVerification?civilId=" + message.smsactivationcode.UserName),
                            true,
                            "");
                        outputPort.SaveVarification(objResponse);
                        return true;
                    }
                }
                else
                {
                    VCRegistrationResponse objResponse = new VCRegistrationResponse(
                               new AjaxResponse("200", _sharedLocalizer["INVALID_USER_INFO"].Value, "false", "", ""),
                               false,
                               _sharedLocalizer["INVALID_USER_INFO"].Value);
                    outputPort.SaveVarification(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                VCRegistrationResponse objResponse = new VCRegistrationResponse(
                              new AjaxResponse("200", "Oops. Error in System: " + ex.Message, "false", "", ""),
                              false,
                              "Oops. Error in System");
                outputPort.SaveVarification(objResponse);
                return false;
            }
        }

        #endregion

        public async Task<bool> GetRegistrationByCivilId(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            bool state = false;
            try
            {
                var viewmodel = await BFC.Core.FacadeCreatorObjects.General.reg_basicinfoFCC.GetFacadeCreate(this._contextAccessor).
                    GetRegisteredApplicantProfileDataByCivilId(
                    new reg_basicinfoEntity()
                    {
                        civilid = message.CivilId,
                        email = message.email,
                        mob1 = message.mobileno
                    }, cancellationToken);

                if (viewmodel.Documents != null)
                {
                    foreach (var item in viewmodel.Documents)
                    {
                        item.FullFtpFilePath = $"{ftpServerSetting.ReadFileUrl}{item.filepath}";
                    }
                }

                var response = new VCRegistrationResponse(viewmodel, true);
                outputPort.GetSingleById(response);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(JsonConvert.SerializeObject(ex.Message));
                return false;
            }
        }

        public async Task<bool> GetRegistrationDetailsByCivilId(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            bool state = false;
            try
            {
                var viewmodel = await BFC.Core.FacadeCreatorObjects.General.reg_basicinfoFCC.GetFacadeCreate(this._contextAccessor).
                    GetRegistrationDetailsByCivilId(
                    new reg_basicinfoEntity()
                    {
                        civilid = message.CivilId
                    }, cancellationToken);

                var response = new VCRegistrationResponse(viewmodel, true);
                outputPort.GetSingleById(response);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(JsonConvert.SerializeObject(ex.Message));
                return false;
            }
        }

        public async Task<bool> GetRegistrationByCivilIdForDelete(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            bool state = false;
            try
            {
                var viewmodel = await BFC.Core.FacadeCreatorObjects.General.reg_basicinfoFCC.GetFacadeCreate(this._contextAccessor).
                    GetRegisteredApplicantProfileDataByCivilIdForDelete(
                    new reg_basicinfoEntity()
                    {
                        civilid = message.CivilId,
                        email = message.email,
                        mob1 = message.mobileno
                    }, cancellationToken);

                if (viewmodel.Documents != null)
                {
                    foreach (var item in viewmodel.Documents)
                    {
                        item.FullFtpFilePath = $"{ftpServerSetting.ReadFileUrl}{item.filepath}";
                    }
                }

                var response = new VCRegistrationResponse(viewmodel, true);
                outputPort.GetSingleById(response);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(JsonConvert.SerializeObject(ex.Message));
                return false;
            }
        }

        public async Task<bool> SubmitFinalRegistration(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                #region Validation
                var errormsg = "";

                var datastatuscheck = await BFC.Core.FacadeCreatorObjects.General.reg_basicinfoFCC.GetFacadeCreate(this._contextAccessor).
                    GetRegistrationDataInfoStatusCheck(new reg_basicinfoEntity() { basicinfoid = message.registrationViewModel.BasicInfo.basicinfoid }, cancellationToken);

                if (datastatuscheck.basicinfocount == 0)
                {
                    errormsg += _sharedLocalizer["BASIC_INFO"].Value;
                }
                if (datastatuscheck.educationinfocount == 0)
                {
                    if (!string.IsNullOrEmpty(errormsg))
                    {
                        errormsg += ", ";
                    }
                    errormsg += _sharedLocalizer["EDUCATION_INFO"].Value;
                }
                if (datastatuscheck.fatherinfocount == 0)
                {
                    if (!string.IsNullOrEmpty(errormsg))
                    {
                        errormsg += ", ";
                    }
                    errormsg += _sharedLocalizer["FATHER_INFO"].Value;
                }
                if (datastatuscheck.motherinfocount == 0)
                {
                    if (!string.IsNullOrEmpty(errormsg))
                    {
                        errormsg += ", ";
                    }
                    errormsg += _sharedLocalizer["MOTHER_INFO"].Value;
                }
                if (message.registrationViewModel.BasicInfo.maritalstatus == (long)MaritalStatusEnum.Married)
                {
                    if (datastatuscheck.wifeinfocount == 0)
                    {
                        if (!string.IsNullOrEmpty(errormsg))
                        {
                            errormsg += ", ";
                        }
                        errormsg += _sharedLocalizer["SPOUSE_INFO"].Value;
                    }
                }
                if (datastatuscheck.emmergencyinfocount == 0)
                {
                    if (!string.IsNullOrEmpty(errormsg))
                    {
                        errormsg += ", ";
                    }
                    errormsg += _sharedLocalizer["EMERGENCY_INFO"].Value;
                }
                if (datastatuscheck.documentinfostatus == false)
                {
                    if (!string.IsNullOrEmpty(errormsg))
                    {
                        errormsg += ", ";
                    }
                    errormsg += _sharedLocalizer["DOCUMENT_INFO"].Value;
                }
                if (!string.IsNullOrEmpty(errormsg))
                {
                    outputPort.ValidationPolicy(new VCRegistrationResponse(
                        new AjaxResponse("500", _sharedLocalizer["FAILED_TO_PROCESS"].Value + " " + errormsg + " " + _sharedLocalizer["NOT_FOUND"].Value,
                        CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleGenericError, "/"
                    ), false, ""));
                    return false;
                }
                #endregion

                i = await BFC.Core.FacadeCreatorObjects.General.reg_basicinfoFCC.GetFacadeCreate(_contextAccessor)
                    .SubmitFinalRegistration(message.registrationViewModel, cancellationToken);
                if (i > 0)
                {
                    var objResponse =
                        new VCRegistrationResponse(
                            new AjaxResponse("200", _sharedLocalizer["DATA_FINALSUBMIT_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/PostRegistration/PostRegistrationLanding"
                            , message.registrationViewModel.BasicInfo.civilid
                    ), true, null);
                    outputPort.SavePreRegistration(objResponse);
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));

                    return true;
                }
                else
                {
                    var objResponse = new VCRegistrationResponse(
                       new AjaxResponse("500", _sharedLocalizer["DATA_SAVE_ERROR"].Value,
                       CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleGenericError, "/"
                   ), false, "");
                    outputPort.ValidationPolicy(objResponse);
                    _logger.LogWarning(JsonConvert.SerializeObject(objResponse));
                    return false;
                }
            }
            catch (Exception ex)
            {
                var objResponse = new VCRegistrationResponse(
                        new AjaxResponse("500", ex.Message,
                        CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleGenericError, "/"
                    ), false, ex.Message);
                outputPort.ValidationPolicy(objResponse);
                _logger.LogError(JsonConvert.SerializeObject(objResponse));
                return false;


            }
        }

        public async Task<bool> ApplicantRequiredDataValidation(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                #region Validation
                var errormsg = "";

                var datastatuscheck = await BFC.Core.FacadeCreatorObjects.General.reg_basicinfoFCC.GetFacadeCreate(this._contextAccessor).
                    GetRegistrationDataInfoStatusCheck(new reg_basicinfoEntity() { basicinfoid = message.registrationViewModel.BasicInfo.basicinfoid }, cancellationToken);

                if (datastatuscheck.basicinfocount == 0)
                {
                    errormsg += _sharedLocalizer["BASIC_INFO"].Value;
                }
                if (datastatuscheck.educationinfocount == 0)
                {
                    if (!string.IsNullOrEmpty(errormsg))
                    {
                        errormsg += ", ";
                    }
                    errormsg += _sharedLocalizer["EDUCATION_INFO"].Value;
                }
                if (datastatuscheck.fatherinfocount == 0)
                {
                    if (!string.IsNullOrEmpty(errormsg))
                    {
                        errormsg += ", ";
                    }
                    errormsg += _sharedLocalizer["FATHER_INFO"].Value;
                }
                if (datastatuscheck.motherinfocount == 0)
                {
                    if (!string.IsNullOrEmpty(errormsg))
                    {
                        errormsg += ", ";
                    }
                    errormsg += _sharedLocalizer["MOTHER_INFO"].Value;
                }
                if (message.registrationViewModel.BasicInfo.maritalstatus == (long)MaritalStatusEnum.Married)
                {
                    if (datastatuscheck.wifeinfocount == 0)
                    {
                        if (!string.IsNullOrEmpty(errormsg))
                        {
                            errormsg += ", ";
                        }
                        errormsg += _sharedLocalizer["SPOUSE_INFO"].Value;
                    }
                }
                if (datastatuscheck.emmergencyinfocount == 0)
                {
                    if (!string.IsNullOrEmpty(errormsg))
                    {
                        errormsg += ", ";
                    }
                    errormsg += _sharedLocalizer["EMERGENCY_INFO"].Value;
                }
                if (datastatuscheck.documentinfostatus == false)
                {
                    if (!string.IsNullOrEmpty(errormsg))
                    {
                        errormsg += ", ";
                    }
                    errormsg += _sharedLocalizer["DOCUMENT_INFO"].Value;
                }
                if (!string.IsNullOrEmpty(errormsg))
                {
                    outputPort.ValidationPolicy(new VCRegistrationResponse(
                        new AjaxResponse("500", _sharedLocalizer["FAILED_TO_PROCESS"].Value + " " + errormsg + " " + _sharedLocalizer["NOT_FOUND"].Value,
                        CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleGenericError, "/"
                    ), false, ""));
                    return false;
                }
                return true;
                #endregion

            }
            catch (Exception ex)
            {
                var objResponse = new VCRegistrationResponse(
                        new AjaxResponse("500", ex.Message,
                        CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleGenericError, "/"
                    ), false, ex.Message);
                outputPort.ValidationPolicy(objResponse);
                _logger.LogError(JsonConvert.SerializeObject(objResponse));
                return false;


            }
        }

        public async Task<bool> RollbackFinalSubmit(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                #region Validation

                if (message.registrationViewModel.IsAllowToRollbak == false)
                {

                    outputPort.ValidationPolicy(new VCRegistrationResponse(
                           new AjaxResponse("500", "Failed to Rollback.",
                           CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleGenericError, "/"
                       ), false, ""));
                    return false;
                }

                #endregion

                i = await BFC.Core.FacadeCreatorObjects.General.reg_basicinfoFCC.GetFacadeCreate(_contextAccessor)
                    .RollbackFinalSubmit(message.registrationViewModel, cancellationToken);
                if (i > 0)
                {
                    outputPort.SavePreRegistration(
                        new VCRegistrationResponse(
                            new AjaxResponse("200", _sharedLocalizer["DATA_ROLLBACK_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/PostRegistration/PostRegistrationLanding"
                            , message.registrationViewModel.BasicInfo.civilid
                    ), true, null));

                    return true;
                }
                else
                {
                    outputPort.ValidationPolicy(new VCRegistrationResponse(
                       new AjaxResponse("500", _sharedLocalizer["DATA_SAVE_ERROR"].Value,
                       CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleGenericError, "/"
                   ), false, ""));
                    return false;
                }
            }
            catch (Exception ex)
            {
                outputPort.ValidationPolicy(new VCRegistrationResponse(
                        new AjaxResponse("500", ex.Message,
                        CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleGenericError, "/"
                    ), false, ex.Message));

                return false;


            }
        }

        public async Task<bool> GetRegistrationProfileDataWithDetailByBasicId(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            bool state = false;
            try
            {
                var viewmodel = await BFC.Core.FacadeCreatorObjects.General.reg_basicinfoFCC.GetFacadeCreate(this._contextAccessor).
                    GetRegistrationProfileDataWithDetailByBasicId(new reg_basicinfoEntity() { basicinfoid = message.BasicId, civilid = message.CivilId }, cancellationToken);
                var response = new VCRegistrationResponse(viewmodel, true);
                outputPort.GetReportProfile(response);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(JsonConvert.SerializeObject(ex.Message));
                return false;
            }
        }


        public async Task<bool> GetRegisteredApplicantCurrentBatchDataByBasicId(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            bool state = false;
            try
            {
                var viewmodel = await BFC.Core.FacadeCreatorObjects.General.reg_basicinfoFCC.GetFacadeCreate(this._contextAccessor).
                    GetRegisteredApplicantCurrentBatchDataByBasicId(new reg_basicinfoEntity() { basicinfoid = message.BasicId }, cancellationToken);
                var response = new VCRegistrationResponse(viewmodel, true);
                outputPort.GetSingleById(response);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(JsonConvert.SerializeObject(ex.Message));
                return false;
            }
        }


        public async Task<bool> RegisterAnotherBatchSave(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                message.registrationViewModel._applicationGlobalSettings = _applicationGlobalSettings;

                i = await BFC.Core.FacadeCreatorObjects.General.reg_basicinfoFCC.GetFacadeCreate(_contextAccessor)
                    .RegisterAnotherBatchSave(message.registrationViewModel, cancellationToken);

                if (i > 0)
                {
                    var objResponse = new VCRegistrationResponse(
                            new AjaxResponse("200", _sharedLocalizer["DATA_SAVE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/AccountVarification/AccountVerification?civilId=" + message.registrationViewModel.BasicInfo.civilid
                            , message.registrationViewModel.BasicInfo.civilid
                    ), true, null);
                    outputPort.SavePreRegistration(objResponse);
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    return true;
                }
                else
                {

                    var objResponse = new VCRegistrationResponse(
                         new AjaxResponse("500", _sharedLocalizer["DATA_SAVE_ERROR"].Value,
                         CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleGenericError, "/"
                     ), false, "");
                    outputPort.ValidationPolicy(objResponse);
                    _logger.LogWarning(JsonConvert.SerializeObject(objResponse));
                    return false;
                }
            }
            catch (Exception ex)
            {
                if (message.registrationViewModel.BasicInfo.DocumentList != null)
                {
                    foreach (var basicDoc in message.registrationViewModel.BasicInfo.DocumentList)
                    {
                        fileuploadclient.DeleteFileFTP(basicDoc.foldercontentid, basicDoc.filename, basicDoc.extension);
                    }
                }

                var objResponse = new VCRegistrationResponse(
                    new AjaxResponse("500", ex.Message,
                    CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleGenericError, "/"
                ), false, ex.Message);
                outputPort.ValidationPolicy(objResponse);
                _logger.LogError(JsonConvert.SerializeObject(objResponse));
                return false;


            }
        }

        public async Task<bool> getApplicationList(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            bool state = false;
            try
            {
                var viewmodel = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(this._contextAccessor).
                    getApplicationList(new reg_registrationinfoEntity()
                    {
                        batchidstring = message.batchidstring,
                        phaseid = message.phaseid,
                        candidatetypeid = message.candidatetypeid,
                        professionidstring = message.professionidstring,
                        nationalityid = message.nationalityid,
                        statusid = message.statusid
                    }, cancellationToken);
                var response = new VCRegistrationResponse(viewmodel, true);
                outputPort.GetReportProfile(response);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(JsonConvert.SerializeObject(ex.Message));
                return false;
            }
        }

        public async Task<bool> getApplicationStatus(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            bool state = false;
            try
            {
                var viewmodel = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(this._contextAccessor).
                    getApplicationStatus(new reg_registrationinfoEntity()
                    {
                        civilid = message.CivilId
                    }, cancellationToken);
                var response = new VCRegistrationResponse(viewmodel, true);
                outputPort.GetReportProfile(response);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(JsonConvert.SerializeObject(ex.Message));
                return false;
            }
        }

        public async Task<bool> getApplicationAssessmentList(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            bool state = false;
            try
            {
                var viewmodel = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(this._contextAccessor).
                    getApplicationAssessmentList(new reg_registrationinfoEntity()
                    {


                        candidatetypeid = message.candidatetypeid,
                        professionidstring = message.professionidstring,
                        batchidstring = message.batchidstring,
                        registrationfromdate = message.fromDate,
                        registrationtodate = message.toDate,


                    }, cancellationToken);
                var response = new VCRegistrationResponse(viewmodel, true);
                outputPort.GetReportProfile(response);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(JsonConvert.SerializeObject(ex.Message));
                return false;
            }
        }

        public async Task<bool> getApplicantAudit(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            bool state = false;
            try
            {
                var viewmodel = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(this._contextAccessor).
                    getApplicantAudit(new reg_registrationinfoEntity()

                    {
                        civilid = message.CivilId,




                    }, cancellationToken); ;
                var response = new VCRegistrationResponse(viewmodel, true);
                outputPort.GetReportProfile(response);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(JsonConvert.SerializeObject(ex.Message));
                return false;
            }
        }

        public async Task<bool> getApplicantAllDataBasic(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            bool state = false;
            try
            {
                var viewmodel = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(this._contextAccessor).
                    getApplicantAllDataBasic(new reg_registrationinfoEntity()

                    {
                        civilid = message.CivilId,




                    }, cancellationToken); ;
                var response = new VCRegistrationResponse(viewmodel, true);
                outputPort.GetReportProfile(response);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(JsonConvert.SerializeObject(ex.Message));
                return false;
            }
        }


        public async Task<bool> getApplicantSmsStatus(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            bool state = false;
            try
            {
                var viewmodel = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(this._contextAccessor).
                   getApplicantSmsStatus(new reg_registrationinfoEntity()

                   {
                       civilid = message.CivilId,
                       batchidstring = message.batchidstring,

                       candidatetypeid = message.candidatetypeid,
                       professionidstring = message.professionidstring,
                       smsSendDate = message.smsSendDate,
                       interviewdate = message.interViewDate,
                       notificationStatus = message.notificationstatus,



                   }, cancellationToken);
                var response = new VCRegistrationResponse(viewmodel, true);
                outputPort.GetReportProfile(response);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(JsonConvert.SerializeObject(ex.Message));
                return false;
            }
        }

        public async Task<bool> getMedicalExamForm(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            bool state = false;
            try
            {
                var viewmodel = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(this._contextAccessor).
                   getMedicalExamForm(new reg_registrationinfoEntity()

                   {
                       civilid = message.CivilId,



                   }, cancellationToken);
                var response = new VCRegistrationResponse(viewmodel, true);
                outputPort.GetReportProfile(response);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(JsonConvert.SerializeObject(ex.Message));
                return false;
            }
        }

        public async Task<bool> getMedicalExamReport(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            bool state = false;
            try
            {

                var viewmodel = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(this._contextAccessor).
                   getMedicalExamReport(new reg_registrationinfoEntity()

                   {
                       civilid = message.CivilId,



                   }, cancellationToken);
                var response = new VCRegistrationResponse(viewmodel, true);
                outputPort.GetReportProfile(response);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(JsonConvert.SerializeObject(ex.Message));
                return false;
            }
        }

        public async Task<bool> getVolunteerTestExtForm(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            bool state = false;
            try
            {
                var viewmodel = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(this._contextAccessor).
                   getVolunteerTestExtForm(new reg_registrationinfoEntity()

                   {
                       civilid = message.CivilId,



                   }, cancellationToken);
                var response = new VCRegistrationResponse(viewmodel, true);
                outputPort.GetReportProfile(response);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(JsonConvert.SerializeObject(ex.Message));
                return false;
            }
        }



        public async Task<bool> getBatchSummaryRpt(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            bool state = false;
            try
            {
                var viewmodel = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(this._contextAccessor).
                    getBatchSummaryRpt(new reg_registrationinfoEntity()
                    {


                        // candidatetypeid = message.candidatetypeid,
                        //professionidstring = message.professionidstring,
                        //batchidstring = message.batchidstring,
                        batchid = message.batchid,
                        registrationfromdate = message.fromDate,
                        registrationtodate = message.toDate,


                    }, cancellationToken);
                var response = new VCRegistrationResponse(viewmodel, true);
                outputPort.GetReportProfile(response);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(JsonConvert.SerializeObject(ex.Message));
                return false;
            }
        }


        public async Task<bool> getBatchSummaryDetail(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            bool state = false;
            try
            {
                var viewmodel = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(this._contextAccessor).
                    getBatchSummaryDetail(new reg_registrationinfoEntity()
                    {


                        candidatetypeid = message.candidatetypeid,
                        professionidstring = message.professionidstring,
                        batchidstring = message.batchidstring,
                        //batchid = message.batchid,
                        //registrationfromdate = message.fromDate,
                        //registrationtodate = message.toDate,


                    }, cancellationToken);
                var response = new VCRegistrationResponse(viewmodel, true);
                outputPort.GetReportProfile(response);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(JsonConvert.SerializeObject(ex.Message));
                return false;
            }
        }

        public async Task<bool> getVolunteerClearance(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            bool state = false;
            try
            {
                var viewmodel = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(this._contextAccessor).
                    getVolunteerClearance(new reg_registrationinfoEntity()
                    {


                        candidatetypeidstring = message.candidatetypeidstring,
                        professionidstring = message.professionidstring,
                        batchidstring = message.batchidstring,
                        nationalityid = message.nationalityid,
                        clearancetypeid = message.clearancetypeid,
                        clearancestatusid = message.clearancestatus,


                    }, cancellationToken);
                var response = new VCRegistrationResponse(viewmodel, true);
                outputPort.GetReportProfile(response);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(JsonConvert.SerializeObject(ex.Message));
                return false;
            }
        }


        public async Task<bool> getVolunteerExamLog(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            bool state = false;
            try
            {
                var viewmodel = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(this._contextAccessor).
                    getVolunteerExamLog(new reg_registrationinfoEntity()
                    {


                        candidatetypeidstring = message.candidatetypeidstring,
                        professionidstring = message.professionidstring,
                        batchidstring = message.batchidstring,
                        nationalityid = message.nationalityid,
                        clearancetypeid = message.clearancetypeid,
                        civilid = message.CivilId,


                    }, cancellationToken);
                var response = new VCRegistrationResponse(viewmodel, true);
                outputPort.GetReportProfile(response);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(JsonConvert.SerializeObject(ex.Message));
                return false;
            }
        }

        public async Task<bool> getVolunteerCertificateInfo(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            bool state = false;
            try
            {
                var viewmodel = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(this._contextAccessor).
                    getVolunteerCertificateInfo(new reg_registrationinfoEntity()
                    {


                        candidatetypeidstring = message.candidatetypeidstring,

                        batchidstring = message.batchidstring,
                        nationalityid = message.nationalityid,

                        civilid = message.CivilId,
                        CertificateLevelId = message.certificatelevelid,
                        certificateid = message.certificateID,
                        CertificateSubjectId = message.certificateSubjectID,
                        phaseid = message.phaseid




                    }, cancellationToken);
                var response = new VCRegistrationResponse(viewmodel, true);
                outputPort.GetReportProfile(response);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(JsonConvert.SerializeObject(ex.Message));
                return false;
            }
        }


        public async Task<bool> GetRegistrationByCivilIdforLogin(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            bool state = false;
            try
            {
                var viewmodel = await BFC.Core.FacadeCreatorObjects.General.reg_basicinfoFCC.GetFacadeCreate(this._contextAccessor).
                    GetRegisteredApplicantProfileDataByCivilId(
                    new reg_basicinfoEntity()
                    {
                        civilid = message.CivilId,
                        email = message.email,
                        mob1 = message.mobileno
                    }, cancellationToken);

                if (viewmodel != null)
                {
                    #region check sy exam result: Login not allowed for "Failed" and "Hold" status
                    if (viewmodel.CurrentRegistration.syexamresult == (int)SyExamResultEnum.NotAgree || viewmodel.CurrentRegistration.syexamresult == (int)SyExamResultEnum.Hold)
                    {
                        VCRegistrationResponse objResponse = new VCRegistrationResponse(
                         new AjaxResponse("200", _sharedLocalizer["CONATCT_TO_SECURITY_DEPT"].Value, "false", "", ""),
                         false,
                         _sharedLocalizer["CONATCT_TO_SECURITY_DEPT"].Value);
                        outputPort.AccountActivation(objResponse);
                        return false;
                    }
                    #endregion

                    #region check med and psycho exam result: Login not allowed for "Hold", "Absent", "Incomplete"
                    if (viewmodel.CurrentRegistration.medexamresult == (int)MedExamResultEnum.Hold
                        || viewmodel.CurrentRegistration.medexamresult == (int)MedExamResultEnum.Absent
                        || viewmodel.CurrentRegistration.medexamresult == (int)MedExamResultEnum.Incomplete
                        || viewmodel.CurrentRegistration.psychoexamresult == (int)PsychoExamResultEnum.Hold
                        || viewmodel.CurrentRegistration.psychoexamresult == (int)PsychoExamResultEnum.Absent
                        || viewmodel.CurrentRegistration.psychoexamresult == (int)PsychoExamResultEnum.Incomplete)
                    {
                        VCRegistrationResponse objResponse = new VCRegistrationResponse(
                         new AjaxResponse("200", _sharedLocalizer["CONATCT_TO_MEDICAL_DEPT"].Value, "false", "", ""),
                         false,
                         _sharedLocalizer["CONATCT_TO_MEDICAL_DEPT"].Value);
                        outputPort.AccountActivation(objResponse);
                        return false;
                    }
                    #endregion
                }
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(JsonConvert.SerializeObject(ex.Message));
                return false;
            }
        }

        public async Task<bool> getMedExaSmsStatus(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            bool state = false;
            try
            {
                var viewmodel = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(this._contextAccessor).
                   getMedExaSmsStatus(new reg_registrationinfoEntity()

                   {
                       civilid = message.CivilId,
                       batchidstring = message.batchidstring,

                       candidatetypeid = message.candidatetypeid,
                       professionidstring = message.professionidstring,
                       smsSendDate = message.smsSendDate,
                       interviewdate = message.interViewDate,
                       notificationStatus = message.notificationstatus,



                   }, cancellationToken);
                var response = new VCRegistrationResponse(viewmodel, true);
                outputPort.GetReportProfile(response);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(JsonConvert.SerializeObject(ex.Message));
                return false;
            }
        }

        public async Task<bool> getFinalExaSmsStatus(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            bool state = false;
            try
            {
                var viewmodel = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(this._contextAccessor).
                   getFinalExaSmsStatus(new reg_registrationinfoEntity()

                   {
                       civilid = message.CivilId,
                       batchidstring = message.batchidstring,

                       candidatetypeid = message.candidatetypeid,
                       professionidstring = message.professionidstring,
                       smsSendDate = message.smsSendDate,
                       interviewdate = message.interViewDate,
                       notificationStatus = message.notificationstatus,



                   }, cancellationToken);
                var response = new VCRegistrationResponse(viewmodel, true);
                outputPort.GetReportProfile(response);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(JsonConvert.SerializeObject(ex.Message));
                return false;
            }
        }



        public async Task<bool> getTrainingJoinSmsStatus(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            bool state = false;
            try
            {
                var viewmodel = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(this._contextAccessor).
                   getTrainingJoinSmsStatus(new reg_registrationinfoEntity()

                   {
                       civilid = message.CivilId,
                       batchidstring = message.batchidstring,

                       candidatetypeid = message.candidatetypeid,
                       professionidstring = message.professionidstring,
                       smsSendDate = message.smsSendDate,
                       interviewdate = message.interViewDate,
                       notificationStatus = message.notificationstatus,



                   }, cancellationToken);
                var response = new VCRegistrationResponse(viewmodel, true);
                outputPort.GetReportProfile(response);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(JsonConvert.SerializeObject(ex.Message));
                return false;
            }
        }



        public async Task<bool> getVolunteerContract(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            bool state = false;
            try
            {
                var viewmodel = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(this._contextAccessor).
                   getVolunteerContract(new reg_registrationinfoEntity()

                   {
                       civilid = message.CivilId,
                       batchidstring = message.batchidstring,
                       basicinfoids = message.basicinfoidstring
                       //candidatetypeid = message.candidatetypeid,
                       //professionidstring = message.professionidstring,
                       //smsSendDate = message.smsSendDate,
                       //interviewdate = message.interViewDate,
                       //notificationStatus = message.notificationstatus,



                   }, cancellationToken);
                var response = new VCRegistrationResponse(viewmodel, true);
                outputPort.GetReportProfile(response);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(JsonConvert.SerializeObject(ex.Message));
                return false;
            }
        }

    }
}