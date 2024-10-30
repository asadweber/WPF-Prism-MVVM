using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_PhasesRequest : IUseCaseRequest<Gen_PhasesResponse>
    {
        public gen_phasesEntity Objgen_phases { get; }
        
        public Gen_PhasesRequest(gen_phasesEntity objgen_phases)
        {
            Objgen_phases = objgen_phases;
        }
    }
}
