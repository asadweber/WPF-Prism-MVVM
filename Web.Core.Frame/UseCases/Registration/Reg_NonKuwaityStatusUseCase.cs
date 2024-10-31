﻿using CLL.Localization;
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

namespace Web.Core.Frame.UseCases.Registration
{
    public sealed partial class Reg_NonKuwaityStatusUseCase : IReg_NonKuwaityStatusUseCase
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IJwtFactory _jwtFactory;
        private readonly IStringLocalizer _sharedLocalizer;
        private readonly ILogger<Reg_NonKuwaityStatusUseCase> _logger;
        private dataTableButtonPanel objDTBtnPanel = new dataTableButtonPanel();
        public Error _errors { get; set; }

        public Reg_NonKuwaityStatusUseCase(
            IHttpContextAccessor contextAccessor,
            IJwtFactory jwtFactory,
            IStringLocalizerFactory factory,
            ILoggerFactory loggerFactory)
        {
            _contextAccessor = contextAccessor;
            _jwtFactory = jwtFactory;
            _logger = loggerFactory.CreateLogger<Reg_NonKuwaityStatusUseCase>();

            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _sharedLocalizer = factory.Create("SharedResource", assemblyName.Name);
        }

        public Task<bool> Handle(Reg_NonKuwaityStatusRequest message, IOutputPort<Reg_NonKuwaityStatusResponse> outputPort)
        {
            throw new Exception("Not Implemented");
        }

        public async Task<bool> GetAll(Reg_NonKuwaityStatusRequest message, ICRUDRequestHandler<Reg_NonKuwaityStatusResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<reg_nonkuwaitystatusEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_nonkuwaitystatusFCC.GetFacadeCreate(_contextAccessor)
                .GetAll(message.Objreg_nonkuwaitystatus, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAll(new Reg_NonKuwaityStatusResponse(oblist.ToList(), true));
                    return true;
                }
                else
                {
                    Reg_NonKuwaityStatusResponse objResponse = new Reg_NonKuwaityStatusResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAll(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_NonKuwaityStatusResponse objResponse = new Reg_NonKuwaityStatusResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAll(objResponse);
                return true;
            }
        }

        public async Task<bool> GetAllPaged(Reg_NonKuwaityStatusRequest message, ICRUDRequestHandler<Reg_NonKuwaityStatusResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<reg_nonkuwaitystatusEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_nonkuwaitystatusFCC.GetFacadeCreate(_contextAccessor)
                .GetAllByPages(message.Objreg_nonkuwaitystatus, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAllPaged(new Reg_NonKuwaityStatusResponse(oblist.ToList(), true));
                    return true;
                }
                else
                {
                    Reg_NonKuwaityStatusResponse objResponse = new Reg_NonKuwaityStatusResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAllPaged(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_NonKuwaityStatusResponse objResponse = new Reg_NonKuwaityStatusResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAllPaged(objResponse);
                return true;
            }
        }

        public async Task<bool> GetListView(Reg_NonKuwaityStatusRequest message, ICRUDRequestHandler<Reg_NonKuwaityStatusResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<reg_nonkuwaitystatusEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_nonkuwaitystatusFCC.GetFacadeCreate(_contextAccessor)
                .GAPgListView(message.Objreg_nonkuwaitystatus, cancellationToken);
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
                                    t.regnonkuwaitystatusid,
                                    t.nonkuwaitystatusid,
                                    t.civilid,
                                    t.basicinfoid,
                                    t.familyid,
                                    t.comment,
                                    t.remarks,
                                    t.updateinfo,
                                    t.tranformactionid,                                    datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objreg_nonkuwaitystatus.ControllerName, t.regnonkuwaitystatusid, "regnonkuwaitystatusid", _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList)
                                }).ToList();

                    outputPort.GetListView(new Reg_NonKuwaityStatusResponse(new AjaxResponse(oblist[0].RETURN_KEY, data), true, null));
                    return true;
                }
                else
                {
                    Reg_NonKuwaityStatusResponse objResponse = new Reg_NonKuwaityStatusResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                        "404",
                        _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetListView(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_NonKuwaityStatusResponse objResponse = new Reg_NonKuwaityStatusResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetSingle(Reg_NonKuwaityStatusRequest message, ICRUDRequestHandler<Reg_NonKuwaityStatusResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                reg_nonkuwaitystatusEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.reg_nonkuwaitystatusFCC.GetFacadeCreate(_contextAccessor)
                .GetSingle(message.Objreg_nonkuwaitystatus, cancellationToken);
                if (objSingle != null)
                {
                    outputPort.GetSingle(new Reg_NonKuwaityStatusResponse(objSingle, true));
                    return true;
                }
                else
                {
                    Reg_NonKuwaityStatusResponse objResponse = new Reg_NonKuwaityStatusResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_NonKuwaityStatusResponse objResponse = new Reg_NonKuwaityStatusResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }

        public async Task<bool> Save(Reg_NonKuwaityStatusRequest message, ICRUDRequestHandler<Reg_NonKuwaityStatusResponse> outputPort)
        {
            _logger.LogInformation(JsonConvert.SerializeObject(message));
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.reg_nonkuwaitystatusFCC.GetFacadeCreate(_contextAccessor)
                    .Add(message.Objreg_nonkuwaitystatus, cancellationToken);

                outputPort.Save(new Reg_NonKuwaityStatusResponse(new AjaxResponse("200", _sharedLocalizer["DATA_SAVE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_NonKuwaityStatusResponse objResponse = new Reg_NonKuwaityStatusResponse(false, _sharedLocalizer["DATA_SAVE_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Save(objResponse);
                return true;
            }
        }

        public async Task<bool> Update(Reg_NonKuwaityStatusRequest message, ICRUDRequestHandler<Reg_NonKuwaityStatusResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.reg_nonkuwaitystatusFCC.GetFacadeCreate(_contextAccessor)
                    .Update(message.Objreg_nonkuwaitystatus, cancellationToken);

                outputPort.Update(new Reg_NonKuwaityStatusResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_NonKuwaityStatusResponse objResponse = new Reg_NonKuwaityStatusResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> Delete(Reg_NonKuwaityStatusRequest message, ICRUDRequestHandler<Reg_NonKuwaityStatusResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.reg_nonkuwaitystatusFCC.GetFacadeCreate(_contextAccessor)
                    .Delete(message.Objreg_nonkuwaitystatus, cancellationToken);
                outputPort.Delete(new Reg_NonKuwaityStatusResponse(new AjaxResponse("200", _sharedLocalizer["DATA_DELETE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                       ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_NonKuwaityStatusResponse objResponse = new Reg_NonKuwaityStatusResponse(false, _sharedLocalizer["DATA_DELETE_ERROR"], new Error(
                         "500",
                         ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Delete(objResponse);
                return true;
            }
        }





    }
}