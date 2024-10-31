﻿using CLL.Localization;
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
    public sealed partial class Gen_InstituteInfoUseCase : IGen_InstituteInfoUseCase
    {
        //public async Task<bool> GetInstituteInfoDataForDropDown(Gen_InstituteInfoRequest message, IDDLRequestHandler<Gen_InstituteInfoResponse> outputPort)
        //{
        //    CancellationToken cancellationToken = new CancellationToken();
        //    try
        //    {
        //        IList<gen_instituteinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_instituteinfoFCC.GetFacadeCreate(_contextAccessor).GetInstituteInfoDataForDropDown(message.Objgen_instituteinfo, cancellationToken);
        //        if (oblist != null && oblist.Count > 0)
        //        {
        //            var select = (from data in oblist select new { Id = data.instituteid, Text = data.institutename}).ToList();

        //            outputPort.GetDropDown(new Gen_InstituteInfoResponse(new AjaxResponse(oblist[0].RETURN_KEY, select), true, null));
        //            return true;
        //        }
        //        else
        //        {
        //            Gen_InstituteInfoResponse objResponse = new Gen_InstituteInfoResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
        //            "404",
        //            _sharedLocalizer["NO_DATA_FOUND"]));
        //            _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
        //            outputPort.GetDropDown(objResponse);
        //            return false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Gen_InstituteInfoResponse objResponse = new Gen_InstituteInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
        //        "500",
        //        ex.Message));
        //        _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
        //        outputPort.GetDropDown(objResponse);
        //        return true;
        //    }
        //}

        public async Task<bool> GetListViewExt(Gen_InstituteInfoRequest message, ICRUDRequestHandler<Gen_InstituteInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<gen_instituteinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_instituteinfoFCC.GetFacadeCreate(_contextAccessor)
                .GAPgListViewExt(message.Objgen_instituteinfo, cancellationToken);
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
                                    t.instituteid,
                                    t.institutename,
                                    t.countryid,
                                    t.countryname,
                                    t.comment,
                                    t.remarks,
                                    datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objgen_instituteinfo.ControllerName, t.instituteid, "instituteid", _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList, _contextAccessor)
                                }).ToList();

                    outputPort.GetListView(new Gen_InstituteInfoResponse(new AjaxResponse(oblist[0].RETURN_KEY, data), true, null));
                    return true;
                }
                else
                {
                    Gen_InstituteInfoResponse objResponse = new Gen_InstituteInfoResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                        "404",
                        _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetListView(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_InstituteInfoResponse objResponse = new Gen_InstituteInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetInstituteInfoDataForDropDown(Gen_InstituteInfoRequest message, IDDLRequestHandler<Gen_InstituteInfoResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_instituteinfoEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_instituteinfoFCC.GetFacadeCreate(_contextAccessor).GetInstituteInfoDataForDropDown(message.Objgen_instituteinfo, cancellationToken);
                if (oblist != null && oblist.Count > 0)
                {
                    var select = (from data in oblist select new { Id = data.instituteid, Text = data.institutename }).ToList();

                    outputPort.GetDropDown(new Gen_InstituteInfoResponse(new AjaxResponse(oblist[0].RETURN_KEY, select), true, null));
                    return true;
                }
                else
                {
                    Gen_InstituteInfoResponse objResponse = new Gen_InstituteInfoResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_InstituteInfoResponse objResponse = new Gen_InstituteInfoResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return true;
            }
        }

    }
}