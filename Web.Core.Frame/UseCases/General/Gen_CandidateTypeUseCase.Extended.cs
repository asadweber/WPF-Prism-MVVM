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
    public sealed partial class Gen_CandidateTypeUseCase : IGen_CandidateTypeUseCase
    {
        public async Task<bool> GetBatchWiseCandidateTypeDropDownByBatchIDCandicateTypeId(Gen_CandidateTypeRequest message, ICRUDRequestHandler<Gen_CandidateTypeResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_candidatetypeEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_candidatetypeFCC.GetFacadeCreate(_contextAccessor)
                .GetBatchWiseCandidateTypeDropDown(message.Objgen_candidatetype, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAll(new Gen_CandidateTypeResponse(oblist.ToList(), true));

                    return true;
                }
                else
                {
                    Gen_CandidateTypeResponse objResponse = new Gen_CandidateTypeResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAll(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_CandidateTypeResponse objResponse = new Gen_CandidateTypeResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAll(objResponse);
                return false;
            }
        }

        public async Task<bool> GetBatchWiseCandidateTypeDropDown(Gen_CandidateTypeRequest message, IDDLRequestHandler<Gen_CandidateTypeResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_candidatetypeEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_candidatetypeFCC.GetFacadeCreate(_contextAccessor)
                .GetBatchWiseCandidateTypeDropDown(message.Objgen_candidatetype, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    var select = (from data in oblist select new { Id = data.candidatetypeid, Text = data.candidatetypename, BatchId = data.BatchId, BatchCandidateTypeMapId=data.BatchCandidateTypeMapId }).ToList();

                    outputPort.GetDropDown(new Gen_CandidateTypeResponse(new AjaxResponse(oblist[0].RETURN_KEY, select), true, null));

                    return true;
                }
                else
                {
                    Gen_CandidateTypeResponse objResponse = new Gen_CandidateTypeResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_CandidateTypeResponse objResponse = new Gen_CandidateTypeResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return false;
            }
        }

        public async Task<bool> GetBatchWiseCandidateTypeListDropDown(Gen_CandidateTypeRequest message, IDDLRequestHandler<Gen_CandidateTypeResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_candidatetypeEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_candidatetypeFCC.GetFacadeCreate(_contextAccessor)
                .GetBatchWiseCandidateTypeListDropDown(message.Objgen_candidatetype, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    var select = (from data in oblist select new { Id = data.candidatetypeid, Text = data.candidatetypename }).ToList();

                    outputPort.GetDropDown(new Gen_CandidateTypeResponse(new AjaxResponse(oblist[0].RETURN_KEY, select), true, null));

                    return true;
                }
                else
                {
                    Gen_CandidateTypeResponse objResponse = new Gen_CandidateTypeResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_CandidateTypeResponse objResponse = new Gen_CandidateTypeResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return false;
            }
        }

        public async Task<bool> GetMultiBatchWiseCandidateTypeListDropDown(Gen_CandidateTypeRequest message, IDDLRequestHandler<Gen_CandidateTypeResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_candidatetypeEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_candidatetypeFCC.GetFacadeCreate(_contextAccessor)
                .GetMultiBatchWiseCandidateTypeListDropDown(message.Objgen_candidatetype, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    var select = (from data in oblist select new { Id = data.candidatetypeid, Text = data.candidatetypename }).ToList();

                    outputPort.GetDropDown(new Gen_CandidateTypeResponse(new AjaxResponse(oblist[0].RETURN_KEY, select), true, null));

                    return true;
                }
                else
                {
                    Gen_CandidateTypeResponse objResponse = new Gen_CandidateTypeResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_CandidateTypeResponse objResponse = new Gen_CandidateTypeResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return false;
            }
        }

        public async Task<bool> GetSingleById(Gen_CandidateTypeRequest message, ICRUDRequestHandler<Gen_CandidateTypeResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                gen_candidatetypeEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.gen_candidatetypeFCC.GetFacadeCreate(_contextAccessor)
                .GetSingleById(message.Objgen_candidatetype, cancellationToken);
                if (objSingle != null)
                {
                    outputPort.GetSingle(new Gen_CandidateTypeResponse(objSingle, true));
                    return true;
                }
                else
                {
                    Gen_CandidateTypeResponse objResponse = new Gen_CandidateTypeResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_CandidateTypeResponse objResponse = new Gen_CandidateTypeResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }

    }
}