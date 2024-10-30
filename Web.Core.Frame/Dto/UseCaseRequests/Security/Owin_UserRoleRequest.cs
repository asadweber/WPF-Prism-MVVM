using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Owin_UserRoleRequest : IUseCaseRequest<Owin_UserRoleResponse>
    {
        public owin_userroleEntity Objowin_userrole { get; }
        
        public Owin_UserRoleRequest(owin_userroleEntity objowin_userrole)
        {
            Objowin_userrole = objowin_userrole;
        }
    }
}
