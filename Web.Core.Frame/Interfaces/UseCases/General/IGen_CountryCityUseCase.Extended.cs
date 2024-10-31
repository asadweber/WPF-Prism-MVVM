using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_CountryCityUseCase : IUseCaseRequestHandler<Gen_CountryCityRequest, Gen_CountryCityResponse>
    {
        Task<bool> GetGovernateDropDown(Gen_CountryCityRequest message, IDDLRequestHandler<Gen_CountryCityResponse> outputPort);
    }
}
