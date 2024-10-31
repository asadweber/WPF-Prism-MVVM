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
using Microsoft.AspNet.SignalR.Client.Http;
using Web.Core.Frame.Presenters.Registration;
using Microsoft.Extensions.Options;

namespace Web.Core.Frame.UseCases.Registration
{
    public sealed partial class Reg_FamillyUseCase : IReg_FamillyUseCase
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IJwtFactory _jwtFactory;
        private readonly IStringLocalizer _sharedLocalizer;
        private readonly ILogger<Reg_FamillyUseCase> _logger;
        private dataTableButtonPanel objDTBtnPanel = new dataTableButtonPanel();

        private readonly IFileUploadClient fileuploadclient;
        private readonly FtpServerSetting ftpServerSetting;
        public Error _errors { get; set; }

        public Reg_FamillyUseCase(
            IHttpContextAccessor contextAccessor,
            IJwtFactory jwtFactory,
            IStringLocalizerFactory factory,
            ILoggerFactory loggerFactory,
             IFileUploadClient fileuploadclient,
            IOptions<FtpServerSetting> ftpServerSetting
            )
        {
            _contextAccessor = contextAccessor;
            _jwtFactory = jwtFactory;
            _logger = loggerFactory.CreateLogger<Reg_FamillyUseCase>();

            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _sharedLocalizer = factory.Create("SharedResource", assemblyName.Name);
            this.ftpServerSetting = ftpServerSetting.Value;
            this.fileuploadclient = fileuploadclient;
        }

        public Task<bool> Handle(Reg_FamillyRequest message, IOutputPort<Reg_FamillyResponse> outputPort)
        {
            throw new Exception("Not Implemented");
        }

