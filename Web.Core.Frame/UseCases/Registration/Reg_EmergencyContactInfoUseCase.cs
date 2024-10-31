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
using Web.Core.Frame.Interfaces.UseCases.Registration;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.Dto.UseCaseRequests.Registration;

namespace Web.Core.Frame.UseCases.Registration
{
    public sealed partial class Reg_EmergencyContactInfoUseCase : IReg_EmergencyContactInfoUseCase
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IJwtFactory _jwtFactory;
        private readonly IStringLocalizer _sharedLocalizer;
        private readonly ILogger<Reg_EmergencyContactInfoUseCase> _logger;
        private dataTableButtonPanel objDTBtnPanel = new dataTableButtonPanel();
        public Error _errors { get; set; }

        public Reg_EmergencyContactInfoUseCase(
            IHttpContextAccessor contextAccessor,
            IJwtFactory jwtFactory,
            IStringLocalizerFactory factory,
            ILoggerFactory loggerFactory)
        {
            _contextAccessor = contextAccessor;
            _jwtFactory = jwtFactory;
            _logger = loggerFactory.CreateLogger<Reg_EmergencyContactInfoUseCase>();

            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _sharedLocalizer = factory.Create("SharedResource", assemblyName.Name);
        }

        public Task<bool> Handle(Reg_EmergencyContactInfoRequest message, IOutputPort<Reg_EmergencyContactInfoResponse> outputPort)
        {
            throw new Exception("Not Implemented");
        }

