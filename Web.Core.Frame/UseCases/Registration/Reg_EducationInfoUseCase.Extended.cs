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
using Web.Core.Frame.Dto;
using AppConfig.HelperClasses;
using Web.Core.Frame.Helpers;
using System.Security.Claims;
using static AppConfig.HelperClasses.applicationEnamNConstants;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces.UseCases.Registration;
using Web.Core.Frame.Dto.UseCaseRequests.Registration;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using System.Reflection.Metadata;
using BDO.Core.Base;

namespace Web.Core.Frame.UseCases.Registration
{
    public sealed partial class Reg_EducationInfoUseCase : IReg_EducationInfoUseCase
    {

        public async Task<bool> GetListViewByBasicId(Reg_EducationInfoRequest message, ICRUDRequestHandler<Reg_EducationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<reg_educationinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_educationinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetAllByBasicInfoID(message.Objreg_educationinfo, cancellationToken);

                List<dataTableButtonModel> btnActionList = new List<dataTableButtonModel>();
                var edit = new dataTableButtonModel(basicCRUDButtons.Edit_GET);
                edit.isCheckPermission = false;
                edit.JsMethodName = "EditEducation";

                var delete = new dataTableButtonModel(basicCRUDButtons.Delete_GET);
                delete.isCheckPermission = false;
                delete.JsMethodName = "DeleteEducation";

                btnActionList.Add(edit);
                btnActionList.Add(delete);


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
                                t.CertificateLevel,
                                t.CertificateName,
                                t.CertificateSubjectName,
                                datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objreg_educationinfo.ControllerName, t.educationid, GlobalConstant.EducationId, _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList, this._contextAccessor)
                            }).ToList();

                outputPort.GetListView(new Reg_EducationInfoResponse(new AjaxResponse(oblist.Count>0? oblist[0].RETURN_KEY:0, data), true, null));
                return true;
                //}
                //else
                //{
                //    Reg_EducationInfoResponse objResponse = new Reg_EducationInfoResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                //        "404",
                //        _sharedLocalizer["NO_DATA_FOUND"]));
                //    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                //    outputPort.GetListView(objResponse);
                //    return false;
                //}
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
        public async Task<bool> GetSingleById(Reg_EducationInfoRequest message, ICRUDRequestHandler<Reg_EducationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                reg_educationinfoEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.reg_educationinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetSingleById(message.Objreg_educationinfo, cancellationToken);
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


        public async Task<bool> SaveOrUpdate(Reg_EducationInfoRequest message, ICRUDRequestHandler<Reg_EducationInfoResponse> outputPort)
        {
            _logger.LogInformation(JsonConvert.SerializeObject(message));
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                //File Upload: Basic Profile
                if (message.Objreg_educationinfo.CertificateDocuments != null)
                {
                    var Document_FolderName = $"Document_{message.Objreg_educationinfo.civilid}";
                    fileuploadclient.FolderCheckFTP(Document_FolderName);
                    foreach (var basicDoc in message.Objreg_educationinfo.CertificateDocuments.Where(q => q.CurrentState == BaseEntity.EntityState.Added))
                    {
                        basicDoc.foldercontentid = Document_FolderName;
                        basicDoc.filename= Guid.NewGuid().ToString("N").ToUpper();
                        basicDoc.filepath = fileuploadclient.UploadFileFTP(Convert.FromBase64String(basicDoc.base64file), Document_FolderName, basicDoc.filename, basicDoc.extension);
                    }
                    foreach (var basicDoc in message.Objreg_educationinfo.CertificateDocuments.Where(q => q.CurrentState == BaseEntity.EntityState.Deleted))
                    {
                        fileuploadclient.DeleteFileFTP(basicDoc.foldercontentid, basicDoc.filename, basicDoc.extension);
                    }
                }

                i = await BFC.Core.FacadeCreatorObjects.General.reg_educationinfoFCC.GetFacadeCreate(_contextAccessor)
                    .AddOrUpdate(message.Objreg_educationinfo, cancellationToken);

                outputPort.Save(new Reg_EducationInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_SAVE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                if (message.Objreg_educationinfo.CertificateDocuments != null)
                {
                    foreach (var basicDoc in message.Objreg_educationinfo.CertificateDocuments)
                    {
                        fileuploadclient.DeleteFileFTP(basicDoc.foldercontentid, basicDoc.filename, basicDoc.extension);
                    }
                }


                Reg_EducationInfoResponse objResponse = new Reg_EducationInfoResponse(false, _sharedLocalizer["DATA_SAVE_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Save(objResponse);
                return true;
            }
        }

        public async Task<bool> ApllicantReviewEducationInfoSaveorUpdate(Reg_EducationInfoRequest message, ICRUDRequestHandler<Reg_EducationInfoResponse> outputPort)
        {
            _logger.LogInformation(JsonConvert.SerializeObject(message));
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                //File Upload: Basic Profile
                if (message.Objreg_educationinfo.CertificateDocuments != null)
                {
                    var Document_FolderName = $"Document_{message.Objreg_educationinfo.civilid}";
                    fileuploadclient.FolderCheckFTP(Document_FolderName);
                    foreach (var basicDoc in message.Objreg_educationinfo.CertificateDocuments.Where(q => q.CurrentState == BaseEntity.EntityState.Added))
                    {
                        basicDoc.foldercontentid = Document_FolderName;
                        basicDoc.filename = Guid.NewGuid().ToString("N").ToUpper();
                        basicDoc.filepath = fileuploadclient.UploadFileFTP(Convert.FromBase64String(basicDoc.base64file), Document_FolderName, basicDoc.filename, basicDoc.extension);
                    }
                    foreach (var basicDoc in message.Objreg_educationinfo.CertificateDocuments.Where(q => q.CurrentState == BaseEntity.EntityState.Deleted))
                    {
                        fileuploadclient.DeleteFileFTP(basicDoc.foldercontentid, basicDoc.filename, basicDoc.extension);
                    }
                }

                i = await BFC.Core.FacadeCreatorObjects.General.reg_educationinfoFCC.GetFacadeCreate(_contextAccessor)
                    .ApllicantReviewEducationInfoSaveorUpdate(message.Objreg_educationinfo, cancellationToken);

                outputPort.Save(new Reg_EducationInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_SAVE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                if (message.Objreg_educationinfo.CertificateDocuments != null)
                {
                    foreach (var basicDoc in message.Objreg_educationinfo.CertificateDocuments)
                    {
                        fileuploadclient.DeleteFileFTP(basicDoc.foldercontentid, basicDoc.filename, basicDoc.extension);
                    }
                }


                Reg_EducationInfoResponse objResponse = new Reg_EducationInfoResponse(false, _sharedLocalizer["DATA_SAVE_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Save(objResponse);
                return true;
            }
        }

        public async Task<bool> DeleteWithAttachment(Reg_EducationInfoRequest message, ICRUDRequestHandler<Reg_EducationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                // Delete Existing Attachment
                reg_educationinfoEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.reg_educationinfoFCC.GetFacadeCreate(_contextAccessor)
               .GetSingleById(message.Objreg_educationinfo, cancellationToken);
                
                i = await BFC.Core.FacadeCreatorObjects.General.reg_educationinfoFCC.GetFacadeCreate(_contextAccessor)
                    .DeleteWithAttachment(message.Objreg_educationinfo, cancellationToken);

                if (objSingle.CertificateDocuments != null && i>0)
                {
                    foreach (var basicDoc in objSingle.CertificateDocuments)
                    {
                        fileuploadclient.DeleteFileFTP(basicDoc.foldercontentid, basicDoc.filename, basicDoc.extension);
                    }
                }



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