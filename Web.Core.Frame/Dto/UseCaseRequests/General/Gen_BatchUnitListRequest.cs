using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_BatchUnitListRequest : IUseCaseRequest<Gen_BatchUnitListResponse>
    {
        public gen_batchunitlistEntity Objgen_batchunitlist { get; }
        
        public Gen_BatchUnitListRequest(gen_batchunitlistEntity objgen_batchunitlist)
        {
            Objgen_batchunitlist = objgen_batchunitlist;
        }
    }
}
