using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_BatchCandidateReqFileRequest : IUseCaseRequest<Gen_BatchCandidateReqFileResponse>
    {
        public gen_batchcandidatereqfileEntity Objgen_batchcandidatereqfile { get; }
        
        public Gen_BatchCandidateReqFileRequest(gen_batchcandidatereqfileEntity objgen_batchcandidatereqfile)
        {
            Objgen_batchcandidatereqfile = objgen_batchcandidatereqfile;
        }
    }
}
