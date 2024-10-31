using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_BloodGroupUseCase : IUseCaseRequestHandler<Gen_BloodGroupRequest, Gen_BloodGroupResponse>
    {
        Task<bool> GetBloodGroupDataForDropDown(Gen_BloodGroupRequest message, IDDLRequestHandler<Gen_BloodGroupResponse> outputPort);
    }
}
