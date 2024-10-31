using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Tran_NotificationFileDetRequest : IUseCaseRequest<Tran_NotificationFileDetResponse>
    {
        public tran_notificationfiledetEntity Objtran_notificationfiledet { get; }
        
        public Tran_NotificationFileDetRequest(tran_notificationfiledetEntity objtran_notificationfiledet)
        {
            Objtran_notificationfiledet = objtran_notificationfiledet;
        }
    }
}
