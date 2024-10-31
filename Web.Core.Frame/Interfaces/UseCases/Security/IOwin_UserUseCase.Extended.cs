using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IOwin_UserUseCase : IUseCaseRequestHandler<Owin_UserRequest, Owin_UserResponse>
    {
        Task<bool> GetSinglebyUsername(Owin_UserRequest message, ICRUDRequestHandler<Owin_UserResponse> outputPort);
    }
}
