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
using Web.Core.Frame.Interfaces.UseCases.Transaction;
using Web.Core.Frame.Dto.UseCaseResponses.Transaction;
using Web.Core.Frame.Dto.UseCaseRequests.Transaction;
using BDO.DataAccessObjects.ExtendedEntities;
using RestSharp;
using BDO.Base;
using Microsoft.Extensions.Options;
using BDO.Core.Base;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Web.Helpers;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Bson;
using Newtonsoft.Json.Linq;

namespace Web.Core.Frame.UseCases.Transaction
{
    public sealed partial class Tran_SpecialRegistrationUseCase : ITran_SpecialRegistrationUseCase
    {
        clsPrivateKeys objClsPrivate = new clsPrivateKeys();
        private readonly IOptions<ApplicationGlobalSettings> _applicationGlobalSettings;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IJwtFactory _jwtFactory;
        private readonly IStringLocalizer _sharedLocalizer;
        private readonly ILogger<Tran_SpecialRegistrationUseCase> _logger;
        private dataTableButtonPanel objDTBtnPanel = new dataTableButtonPanel();
        public Error _errors { get; set; }
        private readonly KAFPaciServiceSettings _kAFPaciServiceSettings;
        private readonly TinyURLServicesSetting _tinyURLServicesSetting;
        private readonly IConfiguration _config;

        public Tran_SpecialRegistrationUseCase(IConfiguration config,
            IHttpContextAccessor contextAccessor,
            IJwtFactory jwtFactory,
            IStringLocalizerFactory factory,
            ILoggerFactory loggerFactory,

             IOptions<ApplicationGlobalSettings> applicationGlobalSettings)
        {
            _contextAccessor = contextAccessor;
            _jwtFactory = jwtFactory;
            _logger = loggerFactory.CreateLogger<Tran_SpecialRegistrationUseCase>();

            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _sharedLocalizer = factory.Create("SharedResource", assemblyName.Name);
            _config = config;
            _kAFPaciServiceSettings = _config.GetSection(nameof(KAFPaciServiceSettings)).Get<KAFPaciServiceSettings>();
            _tinyURLServicesSetting = _config.GetSection(nameof(TinyURLServicesSetting)).Get<TinyURLServicesSetting>();
            _applicationGlobalSettings = applicationGlobalSettings;
        }

        public Task<bool> Handle(Tran_SpecialRegistrationRequest message, IOutputPort<Tran_SpecialRegistrationResponse> outputPort)
        {
            throw new Exception("Not Implemented");
        }

