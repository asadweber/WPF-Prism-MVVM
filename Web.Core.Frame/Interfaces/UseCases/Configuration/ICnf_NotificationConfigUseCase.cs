using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Configuration;
using Web.Core.Frame.Dto.UseCaseResponses.Configuration;

namespace Web.Core.Frame.Interfaces.UseCases.Configuration
{
    public partial interface ICnf_NotificationConfigUseCase : IUseCaseRequestHandler<Cnf_NotificationConfigRequest, Cnf_NotificationConfigResponse>
    {
        Task<bool> Save(Cnf_NotificationConfigRequest message, ICRUDRequestHandler<Cnf_NotificationConfigResponse> outputPort);

        Task<bool> Update(Cnf_NotificationConfigRequest message, ICRUDRequestHandler<Cnf_NotificationConfigResponse> outputPort);

        Task<bool> Delete(Cnf_NotificationConfigRequest message, ICRUDRequestHandler<Cnf_NotificationConfigResponse> outputPort);


        Task<bool> GetSingle(Cnf_NotificationConfigRequest message, ICRUDRequestHandler<Cnf_NotificationConfigResponse> outputPort);

        Task<bool> GetAll(Cnf_NotificationConfigRequest message, ICRUDRequestHandler<Cnf_NotificationConfigResponse> outputPort);


        Task<bool> GetAllPaged(Cnf_NotificationConfigRequest message, ICRUDRequestHandler<Cnf_NotificationConfigResponse> outputPort);

        Task<bool> GetListView(Cnf_NotificationConfigRequest message, ICRUDRequestHandler<Cnf_NotificationConfigResponse> outputPort);


        Task<bool> GetDataForDropDown(Cnf_NotificationConfigRequest message, IDDLRequestHandler<Cnf_NotificationConfigResponse> outputPort);

    }
}
