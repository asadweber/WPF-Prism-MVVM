using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_FaqUseCase : IUseCaseRequestHandler<Gen_FaqRequest, Gen_FaqResponse>
    {
        Task<bool> Save(Gen_FaqRequest message, ICRUDRequestHandler<Gen_FaqResponse> outputPort);

        Task<bool> Update(Gen_FaqRequest message, ICRUDRequestHandler<Gen_FaqResponse> outputPort);

        Task<bool> Delete(Gen_FaqRequest message, ICRUDRequestHandler<Gen_FaqResponse> outputPort);


        Task<bool> GetSingle(Gen_FaqRequest message, ICRUDRequestHandler<Gen_FaqResponse> outputPort);

        Task<bool> GetAll(Gen_FaqRequest message, ICRUDRequestHandler<Gen_FaqResponse> outputPort);


        Task<bool> GetAllPaged(Gen_FaqRequest message, ICRUDRequestHandler<Gen_FaqResponse> outputPort);

        Task<bool> GetListView(Gen_FaqRequest message, ICRUDRequestHandler<Gen_FaqResponse> outputPort);
        
        
            
    }
}
