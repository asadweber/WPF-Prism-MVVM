using BDO.Core.DataAccessObjects.ExtendedEntities;
using System.Collections.Generic;
using Web.Core.Frame.Interfaces;
 
namespace Web.Core.Frame.Dto.UseCaseResponses
{
    public class LoginResponse : UseCaseResponseMessage
    {
        public AccessToken AccessToken { get; }
        public string RefreshToken { get; }
        public IEnumerable<Error> Errors { get; }
        public string accessToken { get; }
        public int expiresIn { get; }

        public LoginResponse(IEnumerable<Error> errors, bool success = false, string message = null) : base(success, message)
        {
            Errors = errors;
        }
         
        public LoginResponse(AccessToken accessToken, string refreshToken, bool success = false, string message = null) : base(success, message)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;
        }

        public LoginResponse(bool ss, AccessToken Token, string refreshToken, bool success = false, string message = null) : base(success, message)
        {
            accessToken = Token.Token;
            expiresIn = Token.ExpiresIn;
            RefreshToken = refreshToken;
        }
    }
}
