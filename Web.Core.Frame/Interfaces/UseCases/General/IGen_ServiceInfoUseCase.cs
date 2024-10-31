using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_ServiceInfoUseCase : IUseCaseRequestHandler<Gen_ServiceInfoRequest, Gen_ServiceInfoResponse>
    {
        Task<bool> Save(Gen_ServiceInfoRequest message, ICRUDRequestHandler<Gen_ServiceInfoResponse> outputPort);

        Task<bool> Update(Gen_ServiceInfoRequest message, ICRUDRequestHandler<Gen_ServiceInfoResponse> outputPort);

        Task<bool> Delete(Gen_ServiceInfoRequest message, ICRUDRequestHandler<Gen_ServiceInfoResponse> outputPort);


        Task<bool> GetSingle(Gen_ServiceInfoRequest message, ICRUDRequestHandler<Gen_ServiceInfoResponse> outputPort);

        Task<bool> GetAll(Gen_ServiceInfoRequest message, ICRUDRequestHandler<Gen_ServiceInfoResponse> outputPort);


        Task<bool> GetAllPaged(Gen_ServiceInfoRequest message, ICRUDRequestHandler<Gen_ServiceInfoResponse> outputPort);

        Task<bool> GetListView(Gen_ServiceInfoRequest message, ICRUDRequestHandler<Gen_ServiceInfoResponse> outputPort);
        
        
            
    }
}
