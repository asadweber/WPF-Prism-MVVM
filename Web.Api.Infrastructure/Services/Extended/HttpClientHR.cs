using BDO.Core.DataAccessObjects.CommonEntities;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.HRDomainModel;
using BDO.DataAccessObjects.ApiModels;
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

    internal sealed partial class HttpClientHR 
    {
        #region Organization And Position API

        /// <summary>
        /// Gets all authority.
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetAllAuthority()
        {
            string hrapitoken = await GetHRAPITokenFromClaim();
           
            var request = new HttpRequestMessage(HttpMethod.Get, "api/Unit/GetAuthorityEntity");
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", hrapitoken);

            var response = _client.SendAsync(request).Result;
            var JsonString = await response.Content.ReadAsStringAsync();
            return _stringCompression.Zip(JsonString);
            //return Task.Run(() => HttpHrApiInvoke.GetAsync<List<OrganizationEntity>>("api/Unit/GetAuthorityEntity")).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the directorate by authority.
        /// </summary>
        /// <param name="authorityId">The authority identifier.</param>
        /// <returns></returns>
        public async Task<string> GetDirectorateByAuthority(long authorityId)
        {
            string hrapitoken = await GetHRAPITokenFromClaim();

            var request = new HttpRequestMessage(HttpMethod.Get, "api/Unit/GetAuthorityFirstLevel?keyEntityKey=" + authorityId);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", hrapitoken);

            var response = _client.SendAsync(request).Result;
            var JsonString = await response.Content.ReadAsStringAsync();
            return _stringCompression.Zip(JsonString);

            //var para = new Dictionary<string, string>
            //    {{"keyEntityKey", $"{authorityId}"}};

            //return Task.Run(() => HttpHrApiInvoke.GetAsync<List<OrganizationEntity>>("api/Unit/GetAuthorityFirstLevel", para)).GetAwaiter().GetResult();

        }

        /// <summary>
        /// Gets the parent organization.
        /// </summary>
        /// <param name="entityKey">The entity key.</param>
        /// <returns></returns>
        public async Task<string> GetParentOrganization(long? entityKey)
        {
            string _entityKey = string.Empty;
            if (entityKey.HasValue) _entityKey = entityKey.Value.ToString();
            string hrapitoken = await GetHRAPITokenFromClaim();

            var request = new HttpRequestMessage(HttpMethod.Get, "api/Correspondence/getunitParentKeyforReport?keyEntityKey=" + _entityKey);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", hrapitoken);

            var response = _client.SendAsync(request).Result;
            var JsonString = await response.Content.ReadAsStringAsync();
            return _stringCompression.Zip(JsonString);

            //var para = new Dictionary<string, string>
            //{
            //    {"keyEntityKey", entityKey.HasValue?entityKey.Value.ToString():string.Empty},
            //};

            //return Task.Run(() => HttpHrApiInvoke.GetAsync<List<OrganizationEntity>>("api/Correspondence/getunitParentKeyforReport", para)).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the organization.
        /// </summary>
        /// <param name="entityKey">The entity key.</param>
        /// <param name="keyEntityName">Name of the key entity.</param>
        /// <returns></returns>
        public async Task<string> GetOrganization(long? entityKey, string keyEntityName)
        {
            string _entityKey = string.Empty;
            string _entityKeyName = string.Empty;
            if (entityKey.HasValue) _entityKey = entityKey.Value.ToString();
            if (!string.IsNullOrEmpty(keyEntityName)) _entityKeyName = keyEntityName;

            string hrapitoken = await GetHRAPITokenFromClaim();

            var request = new HttpRequestMessage(HttpMethod.Get, "api/Correspondence/getunitforReport?keyEntityKey=" + _entityKey + "&keyEntityName=" + _entityKeyName);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", hrapitoken);

            var response = _client.SendAsync(request).Result;
            var JsonString = await response.Content.ReadAsStringAsync();
            return _stringCompression.Zip(JsonString);

            //var para = new Dictionary<string, string>
            //{
            //    {"keyEntityKey", entityKey.HasValue?entityKey.Value.ToString():string.Empty},
            //    {"keyEntityName", keyEntityName}
            //};
            //return Task.Run(() => HttpHrApiInvoke.GetAsync<List<OrganizationEntity>>("api/Correspondence/getunitforReport", para)).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets all position.
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetAllPosition()
        {
            string hrapitoken = await GetHRAPITokenFromClaim();

            var request = new HttpRequestMessage(HttpMethod.Get, "api/Correspondence/GetAllHeightOfficialPosition");
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", hrapitoken);

            var response = _client.SendAsync(request).Result;
            var JsonString = await response.Content.ReadAsStringAsync();
            return _stringCompression.Zip(JsonString);

            //return Task.Run(() => HttpHrApiInvoke.GetAsync<List<OrganizationAssignPosition>>("api/Correspondence/GetAllHeightOfficialPosition")).GetAwaiter().GetResult();
        }


        /// <summary>
        /// Gets the organization wise assign position.
        /// </summary>
        /// <param name="entityKey">The entity key.</param>
        /// <returns></returns>
        public async Task<string> GetOrganizationWiseAssignPosition(long? entityKey)
        {
            string _entityKey = string.Empty;
            if (entityKey.HasValue) _entityKey = entityKey.Value.ToString();
            string hrapitoken = await GetHRAPITokenFromClaim();

            var request = new HttpRequestMessage(HttpMethod.Get, "api/Correspondence/GetOrganizationWiseAssignPosition?entitykey=" + _entityKey);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", hrapitoken);

            var response = _client.SendAsync(request).Result;
            var JsonString = await response.Content.ReadAsStringAsync();
            return _stringCompression.Zip(JsonString);

            //var para = new Dictionary<string, string>
            //{
            //    {"entitykey", entityKey.HasValue?entityKey.Value.ToString():string.Empty}
            //};
            //return Task.Run(() => HttpHrApiInvoke.GetAsync<List<OrganizationAssignPosition>>("api/Correspondence/GetOrganizationWiseAssignPosition", para)).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the authority logo.
        /// </summary>
        /// <param name="entityKey">The entity key.</param>
        /// <returns></returns>
        public async Task<stp_organizationentityEntity> GetAuthorityLogo(long? entityKey)
        {
            string _entityKey = string.Empty;
            if (entityKey.HasValue) _entityKey = entityKey.Value.ToString();
            string hrapitoken = await GetHRAPITokenFromClaim();

            var request = new HttpRequestMessage(HttpMethod.Get, "api/Correspondence/GetAuthorityLogo?entitykey=" + _entityKey);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", hrapitoken);

            var response = _client.SendAsync(request).Result;
            var JsonString = await response.Content.ReadAsStringAsync();

            stp_organizationentityEntity authority = JsonConvert.DeserializeObject<stp_organizationentityEntity>(JsonString);

            return authority;

            //var para = new Dictionary<string, string>
            //{
            //    {"entitykey", entityKey.HasValue?entityKey.Value.ToString():string.Empty},
            //};
            //var authority = Task.Run(() => HttpHrApiInvoke.GetAsync<OrganizationEntity>("api/Correspondence/GetAuthorityLogo", para)).GetAwaiter().GetResult() ?? new OrganizationEntity();
            //return authority;
        }



        /// <summary>
        /// Gets the organization position hierarchy.
        /// </summary>
        /// <param name="entityKey">The entity key.</param>
        /// <returns></returns>
        public async Task<string> GetOrganizationPositionHierarchy(long? entityKey)
        {
            string _entityKey = string.Empty;
            if (entityKey.HasValue) _entityKey = entityKey.Value.ToString();
            string hrapitoken = await GetHRAPITokenFromClaim();

            var request = new HttpRequestMessage(HttpMethod.Get, "api/Correspondence/GetOrganizationPositionHierarchy?entitykey=" + _entityKey);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", hrapitoken);

            var response = _client.SendAsync(request).Result;
            var JsonString = await response.Content.ReadAsStringAsync();
            return _stringCompression.Zip(JsonString);

            //var para = new Dictionary<string, string>
            //{
            //    {"entitykey", entityKey.HasValue?entityKey.Value.ToString():string.Empty}
            //};
            //return Task.Run(() => HttpHrApiInvoke.GetAsync<List<PositionReportingHierarchy>>("api/Correspondence/GetOrganizationPositionHierarchy", para)).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the organization position hierarchy including child.
        /// </summary>
        /// <param name="entityKey">The entity key.</param>
        /// <returns></returns>
        public async Task<string> GetOrganizationPositionHierarchyIncludingChild(long? entityKey)
        {
            string _entityKey = string.Empty;
            if (entityKey.HasValue) _entityKey = entityKey.Value.ToString();
            string hrapitoken = await GetHRAPITokenFromClaim();

            var request = new HttpRequestMessage(HttpMethod.Get, "api/Correspondence/GetOrganizationPositionHierarchyIncludingChildy?entitykey=" + _entityKey);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", hrapitoken);

            var response = _client.SendAsync(request).Result;
            var JsonString = await response.Content.ReadAsStringAsync();
            return _stringCompression.Zip(JsonString);

            //var para = new Dictionary<string, string>
            //{
            //    {"entitykey", entityKey.HasValue?entityKey.Value.ToString():string.Empty}
            //};
            //return Task.Run(() => HttpHrApiInvoke.GetAsync<List<PositionReportingHierarchy>>("api/SharePoint/GetOrganizationPositionHierarchyIncludingChild", para)).GetAwaiter().GetResult();
        }


        /// <summary>
        /// Gets all position by page.
        /// </summary>
        /// <param name="pageNum">The page number.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="search">The search.</param>
        /// <returns></returns>
        public async Task<gen_militarypossitionEntity> GetAllPositionByPage(int? pageNum, int? pageSize, string search)
        {
            string hrapitoken = await GetHRAPITokenFromClaim();

            var request = new HttpRequestMessage(HttpMethod.Get, "api/Correspondence/GetAllHeightOfficialPositionByPage?pageNum=" + pageNum + "&pageSize=" + pageSize +"&searchByPositionName=" + search);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", hrapitoken);

            var response = _client.SendAsync(request).Result;
            var JsonString = await response.Content.ReadAsStringAsync();

            gen_militarypossitionEntity _pagedposition = JsonConvert.DeserializeObject<gen_militarypossitionEntity>(JsonString);

            return _pagedposition;


            //var para = new Dictionary<string, string>
            //{
            //    {"pageNum", pageNum.HasValue?pageNum.Value.ToString():string.Empty},
            //    {"pageSize", pageSize.HasValue?pageSize.Value.ToString():string.Empty},
            //    {"searchByPositionName","%"+search+"%"}

            //};
            ////GetAllHeightOfficialPositionByPage
            //return Task.Run(() => HttpHrApiInvoke.GetAsync<PagedPosition>("api/SharePoint/GetAllHeightOfficialPositionByPage", para)).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets all position by identifier.
        /// </summary>
        /// <param name="positionId">The position identifier.</param>
        /// <returns></returns>
        public async Task<gen_militarypossitionEntity> GetAllPositionById(long positionId)
        {
            string hrapitoken = await GetHRAPITokenFromClaim();

            var request = new HttpRequestMessage(HttpMethod.Get, "api/Correspondence/GetAllPositionById?positionId=" + positionId.ToString());
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", hrapitoken);

            var response = _client.SendAsync(request).Result;
            var JsonString = await response.Content.ReadAsStringAsync();

            gen_militarypossitionEntity _assignpositions = JsonConvert.DeserializeObject<gen_militarypossitionEntity>(JsonString);

            return _assignpositions;
            //var para = new Dictionary<string, string>
            //{
            //    {"positionId", positionId.ToString()},
            //};

            //return Task.Run(() => HttpHrApiInvoke.GetAsync<OrganizationAssignPosition>("api/SharePoint/GetAllPositionById", para)).GetAwaiter().GetResult();
        }


        #endregion
    }
}
