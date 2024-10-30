using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_BatchOrderUseCase
    {
        Task<bool> SaveWithDetails(Kns_BatchOrderRequest message, ICRUDRequestHandler<Kns_BatchOrderResponse> outputPort);

        Task<bool> SingleDetailSave(Kns_BatchDetailRequest message, ICRUDRequestHandler<Kns_BatchDetailResponse> outputPort);
        Task<bool> SingleProfileForBatchSave(Kns_BatchDetailRequest message, ICRUDRequestHandler<Kns_BatchDetailResponse> outputPort);

        Task<bool> UpdateProfileBatchDetailUsingServiceData(Kns_BatchDetailRequest message, ICRUDRequestHandler<Kns_BatchDetailResponse> outputPort);

    }
}
