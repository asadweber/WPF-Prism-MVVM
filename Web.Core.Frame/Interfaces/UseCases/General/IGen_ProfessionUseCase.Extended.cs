using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_ProfessionUseCase : IUseCaseRequestHandler<Gen_ProfessionRequest, Gen_ProfessionResponse>
    {
        Task<bool> GetListViewExt(Gen_ProfessionRequest message, ICRUDRequestHandler<Gen_ProfessionResponse> outputPort);
        Task<bool> GetProfessionDropDown(Gen_ProfessionRequest message, IDDLRequestHandler<Gen_ProfessionResponse> outputPort);
        
        //For Web Admin
        Task<bool> GetBatchCandidateTypeWiseProfessionDropDown(Gen_ProfessionRequest message, IDDLRequestHandler<Gen_ProfessionResponse> outputPort);
        Task<bool> GetAllProfessionbyProfessionGroupID(Gen_ProfessionRequest message, ICRUDRequestHandler<Gen_ProfessionResponse> outputPort);

        Task<bool> GetMultiBatchCandidateTypeWiseProfessionDropDown(Gen_ProfessionRequest message, IDDLRequestHandler<Gen_ProfessionResponse> outputPort);
    }
}
