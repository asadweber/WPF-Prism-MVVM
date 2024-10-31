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
    public sealed partial class Gen_CountryCityUseCase : IGen_CountryCityUseCase
    {

        public async Task<bool> GetGovernateDropDown(Gen_CountryCityRequest message, IDDLRequestHandler<Gen_CountryCityResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_countrycityEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_countrycityFCC.GetFacadeCreate(_contextAccessor)
                .GetGovernateDropDown(message.Objgen_countrycity, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    var select = (from data in oblist
                                  select new { Id = data.cityid, Text = data.cityname }).ToList();

                    outputPort.GetDropDown(new Gen_CountryCityResponse(new AjaxResponse(oblist[0].RETURN_KEY, select), true, null));

                    return true;
                }
                else
                {
                    Gen_CountryCityResponse objResponse = new Gen_CountryCityResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_CountryCityResponse objResponse = new Gen_CountryCityResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return false;
            }
        }
    }
}