using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_EContactListUseCase : IUseCaseRequestHandler<Gen_EContactListRequest, Gen_EContactListResponse>
    {
        Task<bool> GetFamilyRelationDataForDropDown(Gen_EContactListRequest message, IDDLRequestHandler<Gen_EContactListResponse> outputPort);
    }
}
