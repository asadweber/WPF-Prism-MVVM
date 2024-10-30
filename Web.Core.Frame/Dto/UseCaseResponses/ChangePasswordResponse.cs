using BDO.Core.DataAccessObjects.ExtendedEntities;
using System.Collections.Generic;
using Web.Core.Frame.Interfaces;
 
namespace Web.Core.Frame.Dto.UseCaseResponses
{
    public class ChangePasswordResponse : UseCaseResponseMessage
    {
        public AccessToken AccessToken { get; }
        public string RefreshToken { get; }
        public Error Errors { get; }
        public AjaxResponse _ajaxresponse { get; }


        public ChangePasswordResponse(Error errors, bool success = false, string message = null) : base(success, message)
        {
            Errors = errors;
        }


        public ChangePasswordResponse(AccessToken accessToken, string refreshToken, bool success = false, string message = null) : base(success, message)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;
        }
        public ChangePasswordResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }
    }
}
