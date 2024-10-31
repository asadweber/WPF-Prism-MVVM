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
    public sealed partial class Cnf_NotificationTempletUseCase : ICnf_NotificationTempletUseCase
    {
        /// <summary>
        /// Get Notification Template With Msg DropDown Cnf_NotificationTemplet
        /// </summary>
        /// <param name="response"></param>
        public async Task<bool> GetNotificationTemplateWithMsgDropDown(Cnf_NotificationTempletRequest message, IDDLRequestHandler<Cnf_NotificationTempletResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<cnf_notificationtempletEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.cnf_notificationtempletFCC.GetFacadeCreate(_contextAccessor).GetNotificationTemplateWithMsgDropDown(message.Objcnf_notificationtemplet, cancellationToken);
                if (oblist != null && oblist.Count > 0)
                {
                    var select = (from data in oblist select new { Id = data.notificationtemplateid, Text = data.templateshortname, TemplateMsg = data.templatemsg }).ToList();
                    outputPort.GetDropDown(new Cnf_NotificationTempletResponse(new AjaxResponse(oblist[0].RETURN_KEY, select), true, null));
                    return true;
                }
                else
                {
                    Cnf_NotificationTempletResponse objResponse = new Cnf_NotificationTempletResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Cnf_NotificationTempletResponse objResponse = new Cnf_NotificationTempletResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return true;
            }
        }

    }
}