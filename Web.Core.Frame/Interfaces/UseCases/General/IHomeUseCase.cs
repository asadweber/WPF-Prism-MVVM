using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases 
{
    public interface IHomeUseCase : IUseCaseRequestHandler<HomeRequest, HomeResponse>
    {
        Task<bool> LoadMenuByUserID(HomeRequest message, ICRUDRequestHandler<HomeResponse> outputPort);
    }
}
