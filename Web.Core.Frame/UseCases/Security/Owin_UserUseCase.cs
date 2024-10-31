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
using Web.Core.Frame.CustomIdentityManagers;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;

namespace Web.Core.Frame.UseCases
{
    public sealed partial class Owin_UserUseCase : IOwin_UserUseCase
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IJwtFactory _jwtFactory;
        private readonly IStringLocalizer _sharedLocalizer;
        private readonly ILogger<Owin_UserUseCase> _logger;
        private dataTableButtonPanel objDTBtnPanel = new dataTableButtonPanel();

        private readonly ApplicationUserManager<owin_userEntity> _userManager;
        private readonly ApplicationSignInManager<owin_userEntity> _signInManager;
        public Error _errors { get; set; }

        public Owin_UserUseCase(
            IHttpContextAccessor contextAccessor,
            IJwtFactory jwtFactory,
            IStringLocalizerFactory factory,
            ILoggerFactory loggerFactory,
            ApplicationUserManager<owin_userEntity> userManager,
            ApplicationSignInManager<owin_userEntity> signInManager
            )
        {
            _contextAccessor = contextAccessor;
            _jwtFactory = jwtFactory;
            _logger = loggerFactory.CreateLogger<Owin_UserUseCase>();

            _userManager = userManager;
            _signInManager = signInManager;

            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _sharedLocalizer = factory.Create("SharedResource", assemblyName.Name);
        }

        public Task<bool> Handle(Owin_UserRequest message, IOutputPort<Owin_UserResponse> outputPort)
        {
            throw new Exception("Not Implemented");
        }

