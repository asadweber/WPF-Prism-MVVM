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
using Web.Core.Frame.Interfaces.UseCases.Configuration;
using Web.Core.Frame.Dto.UseCaseResponses.Configuration;
using Web.Core.Frame.Dto.UseCaseRequests.Configuration;

namespace Web.Core.Frame.UseCases.Configuration
{
    public sealed partial class Cnf_FileRequiredUseCase : ICnf_FileRequiredUseCase
    {

        public async Task<bool> GetListViewExt(Cnf_FileRequiredRequest message, ICRUDRequestHandler<Cnf_FileRequiredResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<cnf_filerequiredEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.cnf_filerequiredFCC.GetFacadeCreate(_contextAccessor)
                .GAPgListViewExt(message.Objcnf_filerequired, cancellationToken);
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
                                t.batchid,
                                t.batchno,
                                datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objcnf_filerequired.ControllerName, t.batchid, "batchid", _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList, _contextAccessor)
                            }).ToList();

                outputPort.GetListView(new Cnf_FileRequiredResponse(new AjaxResponse((oblist != null && oblist.Count > 0 ? oblist[0].RETURN_KEY : 0), data), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Cnf_FileRequiredResponse objResponse = new Cnf_FileRequiredResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> CnfFileRequiredSaveList(Cnf_FileRequiredRequest message, ICRUDRequestHandler<Cnf_FileRequiredResponse> outputPort)
        {
            _logger.LogInformation(JsonConvert.SerializeObject(message));
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                //Delete state for existing cnf_filerequired
                IList<cnf_filerequiredEntity> existingFileRequiredList = await BFC.Core.FacadeCreatorObjects.General.cnf_filerequiredFCC.GetFacadeCreate(_contextAccessor)
                    .GetAll(new cnf_filerequiredEntity { batchid = message.Objcnf_filerequired.batchid }, cancellationToken);
                if (existingFileRequiredList != null && existingFileRequiredList.Count > 0)
                {
                    foreach (var item in existingFileRequiredList)
                    {
                        item.CurrentState = BDO.Core.Base.BaseEntity.EntityState.Deleted;
                        message.Objcnf_filerequired.CnfFileRequiredList.Add(item);
                    }
                }

                i = await BFC.Core.FacadeCreatorObjects.General.cnf_filerequiredFCC.GetFacadeCreate(_contextAccessor)
                    .SaveList(message.Objcnf_filerequired.CnfFileRequiredList, cancellationToken);

                outputPort.Save(new Cnf_FileRequiredResponse(new AjaxResponse("200", _sharedLocalizer["DATA_SAVE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Cnf_FileRequiredResponse objResponse = new Cnf_FileRequiredResponse(false, _sharedLocalizer["DATA_SAVE_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Save(objResponse);
                return true;
            }
        }

        public async Task<bool> CnfFileRequiredDeleteList(Cnf_FileRequiredRequest message, ICRUDRequestHandler<Cnf_FileRequiredResponse> outputPort)
        {
            _logger.LogInformation(JsonConvert.SerializeObject(message));
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                //Delete state for existing cnf_filerequired
                message.Objcnf_filerequired.CnfFileRequiredList = new List<cnf_filerequiredEntity>();
                IList<cnf_filerequiredEntity> existingFileRequiredList = await BFC.Core.FacadeCreatorObjects.General.cnf_filerequiredFCC.GetFacadeCreate(_contextAccessor)
                    .GetAll(new cnf_filerequiredEntity { batchid = message.Objcnf_filerequired.batchid }, cancellationToken);
                if (existingFileRequiredList != null && existingFileRequiredList.Count > 0)
                {
                    foreach (var item in existingFileRequiredList)
                    {
                        item.CurrentState = BDO.Core.Base.BaseEntity.EntityState.Deleted;
                        message.Objcnf_filerequired.CnfFileRequiredList.Add(item);
                    }
                }

                i = await BFC.Core.FacadeCreatorObjects.General.cnf_filerequiredFCC.GetFacadeCreate(_contextAccessor)
                    .SaveList(message.Objcnf_filerequired.CnfFileRequiredList, cancellationToken);

                outputPort.Delete(new Cnf_FileRequiredResponse(new AjaxResponse("200", _sharedLocalizer["DATA_DELETE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Cnf_FileRequiredResponse objResponse = new Cnf_FileRequiredResponse(false, _sharedLocalizer["DATA_DELETE_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Delete(objResponse);
                return true;
            }
        }

    }
}