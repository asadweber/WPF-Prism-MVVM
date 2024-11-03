using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KAF.Service.Proxy.Client
{
    public abstract class HttpClientBase : IApiClientBase
    {
        protected readonly HttpClient _httpClient;
        private string _baseUrl;
        private string _bearerToken;

        public HttpClientBase(string baseUrl, System.Net.Http.HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            BaseUrl = baseUrl;
        }

        public string BaseUrl
        {
            get => _baseUrl;
            set
            {
                _baseUrl = value;
                if (!string.IsNullOrEmpty(_baseUrl) && !_baseUrl.EndsWith("/"))
                    _baseUrl += '/';
            }
        }

        public void SetBearerToken(string token)
        {
            _bearerToken = token;
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _bearerToken);
        }
    }
}
