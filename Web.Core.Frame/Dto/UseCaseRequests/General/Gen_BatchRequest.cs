using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_BatchRequest : IUseCaseRequest<Gen_BatchResponse>
    {
        public gen_batchEntity Objgen_batch { get; }
        
        public Gen_BatchRequest(gen_batchEntity objgen_batch)
        {
            Objgen_batch = objgen_batch;
        }
    }
}
