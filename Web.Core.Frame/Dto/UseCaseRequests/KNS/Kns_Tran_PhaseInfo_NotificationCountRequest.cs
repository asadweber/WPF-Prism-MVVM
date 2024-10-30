using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Kns_Tran_PhaseInfo_NotificationCountRequest : IUseCaseRequest<Kns_Tran_PhaseInfo_NotificationCountResponse>
    {
        public kns_tran_phaseinfo_notificationcountEntity Objkns_tran_phaseinfo_notificationcount { get; }
        
        public Kns_Tran_PhaseInfo_NotificationCountRequest(kns_tran_phaseinfo_notificationcountEntity objkns_tran_phaseinfo_notificationcount)
        {
			Objkns_tran_phaseinfo_notificationcount = objkns_tran_phaseinfo_notificationcount;
        }
    }
}
