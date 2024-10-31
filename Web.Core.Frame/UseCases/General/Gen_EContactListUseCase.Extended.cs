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
    public sealed partial class Gen_EContactListUseCase : IGen_EContactListUseCase
    {
        public async Task<bool> GetFamilyRelationDataForDropDown(Gen_EContactListRequest message, IDDLRequestHandler<Gen_EContactListResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_econtactlistEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_econtactlistFCC.GetFacadeCreate(_contextAccessor).GetAll(message.Objgen_econtactlist, cancellationToken);
                if (oblist != null && oblist.Count > 0)
                {
                    var select = (from data in oblist select new { Id = data.emrgconrelid, Text = data.emrgrelationshipname }).ToList();
                    outputPort.GetDropDown(new Gen_EContactListResponse(new AjaxResponse(oblist[0].RETURN_KEY, select), true, null));
                    return true;
                }
                else
                {
                    Gen_EContactListResponse objResponse = new Gen_EContactListResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_EContactListResponse objResponse = new Gen_EContactListResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return true;
            }
        }
        public async Task<bool> GetFamilyRelationDataForDropDown(Gen_EContactListRequest message, ICRUDRequestHandler<Gen_EContactListResponse> outputPort)
        {
            throw new NotImplementedException();
        }

    }
}
