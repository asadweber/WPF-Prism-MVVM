using AppConfig.HelperClasses;
using BDO.Core.Base;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.DataAccessObjects.VCApplicantReview;
using CLL.Localization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Dto.UseCaseRequests.Registration;
using Web.Core.Frame.Dto.UseCaseRequests.Transaction;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.Dto.UseCaseResponses.Transaction;
using Web.Core.Frame.Helpers;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.Interfaces.Services;
using Web.Core.Frame.Interfaces.UseCases.Transaction;

namespace Web.Core.Frame.UseCases.Transaction
{
    public sealed partial class VCApplicantReviewUseCase : IVCApplicantReviewUseCase
    {
        private readonly FtpServerSetting ftpServerSetting;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IJwtFactory _jwtFactory;
        private readonly IStringLocalizer _sharedLocalizer;
        private readonly ILogger<VCApplicantReviewUseCase> _logger;
        private dataTableButtonPanel objDTBtnPanel = new dataTableButtonPanel();
        private readonly IOptions<ApplicationGlobalSettings> _applicationGlobalSettings;
        private readonly IFileUploadClient fileuploadclient;
        public Error _errors { get; set; }

        public VCApplicantReviewUseCase(
            IHttpContextAccessor contextAccessor,
            IJwtFactory jwtFactory,
            IStringLocalizerFactory factory,
            ILoggerFactory loggerFactory,
            IOptions<FtpServerSetting> ftpServerSetting,
            IOptions<ApplicationGlobalSettings> applicationGlobalSettings,
            IFileUploadClient fileuploadclient
            )
        {
            _contextAccessor = contextAccessor;
            _jwtFactory = jwtFactory;
            _logger = loggerFactory.CreateLogger<VCApplicantReviewUseCase>();

            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _sharedLocalizer = factory.Create("SharedResource", assemblyName.Name);
            this.ftpServerSetting = ftpServerSetting.Value;
            _applicationGlobalSettings = applicationGlobalSettings;
            this.fileuploadclient = fileuploadclient;
        }

        public Task<bool> Handle(VCApplicantReviewRequest message, IOutputPort<VCApplicantReviewResponse> outputPort)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> GetApplicantDetailsByRegistrationIDForReview(VCApplicantReviewRequest message, IVCApplicantReviewRequestHandler<VCApplicantReviewResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                ApplicantReviewViewModel viewmodel = new ApplicantReviewViewModel();
                viewmodel = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetApplicantDetailsByRegistrationIDForReview(new reg_registrationinfoEntity() { registrationid = message.RegistrationID }, cancellationToken);

                var response = new VCApplicantReviewResponse(viewmodel, true);
                outputPort.GetApplicantDetailsForReview(response);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(JsonConvert.SerializeObject(ex.Message));
                return false;
            }
        }

        public async Task<bool> GetRegistrationByBasicInfoId(VCApplicantReviewRequest message, IVCApplicantReviewRequestHandler<VCApplicantReviewResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            bool state = false;
            try
            {
                ApplicantReviewViewModel viewmodel = new ApplicantReviewViewModel();
                viewmodel = await BFC.Core.FacadeCreatorObjects.General.reg_basicinfoFCC.GetFacadeCreate(this._contextAccessor).
                    GetRegisteredApplicantProfileDataByBasicInfoId(new reg_basicinfoEntity() { basicinfoid = message.BasicInfoID, ApplicantTableID = message.ApplicantTableID }, cancellationToken);

                //if (viewmodel.Documents != null)
                //{
                //    foreach (var item in viewmodel.Documents)
                //    {
                //        item.FullFtpFilePath = $"{ftpServerSetting.ReadFileUrl}{item.filepath}";
                //    }
                //}

                var response = new VCApplicantReviewResponse(viewmodel, true);
                outputPort.GetRegisteredApplicantProfileDataByBasicInfoId(response);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(JsonConvert.SerializeObject(ex.Message));
                return false;
            }
        }

