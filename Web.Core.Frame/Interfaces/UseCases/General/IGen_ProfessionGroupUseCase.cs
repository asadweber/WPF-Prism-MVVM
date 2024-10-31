using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_ProfessionGroupUseCase : IUseCaseRequestHandler<Gen_ProfessionGroupRequest, Gen_ProfessionGroupResponse>
    {
        Task<bool> Save(Gen_ProfessionGroupRequest message, ICRUDRequestHandler<Gen_ProfessionGroupResponse> outputPort);

        Task<bool> Update(Gen_ProfessionGroupRequest message, ICRUDRequestHandler<Gen_ProfessionGroupResponse> outputPort);

        Task<bool> Delete(Gen_ProfessionGroupRequest message, ICRUDRequestHandler<Gen_ProfessionGroupResponse> outputPort);


        Task<bool> GetSingle(Gen_ProfessionGroupRequest message, ICRUDRequestHandler<Gen_ProfessionGroupResponse> outputPort);

        Task<bool> GetAll(Gen_ProfessionGroupRequest message, ICRUDRequestHandler<Gen_ProfessionGroupResponse> outputPort);


        Task<bool> GetAllPaged(Gen_ProfessionGroupRequest message, ICRUDRequestHandler<Gen_ProfessionGroupResponse> outputPort);

        Task<bool> GetListView(Gen_ProfessionGroupRequest message, ICRUDRequestHandler<Gen_ProfessionGroupResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Gen_ProfessionGroupRequest message, IDDLRequestHandler<Gen_ProfessionGroupResponse> outputPort);
    
    }
}
