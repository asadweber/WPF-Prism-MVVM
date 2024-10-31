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
using Web.Core.Frame.Interfaces.UseCases.Transaction;
using Web.Core.Frame.Dto.UseCaseResponses.Transaction;
using Web.Core.Frame.Dto.UseCaseRequests.Transaction;

namespace Web.Core.Frame.UseCases.Transaction
{
    public sealed partial class Tran_RollbackInfoUseCase : ITran_RollbackInfoUseCase
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IJwtFactory _jwtFactory;
        private readonly IStringLocalizer _sharedLocalizer;
        private readonly ILogger<Tran_RollbackInfoUseCase> _logger;
        private dataTableButtonPanel objDTBtnPanel = new dataTableButtonPanel();
        public Error _errors { get; set; }

        public Tran_RollbackInfoUseCase(
            IHttpContextAccessor contextAccessor,
            IJwtFactory jwtFactory,
            IStringLocalizerFactory factory,
            ILoggerFactory loggerFactory)
        {
            _contextAccessor = contextAccessor;
            _jwtFactory = jwtFactory;
            _logger = loggerFactory.CreateLogger<Tran_RollbackInfoUseCase>();

            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _sharedLocalizer = factory.Create("SharedResource", assemblyName.Name);
        }

        public Task<bool> Handle(Tran_RollbackInfoRequest message, IOutputPort<Tran_RollbackInfoResponse> outputPort)
        {
            throw new Exception("Not Implemented");
        }

        public async Task<bool> GetAll(Tran_RollbackInfoRequest message, ICRUDRequestHandler<Tran_RollbackInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<tran_rollbackinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.tran_rollbackinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetAll(message.Objtran_rollbackinfo, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAll(new Tran_RollbackInfoResponse(oblist.ToList(), true));
                    return true;
                }
                else
                {
                    Tran_RollbackInfoResponse objResponse = new Tran_RollbackInfoResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAll(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Tran_RollbackInfoResponse objResponse = new Tran_RollbackInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAll(objResponse);
                return true;
            }
        }

        public async Task<bool> GetAllPaged(Tran_RollbackInfoRequest message, ICRUDRequestHandler<Tran_RollbackInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<tran_rollbackinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.tran_rollbackinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetAllByPages(message.Objtran_rollbackinfo, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAllPaged(new Tran_RollbackInfoResponse(oblist.ToList(), true));
                    return true;
                }
                else
                {
                    Tran_RollbackInfoResponse objResponse = new Tran_RollbackInfoResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAllPaged(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Tran_RollbackInfoResponse objResponse = new Tran_RollbackInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAllPaged(objResponse);
                return true;
            }
        }

        public async Task<bool> GetListView(Tran_RollbackInfoRequest message, ICRUDRequestHandler<Tran_RollbackInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<tran_rollbackinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.tran_rollbackinfoFCC.GetFacadeCreate(_contextAccessor)
                .GAPgListView(message.Objtran_rollbackinfo, cancellationToken);
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
                                    t.rollbackid,
                                    t.basicinfoid,
                                    t.registrationid,
                                    t.type,
                                    t.trandate,
                                    t.comment,
                                    t.remarks,
                                    t.updateinfo,
                                    t.tranformactionid,                                    datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objtran_rollbackinfo.ControllerName, t.rollbackid, "rollbackid", _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList)
                                }).ToList();

                    outputPort.GetListView(new Tran_RollbackInfoResponse(new AjaxResponse(oblist[0].RETURN_KEY, data), true, null));
                    return true;
                }
                else
                {
                    Tran_RollbackInfoResponse objResponse = new Tran_RollbackInfoResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                        "404",
                        _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetListView(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Tran_RollbackInfoResponse objResponse = new Tran_RollbackInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetSingle(Tran_RollbackInfoRequest message, ICRUDRequestHandler<Tran_RollbackInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                tran_rollbackinfoEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.tran_rollbackinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetSingle(message.Objtran_rollbackinfo, cancellationToken);
                if (objSingle != null)
                {
                    outputPort.GetSingle(new Tran_RollbackInfoResponse(objSingle, true));
                    return true;
                }
                else
                {
                    Tran_RollbackInfoResponse objResponse = new Tran_RollbackInfoResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Tran_RollbackInfoResponse objResponse = new Tran_RollbackInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }

        public async Task<bool> Save(Tran_RollbackInfoRequest message, ICRUDRequestHandler<Tran_RollbackInfoResponse> outputPort)
        {
            _logger.LogInformation(JsonConvert.SerializeObject(message));
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.tran_rollbackinfoFCC.GetFacadeCreate(_contextAccessor)
                    .Add(message.Objtran_rollbackinfo, cancellationToken);

                outputPort.Save(new Tran_RollbackInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_SAVE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Tran_RollbackInfoResponse objResponse = new Tran_RollbackInfoResponse(false, _sharedLocalizer["DATA_SAVE_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Save(objResponse);
                return true;
            }
        }

        public async Task<bool> Update(Tran_RollbackInfoRequest message, ICRUDRequestHandler<Tran_RollbackInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.tran_rollbackinfoFCC.GetFacadeCreate(_contextAccessor)
                    .Update(message.Objtran_rollbackinfo, cancellationToken);

                outputPort.Update(new Tran_RollbackInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Tran_RollbackInfoResponse objResponse = new Tran_RollbackInfoResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> Delete(Tran_RollbackInfoRequest message, ICRUDRequestHandler<Tran_RollbackInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.tran_rollbackinfoFCC.GetFacadeCreate(_contextAccessor)
                    .Delete(message.Objtran_rollbackinfo, cancellationToken);
                outputPort.Delete(new Tran_RollbackInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_DELETE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                       ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Tran_RollbackInfoResponse objResponse = new Tran_RollbackInfoResponse(false, _sharedLocalizer["DATA_DELETE_ERROR"], new Error(
                         "500",
                         ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Delete(objResponse);
                return true;
            }
        }





    }
}