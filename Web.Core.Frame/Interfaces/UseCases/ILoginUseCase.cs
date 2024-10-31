using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests;
using Web.Core.Frame.Dto.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public interface ILoginUseCase : IUseCaseRequestHandler<LoginRequest, LoginResponse>
    {
        Task<bool> HandleForSahel(LoginRequest message, IOutputPort<LoginResponse> outputPort);
    }
}
