using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Configuration;
using Web.Core.Frame.Dto.UseCaseResponses.Configuration;

namespace Web.Core.Frame.Interfaces.UseCases.Configuration
{
    public partial interface ICnf_NotificationConfigDetlUseCase : IUseCaseRequestHandler<Cnf_NotificationConfigDetlRequest, Cnf_NotificationConfigDetlResponse>
    {
        Task<bool> Save(Cnf_NotificationConfigDetlRequest message, ICRUDRequestHandler<Cnf_NotificationConfigDetlResponse> outputPort);

        Task<bool> Update(Cnf_NotificationConfigDetlRequest message, ICRUDRequestHandler<Cnf_NotificationConfigDetlResponse> outputPort);

        Task<bool> Delete(Cnf_NotificationConfigDetlRequest message, ICRUDRequestHandler<Cnf_NotificationConfigDetlResponse> outputPort);


        Task<bool> GetSingle(Cnf_NotificationConfigDetlRequest message, ICRUDRequestHandler<Cnf_NotificationConfigDetlResponse> outputPort);

        Task<bool> GetAll(Cnf_NotificationConfigDetlRequest message, ICRUDRequestHandler<Cnf_NotificationConfigDetlResponse> outputPort);


        Task<bool> GetAllPaged(Cnf_NotificationConfigDetlRequest message, ICRUDRequestHandler<Cnf_NotificationConfigDetlResponse> outputPort);

        Task<bool> GetListView(Cnf_NotificationConfigDetlRequest message, ICRUDRequestHandler<Cnf_NotificationConfigDetlResponse> outputPort);



    }
}
