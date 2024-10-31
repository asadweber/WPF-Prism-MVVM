using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.Interfaces.UseCases;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.UseCases
{
    /// <summary>
    /// Batch: 
    /// </summary>
    /// <seealso cref="Web.Core.Frame.Interfaces.UseCases.IGen_BatchUseCase" />
    public sealed partial class Gen_BatchUseCase : IGen_BatchUseCase
    {
        /// <summary>
        /// Gets the active batch drop down based on batch start, end date and active.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="outputPort">The output port.</param>
        /// <returns></returns>
        public async Task<bool> GetActiveBatchDropDown(Gen_BatchRequest message, IDDLRequestHandler<Gen_BatchResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_batchEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_batchFCC.GetFacadeCreate(_contextAccessor)
                .GetActiveBatch(message.Objgen_batch, cancellationToken);


                if (oblist != null && oblist.Count > 0)
                {
                    var select = (from data in oblist select new { Id = data.batchid,Text=data.BatchDetails, MilitaryType = data.militarytype, Gender = data.gender }).ToList();

                    outputPort.GetDropDown(new Gen_BatchResponse(new AjaxResponse(oblist[0].RETURN_KEY, select), true, null));

                    return true;
                }
                else
                {
                    Gen_BatchResponse objResponse = new Gen_BatchResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_BatchResponse objResponse = new Gen_BatchResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return false;
            }
        }

        /// <summary>
        /// Gets the active batch drop down based on active.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="outputPort">The output port.</param>
        /// <returns></returns>
        public async Task<bool> GetActiveBatchDropDownForReview(Gen_BatchRequest message, IDDLRequestHandler<Gen_BatchResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_batchEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_batchFCC.GetFacadeCreate(_contextAccessor)
                .GetActiveBatchDropDownForReview(message.Objgen_batch, cancellationToken);


                if (oblist != null && oblist.Count > 0)
                {
                    var select = (from data in oblist select new { Id = data.batchid, Text = data.BatchDetails, MilitaryType = data.militarytype, Gender = data.gender }).ToList();

                    outputPort.GetDropDown(new Gen_BatchResponse(new AjaxResponse(oblist[0].RETURN_KEY, select), true, null));

                    return true;
                }
                else
                {
                    Gen_BatchResponse objResponse = new Gen_BatchResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_BatchResponse objResponse = new Gen_BatchResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return false;
            }
        }

        /// <summary>
        /// Get all batch drop down.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="outputPort">The output port.</param>
        /// <returns></returns>
        public async Task<bool> GetAllBatchDropDown(Gen_BatchRequest message, IDDLRequestHandler<Gen_BatchResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_batchEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_batchFCC.GetFacadeCreate(_contextAccessor)
                .GetAllBatch(message.Objgen_batch, cancellationToken);


                if (oblist != null && oblist.Count > 0)
                {
                    var select = (from data in oblist select new { Id = data.batchid, Text = data.BatchDetails, MilitaryType = data.militarytype, Gender = data.gender }).ToList();

                    outputPort.GetDropDown(new Gen_BatchResponse(new AjaxResponse(oblist[0].RETURN_KEY, select), true, null));

                    return true;
                }
                else
                {
                    Gen_BatchResponse objResponse = new Gen_BatchResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_BatchResponse objResponse = new Gen_BatchResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return false;
            }
        }

        public async Task<bool> GetBatchDropDownById(Gen_BatchRequest message, ICRUDRequestHandler<Gen_BatchResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                gen_batchEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.gen_batchFCC.GetFacadeCreate(_contextAccessor)
                .GetBatchById(message.Objgen_batch, cancellationToken);
                if (objSingle != null)
                {
                    outputPort.GetSingle(new Gen_BatchResponse(objSingle, true));
                    return true;
                }
                else
                {
                    Gen_BatchResponse objResponse = new Gen_BatchResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_BatchResponse objResponse = new Gen_BatchResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }

        /// <summary>
		/// GetMilitaryTypeWiseBatchForDropDown Gen_Batch
		/// </summary>
		/// <param name="response"></param>
		public async Task<bool> GetMilitaryTypeWiseBatchForDropDown(Gen_BatchRequest message, IDDLRequestHandler<Gen_BatchResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_dropdownEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_batchFCC.GetFacadeCreate(_contextAccessor).GetMilitaryTypeWiseBatchForDropDown(message.Objgen_batch, cancellationToken);
                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetDropDown(new Gen_BatchResponse(new AjaxResponse(oblist[0].RETURN_KEY, oblist), true, null));
                    return true;
                }
                else
                {
                    Gen_BatchResponse objResponse = new Gen_BatchResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_BatchResponse objResponse = new Gen_BatchResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return true;
            }
        }

    }
}