        public async Task<bool> GetAll(Tran_SpecialRegistrationRequest message, ICRUDRequestHandler<Tran_SpecialRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<tran_specialregistrationEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.tran_specialregistrationFCC.GetFacadeCreate(_contextAccessor)
                .GetAll(message.Objtran_specialregistration, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAll(new Tran_SpecialRegistrationResponse(oblist.ToList(), true));
                    return true;
                }
                else
                {
                    Tran_SpecialRegistrationResponse objResponse = new Tran_SpecialRegistrationResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAll(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Tran_SpecialRegistrationResponse objResponse = new Tran_SpecialRegistrationResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAll(objResponse);
                return true;
            }
        }

        public async Task<bool> GetAllPaged(Tran_SpecialRegistrationRequest message, ICRUDRequestHandler<Tran_SpecialRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<tran_specialregistrationEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.tran_specialregistrationFCC.GetFacadeCreate(_contextAccessor)
                .GetAllByPages(message.Objtran_specialregistration, cancellationToken);

                if (oblist != null && oblist.Count > 0)
                {
                    outputPort.GetAllPaged(new Tran_SpecialRegistrationResponse(oblist.ToList(), true));
                    return true;
                }
                else
                {
                    Tran_SpecialRegistrationResponse objResponse = new Tran_SpecialRegistrationResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetAllPaged(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Tran_SpecialRegistrationResponse objResponse = new Tran_SpecialRegistrationResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetAllPaged(objResponse);
                return true;
            }
        }

        public async Task<bool> GetListView(Tran_SpecialRegistrationRequest message, ICRUDRequestHandler<Tran_SpecialRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {

                IList<tran_specialregistrationEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.tran_specialregistrationFCC.GetFacadeCreate(_contextAccessor)
                .GAPgListView(message.Objtran_specialregistration, cancellationToken);
                if (oblist != null && oblist.Count > 0)
                {
                    List<dataTableButtonModel> btnActionList = new List<dataTableButtonModel>();
                    //btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.New_GET));
                    //btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.Edit_GET));
                    //btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.Delete_GET));
                    btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.GetSingle_GET));
                    //btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.CUSTOM, _sharedLocalizer["PROCESS"], "StpOrganizationEntity/userprocess"));
                    //btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.CUSTOM, _sharedLocalizer["SEARCH"], "StpOrganizationEntity/usersearch"));

                    var data = (from t in oblist
                                select new
                                {
                                    t.specialregid,
                                    t.civilid,
                                    t.batchid,
                                    t.candidatetypeid,
                                    t.mobilenumber,
                                    t.emailaddress,
                                    t.paciresponse,
                                    t.validuntil,
                                    t.sendbysms,
                                    t.sendbyemail,
                                    t.sendbydigitalid,
                                    t.remarks,
                                    t.BaseSecurityParam.createdbyusername,
                                    t.BaseSecurityParam.createddate,
                                    datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objtran_specialregistration.ControllerName, t.specialregid, "specialregid", _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList, _contextAccessor)
                                }).ToList();

                    outputPort.GetListView(new Tran_SpecialRegistrationResponse(new AjaxResponse(oblist[0].RETURN_KEY, data), true, null));
                    return true;
                }
                else
                {
                    Tran_SpecialRegistrationResponse objResponse = new Tran_SpecialRegistrationResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                        "404",
                        _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetListView(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Tran_SpecialRegistrationResponse objResponse = new Tran_SpecialRegistrationResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetListView(objResponse);
                return true;
            }
        }

        public async Task<bool> GetSingle(Tran_SpecialRegistrationRequest message, ICRUDRequestHandler<Tran_SpecialRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                tran_specialregistrationEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.tran_specialregistrationFCC.GetFacadeCreate(_contextAccessor)
                .GetSingle(message.Objtran_specialregistration, cancellationToken);
                if (objSingle != null)
                {
                    outputPort.GetSingle(new Tran_SpecialRegistrationResponse(objSingle, true));
                    return true;
                }
                else
                {
                    Tran_SpecialRegistrationResponse objResponse = new Tran_SpecialRegistrationResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetSingle(objResponse);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Tran_SpecialRegistrationResponse objResponse = new Tran_SpecialRegistrationResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetSingle(objResponse);
                return true;
            }
        }

        public async Task<bool> Save(Tran_SpecialRegistrationRequest message, ICRUDRequestHandler<Tran_SpecialRegistrationResponse> outputPort)
        {
            _logger.LogInformation(JsonConvert.SerializeObject(message));
            CancellationToken cancellationToken = new CancellationToken();
            long? specialregid = null;
            try
            {
                specialregid = await BFC.Core.FacadeCreatorObjects.General.tran_specialregistrationFCC.GetFacadeCreate(_contextAccessor)
                    .Add(message.Objtran_specialregistration, cancellationToken);

                var objGenBatch = await BFC.Core.FacadeCreatorObjects.General.gen_batchFCC.GetFacadeCreate(_contextAccessor).GetBatchById(new gen_batchEntity { batchid = message.Objtran_specialregistration.batchid }, cancellationToken);

                if (_kAFPaciServiceSettings.IsEnable)
                {
                    var SpecialRegistrationId = objClsPrivate.EncodeUrlOnlyParams(GlobalConstant.SpecialRegistrationId, specialregid.ToString());
                    var SpecialRegistrationURL = $"{_applicationGlobalSettings.Value.SpecialRegistrationURL}{SpecialRegistrationId}";

                    //Make url shorter
                    //var token = await LoginToTinyURLAPIService();

                    //string TinySpecialRegistrationURL = string.Empty;
                    string TinySpecialRegistrationURL = SpecialRegistrationURL;

                    //set tiny url
                    //if (!token.IsNullOrEmpty())
                    //{
                    //    using (var httpClient = new HttpClient())
                    //    {
                    //        using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://milapi.kuwaitarmy.gov.kw/api/TranTinyURLData/SetActualURLByTinyURL"))
                    //        {
                    //            request.Headers.TryAddWithoutValidation("accept", "/");
                    //            request.Headers.TryAddWithoutValidation("Authorization", $"bearer {token}");

                    //            request.Content = new StringContent("{\n  \"actualurl\": \"" + SpecialRegistrationURL + "\",\n  \"serviceid\":11,\n  \"isactive\": true,\n  \"otisonetime\": true\n}");
                    //            request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    //            var response = await httpClient.SendAsync(request);
                    //            string responseFinal = await response.Content.ReadAsStringAsync();
                    //            JObject jsonObject = JObject.Parse(responseFinal);
                    //            TinySpecialRegistrationURL = jsonObject["_trantinyurldata_"]["tinyurl"].ToString();
                    //        }
                    //    }
                    //}
                    //else
                    //{
                    //    TinySpecialRegistrationURL = SpecialRegistrationURL;
                    //}
                    
                    using (RestClient client = new RestClient($"{_kAFPaciServiceSettings.WebApiAddress}Auth/login"))
                    {
                        RestRequest Shahilrequest = new RestRequest() { Method = Method.Post };
                        //Add Headers  
                        Shahilrequest.AddHeader("Content-Type", "application/json");
                        var body = new
                        {
                            username = _kAFPaciServiceSettings.UserName,
                            password = _kAFPaciServiceSettings.Password
                        };

                        Shahilrequest.AddJsonBody(body);

                        var apiresponse = client.Execute(Shahilrequest);
                        if (apiresponse.IsSuccessStatusCode)
                        {
                            var accee = JsonConvert.DeserializeObject<SahilAccesstoken>(apiresponse.Content);

                            using (var notificationClient = new RestClient($"{_kAFPaciServiceSettings.WebApiAddress}NotificationRequestRecipientList/SendNotificationToSingleUser"))
                            {
                                Shahilrequest = new RestRequest() { Method = Method.Post };
                                Shahilrequest.AddHeader("Content-Type", "application/json");
                                Shahilrequest.AddHeader("Authorization", $"Bearer {accee.accessToken.token}");

                                string html = System.IO.File.ReadAllText(System.IO.Path.Combine(Environment.CurrentDirectory, "EmailTemplate/SpecialRegistration" + Thread.CurrentThread.CurrentCulture.ToString().ToUpper() + ".html"));
                                html = html.Replace("{currentdatetime}", DateTime.Now.ToString("dd-MM-yyyy"));
                                html = html.Replace("{registrationurllink}", TinySpecialRegistrationURL);
                                html = html.Replace("{CivilID}", message.Objtran_specialregistration.civilid);
                                html = html.Replace("{BatchNo}", objGenBatch.BatchDetails);

                                var NotificationBody = new
                                {
                                    applicationid = _kAFPaciServiceSettings.ApplicationId,
                                    notificationrequestid = 0,
                                    recipientcivilid = message.Objtran_specialregistration.civilid,
                                    recipientmobile = message.Objtran_specialregistration.mobilenumber,
                                    recipientemail = message.Objtran_specialregistration.emailaddress,

                                    msgsubject = "VC:Special Registration",
                                    msgsubjectar = "تفعيل الحساب",

                                    msg = $"Your Special Registration url is {TinySpecialRegistrationURL}",
                                    msgar = $"Your Special Registration url is {TinySpecialRegistrationURL}",


                                    messagebodyemail = html,
                                    messagebodyemailar = html,

                                    sendsms = message.Objtran_specialregistration.sendbysms,
                                    senddigitalidnotification = message.Objtran_specialregistration.sendbydigitalid,
                                    sendemail = message.Objtran_specialregistration.sendbyemail
                                };

                                Shahilrequest.AddJsonBody(NotificationBody);
                                var NotificationApiresponse = notificationClient.Execute(Shahilrequest);


                                //Update Paci Response
                                var singledata = await BFC.Core.FacadeCreatorObjects.General.tran_specialregistrationFCC.GetFacadeCreate(_contextAccessor)
                                                    .GetSingle(new tran_specialregistrationEntity() { specialregid = specialregid }, cancellationToken);
                                singledata.paciresponse = NotificationApiresponse.Content;

                                await BFC.Core.FacadeCreatorObjects.General.tran_specialregistrationFCC.GetFacadeCreate(_contextAccessor)
                                                    .Update(singledata, cancellationToken);

                            }
                        }
                    }
                }

                outputPort.Save(new Tran_SpecialRegistrationResponse(new AjaxResponse("200", _sharedLocalizer["DATA_SAVE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Tran_SpecialRegistrationResponse objResponse = new Tran_SpecialRegistrationResponse(false, _sharedLocalizer["DATA_SAVE_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Save(objResponse);
                return true;
            }
        }

        public async Task<string> LoginToTinyURLAPIService()
        {
            string responseFinal = string.Empty;
            string token = string.Empty;
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), _tinyURLServicesSetting.tinyurlapi + "Auth/login"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "text/plain");
                    request.Content = new StringContent("{\n  \"userName\": \"" + _tinyURLServicesSetting.useranme + "\",\n  \"password\": \"" + _tinyURLServicesSetting.password + "\",\n  \"remoteIpAddress\": \"" + _tinyURLServicesSetting.remoteIpAddress + "\"\n}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    var response = await httpClient.SendAsync(request);
                    var JsonStrm = response.Content.ReadAsStringAsync();
                    if (JsonStrm != null)
                        if (!string.IsNullOrEmpty(JsonStrm.Result))
                        {
                            responseFinal = JsonStrm.Result;
                        }
                }
            }

            ApiLoginAccessEntity objRet = JsonConvert.DeserializeObject<ApiLoginAccessEntity>(responseFinal);
            token = objRet.accessToken;
            return token;

        }

        public async Task<bool> Update(Tran_SpecialRegistrationRequest message, ICRUDRequestHandler<Tran_SpecialRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.tran_specialregistrationFCC.GetFacadeCreate(_contextAccessor)
                    .Update(message.Objtran_specialregistration, cancellationToken);

                outputPort.Update(new Tran_SpecialRegistrationResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Tran_SpecialRegistrationResponse objResponse = new Tran_SpecialRegistrationResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        public async Task<bool> Delete(Tran_SpecialRegistrationRequest message, ICRUDRequestHandler<Tran_SpecialRegistrationResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.General.tran_specialregistrationFCC.GetFacadeCreate(_contextAccessor)
                    .Delete(message.Objtran_specialregistration, cancellationToken);
                outputPort.Delete(new Tran_SpecialRegistrationResponse(new AjaxResponse("200", _sharedLocalizer["DATA_DELETE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                       ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Tran_SpecialRegistrationResponse objResponse = new Tran_SpecialRegistrationResponse(false, _sharedLocalizer["DATA_DELETE_ERROR"], new Error(
                         "500",
                         ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Delete(objResponse);
                return true;
            }
        }





    }
}