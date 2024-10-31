using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Dto.UseCaseResponses.Configuration;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseRequests.Configuration
{
    public partial class Cnf_NotificationTempletRequest : IUseCaseRequest<Cnf_NotificationTempletResponse>
    {
        public cnf_notificationtempletEntity Objcnf_notificationtemplet { get; }

        public Cnf_NotificationTempletRequest(cnf_notificationtempletEntity objcnf_notificationtemplet)
        {
            Objcnf_notificationtemplet = objcnf_notificationtemplet;
        }
    }
}
