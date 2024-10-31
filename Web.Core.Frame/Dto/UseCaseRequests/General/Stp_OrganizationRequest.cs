using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Stp_OrganizationRequest : IUseCaseRequest<Stp_OrganizationResponse>
    {
        public stp_organizationEntity Objstp_organization { get; }
        
        public Stp_OrganizationRequest(stp_organizationEntity objstp_organization)
        {
            Objstp_organization = objstp_organization;
        }
    }
}
