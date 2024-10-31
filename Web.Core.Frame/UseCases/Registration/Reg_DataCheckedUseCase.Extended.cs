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
using Web.Core.Frame.Interfaces.UseCases.Registration;
using Web.Core.Frame.Dto.UseCaseRequests.Registration;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;

namespace Web.Core.Frame.UseCases.Registration
{
    public sealed partial class Reg_DataCheckedUseCase : IReg_DataCheckedUseCase
    {
        public async Task<bool> GetRegDataCheckedByBasicinfoRegistrationID(Reg_DataCheckedRequest message, ICRUDRequestHandler<Reg_DataCheckedResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                reg_datacheckedEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.reg_datacheckedFCC.GetFacadeCreate(_contextAccessor)
                .GetRegDataCheckedByBasicinfoRegistrationID(message.Objreg_datachecked, cancellationToken);
                if (objSingle != null)
                {
                    outputPort.GetSingle(new Reg_DataCheckedResponse(objSingle, true));
                    return true;
                }
                else
                {
                    Reg_DataCheckedResponse objResponse = new Reg_DataCheckedResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_DataCheckedResponse objResponse = new Reg_DataCheckedResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }

    }
}