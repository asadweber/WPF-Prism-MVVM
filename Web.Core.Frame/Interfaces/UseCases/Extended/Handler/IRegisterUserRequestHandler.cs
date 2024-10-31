using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseResponses;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces
{
    public interface IRegisterUserRequestHandler<in RegisterUserResponse>
    {
        void GetSignInResponse(RegisterUserResponse response);
    }
}
