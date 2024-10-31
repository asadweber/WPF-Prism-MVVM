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
    public sealed partial class Gen_BatchCandidateTypeMapUseCase : IGen_BatchCandidateTypeMapUseCase
    {
        public async Task<bool> GetListViewExt(Gen_BatchCandidateTypeMapRequest message, ICRUDRequestHandler<Gen_BatchCandidateTypeMapResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<gen_batchcandidatetypemapEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_batchcandidatetypemapFCC.GetFacadeCreate(_contextAccessor)
                .GAPgListViewExt(message.Objgen_batchcandidatetypemap, cancellationToken);
                if (oblist != null && oblist.Count > 0)
                {
                    List<dataTableButtonModel> btnActionList = new List<dataTableButtonModel>();
                    //btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.New_GET));
                    btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.Edit_GET));
                    btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.Delete_GET));
                    btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.GetSingle_GET));
                    //btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.CUSTOM, _sharedLocalizer["PROCESS"], "StpOrganizationEntity/userprocess"));
                    //btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.CUSTOM, _sharedLocalizer["SEARCH"], "StpOrganizationEntity/usersearch"));

                    var data = (from t in oblist
                                select new
                                {
                                    //t.batchcandidatetypemapid,
                                    t.batchid,
                                    t.batchno,
                                    //t.candidatetypeid,
                                    //t.candidatetypename,
                                    //t.comment,
                                    //t.remarks,
                                    //t.BaseSecurityParam.createdbyusername,
                                    //t.BaseSecurityParam.createddate,
                                    //datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objgen_batchcandidatetypemap.ControllerName, t.batchcandidatetypemapid, "batchcandidatetypemapid", _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList, _contextAccessor)
                                    datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objgen_batchcandidatetypemap.ControllerName, t.batchid, "batchid", _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList, _contextAccessor)
                                }).ToList();

                    outputPort.GetListView(new Gen_BatchCandidateTypeMapResponse(new AjaxResponse(oblist[0].RETURN_KEY, data), true, null));
                    return true;
                }
                else
                {
                    Gen_BatchCandidateTypeMapResponse objResponse = new Gen_BatchCandidateTypeMapResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                        "404",
                        _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetListView(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_BatchCandidateTypeMapResponse objResponse = new Gen_BatchCandidateTypeMapResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }


        /// <summary>
		/// GetDataForDropDown Gen_BatchCandidateTypeMap
		/// </summary>
		/// <param name="response"></param>
		public async Task<bool> GetDataForDropDownExt(Gen_BatchCandidateTypeMapRequest message, IDDLRequestHandler<Gen_BatchCandidateTypeMapResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_dropdownEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_batchcandidatetypemapFCC.GetFacadeCreate(_contextAccessor).GetDataForDropDownExt(message.Objgen_batchcandidatetypemap, cancellationToken);
                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetDropDown(new Gen_BatchCandidateTypeMapResponse(new AjaxResponse(oblist[0].RETURN_KEY, oblist), true, null));
                    return true;
                }
                else
                {
                    Gen_BatchCandidateTypeMapResponse objResponse = new Gen_BatchCandidateTypeMapResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_BatchCandidateTypeMapResponse objResponse = new Gen_BatchCandidateTypeMapResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return true;
            }
        }

        public async Task<bool> GetSingleByBatchCandidateTypeID(Gen_BatchCandidateTypeMapRequest message, ICRUDRequestHandler<Gen_BatchCandidateTypeMapResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                gen_batchcandidatetypemapEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.gen_batchcandidatetypemapFCC.GetFacadeCreate(_contextAccessor)
                .GetSingleByBatchCandidateTypeID(message.Objgen_batchcandidatetypemap, cancellationToken);
                if (objSingle != null)
                {
                    outputPort.GetSingle(new Gen_BatchCandidateTypeMapResponse(objSingle, true));
                    return true;
                }
                else
                {
                    Gen_BatchCandidateTypeMapResponse objResponse = new Gen_BatchCandidateTypeMapResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_BatchCandidateTypeMapResponse objResponse = new Gen_BatchCandidateTypeMapResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }

    }
}