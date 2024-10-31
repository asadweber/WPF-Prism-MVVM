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
    public sealed partial class Gen_CertificateUseCase : IGen_CertificateUseCase
    {
        public async Task<bool> GetListViewExt(Gen_CertificateRequest message, ICRUDRequestHandler<Gen_CertificateResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<gen_certificateEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_certificateFCC.GetFacadeCreate(_contextAccessor)
                .GAPgListViewExt(message.Objgen_certificate, cancellationToken);
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
                                    t.certificateid,
                                    t.certificatename,
                                    t.educationlevel,
                                    t.certificatelevelid,
                                    t.certificatelevel,
                                    t.certificatetypeid,
                                    t.certificatetype,
                                    t.ispercentage,
                                    t.comment,
                                    t.remarks,
                                    datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objgen_certificate.ControllerName, t.certificateid, "certificateid", _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList, _contextAccessor)
                                }).ToList();

                    outputPort.GetListView(new Gen_CertificateResponse(new AjaxResponse(oblist[0].RETURN_KEY, data), true, null));
                    return true;
                }
                else
                {
                    Gen_CertificateResponse objResponse = new Gen_CertificateResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                        "404",
                        _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetListView(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_CertificateResponse objResponse = new Gen_CertificateResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetCertificatebyCertificateLevel(Gen_CertificateRequest message, IDDLRequestHandler<Gen_CertificateResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_certificateEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_certificateFCC.GetFacadeCreate(_contextAccessor).
                    GetCertificatebyCertificateLevel(message.Objgen_certificate, cancellationToken);
                if (oblist != null && oblist.Count > 0)
                {
                    var select = (from data in oblist select new { Id = data.certificateid, Text = data.certificatename, batchcandcertificateid = data.BatchCandCertificateID }).ToList();

                    outputPort.GetDropDown(new Gen_CertificateResponse(new AjaxResponse(oblist[0].RETURN_KEY, select), true, null));
                    return true;
                }
                else
                {
                    Gen_CertificateResponse objResponse = new Gen_CertificateResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_CertificateResponse objResponse = new Gen_CertificateResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return true;
            }
        }

        /// <summary>
		/// GetDataForDropDown Batch Candidate Type wise Gen_Certificate
		/// </summary>
		/// <param name="response"></param>
		public async Task<bool> GetBatchCandidateTypeWiseCertificateDropDown(Gen_CertificateRequest message, IDDLRequestHandler<Gen_CertificateResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_certificateEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_certificateFCC.GetFacadeCreate(_contextAccessor).GetBatchCandidateTypeWiseCertificateDropDown(message.Objgen_certificate, cancellationToken);
                if (oblist != null && oblist.Count > 0)
                {
                    var select = (from data in oblist select new { Id = data.certificateid, Text = data.certificatename }).ToList();

                    outputPort.GetDropDown(new Gen_CertificateResponse(new AjaxResponse(oblist[0].RETURN_KEY, select), true, null));
                    return true;
                }
                else
                {
                    Gen_CertificateResponse objResponse = new Gen_CertificateResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_CertificateResponse objResponse = new Gen_CertificateResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return true;
            }
        }

    }
}