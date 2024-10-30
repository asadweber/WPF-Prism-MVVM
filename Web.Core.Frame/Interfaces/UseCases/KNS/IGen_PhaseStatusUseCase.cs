using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_PhaseStatusUseCase : IUseCaseRequestHandler<Gen_PhaseStatusRequest, Gen_PhaseStatusResponse>
    {
        Task<bool> Save(Gen_PhaseStatusRequest message, ICRUDRequestHandler<Gen_PhaseStatusResponse> outputPort);

        Task<bool> Update(Gen_PhaseStatusRequest message, ICRUDRequestHandler<Gen_PhaseStatusResponse> outputPort);

        Task<bool> Delete(Gen_PhaseStatusRequest message, ICRUDRequestHandler<Gen_PhaseStatusResponse> outputPort);


        Task<bool> GetSingle(Gen_PhaseStatusRequest message, ICRUDRequestHandler<Gen_PhaseStatusResponse> outputPort);

        Task<bool> GetAll(Gen_PhaseStatusRequest message, ICRUDRequestHandler<Gen_PhaseStatusResponse> outputPort);


        Task<bool> GetAllPaged(Gen_PhaseStatusRequest message, ICRUDRequestHandler<Gen_PhaseStatusResponse> outputPort);

        Task<bool> GetListView(Gen_PhaseStatusRequest message, ICRUDRequestHandler<Gen_PhaseStatusResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Gen_PhaseStatusRequest message, IDDLRequestHandler<Gen_PhaseStatusResponse> outputPort);
    
    }
}
