using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Kns_Tran_PhaseInfoNotificationRequest : IUseCaseRequest<Kns_Tran_PhaseInfoNotificationResponse>
    {
        public kns_tran_phaseinfonotificationEntity Objkns_tran_phaseinfonotification { get; }
        
        public Kns_Tran_PhaseInfoNotificationRequest(kns_tran_phaseinfonotificationEntity objkns_tran_phaseinfonotification)
        {
            Objkns_tran_phaseinfonotification = objkns_tran_phaseinfonotification;
        }
    }
}
