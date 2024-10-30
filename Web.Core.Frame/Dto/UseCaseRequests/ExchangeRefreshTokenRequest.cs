using Web.Core.Frame.Dto.UseCaseResponses;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseRequests
{
    public class ExchangeRefreshTokenRequest : IUseCaseRequest<ExchangeRefreshTokenResponse>
    {
        public string AccessToken { get; }
        public string RefreshToken { get; }
        public string SigningKey { get; }
        public string RemoteIPAddress { get; }

        public ExchangeRefreshTokenRequest(string accessToken, string refreshToken, string signingKey,
            string remoteIPAddress)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;
            SigningKey = signingKey;
            RemoteIPAddress = remoteIPAddress;
        }
    }
}
