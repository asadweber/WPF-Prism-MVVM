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
using Web.Core.Frame.Dto.UseCaseResponses.Transaction;

namespace Web.Core.Frame.UseCases.Registration
{
    public sealed partial class Reg_RegistrationInfoUseCase : IReg_RegistrationInfoUseCase
    {

        public async Task<bool> GetFinallySubmittedRegInfoListView(Reg_RegistrationInfoRequest message, IReg_RegistrationInfoHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<reg_registrationinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetFinallySubmittedRegInfoListView(message.Objreg_registrationinfo, cancellationToken);
                if (oblist != null && oblist.Count > 0)
                {

                    //outputPort.GetListView(new Reg_RegistrationInfoResponse(new AjaxResponse(oblist[0].RETURN_KEY, data), true, null));
                    outputPort.GetListViewExt(new Reg_RegistrationInfoResponse(oblist, true, null));
                    return true;
                }
                else
                {
                    outputPort.GetListViewExt(new Reg_RegistrationInfoResponse(new List<reg_registrationinfoEntity>(), true, null));
                    return true;
                }
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListViewExt(objResponse);
                return true;
            }
        }

        public async Task<bool> GetFinallySubmittedRegInfoListForReview(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<reg_registrationinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetFinallySubmittedRegInfoListForReview(message.Objreg_registrationinfo, cancellationToken);
                //if (oblist != null && oblist.Count > 0)
                //{
                List<dataTableButtonModel> btnActionList = new List<dataTableButtonModel>();
                List<dataTableButtonModel> btnActionListOnlyDownload = new List<dataTableButtonModel>();
                btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.CUSTOM, _sharedLocalizer["PROCESS"], "ApplicantReview/ProcessApplicantReview"));
                //btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.CUSTOM, _sharedLocalizer["DOWNLOAD"], "ApplicantReview/DownloadApplicantReview"));
                //btnActionListOnlyDownload.Add(new dataTableButtonModel(basicCRUDButtons.CUSTOM, _sharedLocalizer["DOWNLOAD"], "ApplicantReview/DownloadApplicantReview"));

                var downloadreport = new dataTableButtonModel(basicCRUDButtons.CUSTOM, _sharedLocalizer["DOWNLOAD"]);
                downloadreport.isCheckPermission = false;
                downloadreport.JsMethodName = "DownloadProfileReport";
                btnActionList.Add(downloadreport);
                btnActionListOnlyDownload.Add(downloadreport);

                var data = (from t in oblist
                            select new
                            {
                                t.registrationid,
                                t.basicinfoid,
                                t.batchid,
                                t.batchno,
                                t.candidatetypeid,
                                t.candidatetypename,
                                t.professionname,
                                t.civilid,
                                t.fullname,
                                t.nationality,
                                t.mobno,
                                t.interviewdate,
                                //t.notificationsendbydate,
                                t.noofnotification,
                                t.auditresult,
                                t.auditcomment,
                                t.issecurityforwarded,
                                t.centralagencysyresult,
                                t.centralagencysycomment,
                                t.syexamresult,
                                t.syexamcomment,
                                //datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objreg_registrationinfo.ControllerName, t.registrationid, GlobalConstant.RegistrationID, _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, (t.issecurityforwarded == true) ? btnActionListOnlyDownload : btnActionList, _contextAccessor)
                                datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objreg_registrationinfo.ControllerName, t.registrationid, GlobalConstant.RegistrationID, _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList, _contextAccessor)
                            }).ToList();

                outputPort.GetListView(new Reg_RegistrationInfoResponse(new AjaxResponse(data.Count > 0 ? oblist[0].RETURN_KEY : 0, data), true, null));
                return true;
                //}
                //else
                //{
                //    Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                //        "404",
                //        _sharedLocalizer["NO_DATA_FOUND"]));
                //    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                //    outputPort.GetListView(objResponse);
                //    return false;
                //}
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetRegInfoListForVolunteerSecurityClearance(Reg_RegistrationInfoRequest message, IReg_RegistrationInfoHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<reg_registrationinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetRegInfoListForVolunteerSecurityClearance(message.Objreg_registrationinfo, cancellationToken);
                if (oblist != null && oblist.Count > 0)
                {

                    //outputPort.GetListView(new Reg_RegistrationInfoResponse(new AjaxResponse(oblist[0].RETURN_KEY, data), true, null));
                    outputPort.GetListViewExt(new Reg_RegistrationInfoResponse(oblist, true, null));
                    return true;
                }
                else
                {
                    outputPort.GetListViewExt(new Reg_RegistrationInfoResponse(new List<reg_registrationinfoEntity>(), true, null));
                    return true;
                }
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListViewExt(objResponse);
                return true;
            }
        }

        public async Task<bool> GetRegInfoListDTForVolunteerSecurityClearance(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<reg_registrationinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetRegInfoListForVolunteerSecurityClearance(message.Objreg_registrationinfo, cancellationToken);

                List<dataTableButtonModel> btnActionList = new List<dataTableButtonModel>();

                var documents = new dataTableButtonModel(basicCRUDButtons.CUSTOM, CLL.LLClasses.Models._PreRegistrationResource.Documents);
                documents.isCheckPermission = false;
                documents.JsMethodName = "ShowProfileDocuments";

                var profilereport = new dataTableButtonModel(basicCRUDButtons.CUSTOM, CLL.LLClasses.Models._tran_volunteermedclearance.showprofilereport);
                profilereport.isCheckPermission = false;
                profilereport.JsMethodName = "ShowProfileReport";

                btnActionList.Add(documents);
                btnActionList.Add(profilereport);

                var data = (from t in oblist
                            select new
                            {
                                t.registrationid,
                                t.basicinfoid,
                                t.batchid,
                                t.batchno,
                                t.candidatetypeid,
                                t.candidatetypename,
                                t.professionname,
                                t.civilid,
                                t.fullname,
                                t.nationality,
                                t.mobno,
                                t.auditresult,
                                t.auditdate,
                                t.submitteddate,
                                t.issecurityforwarded,
                                t.SendBy,
                                t.SendDate,
                                strModelForigenKey = objClsPrivate.EncodeUrlOnlyParams(GlobalConstant.BasicInfoId, t.basicinfoid.ToString()),
                                datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objreg_registrationinfo.ControllerName, t.registrationid, GlobalConstant.RegistrationID, _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList, _contextAccessor)
                            }).ToList();

                outputPort.GetListView(new Reg_RegistrationInfoResponse(new AjaxResponse(data.Count > 0 ? oblist[0].RETURN_KEY : 0, data), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetRegInfoListForSecurityReTestApproval(Reg_RegistrationInfoRequest message, IReg_RegistrationInfoHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<reg_registrationinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetRegInfoListForSecurityReTestApproval(message.Objreg_registrationinfo, cancellationToken);
                if (oblist != null && oblist.Count > 0)
                {

                    //outputPort.GetListView(new Reg_RegistrationInfoResponse(new AjaxResponse(oblist[0].RETURN_KEY, data), true, null));
                    outputPort.GetListViewExt(new Reg_RegistrationInfoResponse(oblist, true, null));
                    return true;
                }
                else
                {
                    outputPort.GetListViewExt(new Reg_RegistrationInfoResponse(new List<reg_registrationinfoEntity>(), true, null));
                    return true;
                }
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListViewExt(objResponse);
                return true;
            }
        }

        public async Task<bool> GetRegInfoListDTForSecurityReTestApproval(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<reg_registrationinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetRegInfoListForSecurityReTestApproval(message.Objreg_registrationinfo, cancellationToken);

                List<dataTableButtonModel> btnActionList = new List<dataTableButtonModel>();

                var documents = new dataTableButtonModel(basicCRUDButtons.CUSTOM, CLL.LLClasses.Models._PreRegistrationResource.Documents);
                documents.isCheckPermission = false;
                documents.JsMethodName = "ShowProfileDocuments";

                var profilereport = new dataTableButtonModel(basicCRUDButtons.CUSTOM, CLL.LLClasses.Models._tran_volunteermedclearance.showprofilereport);
                profilereport.isCheckPermission = false;
                profilereport.JsMethodName = "ShowProfileReport";

                btnActionList.Add(documents);
                btnActionList.Add(profilereport);

                var data = (from t in oblist
                            select new
                            {
                                t.registrationid,
                                t.basicinfoid,
                                t.batchid,
                                t.batchno,
                                t.candidatetypeid,
                                t.candidatetypename,
                                t.professionname,
                                t.civilid,
                                t.fullname,
                                t.nationality,
                                t.mobno,
                                t.auditresult,
                                t.auditdate,
                                t.issyretestapproved,
                                t.resultdate,
                                t.resultexpirydate,
                                t.approvedby,
                                t.approvaldate,
                                strModelForigenKey = objClsPrivate.EncodeUrlOnlyParams(GlobalConstant.BasicInfoId, t.basicinfoid.ToString()),
                                datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objreg_registrationinfo.ControllerName, t.registrationid, GlobalConstant.RegistrationID, _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList, _contextAccessor)
                            }).ToList();

                outputPort.GetListView(new Reg_RegistrationInfoResponse(new AjaxResponse(data.Count > 0 ? oblist[0].RETURN_KEY : 0, data), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetRegInfoListForCentralAgencySy(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<reg_registrationinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetRegInfoListForCentralAgencySy(message.Objreg_registrationinfo, cancellationToken);
                //if (oblist != null && oblist.Count > 0)
                //{
                List<dataTableButtonModel> btnActionList = new List<dataTableButtonModel>();
                List<dataTableButtonModel> btnActionListViewOnly = new List<dataTableButtonModel>();

                var edit = new dataTableButtonModel(basicCRUDButtons.Edit_GET);
                edit.isCheckPermission = false;
                edit.JsMethodName = "EditSyExam";

                var documents = new dataTableButtonModel(basicCRUDButtons.CUSTOM, CLL.LLClasses.Models._PreRegistrationResource.Documents);
                documents.isCheckPermission = false;
                documents.JsMethodName = "ShowProfileDocuments";

                var profilereport = new dataTableButtonModel(basicCRUDButtons.CUSTOM, CLL.LLClasses.Models._tran_volunteermedclearance.showprofilereport);
                profilereport.isCheckPermission = false;
                profilereport.JsMethodName = "ShowProfileReport";

                btnActionList.Add(edit);
                btnActionList.Add(documents);
                btnActionList.Add(profilereport);

                btnActionListViewOnly.Add(documents);
                btnActionListViewOnly.Add(profilereport);

                var data = (from t in oblist
                            select new
                            {
                                t.registrationid,
                                t.basicinfoid,
                                t.batchid,
                                t.batchno,
                                t.civilid,
                                t.fullname,
                                t.nationality,
                                t.mobno,
                                t.auditdate,
                                t.syforwardeddate,
                                t.centralagencysyresult,
                                t.candidatetypename,
                                t.professionname,
                                strModelForigenKey = objClsPrivate.EncodeUrlOnlyParams(GlobalConstant.BasicInfoId, t.basicinfoid.ToString()),
                                datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objreg_registrationinfo.ControllerName, t.registrationid, GlobalConstant.RegistrationID, _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, (t.syexamresult > 0) ? btnActionListViewOnly : btnActionList, _contextAccessor)
                            }).ToList();

                outputPort.GetListView(new Reg_RegistrationInfoResponse(new AjaxResponse(data.Count > 0 ? oblist[0].RETURN_KEY : 0, data), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetRegInfoListForSecurityExam(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<reg_registrationinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetRegInfoListForSecurityExam(message.Objreg_registrationinfo, cancellationToken);
                //if (oblist != null && oblist.Count > 0)
                //{
                List<dataTableButtonModel> btnActionList = new List<dataTableButtonModel>();
                List<dataTableButtonModel> btnActionListWithPrint = new List<dataTableButtonModel>();
                List<dataTableButtonModel> btnActionListViewOnly = new List<dataTableButtonModel>();
                var edit = new dataTableButtonModel(basicCRUDButtons.Edit_GET);
                edit.isCheckPermission = false;
                edit.JsMethodName = "EditSyExam";

                var printreport = new dataTableButtonModel(basicCRUDButtons.CUSTOM, CLL.LLClasses._Common._print);
                printreport.isCheckPermission = false;
                printreport.JsMethodName = "PrintProfileReport";

                var documents = new dataTableButtonModel(basicCRUDButtons.CUSTOM, CLL.LLClasses.Models._PreRegistrationResource.Documents);
                documents.isCheckPermission = false;
                documents.JsMethodName = "ShowProfileDocuments";

                var profilereport = new dataTableButtonModel(basicCRUDButtons.CUSTOM, CLL.LLClasses.Models._tran_volunteermedclearance.showprofilereport);
                profilereport.isCheckPermission = false;
                profilereport.JsMethodName = "ShowProfileReport";

                var notify = new dataTableButtonModel(basicCRUDButtons.CUSTOM, _sharedLocalizer["SEND_NOTIFICATION"]);
                notify.isCheckPermission = false;
                notify.JsMethodName = "SendNotification";

                var viewDocument = new dataTableButtonModel(basicCRUDButtons.CUSTOM, _sharedLocalizer["GetSingle_GET"]);
                viewDocument.isCheckPermission = false;
                viewDocument.JsMethodName = "showDocument";

                //Btn list for edit mode
                btnActionList.Add(edit);
                btnActionList.Add(documents);
                btnActionList.Add(profilereport);
                btnActionList.Add(notify);

                //Btn list for edit mode with print profile
                btnActionListWithPrint.Add(edit);
                btnActionListWithPrint.Add(printreport);
                btnActionListWithPrint.Add(documents);
                btnActionListWithPrint.Add(profilereport);
                btnActionListWithPrint.Add(notify);

                //Btn list for view mode
                btnActionListViewOnly.Add(viewDocument);
                btnActionListViewOnly.Add(documents);
                btnActionListViewOnly.Add(profilereport);

                var data = (from t in oblist
                            select new
                            {
                                t.registrationid,
                                t.basicinfoid,
                                t.batchid,
                                t.batchno,
                                t.candidatetypeid,
                                t.candidatetypename,
                                t.civilid,
                                t.fullname,
                                t.nationality,
                                t.mobno,
                                t.auditdate,
                                t.syforwardeddate,
                                t.isunitforwarded,
                                t.centralagencysyresult,
                                t.syexamresult,
                                t.ismedforwarded,
                                //t.notificationsendbydate,
                                t.noofnotification,
                                t.syprofileprint,
                                t.issyresultexpired,
                                t.issyretestapproved,
                                strModelPrimaryKey = objClsPrivate.EncodeUrlOnlyParams(GlobalConstant.RegistrationID, t.registrationid.ToString()),
                                strModelForigenKey = objClsPrivate.EncodeUrlOnlyParams(GlobalConstant.BasicInfoId, t.basicinfoid.ToString()),
                                datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objreg_registrationinfo.ControllerName, t.registrationid, GlobalConstant.RegistrationID, _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, ((t.isunitforwarded == false && t.ismedforwarded == false) || (t.issyresultexpired == true && t.issyretestapproved == true)) ? ((t.syprofileprint == false || t.syprofileprint == null) ? btnActionListWithPrint : btnActionList) : btnActionListViewOnly, _contextAccessor)
                            }).ToList();

                outputPort.GetListView(new Reg_RegistrationInfoResponse(new AjaxResponse(data.Count > 0 ? oblist[0].RETURN_KEY : 0, data), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetRegInfoListForVolunteerUnitClearance(Reg_RegistrationInfoRequest message, IReg_RegistrationInfoHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<reg_registrationinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetRegInfoListForVolunteerUnitClearance(message.Objreg_registrationinfo, cancellationToken);
                if (oblist != null && oblist.Count > 0)
                {

                    //outputPort.GetListView(new Reg_RegistrationInfoResponse(new AjaxResponse(oblist[0].RETURN_KEY, data), true, null));
                    outputPort.GetListViewExt(new Reg_RegistrationInfoResponse(oblist, true, null));
                    return true;
                }
                else
                {
                    outputPort.GetListViewExt(new Reg_RegistrationInfoResponse(new List<reg_registrationinfoEntity>(), true, null));
                    return true;
                }
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListViewExt(objResponse);
                return true;
            }
        }

        public async Task<bool> GetRegInfoListDTForVolunteerUnitClearance(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<reg_registrationinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetRegInfoListForVolunteerUnitClearance(message.Objreg_registrationinfo, cancellationToken);

                List<dataTableButtonModel> btnActionList = new List<dataTableButtonModel>();

                var documents = new dataTableButtonModel(basicCRUDButtons.CUSTOM, CLL.LLClasses.Models._PreRegistrationResource.Documents);
                documents.isCheckPermission = false;
                documents.JsMethodName = "ShowProfileDocuments";

                var profilereport = new dataTableButtonModel(basicCRUDButtons.CUSTOM, "Profile Report");
                profilereport.isCheckPermission = false;
                profilereport.JsMethodName = "ShowProfileReport";

                btnActionList.Add(documents);
                btnActionList.Add(profilereport);

                var data = (from t in oblist
                            select new
                            {
                                t.registrationid,
                                t.basicinfoid,
                                t.batchid,
                                t.batchno,
                                t.candidatetypeid,
                                t.candidatetypename,
                                t.professionname,
                                t.civilid,
                                t.fullname,
                                t.nationality,
                                t.mobno,
                                t.syclearancedate,
                                t.isunitforwarded,
                                t.SendBy,
                                t.SendDate,
                                strModelForigenKey = objClsPrivate.EncodeUrlOnlyParams(GlobalConstant.BasicInfoId, t.basicinfoid.ToString()),
                                datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objreg_registrationinfo.ControllerName, t.registrationid, GlobalConstant.RegistrationID, _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList, _contextAccessor)
                            }).ToList();

                outputPort.GetListView(new Reg_RegistrationInfoResponse(new AjaxResponse(data.Count > 0 ? oblist[0].RETURN_KEY : 0, data), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetRegInfoListForUnitClearance(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<reg_registrationinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetRegInfoListForUnitClearance(message.Objreg_registrationinfo, cancellationToken);
                //if (oblist != null && oblist.Count > 0)
                //{
                List<dataTableButtonModel> btnActionList = new List<dataTableButtonModel>();
                List<dataTableButtonModel> btnActionListViewOnly = new List<dataTableButtonModel>();
                var edit = new dataTableButtonModel(basicCRUDButtons.Edit_GET);
                edit.isCheckPermission = false;
                edit.JsMethodName = "EditUnitClearance";

                var documents = new dataTableButtonModel(basicCRUDButtons.CUSTOM, CLL.LLClasses.Models._PreRegistrationResource.Documents);
                documents.isCheckPermission = false;
                documents.JsMethodName = "ShowProfileDocuments";

                var profilereport = new dataTableButtonModel(basicCRUDButtons.CUSTOM, CLL.LLClasses.Models._tran_volunteermedclearance.showprofilereport);
                profilereport.isCheckPermission = false;
                profilereport.JsMethodName = "ShowProfileReport";

                var viewDocument = new dataTableButtonModel(basicCRUDButtons.CUSTOM, _sharedLocalizer["GetSingle_GET"]);
                viewDocument.isCheckPermission = false;
                viewDocument.JsMethodName = "showDocument";

                //Btn list for edit mode
                btnActionList.Add(edit);
                btnActionList.Add(documents);
                btnActionList.Add(profilereport);

                //Btn list for view mode
                btnActionListViewOnly.Add(viewDocument);
                btnActionListViewOnly.Add(documents);
                btnActionListViewOnly.Add(profilereport);

                var data = (from t in oblist
                            select new
                            {
                                t.registrationid,
                                t.basicinfoid,
                                t.batchid,
                                t.batchno,
                                t.candidatetypeid,
                                t.candidatetypename,
                                t.civilid,
                                t.fullname,
                                t.nationality,
                                t.mobno,
                                t.auditdate,
                                t.unitforwardeddate,
                                t.centralagencysyresult,
                                t.unitclearanceresult,
                                t.ismedforwarded,
                                strModelForigenKey = objClsPrivate.EncodeUrlOnlyParams(GlobalConstant.BasicInfoId, t.basicinfoid.ToString()),
                                datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objreg_registrationinfo.ControllerName, t.registrationid, GlobalConstant.RegistrationID, _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, (t.ismedforwarded == false) ? btnActionList : btnActionListViewOnly, _contextAccessor)
                            }).ToList();

                outputPort.GetListView(new Reg_RegistrationInfoResponse(new AjaxResponse(data.Count > 0 ? oblist[0].RETURN_KEY : 0, data), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetRegInfoListForVolunteerMedicalClearance(Reg_RegistrationInfoRequest message, IReg_RegistrationInfoHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<reg_registrationinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetRegInfoListForVolunteerMedicalClearance(message.Objreg_registrationinfo, cancellationToken);
                if (oblist != null && oblist.Count > 0)
                {

                    //outputPort.GetListView(new Reg_RegistrationInfoResponse(new AjaxResponse(oblist[0].RETURN_KEY, data), true, null));
                    outputPort.GetListViewExt(new Reg_RegistrationInfoResponse(oblist, true, null));
                    return true;
                }
                else
                {
                    outputPort.GetListViewExt(new Reg_RegistrationInfoResponse(new List<reg_registrationinfoEntity>(), true, null));
                    return true;
                }
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListViewExt(objResponse);
                return true;
            }
        }

        public async Task<bool> GetRegInfoListDTForVolunteerMedicalClearance(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<reg_registrationinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetRegInfoListForVolunteerMedicalClearance(message.Objreg_registrationinfo, cancellationToken);

                List<dataTableButtonModel> btnActionList = new List<dataTableButtonModel>();

                var documents = new dataTableButtonModel(basicCRUDButtons.CUSTOM, CLL.LLClasses.Models._PreRegistrationResource.Documents);
                documents.isCheckPermission = false;
                documents.JsMethodName = "ShowProfileDocuments";

                var profilereport = new dataTableButtonModel(basicCRUDButtons.CUSTOM, CLL.LLClasses.Models._tran_volunteermedclearance.showprofilereport);
                profilereport.isCheckPermission = false;
                profilereport.JsMethodName = "ShowProfileReport";

                btnActionList.Add(documents);
                btnActionList.Add(profilereport);

                var data = (from t in oblist
                            select new
                            {
                                t.registrationid,
                                t.basicinfoid,
                                t.batchid,
                                t.batchno,
                                t.candidatetypeid,
                                t.candidatetypename,
                                t.professionname,
                                t.civilid,
                                t.fullname,
                                t.nationality,
                                t.mobno,
                                t.syclearancedate,
                                t.ismedforwarded,
                                t.SendBy,
                                t.SendDate,
                                strModelForigenKey = objClsPrivate.EncodeUrlOnlyParams(GlobalConstant.BasicInfoId, t.basicinfoid.ToString()),
                                datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objreg_registrationinfo.ControllerName, t.registrationid, GlobalConstant.RegistrationID, _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList, _contextAccessor)
                            }).ToList();

                outputPort.GetListView(new Reg_RegistrationInfoResponse(new AjaxResponse(data.Count > 0 ? oblist[0].RETURN_KEY : 0, data), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetRegInfoListForGeneralMedicalExam(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<reg_registrationinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetRegInfoListForGeneralMedicalExam(message.Objreg_registrationinfo, cancellationToken);
                //if (oblist != null && oblist.Count > 0)
                //{
                List<dataTableButtonModel> btnActionList = new List<dataTableButtonModel>();
                List<dataTableButtonModel> btnActionListWithPrint = new List<dataTableButtonModel>();
                List<dataTableButtonModel> btnActionListViewOnly = new List<dataTableButtonModel>();
                var edit = new dataTableButtonModel(basicCRUDButtons.Edit_GET);
                edit.isCheckPermission = false;
                edit.JsMethodName = "EditGeneralMedExam";

                var printReport = new dataTableButtonModel(basicCRUDButtons.CUSTOM, CLL.LLClasses._Common._print);
                printReport.isCheckPermission = false;
                printReport.JsMethodName = "PrintMedExamReport";

                var documents = new dataTableButtonModel(basicCRUDButtons.CUSTOM, CLL.LLClasses.Models._PreRegistrationResource.Documents);
                documents.isCheckPermission = false;
                documents.JsMethodName = "ShowProfileDocuments";

                var profilereport = new dataTableButtonModel(basicCRUDButtons.CUSTOM, CLL.LLClasses.Models._tran_volunteermedclearance.showprofilereport);
                profilereport.isCheckPermission = false;
                profilereport.JsMethodName = "ShowProfileReport";

                var viewDocument = new dataTableButtonModel(basicCRUDButtons.CUSTOM, _sharedLocalizer["GetSingle_GET"]);
                viewDocument.isCheckPermission = false;
                viewDocument.JsMethodName = "showDocument";

                var notify = new dataTableButtonModel(basicCRUDButtons.CUSTOM, _sharedLocalizer["SEND_NOTIFICATION"]);
                notify.isCheckPermission = false;
                notify.JsMethodName = "SendNotification";

                //Btn list for edit mode
                btnActionList.Add(edit);
                btnActionList.Add(documents);
                btnActionList.Add(profilereport);
                btnActionList.Add(notify);

                //Btn list for edit and print mode
                btnActionListWithPrint.Add(edit);
                btnActionListWithPrint.Add(printReport);
                btnActionListWithPrint.Add(documents);
                btnActionListWithPrint.Add(profilereport);
                btnActionListWithPrint.Add(notify);

                //Btn list for view mode
                btnActionListViewOnly.Add(viewDocument);
                btnActionListViewOnly.Add(documents);
                btnActionListViewOnly.Add(profilereport);

                var data = (from t in oblist
                            select new
                            {
                                t.registrationid,
                                t.basicinfoid,
                                t.batchid,
                                t.batchno,
                                t.candidatetypeid,
                                t.candidatetypename,
                                t.civilid,
                                t.fullname,
                                t.nationality,
                                t.mobno,
                                t.auditdate,
                                t.unitclearancemark,
                                t.medforwardeddate,
                                t.medexamresult,
                                t.noofnotification,
                                strModelPrimaryKey = objClsPrivate.EncodeUrlOnlyParams(GlobalConstant.RegistrationID, t.registrationid.ToString()),
                                strModelForigenKey = objClsPrivate.EncodeUrlOnlyParams(GlobalConstant.BasicInfoId, t.basicinfoid.ToString()),
                                datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objreg_registrationinfo.ControllerName, t.registrationid, GlobalConstant.RegistrationID, _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, (t.finalexamresult > 0) ? btnActionListViewOnly : (t.medexamformprint == null || t.medexamformprint == false ? btnActionListWithPrint : btnActionList), _contextAccessor)
                            }).ToList();

                outputPort.GetListView(new Reg_RegistrationInfoResponse(new AjaxResponse(data.Count > 0 ? oblist[0].RETURN_KEY : 0, data), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetRegInfoListForPsychologyExam(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<reg_registrationinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetRegInfoListForPsychologyExam(message.Objreg_registrationinfo, cancellationToken);
                //if (oblist != null && oblist.Count > 0)
                //{
                List<dataTableButtonModel> btnActionList = new List<dataTableButtonModel>();
                List<dataTableButtonModel> btnActionListViewOnly = new List<dataTableButtonModel>();
                var edit = new dataTableButtonModel(basicCRUDButtons.Edit_GET);
                edit.isCheckPermission = false;
                edit.JsMethodName = "EditPsychologyExam";

                var documents = new dataTableButtonModel(basicCRUDButtons.CUSTOM, CLL.LLClasses.Models._PreRegistrationResource.Documents);
                documents.isCheckPermission = false;
                documents.JsMethodName = "ShowProfileDocuments";

                var profilereport = new dataTableButtonModel(basicCRUDButtons.CUSTOM, CLL.LLClasses.Models._tran_volunteermedclearance.showprofilereport);
                profilereport.isCheckPermission = false;
                profilereport.JsMethodName = "ShowProfileReport";

                var viewDocument = new dataTableButtonModel(basicCRUDButtons.CUSTOM, _sharedLocalizer["GetSingle_GET"]);
                viewDocument.isCheckPermission = false;
                viewDocument.JsMethodName = "showDocument";

                //Btn list for edit mode
                btnActionList.Add(edit);
                btnActionList.Add(documents);
                btnActionList.Add(profilereport);

                //Btn list for view mode
                btnActionListViewOnly.Add(viewDocument);
                btnActionListViewOnly.Add(documents);
                btnActionListViewOnly.Add(profilereport);

                var data = (from t in oblist
                            select new
                            {
                                t.registrationid,
                                t.basicinfoid,
                                t.batchid,
                                t.batchno,
                                t.candidatetypeid,
                                t.candidatetypename,
                                t.civilid,
                                t.fullname,
                                t.nationality,
                                t.mobno,
                                t.auditdate,
                                t.medforwardeddate,
                                t.psychoexamresult,
                                strModelForigenKey = objClsPrivate.EncodeUrlOnlyParams(GlobalConstant.BasicInfoId, t.basicinfoid.ToString()),
                                datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objreg_registrationinfo.ControllerName, t.registrationid, GlobalConstant.RegistrationID, _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, (t.finalexamresult > 0) ? btnActionListViewOnly : btnActionList, _contextAccessor)
                            }).ToList();

                outputPort.GetListView(new Reg_RegistrationInfoResponse(new AjaxResponse(data.Count > 0 ? oblist[0].RETURN_KEY : 0, data), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetRegInfoListForFinalExam(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<reg_registrationinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetRegInfoListForFinalExam(message.Objreg_registrationinfo, cancellationToken);
                //if (oblist != null && oblist.Count > 0)
                //{
                List<dataTableButtonModel> btnActionList = new List<dataTableButtonModel>();
                List<dataTableButtonModel> btnActionListViewOnly = new List<dataTableButtonModel>();
                var edit = new dataTableButtonModel(basicCRUDButtons.Edit_GET);
                edit.isCheckPermission = false;
                edit.JsMethodName = "EditFinalExam";

                var documents = new dataTableButtonModel(basicCRUDButtons.CUSTOM, CLL.LLClasses.Models._PreRegistrationResource.Documents);
                documents.isCheckPermission = false;
                documents.JsMethodName = "ShowProfileDocuments";

                var profilereport = new dataTableButtonModel(basicCRUDButtons.CUSTOM, CLL.LLClasses.Models._tran_volunteermedclearance.showprofilereport);
                profilereport.isCheckPermission = false;
                profilereport.JsMethodName = "ShowProfileReport";

                var viewDocument = new dataTableButtonModel(basicCRUDButtons.CUSTOM, _sharedLocalizer["GetSingle_GET"]);
                viewDocument.isCheckPermission = false;
                viewDocument.JsMethodName = "showDocument";

                //Btn list for edit mode
                btnActionList.Add(edit);
                btnActionList.Add(documents);
                btnActionList.Add(profilereport);

                //Btn list for view mode
                btnActionListViewOnly.Add(viewDocument);
                btnActionListViewOnly.Add(documents);
                btnActionListViewOnly.Add(profilereport);

                var data = (from t in oblist
                            select new
                            {
                                t.registrationid,
                                t.basicinfoid,
                                t.batchid,
                                t.batchno,
                                t.candidatetypeid,
                                t.candidatetypename,
                                t.civilid,
                                t.fullname,
                                t.nationality,
                                t.mobno,
                                t.auditdate,
                                t.noofnotification,
                                t.medexamresultdate,
                                t.finalexamresult,
                                strModelPrimaryKey = objClsPrivate.EncodeUrlOnlyParams(GlobalConstant.RegistrationID, t.registrationid.ToString()),
                                strModelForigenKey = objClsPrivate.EncodeUrlOnlyParams(GlobalConstant.BasicInfoId, t.basicinfoid.ToString()),
                                datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objreg_registrationinfo.ControllerName, t.registrationid, GlobalConstant.RegistrationID, _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, (t.istrgjoinenabled == true) ? btnActionListViewOnly : btnActionList, _contextAccessor)
                            }).ToList();

                outputPort.GetListView(new Reg_RegistrationInfoResponse(new AjaxResponse(data.Count > 0 ? oblist[0].RETURN_KEY : 0, data), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetRegInfoListForTrainingJoin(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<reg_registrationinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetRegInfoListForTrainingJoin(message.Objreg_registrationinfo, cancellationToken);
                //if (oblist != null && oblist.Count > 0)
                //{
                List<dataTableButtonModel> btnActionList = new List<dataTableButtonModel>();
                List<dataTableButtonModel> btnActionListViewOnly = new List<dataTableButtonModel>();
                var edit = new dataTableButtonModel(basicCRUDButtons.Edit_GET);
                edit.isCheckPermission = false;
                edit.JsMethodName = "EditTrainingJoin";

                var viewDocument = new dataTableButtonModel(basicCRUDButtons.CUSTOM, _sharedLocalizer["GetSingle_GET"]);
                viewDocument.isCheckPermission = false;
                viewDocument.JsMethodName = "showDocument";

                var documents = new dataTableButtonModel(basicCRUDButtons.CUSTOM, CLL.LLClasses.Models._PreRegistrationResource.Documents);
                documents.isCheckPermission = false;
                documents.JsMethodName = "ShowProfileDocuments";

                var profilereport = new dataTableButtonModel(basicCRUDButtons.CUSTOM, CLL.LLClasses.Models._tran_volunteermedclearance.showprofilereport);
                profilereport.isCheckPermission = false;
                profilereport.JsMethodName = "ShowProfileReport";

                btnActionList.Add(edit);
                btnActionList.Add(documents);
                btnActionList.Add(profilereport);

                btnActionListViewOnly.Add(viewDocument);
                btnActionListViewOnly.Add(documents);
                btnActionListViewOnly.Add(profilereport);

                var data = (from t in oblist
                            select new
                            {
                                t.registrationid,
                                t.basicinfoid,
                                t.batchid,
                                t.batchno,
                                t.candidatetypeid,
                                t.candidatetypename,
                                t.civilid,
                                t.fullname,
                                t.nationality,
                                t.mobno,
                                t.auditdate,
                                t.finalexamResultDate,
                                t.TrgJoinID,
                                t.TrgCentreID,
                                t.TrgCentreName,
                                t.JoinDate,
                                t.VolunteerNo,
                                t.noofnotification,
                                t.OrderNo,
                                t.OrderDate,
                                strModelPrimaryKey = objClsPrivate.EncodeUrlOnlyParams(GlobalConstant.RegistrationID, t.registrationid.ToString()),
                                strModelForigenKey = objClsPrivate.EncodeUrlOnlyParams(GlobalConstant.BasicInfoId, t.basicinfoid.ToString()),
                                datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objreg_registrationinfo.ControllerName, t.registrationid, GlobalConstant.RegistrationID, _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, (t.isexported == true ? btnActionListViewOnly : btnActionList), _contextAccessor)
                            }).ToList();

                outputPort.GetListView(new Reg_RegistrationInfoResponse(new AjaxResponse(data.Count > 0 ? oblist[0].RETURN_KEY : 0, data), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> ApplicantReviewAuditResultUpdate(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                    .ApplicantReviewAuditResultUpdate(message.Objreg_registrationinfo, cancellationToken);

                outputPort.Update(new Reg_RegistrationInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> ForwardSecurityExamination(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                    .ForwardSecurityExamination(message.Objreg_registrationinfo, cancellationToken);

                outputPort.Update(new Reg_RegistrationInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> GroupForwardSecurityExamination(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                    .GroupForwardSecurityExamination(message.Objreg_registrationinfo.RegistrationInfoList, cancellationToken);

                outputPort.Update(new Reg_RegistrationInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> ApproveSecurityExaminationReTest(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                    .ApproveSecurityExaminationReTest(message.Objreg_registrationinfo, cancellationToken);

                outputPort.Update(new Reg_RegistrationInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> GroupApproveSecurityExaminationReTest(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                    .GroupApproveSecurityExaminationReTest(message.Objreg_registrationinfo.RegistrationInfoList, cancellationToken);

                outputPort.Update(new Reg_RegistrationInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> SecurityExaminationResultUpdate(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                //upload document
                bool allowFileUpload = true;
                if (message.Objreg_registrationinfo.DocumentList != null && message.Objreg_registrationinfo.DocumentList.Count > 0)
                {
                    allowFileUpload = await UploadDocument(message.Objreg_registrationinfo.strModelForigenKey1, message.Objreg_registrationinfo.DocumentList);
                }

                if (allowFileUpload)
                {
                    i = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                        .SecurityExaminationResultUpdate(message.Objreg_registrationinfo, cancellationToken);
                    outputPort.Update(new Reg_RegistrationInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                            ), true, null));
                    return true;
                }
                else
                {
                    if (message.Objreg_registrationinfo.DocumentList != null)
                    {
                        foreach (var basicDoc in message.Objreg_registrationinfo.DocumentList)
                        {
                            fileuploadclient.DeleteFileFTP(basicDoc.foldercontentid, basicDoc.filename, basicDoc.extension);
                        }
                    }
                    var objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["FILE_FORMAT_NOT_SUPPORTED"].Value, new Error("415", _sharedLocalizer["FILE_FORMAT_NOT_SUPPORTED"].Value));
                    outputPort.Update(objResponse);
                    _logger.LogError(JsonConvert.SerializeObject(objResponse));
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> ForwardUnitClearance(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                    .ForwardUnitClearance(message.Objreg_registrationinfo, cancellationToken);

                outputPort.Update(new Reg_RegistrationInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> GroupForwardUnitClearance(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                    .GroupForwardUnitClearance(message.Objreg_registrationinfo.RegistrationInfoList, cancellationToken);

                outputPort.Update(new Reg_RegistrationInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> UnitClearanceResultUpdate(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                //upload document
                bool allowFileUpload = true;
                if (message.Objreg_registrationinfo.DocumentList != null && message.Objreg_registrationinfo.DocumentList.Count > 0)
                {
                    allowFileUpload = await UploadDocument(message.Objreg_registrationinfo.strModelForigenKey1, message.Objreg_registrationinfo.DocumentList);
                }

                if (allowFileUpload)
                {
                    i = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                        .UnitClearanceResultUpdate(message.Objreg_registrationinfo, cancellationToken);

                    outputPort.Update(new Reg_RegistrationInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                            ), true, null));
                    return true;
                }
                else
                {
                    if (message.Objreg_registrationinfo.DocumentList != null)
                    {
                        foreach (var basicDoc in message.Objreg_registrationinfo.DocumentList)
                        {
                            fileuploadclient.DeleteFileFTP(basicDoc.foldercontentid, basicDoc.filename, basicDoc.extension);
                        }
                    }
                    var objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["FILE_FORMAT_NOT_SUPPORTED"].Value, new Error("415", _sharedLocalizer["FILE_FORMAT_NOT_SUPPORTED"].Value));
                    outputPort.Update(objResponse);
                    _logger.LogError(JsonConvert.SerializeObject(objResponse));
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> ForwardMedicalClearance(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                    .ForwardMedicalClearance(message.Objreg_registrationinfo, cancellationToken);

                outputPort.Update(new Reg_RegistrationInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> GroupForwardMedicalClearance(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                    .GroupForwardMedicalClearance(message.Objreg_registrationinfo.RegistrationInfoList, cancellationToken);

                outputPort.Update(new Reg_RegistrationInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> GeneralMedicalExaminationResultUpdate(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                //upload document
                bool allowFileUpload = true;
                if (message.Objreg_registrationinfo.DocumentList != null && message.Objreg_registrationinfo.DocumentList.Count > 0)
                {
                    allowFileUpload = await UploadDocument(message.Objreg_registrationinfo.strModelForigenKey1, message.Objreg_registrationinfo.DocumentList);
                }

                if (allowFileUpload)
                {
                    i = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                    .GeneralMedicalExaminationResultUpdate(message.Objreg_registrationinfo, cancellationToken);

                    outputPort.Update(new Reg_RegistrationInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                            ), true, null));
                    return true;
                }
                else
                {
                    if (message.Objreg_registrationinfo.DocumentList != null)
                    {
                        foreach (var basicDoc in message.Objreg_registrationinfo.DocumentList)
                        {
                            fileuploadclient.DeleteFileFTP(basicDoc.foldercontentid, basicDoc.filename, basicDoc.extension);
                        }
                    }
                    var objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["FILE_FORMAT_NOT_SUPPORTED"].Value, new Error("415", _sharedLocalizer["FILE_FORMAT_NOT_SUPPORTED"].Value));
                    outputPort.Update(objResponse);
                    _logger.LogError(JsonConvert.SerializeObject(objResponse));
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> PsychologyExaminationResultUpdate(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                //upload document
                bool allowFileUpload = true;
                if (message.Objreg_registrationinfo.DocumentList != null && message.Objreg_registrationinfo.DocumentList.Count > 0)
                {
                    allowFileUpload = await UploadDocument(message.Objreg_registrationinfo.strModelForigenKey1, message.Objreg_registrationinfo.DocumentList);
                }

                if (allowFileUpload)
                {
                    i = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                        .PsychologyExaminationResultUpdate(message.Objreg_registrationinfo, cancellationToken);
                    outputPort.Update(new Reg_RegistrationInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                            ), true, null));
                    return true;
                }
                else
                {
                    if (message.Objreg_registrationinfo.DocumentList != null)
                    {
                        foreach (var basicDoc in message.Objreg_registrationinfo.DocumentList)
                        {
                            fileuploadclient.DeleteFileFTP(basicDoc.foldercontentid, basicDoc.filename, basicDoc.extension);
                        }
                    }
                    var objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["FILE_FORMAT_NOT_SUPPORTED"].Value, new Error("415", _sharedLocalizer["FILE_FORMAT_NOT_SUPPORTED"].Value));
                    outputPort.Update(objResponse);
                    _logger.LogError(JsonConvert.SerializeObject(objResponse));
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> FinalExaminationResultUpdate(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                //upload document
                bool allowFileUpload = true;
                if (message.Objreg_registrationinfo.DocumentList != null && message.Objreg_registrationinfo.DocumentList.Count > 0)
                {
                    allowFileUpload = await UploadDocument(message.Objreg_registrationinfo.strModelForigenKey1, message.Objreg_registrationinfo.DocumentList);
                }

                if (allowFileUpload)
                {
                    i = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                        .FinalExaminationResultUpdate(message.Objreg_registrationinfo, cancellationToken);
                    outputPort.Update(new Reg_RegistrationInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                            ), true, null));
                    return true;
                }
                else
                {
                    if (message.Objreg_registrationinfo.DocumentList != null)
                    {
                        foreach (var basicDoc in message.Objreg_registrationinfo.DocumentList)
                        {
                            fileuploadclient.DeleteFileFTP(basicDoc.foldercontentid, basicDoc.filename, basicDoc.extension);
                        }
                    }
                    var objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["FILE_FORMAT_NOT_SUPPORTED"].Value, new Error("415", _sharedLocalizer["FILE_FORMAT_NOT_SUPPORTED"].Value));
                    outputPort.Update(objResponse);
                    _logger.LogError(JsonConvert.SerializeObject(objResponse));
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> TrainingJoinResultUpdate(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                //upload document
                bool allowFileUpload = true;
                if (message.Objreg_registrationinfo.DocumentList != null && message.Objreg_registrationinfo.DocumentList.Count > 0)
                {
                    allowFileUpload = await UploadDocument(message.Objreg_registrationinfo.strModelForigenKey1, message.Objreg_registrationinfo.DocumentList);
                }

                if (allowFileUpload)
                {
                    i = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                        .TrainingJoinResultUpdate(message.Objreg_registrationinfo, cancellationToken);
                    outputPort.Update(new Reg_RegistrationInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                            ), true, null));
                    return true;
                }
                else
                {
                    if (message.Objreg_registrationinfo.DocumentList != null)
                    {
                        foreach (var basicDoc in message.Objreg_registrationinfo.DocumentList)
                        {
                            fileuploadclient.DeleteFileFTP(basicDoc.foldercontentid, basicDoc.filename, basicDoc.extension);
                        }
                    }
                    var objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["FILE_FORMAT_NOT_SUPPORTED"].Value, new Error("415", _sharedLocalizer["FILE_FORMAT_NOT_SUPPORTED"].Value));
                    outputPort.Update(objResponse);
                    _logger.LogError(JsonConvert.SerializeObject(objResponse));
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        private async Task<bool> UploadDocument(string civilid, List<reg_studentfilestorageEntity> DocumentList)
        {
            try {
                if (civilid != null && DocumentList != null && DocumentList.Count > 0)
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
            catch (Exception ex) {
                return false;
            }
        }

        public async Task<bool> CentralAgencySyResultUpdate(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                    .CentralAgencySyResultUpdate(message.Objreg_registrationinfo, cancellationToken);

                outputPort.Update(new Reg_RegistrationInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> GetSingleRegistrationInfoforSecurityExam(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                reg_registrationinfoEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetSingleRegistrationInfoforSecurityExam(message.Objreg_registrationinfo, cancellationToken);

                if (objSingle != null)
                {
                    if (objSingle.DocumentList != null)
                    {
                        foreach (var item in objSingle.DocumentList)
                        {
                            item.FullFtpFilePath = $"{ftpServerSetting.ReadFileUrl}{item.filepath}";
                        }
                    }

                    outputPort.GetSingle(new Reg_RegistrationInfoResponse(objSingle, true));
                    return true;
                }
                else
                {
                    Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }

        public async Task<bool> GetSingleRegistrationInfoforUnitClearance(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                reg_registrationinfoEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetSingleRegistrationInfoforUnitClearance(message.Objreg_registrationinfo, cancellationToken);

                if (objSingle != null)
                {
                    if (objSingle.DocumentList != null)
                    {
                        foreach (var item in objSingle.DocumentList)
                        {
                            item.FullFtpFilePath = $"{ftpServerSetting.ReadFileUrl}{item.filepath}";
                        }
                    }

                    outputPort.GetSingle(new Reg_RegistrationInfoResponse(objSingle, true));
                    return true;
                }
                else
                {
                    Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }

        public async Task<bool> GetSingleRegistrationInfoforGeneralMedicalExam(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                reg_registrationinfoEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetSingleRegistrationInfoforGeneralMedicalExam(message.Objreg_registrationinfo, cancellationToken);

                if (objSingle != null)
                {
                    if (objSingle.DocumentList != null)
                    {
                        foreach (var item in objSingle.DocumentList)
                        {
                            item.FullFtpFilePath = $"{ftpServerSetting.ReadFileUrl}{item.filepath}";
                        }
                    }

                    outputPort.GetSingle(new Reg_RegistrationInfoResponse(objSingle, true));
                    return true;
                }
                else
                {
                    Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }

        public async Task<bool> GetSingleRegistrationInfoforPsychologyExam(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                reg_registrationinfoEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetSingleRegistrationInfoforPsychologyExam(message.Objreg_registrationinfo, cancellationToken);

                if (objSingle != null)
                {
                    if (objSingle.DocumentList != null)
                    {
                        foreach (var item in objSingle.DocumentList)
                        {
                            item.FullFtpFilePath = $"{ftpServerSetting.ReadFileUrl}{item.filepath}";
                        }
                    }

                    outputPort.GetSingle(new Reg_RegistrationInfoResponse(objSingle, true));
                    return true;
                }
                else
                {
                    Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }

        public async Task<bool> GetSingleRegistrationInfoforFinalExam(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                reg_registrationinfoEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetSingleRegistrationInfoforFinalExam(message.Objreg_registrationinfo, cancellationToken);

                if (objSingle != null)
                {
                    if (objSingle.DocumentList != null)
                    {
                        foreach (var item in objSingle.DocumentList)
                        {
                            item.FullFtpFilePath = $"{ftpServerSetting.ReadFileUrl}{item.filepath}";
                        }
                    }

                    outputPort.GetSingle(new Reg_RegistrationInfoResponse(objSingle, true));
                    return true;
                }
                else
                {
                    Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }

        public async Task<bool> GetSingleRegistrationInfoforTrainingJoin(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                reg_registrationinfoEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetSingleRegistrationInfoforTrainingJoin(message.Objreg_registrationinfo, cancellationToken);

                if (objSingle != null)
                {
                    if (objSingle.DocumentList != null)
                    {
                        foreach (var item in objSingle.DocumentList)
                        {
                            item.FullFtpFilePath = $"{ftpServerSetting.ReadFileUrl}{item.filepath}";
                        }
                    }

                    outputPort.GetSingle(new Reg_RegistrationInfoResponse(objSingle, true));
                    return true;
                }
                else
                {
                    Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }

        public async Task<bool> UpdateSyPrintProfile(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                    .UpdateSyPrintProfile(message.Objreg_registrationinfo, cancellationToken);

                outputPort.Update(new Reg_RegistrationInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> UpdateMedExamFormPrint(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.reg_registrationinfoFCC.GetFacadeCreate(_contextAccessor)
                    .UpdateMedExamFormPrint(message.Objreg_registrationinfo, cancellationToken);

                outputPort.Update(new Reg_RegistrationInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_RegistrationInfoResponse objResponse = new Reg_RegistrationInfoResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

    }
}