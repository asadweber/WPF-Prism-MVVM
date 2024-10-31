using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_ServicesUseCase : IUseCaseRequestHandler<Gen_ServicesRequest, Gen_ServicesResponse>
    {
         
    }
}
