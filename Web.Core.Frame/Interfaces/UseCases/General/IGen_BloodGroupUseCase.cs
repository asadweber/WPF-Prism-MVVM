using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_BloodGroupUseCase : IUseCaseRequestHandler<Gen_BloodGroupRequest, Gen_BloodGroupResponse>
    {
        Task<bool> Save(Gen_BloodGroupRequest message, ICRUDRequestHandler<Gen_BloodGroupResponse> outputPort);

        Task<bool> Update(Gen_BloodGroupRequest message, ICRUDRequestHandler<Gen_BloodGroupResponse> outputPort);

        Task<bool> Delete(Gen_BloodGroupRequest message, ICRUDRequestHandler<Gen_BloodGroupResponse> outputPort);


        Task<bool> GetSingle(Gen_BloodGroupRequest message, ICRUDRequestHandler<Gen_BloodGroupResponse> outputPort);

        Task<bool> GetAll(Gen_BloodGroupRequest message, ICRUDRequestHandler<Gen_BloodGroupResponse> outputPort);


        Task<bool> GetAllPaged(Gen_BloodGroupRequest message, ICRUDRequestHandler<Gen_BloodGroupResponse> outputPort);

        Task<bool> GetListView(Gen_BloodGroupRequest message, ICRUDRequestHandler<Gen_BloodGroupResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Gen_BloodGroupRequest message, IDDLRequestHandler<Gen_BloodGroupResponse> outputPort);
    
    }
}
