using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Kns_Gen_ReasonTypeRequest : IUseCaseRequest<Kns_Gen_ReasonTypeResponse>
    {
        public kns_gen_reasontypeEntity Objkns_gen_reasontype { get; }
        
        public Kns_Gen_ReasonTypeRequest(kns_gen_reasontypeEntity objkns_gen_reasontype)
        {
            Objkns_gen_reasontype = objkns_gen_reasontype;
        }
    }
}
