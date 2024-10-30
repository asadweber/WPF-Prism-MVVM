 
using System.Security.Claims;

namespace Web.Core.Frame.Interfaces.Services
{
    public interface IJwtTokenValidator
    {
        ClaimsPrincipal GetPrincipalFromToken(string token);

        System.DateTime? GetValidFromTimeFromToken(string token);

        System.DateTime? GetValidToTimeFromToken(string token);

        string GetJsonHRApiTokenFromToken(string token);

        string GetJsonHRProfileObjectFromToken();
    }
}
