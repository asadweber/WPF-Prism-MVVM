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
    public sealed partial class Tran_ApplicantPhasesUseCase : ITran_ApplicantPhasesUseCase
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IJwtFactory _jwtFactory;
        private readonly IStringLocalizer _sharedLocalizer;
        private readonly ILogger<Tran_ApplicantPhasesUseCase> _logger;
        private dataTableButtonPanel objDTBtnPanel = new dataTableButtonPanel();
        public Error _errors { get; set; }

        public Tran_ApplicantPhasesUseCase(
            IHttpContextAccessor contextAccessor,
            IJwtFactory jwtFactory,
            IStringLocalizerFactory factory,
            ILoggerFactory loggerFactory)
        {
            _contextAccessor = contextAccessor;
            _jwtFactory = jwtFactory;
            _logger = loggerFactory.CreateLogger<Tran_ApplicantPhasesUseCase>();

            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _sharedLocalizer = factory.Create("SharedResource", assemblyName.Name);
        }

        public Task<bool> Handle(Tran_ApplicantPhasesRequest message, IOutputPort<Tran_ApplicantPhasesResponse> outputPort)
        {
            throw new Exception("Not Implemented");
        }

        public async Task<bool> GetAll(Tran_ApplicantPhasesRequest message, ICRUDRequestHandler<Tran_ApplicantPhasesResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<tran_applicantphasesEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.tran_applicantphasesFCC.GetFacadeCreate(_contextAccessor)
                .GetAll(message.Objtran_applicantphases, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAll(new Tran_ApplicantPhasesResponse(oblist.ToList(), true));
                    return true;
                }
                else
                {
                    Tran_ApplicantPhasesResponse objResponse = new Tran_ApplicantPhasesResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAll(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Tran_ApplicantPhasesResponse objResponse = new Tran_ApplicantPhasesResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAll(objResponse);
                return true;
            }
        }

        public async Task<bool> GetAllPaged(Tran_ApplicantPhasesRequest message, ICRUDRequestHandler<Tran_ApplicantPhasesResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<tran_applicantphasesEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.tran_applicantphasesFCC.GetFacadeCreate(_contextAccessor)
                .GetAllByPages(message.Objtran_applicantphases, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAllPaged(new Tran_ApplicantPhasesResponse(oblist.ToList(), true));
                    return true;
                }
                else
                {
                    Tran_ApplicantPhasesResponse objResponse = new Tran_ApplicantPhasesResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAllPaged(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Tran_ApplicantPhasesResponse objResponse = new Tran_ApplicantPhasesResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAllPaged(objResponse);
                return true;
            }
        }

        public async Task<bool> GetListView(Tran_ApplicantPhasesRequest message, ICRUDRequestHandler<Tran_ApplicantPhasesResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<tran_applicantphasesEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.tran_applicantphasesFCC.GetFacadeCreate(_contextAccessor)
                .GAPgListView(message.Objtran_applicantphases, cancellationToken);
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
                                    t.applicantphaseid,
                                    t.parentid,
                                    t.basicinfoid,
                                    t.registrationid,
                                    t.batchid,
                                    t.phaseid,
                                    t.statusid,
                                    t.submittedby,
                                    t.submitteddate,
                                   
                                    t.remarks,
                                    t.updateinfo,
                                    t.tranformactionid,
                                    datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objtran_applicantphases.ControllerName, t.applicantphaseid, "applicantphaseid", _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList)
                                }).ToList();

                    outputPort.GetListView(new Tran_ApplicantPhasesResponse(new AjaxResponse(oblist[0].RETURN_KEY, data), true, null));
                    return true;
                }
                else
                {
                    Tran_ApplicantPhasesResponse objResponse = new Tran_ApplicantPhasesResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                        "404",
                        _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetListView(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Tran_ApplicantPhasesResponse objResponse = new Tran_ApplicantPhasesResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetSingle(Tran_ApplicantPhasesRequest message, ICRUDRequestHandler<Tran_ApplicantPhasesResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                tran_applicantphasesEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.tran_applicantphasesFCC.GetFacadeCreate(_contextAccessor)
                .GetSingle(message.Objtran_applicantphases, cancellationToken);
                if (objSingle != null)
                {
                    outputPort.GetSingle(new Tran_ApplicantPhasesResponse(objSingle, true));
                    return true;
                }
                else
                {
                    Tran_ApplicantPhasesResponse objResponse = new Tran_ApplicantPhasesResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Tran_ApplicantPhasesResponse objResponse = new Tran_ApplicantPhasesResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }

        public async Task<bool> Save(Tran_ApplicantPhasesRequest message, ICRUDRequestHandler<Tran_ApplicantPhasesResponse> outputPort)
        {
            _logger.LogInformation(JsonConvert.SerializeObject(message));
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.tran_applicantphasesFCC.GetFacadeCreate(_contextAccessor)
                    .Add(message.Objtran_applicantphases, cancellationToken);

                outputPort.Save(new Tran_ApplicantPhasesResponse(new AjaxResponse("200", _sharedLocalizer["DATA_SAVE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Tran_ApplicantPhasesResponse objResponse = new Tran_ApplicantPhasesResponse(false, _sharedLocalizer["DATA_SAVE_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Save(objResponse);
                return true;
            }
        }

        public async Task<bool> Update(Tran_ApplicantPhasesRequest message, ICRUDRequestHandler<Tran_ApplicantPhasesResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.tran_applicantphasesFCC.GetFacadeCreate(_contextAccessor)
                    .Update(message.Objtran_applicantphases, cancellationToken);

                outputPort.Update(new Tran_ApplicantPhasesResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Tran_ApplicantPhasesResponse objResponse = new Tran_ApplicantPhasesResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> Delete(Tran_ApplicantPhasesRequest message, ICRUDRequestHandler<Tran_ApplicantPhasesResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.tran_applicantphasesFCC.GetFacadeCreate(_contextAccessor)
                    .Delete(message.Objtran_applicantphases, cancellationToken);
                outputPort.Delete(new Tran_ApplicantPhasesResponse(new AjaxResponse("200", _sharedLocalizer["DATA_DELETE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                       ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Tran_ApplicantPhasesResponse objResponse = new Tran_ApplicantPhasesResponse(false, _sharedLocalizer["DATA_DELETE_ERROR"], new Error(
                         "500",
                         ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Delete(objResponse);
                return true;
            }
        }



        /// <summary>
        /// GetDataForDropDown Tran_ApplicantPhases
        /// </summary>
        /// <param name="response"></param>
        public async Task<bool> GetDataForDropDown(Tran_ApplicantPhasesRequest message, IDDLRequestHandler<Tran_ApplicantPhasesResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_dropdownEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.tran_applicantphasesFCC.GetFacadeCreate(_contextAccessor).GetDataForDropDown(message.Objtran_applicantphases, cancellationToken);
                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetDropDown(new Tran_ApplicantPhasesResponse(new AjaxResponse(oblist[0].RETURN_KEY, oblist), true, null));
                    return true;
                }
                else
                {
                    Tran_ApplicantPhasesResponse objResponse = new Tran_ApplicantPhasesResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Tran_ApplicantPhasesResponse objResponse = new Tran_ApplicantPhasesResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return true;
            }
        }


    }
}