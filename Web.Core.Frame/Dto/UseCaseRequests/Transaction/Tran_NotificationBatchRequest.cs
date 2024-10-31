using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Dto.UseCaseResponses.Transaction;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseRequests.Transaction
{
    public partial class Tran_NotificationBatchRequest : IUseCaseRequest<Tran_NotificationBatchResponse>
    {
        public tran_notificationbatchEntity Objtran_notificationbatch { get; }

        public Tran_NotificationBatchRequest(tran_notificationbatchEntity objtran_notificationbatch)
        {
            Objtran_notificationbatch = objtran_notificationbatch;
        }
    }
}
