using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_BatchCandProfessionUseCase : IUseCaseRequestHandler<Gen_BatchCandProfessionRequest, Gen_BatchCandProfessionResponse>
    {
        Task<bool> Save(Gen_BatchCandProfessionRequest message, ICRUDRequestHandler<Gen_BatchCandProfessionResponse> outputPort);

        Task<bool> Update(Gen_BatchCandProfessionRequest message, ICRUDRequestHandler<Gen_BatchCandProfessionResponse> outputPort);

        Task<bool> Delete(Gen_BatchCandProfessionRequest message, ICRUDRequestHandler<Gen_BatchCandProfessionResponse> outputPort);


        Task<bool> GetSingle(Gen_BatchCandProfessionRequest message, ICRUDRequestHandler<Gen_BatchCandProfessionResponse> outputPort);

        Task<bool> GetAll(Gen_BatchCandProfessionRequest message, ICRUDRequestHandler<Gen_BatchCandProfessionResponse> outputPort);


        Task<bool> GetAllPaged(Gen_BatchCandProfessionRequest message, ICRUDRequestHandler<Gen_BatchCandProfessionResponse> outputPort);

        Task<bool> GetListView(Gen_BatchCandProfessionRequest message, ICRUDRequestHandler<Gen_BatchCandProfessionResponse> outputPort);
        
        
            
    }
}
