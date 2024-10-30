using BDO.Core.Base;
using BDO.Core.DataAccessObjects.HRDomainModel;
using System.Security.Claims;

namespace Web.Core.Frame.Interfaces.Services
{
    public interface ISecCapFillerFromJWTClaim
    {
        SecurityCapsule SetCap(string Token, string remoteIpAddress, out System.DateTime? tokenValidFromTime, out System.DateTime? tokenValidToTime);

        SecurityCapsule SetCap(GetMilShortInfoByBasicMilEntity hrprofile);
    }

}
