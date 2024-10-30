using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Kns_BatchOrderRequest : IUseCaseRequest<Kns_BatchOrderResponse>
    {
        public kns_batchorderEntity Objkns_batchorder { get; }
        
        public Kns_BatchOrderRequest(kns_batchorderEntity objkns_batchorder)
        {
            Objkns_batchorder = objkns_batchorder;
        }
    }
}
