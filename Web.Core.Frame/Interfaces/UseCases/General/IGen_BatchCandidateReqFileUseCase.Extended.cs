using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_BatchCandidateReqFileUseCase : IUseCaseRequestHandler<Gen_BatchCandidateReqFileRequest, Gen_BatchCandidateReqFileResponse>
    {
        Task<bool> GetListViewExt(Gen_BatchCandidateReqFileRequest message, ICRUDRequestHandler<Gen_BatchCandidateReqFileResponse> outputPort);
        Task<bool> GetSingleExt(Gen_BatchCandidateReqFileRequest message, ICRUDRequestHandler<Gen_BatchCandidateReqFileResponse> outputPort);
    }
}
