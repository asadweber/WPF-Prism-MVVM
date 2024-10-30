using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Owin_UserRolesRequest : IUseCaseRequest<Owin_UserRolesResponse>
    {
        public owin_userrolesEntity Objowin_userroles { get; }
        
        public Owin_UserRolesRequest(owin_userrolesEntity objowin_userroles)
        {
            Objowin_userroles = objowin_userroles;
        }
    }
}
