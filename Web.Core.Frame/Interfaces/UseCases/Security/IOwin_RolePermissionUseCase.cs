using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IOwin_RolePermissionUseCase : IUseCaseRequestHandler<Owin_RolePermissionRequest, Owin_RolePermissionResponse>
    {
        Task<bool> Save(Owin_RolePermissionRequest message, ICRUDRequestHandler<Owin_RolePermissionResponse> outputPort);

        Task<bool> Update(Owin_RolePermissionRequest message, ICRUDRequestHandler<Owin_RolePermissionResponse> outputPort);

        Task<bool> Delete(Owin_RolePermissionRequest message, ICRUDRequestHandler<Owin_RolePermissionResponse> outputPort);


        Task<bool> GetSingle(Owin_RolePermissionRequest message, ICRUDRequestHandler<Owin_RolePermissionResponse> outputPort);

        Task<bool> GetAll(Owin_RolePermissionRequest message, ICRUDRequestHandler<Owin_RolePermissionResponse> outputPort);


        Task<bool> GetAllPaged(Owin_RolePermissionRequest message, ICRUDRequestHandler<Owin_RolePermissionResponse> outputPort);

        Task<bool> GetListView(Owin_RolePermissionRequest message, ICRUDRequestHandler<Owin_RolePermissionResponse> outputPort);
    }
}
