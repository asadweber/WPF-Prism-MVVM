using Web.Core.Frame.Dto.UseCaseRequests;
using Web.Core.Frame.Dto.UseCaseResponses;
using Web.Core.Frame.Presenters;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public interface ILoginUseCase : IUseCaseRequestHandler<LoginRequest, LoginResponse>
    {
        //Task HandleForSahel(LoginRequest loginRequest, LoginPresenter loginPresenter);
    }
}
