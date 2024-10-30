using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces.Services;
using Web.Api.Infrastructure.Interfaces;
using System.Security.Cryptography;
using Web.Core.Frame.Helpers;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using System.Collections.Generic;
using BDO.Core.DataAccessObjects.SecurityModels;


namespace Web.Api.Infrastructure.Auth
{
    internal sealed class JwtFactory : IJwtFactory
    {
        private readonly IJwtTokenHandler _jwtTokenHandler;
        private readonly JwtIssuerOptions _jwtOptions;
        private readonly IStringCompression _stringCompression;

        internal JwtFactory(IJwtTokenHandler jwtTokenHandler, IOptions<JwtIssuerOptions> jwtOptions
            , IStringCompression stringCompression)
        {
            _jwtTokenHandler = jwtTokenHandler;
            _jwtOptions = jwtOptions.Value;
            _stringCompression = stringCompression;
            ThrowIfInvalidOptions(_jwtOptions);
        }

        public string GenerateToken(int size = 32)
        {
            var randomNumber = new byte[size];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }

        public async Task<AccessToken> GenerateEncodedToken(owin_userEntity user, List<string> usrorle, string hrTokenJsonString = null, string hrprofileJsonString = null)
        {
            AppConfig.HelperClasses.transactioncodeGen objTran = new AppConfig.HelperClasses.transactioncodeGen();
            var TransID = objTran.GetRandomAlphaNumericStringForTransactionActivity("TOK", DateTime.Now);
            var identity = GenerateClaimsIdentity(user.userid.ToString(), user.username, usrorle, _jwtOptions.Issuer);
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(JwtRegisteredClaimNames.Sub, user.username));
            claims.Add(new Claim(JwtRegisteredClaimNames.Iat, ToUnixEpochDate(_jwtOptions.IssuedAt).ToString(), ClaimValueTypes.Integer64));
            claims.Add(new Claim("TransID", TransID));
            claims.Add(new Claim("CreatedByUserName", user.username)); 
            claims.Add(new Claim("UpdatedByUserName", user.username));
            claims.Add(new Claim("username", user.username));
            claims.Add(new Claim(JwtRegisteredClaimNames.Jti, await _jwtOptions.JtiGenerator()));
            claims.Add(new Claim("IsBlocked", user.locked.GetValueOrDefault(true) == true ? "1" : "0"));
            claims.Add(new Claim("Approved", user.approved.GetValueOrDefault(false) == false ? "0" : "1"));
            claims.Add(new Claim("IssuedAt", _jwtOptions.IssuedAt.ToString()));
            claims.Add(new Claim("id", user.userid.GetValueOrDefault().ToString()));
            claims.Add(new Claim("masteruserid", user.masteruserid.GetValueOrDefault().ToString()));

            foreach (Claim cl in identity.Claims)
            {
                claims.Add(cl);
            }

            if (!string.IsNullOrEmpty(hrTokenJsonString))
            {
                claims.Add(new Claim("hrapitoken", _stringCompression.Zip(hrTokenJsonString)));
            }
            if (!string.IsNullOrEmpty(hrprofileJsonString))
            {
                claims.Add(new Claim("hrprofile", hrprofileJsonString));
            }

            // Create the JWT security token and encode it.
            var jwt = new JwtSecurityToken(
                _jwtOptions.Issuer,
                _jwtOptions.Audience,
                claims,
                _jwtOptions.NotBefore,
                _jwtOptions.Expiration,
                _jwtOptions.SigningCredentials);



            return new AccessToken(_jwtTokenHandler.WriteToken(jwt), (int)_jwtOptions.ValidFor.TotalSeconds);
        }


        private static ClaimsIdentity GenerateClaimsIdentity(string id, string userName, List<string> usrrole, string strIssueer)
        {
            GenericIdentity claims = new GenericIdentity(userName, "Token");
            claims.AddClaim(new Claim(ClaimTypes.NameIdentifier, id));
            foreach (var item in usrrole)
            {
                claims.AddClaim(new Claim(ClaimTypes.Role, item));
            }
            return claims;
        }

        /// <returns>Date converted to seconds since Unix epoch (Jan 1, 1970, midnight UTC).</returns>
        private static long ToUnixEpochDate(DateTime date)
          => (long)Math.Round((date.ToUniversalTime() -
                               new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero))
                              .TotalSeconds);

        private static void ThrowIfInvalidOptions(JwtIssuerOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            if (options.ValidFor <= TimeSpan.Zero)
            {
                throw new ArgumentException("Must be a non-zero TimeSpan.", nameof(JwtIssuerOptions.ValidFor));
            }

            if (options.SigningCredentials == null)
            {
                throw new ArgumentNullException(nameof(JwtIssuerOptions.SigningCredentials));
            }

            if (options.JtiGenerator == null)
            {
                throw new ArgumentNullException(nameof(JwtIssuerOptions.JtiGenerator));
            }
        }
    }
}
