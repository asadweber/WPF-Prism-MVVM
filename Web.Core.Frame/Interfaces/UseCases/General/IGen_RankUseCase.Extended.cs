using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_RankUseCase : IUseCaseRequestHandler<Gen_RankRequest, Gen_RankResponse>
    {
         
    }
}
