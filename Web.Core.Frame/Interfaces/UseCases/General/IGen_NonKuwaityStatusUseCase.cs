using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_NonKuwaityStatusUseCase : IUseCaseRequestHandler<Gen_NonKuwaityStatusRequest, Gen_NonKuwaityStatusResponse>
    {
        Task<bool> Save(Gen_NonKuwaityStatusRequest message, ICRUDRequestHandler<Gen_NonKuwaityStatusResponse> outputPort);

        Task<bool> Update(Gen_NonKuwaityStatusRequest message, ICRUDRequestHandler<Gen_NonKuwaityStatusResponse> outputPort);

        Task<bool> Delete(Gen_NonKuwaityStatusRequest message, ICRUDRequestHandler<Gen_NonKuwaityStatusResponse> outputPort);


        Task<bool> GetSingle(Gen_NonKuwaityStatusRequest message, ICRUDRequestHandler<Gen_NonKuwaityStatusResponse> outputPort);

        Task<bool> GetAll(Gen_NonKuwaityStatusRequest message, ICRUDRequestHandler<Gen_NonKuwaityStatusResponse> outputPort);


        Task<bool> GetAllPaged(Gen_NonKuwaityStatusRequest message, ICRUDRequestHandler<Gen_NonKuwaityStatusResponse> outputPort);

        Task<bool> GetListView(Gen_NonKuwaityStatusRequest message, ICRUDRequestHandler<Gen_NonKuwaityStatusResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Gen_NonKuwaityStatusRequest message, IDDLRequestHandler<Gen_NonKuwaityStatusResponse> outputPort);
    
    }
}
