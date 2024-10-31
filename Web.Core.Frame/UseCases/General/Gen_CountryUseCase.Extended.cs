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
using Microsoft.AspNet.SignalR.Client.Http;
using BDO.Core.Base;

namespace Web.Core.Frame.UseCases
{
    public sealed partial class Gen_CountryUseCase : IGen_CountryUseCase
    {
        public async Task<bool> GetSingleByCountryId(Gen_CountryRequest message, ICRUDRequestHandler<Gen_CountryResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                gen_countryEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.gen_countryFCC.GetFacadeCreate(_contextAccessor)
                .GetSingleByCountryId(message.Objgen_country, cancellationToken);
                if (objSingle != null)
                {
                    gen_countrycityEntity objrequest = new gen_countrycityEntity();
                    objrequest.BaseSecurityParam = new BDO.Core.Base.SecurityCapsule();
                    objrequest.BaseSecurityParam = message.Objgen_country.BaseSecurityParam;
                    objrequest.CurrentPage = message.Objgen_country.CurrentPage;
                    objrequest.PageSize = 1000;
                    objrequest.SortExpression = " CityID asc ";
                    objrequest.strCommonSerachParam = message.Objgen_country.strCommonSerachParam;
                    objrequest.ControllerName = "Registration";
                    objrequest.isgovernate = true;
                    objrequest.countryid = objSingle.countryid;

                    objSingle.HasGovernarate = await BFC.Core.FacadeCreatorObjects.General.gen_countrycityFCC.GetFacadeCreate(_contextAccessor)
                        .CheckHasGovernarate(objrequest, cancellationToken);

                    outputPort.GetSingle(new Gen_CountryResponse(objSingle, true));
                    return true;
                }
                else
                {
                    Gen_CountryResponse objResponse = new Gen_CountryResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_CountryResponse objResponse = new Gen_CountryResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }
        public async Task<bool> GetCountryByCandidateTypeDropDown(Gen_CountryRequest message, IDDLRequestHandler<Gen_CountryResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_countryEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_countryFCC.GetFacadeCreate(_contextAccessor)
                .GetCountryDropDown(message.Objgen_country, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {

                    if (message.Objgen_country.CandidateTypeId == 0)
                    {
                        var select = (from data in oblist = new List<gen_countryEntity>()
                                      select new { Id = data.countryid, Text = data.gmt }).ToList();

                        outputPort.GetDropDown(new Gen_CountryResponse(new AjaxResponse(oblist[0].RETURN_KEY, select), true, null));
                    }
                    else if (message.Objgen_country.CandidateTypeId == 1)
                    {
                        var select = (from data in oblist
                                      where data.countryid == 1
                                      select new { Id = data.countryid, Text = data.gmt }).ToList();

                        outputPort.GetDropDown(new Gen_CountryResponse(new AjaxResponse(oblist[0].RETURN_KEY, select), true, null));
                    }

                    else if (message.Objgen_country.CandidateTypeId == 5)
                    {
                        var select = (from data in oblist
                                      where data.countryid != 1 && data.countryid != 9999
                                      select new { Id = data.countryid, Text = data.gmt }).ToList();

                        outputPort.GetDropDown(new Gen_CountryResponse(new AjaxResponse(oblist[0].RETURN_KEY, select), true, null));
                    }
                    else
                    {
                        var select = (from data in oblist
                                      where data.countryid != 1
                                      select new { Id = data.countryid, Text = data.gmt }).ToList();

                        var Illegal_Resident = select.Where(x => x.Id == 9999).FirstOrDefault();
                        if (Illegal_Resident != null) {
                            select.Remove(Illegal_Resident);
                            select.Insert(0, Illegal_Resident);
                        }

                        outputPort.GetDropDown(new Gen_CountryResponse(new AjaxResponse(oblist[0].RETURN_KEY, select), true, null));
                    }

                    return true;
                }
                else
                {
                    Gen_CountryResponse objResponse = new Gen_CountryResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_CountryResponse objResponse = new Gen_CountryResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return false;
            }
        }


        public async Task<bool> GetQualificationCountryDropDown(Gen_CountryRequest message, IDDLRequestHandler<Gen_CountryResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_countryEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_countryFCC.GetFacadeCreate(_contextAccessor)
                .GetCountryDropDown(message.Objgen_country, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {

                    var select = (from data in oblist
                                  where data.countryid != 9999
                                  select new { Id = data.countryid, Text = data.gmt }).ToList();

                    outputPort.GetDropDown(new Gen_CountryResponse(new AjaxResponse(oblist[0].RETURN_KEY, select), true, null));

                    return true;
                }
                else
                {
                    Gen_CountryResponse objResponse = new Gen_CountryResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_CountryResponse objResponse = new Gen_CountryResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return false;
            }
        }


        public async Task<bool> GetPlaceOfBirthCountryDropDown(Gen_CountryRequest message, IDDLRequestHandler<Gen_CountryResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_countryEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_countryFCC.GetFacadeCreate(_contextAccessor)
                .GetCountryDropDown(message.Objgen_country, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {

                    var select = (from data in oblist
                                  where data.countryid != 9999
                                  select new { Id = data.countryid, Text = data.countryname }).ToList();

                    outputPort.GetDropDown(new Gen_CountryResponse(new AjaxResponse(oblist[0].RETURN_KEY, select), true, null));

                    return true;
                }
                else
                {
                    Gen_CountryResponse objResponse = new Gen_CountryResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_CountryResponse objResponse = new Gen_CountryResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return false;
            }
        }

        public async Task<bool> GetNationalityCountryDropDown(Gen_CountryRequest message, IDDLRequestHandler<Gen_CountryResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_countryEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_countryFCC.GetFacadeCreate(_contextAccessor)
                .GetCountryDropDown(message.Objgen_country, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {

                    var select = (from data in oblist
                                  where data.countryid != 9999
                                  select new { Id = data.countryid, Text = data.gmt }).ToList();

                    outputPort.GetDropDown(new Gen_CountryResponse(new AjaxResponse(oblist[0].RETURN_KEY, select), true, null));

                    return true;
                }
                else
                {
                    Gen_CountryResponse objResponse = new Gen_CountryResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_CountryResponse objResponse = new Gen_CountryResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return false;
            }
        }

        public async Task<bool> GetFatherNationalityCountryDropDown(Gen_CountryRequest message, IDDLRequestHandler<Gen_CountryResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_countryEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_countryFCC.GetFacadeCreate(_contextAccessor)
                .GetCountryDropDown(message.Objgen_country, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {

                    var select = (from data in oblist
                                  select new { Id = data.countryid, Text = data.gmt }).ToList();

                    if (message.Objgen_country.NationalityListType == (Int32)NationalityListType.IncludeOnlyKuwait)
                    {
                        select = (from data in oblist
                                  where data.countryid == 1
                                  select new { Id = data.countryid, Text = data.gmt }).ToList();
                    }
                    else if (message.Objgen_country.NationalityListType == (Int32)NationalityListType.IncludeExceptKuwait)
                    {
                        select = (from data in oblist
                                  where data.countryid != 1
                                  select new { Id = data.countryid, Text = data.gmt }).ToList();
                    }
                    else if (message.Objgen_country.NationalityListType == (Int32)NationalityListType.IncludeExceptKuwaitIllegalResident)
                    {
                        select = (from data in oblist
                                  where data.countryid != 1 && data.countryid != 9999
                                  select new { Id = data.countryid, Text = data.gmt }).ToList();
                    }

                    if (message.Objgen_country.NationalityListType != (Int32)NationalityListType.IncludeOnlyKuwait
                        && message.Objgen_country.NationalityListType != (Int32)NationalityListType.IncludeExceptKuwaitIllegalResident)
                    {
                        var Illegal_Resident = select.Where(x => x.Id == 9999).FirstOrDefault();
                        if (Illegal_Resident != null) {
                            select.Remove(Illegal_Resident);
                            if (message.Objgen_country.NationalityListType == (Int32)NationalityListType.IncludeAll == true)
                                select.Insert(1, Illegal_Resident);
                            else
                                select.Insert(0, Illegal_Resident);
                        }
                    }

                    outputPort.GetDropDown(new Gen_CountryResponse(new AjaxResponse(oblist[0].RETURN_KEY, select), true, null));

                    return true;
                }
                else
                {
                    Gen_CountryResponse objResponse = new Gen_CountryResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_CountryResponse objResponse = new Gen_CountryResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return false;
            }
        }

        public async Task<bool> GetMotherNationalityCountryDropDown(Gen_CountryRequest message, IDDLRequestHandler<Gen_CountryResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_countryEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_countryFCC.GetFacadeCreate(_contextAccessor)
                .GetCountryDropDown(message.Objgen_country, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    var select = (from data in oblist
                                  select new { Id = data.countryid, Text = data.gmt }).ToList();

                    if (message.Objgen_country.NationalityListType == (Int32)NationalityListType.IncludeOnlyKuwait)
                    {
                        select = (from data in oblist
                                  where data.countryid == 1
                                  select new { Id = data.countryid, Text = data.gmt }).ToList();
                    }
                    else if (message.Objgen_country.NationalityListType == (Int32)NationalityListType.IncludeExceptKuwait)
                    {
                        select = (from data in oblist
                                  where data.countryid != 1
                                  select new { Id = data.countryid, Text = data.gmt }).ToList();
                    }

                    if (message.Objgen_country.NationalityListType != (Int32)NationalityListType.IncludeOnlyKuwait)
                    {
                        var Illegal_Resident = select.Where(x => x.Id == 9999).FirstOrDefault();
                        if (Illegal_Resident != null) {
                            select.Remove(Illegal_Resident);
                            if (message.Objgen_country.NationalityListType == (Int32)NationalityListType.IncludeAll == true)
                                select.Insert(1, Illegal_Resident);
                            else
                                select.Insert(0, Illegal_Resident);
                        }
                    }

                    outputPort.GetDropDown(new Gen_CountryResponse(new AjaxResponse(oblist[0].RETURN_KEY, select), true, null));

                    return true;
                }
                else
                {
                    Gen_CountryResponse objResponse = new Gen_CountryResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_CountryResponse objResponse = new Gen_CountryResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return false;
            }
        }
        public async Task<bool> GetCountryDropDown(Gen_CountryRequest message, IDDLRequestHandler<Gen_CountryResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_countryEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_countryFCC.GetFacadeCreate(_contextAccessor)
                .GetCountryDropDown(message.Objgen_country, cancellationToken);




                if (oblist != null && oblist.Count > 0)
                {


                    foreach (var item in oblist)
                    {
                        gen_countrycityEntity objrequest = new gen_countrycityEntity();
                        objrequest.BaseSecurityParam = new BDO.Core.Base.SecurityCapsule();
                        objrequest.BaseSecurityParam = message.Objgen_country.BaseSecurityParam;
                        objrequest.CurrentPage = message.Objgen_country.CurrentPage;
                        objrequest.PageSize = 1000;
                        objrequest.SortExpression = " CityID asc ";
                        objrequest.strCommonSerachParam = message.Objgen_country.strCommonSerachParam;
                        objrequest.ControllerName = "Registration";
                        objrequest.isgovernate = true;
                        objrequest.countryid = item.countryid;

                        item.HasGovernarate = await BFC.Core.FacadeCreatorObjects.General.gen_countrycityFCC.GetFacadeCreate(_contextAccessor)
                            .CheckHasGovernarate(objrequest, cancellationToken);
                    }

                    var select = (from data in oblist
                                  where data.countryid != 9999
                                  select new { Id = data.countryid, Text = data.countryname, HasGovernarate = data.HasGovernarate }).ToList();


                    outputPort.GetDropDown(new Gen_CountryResponse(new AjaxResponse(oblist[0].RETURN_KEY, select), true, null));

                    return true;
                }
                else
                {
                    Gen_CountryResponse objResponse = new Gen_CountryResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_CountryResponse objResponse = new Gen_CountryResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return false;
            }
        }


        public async Task<bool> GetGenericNationalityCountryDropDown(Gen_CountryRequest message, IDDLRequestHandler<Gen_CountryResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_countryEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_countryFCC.GetFacadeCreate(_contextAccessor)
                .GetCountryDropDown(message.Objgen_country, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {

                    var select = (from data in oblist
                                  where data.countryid != 1
                                  select new { Id = data.countryid, Text = data.gmt }).ToList();

                    if (message.Objgen_country.IsInculdeAll == true)
                        select = (from data in oblist
                                  select new { Id = data.countryid, Text = data.gmt }).ToList();

                    var Illegal_Resident = select.Where(x => x.Id == 9999).FirstOrDefault();
                    if (Illegal_Resident != null) {
                        select.Remove(Illegal_Resident);
                        if (message.Objgen_country.IsInculdeAll == true)
                            select.Insert(1, Illegal_Resident);
                        else
                            select.Insert(0, Illegal_Resident);
                    }

                    outputPort.GetDropDown(new Gen_CountryResponse(new AjaxResponse(oblist[0].RETURN_KEY, select), true, null));
                    return true;
                }
                else
                {
                    Gen_CountryResponse objResponse = new Gen_CountryResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_CountryResponse objResponse = new Gen_CountryResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return false;
            }
        }

        /// <summary>
        /// GetDataForDropDown Gen_Country
        /// </summary>
        /// <param name="response"></param>
        public async Task<bool> GetNationalityForDropDown(Gen_CountryRequest message, IDDLRequestHandler<Gen_CountryResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<gen_countryEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_countryFCC.GetFacadeCreate(_contextAccessor)
                .GetCountryDropDown(message.Objgen_country, cancellationToken);
                if (oblist != null && oblist.Count > 0)
                {
                    var select = (from data in oblist
                                  select new { Id = data.countryid, Text = data.gmt }).ToList();

                    var Illegal_Resident = select.Where(x => x.Id == 9999).FirstOrDefault();
                    if (Illegal_Resident != null)
                    {
                        select.Remove(Illegal_Resident);
                        select.Insert(1, Illegal_Resident);
                    }
                    outputPort.GetDropDown(new Gen_CountryResponse(new AjaxResponse(oblist[0].RETURN_KEY, select), true, null));
                    return true;
                }
                else
                {
                    Gen_CountryResponse objResponse = new Gen_CountryResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                    "404",
                    _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetDropDown(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Gen_CountryResponse objResponse = new Gen_CountryResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetDropDown(objResponse);
                return true;
            }
        }


    }
}