using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_CandidateTypeUseCase : IUseCaseRequestHandler<Gen_CandidateTypeRequest, Gen_CandidateTypeResponse>
    {
        Task<bool> Save(Gen_CandidateTypeRequest message, ICRUDRequestHandler<Gen_CandidateTypeResponse> outputPort);

        Task<bool> Update(Gen_CandidateTypeRequest message, ICRUDRequestHandler<Gen_CandidateTypeResponse> outputPort);

        Task<bool> Delete(Gen_CandidateTypeRequest message, ICRUDRequestHandler<Gen_CandidateTypeResponse> outputPort);


        Task<bool> GetSingle(Gen_CandidateTypeRequest message, ICRUDRequestHandler<Gen_CandidateTypeResponse> outputPort);

        Task<bool> GetAll(Gen_CandidateTypeRequest message, ICRUDRequestHandler<Gen_CandidateTypeResponse> outputPort);


        Task<bool> GetAllPaged(Gen_CandidateTypeRequest message, ICRUDRequestHandler<Gen_CandidateTypeResponse> outputPort);

        Task<bool> GetListView(Gen_CandidateTypeRequest message, ICRUDRequestHandler<Gen_CandidateTypeResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Gen_CandidateTypeRequest message, IDDLRequestHandler<Gen_CandidateTypeResponse> outputPort);
    
    }
}
