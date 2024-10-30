using System.Threading.Tasks;
using Web.Core.Frame.Presenters;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_StatusChangeRequestResolutionUseCase : IUseCaseRequestHandler<Kns_StatusChangeRequestResolutionRequest, Kns_StatusChangeRequestResolutionResponse>
    {
        Task<bool> Save(Kns_StatusChangeRequestResolutionRequest message, ICRUDRequestHandler<Kns_StatusChangeRequestResolutionResponse> outputPort);

        Task<bool> Update(Kns_StatusChangeRequestResolutionRequest message, ICRUDRequestHandler<Kns_StatusChangeRequestResolutionResponse> outputPort);

        Task<bool> Delete(Kns_StatusChangeRequestResolutionRequest message, ICRUDRequestHandler<Kns_StatusChangeRequestResolutionResponse> outputPort);


        Task<bool> GetSingle(Kns_StatusChangeRequestResolutionRequest message, ICRUDRequestHandler<Kns_StatusChangeRequestResolutionResponse> outputPort);

        Task<bool> GetAll(Kns_StatusChangeRequestResolutionRequest message, ICRUDRequestHandler<Kns_StatusChangeRequestResolutionResponse> outputPort);


        Task<bool> GetAllPaged(Kns_StatusChangeRequestResolutionRequest message, ICRUDRequestHandler<Kns_StatusChangeRequestResolutionResponse> outputPort);

        Task<bool> GetListView(Kns_StatusChangeRequestResolutionRequest message, ICRUDRequestHandler<Kns_StatusChangeRequestResolutionResponse> outputPort);

        Task<bool> GetListView(Kns_StatusChangeRequestResolutionRequest message, ICRUDRequestHandler<Kns_StatusChangeRequestResponse> outputPort);
        Task<bool> GetAllDelay_Report(Kns_StatusChangeRequestResolutionRequest message, ICRUDRequestHandler<Kns_StatusChangeRequestResolutionResponse> outputPort);
        
    }
}
