using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Tran_SyExamNotificationRequest : IUseCaseRequest<Tran_SyExamNotificationResponse>
    {
        public tran_syexamnotificationEntity Objtran_syexamnotification { get; }
        
        public Tran_SyExamNotificationRequest(tran_syexamnotificationEntity objtran_syexamnotification)
        {
            Objtran_syexamnotification = objtran_syexamnotification;
        }
    }
}
