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
using AppConfig.HelperClasses;
using Web.Core.Frame.Helpers;
using System.Security.Claims;
using static AppConfig.HelperClasses.applicationEnamNConstants;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.SecurityModels;

namespace Web.Core.Frame.UseCases
{
    public sealed partial class Tran_TrainingJoinNotificationUseCase : ITran_TrainingJoinNotificationUseCase
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IJwtFactory _jwtFactory;
        private readonly IStringLocalizer _sharedLocalizer;
        private readonly ILogger<Tran_TrainingJoinNotificationUseCase> _logger;
        private dataTableButtonPanel objDTBtnPanel = new dataTableButtonPanel();
        public Error _errors { get; set; }

        public Tran_TrainingJoinNotificationUseCase(
            IHttpContextAccessor contextAccessor,
            IJwtFactory jwtFactory,
            IStringLocalizerFactory factory,
            ILoggerFactory loggerFactory)
        {
            _contextAccessor = contextAccessor;
            _jwtFactory = jwtFactory;
            _logger = loggerFactory.CreateLogger<Tran_TrainingJoinNotificationUseCase>();

            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _sharedLocalizer = factory.Create("SharedResource", assemblyName.Name);
        }

        public Task<bool> Handle(Tran_TrainingJoinNotificationRequest message, IOutputPort<Tran_TrainingJoinNotificationResponse> outputPort)
        {
            throw new Exception("Not Implemented");
        }

        public async Task<bool> GetAll(Tran_TrainingJoinNotificationRequest message, ICRUDRequestHandler<Tran_TrainingJoinNotificationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<tran_trainingjoinnotificationEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.tran_trainingjoinnotificationFCC.GetFacadeCreate(_contextAccessor)
                .GetAll(message.Objtran_trainingjoinnotification, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAll(new Tran_TrainingJoinNotificationResponse(oblist.ToList(), true));
                    return true;
                }
                else
                {
                    Tran_TrainingJoinNotificationResponse objResponse = new Tran_TrainingJoinNotificationResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAll(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Tran_TrainingJoinNotificationResponse objResponse = new Tran_TrainingJoinNotificationResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAll(objResponse);
                return true;
            }
        }

        public async Task<bool> GetAllPaged(Tran_TrainingJoinNotificationRequest message, ICRUDRequestHandler<Tran_TrainingJoinNotificationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<tran_trainingjoinnotificationEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.tran_trainingjoinnotificationFCC.GetFacadeCreate(_contextAccessor)
                .GetAllByPages(message.Objtran_trainingjoinnotification, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAllPaged(new Tran_TrainingJoinNotificationResponse(oblist.ToList(), true));
                    return true;
                }
                else
                {
                    Tran_TrainingJoinNotificationResponse objResponse = new Tran_TrainingJoinNotificationResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAllPaged(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Tran_TrainingJoinNotificationResponse objResponse = new Tran_TrainingJoinNotificationResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAllPaged(objResponse);
                return true;
            }
        }

        public async Task<bool> GetListView(Tran_TrainingJoinNotificationRequest message, ICRUDRequestHandler<Tran_TrainingJoinNotificationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<tran_trainingjoinnotificationEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.tran_trainingjoinnotificationFCC.GetFacadeCreate(_contextAccessor)
                .GAPgListView(message.Objtran_trainingjoinnotification, cancellationToken);
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
                                    t.trainingjoinnotificationid,
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
                                    datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objtran_trainingjoinnotification.ControllerName, t.trainingjoinnotificationid, "trainingjoinnotificationid", _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList)
                                }).ToList();

                    outputPort.GetListView(new Tran_TrainingJoinNotificationResponse(new AjaxResponse(oblist[0].RETURN_KEY, data), true, null));
                    return true;
                }
                else
                {
                    Tran_TrainingJoinNotificationResponse objResponse = new Tran_TrainingJoinNotificationResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                        "404",
                        _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetListView(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Tran_TrainingJoinNotificationResponse objResponse = new Tran_TrainingJoinNotificationResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetSingle(Tran_TrainingJoinNotificationRequest message, ICRUDRequestHandler<Tran_TrainingJoinNotificationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                tran_trainingjoinnotificationEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.tran_trainingjoinnotificationFCC.GetFacadeCreate(_contextAccessor)
                .GetSingle(message.Objtran_trainingjoinnotification, cancellationToken);
                if (objSingle != null)
                {
                    outputPort.GetSingle(new Tran_TrainingJoinNotificationResponse(objSingle, true));
                    return true;
                }
                else
                {
                    Tran_TrainingJoinNotificationResponse objResponse = new Tran_TrainingJoinNotificationResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Tran_TrainingJoinNotificationResponse objResponse = new Tran_TrainingJoinNotificationResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }

        public async Task<bool> Save(Tran_TrainingJoinNotificationRequest message, ICRUDRequestHandler<Tran_TrainingJoinNotificationResponse> outputPort)
        {
            _logger.LogInformation(JsonConvert.SerializeObject(message));
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.tran_trainingjoinnotificationFCC.GetFacadeCreate(_contextAccessor)
                    .Add(message.Objtran_trainingjoinnotification, cancellationToken);

                outputPort.Save(new Tran_TrainingJoinNotificationResponse(new AjaxResponse("200", _sharedLocalizer["NOTIFICATION_SENT_SUCCESS"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Tran_TrainingJoinNotificationResponse objResponse = new Tran_TrainingJoinNotificationResponse(false, _sharedLocalizer["DATA_SAVE_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Save(objResponse);
                return true;
            }
        }

        public async Task<bool> Update(Tran_TrainingJoinNotificationRequest message, ICRUDRequestHandler<Tran_TrainingJoinNotificationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.tran_trainingjoinnotificationFCC.GetFacadeCreate(_contextAccessor)
                    .Update(message.Objtran_trainingjoinnotification, cancellationToken);

                outputPort.Update(new Tran_TrainingJoinNotificationResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Tran_TrainingJoinNotificationResponse objResponse = new Tran_TrainingJoinNotificationResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> Delete(Tran_TrainingJoinNotificationRequest message, ICRUDRequestHandler<Tran_TrainingJoinNotificationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.tran_trainingjoinnotificationFCC.GetFacadeCreate(_contextAccessor)
                    .Delete(message.Objtran_trainingjoinnotification, cancellationToken);
                outputPort.Delete(new Tran_TrainingJoinNotificationResponse(new AjaxResponse("200", _sharedLocalizer["DATA_DELETE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                       ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Tran_TrainingJoinNotificationResponse objResponse = new Tran_TrainingJoinNotificationResponse(false, _sharedLocalizer["DATA_DELETE_ERROR"], new Error(
                         "500",
                         ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Delete(objResponse);
                return true;
            }
        }





    }
}