using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_BatchCandidateTypeMapRequest : IUseCaseRequest<Gen_BatchCandidateTypeMapResponse>
    {
        public gen_batchcandidatetypemapEntity Objgen_batchcandidatetypemap { get; }
        
        public Gen_BatchCandidateTypeMapRequest(gen_batchcandidatetypemapEntity objgen_batchcandidatetypemap)
        {
            Objgen_batchcandidatetypemap = objgen_batchcandidatetypemap;
        }
    }
}
