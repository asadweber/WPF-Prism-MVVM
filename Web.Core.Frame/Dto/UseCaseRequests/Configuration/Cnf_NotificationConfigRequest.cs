using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Dto.UseCaseResponses.Configuration;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Dto.UseCaseRequests.Configuration
{
    public partial class Cnf_NotificationConfigRequest : IUseCaseRequest<Cnf_NotificationConfigResponse>
    {
        public cnf_notificationconfigEntity Objcnf_notificationconfig { get; }

        public Cnf_NotificationConfigRequest(cnf_notificationconfigEntity objcnf_notificationconfig)
        {
            Objcnf_notificationconfig = objcnf_notificationconfig;
        }
    }
}
