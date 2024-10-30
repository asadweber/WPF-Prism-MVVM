using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKNS_HangfireJobDetailUseCase : IUseCaseRequestHandler<KNS_HangfireJobDetailRequest, KNS_HangfireJobDetailResponse>
    {
        Task<bool> Save(KNS_HangfireJobDetailRequest message, ICRUDRequestHandler<KNS_HangfireJobDetailResponse> outputPort);

        Task<bool> Update(KNS_HangfireJobDetailRequest message, ICRUDRequestHandler<KNS_HangfireJobDetailResponse> outputPort);

        Task<bool> Delete(KNS_HangfireJobDetailRequest message, ICRUDRequestHandler<KNS_HangfireJobDetailResponse> outputPort);


        Task<bool> GetSingle(KNS_HangfireJobDetailRequest message, ICRUDRequestHandler<KNS_HangfireJobDetailResponse> outputPort);

        Task<bool> GetAll(KNS_HangfireJobDetailRequest message, ICRUDRequestHandler<KNS_HangfireJobDetailResponse> outputPort);


        Task<bool> GetAllPaged(KNS_HangfireJobDetailRequest message, ICRUDRequestHandler<KNS_HangfireJobDetailResponse> outputPort);

        Task<bool> GetListView(KNS_HangfireJobDetailRequest message, ICRUDRequestHandler<KNS_HangfireJobDetailResponse> outputPort);
        
        
            
    }
}
