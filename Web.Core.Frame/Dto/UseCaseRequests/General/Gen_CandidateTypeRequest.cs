using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_CandidateTypeRequest : IUseCaseRequest<Gen_CandidateTypeResponse>
    {
        public gen_candidatetypeEntity Objgen_candidatetype { get; }
        
        public Gen_CandidateTypeRequest(gen_candidatetypeEntity objgen_candidatetype)
        {
            Objgen_candidatetype = objgen_candidatetype;
        }
    }
}