        public async Task<bool> GetAll(Reg_EmergencyContactInfoRequest message, ICRUDRequestHandler<Reg_EmergencyContactInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<reg_emergencycontactinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_emergencycontactinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetAll(message.Objreg_emergencycontactinfo, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAll(new Reg_EmergencyContactInfoResponse(oblist.ToList(), true));
                    return true;
                }
                else
                {
                    Reg_EmergencyContactInfoResponse objResponse = new Reg_EmergencyContactInfoResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAll(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_EmergencyContactInfoResponse objResponse = new Reg_EmergencyContactInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAll(objResponse);
                return true;
            }
        }

        public async Task<bool> GetAllPaged(Reg_EmergencyContactInfoRequest message, ICRUDRequestHandler<Reg_EmergencyContactInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<reg_emergencycontactinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_emergencycontactinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetAllByPages(message.Objreg_emergencycontactinfo, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAllPaged(new Reg_EmergencyContactInfoResponse(oblist.ToList(), true));
                    return true;
                }
                else
                {
                    Reg_EmergencyContactInfoResponse objResponse = new Reg_EmergencyContactInfoResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAllPaged(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_EmergencyContactInfoResponse objResponse = new Reg_EmergencyContactInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAllPaged(objResponse);
                return true;
            }
        }

        public async Task<bool> GetListView(Reg_EmergencyContactInfoRequest message, ICRUDRequestHandler<Reg_EmergencyContactInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<reg_emergencycontactinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_emergencycontactinfoFCC.GetFacadeCreate(_contextAccessor)
                .GAPgListView(message.Objreg_emergencycontactinfo, cancellationToken);
                
                    List<dataTableButtonModel> btnActionList = new List<dataTableButtonModel>();
                    var edit = new dataTableButtonModel(basicCRUDButtons.Edit_GET);
                    edit.isCheckPermission = false;
                    edit.JsMethodName = "EditEmergencyContactInfo";

                    var delete = new dataTableButtonModel(basicCRUDButtons.Delete_GET);
                    delete.isCheckPermission = false;
                    delete.JsMethodName = "DeleteEmergencyContactInfo";

                    btnActionList.Add(edit);
                    btnActionList.Add(delete);

                    var data = (from t in oblist
                                select new
                                {
                                    t.emergencycontactid,
                                    t.basicinfoid,
                                    t.familyid,
                                    t.name1,
                                    t.name2,
                                    t.name3,
                                    t.name4,
                                    t.name5,
                                    t.fullname,
                                    t.mobile1,
                                    t.mobile2,
                                    t.telephone1,
                                    t.telephone2,
                                    t.email,
                                    t.comment,
                                    t.remarks,
                                    t.updateinfo,
                                    t.tranformactionid,
                                    datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objreg_emergencycontactinfo.ControllerName, t.emergencycontactid, "emergencycontactid", _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList,_contextAccessor)
                                }).ToList();

                    outputPort.GetListView(new Reg_EmergencyContactInfoResponse(new AjaxResponse(oblist[0].RETURN_KEY, data), true, null));
                    return true;
               
            }
            catch (Exception ex)
            {
                Reg_EmergencyContactInfoResponse objResponse = new Reg_EmergencyContactInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetSingle(Reg_EmergencyContactInfoRequest message, ICRUDRequestHandler<Reg_EmergencyContactInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                reg_emergencycontactinfoEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.reg_emergencycontactinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetSingle(message.Objreg_emergencycontactinfo, cancellationToken);
                if (objSingle != null)
                {
                    outputPort.GetSingle(new Reg_EmergencyContactInfoResponse(objSingle, true));
                    return true;
                }
                else
                {
                    Reg_EmergencyContactInfoResponse objResponse = new Reg_EmergencyContactInfoResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_EmergencyContactInfoResponse objResponse = new Reg_EmergencyContactInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }

        public async Task<bool> Save(Reg_EmergencyContactInfoRequest message, ICRUDRequestHandler<Reg_EmergencyContactInfoResponse> outputPort)
        {
            _logger.LogInformation(JsonConvert.SerializeObject(message));
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                message.Objreg_emergencycontactinfo.fullname = $"{message.Objreg_emergencycontactinfo.name1} {message.Objreg_emergencycontactinfo.name2} {message.Objreg_emergencycontactinfo.name3} {message.Objreg_emergencycontactinfo.name4} {message.Objreg_emergencycontactinfo.name5}";
                i = await BFC.Core.FacadeCreatorObjects.General.reg_emergencycontactinfoFCC.GetFacadeCreate(_contextAccessor)
                    .Add(message.Objreg_emergencycontactinfo, cancellationToken);

                outputPort.Save(new Reg_EmergencyContactInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_SAVE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_EmergencyContactInfoResponse objResponse = new Reg_EmergencyContactInfoResponse(false, _sharedLocalizer["DATA_SAVE_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Save(objResponse);
                return true;
            }
        }

        public async Task<bool> Update(Reg_EmergencyContactInfoRequest message, ICRUDRequestHandler<Reg_EmergencyContactInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.reg_emergencycontactinfoFCC.GetFacadeCreate(_contextAccessor)
                    .Update(message.Objreg_emergencycontactinfo, cancellationToken);

                outputPort.Update(new Reg_EmergencyContactInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_EmergencyContactInfoResponse objResponse = new Reg_EmergencyContactInfoResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> Delete(Reg_EmergencyContactInfoRequest message, ICRUDRequestHandler<Reg_EmergencyContactInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.reg_emergencycontactinfoFCC.GetFacadeCreate(_contextAccessor)
                    .Delete(message.Objreg_emergencycontactinfo, cancellationToken);
                outputPort.Delete(new Reg_EmergencyContactInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_DELETE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                       ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_EmergencyContactInfoResponse objResponse = new Reg_EmergencyContactInfoResponse(false, _sharedLocalizer["DATA_DELETE_ERROR"], new Error(
                         "500",
                         ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Delete(objResponse);
                return true;
            }
        }



        /// <summary>
        /// GetDataForDropDown Reg_EmergencyContactInfo
        /// </summary>
        /// <param name="response"></param>
        public async Task<bool> GetDataForDropDown(Reg_EmergencyContactInfoRequest message, IDDLRequestHandler<Reg_EmergencyContactInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_dropdownEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_emergencycontactinfoFCC.GetFacadeCreate(_contextAccessor).GetDataForDropDown(message.Objreg_emergencycontactinfo, cancellationToken);
                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetDropDown(new Reg_EmergencyContactInfoResponse(new AjaxResponse(oblist[0].RETURN_KEY, oblist), true, null));
                    return true;
                }
                else
                {
                    Reg_EmergencyContactInfoResponse objResponse = new Reg_EmergencyContactInfoResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_EmergencyContactInfoResponse objResponse = new Reg_EmergencyContactInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return true;
            }
        }


    }
}