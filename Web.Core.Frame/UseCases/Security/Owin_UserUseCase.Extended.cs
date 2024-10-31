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

namespace Web.Core.Frame.UseCases
{
    public sealed partial class Owin_UserUseCase : IOwin_UserUseCase
    {
        public async Task<bool> GetSinglebyUsername(Owin_UserRequest message, ICRUDRequestHandler<Owin_UserResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                owin_userEntity objSingle = await BFC.Core.FacadeCreatorObjects.Security.owin_userFCC.GetFacadeCreate(_contextAccessor)
                .GetSinglebyUsername(message.Objowin_user, cancellationToken);
                outputPort.GetSingle(new Owin_UserResponse(objSingle != null ? objSingle : null, true));
                //else
                //{
                //    Owin_UserResponse objResponse = new Owin_UserResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                //     "404",
                //     _sharedLocalizer["NO_DATA_FOUND"]));
                //    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                //    outputPort.GetSingle(objResponse);
                //}
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

    }
}