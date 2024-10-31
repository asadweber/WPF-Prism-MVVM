using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Dto.UseCaseResponses.Configuration;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseRequests.Configuration
{
    public partial class Cnf_NotificationConfigDetlRequest : IUseCaseRequest<Cnf_NotificationConfigDetlResponse>
    {
        public cnf_notificationconfigdetlEntity Objcnf_notificationconfigdetl { get; }

        public Cnf_NotificationConfigDetlRequest(cnf_notificationconfigdetlEntity objcnf_notificationconfigdetl)
        {
            Objcnf_notificationconfigdetl = objcnf_notificationconfigdetl;
        }
    }
}
