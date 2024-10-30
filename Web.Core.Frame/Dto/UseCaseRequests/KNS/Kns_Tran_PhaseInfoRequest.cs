using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Kns_Tran_PhaseInfoRequest : IUseCaseRequest<Kns_Tran_PhaseInfoResponse>
    {
        public kns_tran_phaseinfoEntity Objkns_tran_phaseinfo { get; }
        
        public Kns_Tran_PhaseInfoRequest(kns_tran_phaseinfoEntity objkns_tran_phaseinfo)
        {
            Objkns_tran_phaseinfo = objkns_tran_phaseinfo;
        }
    }
}
