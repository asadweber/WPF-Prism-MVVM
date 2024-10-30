using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IOwin_RoleUseCase : IUseCaseRequestHandler<Owin_RoleRequest, Owin_RoleResponse>
    {
        Task<bool> Save(Owin_RoleRequest message, ICRUDRequestHandler<Owin_RoleResponse> outputPort);

        Task<bool> Update(Owin_RoleRequest message, ICRUDRequestHandler<Owin_RoleResponse> outputPort);

        Task<bool> Delete(Owin_RoleRequest message, ICRUDRequestHandler<Owin_RoleResponse> outputPort);


        Task<bool> GetSingle(Owin_RoleRequest message, ICRUDRequestHandler<Owin_RoleResponse> outputPort);

        Task<bool> GetAll(Owin_RoleRequest message, ICRUDRequestHandler<Owin_RoleResponse> outputPort);


        Task<bool> GetAllPaged(Owin_RoleRequest message, ICRUDRequestHandler<Owin_RoleResponse> outputPort);

        Task<bool> GetListView(Owin_RoleRequest message, ICRUDRequestHandler<Owin_RoleResponse> outputPort);

        Task<bool> GetDataForDropDown(Owin_RoleRequest message, IDDLRequestHandler<Owin_RoleResponse> outputPort);
    }
}
