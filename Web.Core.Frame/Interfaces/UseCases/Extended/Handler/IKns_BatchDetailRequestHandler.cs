using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces
{
    public interface IKns_BatchDetailRequestHandler<in Kns_BatchDetailRequest>
    {
        void GetSingleRegisteredStatistics(Kns_BatchDetailResponse response);
    }
}
