using Web.Core.Frame.RequestResponse.UseCaseResponses;
using Web.Core.Frame.Interfaces;
using BDO.Core.DataAccessObjects.SecurityModels;
using BDO.Core.DataAccessObjects.ExtendedEntities;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public class Auth_Request : IUseCaseRequest<Auth_Response>
    {
        public PACIAuthRequestEntity Obj_PACIAuthRequest { get; }

        public owin_userEntity Obj_owin_user { get; }
        public string RemoteIpAddress { get; }

        public Auth_Request(owin_userEntity obj_owin_user)
        {
            Obj_owin_user = obj_owin_user;
        }
        public Auth_Request(PACIAuthRequestEntity obj_PACIAuthRequest)
        {
            Obj_PACIAuthRequest = obj_PACIAuthRequest;
        }
    }
}
