using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Owin_RoleRequest : IUseCaseRequest<Owin_RoleResponse>
    {
        public owin_roleEntity Objowin_role { get; }
        
        public Owin_RoleRequest(owin_roleEntity objowin_role)
        {
            Objowin_role = objowin_role;
        }
    }
}
