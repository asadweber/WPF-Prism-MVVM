using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Tran_MedExamNotificationRequest : IUseCaseRequest<Tran_MedExamNotificationResponse>
    {
        public tran_medexamnotificationEntity Objtran_medexamnotification { get; }
        
        public Tran_MedExamNotificationRequest(tran_medexamnotificationEntity objtran_medexamnotification)
        {
            Objtran_medexamnotification = objtran_medexamnotification;
        }
    }
}
