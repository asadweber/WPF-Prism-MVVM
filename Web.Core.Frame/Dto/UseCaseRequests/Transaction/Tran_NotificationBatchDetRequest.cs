using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Dto.UseCaseResponses.Transaction;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseRequests.Transaction
{
    public partial class Tran_NotificationBatchDetRequest : IUseCaseRequest<Tran_NotificationBatchDetResponse>
    {
        public tran_notificationbatchdetEntity Objtran_notificationbatchdet { get; }

        public Tran_NotificationBatchDetRequest(tran_notificationbatchdetEntity objtran_notificationbatchdet)
        {
            Objtran_notificationbatchdet = objtran_notificationbatchdet;
        }
    }
}
