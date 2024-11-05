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
            _jwtTokenValidator = jwtTokenValidator;

            HttpClient client = _IHttpClienFactory.CreateClient();
           // client.BaseAddress = new Uri(_kNSServiceSettings.WebApiAddress);
            client.DefaultRequestHeaders.Add("Accept", "application/vnd.github.v3+json");
            client.DefaultRequestHeaders.Add("User-Agent", "CoreCors");
            _client = client;
        }

    }
}
