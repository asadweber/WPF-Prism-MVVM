using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Configuration;
using Web.Core.Frame.Dto.UseCaseResponses.Configuration;

namespace Web.Core.Frame.Interfaces.UseCases.Configuration
{
    public partial interface ICnf_NotificationConfigDetlUseCase : IUseCaseRequestHandler<Cnf_NotificationConfigDetlRequest, Cnf_NotificationConfigDetlResponse>
    {
        Task<bool> GetListViewExt(Cnf_NotificationConfigDetlRequest message, ICRUDRequestHandler<Cnf_NotificationConfigDetlResponse> outputPort);
        Task<bool> GetSingleExt(Cnf_NotificationConfigDetlRequest message, ICRUDRequestHandler<Cnf_NotificationConfigDetlResponse> outputPort);
    }
}
