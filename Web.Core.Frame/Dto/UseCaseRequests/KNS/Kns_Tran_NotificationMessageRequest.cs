using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Kns_Tran_NotificationMessageRequest : IUseCaseRequest<Kns_Tran_NotificationMessageResponse>
    {
        public kns_tran_notificationmessageEntity Objkns_tran_notificationmessage { get; }
        
        public Kns_Tran_NotificationMessageRequest(kns_tran_notificationmessageEntity objkns_tran_notificationmessage)
        {
            Objkns_tran_notificationmessage = objkns_tran_notificationmessage;
        }
    }
}
