using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Kns_Gen_ReasonRequest : IUseCaseRequest<Kns_Gen_ReasonResponse>
    {
        public kns_gen_reasonEntity Objkns_gen_reason { get; }
        
        public Kns_Gen_ReasonRequest(kns_gen_reasonEntity objkns_gen_reason)
        {
            Objkns_gen_reason = objkns_gen_reason;
        }
    }
}
