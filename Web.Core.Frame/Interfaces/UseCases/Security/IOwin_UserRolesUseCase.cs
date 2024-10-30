using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IOwin_UserRolesUseCase : IUseCaseRequestHandler<Owin_UserRolesRequest, Owin_UserRolesResponse>
    {
        Task<bool> Save(Owin_UserRolesRequest message, ICRUDRequestHandler<Owin_UserRolesResponse> outputPort);

        Task<bool> Update(Owin_UserRolesRequest message, ICRUDRequestHandler<Owin_UserRolesResponse> outputPort);

        Task<bool> Delete(Owin_UserRolesRequest message, ICRUDRequestHandler<Owin_UserRolesResponse> outputPort);


        Task<bool> GetSingle(Owin_UserRolesRequest message, ICRUDRequestHandler<Owin_UserRolesResponse> outputPort);

        Task<bool> GetAll(Owin_UserRolesRequest message, ICRUDRequestHandler<Owin_UserRolesResponse> outputPort);


        Task<bool> GetAllPaged(Owin_UserRolesRequest message, ICRUDRequestHandler<Owin_UserRolesResponse> outputPort);

        Task<bool> GetListView(Owin_UserRolesRequest message, ICRUDRequestHandler<Owin_UserRolesResponse> outputPort);
    }
}
