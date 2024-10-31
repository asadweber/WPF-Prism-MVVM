using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_BatchCandidateReqFileUseCase : IUseCaseRequestHandler<Gen_BatchCandidateReqFileRequest, Gen_BatchCandidateReqFileResponse>
    {
        Task<bool> Save(Gen_BatchCandidateReqFileRequest message, ICRUDRequestHandler<Gen_BatchCandidateReqFileResponse> outputPort);

        Task<bool> Update(Gen_BatchCandidateReqFileRequest message, ICRUDRequestHandler<Gen_BatchCandidateReqFileResponse> outputPort);

        Task<bool> Delete(Gen_BatchCandidateReqFileRequest message, ICRUDRequestHandler<Gen_BatchCandidateReqFileResponse> outputPort);


        Task<bool> GetSingle(Gen_BatchCandidateReqFileRequest message, ICRUDRequestHandler<Gen_BatchCandidateReqFileResponse> outputPort);

        Task<bool> GetAll(Gen_BatchCandidateReqFileRequest message, ICRUDRequestHandler<Gen_BatchCandidateReqFileResponse> outputPort);


        Task<bool> GetAllPaged(Gen_BatchCandidateReqFileRequest message, ICRUDRequestHandler<Gen_BatchCandidateReqFileResponse> outputPort);

        Task<bool> GetListView(Gen_BatchCandidateReqFileRequest message, ICRUDRequestHandler<Gen_BatchCandidateReqFileResponse> outputPort);
        
        
            
    }
}
