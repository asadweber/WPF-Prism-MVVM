using BDO.Core.DataAccessObjects.CommonEntities;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.DataAccessObjects.ApiModels;
using BDO.DataAccessObjects.ExtendedEntities;
using BDO.DataAccessObjects.ExtendedEntities;
using DocumentFormat.OpenXml.Bibliography;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

using Web.Api.Infrastructure.Interfaces;
using Web.Core.Frame.Interfaces.Services;
using Web.Core.Frame.RequestResponse.UseCaseRequests;

namespace Web.Api.Infrastructure.Services
{

    internal sealed partial class HttpClientPACIAuth : IHttpClientPACIAuth
    {

        private readonly IConfiguration _config;
        private readonly HttpClient _client;
        private IHttpClientFactory _IHttpClienFactory;
        private readonly IJwtTokenValidator _jwtTokenValidator;
        private readonly IHttpContextAccessor _contextAccessor;

        private readonly IStringCompression _stringCompression;
        private readonly KAFPaciServiceSettings _kAFPaciServiceSettings;

        internal HttpClientPACIAuth(IConfiguration config
            , IHttpContextAccessor contextAccessor
            , IHttpClientFactory IHttpClienFactory
            , IJwtTokenValidator jwtTokenValidator
            , IStringCompression stringCompression
            )
        {
            _contextAccessor = contextAccessor;
            _config = config;
            _IHttpClienFactory = IHttpClienFactory;
            _stringCompression = stringCompression;
            _jwtTokenValidator = jwtTokenValidator;
            _kAFPaciServiceSettings = _config.GetSection(nameof(KAFPaciServiceSettings)).Get<KAFPaciServiceSettings>();

            HttpClient client = _IHttpClienFactory.CreateClient();
            client.BaseAddress = new Uri(_kAFPaciServiceSettings.WebApiAddress);
            client.DefaultRequestHeaders.Add("Accept", "application/vnd.github.v3+json");
            client.DefaultRequestHeaders.Add("User-Agent", "CoreCors");
            _client = client;
        }

        public async Task<string> LoginToPACIAPIService()
        {
            string responseFinal = string.Empty;
            string token = string.Empty;
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), _kAFPaciServiceSettings.WebApiAddress + "Auth/login"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "text/plain");
                    request.Content = new StringContent("{\n  \"userName\": \"" + _kAFPaciServiceSettings.UserName + "\",\n  \"password\": \"" + _kAFPaciServiceSettings.Password + "\",\n  \"remoteIpAddress\": \"192.168.200.90\"\n}");
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
            dynamic dynamicApi = JsonConvert.DeserializeObject(responseFinal);
            token = dynamicApi.accessToken.token.ToString();

