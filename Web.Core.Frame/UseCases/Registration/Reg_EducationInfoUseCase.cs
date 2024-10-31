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
using Microsoft.Extensions.Options;
using BDO.Core.Base;

namespace Web.Core.Frame.UseCases.Registration
{
    public sealed partial class Reg_EducationInfoUseCase : IReg_EducationInfoUseCase
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IJwtFactory _jwtFactory;
        private readonly IStringLocalizer _sharedLocalizer;
        private readonly ILogger<Reg_EducationInfoUseCase> _logger;
        private dataTableButtonPanel objDTBtnPanel = new dataTableButtonPanel();
        public Error _errors { get; set; }

        private readonly IFileUploadClient fileuploadclient;
        private readonly FtpServerSetting ftpServerSetting;
        public Reg_EducationInfoUseCase(
            IHttpContextAccessor contextAccessor,
            IJwtFactory jwtFactory,
            IStringLocalizerFactory factory,
            ILoggerFactory loggerFactory,
             IFileUploadClient fileuploadclient,
            IOptions<FtpServerSetting> ftpServerSetting)
        {
            _contextAccessor = contextAccessor;
            _jwtFactory = jwtFactory;
            _logger = loggerFactory.CreateLogger<Reg_EducationInfoUseCase>();

            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _sharedLocalizer = factory.Create("SharedResource", assemblyName.Name);
            this.ftpServerSetting = ftpServerSetting.Value;
            this.fileuploadclient = fileuploadclient;
        }

        public Task<bool> Handle(Reg_EducationInfoRequest message, IOutputPort<Reg_EducationInfoResponse> outputPort)
        {
            throw new Exception("Not Implemented");
        }

