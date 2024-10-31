using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_MaritalStatusUseCase : IUseCaseRequestHandler<Gen_MaritalStatusRequest, Gen_MaritalStatusResponse>
    {
        Task<bool> GetMaritalStatusDataForDropDown(Gen_MaritalStatusRequest message, IDDLRequestHandler<Gen_MaritalStatusResponse> outputPort);
    }
}
