using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_ServicesUseCase : IUseCaseRequestHandler<Gen_ServicesRequest, Gen_ServicesResponse>
    {
        Task<bool> Save(Gen_ServicesRequest message, ICRUDRequestHandler<Gen_ServicesResponse> outputPort);

        Task<bool> Update(Gen_ServicesRequest message, ICRUDRequestHandler<Gen_ServicesResponse> outputPort);

        Task<bool> Delete(Gen_ServicesRequest message, ICRUDRequestHandler<Gen_ServicesResponse> outputPort);


        Task<bool> GetSingle(Gen_ServicesRequest message, ICRUDRequestHandler<Gen_ServicesResponse> outputPort);

        Task<bool> GetAll(Gen_ServicesRequest message, ICRUDRequestHandler<Gen_ServicesResponse> outputPort);


        Task<bool> GetAllPaged(Gen_ServicesRequest message, ICRUDRequestHandler<Gen_ServicesResponse> outputPort);

        Task<bool> GetListView(Gen_ServicesRequest message, ICRUDRequestHandler<Gen_ServicesResponse> outputPort);
        
        
            
    }
}
