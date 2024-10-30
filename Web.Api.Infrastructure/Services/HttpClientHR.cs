using BDO.Core.DataAccessObjects.CommonEntities;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.HRDomainModel;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
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
        private readonly hrwebapiconnectionsettings _hrwebapiconnectionsettings;
        private readonly IStringCompression _stringCompression;

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
            _hrwebapiconnectionsettings = _config.GetSection(nameof(hrwebapiconnectionsettings)).Get<hrwebapiconnectionsettings>();
            string username = _hrwebapiconnectionsettings.apiusername;
            string password = _hrwebapiconnectionsettings.apipassword;

            _jwtTokenValidator = jwtTokenValidator;

            HttpClient client = _IHttpClienFactory.CreateClient();
            client.BaseAddress = new Uri(_hrwebapiconnectionsettings.DefaultConnection);
            client.DefaultRequestHeaders.Add("Accept", "application/vnd.github.v3+json");
            client.DefaultRequestHeaders.Add("User-Agent", "CoreCors");
            _client = client;
        }

        /// <summary>
        /// LoginToHRAPIService
        /// </summary>
        /// <returns></returns>
        public async Task<string> LoginToHRAPIService()
        {
            var _hrwebapiconnectionsettings = _config.GetSection(nameof(hrwebapiconnectionsettings)).Get<hrwebapiconnectionsettings>();
            string apiResponse = "";
            var postData = new List<KeyValuePair<string, string>>();
            postData.Add(new KeyValuePair<string, string>("username", _hrwebapiconnectionsettings.apiusername));
            postData.Add(new KeyValuePair<string, string>("password", _hrwebapiconnectionsettings.apipassword));
            postData.Add(new KeyValuePair<string, string>("grant_type", "password"));
            HttpContent content = new FormUrlEncodedContent(postData);

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.PostAsync(_hrwebapiconnectionsettings.DefaultConnection + "oauth2/token", content))
                {
                    apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            return _stringCompression.Zip(apiResponse);
        }

        //json string of type GetPersonnelShortProfileForCOREntity
        public async Task<string> CheckUserExists(string adUserAccountName)
        {
            var json = JsonConvert.SerializeObject(adUserAccountName);
            var request = new HttpRequestMessage(HttpMethod.Get, "api/Correspondence/CheckUserExists?adUserAccountName=" + adUserAccountName);
            var response = _client.SendAsync(request).Result;
            var JsonString = await response.Content.ReadAsStringAsync();
            //var objEntity = Newtonsoft.Json.JsonConvert.DeserializeObject<GetPersonnelShortProfileForCOREntity>(JsonString);
            return JsonString;
        }



        public async Task<bool> LDAPAuthentication(string userName, string password)
        {
            DirectoryEntry de = new DirectoryEntry(_hrwebapiconnectionsettings.LDAPURL, userName, password);
            DirectorySearcher dsearch = new DirectorySearcher(de);
            SearchResult results = null;
            results = dsearch.FindOne();
            if (results != null)
            {
                return true;
            } 
            return false;
        }

        public async Task<string> GetMilitaryShortProfileFromHR(string email, string hrapitoken="")
        {

            if (hrapitoken == "")
            {
                hrapitoken = await GetHRAPITokenFromClaim(); 
            }
            else
            {
                var strunzippedtoken = _stringCompression.UnZip(hrapitoken);

                dynamic objtoken = JsonConvert.DeserializeObject(strunzippedtoken);

                hrapitoken = objtoken.access_token;
            }

            var request = new HttpRequestMessage(HttpMethod.Get, "api/Correspondence/getPersonnelShortProfileForSharePoint?adEmail=" + email);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", hrapitoken);

            var response = _client.SendAsync(request).Result;
            var JsonString = await response.Content.ReadAsStringAsync();

            GetMilShortInfoByBasicMilEntity objUserHRProfile = JsonConvert.DeserializeObject<GetMilShortInfoByBasicMilEntity>(JsonString);
            objUserHRProfile.jobresponsibility = string.Empty;
            objUserHRProfile.unitrole = string.Empty;
            AppConfig.HelperClasses.transactioncodeGen objTrans = new AppConfig.HelperClasses.transactioncodeGen();
            objUserHRProfile.TransID = objTrans.GetRandomAlphaNumericStringForTransactionActivity("PROLOG", DateTime.Now);
            //objUserHRProfile.RemoteIP = message.RemoteIpAddress;
            string objUserHRProfileJson = JsonConvert.SerializeObject(objUserHRProfile); ;
            return _stringCompression.Zip(objUserHRProfileJson);
        }

     
        public async Task<string> GetHRAPITokenFromClaim()
        {
            try
            {
                var claim = _contextAccessor.HttpContext.User.Identity as ClaimsIdentity;
                List<Claim> listClaims = (List<Claim>)claim.Claims;
                var strapitokenzipped = listClaims.Find(c => c.Type == "apitokenJson").Value;

                var unzippedapitoken = _stringCompression.UnZip(strapitokenzipped);

                dynamic dynamicApi = JsonConvert.DeserializeObject(unzippedapitoken);

                var apitoken = dynamicApi.access_token.ToString();

                return apitoken;
            }
            catch (Exception es)
            {
                return "";
            }
        }

        public async Task<string> GetReportingReceiverListByModule(string adEmail, int moduleId, string hrTokenJsonString)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "api/Correspondence/GetReportingReceiverListByModule?adEmail=" + adEmail + "&moduleId=" + moduleId);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer",await GetHRAPITokenFromClaim());

            var response = _client.SendAsync(request).Result;
            var JsonString = await response.Content.ReadAsStringAsync();
            return JsonString;
        }

    }
}
