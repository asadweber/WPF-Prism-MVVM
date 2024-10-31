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
    public sealed partial class Gen_ProfessionUseCase : IGen_ProfessionUseCase
    {

        public async Task<bool> GetProfessionDropDown(Gen_ProfessionRequest message, IDDLRequestHandler<Gen_ProfessionResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_professionEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_professionFCC.GetFacadeCreate(_contextAccessor)
                    .GetProfessionDropDown(message.Objgen_profession, cancellationToken);
                if (oblist != null && oblist.Count > 0)
                {
                    var select = (from data in oblist select new { Id = data.professionid, Text = data.professionname, BatchCandProfessionMapID=data.BatchCandProfessionMapID }).ToList();

                    outputPort.GetDropDown(new Gen_ProfessionResponse(new AjaxResponse(oblist[0].RETURN_KEY, select), true, null));
                    return true;
                }
                else
                {
                    Gen_ProfessionResponse objResponse = new Gen_ProfessionResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_ProfessionResponse objResponse = new Gen_ProfessionResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return true;
            }
        }


        //For Web Admin
        public async Task<bool> GetBatchCandidateTypeWiseProfessionDropDown(Gen_ProfessionRequest message, IDDLRequestHandler<Gen_ProfessionResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_professionEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_professionFCC.GetFacadeCreate(_contextAccessor)
                    .GetBatchCandidateTypeWiseProfessionDropDown(message.Objgen_profession, cancellationToken);
                if (oblist != null && oblist.Count > 0)
                {
                    var select = (from data in oblist select new { Id = data.professionid, Text = data.professionname }).ToList();

                    outputPort.GetDropDown(new Gen_ProfessionResponse(new AjaxResponse(oblist[0].RETURN_KEY, select), true, null));
                    return true;
                }
                else
                {
                    Gen_ProfessionResponse objResponse = new Gen_ProfessionResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_ProfessionResponse objResponse = new Gen_ProfessionResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return true;
            }
        }

        //For Web Admin
        public async Task<bool> GetMultiBatchCandidateTypeWiseProfessionDropDown(Gen_ProfessionRequest message, IDDLRequestHandler<Gen_ProfessionResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_professionEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_professionFCC.GetFacadeCreate(_contextAccessor)
                    .GetMultiBatchCandidateTypeWiseProfessionDropDown(message.Objgen_profession, cancellationToken);
                if (oblist != null && oblist.Count > 0)
                {
                    var select = (from data in oblist select new { Id = data.professionid, Text = data.professionname }).ToList();

                    outputPort.GetDropDown(new Gen_ProfessionResponse(new AjaxResponse(oblist[0].RETURN_KEY, select), true, null));
                    return true;
                }
                else
                {
                    Gen_ProfessionResponse objResponse = new Gen_ProfessionResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_ProfessionResponse objResponse = new Gen_ProfessionResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return true;
            }
        }

        public async Task<bool> GetListViewExt(Gen_ProfessionRequest message, ICRUDRequestHandler<Gen_ProfessionResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<gen_professionEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_professionFCC.GetFacadeCreate(_contextAccessor)
                .GAPgListViewExt(message.Objgen_profession, cancellationToken);
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
                                    t.professionid,
                                    t.professionname,
                                    t.professiongroupid,
                                    t.professiongroupname,
                                    t.comment,
                                    t.remarks,
                                    datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objgen_profession.ControllerName, t.professionid, "professionid", _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList, _contextAccessor)
                                }).ToList();

                    outputPort.GetListView(new Gen_ProfessionResponse(new AjaxResponse(oblist[0].RETURN_KEY, data), true, null));
                    return true;
                }
                else
                {
                    Gen_ProfessionResponse objResponse = new Gen_ProfessionResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                        "404",
                        _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetListView(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_ProfessionResponse objResponse = new Gen_ProfessionResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetAllProfessionbyProfessionGroupID(Gen_ProfessionRequest message, ICRUDRequestHandler<Gen_ProfessionResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_professionEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_professionFCC.GetFacadeCreate(_contextAccessor)
                .GetAllProfessionbyProfessionGroupID(message.Objgen_profession, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAll(new Gen_ProfessionResponse(oblist.ToList(), true));
                    return true;
                }
                else
                {
                    Gen_ProfessionResponse objResponse = new Gen_ProfessionResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAll(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_ProfessionResponse objResponse = new Gen_ProfessionResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAll(objResponse);
                return true;
            }
        }

    }
}