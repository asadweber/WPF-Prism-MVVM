using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Kns_BatchRequest : IUseCaseRequest<Kns_BatchResponse>
    {
        public kns_batchEntity Objkns_batch { get; }
        
        public Kns_BatchRequest(kns_batchEntity objkns_batch)
        {
            Objkns_batch = objkns_batch;
        }
    }
}
