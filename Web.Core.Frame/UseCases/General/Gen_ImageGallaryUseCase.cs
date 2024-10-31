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
using Microsoft.Extensions.Options;

namespace Web.Core.Frame.UseCases
{
    public sealed partial class Gen_ImageGallaryUseCase : IGen_ImageGallaryUseCase
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IJwtFactory _jwtFactory;
        private readonly IStringLocalizer _sharedLocalizer;
        private readonly ILogger<Gen_ImageGallaryUseCase> _logger;
        private dataTableButtonPanel objDTBtnPanel = new dataTableButtonPanel();
        public Error _errors { get; set; }
        private readonly FtpServerSetting _ftpServerSetting;

        public Gen_ImageGallaryUseCase(
            IHttpContextAccessor contextAccessor,
            IJwtFactory jwtFactory,
            IStringLocalizerFactory factory,
            IOptions<FtpServerSetting> ftpServerSetting,
            ILoggerFactory loggerFactory)
        {
            _contextAccessor = contextAccessor;
            _jwtFactory = jwtFactory;
            _logger = loggerFactory.CreateLogger<Gen_ImageGallaryUseCase>();

            _ftpServerSetting = ftpServerSetting.Value;
            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _sharedLocalizer = factory.Create("SharedResource", assemblyName.Name);
        }

        public Task<bool> Handle(Gen_ImageGallaryRequest message, IOutputPort<Gen_ImageGallaryResponse> outputPort)
        {
            throw new Exception("Not Implemented");
        }

        public async Task<bool> GetAll(Gen_ImageGallaryRequest message, ICRUDRequestHandler<Gen_ImageGallaryResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_imagegallaryEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_imagegallaryFCC.GetFacadeCreate(_contextAccessor)
                .GetAll(message.Objgen_imagegallary, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                     foreach (var item in oblist)
                    {
						 item.imagepath = !string.IsNullOrEmpty(item.imagename) ? $"{ this._ftpServerSetting.ReadFileUrl}ImageGallery/{item.imagename}{item.imageextension}" : "";
					    }
            
                    outputPort.GetAll(new Gen_ImageGallaryResponse(oblist.ToList(), true));
                    return true;
                }
                else
                {
                    outputPort.GetAll(new Gen_ImageGallaryResponse(new List<gen_imagegallaryEntity>(), true));
                    return true;
                }                
            }
            catch (Exception ex)
            {
                Gen_ImageGallaryResponse objResponse = new Gen_ImageGallaryResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAll(objResponse);
                return true;
            }
        }

        public async Task<bool> GetAllPaged(Gen_ImageGallaryRequest message, ICRUDRequestHandler<Gen_ImageGallaryResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_imagegallaryEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_imagegallaryFCC.GetFacadeCreate(_contextAccessor)
                .GetAllByPages(message.Objgen_imagegallary, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAllPaged(new Gen_ImageGallaryResponse(oblist.ToList(), true));
                    return true;
                }
                else
                {
                    Gen_ImageGallaryResponse objResponse = new Gen_ImageGallaryResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAllPaged(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_ImageGallaryResponse objResponse = new Gen_ImageGallaryResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAllPaged(objResponse);
                return true;
            }
        }

        public async Task<bool> GetListView(Gen_ImageGallaryRequest message, ICRUDRequestHandler<Gen_ImageGallaryResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<gen_imagegallaryEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_imagegallaryFCC.GetFacadeCreate(_contextAccessor)
                .GAPgListView(message.Objgen_imagegallary, cancellationToken);
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
									 t.imagegallaryid,
									 t.imagegallarycategoryid,
									 t.imagepath,
									 t.imagetype,
									 t.imageextension,
									 t.imagename,
									 t.headingtextar,
									 t.headingtext,
									 t.bodytextar,
									 t.bodytext,
									 t.isslider,                                    datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objgen_imagegallary.ControllerName, t.imagegallaryid, "imagegallaryid", _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList)
                                }).ToList();

                    outputPort.GetListView(new Gen_ImageGallaryResponse(new AjaxResponse(oblist[0].RETURN_KEY, data), true, null));
                    return true;
                }
                else
                {
                 Gen_ImageGallaryResponse objResponse = new Gen_ImageGallaryResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetListView(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_ImageGallaryResponse objResponse = new Gen_ImageGallaryResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetSingle(Gen_ImageGallaryRequest message, ICRUDRequestHandler<Gen_ImageGallaryResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                gen_imagegallaryEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.gen_imagegallaryFCC.GetFacadeCreate(_contextAccessor)
                .GetSingle(message.Objgen_imagegallary, cancellationToken);
                if (objSingle != null)
                {
                    outputPort.GetSingle(new Gen_ImageGallaryResponse(objSingle, true));
                    return true;
                }
                else
                {
                    Gen_ImageGallaryResponse objResponse = new Gen_ImageGallaryResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_ImageGallaryResponse objResponse = new Gen_ImageGallaryResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }

        public async Task<bool> Save(Gen_ImageGallaryRequest message, ICRUDRequestHandler<Gen_ImageGallaryResponse> outputPort)
        {
            _logger.LogInformation(JsonConvert.SerializeObject(message));
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.gen_imagegallaryFCC.GetFacadeCreate(_contextAccessor)
                    .Add(message.Objgen_imagegallary, cancellationToken);
                    
                outputPort.Save(new Gen_ImageGallaryResponse(new AjaxResponse("200", _sharedLocalizer["DATA_SAVE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Gen_ImageGallaryResponse objResponse = new Gen_ImageGallaryResponse(false, _sharedLocalizer["DATA_SAVE_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Save(objResponse);
                return true;
            }
        }

        public async Task<bool> Update(Gen_ImageGallaryRequest message, ICRUDRequestHandler<Gen_ImageGallaryResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.gen_imagegallaryFCC.GetFacadeCreate(_contextAccessor)
                    .Update(message.Objgen_imagegallary, cancellationToken);
                
                outputPort.Update(new Gen_ImageGallaryResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Gen_ImageGallaryResponse objResponse = new Gen_ImageGallaryResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> Delete(Gen_ImageGallaryRequest message, ICRUDRequestHandler<Gen_ImageGallaryResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.gen_imagegallaryFCC.GetFacadeCreate(_contextAccessor)
                    .Delete(message.Objgen_imagegallary, cancellationToken);
                outputPort.Delete(new Gen_ImageGallaryResponse(new AjaxResponse("200", _sharedLocalizer["DATA_DELETE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                       ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Gen_ImageGallaryResponse objResponse = new Gen_ImageGallaryResponse(false, _sharedLocalizer["DATA_DELETE_ERROR"], new Error(
                         "500",
                         ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Delete(objResponse);
                return true;
            }
        }
        
        
        
        
        
    }
}