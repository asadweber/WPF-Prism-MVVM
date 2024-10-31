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

namespace Web.Core.Frame.UseCases
{
    public sealed partial class Gen_CivilWorkPlacesUseCase : IGen_CivilWorkPlacesUseCase
    {
        public async Task<bool> GetSingleExt(Gen_CivilWorkPlacesRequest message, ICRUDRequestHandler<Gen_CivilWorkPlacesResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                gen_civilworkplacesEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.gen_civilworkplacesFCC.GetFacadeCreate(_contextAccessor)
                .GetSingleExt(message.Objgen_civilworkplaces, cancellationToken);
                if (objSingle != null)
                {
                    outputPort.GetSingle(new Gen_CivilWorkPlacesResponse(objSingle, true));
                    return true;
                }
                else
                {
                    Gen_CivilWorkPlacesResponse objResponse = new Gen_CivilWorkPlacesResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_CivilWorkPlacesResponse objResponse = new Gen_CivilWorkPlacesResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }
    }
}