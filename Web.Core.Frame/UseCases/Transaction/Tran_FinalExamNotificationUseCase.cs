using AppConfig.HelperClasses;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using CLL.Localization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static AppConfig.HelperClasses.applicationEnamNConstants;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Helpers;
using Web.Core.Frame.Interfaces.Services;
using Web.Core.Frame.Interfaces.UseCases;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;
using Newtonsoft.Json;

namespace Web.Core.Frame.UseCases
{
    public sealed partial class Tran_FinalExamNotificationUseCase : ITran_FinalExamNotificationUseCase
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IJwtFactory _jwtFactory;
        private readonly IStringLocalizer _sharedLocalizer;
        private readonly ILogger<Tran_FinalExamNotificationUseCase> _logger;
        private dataTableButtonPanel objDTBtnPanel = new dataTableButtonPanel();
        public Error _errors { get; set; }

        public Tran_FinalExamNotificationUseCase(
            IHttpContextAccessor contextAccessor,
            IJwtFactory jwtFactory,
            IStringLocalizerFactory factory,
            ILoggerFactory loggerFactory)
        {
            _contextAccessor = contextAccessor;
            _jwtFactory = jwtFactory;
            _logger = loggerFactory.CreateLogger<Tran_FinalExamNotificationUseCase>();

            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _sharedLocalizer = factory.Create("SharedResource", assemblyName.Name);
        }

        public Task<bool> Handle(Tran_FinalExamNotificationRequest message, IOutputPort<Tran_FinalExamNotificationResponse> outputPort)
        {
            throw new Exception("Not Implemented");
        }

        public async Task<bool> GetAll(Tran_FinalExamNotificationRequest message, ICRUDRequestHandler<Tran_FinalExamNotificationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<tran_finalexamnotificationEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.tran_finalexamnotificationFCC.GetFacadeCreate(_contextAccessor)
                .GetAll(message.Objtran_finalexamnotification, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAll(new Tran_FinalExamNotificationResponse(oblist.ToList(), true));
                    return true;
                }
                else
                {
                    Tran_FinalExamNotificationResponse objResponse = new Tran_FinalExamNotificationResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAll(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Tran_FinalExamNotificationResponse objResponse = new Tran_FinalExamNotificationResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAll(objResponse);
                return true;
            }
        }

        public async Task<bool> GetAllPaged(Tran_FinalExamNotificationRequest message, ICRUDRequestHandler<Tran_FinalExamNotificationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<tran_finalexamnotificationEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.tran_finalexamnotificationFCC.GetFacadeCreate(_contextAccessor)
                .GetAllByPages(message.Objtran_finalexamnotification, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAllPaged(new Tran_FinalExamNotificationResponse(oblist.ToList(), true));
                    return true;
                }
                else
                {
                    Tran_FinalExamNotificationResponse objResponse = new Tran_FinalExamNotificationResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAllPaged(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Tran_FinalExamNotificationResponse objResponse = new Tran_FinalExamNotificationResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAllPaged(objResponse);
                return true;
            }
        }

        public async Task<bool> GetListView(Tran_FinalExamNotificationRequest message, ICRUDRequestHandler<Tran_FinalExamNotificationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<tran_finalexamnotificationEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.tran_finalexamnotificationFCC.GetFacadeCreate(_contextAccessor)
                .GAPgListView(message.Objtran_finalexamnotification, cancellationToken);
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
                                    t.finalexamnotificationid,
                                    t.batchid,
                                    t.basicinfoid,
                                    t.registrationid,
                                    t.applicantphaseid,
                                    t.messagesubject,
                                    t.messagebody,
                                    t.smsnotification,
                                    t.pacinotification,
                                    t.emailnotification,
                                    t.senddate,
                                    t.notificationstatus,
                                    t.fileid,
                                    t.fileuploadresult,
                                    t.comment,
                                    t.remarks,
                                    t.updateinfo,
                                    t.tranformactionid,
                                    datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objtran_finalexamnotification.ControllerName, t.finalexamnotificationid, "finalexamnotificationid", _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList)
                                }).ToList();

                    outputPort.GetListView(new Tran_FinalExamNotificationResponse(new AjaxResponse(oblist[0].RETURN_KEY, data), true, null));
                    return true;
                }
                else
                {
                    Tran_FinalExamNotificationResponse objResponse = new Tran_FinalExamNotificationResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                        "404",
                        _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetListView(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Tran_FinalExamNotificationResponse objResponse = new Tran_FinalExamNotificationResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetSingle(Tran_FinalExamNotificationRequest message, ICRUDRequestHandler<Tran_FinalExamNotificationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                tran_finalexamnotificationEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.tran_finalexamnotificationFCC.GetFacadeCreate(_contextAccessor)
                .GetSingle(message.Objtran_finalexamnotification, cancellationToken);
                if (objSingle != null)
                {
                    outputPort.GetSingle(new Tran_FinalExamNotificationResponse(objSingle, true));
                    return true;
                }
                else
                {
                    Tran_FinalExamNotificationResponse objResponse = new Tran_FinalExamNotificationResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Tran_FinalExamNotificationResponse objResponse = new Tran_FinalExamNotificationResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }

        public async Task<bool> Save(Tran_FinalExamNotificationRequest message, ICRUDRequestHandler<Tran_FinalExamNotificationResponse> outputPort)
        {
            _logger.LogInformation(JsonConvert.SerializeObject(message));
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.tran_finalexamnotificationFCC.GetFacadeCreate(_contextAccessor)
                    .Add(message.Objtran_finalexamnotification, cancellationToken);

                outputPort.Save(new Tran_FinalExamNotificationResponse(new AjaxResponse("200", _sharedLocalizer["NOTIFICATION_SENT_SUCCESS"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Tran_FinalExamNotificationResponse objResponse = new Tran_FinalExamNotificationResponse(false, _sharedLocalizer["DATA_SAVE_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Save(objResponse);
                return true;
            }
        }

        public async Task<bool> Update(Tran_FinalExamNotificationRequest message, ICRUDRequestHandler<Tran_FinalExamNotificationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.tran_finalexamnotificationFCC.GetFacadeCreate(_contextAccessor)
                    .Update(message.Objtran_finalexamnotification, cancellationToken);

                outputPort.Update(new Tran_FinalExamNotificationResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Tran_FinalExamNotificationResponse objResponse = new Tran_FinalExamNotificationResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> Delete(Tran_FinalExamNotificationRequest message, ICRUDRequestHandler<Tran_FinalExamNotificationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.tran_finalexamnotificationFCC.GetFacadeCreate(_contextAccessor)
                    .Delete(message.Objtran_finalexamnotification, cancellationToken);
                outputPort.Delete(new Tran_FinalExamNotificationResponse(new AjaxResponse("200", _sharedLocalizer["DATA_DELETE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                       ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Tran_FinalExamNotificationResponse objResponse = new Tran_FinalExamNotificationResponse(false, _sharedLocalizer["DATA_DELETE_ERROR"], new Error(
                         "500",
                         ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Delete(objResponse);
                return true;
            }
        }





    }
}