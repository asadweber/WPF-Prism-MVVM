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
    public sealed partial class Gen_BatchCandidateReqFileUseCase : IGen_BatchCandidateReqFileUseCase
    {
        public async Task<bool> GetListViewExt(Gen_BatchCandidateReqFileRequest message, ICRUDRequestHandler<Gen_BatchCandidateReqFileResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<gen_batchcandidatereqfileEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_batchcandidatereqfileFCC.GetFacadeCreate(_contextAccessor)
                .GAPgListViewExt(message.Objgen_batchcandidatereqfile, cancellationToken);
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
                                    t.batchcandreqfileid,
                                    t.batchcandidatetypemapid,
                                    t.batchid,
                                    t.batchno,
                                    t.candidatetypeid,
                                    t.candidatetypename,
                                    t.fileconfigid,
                                    t.fileconfigname,
                                    t.description,
                                    t.isrequired,
                                    t.remarks,
                                    datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objgen_batchcandidatereqfile.ControllerName, t.batchcandreqfileid, "batchcandreqfileid", _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList, _contextAccessor)
                                }).ToList();

                    outputPort.GetListView(new Gen_BatchCandidateReqFileResponse(new AjaxResponse(oblist[0].RETURN_KEY, data), true, null));
                    return true;
                }
                else
                {
                    Gen_BatchCandidateReqFileResponse objResponse = new Gen_BatchCandidateReqFileResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                        "404",
                        _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetListView(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_BatchCandidateReqFileResponse objResponse = new Gen_BatchCandidateReqFileResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetSingleExt(Gen_BatchCandidateReqFileRequest message, ICRUDRequestHandler<Gen_BatchCandidateReqFileResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                gen_batchcandidatereqfileEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.gen_batchcandidatereqfileFCC.GetFacadeCreate(_contextAccessor)
                .GetSingleExt(message.Objgen_batchcandidatereqfile, cancellationToken);
                if (objSingle != null)
                {
                    outputPort.GetSingle(new Gen_BatchCandidateReqFileResponse(objSingle, true));
                    return true;
                }
                else
                {
                    Gen_BatchCandidateReqFileResponse objResponse = new Gen_BatchCandidateReqFileResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_BatchCandidateReqFileResponse objResponse = new Gen_BatchCandidateReqFileResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }

    }
}