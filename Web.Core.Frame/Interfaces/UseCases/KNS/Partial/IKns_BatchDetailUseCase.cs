using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
	public partial interface IKns_BatchDetailUseCase : IUseCaseRequestHandler<Kns_BatchDetailRequest, Kns_BatchDetailResponse>
	{
        Task<bool> GetRegisteredStatisticsChart(IKns_BatchDetailRequestHandler<Kns_BatchDetailResponse> outputPort);

    }
}
