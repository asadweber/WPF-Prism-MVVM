using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_PhasesUseCase : IUseCaseRequestHandler<Gen_PhasesRequest, Gen_PhasesResponse>
    {
        Task<bool> Save(Gen_PhasesRequest message, ICRUDRequestHandler<Gen_PhasesResponse> outputPort);

        Task<bool> Update(Gen_PhasesRequest message, ICRUDRequestHandler<Gen_PhasesResponse> outputPort);

        Task<bool> Delete(Gen_PhasesRequest message, ICRUDRequestHandler<Gen_PhasesResponse> outputPort);


        Task<bool> GetSingle(Gen_PhasesRequest message, ICRUDRequestHandler<Gen_PhasesResponse> outputPort);

        Task<bool> GetAll(Gen_PhasesRequest message, ICRUDRequestHandler<Gen_PhasesResponse> outputPort);


        Task<bool> GetAllPaged(Gen_PhasesRequest message, ICRUDRequestHandler<Gen_PhasesResponse> outputPort);

        Task<bool> GetListView(Gen_PhasesRequest message, ICRUDRequestHandler<Gen_PhasesResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Gen_PhasesRequest message, IDDLRequestHandler<Gen_PhasesResponse> outputPort);
    
    }
}
