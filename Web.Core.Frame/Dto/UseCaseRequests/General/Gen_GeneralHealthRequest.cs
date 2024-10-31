using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_GeneralHealthRequest : IUseCaseRequest<Gen_GeneralHealthResponse>
    {
        public gen_generalhealthEntity Objgen_generalhealth { get; }
        
        public Gen_GeneralHealthRequest(gen_generalhealthEntity objgen_generalhealth)
        {
            Objgen_generalhealth = objgen_generalhealth;
        }
    }
}
