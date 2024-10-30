using Web.Core.Frame.Dto.UseCaseRequests;
using Web.Core.Frame.Dto.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public interface IChangePasswordUseCase : IUseCaseRequestHandler<ChangePasswordRequest, ChangePasswordResponse>
    {
    }
}
