using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests;
using Web.Core.Frame.Dto.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
   public interface IRegisterUserUseCase : IUseCaseRequestHandler<RegisterUserRequest, RegisterUserResponse>
   {
        //Task<bool> CivilIdValidateUsingPaciAPI(RegisterUserRequest message, IRegisterUserRequestHandler<RegisterUserResponse> outputPort);


        //Task<bool> CheckCividIdIsAuthenticatedUsingPaci(RegisterUserRequest message, ICRUDRequestHandler<RegisterUserResponse> outputPort);

    }
}
