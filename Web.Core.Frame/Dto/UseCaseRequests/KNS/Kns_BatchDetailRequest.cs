using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Kns_BatchDetailRequest : IUseCaseRequest<Kns_BatchDetailResponse>
    {
        public kns_batchdetailEntity Objkns_batchdetail { get; }
        
        public Kns_BatchDetailRequest(kns_batchdetailEntity objkns_batchdetail)
        {
            Objkns_batchdetail = objkns_batchdetail;
        }
    }
}
