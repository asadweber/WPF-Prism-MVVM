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
    public sealed partial class Owin_UserPrefferencesSettingsUseCase : IOwin_UserPrefferencesSettingsUseCase
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IJwtFactory _jwtFactory;
        private readonly IStringLocalizer _sharedLocalizer;
        private readonly ILogger<Owin_UserPrefferencesSettingsUseCase> _logger;
        private dataTableButtonPanel objDTBtnPanel = new dataTableButtonPanel();
        public Error _errors { get; set; }

        public Owin_UserPrefferencesSettingsUseCase(
            IHttpContextAccessor contextAccessor,
            IJwtFactory jwtFactory,
            IStringLocalizerFactory factory,
            ILoggerFactory loggerFactory)
        {
            _contextAccessor = contextAccessor;
            _jwtFactory = jwtFactory;
            _logger = loggerFactory.CreateLogger<Owin_UserPrefferencesSettingsUseCase>();

            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _sharedLocalizer = factory.Create("SharedResource", assemblyName.Name);
        }

        public Task<bool> Handle(Owin_UserPrefferencesSettingsRequest message, IOutputPort<Owin_UserPrefferencesSettingsResponse> outputPort)
        {
            throw new Exception("Not Implemented");
        }

        public async Task<bool> GetAll(Owin_UserPrefferencesSettingsRequest message, ICRUDRequestHandler<Owin_UserPrefferencesSettingsResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<owin_userprefferencessettingsEntity> oblist = await BFC.Core.FacadeCreatorObjects.Security.owin_userprefferencessettingsFCC.GetFacadeCreate(_contextAccessor)
                .GetAll(new owin_userprefferencessettingsEntity(), cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAll(new Owin_UserPrefferencesSettingsResponse(oblist.ToList(), true));
                }
                else
                {
                    Owin_UserPrefferencesSettingsResponse objResponse = new Owin_UserPrefferencesSettingsResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAll(objResponse);
                }
                return true;
            }
            catch (Exception ex)
            {
                Owin_UserPrefferencesSettingsResponse objResponse = new Owin_UserPrefferencesSettingsResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAll(objResponse);
                return true;
            }
        }

        public async Task<bool> GetAllPaged(Owin_UserPrefferencesSettingsRequest message, ICRUDRequestHandler<Owin_UserPrefferencesSettingsResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<owin_userprefferencessettingsEntity> oblist = await BFC.Core.FacadeCreatorObjects.Security.owin_userprefferencessettingsFCC.GetFacadeCreate(_contextAccessor)
                .GetAllByPages(message.Objowin_userprefferencessettings, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAllPaged(new Owin_UserPrefferencesSettingsResponse(oblist.ToList(), true));
                }
                else
                {
                    Owin_UserPrefferencesSettingsResponse objResponse = new Owin_UserPrefferencesSettingsResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAllPaged(objResponse);
                }
                return true;
            }
            catch (Exception ex)
            {
                Owin_UserPrefferencesSettingsResponse objResponse = new Owin_UserPrefferencesSettingsResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAllPaged(objResponse);
                return true;
            }
        }

        public async Task<bool> GetListView(Owin_UserPrefferencesSettingsRequest message, ICRUDRequestHandler<Owin_UserPrefferencesSettingsResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<owin_userprefferencessettingsEntity> oblist = await BFC.Core.FacadeCreatorObjects.Security.owin_userprefferencessettingsFCC.GetFacadeCreate(_contextAccessor)
                .GAPgListView(message.Objowin_userprefferencessettings, cancellationToken);
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
                                    t.serialno,
                                    t.userid,
                                    t.masteruserid,
                                    t.appformid,
                                    t.prepagesize,
                                    datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objowin_userprefferencessettings.ControllerName, t.serialno, "serialno", _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList, _contextAccessor)
                                }).ToList();

                    outputPort.GetListView(new Owin_UserPrefferencesSettingsResponse(new AjaxResponse(oblist[0].RETURN_KEY, data), true, null));

                }
                else
                {
                    Owin_UserPrefferencesSettingsResponse objResponse = new Owin_UserPrefferencesSettingsResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                        "404",
                        _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetListView(objResponse);
                }
                return true;
            }
            catch (Exception ex)
            {
                Owin_UserPrefferencesSettingsResponse objResponse = new Owin_UserPrefferencesSettingsResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetSingle(Owin_UserPrefferencesSettingsRequest message, ICRUDRequestHandler<Owin_UserPrefferencesSettingsResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                owin_userprefferencessettingsEntity objSingle = await BFC.Core.FacadeCreatorObjects.Security.owin_userprefferencessettingsFCC.GetFacadeCreate(_contextAccessor)
                .GetSingle(message.Objowin_userprefferencessettings, cancellationToken);
                if (objSingle != null)
                {
                    outputPort.GetSingle(new Owin_UserPrefferencesSettingsResponse(objSingle, true));
                }
                else
                {
                    Owin_UserPrefferencesSettingsResponse objResponse = new Owin_UserPrefferencesSettingsResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                }
                return true;
            }
            catch (Exception ex)
            {
                Owin_UserPrefferencesSettingsResponse objResponse = new Owin_UserPrefferencesSettingsResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }

        public async Task<bool> Save(Owin_UserPrefferencesSettingsRequest message, ICRUDRequestHandler<Owin_UserPrefferencesSettingsResponse> outputPort)
        {
            _logger.LogInformation(JsonConvert.SerializeObject(message));
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.Security.owin_userprefferencessettingsFCC.GetFacadeCreate(_contextAccessor)
                    .Add(message.Objowin_userprefferencessettings, cancellationToken);

                outputPort.Save(new Owin_UserPrefferencesSettingsResponse(new AjaxResponse("200", _sharedLocalizer["DATA_SAVE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Owin_UserPrefferencesSettingsResponse objResponse = new Owin_UserPrefferencesSettingsResponse(false, _sharedLocalizer["DATA_SAVE_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Save(objResponse);
                return true;
            }
        }

        public async Task<bool> Update(Owin_UserPrefferencesSettingsRequest message, ICRUDRequestHandler<Owin_UserPrefferencesSettingsResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.Security.owin_userprefferencessettingsFCC.GetFacadeCreate(_contextAccessor)
                    .Update(message.Objowin_userprefferencessettings, cancellationToken);

                outputPort.Update(new Owin_UserPrefferencesSettingsResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Owin_UserPrefferencesSettingsResponse objResponse = new Owin_UserPrefferencesSettingsResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> Delete(Owin_UserPrefferencesSettingsRequest message, ICRUDRequestHandler<Owin_UserPrefferencesSettingsResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.Security.owin_userprefferencessettingsFCC.GetFacadeCreate(_contextAccessor)
                    .Delete(message.Objowin_userprefferencessettings, cancellationToken);
                outputPort.Delete(new Owin_UserPrefferencesSettingsResponse(new AjaxResponse("200", _sharedLocalizer["DATA_DELETE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                       ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Owin_UserPrefferencesSettingsResponse objResponse = new Owin_UserPrefferencesSettingsResponse(false, _sharedLocalizer["DATA_DELETE_ERROR"], new Error(
                         "500",
                         ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Delete(objResponse);
                return true;
            }
        }
    }
}