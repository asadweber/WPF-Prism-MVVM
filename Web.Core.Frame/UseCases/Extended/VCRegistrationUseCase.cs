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
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.Dto.UseCaseRequests.Registration;
using System.Globalization;
using System.Data.Common;
using AppConfig.EncryptionHandler;
using Microsoft.AspNet.SignalR.Client.Http;
using BDO.Core.Base;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;
using CLL.LLClasses.Models;
using Microsoft.AspNetCore.Identity;
using Web.Core.Frame.CustomIdentityManagers;
using BDO.DataAccessObjects.Enums;
using NLog.LayoutRenderers.Wrappers;
using BDO.DataAccessObjects.VCRegistration;
using BDO.Base;
using RestSharp;
using BDO.DataAccessObjects.ExtendedEntities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.IO;
using CLL.LLClasses;
using DocumentFormat.OpenXml.Vml;
using IDAC.Core.IDataAccessObjects.Security.ExtendedPartial;
using DocumentFormat.OpenXml.Bibliography;

namespace Web.Core.Frame.UseCases.Registration
{
    public sealed partial class VCRegistrationUseCase 
    {
        public async Task<bool> GetRegistrationDataInfoStatusCheck(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            bool state = false;
            try
            {
                var viewmodel = await BFC.Core.FacadeCreatorObjects.General.reg_basicinfoFCC.GetFacadeCreate(this._contextAccessor).
                    GetRegistrationDataInfoStatusCheck(new reg_basicinfoEntity() { basicinfoid = message.BasicId}, cancellationToken);

                var response = new VCRegistrationResponse(viewmodel, true);
                outputPort.GetProfileDataCheckStatus(response);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(JsonConvert.SerializeObject(ex.Message));
                return false;
            }
        }
    }
}