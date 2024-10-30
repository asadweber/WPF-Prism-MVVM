using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;


namespace Web.Api.Infrastructure.Interfaces
{
    public interface IJwtTokenHandler
    {
        string WriteToken(JwtSecurityToken jwt);
        ClaimsPrincipal ValidateToken(string token, TokenValidationParameters tokenValidationParameters);

        System.DateTime? tokenValidFromTime(string token, TokenValidationParameters tokenValidationParameters);

        System.DateTime? tokenValidToTime(string token, TokenValidationParameters tokenValidationParameters);
    }
}
