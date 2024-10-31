using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_BatchCandProfessionUseCase : IUseCaseRequestHandler<Gen_BatchCandProfessionRequest, Gen_BatchCandProfessionResponse>
    {
        Task<bool> GetSingleExt(Gen_BatchCandProfessionRequest message, ICRUDRequestHandler<Gen_BatchCandProfessionResponse> outputPort);
        Task<bool> GetListViewExt(Gen_BatchCandProfessionRequest message, ICRUDRequestHandler<Gen_BatchCandProfessionResponse> outputPort);
        Task<bool> SaveList(Gen_BatchCandProfessionRequest message, ICRUDRequestHandler<Gen_BatchCandProfessionResponse> outputPort);
        Task<bool> GetSingleByBatchCandidateTypeMapProfessionID(Gen_BatchCandProfessionRequest message, ICRUDRequestHandler<Gen_BatchCandProfessionResponse> outputPort);
    }
}