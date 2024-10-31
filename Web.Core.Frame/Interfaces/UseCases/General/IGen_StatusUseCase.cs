using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_StatusUseCase : IUseCaseRequestHandler<Gen_StatusRequest, Gen_StatusResponse>
    {
        Task<bool> Save(Gen_StatusRequest message, ICRUDRequestHandler<Gen_StatusResponse> outputPort);

        Task<bool> Update(Gen_StatusRequest message, ICRUDRequestHandler<Gen_StatusResponse> outputPort);

        Task<bool> Delete(Gen_StatusRequest message, ICRUDRequestHandler<Gen_StatusResponse> outputPort);


        Task<bool> GetSingle(Gen_StatusRequest message, ICRUDRequestHandler<Gen_StatusResponse> outputPort);

        Task<bool> GetAll(Gen_StatusRequest message, ICRUDRequestHandler<Gen_StatusResponse> outputPort);


        Task<bool> GetAllPaged(Gen_StatusRequest message, ICRUDRequestHandler<Gen_StatusResponse> outputPort);

        Task<bool> GetListView(Gen_StatusRequest message, ICRUDRequestHandler<Gen_StatusResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Gen_StatusRequest message, IDDLRequestHandler<Gen_StatusResponse> outputPort);
    
    }
}
