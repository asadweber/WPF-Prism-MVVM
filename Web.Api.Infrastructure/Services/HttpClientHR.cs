using BDO.Core.DataAccessObjects.CommonEntities;
using BDO.Core.DataAccessObjects.ExtendedEntities;
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

    internal sealed partial class HttpClientHR : IHttpClientHR
    {

        private readonly IConfiguration _config;
        private readonly HttpClient _client;
        private IHttpClientFactory _IHttpClienFactory;
        private readonly IJwtTokenValidator _jwtTokenValidator;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly KNSServiceSettings _kNSServiceSettings;
        private readonly IStringCompression _stringCompression;
        private readonly SalaryServiceSettings _salaryServiceSettings;
        private readonly KAFPaciServiceSettings _kAFPaciServiceSettings;

        internal HttpClientHR(IConfiguration config
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
            _kNSServiceSettings = _config.GetSection(nameof(KNSServiceSettings)).Get<KNSServiceSettings>();
            _salaryServiceSettings = _config.GetSection(nameof(SalaryServiceSettings)).Get<SalaryServiceSettings>();
            _kAFPaciServiceSettings = _config.GetSection(nameof(KAFPaciServiceSettings)).Get<KAFPaciServiceSettings>();

            HttpClient client = _IHttpClienFactory.CreateClient();
            client.BaseAddress = new Uri(_kNSServiceSettings.WebApiAddress);
            client.DefaultRequestHeaders.Add("Accept", "application/vnd.github.v3+json");
            client.DefaultRequestHeaders.Add("User-Agent", "CoreCors");
            _client = client;
        }


        public async Task<knsCertificatesResponseEntity> GetKNSProfileCertificateByCivilID(GetStatusByCivilIDEntity objEntity)
        {
            knsCertificatesResponseEntity objData = new knsCertificatesResponseEntity();
            HttpResponseMessage response = null;
            var handler = new HttpClientHandler();
            handler.UseCookies = false;
            using (var httpClient = new HttpClient(handler))
            {
                using (var request = new HttpRequestMessage(new HttpMethod("GET"), _kNSServiceSettings.WebApiAddress + "getProfileCertificateBase64/civilid/" + objEntity.civilid))
                {
                    request.Headers.TryAddWithoutValidation("username", _kNSServiceSettings.ApiUserName);
                    request.Headers.TryAddWithoutValidation("password", _kNSServiceSettings.ApiPassword);
                    response = await httpClient.SendAsync(request);
                    var JsonStrm = response.Content.ReadAsStringAsync();
                    if (JsonStrm != null)
                        if (!string.IsNullOrEmpty(JsonStrm.Result))
                        {
                            objData = JsonConvert.DeserializeObject<knsCertificatesResponseEntity>(JsonStrm.Result);
                            return objData;
                        }
                }
            }
            return null;
        }


        public async Task<knsCertificatesResponseEntity> GetKNSProfessionalCertificateByCivilID(GetStatusByCivilIDEntity objEntity)
        {
            knsCertificatesResponseEntity objData = new knsCertificatesResponseEntity();
            HttpResponseMessage response = null;
            var handler = new HttpClientHandler();
            handler.UseCookies = false;
            using (var httpClient = new HttpClient(handler))
            {
                using (var request = new HttpRequestMessage(new HttpMethod("GET"), _kNSServiceSettings.WebApiAddress + "getProfileProfessionCertificateBase64/civilid/" + objEntity.civilid))
                {
                    request.Headers.TryAddWithoutValidation("username", _kNSServiceSettings.ApiUserName);
                    request.Headers.TryAddWithoutValidation("password", _kNSServiceSettings.ApiPassword);
                    response = await httpClient.SendAsync(request);
                    var JsonStrm = response.Content.ReadAsStringAsync();
                    if (JsonStrm != null)
                        if (!string.IsNullOrEmpty(JsonStrm.Result))
                        {
                            objData = JsonConvert.DeserializeObject<knsCertificatesResponseEntity>(JsonStrm.Result);
                            return objData;
                        }
                }
            }
            return null;
        }


        public async Task<knsCertificatesResponseEntity> GetKNSEmploymentCertificateByCivilID(GetStatusByCivilIDEntity objEntity)
        {
            knsCertificatesResponseEntity objData = new knsCertificatesResponseEntity();
            HttpResponseMessage response = null;
            var handler = new HttpClientHandler();
            handler.UseCookies = false;
            using (var httpClient = new HttpClient(handler))
            {
                using (var request = new HttpRequestMessage(new HttpMethod("GET"), _kNSServiceSettings.WebApiAddress + "getProfileEmploymentCertificateBase64/civilid/" + objEntity.civilid))
                {
                    request.Headers.TryAddWithoutValidation("username", _kNSServiceSettings.ApiUserName);
                    request.Headers.TryAddWithoutValidation("password", _kNSServiceSettings.ApiPassword);
                    response = await httpClient.SendAsync(request);
                    var JsonStrm = response.Content.ReadAsStringAsync();
                    if (JsonStrm != null)
                        if (!string.IsNullOrEmpty(JsonStrm.Result))
                        {
                            objData = JsonConvert.DeserializeObject<knsCertificatesResponseEntity>(JsonStrm.Result);
                            return objData;
                        }
                }
            }
            return null;
        }



        public async Task<salaryCertificatesResponseEntity> GetSalaryCertificateByCivilIDAndMilitaryID(GetStatusByCivilIDEntity objEntity)
        {
            salaryCertificatesResponseEntity objData = new salaryCertificatesResponseEntity();
            HttpResponseMessage response = null;
            var handler = new HttpClientHandler();
            handler.UseCookies = false;
            using (var httpClient = new HttpClient(handler))
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), _salaryServiceSettings.WebApiAddress))
                {

                    string strQR = "Civil ID: " + objEntity.nationalid + " Military ID: " + objEntity.caseno + " Secret Code: " + objEntity.selectedtext;
                    request.Headers.TryAddWithoutValidation("accept", "*/*");
                    request.Content = new StringContent("{\n \n  \"employeeno\": \"" + objEntity.caseno + "\",\n  \"subject\": \"" + strQR + "\",\n  \"letterno\": \"" + objEntity.nationalid + "\",\n  \"year\": \"" + objEntity.preaddress + "\",\n  \"month\": \"" + objEntity.prepaci + "\"\n}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    response = await httpClient.SendAsync(request);
                    var JsonStrm = response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(JsonStrm.Result))
                    {
                        objData = new salaryCertificatesResponseEntity();
                        objData.responsetext = JsonStrm.Result;
                        objData.status = "200";

                        if (objData.responsetext == "No data found")
                        {
                            objData.status = "404";
                            return objData;
                        }

                        byte[] fileContents = Convert.FromBase64String(objData.responsetext);

                        //GetStatusByCivilIDEntity obj = new GetStatusByCivilIDEntity();
                        //obj.caseno = militaryID;
                        //obj.nationalid = civilid;
                        //obj.prepaci = MonthID;
                        //obj.preaddress = YearID;

                        byte[] fileContentsEnc = null;
                        using (MemoryStream input = new MemoryStream(fileContents))
                        {
                            using (MemoryStream output = new MemoryStream())
                            {
                                string password = objEntity.selectedtext;
                                PdfReader reader = new PdfReader(input);
                                PdfEncryptor.Encrypt(reader, output, true, password, password, PdfWriter.ALLOW_SCREENREADERS);
                                fileContentsEnc = output.ToArray();
                            }
                        }


                        string fileNameWithExt = objEntity.caseno + "_" + objEntity.prepaci + "_" + objEntity.preaddress + "_" + "_SalaryCertificate.pdf";
                        FtpWebRequest requestFTP = (FtpWebRequest)WebRequest.Create(_salaryServiceSettings.ftpurl + fileNameWithExt);

                        requestFTP.ContentLength = fileContentsEnc.Length;
                        requestFTP.Method = WebRequestMethods.Ftp.UploadFile;
                        requestFTP.Credentials = new NetworkCredential(_salaryServiceSettings.ftpUserName, _salaryServiceSettings.ftpPassword);
                        Stream requestFTPStream = requestFTP.GetRequestStream();
                        requestFTPStream.Write(fileContentsEnc, 0, fileContentsEnc.Length);
                        requestFTPStream.Close();
                        FtpWebResponse responseFTP = (FtpWebResponse)requestFTP.GetResponse();

                        objData.responsetext = _salaryServiceSettings.ftpaccessurl + "SAL/" + fileNameWithExt;
                        return objData;
                    }
                }
            }
            return null;
        }

        public async Task<string> SendPACINotification(EmailEntity objEntity)
        {
            string responseFinal = string.Empty;
            string token = string.Empty;
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), _kAFPaciServiceSettings.WebApiAddress + "Auth/login"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "text/plain");
                    request.Content = new StringContent("{\n  \"userName\": \"" + _kAFPaciServiceSettings.UserName + "\",\n  \"password\": \"" + _kAFPaciServiceSettings.Password + "\",\n  \"remoteIpAddress\": \"127.0.0.1\"\n}");
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


            if (!string.IsNullOrEmpty(token))
            {
                using (var httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("GET"), _kAFPaciServiceSettings.WebApiAddress + "Tran_PaciSignInRequestInfo/SendMessageToDigitalIDUserGet?" +
                        "PersonCivilNo=" + objEntity.toEmail + "&NotificationSubjectEn=" + objEntity.subjecten + "&" +
                        "NotificationSubjectAr=" + objEntity.subject + "&" +
                        "NotificationMessageEn=" + objEntity.messageen + "&NotificationMessageAr=" + objEntity.message + ""))
                    {
                        request.Headers.TryAddWithoutValidation("accept", "text/plain");
                        request.Headers.TryAddWithoutValidation("Authorization", "bearer " + token);

                        var response = await httpClient.SendAsync(request);
                        var JsonStrm = response.Content.ReadAsStringAsync();
                        if (JsonStrm != null)
                            if (!string.IsNullOrEmpty(JsonStrm.Result))
                            {
                                responseFinal = JsonStrm.Result;
                            }
                    }
                }

                dynamic dynamicApi2 = JsonConvert.DeserializeObject(responseFinal);
                responseFinal = dynamicApi2.data.result.ToString();
            }

            return responseFinal;
        }



        public async Task<Payload> GetPACICivilIDInformation(EmailEntity objEntity)
        {
            Payload obj = new Payload();
            string responseFinal = string.Empty;
            string token = string.Empty;
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), _kAFPaciServiceSettings.WebApiAddress + "Auth/login"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "text/plain");
                    request.Content = new StringContent("{\n  \"userName\": \"" + _kAFPaciServiceSettings.UserName + "\",\n  \"password\": \"" + _kAFPaciServiceSettings.Password + "\",\n  \"remoteIpAddress\": \"127.0.0.1\"\n}");
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


            if (!string.IsNullOrEmpty(token))
            {
                using (var httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("GET"), _kAFPaciServiceSettings.WebApiAddress + "Tran_PaciSignInRequestInfo/GetCivilDataByPACI?" +
                        "civilid=" + objEntity.toEmail))
                    {
                        request.Headers.TryAddWithoutValidation("accept", "text/plain");
                        request.Headers.TryAddWithoutValidation("Authorization", "bearer " + token);

                        var response = await httpClient.SendAsync(request);
                        var JsonStrm = response.Content.ReadAsStringAsync();
                        if (JsonStrm != null)
                            if (!string.IsNullOrEmpty(JsonStrm.Result))
                            {
                                responseFinal = JsonStrm.Result;
                            }
                    }
                }

                dynamic dynamicApi2 = JsonConvert.DeserializeObject(responseFinal);
                obj = JsonConvert.DeserializeObject<Payload>(responseFinal);
            }

            return obj;
        }


        public async Task<PACIMainShortProfileResponseEntity> GetPACIMAinCivilIDInformation(EmailEntity objEntity)
        {
            PACIMainShortProfileResponseEntity objResponse = new PACIMainShortProfileResponseEntity();
            string responseFinal = string.Empty;
            string token = string.Empty;
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), _kAFPaciServiceSettings.WebApiAddress + "Auth/login"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "text/plain");
                    request.Content = new StringContent("{\n  \"userName\": \"" + _kAFPaciServiceSettings.UserName + "\",\n  \"password\": \"" + _kAFPaciServiceSettings.Password + "\",\n  \"remoteIpAddress\": \"127.0.0.1\"\n}");
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


            if (!string.IsNullOrEmpty(token))
            {
                using (var httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("GET"), _kAFPaciServiceSettings.WebApiAddress + "Tran_PaciSignInRequestInfo/GetCivilShortDataByPACIForSahel?civilid="+ objEntity.toEmail))
                    {
                        request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + token);

                        var response = await httpClient.SendAsync(request);
                        var JsonStrm = response.Content.ReadAsStringAsync();
                        if (JsonStrm != null)
                            if (!string.IsNullOrEmpty(JsonStrm.Result))
                            {
                                responseFinal = JsonStrm.Result;
                            }
                    }
                }

                objResponse = JsonConvert.DeserializeObject<PACIMainShortProfileResponseEntity>(responseFinal);

            }
            return objResponse;
        }



       


    }
}
