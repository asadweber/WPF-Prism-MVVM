using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IOwin_FormActionUseCase
    {

        Task<bool> GetFormActionByRole(Owin_FormActionRequest message, IOwin_FormActionHandler<Owin_FormActionResponse> outputPort);

        Task<bool> AssignRolePermission(Owin_RolePermissionRequest message, ICRUDRequestHandler<Owin_RolePermissionResponse> outputPort);
        Task<bool> GetFormActionListByMasterUserId(Owin_FormActionRequest message, IOwin_FormActionHandler<Owin_FormActionResponse> outputPort);
    }
}
