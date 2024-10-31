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
    public sealed partial class Tran_NotificationBatchDetUseCase 
    {
        public async Task<bool> GetAllExt(Tran_NotificationBatchDetRequest message, ICRUDRequestHandler<Tran_NotificationBatchDetResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<tran_notificationbatchdetEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.tran_notificationbatchdetFCC.GetFacadeCreate(_contextAccessor)
                .GetAllExt(message.Objtran_notificationbatchdet, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAll(new Tran_NotificationBatchDetResponse(oblist.ToList(), true));
                    return true;
                }
                else
                {
                    outputPort.GetAll(new Tran_NotificationBatchDetResponse(new List<BDO.Core.DataAccessObjects.Models.tran_notificationbatchdetEntity>(), true));
                    return false;
                    //Tran_NotificationBatchDetResponse objResponse = new Tran_NotificationBatchDetResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    // "404",
                    // _sharedLocalizer["NO_DATA_FOUND"]));
                    //_logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    //outputPort.GetAll(objResponse);
                    //return false;
                }
            }
            catch (Exception ex)
            {
                Tran_NotificationBatchDetResponse objResponse = new Tran_NotificationBatchDetResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAll(objResponse);
                return true;
            }
        }

        public async Task<bool> GetAllByBasicInfoRegistrationID(Tran_NotificationBatchDetRequest message, ICRUDRequestHandler<Tran_NotificationBatchDetResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<tran_notificationbatchdetEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.tran_notificationbatchdetFCC.GetFacadeCreate(_contextAccessor)
                .GetAllByBasicInfoRegistrationID(message.Objtran_notificationbatchdet, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAll(new Tran_NotificationBatchDetResponse(oblist.ToList(), true));
                    return true;
                }
                else
                {
                    Tran_NotificationBatchDetResponse objResponse = new Tran_NotificationBatchDetResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAll(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Tran_NotificationBatchDetResponse objResponse = new Tran_NotificationBatchDetResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAll(objResponse);
                return true;
            }
        }

    }
}