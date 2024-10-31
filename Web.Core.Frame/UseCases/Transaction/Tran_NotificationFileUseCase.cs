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
using Microsoft.Extensions.Configuration;
using System.Configuration;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;

namespace Web.Core.Frame.UseCases
{
    public sealed partial class Tran_NotificationFileUseCase : ITran_NotificationFileUseCase
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IJwtFactory _jwtFactory;
        private readonly IStringLocalizer _sharedLocalizer;
        private readonly ILogger<Tran_NotificationFileUseCase> _logger;
        private dataTableButtonPanel objDTBtnPanel = new dataTableButtonPanel();
        public Error _errors { get; set; }
        private readonly FtpSettings _ftpSettings;
        private readonly IConfiguration _configuration;

        public Tran_NotificationFileUseCase(
            IHttpContextAccessor contextAccessor,
            IJwtFactory jwtFactory,
            IStringLocalizerFactory factory,
            ILoggerFactory loggerFactory,
            IConfiguration configuration)
        {
            _contextAccessor = contextAccessor;
            _jwtFactory = jwtFactory;
            _logger = loggerFactory.CreateLogger<Tran_NotificationFileUseCase>();

            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _sharedLocalizer = factory.Create("SharedResource", assemblyName.Name);
            _configuration = configuration;
            _ftpSettings = _configuration.GetSection(nameof(FtpSettings)).Get<FtpSettings>();
        }

        public Task<bool> Handle(Tran_NotificationFileRequest message, IOutputPort<Tran_NotificationFileResponse> outputPort)
        {
            throw new Exception("Not Implemented");
        }

        public async Task<bool> GetAll(Tran_NotificationFileRequest message, ICRUDRequestHandler<Tran_NotificationFileResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<tran_notificationfileEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.tran_notificationfileFCC.GetFacadeCreate(_contextAccessor)
                .GetAll(message.Objtran_notificationfile, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAll(new Tran_NotificationFileResponse(oblist.ToList(), true));
                    return true;
                }
                else
                {
                    Tran_NotificationFileResponse objResponse = new Tran_NotificationFileResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAll(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Tran_NotificationFileResponse objResponse = new Tran_NotificationFileResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAll(objResponse);
                return true;
            }
        }

        public async Task<bool> GetAllPaged(Tran_NotificationFileRequest message, ICRUDRequestHandler<Tran_NotificationFileResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<tran_notificationfileEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.tran_notificationfileFCC.GetFacadeCreate(_contextAccessor)
                .GetAllByPages(message.Objtran_notificationfile, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAllPaged(new Tran_NotificationFileResponse(oblist.ToList(), true));
                    return true;
                }
                else
                {
                    Tran_NotificationFileResponse objResponse = new Tran_NotificationFileResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAllPaged(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Tran_NotificationFileResponse objResponse = new Tran_NotificationFileResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAllPaged(objResponse);
                return true;
            }
        }

        public async Task<bool> GetListView(Tran_NotificationFileRequest message, ICRUDRequestHandler<Tran_NotificationFileResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<tran_notificationfileEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.tran_notificationfileFCC.GetFacadeCreate(_contextAccessor)
                .GAPgListView(message.Objtran_notificationfile, cancellationToken);
                
                List<dataTableButtonModel> btnActionList = new List<dataTableButtonModel>();
                //btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.New_GET));
                //btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.Edit_GET));
                //btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.Delete_GET));
                btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.GetSingle_GET));
                //btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.CUSTOM, _sharedLocalizer["PROCESS"], "StpOrganizationEntity/userprocess"));
                //btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.CUSTOM, _sharedLocalizer["SEARCH"], "StpOrganizationEntity/usersearch"));

                var data = (from t in oblist
                            select new
                            {
                                t.filerequestid,
                                t.fileguid,
                                t.applicationid,
                                t.physicalfilename,
                                t.userfilename,
                                t.filetype,
                                t.fileextension,
                                t.filesize,
                                t.messagesubject,
                                t.messagebody,
                                t.messagesubjectar,
                                t.messagebodyar,
                                t.messagebodyemail,
                                t.messagebodyemailar,
                                t.sendsms,
                                t.senddigitalidnotification,
                                t.sendemail,
                                t.fileid,
                                t.fileuploaddate,
                                t.fileuploadresult,
                                t.comment,
                                datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objtran_notificationfile.ControllerName, t.filerequestid, "filerequestid", _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList, _contextAccessor)
                            }).ToList();

                outputPort.GetListView(new Tran_NotificationFileResponse(new AjaxResponse(oblist.Count > 0 ? oblist[0].RETURN_KEY : 0, data), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Tran_NotificationFileResponse objResponse = new Tran_NotificationFileResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetSingle(Tran_NotificationFileRequest message, ICRUDRequestHandler<Tran_NotificationFileResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                tran_notificationfileEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.tran_notificationfileFCC.GetFacadeCreate(_contextAccessor)
                .GetSingle(message.Objtran_notificationfile, cancellationToken);
                if (objSingle != null)
                {
                    outputPort.GetSingle(new Tran_NotificationFileResponse(objSingle, true));
                    return true;
                }
                else
                {
                    Tran_NotificationFileResponse objResponse = new Tran_NotificationFileResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Tran_NotificationFileResponse objResponse = new Tran_NotificationFileResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }

        public async Task<bool> Save(Tran_NotificationFileRequest message, ICRUDRequestHandler<Tran_NotificationFileResponse> outputPort)
        {
            _logger.LogInformation(JsonConvert.SerializeObject(message));
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.tran_notificationfileFCC.GetFacadeCreate(_contextAccessor)
                    .Add(message.Objtran_notificationfile, cancellationToken);

                outputPort.Save(new Tran_NotificationFileResponse(new AjaxResponse("200", _sharedLocalizer["DATA_SAVE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Tran_NotificationFileResponse objResponse = new Tran_NotificationFileResponse(false, _sharedLocalizer["DATA_SAVE_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Save(objResponse);
                return true;
            }
        }

        public async Task<bool> Update(Tran_NotificationFileRequest message, ICRUDRequestHandler<Tran_NotificationFileResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.tran_notificationfileFCC.GetFacadeCreate(_contextAccessor)
                    .Update(message.Objtran_notificationfile, cancellationToken);

                outputPort.Update(new Tran_NotificationFileResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Tran_NotificationFileResponse objResponse = new Tran_NotificationFileResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> Delete(Tran_NotificationFileRequest message, ICRUDRequestHandler<Tran_NotificationFileResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.tran_notificationfileFCC.GetFacadeCreate(_contextAccessor)
                    .Delete(message.Objtran_notificationfile, cancellationToken);
                outputPort.Delete(new Tran_NotificationFileResponse(new AjaxResponse("200", _sharedLocalizer["DATA_DELETE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                       ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Tran_NotificationFileResponse objResponse = new Tran_NotificationFileResponse(false, _sharedLocalizer["DATA_DELETE_ERROR"], new Error(
                         "500",
                         ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Delete(objResponse);
                return true;
            }
        }





    }
}