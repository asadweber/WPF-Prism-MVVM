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
    public sealed partial class Tran_NotificationBatchUseCase : ITran_NotificationBatchUseCase
    {
        public async Task<bool> SaveNotificationBatchWithProfileList(Tran_NotificationBatchRequest message, ICRUDRequestHandler<Tran_NotificationBatchResponse> outputPort)
        {
            _logger.LogInformation(JsonConvert.SerializeObject(message));
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.tran_notificationbatchFCC.GetFacadeCreate(_contextAccessor)
                    .SaveNotificationBatchWithProfileList(message.Objtran_notificationbatch, cancellationToken);

                message.Objtran_notificationbatch.notificationbatchid = i;

                outputPort.Save(new Tran_NotificationBatchResponse(message.Objtran_notificationbatch, true, null));
                return true;
            }
            catch (Exception ex)
            {
                Tran_NotificationBatchResponse objResponse = new Tran_NotificationBatchResponse(false, _sharedLocalizer["DATA_SAVE_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Save(objResponse);
                return true;
            }
        }
    }
}