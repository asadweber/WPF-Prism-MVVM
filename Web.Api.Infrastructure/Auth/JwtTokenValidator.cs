using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Web.Core.Frame.Interfaces.Services;
using Web.Api.Infrastructure.Interfaces;
using Microsoft.Extensions.Configuration;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace Web.Api.Infrastructure.Auth
{
    internal sealed class JwtTokenValidator : IJwtTokenValidator
    {
        private readonly IJwtTokenHandler _jwtTokenHandler;
        private readonly IConfiguration _config;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IStringCompression _stringCompression;

        internal JwtTokenValidator(IJwtTokenHandler jwtTokenHandler, IConfiguration config, IHttpContextAccessor contextAccessor, IStringCompression stringCompression)
        {
            _jwtTokenHandler = jwtTokenHandler;
            _config = config;
            _contextAccessor = contextAccessor;
            _stringCompression = stringCompression;
        }
         
        public ClaimsPrincipal GetPrincipalFromToken(string token)
        {
            var authSettings = _config.GetSection(nameof(AuthSettings)).Get<AuthSettings>();
            var signingKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(Encoding.ASCII.GetBytes(authSettings.SecretKey));
            var jwtIssuerOptions = _config.GetSection(nameof(JwtIssuerOptions)).Get<JwtIssuerOptions>();

            return _jwtTokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = jwtIssuerOptions.Issuer,

                ValidateAudience = true,
                ValidAudience = jwtIssuerOptions.Audience,

                ValidateIssuerSigningKey = true,
                IssuerSigningKey = signingKey,

                //RequireExpirationTime = true,
                ValidateLifetime = true
            });
        }

        public System.DateTime? GetValidFromTimeFromToken(string token)
        {
            var authSettings = _config.GetSection(nameof(AuthSettings)).Get<AuthSettings>();
            var signingKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(Encoding.ASCII.GetBytes(authSettings.SecretKey));
            var jwtIssuerOptions = _config.GetSection(nameof(JwtIssuerOptions)).Get<JwtIssuerOptions>();


            return _jwtTokenHandler.tokenValidFromTime(token, new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = jwtIssuerOptions.Issuer,

                ValidateAudience = true,
                ValidAudience = jwtIssuerOptions.Audience,

                ValidateIssuerSigningKey = true,
                IssuerSigningKey = signingKey,

                //RequireExpirationTime = true,
                ValidateLifetime = true
            });
        }

        public System.DateTime? GetValidToTimeFromToken(string token)
        {
            var authSettings = _config.GetSection(nameof(AuthSettings)).Get<AuthSettings>();
            var signingKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(Encoding.ASCII.GetBytes(authSettings.SecretKey));
            var jwtIssuerOptions = _config.GetSection(nameof(JwtIssuerOptions)).Get<JwtIssuerOptions>();


            return _jwtTokenHandler.tokenValidToTime(token, new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = jwtIssuerOptions.Issuer,

                ValidateAudience = true,
                ValidAudience = jwtIssuerOptions.Audience,

                ValidateIssuerSigningKey = true,
                IssuerSigningKey = signingKey,

                //RequireExpirationTime = true,
                ValidateLifetime = true
            });
        }

        public string GetJsonHRApiTokenFromToken(string token)
        {
            string jsonobject = string.Empty;
            var authSettings = _config.GetSection(nameof(AuthSettings)).Get<AuthSettings>();
            var signingKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(Encoding.ASCII.GetBytes(authSettings.SecretKey));
            var jwtIssuerOptions = _config.GetSection(nameof(JwtIssuerOptions)).Get<JwtIssuerOptions>();

            return _jwtTokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = jwtIssuerOptions.Issuer,

                ValidateAudience = true,
                ValidAudience = jwtIssuerOptions.Audience,

                ValidateIssuerSigningKey = true,
                IssuerSigningKey = signingKey,

                //RequireExpirationTime = true,
                ValidateLifetime = true
            }).FindFirst(x => x.Type == "hrprofile").Value;

        }


        public string GetJsonHRProfileObjectFromToken()
        {
            string jsonobject = string.Empty;

            var claim = _contextAccessor.HttpContext.User.Identity as ClaimsIdentity;
            List<Claim> listClaims =(List<Claim>)claim.Claims;
            var strZipedprofile=listClaims.Find(c => c.Type == "profileJson").Value;
            var unzipprofile= ((_stringCompression.UnZip(strZipedprofile)));

            return unzipprofile;

        }
    }
}
