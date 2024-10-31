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
    public sealed partial class Stp_OrganizationEntityTypeUseCase : IStp_OrganizationEntityTypeUseCase
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IJwtFactory _jwtFactory;
        private readonly IStringLocalizer _sharedLocalizer;
        private readonly ILogger<Stp_OrganizationEntityTypeUseCase> _logger;
        private dataTableButtonPanel objDTBtnPanel = new dataTableButtonPanel();
        public Error _errors { get; set; }

        public Stp_OrganizationEntityTypeUseCase(
            IHttpContextAccessor contextAccessor,
            IJwtFactory jwtFactory,
            IStringLocalizerFactory factory,
            ILoggerFactory loggerFactory)
        {
            _contextAccessor = contextAccessor;
            _jwtFactory = jwtFactory;
            _logger = loggerFactory.CreateLogger<Stp_OrganizationEntityTypeUseCase>();

            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _sharedLocalizer = factory.Create("SharedResource", assemblyName.Name);
        }

        public Task<bool> Handle(Stp_OrganizationEntityTypeRequest message, IOutputPort<Stp_OrganizationEntityTypeResponse> outputPort)
        {
            throw new Exception("Not Implemented");
        }

        public async Task<bool> GetAll(Stp_OrganizationEntityTypeRequest message, ICRUDRequestHandler<Stp_OrganizationEntityTypeResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<stp_organizationentitytypeEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.stp_organizationentitytypeFCC.GetFacadeCreate(_contextAccessor)
                .GetAll(message.Objstp_organizationentitytype, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAll(new Stp_OrganizationEntityTypeResponse(oblist.ToList(), true));
                    return true;
                }
                else
                {
                    Stp_OrganizationEntityTypeResponse objResponse = new Stp_OrganizationEntityTypeResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAll(objResponse);
                    return false;
                }                
            }
            catch (Exception ex)
            {
                Stp_OrganizationEntityTypeResponse objResponse = new Stp_OrganizationEntityTypeResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAll(objResponse);
                return true;
            }
        }

        public async Task<bool> GetAllPaged(Stp_OrganizationEntityTypeRequest message, ICRUDRequestHandler<Stp_OrganizationEntityTypeResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<stp_organizationentitytypeEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.stp_organizationentitytypeFCC.GetFacadeCreate(_contextAccessor)
                .GetAllByPages(message.Objstp_organizationentitytype, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAllPaged(new Stp_OrganizationEntityTypeResponse(oblist.ToList(), true));
                    return true;
                }
                else
                {
                    Stp_OrganizationEntityTypeResponse objResponse = new Stp_OrganizationEntityTypeResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAllPaged(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Stp_OrganizationEntityTypeResponse objResponse = new Stp_OrganizationEntityTypeResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAllPaged(objResponse);
                return true;
            }
        }

        public async Task<bool> GetListView(Stp_OrganizationEntityTypeRequest message, ICRUDRequestHandler<Stp_OrganizationEntityTypeResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<stp_organizationentitytypeEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.stp_organizationentitytypeFCC.GetFacadeCreate(_contextAccessor)
                .GAPgListView(message.Objstp_organizationentitytype, cancellationToken);
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
									 t.entirytypekey,
									 t.organizationkey,
									 t.entirytypecode,
									 t.entirytype,
									 t.description,
									 t.entitylevel,
									 t.isactive,
									 t.updateinfo,
									 t.tranformactionid,                                    datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objstp_organizationentitytype.ControllerName, t.entirytypekey, "entirytypekey", _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList)
                                }).ToList();

                    outputPort.GetListView(new Stp_OrganizationEntityTypeResponse(new AjaxResponse(oblist[0].RETURN_KEY, data), true, null));
                    return true;
                }
                else
                {
                 Stp_OrganizationEntityTypeResponse objResponse = new Stp_OrganizationEntityTypeResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetListView(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Stp_OrganizationEntityTypeResponse objResponse = new Stp_OrganizationEntityTypeResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetSingle(Stp_OrganizationEntityTypeRequest message, ICRUDRequestHandler<Stp_OrganizationEntityTypeResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                stp_organizationentitytypeEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.stp_organizationentitytypeFCC.GetFacadeCreate(_contextAccessor)
                .GetSingle(message.Objstp_organizationentitytype, cancellationToken);
                if (objSingle != null)
                {
                    outputPort.GetSingle(new Stp_OrganizationEntityTypeResponse(objSingle, true));
                    return true;
                }
                else
                {
                    Stp_OrganizationEntityTypeResponse objResponse = new Stp_OrganizationEntityTypeResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Stp_OrganizationEntityTypeResponse objResponse = new Stp_OrganizationEntityTypeResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }

        public async Task<bool> Save(Stp_OrganizationEntityTypeRequest message, ICRUDRequestHandler<Stp_OrganizationEntityTypeResponse> outputPort)
        {
            _logger.LogInformation(JsonConvert.SerializeObject(message));
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.stp_organizationentitytypeFCC.GetFacadeCreate(_contextAccessor)
                    .Add(message.Objstp_organizationentitytype, cancellationToken);
                    
                outputPort.Save(new Stp_OrganizationEntityTypeResponse(new AjaxResponse("200", _sharedLocalizer["DATA_SAVE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Stp_OrganizationEntityTypeResponse objResponse = new Stp_OrganizationEntityTypeResponse(false, _sharedLocalizer["DATA_SAVE_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Save(objResponse);
                return true;
            }
        }

        public async Task<bool> Update(Stp_OrganizationEntityTypeRequest message, ICRUDRequestHandler<Stp_OrganizationEntityTypeResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.stp_organizationentitytypeFCC.GetFacadeCreate(_contextAccessor)
                    .Update(message.Objstp_organizationentitytype, cancellationToken);
                
                outputPort.Update(new Stp_OrganizationEntityTypeResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Stp_OrganizationEntityTypeResponse objResponse = new Stp_OrganizationEntityTypeResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> Delete(Stp_OrganizationEntityTypeRequest message, ICRUDRequestHandler<Stp_OrganizationEntityTypeResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.stp_organizationentitytypeFCC.GetFacadeCreate(_contextAccessor)
                    .Delete(message.Objstp_organizationentitytype, cancellationToken);
                outputPort.Delete(new Stp_OrganizationEntityTypeResponse(new AjaxResponse("200", _sharedLocalizer["DATA_DELETE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                       ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Stp_OrganizationEntityTypeResponse objResponse = new Stp_OrganizationEntityTypeResponse(false, _sharedLocalizer["DATA_DELETE_ERROR"], new Error(
                         "500",
                         ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Delete(objResponse);
                return true;
            }
        }
        
        
        
        /// <summary>
		/// GetDataForDropDown Stp_OrganizationEntityType
		/// </summary>
		/// <param name="response"></param>
		public async Task<bool> GetDataForDropDown(Stp_OrganizationEntityTypeRequest message, IDDLRequestHandler<Stp_OrganizationEntityTypeResponse> outputPort)
		{
			CancellationToken cancellationToken = new CancellationToken();
			try
			{
				IList<gen_dropdownEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.stp_organizationentitytypeFCC.GetFacadeCreate(_contextAccessor).GetDataForDropDown(message.Objstp_organizationentitytype, cancellationToken);
				if (oblist != null && oblist.Count > 0)
				{
					outputPort.GetDropDown(new Stp_OrganizationEntityTypeResponse(new AjaxResponse(oblist[0].RETURN_KEY, oblist), true, null));
					return true;
				}
				else
				{
					Stp_OrganizationEntityTypeResponse objResponse = new Stp_OrganizationEntityTypeResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
					"404",
					_sharedLocalizer["NO_DATA_FOUND"]));
					_logger.LogInformation(JsonConvert.SerializeObject(objResponse));
					outputPort.GetDropDown(objResponse);
					return false;
				}
			}
			catch (Exception ex)
			{
				Stp_OrganizationEntityTypeResponse objResponse = new Stp_OrganizationEntityTypeResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
				"500",
				ex.Message));
				_logger.LogInformation(JsonConvert.SerializeObject(objResponse));
				outputPort.GetDropDown(objResponse);
				return true;
			}
		}

        
    }
}