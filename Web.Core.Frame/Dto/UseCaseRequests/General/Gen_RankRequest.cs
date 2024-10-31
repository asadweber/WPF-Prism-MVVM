using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_RankRequest : IUseCaseRequest<Gen_RankResponse>
    {
        public gen_rankEntity Objgen_rank { get; }
        
        public Gen_RankRequest(gen_rankEntity objgen_rank)
        {
            Objgen_rank = objgen_rank;
        }
    }
}
