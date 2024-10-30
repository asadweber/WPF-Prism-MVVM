using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Kns_Gen_DecisionTypeRequest : IUseCaseRequest<Kns_Gen_DecisionTypeResponse>
    {
        public kns_gen_decisiontypeEntity Objkns_gen_decisiontype { get; }
        
        public Kns_Gen_DecisionTypeRequest(kns_gen_decisiontypeEntity objkns_gen_decisiontype)
        {
            Objkns_gen_decisiontype = objkns_gen_decisiontype;
        }
    }
}
