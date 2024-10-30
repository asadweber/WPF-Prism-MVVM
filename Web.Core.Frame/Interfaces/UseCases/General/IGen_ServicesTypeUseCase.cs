using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_ServicesTypeUseCase : IUseCaseRequestHandler<Gen_ServicesTypeRequest, Gen_ServicesTypeResponse>
    {
        Task<bool> Save(Gen_ServicesTypeRequest message, ICRUDRequestHandler<Gen_ServicesTypeResponse> outputPort);

        Task<bool> Update(Gen_ServicesTypeRequest message, ICRUDRequestHandler<Gen_ServicesTypeResponse> outputPort);

        Task<bool> Delete(Gen_ServicesTypeRequest message, ICRUDRequestHandler<Gen_ServicesTypeResponse> outputPort);


        Task<bool> GetSingle(Gen_ServicesTypeRequest message, ICRUDRequestHandler<Gen_ServicesTypeResponse> outputPort);

        Task<bool> GetAll(Gen_ServicesTypeRequest message, ICRUDRequestHandler<Gen_ServicesTypeResponse> outputPort);


        Task<bool> GetAllPaged(Gen_ServicesTypeRequest message, ICRUDRequestHandler<Gen_ServicesTypeResponse> outputPort);

        Task<bool> GetListView(Gen_ServicesTypeRequest message, ICRUDRequestHandler<Gen_ServicesTypeResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Gen_ServicesTypeRequest message, IDDLRequestHandler<Gen_ServicesTypeResponse> outputPort);
    
    }
}
