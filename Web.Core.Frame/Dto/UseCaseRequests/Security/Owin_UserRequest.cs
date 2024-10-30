using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Owin_UserRequest : IUseCaseRequest<Owin_UserResponse>
    {
        public owin_userEntity Objowin_user { get; }
        
        public Owin_UserRequest(owin_userEntity objowin_user)
        {
            Objowin_user = objowin_user;
        }
    }
}
