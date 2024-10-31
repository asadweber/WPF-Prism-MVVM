using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_CandidateTypeUseCase : IUseCaseRequestHandler<Gen_CandidateTypeRequest, Gen_CandidateTypeResponse>
    {
        Task<bool> GetBatchWiseCandidateTypeDropDown(Gen_CandidateTypeRequest message, IDDLRequestHandler<Gen_CandidateTypeResponse> outputPort);
        
        //For Web Admin
        Task<bool> GetBatchWiseCandidateTypeListDropDown(Gen_CandidateTypeRequest message, IDDLRequestHandler<Gen_CandidateTypeResponse> outputPort);

        //For Web Admin
        Task<bool> GetMultiBatchWiseCandidateTypeListDropDown(Gen_CandidateTypeRequest message, IDDLRequestHandler<Gen_CandidateTypeResponse> outputPort);

        Task<bool> GetSingleById(Gen_CandidateTypeRequest message, ICRUDRequestHandler<Gen_CandidateTypeResponse> outputPort);


        Task<bool> GetBatchWiseCandidateTypeDropDownByBatchIDCandicateTypeId(Gen_CandidateTypeRequest message, ICRUDRequestHandler<Gen_CandidateTypeResponse> outputPort);



    }
}