        public async Task<bool> ValidateMobileNumber(VCApplicantReviewRequest message, IVCApplicantReviewRequestHandler<VCApplicantReviewResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                var MobileNumber = message.validationParameter.MobileNumber;
                var BatchId = message.validationParameter.BatchId;

                reg_basicinfoEntity oblist = await BFC.Core.FacadeCreatorObjects.General.reg_basicinfoFCC.GetFacadeCreate(_contextAccessor)
                .ValidateMobileNumber(new reg_basicinfoEntity() { mob1 = MobileNumber, BatchID = BatchId }, cancellationToken);

                if (oblist != null)
                {
                    VCApplicantReviewResponse objResponse = new VCApplicantReviewResponse(
                       new AjaxResponse("200", @CLL.LLClasses.Models._PreRegistrationResource.MobileNumberExistsErrorMsg, "false", "", ""),
                       false,
                       @CLL.LLClasses.Models._PreRegistrationResource.MobileNumberExistsErrorMsg);

                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.ValidationPolicy(objResponse);
                    return false;

                }
                else
                {
                    VCApplicantReviewResponse objResponse = new VCApplicantReviewResponse(
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
                VCApplicantReviewResponse objResponse = new VCApplicantReviewResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.ValidationPolicy(objResponse);
                return false;
            }
        }

        public async Task<bool> ValidateEmailAddress(VCApplicantReviewRequest message, IVCApplicantReviewRequestHandler<VCApplicantReviewResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                var EmailAddress = message.validationParameter.EmailAddress;
                var BatchId = message.validationParameter.BatchId;


                reg_basicinfoEntity oblist = await BFC.Core.FacadeCreatorObjects.General.reg_basicinfoFCC.GetFacadeCreate(_contextAccessor)
                .ValidateEmailAddress(new reg_basicinfoEntity() { email = EmailAddress, BatchID = BatchId }, cancellationToken);

                if (oblist != null)
                {
                    VCApplicantReviewResponse objResponse = new VCApplicantReviewResponse(
                       new AjaxResponse("200", @CLL.LLClasses.Models._PreRegistrationResource.EmailExistsErrorMsg, "false", "", ""),
                       false,
                       @CLL.LLClasses.Models._PreRegistrationResource.EmailExistsErrorMsg);

                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.ValidationPolicy(objResponse);
                    return false;

                }
                else
                {
                    VCApplicantReviewResponse objResponse = new VCApplicantReviewResponse(
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
                VCApplicantReviewResponse objResponse = new VCApplicantReviewResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.ValidationPolicy(objResponse);
                return false;
            }
        }

        public async Task<bool> SaveApplicantReviewBasicInfo(VCApplicantReviewRequest message, IVCApplicantReviewRequestHandler<VCApplicantReviewResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                message.applicantreviewViewModel._applicationGlobalSettings = _applicationGlobalSettings;

                //File Upload: Basic Profile
                //if (message.applicantreviewViewModel.BasicInfo.DocumentList != null && message.applicantreviewViewModel.BasicInfo.DocumentList.Count > 0)
                //{
                //    var Document_FolderName = $"Document_{message.applicantreviewViewModel.BasicInfo.civilid}";
                //    fileuploadclient.FolderCheckFTP(Document_FolderName);
                //    foreach (var basicDoc in message.applicantreviewViewModel.BasicInfo.DocumentList.Where(q => q.CurrentState == BaseEntity.EntityState.Added))
                //    {
                //        basicDoc.foldercontentid = Document_FolderName;
                //        basicDoc.filename = Guid.NewGuid().ToString("N").ToUpper();
                //        basicDoc.filepath = fileuploadclient.UploadFileFTP(Convert.FromBase64String(basicDoc.base64file), Document_FolderName, basicDoc.filename, basicDoc.extension);
                //    }
                //    foreach (var basicDoc in message.applicantreviewViewModel.BasicInfo.DocumentList.Where(q => q.CurrentState == BaseEntity.EntityState.Deleted))
                //    {
                //        fileuploadclient.DeleteFileFTP(basicDoc.foldercontentid, basicDoc.filename, basicDoc.extension);
                //    }
                //}

                i = await BFC.Core.FacadeCreatorObjects.General.reg_basicinfoFCC.GetFacadeCreate(_contextAccessor)
                    .SaveApplicantReviewBasicInfo(message.applicantreviewViewModel, cancellationToken);

                if (i > 0)
                {
                    clsPrivateKeys objClsPrivate = new clsPrivateKeys();
                    var encryptedbasicinfoid = objClsPrivate.EncodeUrlOnlyParams("basicinfoid", message.applicantreviewViewModel.BasicInfo.basicinfoid.ToString());
                    var objResponse = new VCApplicantReviewResponse(
                            new AjaxResponse("200", _sharedLocalizer["DATA_SAVE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/BasicInfo/LandingBasicInfo?params=" + encryptedbasicinfoid
                    //, message.applicantreviewViewModel.BasicInfo.basicinfoid
                    ), true, null);
                    outputPort.SaveApplicantReviewData(objResponse);
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    return true;
                }
                else
                {

                    var objResponse = new VCApplicantReviewResponse(
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
                if (message.applicantreviewViewModel.BasicInfo.DocumentList != null)
                {
                    foreach (var basicDoc in message.applicantreviewViewModel.BasicInfo.DocumentList)
                    {
                        fileuploadclient.DeleteFileFTP(basicDoc.foldercontentid, basicDoc.filename, basicDoc.extension);
                    }
                }

                bool datetimeerror = ex.Message.Contains("DateTime", StringComparison.OrdinalIgnoreCase);

                var objResponse = new VCApplicantReviewResponse(
                    new AjaxResponse("500", (datetimeerror == false ? ex.Message : _sharedLocalizer["DATE_TIME_ERROR"].Value),
                    CLL.LLClasses._Status._statusFailed, CLL.LLClasses._Status._titleGenericError, "/"
                ), false, (datetimeerror == false ? ex.Message : _sharedLocalizer["DATE_TIME_ERROR"].Value));
                outputPort.ValidationPolicy(objResponse);
                _logger.LogError(JsonConvert.SerializeObject(objResponse));
                return false;
            }
        }

        public async Task<bool> SaveDocument(VCApplicantReviewRequest message, IVCApplicantReviewRequestHandler<VCApplicantReviewResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                message.applicantreviewViewModel._applicationGlobalSettings = _applicationGlobalSettings;

                //File Upload: Basic Profile
                bool allowFileUpload = await UploadDocument(message.applicantreviewViewModel.strModelForigenKey, message.applicantreviewViewModel.Documents);

                if (allowFileUpload)
                {
                    i = await BFC.Core.FacadeCreatorObjects.General.reg_studentfilestorageFCC.GetFacadeCreate(_contextAccessor)
                    .SaveList(message.applicantreviewViewModel.Documents, cancellationToken);

                    var objResponse = new VCApplicantReviewResponse(
                            new AjaxResponse("200", _sharedLocalizer["DATA_SAVE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                    ), true, null);
                    outputPort.SaveDocument(objResponse);
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    return true;
                }
                else
                {
                    if (message.applicantreviewViewModel.Documents != null)
                    {
                        foreach (var basicDoc in message.applicantreviewViewModel.Documents)
                        {
                            fileuploadclient.DeleteFileFTP(basicDoc.foldercontentid, basicDoc.filename, basicDoc.extension);
                        }
                    }
                    var objResponse = new VCApplicantReviewResponse(false, _sharedLocalizer["FILE_FORMAT_NOT_SUPPORTED"].Value, new Error("415", _sharedLocalizer["FILE_FORMAT_NOT_SUPPORTED"].Value));
                    outputPort.SaveDocument(objResponse);
                    _logger.LogError(JsonConvert.SerializeObject(objResponse));
                    return false;
                }

            }
            catch (Exception ex)
            {
                if (message.applicantreviewViewModel.Documents != null)
                {
                    foreach (var basicDoc in message.applicantreviewViewModel.Documents)
                    {
                        fileuploadclient.DeleteFileFTP(basicDoc.foldercontentid, basicDoc.filename, basicDoc.extension);
                    }
                }
                var objResponse = new VCApplicantReviewResponse(
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
            try {
                if (DocumentList != null && DocumentList.Count > 0)
                {
                    bool allowFileUpload = true;
                    string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tiff", ".tif", ".pdf" };

                    foreach (var basicDoc in DocumentList.Where(q => q.CurrentState == BaseEntity.EntityState.Added || q.CurrentState == BaseEntity.EntityState.Changed))
                    {
                        if (!Array.Exists(imageExtensions, ext => ext.Equals(basicDoc.extension.ToLower(), StringComparison.OrdinalIgnoreCase)))
                        {
                            //throw new Exception("File not allowed");
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

    }
}
