using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IOwin_UserRoleUseCase : IUseCaseRequestHandler<Owin_UserRoleRequest, Owin_UserRoleResponse>
    {
        Task<bool> Save(Owin_UserRoleRequest message, ICRUDRequestHandler<Owin_UserRoleResponse> outputPort);

        Task<bool> Update(Owin_UserRoleRequest message, ICRUDRequestHandler<Owin_UserRoleResponse> outputPort);

        Task<bool> Delete(Owin_UserRoleRequest message, ICRUDRequestHandler<Owin_UserRoleResponse> outputPort);


        Task<bool> GetSingle(Owin_UserRoleRequest message, ICRUDRequestHandler<Owin_UserRoleResponse> outputPort);

        Task<bool> GetAll(Owin_UserRoleRequest message, ICRUDRequestHandler<Owin_UserRoleResponse> outputPort);


        Task<bool> GetAllPaged(Owin_UserRoleRequest message, ICRUDRequestHandler<Owin_UserRoleResponse> outputPort);

        Task<bool> GetListView(Owin_UserRoleRequest message, ICRUDRequestHandler<Owin_UserRoleResponse> outputPort);
    }
}