        public async Task<bool> GetAll(Owin_UserRequest message, ICRUDRequestHandler<Owin_UserResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<owin_userEntity> oblist = await BFC.Core.FacadeCreatorObjects.Security.owin_userFCC.GetFacadeCreate(_contextAccessor)
                .GetAll(new owin_userEntity(), cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAll(new Owin_UserResponse(oblist.ToList(), true));
                }
                else
                {
                    Owin_UserResponse objResponse = new Owin_UserResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAll(objResponse);
                }
                return true;
            }
            catch (Exception ex)
            {
                Owin_UserResponse objResponse = new Owin_UserResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAll(objResponse);
                return true;
            }
        }

        public async Task<bool> GetAllPaged(Owin_UserRequest message, ICRUDRequestHandler<Owin_UserResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<owin_userEntity> oblist = await BFC.Core.FacadeCreatorObjects.Security.owin_userFCC.GetFacadeCreate(_contextAccessor)
                .GetAllByPages(message.Objowin_user, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAllPaged(new Owin_UserResponse(oblist.ToList(), true));
                }
                else
                {
                    Owin_UserResponse objResponse = new Owin_UserResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAllPaged(objResponse);
                }
                return true;
            }
            catch (Exception ex)
            {
                Owin_UserResponse objResponse = new Owin_UserResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAllPaged(objResponse);
                return true;
            }
        }

        public async Task<bool> GetListView(Owin_UserRequest message, ICRUDRequestHandler<Owin_UserResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<owin_userEntity> oblist = await BFC.Core.FacadeCreatorObjects.Security.owin_userFCC.GetFacadeCreate(_contextAccessor)
                .GAPgListView(message.Objowin_user, cancellationToken);

                List<dataTableButtonModel> btnActionList = new List<dataTableButtonModel>();
                ////btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.New_GET));
                //btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.Edit_GET));
                //btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.Delete_GET));
                //btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.GetSingle_GET));
                ////btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.CUSTOM, _sharedLocalizer["PROCESS"], "StpOrganizationEntity/userprocess"));
                ////btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.CUSTOM, _sharedLocalizer["SEARCH"], "StpOrganizationEntity/usersearch"));
                btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.CUSTOM, _sharedLocalizer["UPDATE_ROLE"], "Owin_User/UpdateRoleOwin_User", "fas fa-edit"));
                btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.CUSTOM, _sharedLocalizer["REVIEW_OWIN_USER"], "Owin_User/ReviewOwin_User", "fas fa-edit"));
                btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.CUSTOM, _sharedLocalizer["LOCK_OWIN_USER"], "Owin_User/LockOwin_User", "fas fa-edit"));
                btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.CUSTOM, _sharedLocalizer["RESET_PASSWORD"], "Owin_User/PasswordResetOwin_User", "fas fa-edit"));
                btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.CUSTOM, _sharedLocalizer["EMAIL_RESET"], "Owin_User/EmailResetOwin_User", "fas fa-edit"));
                btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.GetSingle_GET));
                //btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.CUSTOM, "Details", "OwinUserDetails", "<i class='fas fa-eye'></i>"));
                var data = (from t in oblist
                            select new
                            {
                                t.applicationid,
                                t.userid,
                                t.masteruserid,
                                t.username,
                                t.fullname,
                                t.emailaddress,
                                t.loweredusername,
                                t.mobilenumber,
                                t.userprofilephoto,
                                t.isanonymous,
                                t.ischildenable,
                                t.masprivatekey,
                                t.maspublickey,
                                t.password,
                                t.passwordsalt,
                                t.passwordkey,
                                t.passwordvector,
                                t.mobilepin,
                                t.passwordquestion,
                                t.passwordanswer,
                                t.approved,
                                t.locked,
                                t.isreviewed,
                                t.lastlogindate,
                                t.lastpasschangeddate,
                                t.lastlockoutdate,
                                t.failedpasswordattemptcount,
                                t.comment,
                                t.lastactivitydate,
                                t.isapproved,
                                t.approvedby,
                                t.approvedbyusername,
                                t.approveddate,
                                t.isemailconfirmed,
                                t.emailconfirmationbyuserdate,
                                t.twofactorenable,
                                t.ismobilenumberconfirmed,
                                t.mobilenumberconfirmedbyuserdate,
                                t.securitystamp,
                                t.concurrencystamp,
                                t.rolename,
                                datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objowin_user.ControllerName, t.userid, "userid", _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList, _contextAccessor)
                            }).ToList();

                outputPort.GetListView(new Owin_UserResponse(new AjaxResponse(oblist.Count > 0 ? oblist[0].RETURN_KEY : 0, data), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Owin_UserResponse objResponse = new Owin_UserResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetSingle(Owin_UserRequest message, ICRUDRequestHandler<Owin_UserResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                owin_userEntity objSingle = await BFC.Core.FacadeCreatorObjects.Security.owin_userFCC.GetFacadeCreate(_contextAccessor)
                .GetSingle(message.Objowin_user, cancellationToken);
                if (objSingle != null)
                {
                    outputPort.GetSingle(new Owin_UserResponse(objSingle, true));
                }
                else
                {
                    Owin_UserResponse objResponse = new Owin_UserResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                }
                return true;
            }
            catch (Exception ex)
            {
                Owin_UserResponse objResponse = new Owin_UserResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }

        public async Task<bool> Save(Owin_UserRequest message, ICRUDRequestHandler<Owin_UserResponse> outputPort)
        {
            _logger.LogInformation(JsonConvert.SerializeObject(message));
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.GetFacadeCreate(_contextAccessor)
                    .createuser(message.Objowin_user, cancellationToken);

                outputPort.Save(new Owin_UserResponse(new AjaxResponse("200", _sharedLocalizer["DATA_SAVE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Owin_UserResponse objResponse = new Owin_UserResponse(false, _sharedLocalizer["DATA_SAVE_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Save(objResponse);
                return true;
            }
        }

        public async Task<bool> Update(Owin_UserRequest message, ICRUDRequestHandler<Owin_UserResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.Security.owin_userFCC.GetFacadeCreate(_contextAccessor)
                    .Update(message.Objowin_user, cancellationToken);

                outputPort.Update(new Owin_UserResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Owin_UserResponse objResponse = new Owin_UserResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> Delete(Owin_UserRequest message, ICRUDRequestHandler<Owin_UserResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.Security.owin_userFCC.GetFacadeCreate(_contextAccessor)
                    .Delete(message.Objowin_user, cancellationToken);
                outputPort.Delete(new Owin_UserResponse(new AjaxResponse("200", _sharedLocalizer["DATA_DELETE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                       ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Owin_UserResponse objResponse = new Owin_UserResponse(false, _sharedLocalizer["DATA_DELETE_ERROR"], new Error(
                         "500",
                         ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Delete(objResponse);
                return true;
            }
        }

        public async Task<bool> GetDataForDropDown(Owin_UserRequest message, IDDLRequestHandler<Owin_UserResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {


                IList<gen_dropdownEntity> oblist = await BFC.Core.FacadeCreatorObjects.Security.owin_userFCC.GetFacadeCreate(_contextAccessor).GetDataForDropDown(message.Objowin_user, cancellationToken);
                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetDropDown(new Owin_UserResponse(new AjaxResponse(oblist[0].RETURN_KEY, oblist), true, null));
                    return true;
                }
                else
                {
                    Owin_UserResponse objResponse = new Owin_UserResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Owin_UserResponse objResponse = new Owin_UserResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return true;
            }
        }
    }
}