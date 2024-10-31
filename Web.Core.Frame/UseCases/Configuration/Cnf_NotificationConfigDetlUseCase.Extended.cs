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
    public sealed partial class Cnf_NotificationConfigDetlUseCase : ICnf_NotificationConfigDetlUseCase
    {
        public async Task<bool> GetListViewExt(Cnf_NotificationConfigDetlRequest message, ICRUDRequestHandler<Cnf_NotificationConfigDetlResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<cnf_notificationconfigdetlEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.cnf_notificationconfigdetlFCC.GetFacadeCreate(_contextAccessor)
                .GAPgListViewExt(message.Objcnf_notificationconfigdetl, cancellationToken);
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
                                    t.notificationconfigdetlid,
                                    t.notificationconfigid,
                                    t.phaseid,
                                    t.phasename,
                                    t.statusid,
                                    t.statusname,
                                    t.notificationtypeid,
                                    t.notificationtemplateid,
                                    t.templateshortname,
                                    t.remarks,
                                    datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objcnf_notificationconfigdetl.ControllerName, t.notificationconfigdetlid, "notificationconfigdetlid", _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList, _contextAccessor)
                                }).ToList();

                    outputPort.GetListView(new Cnf_NotificationConfigDetlResponse(new AjaxResponse(oblist[0].RETURN_KEY, data), true, null));
                    return true;
                }
                else
                {
                    Cnf_NotificationConfigDetlResponse objResponse = new Cnf_NotificationConfigDetlResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                        "404",
                        _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetListView(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Cnf_NotificationConfigDetlResponse objResponse = new Cnf_NotificationConfigDetlResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetSingleExt(Cnf_NotificationConfigDetlRequest message, ICRUDRequestHandler<Cnf_NotificationConfigDetlResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                cnf_notificationconfigdetlEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.cnf_notificationconfigdetlFCC.GetFacadeCreate(_contextAccessor)
                .GetSingleExt(message.Objcnf_notificationconfigdetl, cancellationToken);
                if (objSingle != null)
                {
                    outputPort.GetSingle(new Cnf_NotificationConfigDetlResponse(objSingle, true));
                    return true;
                }
                else
                {
                    Cnf_NotificationConfigDetlResponse objResponse = new Cnf_NotificationConfigDetlResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Cnf_NotificationConfigDetlResponse objResponse = new Cnf_NotificationConfigDetlResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }


    }
}