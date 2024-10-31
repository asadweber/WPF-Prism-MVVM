using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_GeneralHealthUseCase : IUseCaseRequestHandler<Gen_GeneralHealthRequest, Gen_GeneralHealthResponse>
    {
        Task<bool> Save(Gen_GeneralHealthRequest message, ICRUDRequestHandler<Gen_GeneralHealthResponse> outputPort);

        Task<bool> Update(Gen_GeneralHealthRequest message, ICRUDRequestHandler<Gen_GeneralHealthResponse> outputPort);

        Task<bool> Delete(Gen_GeneralHealthRequest message, ICRUDRequestHandler<Gen_GeneralHealthResponse> outputPort);


        Task<bool> GetSingle(Gen_GeneralHealthRequest message, ICRUDRequestHandler<Gen_GeneralHealthResponse> outputPort);

        Task<bool> GetAll(Gen_GeneralHealthRequest message, ICRUDRequestHandler<Gen_GeneralHealthResponse> outputPort);


        Task<bool> GetAllPaged(Gen_GeneralHealthRequest message, ICRUDRequestHandler<Gen_GeneralHealthResponse> outputPort);

        Task<bool> GetListView(Gen_GeneralHealthRequest message, ICRUDRequestHandler<Gen_GeneralHealthResponse> outputPort);
        
        
            
    }
}
