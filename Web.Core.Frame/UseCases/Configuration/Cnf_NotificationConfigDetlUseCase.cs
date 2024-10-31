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
using Web.Core.Frame.Interfaces.UseCases.Configuration;
using Web.Core.Frame.Dto.UseCaseResponses.Configuration;
using Web.Core.Frame.Dto.UseCaseRequests.Configuration;

namespace Web.Core.Frame.UseCases.Configuration
{
    public sealed partial class Cnf_NotificationConfigDetlUseCase : ICnf_NotificationConfigDetlUseCase
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IJwtFactory _jwtFactory;
        private readonly IStringLocalizer _sharedLocalizer;
        private readonly ILogger<Cnf_NotificationConfigDetlUseCase> _logger;
        private dataTableButtonPanel objDTBtnPanel = new dataTableButtonPanel();
        public Error _errors { get; set; }

        public Cnf_NotificationConfigDetlUseCase(
            IHttpContextAccessor contextAccessor,
            IJwtFactory jwtFactory,
            IStringLocalizerFactory factory,
            ILoggerFactory loggerFactory)
        {
            _contextAccessor = contextAccessor;
            _jwtFactory = jwtFactory;
            _logger = loggerFactory.CreateLogger<Cnf_NotificationConfigDetlUseCase>();

            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _sharedLocalizer = factory.Create("SharedResource", assemblyName.Name);
        }

        public Task<bool> Handle(Cnf_NotificationConfigDetlRequest message, IOutputPort<Cnf_NotificationConfigDetlResponse> outputPort)
        {
            throw new Exception("Not Implemented");
        }

        public async Task<bool> GetAll(Cnf_NotificationConfigDetlRequest message, ICRUDRequestHandler<Cnf_NotificationConfigDetlResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<cnf_notificationconfigdetlEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.cnf_notificationconfigdetlFCC.GetFacadeCreate(_contextAccessor)
                .GetAll(message.Objcnf_notificationconfigdetl, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAll(new Cnf_NotificationConfigDetlResponse(oblist.ToList(), true));
                    return true;
                }
                else
                {
                    Cnf_NotificationConfigDetlResponse objResponse = new Cnf_NotificationConfigDetlResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAll(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Cnf_NotificationConfigDetlResponse objResponse = new Cnf_NotificationConfigDetlResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAll(objResponse);
                return true;
            }
        }

        public async Task<bool> GetAllPaged(Cnf_NotificationConfigDetlRequest message, ICRUDRequestHandler<Cnf_NotificationConfigDetlResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<cnf_notificationconfigdetlEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.cnf_notificationconfigdetlFCC.GetFacadeCreate(_contextAccessor)
                .GetAllByPages(message.Objcnf_notificationconfigdetl, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAllPaged(new Cnf_NotificationConfigDetlResponse(oblist.ToList(), true));
                    return true;
                }
                else
                {
                    Cnf_NotificationConfigDetlResponse objResponse = new Cnf_NotificationConfigDetlResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAllPaged(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Cnf_NotificationConfigDetlResponse objResponse = new Cnf_NotificationConfigDetlResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAllPaged(objResponse);
                return true;
            }
        }

        public async Task<bool> GetListView(Cnf_NotificationConfigDetlRequest message, ICRUDRequestHandler<Cnf_NotificationConfigDetlResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<cnf_notificationconfigdetlEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.cnf_notificationconfigdetlFCC.GetFacadeCreate(_contextAccessor)
                .GAPgListView(message.Objcnf_notificationconfigdetl, cancellationToken);
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
                                    t.notificationconfigdetlid,
                                    t.notificationconfigid,
                                    t.notificationtypeid,
                                    t.notificationtemplateid,
                                    t.remarks,
                                    datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objcnf_notificationconfigdetl.ControllerName, t.notificationconfigdetlid, "notificationconfigdetlid", _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList, _contextAccessor)
                                }).ToList();

                    outputPort.GetListView(new Cnf_NotificationConfigDetlResponse(new AjaxResponse(oblist[0].RETURN_KEY, data), true, null));
                    return true;
                }
                else
                {
                    Cnf_NotificationConfigDetlResponse objResponse = new Cnf_NotificationConfigDetlResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                        "404",
                        _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetListView(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Cnf_NotificationConfigDetlResponse objResponse = new Cnf_NotificationConfigDetlResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetSingle(Cnf_NotificationConfigDetlRequest message, ICRUDRequestHandler<Cnf_NotificationConfigDetlResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                cnf_notificationconfigdetlEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.cnf_notificationconfigdetlFCC.GetFacadeCreate(_contextAccessor)
                .GetSingle(message.Objcnf_notificationconfigdetl, cancellationToken);
                if (objSingle != null)
                {
                    outputPort.GetSingle(new Cnf_NotificationConfigDetlResponse(objSingle, true));
                    return true;
                }
                else
                {
                    Cnf_NotificationConfigDetlResponse objResponse = new Cnf_NotificationConfigDetlResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Cnf_NotificationConfigDetlResponse objResponse = new Cnf_NotificationConfigDetlResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }

        public async Task<bool> Save(Cnf_NotificationConfigDetlRequest message, ICRUDRequestHandler<Cnf_NotificationConfigDetlResponse> outputPort)
        {
            _logger.LogInformation(JsonConvert.SerializeObject(message));
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.cnf_notificationconfigdetlFCC.GetFacadeCreate(_contextAccessor)
                    .Add(message.Objcnf_notificationconfigdetl, cancellationToken);

                outputPort.Save(new Cnf_NotificationConfigDetlResponse(new AjaxResponse("200", _sharedLocalizer["DATA_SAVE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Cnf_NotificationConfigDetlResponse objResponse = new Cnf_NotificationConfigDetlResponse(false, _sharedLocalizer["DATA_SAVE_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Save(objResponse);
                return true;
            }
        }

        public async Task<bool> Update(Cnf_NotificationConfigDetlRequest message, ICRUDRequestHandler<Cnf_NotificationConfigDetlResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.cnf_notificationconfigdetlFCC.GetFacadeCreate(_contextAccessor)
                    .Update(message.Objcnf_notificationconfigdetl, cancellationToken);

                outputPort.Update(new Cnf_NotificationConfigDetlResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Cnf_NotificationConfigDetlResponse objResponse = new Cnf_NotificationConfigDetlResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> Delete(Cnf_NotificationConfigDetlRequest message, ICRUDRequestHandler<Cnf_NotificationConfigDetlResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.cnf_notificationconfigdetlFCC.GetFacadeCreate(_contextAccessor)
                    .Delete(message.Objcnf_notificationconfigdetl, cancellationToken);
                outputPort.Delete(new Cnf_NotificationConfigDetlResponse(new AjaxResponse("200", _sharedLocalizer["DATA_DELETE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                       ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Cnf_NotificationConfigDetlResponse objResponse = new Cnf_NotificationConfigDetlResponse(false, _sharedLocalizer["DATA_DELETE_ERROR"], new Error(
                         "500",
                         ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Delete(objResponse);
                return true;
            }
        }





    }
}