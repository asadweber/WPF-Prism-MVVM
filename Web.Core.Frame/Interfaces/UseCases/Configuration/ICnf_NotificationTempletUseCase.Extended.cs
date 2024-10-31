using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Configuration;
using Web.Core.Frame.Dto.UseCaseResponses.Configuration;

namespace Web.Core.Frame.Interfaces.UseCases.Configuration
{
    public partial interface ICnf_NotificationTempletUseCase : IUseCaseRequestHandler<Cnf_NotificationTempletRequest, Cnf_NotificationTempletResponse>
    {
        Task<bool> GetNotificationTemplateWithMsgDropDown(Cnf_NotificationTempletRequest message, IDDLRequestHandler<Cnf_NotificationTempletResponse> outputPort);

    }
}
