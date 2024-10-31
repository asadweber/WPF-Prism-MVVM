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
using Web.Core.Frame.Dto.UseCaseRequests.Registration;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.Interfaces.UseCases.Registration;

namespace Web.Core.Frame.UseCases
{
    public sealed partial class Reg_StudentFileStorageUseCase : IReg_StudentFileStorageUseCase
    {
        public async Task<bool> DeletebyBasicInfoIDFileConfigID(Reg_StudentFileStorageRequest message, ICRUDRequestHandler<Reg_StudentFileStorageResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.reg_studentfilestorageFCC.GetFacadeCreate(_contextAccessor)
                    .DeletebyBasicInfoIDFileConfigID(message.Objreg_studentfilestorage, cancellationToken);
                outputPort.Delete(new Reg_StudentFileStorageResponse(new AjaxResponse("200", _sharedLocalizer["DATA_DELETE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                       ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Reg_StudentFileStorageResponse objResponse = new Reg_StudentFileStorageResponse(false, _sharedLocalizer["DATA_DELETE_ERROR"], new Error(
                         "500",
                         ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Delete(objResponse);
                return true;
            }
        }

        public async Task<bool> GetAllByBasicInfoID(Reg_StudentFileStorageRequest message, ICRUDRequestHandler<Reg_StudentFileStorageResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<reg_studentfilestorageEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.reg_studentfilestorageFCC.GetFacadeCreate(_contextAccessor)
                .GetAllByBasicInfoID(message.Objreg_studentfilestorage, cancellationToken);

                outputPort.GetAll(new Reg_StudentFileStorageResponse(oblist.Count > 0 ? oblist.ToList() : null, true));
                return true;
            }
            catch (Exception ex)
            {
                Reg_StudentFileStorageResponse objResponse = new Reg_StudentFileStorageResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAll(objResponse);
                return true;
            }
        }

    }
}