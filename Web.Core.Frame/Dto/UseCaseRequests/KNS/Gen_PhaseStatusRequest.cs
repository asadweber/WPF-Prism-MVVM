using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_PhaseStatusRequest : IUseCaseRequest<Gen_PhaseStatusResponse>
    {
        public gen_phasestatusEntity Objgen_phasestatus { get; }
        
        public Gen_PhaseStatusRequest(gen_phasestatusEntity objgen_phasestatus)
        {
            Objgen_phasestatus = objgen_phasestatus;
        }
    }
}
