using BDO.Core.DataAccessObjects.ExtendedEntities;
using System.Collections.Generic;
using Web.Core.Frame.Interfaces;
 
namespace Web.Core.Frame.Dto.UseCaseResponses
{
    public class LoginResponse : UseCaseResponseMessage
    {
        public AccessToken AccessToken { get; }
        public IEnumerable<Error> Errors { get; }

        public LoginResponse(IEnumerable<Error> errors, bool success = false, string message = null) : base(success, message)
        {
            Errors = errors;
        }
         
        public LoginResponse(AccessToken accessToken, bool success = false, string message = null) : base(success, message)
        {
            AccessToken = accessToken;
        }

    }
}