        public async Task<bool> GetAll(Reg_EducationInfoRequest message, ICRUDRequestHandler<Reg_EducationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<reg_educationinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_educationinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetAll(message.Objreg_educationinfo, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAll(new Reg_EducationInfoResponse(oblist.ToList(), true));
                    return true;
                }
                else
                {
                    Reg_EducationInfoResponse objResponse = new Reg_EducationInfoResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAll(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_EducationInfoResponse objResponse = new Reg_EducationInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAll(objResponse);
                return true;
            }
        }

        public async Task<bool> GetAllPaged(Reg_EducationInfoRequest message, ICRUDRequestHandler<Reg_EducationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<reg_educationinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_educationinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetAllByPages(message.Objreg_educationinfo, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAllPaged(new Reg_EducationInfoResponse(oblist.ToList(), true));
                    return true;
                }
                else
                {
                    Reg_EducationInfoResponse objResponse = new Reg_EducationInfoResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAllPaged(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_EducationInfoResponse objResponse = new Reg_EducationInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAllPaged(objResponse);
                return true;
            }
        }

        public async Task<bool> GetListView(Reg_EducationInfoRequest message, ICRUDRequestHandler<Reg_EducationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<reg_educationinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_educationinfoFCC.GetFacadeCreate(_contextAccessor)
                .GAPgListView(message.Objreg_educationinfo, cancellationToken);
                if (oblist != null && oblist.Count > 0)
                {
                    List<dataTableButtonModel> btnActionList = new List<dataTableButtonModel>();
                    //btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.New_GET));
                    btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.Edit_GET));
                    btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.Delete_GET));
                    btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.GetSingle_GET));
                    //btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.CUSTOM, _sharedLocalizer["PROCESS"], "StpOrganizationEntity/userprocess"));
                    //btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.CUSTOM, _sharedLocalizer["SEARCH"], "StpOrganizationEntity/usersearch"));

                    var data = (from t in oblist
                                select new
                                {
                                    t.educationid,
                                    t.basicinfoid,
                                    t.certificateid,
                                    t.certificatesubjectid,
                                    t.educationshiftid,
                                    t.edugradeid,
                                    t.edumajorid,
                                    t.instituteid,
                                    t.countryid,
                                    t.passyear,
                                    t.ispercentage,
                                    t.points,
                                    t.grade,
                                    t.institutename,
                                    t.isstudying,
                                    t.newinstituteid,
                                    t.semestername,
                                    t.filepath,
                                    t.filename,
                                    t.filetype,
                                    t.extension,
                                    t.comment,
                                    t.remarks,
                                    t.updateinfo,
                                    t.tranformactionid,
                                    datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objreg_educationinfo.ControllerName, t.educationid, "educationid", _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList,this._contextAccessor)
                                }).ToList();

                    outputPort.GetListView(new Reg_EducationInfoResponse(new AjaxResponse(oblist[0].RETURN_KEY, data), true, null));
                    return true;
                }
                else
                {
                    Reg_EducationInfoResponse objResponse = new Reg_EducationInfoResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                        "404",
                        _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetListView(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_EducationInfoResponse objResponse = new Reg_EducationInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetSingle(Reg_EducationInfoRequest message, ICRUDRequestHandler<Reg_EducationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                reg_educationinfoEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.reg_educationinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetSingle(message.Objreg_educationinfo, cancellationToken);
                if (objSingle != null)
                {
                    outputPort.GetSingle(new Reg_EducationInfoResponse(objSingle, true));
                    return true;
                }
                else
                {
                    Reg_EducationInfoResponse objResponse = new Reg_EducationInfoResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_EducationInfoResponse objResponse = new Reg_EducationInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }

        public async Task<bool> Save(Reg_EducationInfoRequest message, ICRUDRequestHandler<Reg_EducationInfoResponse> outputPort)
        {
            _logger.LogInformation(JsonConvert.SerializeObject(message));
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                //File Upload: Basic Profile
                if (message.Objreg_educationinfo.CertificateDocuments!= null)
                {
                    var Document_FolderName = $"Document_{message.Objreg_educationinfo.civilid}";
                    fileuploadclient.FolderCheckFTP(Document_FolderName);
                    foreach (var basicDoc in message.Objreg_educationinfo.CertificateDocuments.Where(q => q.CurrentState == BaseEntity.EntityState.Added))
                    {
                        basicDoc.foldercontentid = Document_FolderName;
                        basicDoc.filepath = fileuploadclient.UploadFileFTP(Convert.FromBase64String(basicDoc.base64file), Document_FolderName, basicDoc.filename, basicDoc.extension);
                    }
                    foreach (var basicDoc in message.Objreg_educationinfo.CertificateDocuments.Where(q => q.CurrentState == BaseEntity.EntityState.Deleted))
                    {
                        fileuploadclient.DeleteFileFTP(basicDoc.foldercontentid, basicDoc.filename, basicDoc.extension);
                    }
                }

                i = await BFC.Core.FacadeCreatorObjects.General.reg_educationinfoFCC.GetFacadeCreate(_contextAccessor)
                    .Add(message.Objreg_educationinfo, cancellationToken);

                outputPort.Save(new Reg_EducationInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_SAVE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_EducationInfoResponse objResponse = new Reg_EducationInfoResponse(false, _sharedLocalizer["DATA_SAVE_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Save(objResponse);
                return true;
            }
        }

        public async Task<bool> Update(Reg_EducationInfoRequest message, ICRUDRequestHandler<Reg_EducationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.reg_educationinfoFCC.GetFacadeCreate(_contextAccessor)
                    .Update(message.Objreg_educationinfo, cancellationToken);

                outputPort.Update(new Reg_EducationInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_EducationInfoResponse objResponse = new Reg_EducationInfoResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> Delete(Reg_EducationInfoRequest message, ICRUDRequestHandler<Reg_EducationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.reg_educationinfoFCC.GetFacadeCreate(_contextAccessor)
                    .Delete(message.Objreg_educationinfo, cancellationToken);
                outputPort.Delete(new Reg_EducationInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_DELETE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                       ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_EducationInfoResponse objResponse = new Reg_EducationInfoResponse(false, _sharedLocalizer["DATA_DELETE_ERROR"], new Error(
                         "500",
                         ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Delete(objResponse);
                return true;
            }
        }





    }
}