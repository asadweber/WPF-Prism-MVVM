using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_NewsUseCase : IUseCaseRequestHandler<Gen_NewsRequest, Gen_NewsResponse>
    {
        Task<bool> Save(Gen_NewsRequest message, ICRUDRequestHandler<Gen_NewsResponse> outputPort);

        Task<bool> Update(Gen_NewsRequest message, ICRUDRequestHandler<Gen_NewsResponse> outputPort);

        Task<bool> Delete(Gen_NewsRequest message, ICRUDRequestHandler<Gen_NewsResponse> outputPort);


        Task<bool> GetSingle(Gen_NewsRequest message, ICRUDRequestHandler<Gen_NewsResponse> outputPort);

        Task<bool> GetAll(Gen_NewsRequest message, ICRUDRequestHandler<Gen_NewsResponse> outputPort);


        Task<bool> GetAllPaged(Gen_NewsRequest message, ICRUDRequestHandler<Gen_NewsResponse> outputPort);

        Task<bool> GetListView(Gen_NewsRequest message, ICRUDRequestHandler<Gen_NewsResponse> outputPort);
        
        
            
    }
}
