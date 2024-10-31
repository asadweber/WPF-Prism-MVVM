using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Tran_TrainingJoinNotificationRequest : IUseCaseRequest<Tran_TrainingJoinNotificationResponse>
    {
        public tran_trainingjoinnotificationEntity Objtran_trainingjoinnotification { get; }

        public Tran_TrainingJoinNotificationRequest(tran_trainingjoinnotificationEntity objtran_trainingjoinnotification)
        {
            Objtran_trainingjoinnotification = objtran_trainingjoinnotification;
        }
    }
}
