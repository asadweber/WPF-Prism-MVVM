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
using BDO.Core.Base;

namespace Web.Core.Frame.UseCases.Registration
{
   public sealed partial class Reg_FamillyUseCase : IReg_FamillyUseCase
    {

        public async Task<bool> GetSingleByIdWithDocument(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                reg_famillyEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.reg_famillyFCC.GetFacadeCreate(_contextAccessor)
                .GetSingleByIdWithDocument(message.Objreg_familly, cancellationToken);
                if (objSingle != null)
                {
                    outputPort.GetSingle(new Reg_FamillyResponse(objSingle, true));
                    return true;
                }
                else
                {
                    Reg_FamillyResponse objResponse = new Reg_FamillyResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_FamillyResponse objResponse = new Reg_FamillyResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }
        public async Task<bool> SaveUpdateWithSpouse(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? familyid = null;
            try
            {

                //if (message.Objreg_familly.Documents != null)
                //{
                //    var Document_FolderName = $"Document_{message.Objreg_familly.applicantCivilId}";
                //    fileuploadclient.FolderCheckFTP(Document_FolderName);
                //    foreach (var basicDoc in message.Objreg_familly.Documents.Where(q => q.CurrentState == BaseEntity.EntityState.Added))
                //    {
                //        basicDoc.foldercontentid = Document_FolderName;
                //        basicDoc.filename = Guid.NewGuid().ToString("N").ToUpper();
                //        basicDoc.filepath = fileuploadclient.UploadFileFTP(Convert.FromBase64String(basicDoc.base64file), Document_FolderName, basicDoc.filename, basicDoc.extension);
                //    }
                //    foreach (var basicDoc in message.Objreg_familly.Documents.Where(q => q.CurrentState == BaseEntity.EntityState.Deleted))
                //    {
                //        fileuploadclient.DeleteFileFTP(basicDoc.foldercontentid, basicDoc.filename, basicDoc.extension);
                //    }
                //}

                familyid = await BFC.Core.FacadeCreatorObjects.General.reg_famillyFCC.GetFacadeCreate(_contextAccessor)
                    .SaveUpdate(message.Objreg_familly, cancellationToken);

                if (message.Objreg_familly.spouseInfo != null)
                {
                    message.Objreg_familly.spouseInfo.BaseSecurityParam = message.Objreg_familly.BaseSecurityParam;
                    message.Objreg_familly.spouseInfo.basicinfoid = message.Objreg_familly.basicinfoid;
                    message.Objreg_familly.spouseInfo.parentid = familyid;
                    message.Objreg_familly.spouseInfo.isinkuwait = message.Objreg_familly.isinkuwait;

                    familyid = await BFC.Core.FacadeCreatorObjects.General.reg_famillyFCC.GetFacadeCreate(_contextAccessor)
                        .SaveUpdate(message.Objreg_familly.spouseInfo, cancellationToken);
                }



                outputPort.Update(new Reg_FamillyResponse(new AjaxResponse("200", _sharedLocalizer["DATA_SAVE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                    ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                bool datetimeerror = ex.Message.Contains("DateTime", StringComparison.OrdinalIgnoreCase);
                Reg_FamillyResponse objResponse = new Reg_FamillyResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       (datetimeerror == false ? ex.Message : _sharedLocalizer["DATE_TIME_ERROR"].Value)));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> ApplicantReviewSaveUpdateWithSpouse(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? familyid = null;
            try
            {

                //if (message.Objreg_familly.Documents != null)
                //{
                //    var Document_FolderName = $"Document_{message.Objreg_familly.applicantCivilId}";
                //    fileuploadclient.FolderCheckFTP(Document_FolderName);
                //    foreach (var basicDoc in message.Objreg_familly.Documents.Where(q => q.CurrentState == BaseEntity.EntityState.Added))
                //    {
                //        basicDoc.foldercontentid = Document_FolderName;
                //        basicDoc.filename = Guid.NewGuid().ToString("N").ToUpper();
                //        basicDoc.filepath = fileuploadclient.UploadFileFTP(Convert.FromBase64String(basicDoc.base64file), Document_FolderName, basicDoc.filename, basicDoc.extension);
                //    }
                //    foreach (var basicDoc in message.Objreg_familly.Documents.Where(q => q.CurrentState == BaseEntity.EntityState.Deleted))
                //    {
                //        fileuploadclient.DeleteFileFTP(basicDoc.foldercontentid, basicDoc.filename, basicDoc.extension);
                //    }
                //}

                familyid = await BFC.Core.FacadeCreatorObjects.General.reg_famillyFCC.GetFacadeCreate(_contextAccessor)
                    .ApplicantReviewSaveUpdate(message.Objreg_familly, cancellationToken);

                if (message.Objreg_familly.spouseInfo != null)
                {
                    message.Objreg_familly.spouseInfo.BaseSecurityParam = message.Objreg_familly.BaseSecurityParam;
                    message.Objreg_familly.spouseInfo.basicinfoid = message.Objreg_familly.basicinfoid;
                    message.Objreg_familly.spouseInfo.parentid = familyid;
                    message.Objreg_familly.spouseInfo.isinkuwait = message.Objreg_familly.isinkuwait;

                    familyid = await BFC.Core.FacadeCreatorObjects.General.reg_famillyFCC.GetFacadeCreate(_contextAccessor)
                        .ApplicantReviewSaveUpdate(message.Objreg_familly.spouseInfo, cancellationToken);
                }



                outputPort.Update(new Reg_FamillyResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                    ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                bool datetimeerror = ex.Message.Contains("DateTime", StringComparison.OrdinalIgnoreCase);
                Reg_FamillyResponse objResponse = new Reg_FamillyResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       (datetimeerror == false ? ex.Message : _sharedLocalizer["DATE_TIME_ERROR"].Value)));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> SaveFather(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                clsPrivateKeys objClsPrivate = new clsPrivateKeys();
                //if (message.Objreg_familly.Documents != null)
                //{
                //    var Document_FolderName = $"Document_{message.Objreg_familly.applicantCivilId}";
                //    fileuploadclient.FolderCheckFTP(Document_FolderName);
                //    foreach (var basicDoc in message.Objreg_familly.Documents.Where(q => q.CurrentState == BaseEntity.EntityState.Added))
                //    {
                //        basicDoc.foldercontentid = Document_FolderName;
                //        basicDoc.filename = Guid.NewGuid().ToString("N").ToUpper();
                //        basicDoc.filepath = fileuploadclient.UploadFileFTP(Convert.FromBase64String(basicDoc.base64file), Document_FolderName, basicDoc.filename, basicDoc.extension);
                //    }
                //    foreach (var basicDoc in message.Objreg_familly.Documents.Where(q => q.CurrentState == BaseEntity.EntityState.Deleted))
                //    {
                //        fileuploadclient.DeleteFileFTP(basicDoc.foldercontentid, basicDoc.filename, basicDoc.extension);
                //    }
                //}


                i = await BFC.Core.FacadeCreatorObjects.General.reg_famillyFCC.GetFacadeCreate(_contextAccessor)
                            .SaveUpdate(message.Objreg_familly, cancellationToken);
                var FatherFamilyID = objClsPrivate.EncodeUrlOnlyParams(GlobalConstant.FatherFamilyID, i.ToString());
                outputPort.Update(new Reg_FamillyResponse(
                    new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        , string.Empty, FatherFamilyID), true, null));
                return true;
            }
            catch (Exception ex)
            {
                bool datetimeerror = ex.Message.Contains("DateTime", StringComparison.OrdinalIgnoreCase);
                Reg_FamillyResponse objResponse = new Reg_FamillyResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       (datetimeerror == false ? ex.Message : _sharedLocalizer["DATE_TIME_ERROR"].Value)));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> ApplicantReviewSaveFatherInfo(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                clsPrivateKeys objClsPrivate = new clsPrivateKeys();
                //if (message.Objreg_familly.Documents != null)
                //{
                //    var Document_FolderName = $"Document_{message.Objreg_familly.applicantCivilId}";
                //    fileuploadclient.FolderCheckFTP(Document_FolderName);
                //    foreach (var basicDoc in message.Objreg_familly.Documents.Where(q => q.CurrentState == BaseEntity.EntityState.Added))
                //    {
                //        basicDoc.foldercontentid = Document_FolderName;
                //        basicDoc.filename = Guid.NewGuid().ToString("N").ToUpper();
                //        basicDoc.filepath = fileuploadclient.UploadFileFTP(Convert.FromBase64String(basicDoc.base64file), Document_FolderName, basicDoc.filename, basicDoc.extension);
                //    }
                //    foreach (var basicDoc in message.Objreg_familly.Documents.Where(q => q.CurrentState == BaseEntity.EntityState.Deleted))
                //    {
                //        fileuploadclient.DeleteFileFTP(basicDoc.foldercontentid, basicDoc.filename, basicDoc.extension);
                //    }
                //}


                i = await BFC.Core.FacadeCreatorObjects.General.reg_famillyFCC.GetFacadeCreate(_contextAccessor)
                            .ApplicantReviewSaveUpdate(message.Objreg_familly, cancellationToken);
                var FatherFamilyID = objClsPrivate.EncodeUrlOnlyParams(GlobalConstant.FatherFamilyID, i.ToString());
                outputPort.Update(new Reg_FamillyResponse(
                    new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        , string.Empty, FatherFamilyID), true, null));
                return true;
            }
            catch (Exception ex)
            {
                bool datetimeerror = ex.Message.Contains("DateTime", StringComparison.OrdinalIgnoreCase);

                Reg_FamillyResponse objResponse = new Reg_FamillyResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       (datetimeerror == false ? ex.Message : _sharedLocalizer["DATE_TIME_ERROR"].Value)));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> SaveMother(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                clsPrivateKeys objClsPrivate = new clsPrivateKeys();
                //if (message.Objreg_familly.Documents != null)
                //{
                //    var Document_FolderName = $"Document_{message.Objreg_familly.applicantCivilId}";
                //    fileuploadclient.FolderCheckFTP(Document_FolderName);
                //    foreach (var basicDoc in message.Objreg_familly.Documents.Where(q => q.CurrentState == BaseEntity.EntityState.Added))
                //    {
                //        basicDoc.foldercontentid = Document_FolderName;
                //        basicDoc.filename = Guid.NewGuid().ToString("N").ToUpper();
                //        basicDoc.filepath = fileuploadclient.UploadFileFTP(Convert.FromBase64String(basicDoc.base64file), Document_FolderName, basicDoc.filename, basicDoc.extension);
                //    }
                //    foreach (var basicDoc in message.Objreg_familly.Documents.Where(q => q.CurrentState == BaseEntity.EntityState.Deleted))
                //    {
                //        fileuploadclient.DeleteFileFTP(basicDoc.foldercontentid, basicDoc.filename, basicDoc.extension);
                //    }
                //}

                i = await BFC.Core.FacadeCreatorObjects.General.reg_famillyFCC.GetFacadeCreate(_contextAccessor)
                            .SaveUpdate(message.Objreg_familly, cancellationToken);
                var MotherFamilyID = objClsPrivate.EncodeUrlOnlyParams(GlobalConstant.MotherFamilyID, i.ToString());
                outputPort.Update(new Reg_FamillyResponse(
                    new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        , string.Empty, MotherFamilyID), true, null));
                return true;
            }
            catch (Exception ex)
            {
                bool datetimeerror = ex.Message.Contains("DateTime", StringComparison.OrdinalIgnoreCase);
                Reg_FamillyResponse objResponse = new Reg_FamillyResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       (datetimeerror == false ? ex.Message : _sharedLocalizer["DATE_TIME_ERROR"].Value)));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> ApplicantReviewSaveMotherInfo(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                clsPrivateKeys objClsPrivate = new clsPrivateKeys();
                //if (message.Objreg_familly.Documents != null)
                //{
                //    var Document_FolderName = $"Document_{message.Objreg_familly.applicantCivilId}";
                //    fileuploadclient.FolderCheckFTP(Document_FolderName);
                //    foreach (var basicDoc in message.Objreg_familly.Documents.Where(q => q.CurrentState == BaseEntity.EntityState.Added))
                //    {
                //        basicDoc.foldercontentid = Document_FolderName;
                //        basicDoc.filename = Guid.NewGuid().ToString("N").ToUpper();
                //        basicDoc.filepath = fileuploadclient.UploadFileFTP(Convert.FromBase64String(basicDoc.base64file), Document_FolderName, basicDoc.filename, basicDoc.extension);
                //    }
                //    foreach (var basicDoc in message.Objreg_familly.Documents.Where(q => q.CurrentState == BaseEntity.EntityState.Deleted))
                //    {
                //        fileuploadclient.DeleteFileFTP(basicDoc.foldercontentid, basicDoc.filename, basicDoc.extension);
                //    }
                //}

                i = await BFC.Core.FacadeCreatorObjects.General.reg_famillyFCC.GetFacadeCreate(_contextAccessor)
                            .ApplicantReviewSaveUpdate(message.Objreg_familly, cancellationToken);
                var MotherFamilyID = objClsPrivate.EncodeUrlOnlyParams(GlobalConstant.MotherFamilyID, i.ToString());
                outputPort.Update(new Reg_FamillyResponse(
                    new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        , string.Empty, MotherFamilyID), true, null));
                return true;
            }
            catch (Exception ex)
            {
                bool datetimeerror = ex.Message.Contains("DateTime", StringComparison.OrdinalIgnoreCase);
                Reg_FamillyResponse objResponse = new Reg_FamillyResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       (datetimeerror == false ? ex.Message : _sharedLocalizer["DATE_TIME_ERROR"].Value)));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> CheckHasSpouce(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<reg_famillyEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_famillyFCC.GetFacadeCreate(_contextAccessor)
                .GetAllSpouseByPage(message.Objreg_familly, cancellationToken);
                if (oblist.Count>0)
                {
                    outputPort.GetAll(new Reg_FamillyResponse(oblist.ToList(), true));
                    return true;
                }
                else
                {
                    outputPort.GetAll(new Reg_FamillyResponse(new List<reg_famillyEntity>(), true));
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_FamillyResponse objResponse = new Reg_FamillyResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAll(objResponse);
                return true;
            }
        }

        public async Task<bool> GetAllMotherHusbandSpouseByPage(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<reg_famillyEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_famillyFCC.GetFacadeCreate(_contextAccessor)
                .GetAllSpouseByPage(message.Objreg_familly, cancellationToken);
                List<dataTableButtonModel> btnActionList = new List<dataTableButtonModel>();
                var edit = new dataTableButtonModel(basicCRUDButtons.Edit_GET);
                edit.isCheckPermission = false;
                edit.JsMethodName = "EditMotherHusband";

                var delete = new dataTableButtonModel(basicCRUDButtons.Delete_GET);
                delete.isCheckPermission = false;
                delete.JsMethodName = "DeleteMotherHusband"; 

                //var single = new dataTableButtonModel(basicCRUDButtons.GetSingle_GET);
                //single.isCheckPermission = false;
                //single.JsMethodName = "GetSingleFatherWife";


                btnActionList.Add(edit);
                btnActionList.Add(delete);
                //btnActionList.Add(single);


                var data = (from t in oblist
                            select new
                            {
                                t.familyid,
                                t.parentid,
                                t.basicinfoid,
                                t.relationshipid,
                                t.relationshipname,
                                t.familygenderid,
                                t.familyreligionid,
                                t.familybloodgroupid,
                                t.maritalstatusid,
                                t.parentalstatus,
                                t.nationalityid,
                                t.nationalityname,
                                t.classid,
                                t.birthcountryid,
                                t.prevnationalityid,
                                t.birthdate,
                                t.civilid,
                                t.nationalid,
                                t.passportnumber,
                                t.fullname,
                                t.name1,
                                t.name2,
                                t.name3,
                                t.name4,
                                t.name5,
                                t.isservedinmilitary,
                                t.isserving,
                                t.splmilstatus,
                                t.militaryid,
                                t.companyid,
                                t.workdesignation,
                                t.workcompany,
                                t.companytype,
                                t.companyaddress,
                                t.enrollmentdate,
                                t.previousjob,
                                t.previousjobdetails,
                                t.preaddcountryid,
                                t.preaddgovernid,
                                t.preaddcityid,
                                t.preaddstreet,
                                t.preaddblock,
                                t.preaddhousingno,
                                t.preaddhousingflatno,
                                t.prepaci,
                                t.preaddress,
                                t.pres_latitude,
                                t.pres_longitude,
                                t.peraddcountryid,
                                t.peraddgovernid,
                                t.peraddcityid,
                                t.peraddstreet,
                                t.peraddblock,
                                t.peraddhousingno,
                                t.peraddhousingflatno,
                                t.perpaci,
                                t.peraddress,
                                t.perm_latitude,
                                t.perm_longitude,
                                t.email,
                                t.mobilephone1,
                                t.mobilephone2,
                                t.mobilephone3,
                                t.lanphone1,
                                t.lanphone2,
                                t.lanphone3,
                                t.ismarried,
                                t.familymarriagedate,
                                t.familymarriagedocno,
                                t.familymarriagedocdate,
                                t.deathdate,
                                t.filepath,
                                t.filename,
                                t.filetype,
                                t.extension,
                                t.securitycardvaliddate,
                                t.comment,
                                t.remarks,
                                t.updateinfo,
                                t.tranformactionid,
                                datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objreg_familly.ControllerName, t.familyid, GlobalConstant.MotherHusbandFamilyID, _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList, this._contextAccessor)
                            }).ToList();

                outputPort.GetListView(new Reg_FamillyResponse(new AjaxResponse(oblist.Count > 0 ? oblist[0].RETURN_KEY : 0, data), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_FamillyResponse objResponse = new Reg_FamillyResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAll(objResponse);
                return true;
            }
        }

        public async Task<bool> GetAllFatheWifeSpouseByPage(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<reg_famillyEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_famillyFCC.GetFacadeCreate(_contextAccessor)
                .GetAllSpouseByPage(message.Objreg_familly, cancellationToken);
                List<dataTableButtonModel> btnActionList = new List<dataTableButtonModel>();
                var edit = new dataTableButtonModel(basicCRUDButtons.Edit_GET);
                edit.isCheckPermission = false;
                edit.JsMethodName = "EditFatherWife";

                var delete = new dataTableButtonModel(basicCRUDButtons.Delete_GET);
                delete.isCheckPermission = false;
                delete.JsMethodName = "DeleteFatherWife";

                //var single = new dataTableButtonModel(basicCRUDButtons.GetSingle_GET);
                //single.isCheckPermission = false;
                //single.JsMethodName = "GetSingleFatherWife";


                btnActionList.Add(edit);
                btnActionList.Add(delete);
                //btnActionList.Add(single);


                var data = (from t in oblist
                            select new
                            {
                                t.familyid,
                                t.parentid,
                                t.basicinfoid,
                                t.relationshipid,
                                t.relationshipname,
                                t.familygenderid,
                                t.familyreligionid,
                                t.familybloodgroupid,
                                t.maritalstatusid,
                                t.parentalstatus,
                                t.nationalityid,
                                t.nationalityname,
                                t.classid,
                                t.birthcountryid,
                                t.prevnationalityid,
                                t.birthdate,
                                t.civilid,
                                t.nationalid,
                                t.passportnumber,
                                t.fullname,
                                t.name1,
                                t.name2,
                                t.name3,
                                t.name4,
                                t.name5,
                                t.isservedinmilitary,
                                t.isserving,
                                t.splmilstatus,
                                t.militaryid,
                                t.companyid,
                                t.workdesignation,
                                t.workcompany,
                                t.companytype,
                                t.companyaddress,
                                t.enrollmentdate,
                                t.previousjob,
                                t.previousjobdetails,
                                t.preaddcountryid,
                                t.preaddgovernid,
                                t.preaddcityid,
                                t.preaddstreet,
                                t.preaddblock,
                                t.preaddhousingno,
                                t.preaddhousingflatno,
                                t.prepaci,
                                t.preaddress,
                                t.pres_latitude,
                                t.pres_longitude,
                                t.peraddcountryid,
                                t.peraddgovernid,
                                t.peraddcityid,
                                t.peraddstreet,
                                t.peraddblock,
                                t.peraddhousingno,
                                t.peraddhousingflatno,
                                t.perpaci,
                                t.peraddress,
                                t.perm_latitude,
                                t.perm_longitude,
                                t.email,
                                t.mobilephone1,
                                t.mobilephone2,
                                t.mobilephone3,
                                t.lanphone1,
                                t.lanphone2,
                                t.lanphone3,
                                t.ismarried,
                                t.familymarriagedate,
                                t.familymarriagedocno,
                                t.familymarriagedocdate,
                                t.deathdate,
                                t.filepath,
                                t.filename,
                                t.filetype,
                                t.extension,
                                t.securitycardvaliddate,
                                t.comment,
                                t.remarks,
                                t.updateinfo,
                                t.tranformactionid,
                                datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objreg_familly.ControllerName, t.familyid, GlobalConstant.FatherWifeFamilyID, _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList, this._contextAccessor)
                            }).ToList();

                outputPort.GetListView(new Reg_FamillyResponse(new AjaxResponse(oblist.Count > 0 ? oblist[0].RETURN_KEY : 0, data), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_FamillyResponse objResponse = new Reg_FamillyResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAll(objResponse);
                return true;
            }
        }

        public async Task<bool> DeleteByFamilityId(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.reg_famillyFCC.GetFacadeCreate(_contextAccessor)
                    .DeleteByFamilityId(message.Objreg_familly, cancellationToken);
                outputPort.Delete(new Reg_FamillyResponse(new AjaxResponse("200", _sharedLocalizer["DATA_DELETE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                       ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_FamillyResponse objResponse = new Reg_FamillyResponse(false, _sharedLocalizer["DATA_DELETE_ERROR"], new Error(
                         "500",
                         ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Delete(objResponse);
                return true;
            }
        }

        

        #region Brother
        public async Task<bool> GetBrotherListViewByFamilyId(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<reg_famillyEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_famillyFCC.GetFacadeCreate(_contextAccessor)
                .GetFamilyMembersByRelationshipType(message.Objreg_familly, cancellationToken);

                

                List<dataTableButtonModel> btnActionList = new List<dataTableButtonModel>();
                var edit = new dataTableButtonModel(basicCRUDButtons.Edit_GET);
                edit.isCheckPermission = false;
                edit.JsMethodName = "EditBrother";

                var delete = new dataTableButtonModel(basicCRUDButtons.Delete_GET);
                delete.isCheckPermission = false;
                delete.JsMethodName = "DeleteBrother";

                btnActionList.Add(edit);
                btnActionList.Add(delete);


                var data = (from t in oblist
                            select new
                            {
                                t.familyid,
                                t.parentid,
                                t.isinkuwait,
                                t.basicinfoid,
                                t.relationshipid,
                                t.relationshipname,
                                t.familygenderid,
                                t.familyreligionid,
                                t.familybloodgroupid,
                                t.maritalstatusid,
                                t.parentalstatus,
                                t.nationalityid,
                                t.nationalityname,
                                t.classid,
                                t.birthcountryid,
                                t.prevnationalityid,
                                t.birthdate,
                                t.civilid,
                                t.nationalid,
                                t.passportnumber,
                                t.fullname,
                                t.name1,
                                t.name2,
                                t.name3,
                                t.name4,
                                t.name5,
                                t.isservedinmilitary,
                                t.isserving,
                                t.splmilstatus,
                                t.militaryid,
                                t.companyid,
                                t.workdesignation,
                                t.workcompany,
                                t.companytype,
                                t.companyaddress,
                                t.enrollmentdate,
                                t.previousjob,
                                t.previousjobdetails,
                                t.preaddcountryid,
                                t.preaddgovernid,
                                t.preaddgovernarate,
                                t.preaddcityid,
                                t.preaddcity,
                                t.preaddstreet,
                                t.preaddblock,
                                t.preaddhousingno,
                                t.preaddhousingflatno,
                                t.prepaci,
                                t.preaddress,
                                t.pres_latitude,
                                t.pres_longitude,
                                t.peraddcountryid,
                                t.peraddgovernid,
                                t.peraddcityid,
                                t.peraddstreet,
                                t.peraddblock,
                                t.peraddhousingno,
                                t.peraddhousingflatno,
                                t.perpaci,
                                t.peraddress,
                                t.perm_latitude,
                                t.perm_longitude,
                                t.email,
                                t.mobilephone1,
                                t.mobilephone2,
                                t.mobilephone3,
                                t.lanphone1,
                                t.lanphone2,
                                t.lanphone3,
                                t.ismarried,
                                t.familymarriagedate,
                                t.familymarriagedocno,
                                t.familymarriagedocdate,
                                t.deathdate,
                                t.isalive,
                                t.isfatherside,
                                t.ismotherside,
                                t.filepath,
                                t.filename,
                                t.filetype,
                                t.extension,
                                t.securitycardvaliddate,
                                t.comment,
                                t.remarks,
                                t.updateinfo,
                                t.tranformactionid,
                                datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objreg_familly.ControllerName, t.familyid, GlobalConstant.BrotherFamilyID, _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList, this._contextAccessor)
                            }).ToList();

                outputPort.GetListView(new Reg_FamillyResponse(new AjaxResponse(oblist.Count > 0 ? oblist[0].RETURN_KEY : 0, data), true, null));
                return true;

            }
            catch (Exception ex)
            {
                Reg_FamillyResponse objResponse = new Reg_FamillyResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }
        
       
         #endregion

        #region Sister
        public async Task<bool> GetSisterListViewByFamilyId(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<reg_famillyEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_famillyFCC.GetFacadeCreate(_contextAccessor)
                .GetFamilyMembersByRelationshipType(message.Objreg_familly, cancellationToken);

                List<dataTableButtonModel> btnActionList = new List<dataTableButtonModel>();
                var edit = new dataTableButtonModel(basicCRUDButtons.Edit_GET);
                edit.isCheckPermission = false;
                edit.JsMethodName = "EditSister";

                var delete = new dataTableButtonModel(basicCRUDButtons.Delete_GET);
                delete.isCheckPermission = false;
                delete.JsMethodName = "DeleteSister";

                btnActionList.Add(edit);
                btnActionList.Add(delete);


                var data = (from t in oblist
                            select new
                            {
                                t.familyid,
                                t.parentid,
                                t.isinkuwait,
                                t.basicinfoid,
                                t.relationshipid,
                                t.relationshipname,
                                t.familygenderid,
                                t.familyreligionid,
                                t.familybloodgroupid,
                                t.maritalstatusid,
                                t.parentalstatus,
                                t.nationalityid,
                                t.nationalityname,
                                t.classid,
                                t.birthcountryid,
                                t.prevnationalityid,
                                t.birthdate,
                                t.civilid,
                                t.nationalid,
                                t.passportnumber,
                                t.fullname,
                                t.name1,
                                t.name2,
                                t.name3,
                                t.name4,
                                t.name5,
                                t.isservedinmilitary,
                                t.isserving,
                                t.splmilstatus,
                                t.militaryid,
                                t.companyid,
                                t.workdesignation,
                                t.workcompany,
                                t.companytype,
                                t.companyaddress,
                                t.enrollmentdate,
                                t.previousjob,
                                t.previousjobdetails,
                                t.preaddcountryid,
                                t.preaddgovernid,
                                t.preaddgovernarate,
                                t.preaddcityid,
                                t.preaddcity,
                                t.preaddstreet,
                                t.preaddblock,
                                t.preaddhousingno,
                                t.preaddhousingflatno,
                                t.prepaci,
                                t.preaddress,
                                t.pres_latitude,
                                t.pres_longitude,
                                t.peraddcountryid,
                                t.peraddgovernid,
                                t.peraddcityid,
                                t.peraddstreet,
                                t.peraddblock,
                                t.peraddhousingno,
                                t.peraddhousingflatno,
                                t.perpaci,
                                t.peraddress,
                                t.perm_latitude,
                                t.perm_longitude,
                                t.email,
                                t.mobilephone1,
                                t.mobilephone2,
                                t.mobilephone3,
                                t.lanphone1,
                                t.lanphone2,
                                t.lanphone3,
                                t.ismarried,
                                t.familymarriagedate,
                                t.familymarriagedocno,
                                t.familymarriagedocdate,
                                t.deathdate,
                                t.isalive,
                                t.isfatherside,
                                t.ismotherside,
                                t.filepath,
                                t.filename,
                                t.filetype,
                                t.extension,
                                t.securitycardvaliddate,
                                t.comment,
                                t.remarks,
                                t.updateinfo,
                                t.tranformactionid,
                                datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objreg_familly.ControllerName, t.familyid, GlobalConstant.SisterFamilyID, _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList, this._contextAccessor)
                            }).ToList();

                outputPort.GetListView(new Reg_FamillyResponse(new AjaxResponse(oblist.Count > 0 ? oblist[0].RETURN_KEY : 0, data), true, null));
                return true;

            }
            catch (Exception ex)
            {
                Reg_FamillyResponse objResponse = new Reg_FamillyResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }


        #endregion
        public async Task<bool> GetPaternalUncleListViewByFamilyId(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<reg_famillyEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_famillyFCC.GetFacadeCreate(_contextAccessor)
                .GetFamilyMembersByRelationshipType(message.Objreg_familly, cancellationToken);

                List<dataTableButtonModel> btnActionList = new List<dataTableButtonModel>();
                var edit = new dataTableButtonModel(basicCRUDButtons.Edit_GET);
                edit.isCheckPermission = false;
                edit.JsMethodName = "EditPaternalUncle";

                var delete = new dataTableButtonModel(basicCRUDButtons.Delete_GET);
                delete.isCheckPermission = false;
                delete.JsMethodName = "DeletePaternalUncle";

                btnActionList.Add(edit);
                btnActionList.Add(delete);


                var data = (from t in oblist
                            select new
                            {
                                t.familyid,
                                t.parentid,
                                t.isinkuwait,
                                t.basicinfoid,
                                t.relationshipid,
                                t.relationshipname,
                                t.familygenderid,
                                t.familyreligionid,
                                t.familybloodgroupid,
                                t.maritalstatusid,
                                t.parentalstatus,
                                t.nationalityid,
                                t.nationalityname,
                                t.classid,
                                t.birthcountryid,
                                t.prevnationalityid,
                                t.birthdate,
                                t.civilid,
                                t.nationalid,
                                t.passportnumber,
                                t.fullname,
                                t.name1,
                                t.name2,
                                t.name3,
                                t.name4,
                                t.name5,
                                t.isservedinmilitary,
                                t.isserving,
                                t.splmilstatus,
                                t.militaryid,
                                t.companyid,
                                t.workdesignation,
                                t.workcompany,
                                t.companytype,
                                t.companyaddress,
                                t.enrollmentdate,
                                t.previousjob,
                                t.previousjobdetails,
                                t.preaddcountryid,
                                t.preaddgovernid,
                                t.preaddgovernarate,
                                t.preaddcityid,
                                t.preaddcity,
                                t.preaddstreet,
                                t.preaddblock,
                                t.preaddhousingno,
                                t.preaddhousingflatno,
                                t.prepaci,
                                t.preaddress,
                                t.pres_latitude,
                                t.pres_longitude,
                                t.peraddcountryid,
                                t.peraddgovernid,
                                t.peraddcityid,
                                t.peraddstreet,
                                t.peraddblock,
                                t.peraddhousingno,
                                t.peraddhousingflatno,
                                t.perpaci,
                                t.peraddress,
                                t.perm_latitude,
                                t.perm_longitude,
                                t.email,
                                t.mobilephone1,
                                t.mobilephone2,
                                t.mobilephone3,
                                t.lanphone1,
                                t.lanphone2,
                                t.lanphone3,
                                t.ismarried,
                                t.familymarriagedate,
                                t.familymarriagedocno,
                                t.familymarriagedocdate,
                                t.deathdate,
                                t.isalive,
                                t.filepath,
                                t.filename,
                                t.filetype,
                                t.extension,
                                t.securitycardvaliddate,
                                t.comment,
                                t.remarks,
                                t.updateinfo,
                                t.tranformactionid,
                                datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objreg_familly.ControllerName, t.familyid, GlobalConstant.PaternalUncleFamilyID, _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList, this._contextAccessor)
                            }).ToList();

                outputPort.GetListView(new Reg_FamillyResponse(new AjaxResponse(oblist.Count > 0 ? oblist[0].RETURN_KEY : 0, data), true, null));
                return true;

            }
            catch (Exception ex)
            {
                Reg_FamillyResponse objResponse = new Reg_FamillyResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetPaternalAuntyListViewByFamilyId(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<reg_famillyEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_famillyFCC.GetFacadeCreate(_contextAccessor)
                .GetFamilyMembersByRelationshipType(message.Objreg_familly, cancellationToken);

                List<dataTableButtonModel> btnActionList = new List<dataTableButtonModel>();
                var edit = new dataTableButtonModel(basicCRUDButtons.Edit_GET);
                edit.isCheckPermission = false;
                edit.JsMethodName = "EditPaternalAunty";

                var delete = new dataTableButtonModel(basicCRUDButtons.Delete_GET);
                delete.isCheckPermission = false;
                delete.JsMethodName = "DeletePaternalAunty";

                btnActionList.Add(edit);
                btnActionList.Add(delete);


                var data = (from t in oblist
                            select new
                            {
                                t.familyid,
                                t.parentid,
                                t.isinkuwait,
                                t.basicinfoid,
                                t.relationshipid,
                                t.relationshipname,
                                t.familygenderid,
                                t.familyreligionid,
                                t.familybloodgroupid,
                                t.maritalstatusid,
                                t.parentalstatus,
                                t.nationalityid,
                                t.nationalityname,
                                t.classid,
                                t.birthcountryid,
                                t.prevnationalityid,
                                t.birthdate,
                                t.civilid,
                                t.nationalid,
                                t.passportnumber,
                                t.fullname,
                                t.name1,
                                t.name2,
                                t.name3,
                                t.name4,
                                t.name5,
                                t.isservedinmilitary,
                                t.isserving,
                                t.splmilstatus,
                                t.militaryid,
                                t.companyid,
                                t.workdesignation,
                                t.workcompany,
                                t.companytype,
                                t.companyaddress,
                                t.enrollmentdate,
                                t.previousjob,
                                t.previousjobdetails,
                                t.preaddcountryid,
                                t.preaddgovernid,
                                t.preaddgovernarate,
                                t.preaddcityid,
                                t.preaddcity,
                                t.preaddstreet,
                                t.preaddblock,
                                t.preaddhousingno,
                                t.preaddhousingflatno,
                                t.prepaci,
                                t.preaddress,
                                t.pres_latitude,
                                t.pres_longitude,
                                t.peraddcountryid,
                                t.peraddgovernid,
                                t.peraddcityid,
                                t.peraddstreet,
                                t.peraddblock,
                                t.peraddhousingno,
                                t.peraddhousingflatno,
                                t.perpaci,
                                t.peraddress,
                                t.perm_latitude,
                                t.perm_longitude,
                                t.email,
                                t.mobilephone1,
                                t.mobilephone2,
                                t.mobilephone3,
                                t.lanphone1,
                                t.lanphone2,
                                t.lanphone3,
                                t.ismarried,
                                t.familymarriagedate,
                                t.familymarriagedocno,
                                t.familymarriagedocdate,
                                t.deathdate,
                                t.isalive,
                                t.filepath,
                                t.filename,
                                t.filetype,
                                t.extension,
                                t.securitycardvaliddate,
                                t.comment,
                                t.remarks,
                                t.updateinfo,
                                t.tranformactionid,
                                datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objreg_familly.ControllerName, t.familyid, GlobalConstant.PaternalAuntyFamilyID, _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList, this._contextAccessor)
                            }).ToList();

                outputPort.GetListView(new Reg_FamillyResponse(new AjaxResponse(oblist.Count > 0 ? oblist[0].RETURN_KEY : 0, data), true, null));
                return true;

            }
            catch (Exception ex)
            {
                Reg_FamillyResponse objResponse = new Reg_FamillyResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }
        public async Task<bool> GetMaternalUncleListViewByFamilyId(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<reg_famillyEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_famillyFCC.GetFacadeCreate(_contextAccessor)
                .GetFamilyMembersByRelationshipType(message.Objreg_familly, cancellationToken);

                List<dataTableButtonModel> btnActionList = new List<dataTableButtonModel>();
                var edit = new dataTableButtonModel(basicCRUDButtons.Edit_GET);
                edit.isCheckPermission = false;
                edit.JsMethodName = "EditMaternalUncle";

                var delete = new dataTableButtonModel(basicCRUDButtons.Delete_GET);
                delete.isCheckPermission = false;
                delete.JsMethodName = "DeleteMaternalUncle";

                btnActionList.Add(edit);
                btnActionList.Add(delete);


                var data = (from t in oblist
                            select new
                            {
                                t.familyid,
                                t.parentid,
                                t.isinkuwait,
                                t.basicinfoid,
                                t.relationshipid,
                                t.relationshipname,
                                t.familygenderid,
                                t.familyreligionid,
                                t.familybloodgroupid,
                                t.maritalstatusid,
                                t.parentalstatus,
                                t.nationalityid,
                                t.nationalityname,
                                t.classid,
                                t.birthcountryid,
                                t.prevnationalityid,
                                t.birthdate,
                                t.civilid,
                                t.nationalid,
                                t.passportnumber,
                                t.fullname,
                                t.name1,
                                t.name2,
                                t.name3,
                                t.name4,
                                t.name5,
                                t.isservedinmilitary,
                                t.isserving,
                                t.splmilstatus,
                                t.militaryid,
                                t.companyid,
                                t.workdesignation,
                                t.workcompany,
                                t.companytype,
                                t.companyaddress,
                                t.enrollmentdate,
                                t.previousjob,
                                t.previousjobdetails,
                                t.preaddcountryid,
                                t.preaddgovernid,
                                t.preaddgovernarate,
                                t.preaddcityid,
                                t.preaddcity,
                                t.preaddstreet,
                                t.preaddblock,
                                t.preaddhousingno,
                                t.preaddhousingflatno,
                                t.prepaci,
                                t.preaddress,
                                t.pres_latitude,
                                t.pres_longitude,
                                t.peraddcountryid,
                                t.peraddgovernid,
                                t.peraddcityid,
                                t.peraddstreet,
                                t.peraddblock,
                                t.peraddhousingno,
                                t.peraddhousingflatno,
                                t.perpaci,
                                t.peraddress,
                                t.perm_latitude,
                                t.perm_longitude,
                                t.email,
                                t.mobilephone1,
                                t.mobilephone2,
                                t.mobilephone3,
                                t.lanphone1,
                                t.lanphone2,
                                t.lanphone3,
                                t.ismarried,
                                t.familymarriagedate,
                                t.familymarriagedocno,
                                t.familymarriagedocdate,
                                t.deathdate,
                                t.isalive,
                                t.filepath,
                                t.filename,
                                t.filetype,
                                t.extension,
                                t.securitycardvaliddate,
                                t.comment,
                                t.remarks,
                                t.updateinfo,
                                t.tranformactionid,
                                datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objreg_familly.ControllerName, t.familyid, GlobalConstant.MaternalUncleFamilyID, _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList, this._contextAccessor)
                            }).ToList();

                outputPort.GetListView(new Reg_FamillyResponse(new AjaxResponse(oblist.Count > 0 ? oblist[0].RETURN_KEY : 0, data), true, null));
                return true;

            }
            catch (Exception ex)
            {
                Reg_FamillyResponse objResponse = new Reg_FamillyResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetMaternalAuntyListViewByFamilyId(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<reg_famillyEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_famillyFCC.GetFacadeCreate(_contextAccessor)
                .GetFamilyMembersByRelationshipType(message.Objreg_familly, cancellationToken);

                List<dataTableButtonModel> btnActionList = new List<dataTableButtonModel>();
                var edit = new dataTableButtonModel(basicCRUDButtons.Edit_GET);
                edit.isCheckPermission = false;
                edit.JsMethodName = "EditMaternalAunty";

                var delete = new dataTableButtonModel(basicCRUDButtons.Delete_GET);
                delete.isCheckPermission = false;
                delete.JsMethodName = "DeleteMaternalAunty";

                btnActionList.Add(edit);
                btnActionList.Add(delete);


                var data = (from t in oblist
                            select new
                            {
                                t.familyid,
                                t.parentid,
                                t.isinkuwait,
                                t.basicinfoid,
                                t.relationshipid,
                                t.relationshipname,
                                t.familygenderid,
                                t.familyreligionid,
                                t.familybloodgroupid,
                                t.maritalstatusid,
                                t.parentalstatus,
                                t.nationalityid,
                                t.nationalityname,
                                t.classid,
                                t.birthcountryid,
                                t.prevnationalityid,
                                t.birthdate,
                                t.civilid,
                                t.nationalid,
                                t.passportnumber,
                                t.fullname,
                                t.name1,
                                t.name2,
                                t.name3,
                                t.name4,
                                t.name5,
                                t.isservedinmilitary,
                                t.isserving,
                                t.splmilstatus,
                                t.militaryid,
                                t.companyid,
                                t.workdesignation,
                                t.workcompany,
                                t.companytype,
                                t.companyaddress,
                                t.enrollmentdate,
                                t.previousjob,
                                t.previousjobdetails,
                                t.preaddcountryid,
                                t.preaddgovernid,
                                t.preaddgovernarate,
                                t.preaddcityid,
                                t.preaddcity,
                                t.preaddstreet,
                                t.preaddblock,
                                t.preaddhousingno,
                                t.preaddhousingflatno,
                                t.prepaci,
                                t.preaddress,
                                t.pres_latitude,
                                t.pres_longitude,
                                t.peraddcountryid,
                                t.peraddgovernid,
                                t.peraddcityid,
                                t.peraddstreet,
                                t.peraddblock,
                                t.peraddhousingno,
                                t.peraddhousingflatno,
                                t.perpaci,
                                t.peraddress,
                                t.perm_latitude,
                                t.perm_longitude,
                                t.email,
                                t.mobilephone1,
                                t.mobilephone2,
                                t.mobilephone3,
                                t.lanphone1,
                                t.lanphone2,
                                t.lanphone3,
                                t.ismarried,
                                t.familymarriagedate,
                                t.familymarriagedocno,
                                t.familymarriagedocdate,
                                t.deathdate,
                                t.isalive,
                                t.filepath,
                                t.filename,
                                t.filetype,
                                t.extension,
                                t.securitycardvaliddate,
                                t.comment,
                                t.remarks,
                                t.updateinfo,
                                t.tranformactionid,
                                datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objreg_familly.ControllerName, t.familyid, GlobalConstant.MaternalAuntyFamilyID, _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList, this._contextAccessor)
                            }).ToList();

                outputPort.GetListView(new Reg_FamillyResponse(new AjaxResponse(oblist.Count > 0 ? oblist[0].RETURN_KEY : 0, data), true, null));
                return true;

            }
            catch (Exception ex)
            {
                Reg_FamillyResponse objResponse = new Reg_FamillyResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }
        public async Task<bool> GetProfileSpouseListViewByFamilyId(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<reg_famillyEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_famillyFCC.GetFacadeCreate(_contextAccessor)
                .GetFamilyMembersByRelationshipType(message.Objreg_familly, cancellationToken);

                List<dataTableButtonModel> btnActionList = new List<dataTableButtonModel>();
                var edit = new dataTableButtonModel(basicCRUDButtons.Edit_GET);
                edit.isCheckPermission = false;
                edit.JsMethodName = "EditProfileSpouse";

                var delete = new dataTableButtonModel(basicCRUDButtons.Delete_GET);
                delete.isCheckPermission = false;
                delete.JsMethodName = "DeleteProfileSpouse";

                btnActionList.Add(edit);
                btnActionList.Add(delete);


                var data = (from t in oblist
                            select new
                            {
                                t.familyid,
                                t.parentid,
                                t.isinkuwait,
                                t.basicinfoid,
                                t.relationshipid,
                                t.familygenderid,
                                t.familyreligionid,
                                t.familybloodgroupid,
                                t.maritalstatusid,
                                t.parentalstatus,
                                t.nationalityid,
                                t.nationalityname,
                                t.classid,
                                t.birthcountryid,
                                t.prevnationalityid,
                                t.birthdate,
                                t.civilid,
                                t.nationalid,
                                t.passportnumber,
                                t.fullname,
                                t.name1,
                                t.name2,
                                t.name3,
                                t.name4,
                                t.name5,
                                t.isservedinmilitary,
                                t.isserving,
                                t.splmilstatus,
                                t.militaryid,
                                t.companyid,
                                t.workdesignation,
                                t.workcompany,
                                t.companytype,
                                t.companyaddress,
                                t.enrollmentdate,
                                t.previousjob,
                                t.previousjobdetails,
                                t.preaddcountryid,
                                t.preaddgovernid,
                                t.preaddgovernarate,
                                t.preaddcityid,
                                t.preaddcity,
                                t.preaddstreet,
                                t.preaddblock,
                                t.preaddhousingno,
                                t.preaddhousingflatno,
                                t.prepaci,
                                t.preaddress,
                                t.pres_latitude,
                                t.pres_longitude,
                                t.peraddcountryid,
                                t.peraddgovernid,
                                t.peraddcityid,
                                t.peraddstreet,
                                t.peraddblock,
                                t.peraddhousingno,
                                t.peraddhousingflatno,
                                t.perpaci,
                                t.peraddress,
                                t.perm_latitude,
                                t.perm_longitude,
                                t.email,
                                t.mobilephone1,
                                t.mobilephone2,
                                t.mobilephone3,
                                t.lanphone1,
                                t.lanphone2,
                                t.lanphone3,
                                t.ismarried,
                                t.familymarriagedate,
                                t.familymarriagedocno,
                                t.familymarriagedocdate,
                                t.deathdate,
                                t.isalive,
                                t.filepath,
                                t.filename,
                                t.filetype,
                                t.extension,
                                t.securitycardvaliddate,
                                t.comment,
                                t.remarks,
                                t.updateinfo,
                                t.tranformactionid,
                                datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objreg_familly.ControllerName, t.familyid, GlobalConstant.ProfileSpouseFamilyID, _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList, this._contextAccessor)
                            }).ToList();

                outputPort.GetListView(new Reg_FamillyResponse(new AjaxResponse(oblist.Count > 0 ? oblist[0].RETURN_KEY : 0, data), true, null));
                return true;

            }
            catch (Exception ex)
            {
                Reg_FamillyResponse objResponse = new Reg_FamillyResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

    }
}