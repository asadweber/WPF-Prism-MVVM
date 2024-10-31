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
    public sealed partial class Reg_BasicInfoUseCase : IReg_BasicInfoUseCase
    {
        public async Task<bool> GetAllRegBasicInfoByMultipleBasicID(Reg_BasicInfoRequest message, ICRUDRequestHandler<Reg_BasicInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<reg_basicinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_basicinfoFCC.GetFacadeCreate(_contextAccessor)
                .GetAllRegBasicInfoByMultipleBasicID(message.Objreg_basicinfo, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAll(new Reg_BasicInfoResponse(oblist.ToList(), true));

                    return true;
                }
                else
                {
                    Reg_BasicInfoResponse objResponse = new Reg_BasicInfoResponse(new List<reg_basicinfoEntity>(), true);
                    outputPort.GetAll(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Reg_BasicInfoResponse objResponse = new Reg_BasicInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAll(objResponse);
                return true;
            }
        }

        public async Task<bool> DeleteApplicantbyBasicInfoID(Reg_BasicInfoRequest message, ICRUDRequestHandler<Reg_BasicInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.reg_basicinfoFCC.GetFacadeCreate(_contextAccessor)
                    .DeleteApplicantbyBasicInfoID(message.Objreg_basicinfo, cancellationToken);
                outputPort.Delete(new Reg_BasicInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_DELETE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                       ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_BasicInfoResponse objResponse = new Reg_BasicInfoResponse(false, _sharedLocalizer["DATA_DELETE_ERROR"], new Error(
                         "500",
                         ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Delete(objResponse);
                return true;
            }
        }

        public async Task<bool> UpdateApplicantContactInfo(Reg_BasicInfoRequest message, ICRUDRequestHandler<Reg_BasicInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.reg_basicinfoFCC.GetFacadeCreate(_contextAccessor)
                    .UpdateApplicantContactInfo(message.Objreg_basicinfo, cancellationToken);

                outputPort.Update(new Reg_BasicInfoResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_BasicInfoResponse objResponse = new Reg_BasicInfoResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

    }
}