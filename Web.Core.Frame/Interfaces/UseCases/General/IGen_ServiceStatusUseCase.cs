using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_ServiceStatusUseCase : IUseCaseRequestHandler<Gen_ServiceStatusRequest, Gen_ServiceStatusResponse>
    {
        Task<bool> Save(Gen_ServiceStatusRequest message, ICRUDRequestHandler<Gen_ServiceStatusResponse> outputPort);

        Task<bool> Update(Gen_ServiceStatusRequest message, ICRUDRequestHandler<Gen_ServiceStatusResponse> outputPort);

        Task<bool> Delete(Gen_ServiceStatusRequest message, ICRUDRequestHandler<Gen_ServiceStatusResponse> outputPort);


        Task<bool> GetSingle(Gen_ServiceStatusRequest message, ICRUDRequestHandler<Gen_ServiceStatusResponse> outputPort);

        Task<bool> GetAll(Gen_ServiceStatusRequest message, ICRUDRequestHandler<Gen_ServiceStatusResponse> outputPort);


        Task<bool> GetAllPaged(Gen_ServiceStatusRequest message, ICRUDRequestHandler<Gen_ServiceStatusResponse> outputPort);

        Task<bool> GetListView(Gen_ServiceStatusRequest message, ICRUDRequestHandler<Gen_ServiceStatusResponse> outputPort);
        
        
            
    }
}
