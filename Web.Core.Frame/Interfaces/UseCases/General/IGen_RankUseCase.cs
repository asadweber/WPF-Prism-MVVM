using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_RankUseCase : IUseCaseRequestHandler<Gen_RankRequest, Gen_RankResponse>
    {
        Task<bool> Save(Gen_RankRequest message, ICRUDRequestHandler<Gen_RankResponse> outputPort);

        Task<bool> Update(Gen_RankRequest message, ICRUDRequestHandler<Gen_RankResponse> outputPort);

        Task<bool> Delete(Gen_RankRequest message, ICRUDRequestHandler<Gen_RankResponse> outputPort);


        Task<bool> GetSingle(Gen_RankRequest message, ICRUDRequestHandler<Gen_RankResponse> outputPort);

        Task<bool> GetAll(Gen_RankRequest message, ICRUDRequestHandler<Gen_RankResponse> outputPort);


        Task<bool> GetAllPaged(Gen_RankRequest message, ICRUDRequestHandler<Gen_RankResponse> outputPort);

        Task<bool> GetListView(Gen_RankRequest message, ICRUDRequestHandler<Gen_RankResponse> outputPort);
        
        
            
    }
}
