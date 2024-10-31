using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Stp_OrganizationEntityTypeRequest : IUseCaseRequest<Stp_OrganizationEntityTypeResponse>
    {
        public stp_organizationentitytypeEntity Objstp_organizationentitytype { get; }
        
        public Stp_OrganizationEntityTypeRequest(stp_organizationentitytypeEntity objstp_organizationentitytype)
        {
            Objstp_organizationentitytype = objstp_organizationentitytype;
        }
    }
}
