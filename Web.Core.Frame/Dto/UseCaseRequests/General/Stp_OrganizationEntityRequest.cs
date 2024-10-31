using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Stp_OrganizationEntityRequest : IUseCaseRequest<Stp_OrganizationEntityResponse>
    {
        public stp_organizationentityEntity Objstp_organizationentity { get; }
        
        public Stp_OrganizationEntityRequest(stp_organizationentityEntity objstp_organizationentity)
        {
            Objstp_organizationentity = objstp_organizationentity;
        }
    }
}