            return token;
        }

        public async Task<PACIQRCodeAuthenticationEntity> GetQRCodeFromPACIToAuthenticate(PACIAuthRequestEntity objEntity)
        {
            string responseFinal = string.Empty;
            string token = await LoginToPACIAPIService();

            PACIQRCodeAuthenticationEntity objRet = new PACIQRCodeAuthenticationEntity();


            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), _kAFPaciServiceSettings.WebApiAddress + "PACIAuthenticationAPI/GetQRCodeFromPACIToAuthenticate"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "text/plain");
                    request.Headers.TryAddWithoutValidation("Authorization", "bearer " + token);

                    objEntity.ServiceDescriptionEN = string.IsNullOrEmpty(objEntity.ServiceDescriptionEN) == false ? objEntity.ServiceDescriptionEN : "Service Description";
                    objEntity.ServiceDescriptionAR = string.IsNullOrEmpty(objEntity.ServiceDescriptionAR) == false ? objEntity.ServiceDescriptionAR : "وصف الخدمة";
                    objEntity.AuthenticationReasonEn = string.IsNullOrEmpty(objEntity.AuthenticationReasonEn) == false ? objEntity.AuthenticationReasonEn : "Authentication Reason";
                    objEntity.AuthenticationReasonAr = string.IsNullOrEmpty(objEntity.AuthenticationReasonAr) == false ? objEntity.AuthenticationReasonAr : "سبب المصادقة";


                    request.Content = new StringContent("{\n  " +
                        "\n  \"civilid\": \"-99\"," +
                        "\n  \"servicename\": \""+ objEntity.servicename + "\"," +
                        "\n  \"serviceDescriptionEN\": \""+ objEntity.ServiceDescriptionEN + "\"," +
                        "\n  \"serviceDescriptionAR\": \""+ objEntity.ServiceDescriptionAR + "\"," +
                        "\n  \"authenticationReasonEn\": \""+ objEntity.AuthenticationReasonEn + "\"," +
                        "\n  \"authenticationReasonAr\": \""+ objEntity.AuthenticationReasonAr + "\"," +
                        "\n  \"callingUrl\": \""+ objEntity.CallingUrl + "\"," +
                        "\n  \"keyParam\": \""+ objEntity.KeyParam + "\"," +
                        "\n  \"signalRContextName\": \""+ objEntity.SignalRContextName + "\"," +
                        "\n  \"signalRMethodName\": \""+ objEntity.SignalRMethodName + "\"," +
                        "\n  \"mobilenumber\": \""+ objEntity.mobilenumber + "\"," +
                        "\n  \"coreornocore\": true\n}");


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

            objRet = JsonConvert.DeserializeObject<PACIQRCodeAuthenticationEntity>(responseFinal);
            return objRet;
        }

        public async Task<SignInAjaxResponse> SendAuthRequestToAuthenticate(PACIAuthRequestEntity objEntity)
        {
            string responseFinal = string.Empty;
            string token = await LoginToPACIAPIService();

            SignInAjaxResponse objRet = new SignInAjaxResponse();


            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), _kAFPaciServiceSettings.WebApiAddress + "Tran_PaciSignInRequestInfo/GetSignInRequest"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "text/plain");
                    request.Headers.TryAddWithoutValidation("Authorization", "bearer " + token);

                    objEntity.ServiceDescriptionEN = string.IsNullOrEmpty(objEntity.ServiceDescriptionEN) == false ? objEntity.ServiceDescriptionEN : "Service Description";
                    objEntity.ServiceDescriptionAR = string.IsNullOrEmpty(objEntity.ServiceDescriptionAR) == false ? objEntity.ServiceDescriptionAR : "وصف الخدمة";
                    objEntity.AuthenticationReasonEn = string.IsNullOrEmpty(objEntity.AuthenticationReasonEn) == false ? objEntity.AuthenticationReasonEn : "Authentication Reason";
                    objEntity.AuthenticationReasonAr = string.IsNullOrEmpty(objEntity.AuthenticationReasonAr) == false ? objEntity.AuthenticationReasonAr : "سبب المصادقة";


                    request.Content = new StringContent("{\n  " +
                        "\n  \"civilid\": \""+ objEntity.civilid + "\"," +
                        "\n  \"servicename\": \"" + objEntity.servicename + "\"," +
                        "\n  \"serviceDescriptionEN\": \"" + objEntity.ServiceDescriptionEN + "\"," +
                        "\n  \"serviceDescriptionAR\": \"" + objEntity.ServiceDescriptionAR + "\"," +
                        "\n  \"authenticationReasonEn\": \"" + objEntity.AuthenticationReasonEn + "\"," +
                        "\n  \"authenticationReasonAr\": \"" + objEntity.AuthenticationReasonAr + "\"," +
                        "\n  \"callingUrl\": \"" + objEntity.CallingUrl + "\"," +
                        "\n  \"keyParam\": \"" + objEntity.KeyParam + "\"," +
                        "\n  \"signalRContextName\": \"" + objEntity.SignalRContextName + "\"," +
                        "\n  \"signalRMethodName\": \"" + objEntity.SignalRMethodName + "\"," +
                        "\n  \"mobilenumber\": \"" + objEntity.mobilenumber + "\"," +
                        "\n  \"coreornocore\": true\n}");


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

            objRet = JsonConvert.DeserializeObject<SignInAjaxResponse>(responseFinal);
            return objRet;
        }

    }
}
