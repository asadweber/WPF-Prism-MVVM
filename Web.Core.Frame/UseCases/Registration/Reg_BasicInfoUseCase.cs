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
    public sealed partial class Reg_BasicInfoUseCase : IReg_BasicInfoUseCase
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IJwtFactory _jwtFactory;
        private readonly IStringLocalizer _sharedLocalizer;
        private readonly ILogger<Reg_BasicInfoUseCase> _logger;
        private dataTableButtonPanel objDTBtnPanel = new dataTableButtonPanel();
        public Error _errors { get; set; }

        public Reg_BasicInfoUseCase(
            IHttpContextAccessor contextAccessor,
            IJwtFactory jwtFactory,
            IStringLocalizerFactory factory,
            ILoggerFactory loggerFactory)
        {
            _contextAccessor = contextAccessor;
            _jwtFactory = jwtFactory;
            _logger = loggerFactory.CreateLogger<Reg_BasicInfoUseCase>();

            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _sharedLocalizer = factory.Create("SharedResource", assemblyName.Name);
        }

        public Task<bool> Handle(Reg_BasicInfoRequest message, IOutputPort<Reg_BasicInfoResponse> outputPort)
        {
            throw new Exception("Not Implemented");
        }

        public async Task<bool> GetAll(Reg_BasicInfoRequest message, ICRUDRequestHandler<Reg_BasicInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<reg_basicinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_basicinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetAll(message.Objreg_basicinfo, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAll(new Reg_BasicInfoResponse(oblist.ToList(), true));
                    return true;
                }
                else
                {
                    Reg_BasicInfoResponse objResponse = new Reg_BasicInfoResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAll(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_BasicInfoResponse objResponse = new Reg_BasicInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAll(objResponse);
                return true;
            }
        }

        public async Task<bool> GetAllPaged(Reg_BasicInfoRequest message, ICRUDRequestHandler<Reg_BasicInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<reg_basicinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_basicinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetAllByPages(message.Objreg_basicinfo, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAllPaged(new Reg_BasicInfoResponse(oblist.ToList(), true));
                    return true;
                }
                else
                {
                    Reg_BasicInfoResponse objResponse = new Reg_BasicInfoResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAllPaged(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_BasicInfoResponse objResponse = new Reg_BasicInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAllPaged(objResponse);
                return true;
            }
        }

        public async Task<bool> GetListView(Reg_BasicInfoRequest message, ICRUDRequestHandler<Reg_BasicInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<reg_basicinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_basicinfoFCC.GetFacadeCreate(_contextAccessor)
                .GAPgListView(message.Objreg_basicinfo, cancellationToken);
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
                                    t.basicinfoid,
                                    t.civilid,
                                    t.passportno,
                                    t.fullname,
                                    t.name1,
                                    t.name2,
                                    t.name3,
                                    t.name4,
                                    t.name5,
                                    t.dob,
                                    t.birthcountryid,
                                    t.gender,
                                    t.mob1,
                                    t.mob2,
                                    t.mob3,
                                    t.telephone1,
                                    t.telephone2,
                                    t.telephone3,
                                    t.email,
                                    t.preaddcountryid,
                                    t.preaddgovernid,
                                    t.preaddcityid,
                                    t.preaddstreet,
                                    t.preaddblock,
                                    t.preaddhousingno,
                                    t.preaddhousingflatno,
                                    t.preaddress,
                                    t.prepaci,
                                    t.pres_latitude,
                                    t.pres_longitude,
                                    t.peraddcountryid,
                                    t.peraddgovernid,
                                    t.peraddcityid,
                                    t.peraddstreet,
                                    t.peraddblock,
                                    t.peraddhousingno,
                                    t.peraddhousingflatno,
                                    t.perpaci,
                                    t.peraddress,
                                    t.perm_latitude,
                                    t.perm_longitude,
                                    t.maritalstatus,
                                    t.nationalid,
                                    t.nationaldate,
                                    t.countrynationalityid,
                                    t.countryclassid,
                                    t.residenttypeid,
                                    t.bloodgroupid,
                                    t.relogionid,
                                    t.filepath,
                                    t.filename,
                                    t.filetype,
                                    t.extension,
                                    t.comment,
                                    t.userid,
                                    t.remarks,
                                    t.updateinfo,
                                    t.tranformactionid,
                                    datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objreg_basicinfo.ControllerName, t.basicinfoid, "basicinfoid", _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList)
                                }).ToList();

                    outputPort.GetListView(new Reg_BasicInfoResponse(new AjaxResponse(oblist[0].RETURN_KEY, data), true, null));
                    return true;
                }
                else
                {
                    Reg_BasicInfoResponse objResponse = new Reg_BasicInfoResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                        "404",
                        _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetListView(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_BasicInfoResponse objResponse = new Reg_BasicInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetSingle(Reg_BasicInfoRequest message, ICRUDRequestHandler<Reg_BasicInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                reg_basicinfoEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.reg_basicinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetSingle(message.Objreg_basicinfo, cancellationToken);
                if (objSingle != null)
                {
                    outputPort.GetSingle(new Reg_BasicInfoResponse(objSingle, true));
                    return true;
                }
                else
                {
                    Reg_BasicInfoResponse objResponse = new Reg_BasicInfoResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_BasicInfoResponse objResponse = new Reg_BasicInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }

        public async Task<bool> Save(Reg_BasicInfoRequest message, ICRUDRequestHandler<Reg_BasicInfoResponse> outputPort)
        {
            _logger.LogInformation(JsonConvert.SerializeObject(message));
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.reg_basicinfoFCC.GetFacadeCreate(_contextAccessor)
                    .Add(message.Objreg_basicinfo, cancellationToken);

                outputPort.Save(new Reg_BasicInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_SAVE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_BasicInfoResponse objResponse = new Reg_BasicInfoResponse(false, _sharedLocalizer["DATA_SAVE_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Save(objResponse);
                return true;
            }
        }

        public async Task<bool> Update(Reg_BasicInfoRequest message, ICRUDRequestHandler<Reg_BasicInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.reg_basicinfoFCC.GetFacadeCreate(_contextAccessor)
                    .Update(message.Objreg_basicinfo, cancellationToken);

                outputPort.Update(new Reg_BasicInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_BasicInfoResponse objResponse = new Reg_BasicInfoResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> Delete(Reg_BasicInfoRequest message, ICRUDRequestHandler<Reg_BasicInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.reg_basicinfoFCC.GetFacadeCreate(_contextAccessor)
                    .Delete(message.Objreg_basicinfo, cancellationToken);
                outputPort.Delete(new Reg_BasicInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_DELETE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                       ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_BasicInfoResponse objResponse = new Reg_BasicInfoResponse(false, _sharedLocalizer["DATA_DELETE_ERROR"], new Error(
                         "500",
                         ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Delete(objResponse);
                return true;
            }
        }



        /// <summary>
        /// GetDataForDropDown Reg_BasicInfo
        /// </summary>
        /// <param name="response"></param>
        public async Task<bool> GetDataForDropDown(Reg_BasicInfoRequest message, IDDLRequestHandler<Reg_BasicInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_dropdownEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_basicinfoFCC.GetFacadeCreate(_contextAccessor).GetDataForDropDown(message.Objreg_basicinfo, cancellationToken);
                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetDropDown(new Reg_BasicInfoResponse(new AjaxResponse(oblist[0].RETURN_KEY, oblist), true, null));
                    return true;
                }
                else
                {
                    Reg_BasicInfoResponse objResponse = new Reg_BasicInfoResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_BasicInfoResponse objResponse = new Reg_BasicInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return true;
            }
        }


    }
}