using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_BatchUseCase
    {
        Task<bool> SaveWithDetails(Kns_BatchRequest message, ICRUDRequestHandler<Kns_BatchResponse> outputPort);
    }
}
