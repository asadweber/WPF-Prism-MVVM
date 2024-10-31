using BDO.Core.DataAccessObjects.ExtendedEntities;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses
{
    public class ExchangeRefreshTokenResponse : UseCaseResponseMessage
    {
        public AccessToken AccessToken { get; }
        public string RefreshToken { get; }
        public string accessToken { get; }
        public int expiresIn { get; }


        public ExchangeRefreshTokenResponse(bool success = false, string message = null) : base(success, message)
        {
        }

        public ExchangeRefreshTokenResponse(AccessToken accessToken, string refreshToken, bool success = false, string message = null) : base(success, message)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;
        }

        public ExchangeRefreshTokenResponse(string Token, int ExpiresIn, string refreshToken, bool success = false, string message = null) : base(success, message)
        {
            accessToken = Token;
            expiresIn = ExpiresIn;
            RefreshToken = refreshToken;
        }

    }
}
