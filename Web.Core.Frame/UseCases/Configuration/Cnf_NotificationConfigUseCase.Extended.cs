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
using Web.Core.Frame.Interfaces.UseCases.Configuration;
using Web.Core.Frame.Dto.UseCaseResponses.Configuration;
using Web.Core.Frame.Dto.UseCaseRequests.Configuration;

namespace Web.Core.Frame.UseCases.Configuration
{
    public sealed partial class Cnf_NotificationConfigUseCase : ICnf_NotificationConfigUseCase
    {
        public async Task<bool> GetListViewExt(Cnf_NotificationConfigRequest message, ICRUDRequestHandler<Cnf_NotificationConfigResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<cnf_notificationconfigEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.cnf_notificationconfigFCC.GetFacadeCreate(_contextAccessor)
                .GAPgListViewExt(message.Objcnf_notificationconfig, cancellationToken);
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
                                    t.notificationconfigid,
                                    t.phaseid,
                                    t.phasename,
                                    t.statusid,
                                    t.statusname,
                                    t.remarks,
                                    datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objcnf_notificationconfig.ControllerName, t.notificationconfigid, "notificationconfigid", _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList, _contextAccessor)
                                }).ToList();

                    outputPort.GetListView(new Cnf_NotificationConfigResponse(new AjaxResponse(oblist[0].RETURN_KEY, data), true, null));
                    return true;
                }
                else
                {
                    Cnf_NotificationConfigResponse objResponse = new Cnf_NotificationConfigResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                        "404",
                        _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetListView(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Cnf_NotificationConfigResponse objResponse = new Cnf_NotificationConfigResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetDataForDropDownExt(Cnf_NotificationConfigRequest message, IDDLRequestHandler<Cnf_NotificationConfigResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_dropdownEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.cnf_notificationconfigFCC.GetFacadeCreate(_contextAccessor).GetDataForDropDownExt(message.Objcnf_notificationconfig, cancellationToken);
                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetDropDown(new Cnf_NotificationConfigResponse(new AjaxResponse(oblist[0].RETURN_KEY, oblist), true, null));
                    return true;
                }
                else
                {
                    Cnf_NotificationConfigResponse objResponse = new Cnf_NotificationConfigResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Cnf_NotificationConfigResponse objResponse = new Cnf_NotificationConfigResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return true;
            }
        }


    }
}