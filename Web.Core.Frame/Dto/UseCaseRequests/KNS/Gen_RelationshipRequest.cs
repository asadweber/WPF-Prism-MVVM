using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_RelationshipRequest : IUseCaseRequest<Gen_RelationshipResponse>
    {
        public gen_relationshipEntity Objgen_relationship { get; }
        
        public Gen_RelationshipRequest(gen_relationshipEntity objgen_relationship)
        {
            Objgen_relationship = objgen_relationship;
        }
    }
}