        public async Task<bool> GetAll(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<reg_famillyEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_famillyFCC.GetFacadeCreate(_contextAccessor)
                .GetAll(message.Objreg_familly, cancellationToken);

                outputPort.GetAll(new Reg_FamillyResponse((oblist != null && oblist.Count > 0) ? oblist.ToList() : new List<reg_famillyEntity>(), true));
                return true;
                //if (oblist != null && oblist.Count > 0)
                //{
                //    outputPort.GetAll(new Reg_FamillyResponse((oblist != null && oblist.Count > 0) ? oblist.ToList() : null, true));
                //    return true;
                //}
                //else
                //{
                //    Reg_FamillyResponse objResponse = new Reg_FamillyResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                //     "404",
                //     _sharedLocalizer["NO_DATA_FOUND"]));
                //    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                //    outputPort.GetAll(objResponse);
                //    return false;
                //}
            }
            catch (Exception ex)
            {
                Reg_FamillyResponse objResponse = new Reg_FamillyResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAll(objResponse);
                return true;
            }
        }

        public async Task<bool> GetAllPaged(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<reg_famillyEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_famillyFCC.GetFacadeCreate(_contextAccessor)
                .GetAllByPages(message.Objreg_familly, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAllPaged(new Reg_FamillyResponse(oblist.ToList(), true));
                    return true;
                }
                else
                {
                    Reg_FamillyResponse objResponse = new Reg_FamillyResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAllPaged(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_FamillyResponse objResponse = new Reg_FamillyResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAllPaged(objResponse);
                return true;
            }
        }

        public async Task<bool> GetListView(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<reg_famillyEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_famillyFCC.GetFacadeCreate(_contextAccessor)
                .GAPgListView(message.Objreg_familly, cancellationToken);
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
                                    t.familyid,
                                    t.parentid,
                                    t.basicinfoid,
                                    t.relationshipid,
                                    t.familygenderid,
                                    t.familyreligionid,
                                    t.familybloodgroupid,
                                    t.maritalstatusid,
                                    t.parentalstatus,
                                    t.nationalityid,
                                    t.classid,
                                    t.birthcountryid,
                                    t.prevnationalityid,
                                    t.birthdate,
                                    t.civilid,
                                    t.nationalid,
                                    t.passportnumber,
                                    t.fullname,
                                    t.name1,
                                    t.name2,
                                    t.name3,
                                    t.name4,
                                    t.name5,
                                    t.isservedinmilitary,
                                    t.isserving,
                                    t.splmilstatus,
                                    t.militaryid,
                                    t.companyid,
                                    t.workdesignation,
                                    t.workcompany,
                                    t.companytype,
                                    t.companyaddress,
                                    t.enrollmentdate,
                                    t.previousjob,
                                    t.previousjobdetails,
                                    t.preaddcountryid,
                                    t.preaddgovernid,
                                    t.preaddcityid,
                                    t.preaddstreet,
                                    t.preaddblock,
                                    t.preaddhousingno,
                                    t.preaddhousingflatno,
                                    t.prepaci,
                                    t.preaddress,
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
                                    t.email,
                                    t.mobilephone1,
                                    t.mobilephone2,
                                    t.mobilephone3,
                                    t.lanphone1,
                                    t.lanphone2,
                                    t.lanphone3,
                                    t.ismarried,
                                    t.familymarriagedate,
                                    t.familymarriagedocno,
                                    t.familymarriagedocdate,
                                    t.deathdate,
                                    t.filepath,
                                    t.filename,
                                    t.filetype,
                                    t.extension,
                                    t.securitycardvaliddate,
                                    t.comment,
                                    t.remarks,
                                    t.updateinfo,
                                    t.tranformactionid,
                                    datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objreg_familly.ControllerName, t.familyid, "familyid", _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList)
                                }).ToList();

                    outputPort.GetListView(new Reg_FamillyResponse(new AjaxResponse(oblist[0].RETURN_KEY, data), true, null));
                    return true;
                }
                else
                {
                    Reg_FamillyResponse objResponse = new Reg_FamillyResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                        "404",
                        _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetListView(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_FamillyResponse objResponse = new Reg_FamillyResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetSingle(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                reg_famillyEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.reg_famillyFCC.GetFacadeCreate(_contextAccessor)
                .GetSingle(message.Objreg_familly, cancellationToken);
                if (objSingle != null)
                {
                    outputPort.GetSingle(new Reg_FamillyResponse(objSingle, true));
                    return true;
                }
                else
                {
                    Reg_FamillyResponse objResponse = new Reg_FamillyResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_FamillyResponse objResponse = new Reg_FamillyResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }

        public async Task<bool> Save(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort)
        {
            _logger.LogInformation(JsonConvert.SerializeObject(message));
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.reg_famillyFCC.GetFacadeCreate(_contextAccessor)
                    .Add(message.Objreg_familly, cancellationToken);
                if (message.Objreg_familly.spouseInfo != null)
                {
                    message.Objreg_familly.spouseInfo.BaseSecurityParam = message.Objreg_familly.BaseSecurityParam;
                    message.Objreg_familly.spouseInfo.basicinfoid = message.Objreg_familly.basicinfoid;
                    message.Objreg_familly.spouseInfo.parentid = i;
                    message.Objreg_familly.spouseInfo.isinkuwait = message.Objreg_familly.isinkuwait;

                    i = await BFC.Core.FacadeCreatorObjects.General.reg_famillyFCC.GetFacadeCreate(_contextAccessor)
                    .Add(message.Objreg_familly.spouseInfo, cancellationToken);
                }

                outputPort.Save(new Reg_FamillyResponse(new AjaxResponse("200", _sharedLocalizer["DATA_SAVE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_FamillyResponse objResponse = new Reg_FamillyResponse(
                       new AjaxResponse("200", _sharedLocalizer["DATA_SAVE_ERROR"], "false", "", ""),
                       false,
                       ex.Message);
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Save(objResponse);
                return true;
            }
        }

        public async Task<bool> Update(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.reg_famillyFCC.GetFacadeCreate(_contextAccessor)
                    .Update(message.Objreg_familly, cancellationToken);

                if (message.Objreg_familly.spouseInfo != null)
                {
                    message.Objreg_familly.spouseInfo.BaseSecurityParam = message.Objreg_familly.BaseSecurityParam;
                    message.Objreg_familly.spouseInfo.basicinfoid = message.Objreg_familly.basicinfoid;
                    message.Objreg_familly.spouseInfo.parentid = i;
                    message.Objreg_familly.spouseInfo.isinkuwait = message.Objreg_familly.isinkuwait;


                    if (message.Objreg_familly.spouseInfo.familyid.HasValue)
                    {
                        i = await BFC.Core.FacadeCreatorObjects.General.reg_famillyFCC.GetFacadeCreate(_contextAccessor)
                        .Update(message.Objreg_familly.spouseInfo, cancellationToken);
                    }
                    else
                    {
                        i = await BFC.Core.FacadeCreatorObjects.General.reg_famillyFCC.GetFacadeCreate(_contextAccessor)
                                               .Add(message.Objreg_familly.spouseInfo, cancellationToken);
                    }
                }

                outputPort.Update(new Reg_FamillyResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                    ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_FamillyResponse objResponse = new Reg_FamillyResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> Delete(Reg_FamillyRequest message, ICRUDRequestHandler<Reg_FamillyResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.reg_famillyFCC.GetFacadeCreate(_contextAccessor)
                    .Delete(message.Objreg_familly, cancellationToken);
                outputPort.Delete(new Reg_FamillyResponse(new AjaxResponse("200", _sharedLocalizer["DATA_DELETE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                       ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_FamillyResponse objResponse = new Reg_FamillyResponse(false, _sharedLocalizer["DATA_DELETE_ERROR"], new Error(
                         "500",
                         ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Delete(objResponse);
                return true;
            }
        }



        /// <summary>
        /// GetDataForDropDown Reg_Familly
        /// </summary>
        /// <param name="response"></param>
        public async Task<bool> GetDataForDropDown(Reg_FamillyRequest message, IDDLRequestHandler<Reg_FamillyResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_dropdownEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_famillyFCC.GetFacadeCreate(_contextAccessor).GetDataForDropDown(message.Objreg_familly, cancellationToken);
                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetDropDown(new Reg_FamillyResponse(new AjaxResponse(oblist[0].RETURN_KEY, oblist), true, null));
                    return true;
                }
                else
                {
                    Reg_FamillyResponse objResponse = new Reg_FamillyResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_FamillyResponse objResponse = new Reg_FamillyResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return true;
            }
        }


    }
}