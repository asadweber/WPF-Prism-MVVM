using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_BatchCandidateTypeMapUseCase : IUseCaseRequestHandler<Gen_BatchCandidateTypeMapRequest, Gen_BatchCandidateTypeMapResponse>
    {
        Task<bool> GetListViewExt(Gen_BatchCandidateTypeMapRequest message, ICRUDRequestHandler<Gen_BatchCandidateTypeMapResponse> outputPort);
        Task<bool> GetDataForDropDownExt(Gen_BatchCandidateTypeMapRequest message, IDDLRequestHandler<Gen_BatchCandidateTypeMapResponse> outputPort);
        Task<bool> GetSingleByBatchCandidateTypeID(Gen_BatchCandidateTypeMapRequest message, ICRUDRequestHandler<Gen_BatchCandidateTypeMapResponse> outputPort);
    }
}
