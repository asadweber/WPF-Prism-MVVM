using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Configuration;
using Web.Core.Frame.Dto.UseCaseResponses.Configuration;

namespace Web.Core.Frame.Interfaces.UseCases.Configuration
{
    public partial interface ICnf_NotificationConfigUseCase : IUseCaseRequestHandler<Cnf_NotificationConfigRequest, Cnf_NotificationConfigResponse>
    {
        Task<bool> GetListViewExt(Cnf_NotificationConfigRequest message, ICRUDRequestHandler<Cnf_NotificationConfigResponse> outputPort);

        Task<bool> GetDataForDropDownExt(Cnf_NotificationConfigRequest message, IDDLRequestHandler<Cnf_NotificationConfigResponse> outputPort);

    }
}
