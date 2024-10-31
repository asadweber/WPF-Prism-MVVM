using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_ResidentTypeUseCase : IUseCaseRequestHandler<Gen_ResidentTypeRequest, Gen_ResidentTypeResponse>
    {
        Task<bool> Save(Gen_ResidentTypeRequest message, ICRUDRequestHandler<Gen_ResidentTypeResponse> outputPort);

        Task<bool> Update(Gen_ResidentTypeRequest message, ICRUDRequestHandler<Gen_ResidentTypeResponse> outputPort);

        Task<bool> Delete(Gen_ResidentTypeRequest message, ICRUDRequestHandler<Gen_ResidentTypeResponse> outputPort);


        Task<bool> GetSingle(Gen_ResidentTypeRequest message, ICRUDRequestHandler<Gen_ResidentTypeResponse> outputPort);

        Task<bool> GetAll(Gen_ResidentTypeRequest message, ICRUDRequestHandler<Gen_ResidentTypeResponse> outputPort);


        Task<bool> GetAllPaged(Gen_ResidentTypeRequest message, ICRUDRequestHandler<Gen_ResidentTypeResponse> outputPort);

        Task<bool> GetListView(Gen_ResidentTypeRequest message, ICRUDRequestHandler<Gen_ResidentTypeResponse> outputPort);
        
        
        Task<bool> GetDataForDropDown(Gen_ResidentTypeRequest message, IDDLRequestHandler<Gen_ResidentTypeResponse> outputPort);
    
    }
}
