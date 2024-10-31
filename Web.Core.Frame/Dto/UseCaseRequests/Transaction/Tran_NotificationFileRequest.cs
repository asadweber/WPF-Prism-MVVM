using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Tran_NotificationFileRequest : IUseCaseRequest<Tran_NotificationFileResponse>
    {
        public tran_notificationfileEntity Objtran_notificationfile { get; }
        
        public Tran_NotificationFileRequest(tran_notificationfileEntity objtran_notificationfile)
        {
            Objtran_notificationfile = objtran_notificationfile;
        }
    }
}
