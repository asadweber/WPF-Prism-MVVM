using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Configuration;
using Web.Core.Frame.Dto.UseCaseResponses.Configuration;

namespace Web.Core.Frame.Interfaces.UseCases.Configuration
{
    public partial interface ICnf_NotificationTempletUseCase : IUseCaseRequestHandler<Cnf_NotificationTempletRequest, Cnf_NotificationTempletResponse>
    {
        Task<bool> Save(Cnf_NotificationTempletRequest message, ICRUDRequestHandler<Cnf_NotificationTempletResponse> outputPort);

        Task<bool> Update(Cnf_NotificationTempletRequest message, ICRUDRequestHandler<Cnf_NotificationTempletResponse> outputPort);

        Task<bool> Delete(Cnf_NotificationTempletRequest message, ICRUDRequestHandler<Cnf_NotificationTempletResponse> outputPort);


        Task<bool> GetSingle(Cnf_NotificationTempletRequest message, ICRUDRequestHandler<Cnf_NotificationTempletResponse> outputPort);

        Task<bool> GetAll(Cnf_NotificationTempletRequest message, ICRUDRequestHandler<Cnf_NotificationTempletResponse> outputPort);


        Task<bool> GetAllPaged(Cnf_NotificationTempletRequest message, ICRUDRequestHandler<Cnf_NotificationTempletResponse> outputPort);

        Task<bool> GetListView(Cnf_NotificationTempletRequest message, ICRUDRequestHandler<Cnf_NotificationTempletResponse> outputPort);


        Task<bool> GetDataForDropDown(Cnf_NotificationTempletRequest message, IDDLRequestHandler<Cnf_NotificationTempletResponse> outputPort);

    }
}
