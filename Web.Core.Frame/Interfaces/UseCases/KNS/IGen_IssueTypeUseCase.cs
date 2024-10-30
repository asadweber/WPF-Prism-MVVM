using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_IssueTypeUseCase : IUseCaseRequestHandler<Gen_IssueTypeRequest, Gen_IssueTypeResponse>
    {
        Task<bool> Save(Gen_IssueTypeRequest message, ICRUDRequestHandler<Gen_IssueTypeResponse> outputPort);

        Task<bool> Update(Gen_IssueTypeRequest message, ICRUDRequestHandler<Gen_IssueTypeResponse> outputPort);

        Task<bool> Delete(Gen_IssueTypeRequest message, ICRUDRequestHandler<Gen_IssueTypeResponse> outputPort);


        Task<bool> GetSingle(Gen_IssueTypeRequest message, ICRUDRequestHandler<Gen_IssueTypeResponse> outputPort);

        Task<bool> GetAll(Gen_IssueTypeRequest message, ICRUDRequestHandler<Gen_IssueTypeResponse> outputPort);


        Task<bool> GetAllPaged(Gen_IssueTypeRequest message, ICRUDRequestHandler<Gen_IssueTypeResponse> outputPort);

        Task<bool> GetListView(Gen_IssueTypeRequest message, ICRUDRequestHandler<Gen_IssueTypeResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Gen_IssueTypeRequest message, IDDLRequestHandler<Gen_IssueTypeResponse> outputPort);
    
    }
}
