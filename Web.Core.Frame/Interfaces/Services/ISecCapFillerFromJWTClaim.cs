using BDO.Core.Base;

using System.Security.Claims;

namespace Web.Core.Frame.Interfaces.Services
{
    public interface ISecCapFillerFromJWTClaim
    {
        SecurityCapsule SetCap(string Token, string remoteIpAddress, out System.DateTime? tokenValidFromTime, out System.DateTime? tokenValidToTime);

    }

}
