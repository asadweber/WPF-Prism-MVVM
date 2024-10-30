using BDO.Core.Base;
using BDO.Core.DataAccessObjects.HRDomainModel;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using Web.Core.Frame.Interfaces.Services;

namespace Web.Api.Infrastructure.Services
{
    internal sealed class SecCapFillerFromJWTClaim : ISecCapFillerFromJWTClaim
    {
        private readonly IConfiguration _config;
        private readonly IJwtTokenValidator _ijwttokenvalidator;
        internal SecCapFillerFromJWTClaim(IConfiguration config,
            IJwtTokenValidator ijwttokenvalidator)
        {
            _config = config;
            _ijwttokenvalidator = ijwttokenvalidator;
        }

        public SecurityCapsule SetCap(string Token, string remoteIpAddress, out System.DateTime? tokenValidFromTime, out System.DateTime? tokenValidToTime)
        {
            ClaimsPrincipal claims = _ijwttokenvalidator.GetPrincipalFromToken(Token);
            tokenValidFromTime = _ijwttokenvalidator.GetValidFromTimeFromToken(Token);
            tokenValidToTime = _ijwttokenvalidator.GetValidToTimeFromToken(Token);

            SecurityCapsule objSecCap = new SecurityCapsule();
            DateTime dt = DateTime.Now;
            objSecCap.transid = claims.FindFirst(x => x.Type == "TransID").Value;
            objSecCap.createdbyusername = claims.FindFirst(x => x.Type == "id").Value;
            objSecCap.createddate = dt;
            objSecCap.updatedbyusername = claims.FindFirst(x => x.Type == "id").Value;
            objSecCap.updateddate = dt;
            objSecCap.ipaddress = remoteIpAddress;
            objSecCap.tokenValidFromTime = tokenValidFromTime;
            objSecCap.tokenValidToTime = tokenValidToTime;

            return objSecCap;
        }

        public SecurityCapsule SetCap(GetMilShortInfoByBasicMilEntity hrprofile)
        {

            SecurityCapsule objSecCap = new SecurityCapsule();
            DateTime dt = DateTime.Now;
            objSecCap.transid = hrprofile.TransID;
            objSecCap.createdbyusername = hrprofile.fullname;
            objSecCap.createddate = dt;
            objSecCap.updatedbyusername = hrprofile.fullname;
            objSecCap.updateddate = dt;
            objSecCap.ipaddress = hrprofile.RemoteIP;
            //objSecCap.tokenValidFromTime = tokenValidFromTime;
            //objSecCap.tokenValidToTime = tokenValidToTime;

            return objSecCap;
        }
    }
}
