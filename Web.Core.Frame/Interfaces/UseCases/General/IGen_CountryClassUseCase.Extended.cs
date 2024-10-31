using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_CountryClassUseCase : IUseCaseRequestHandler<Gen_CountryClassRequest, Gen_CountryClassResponse>
    {
        Task<bool> GetCountryClassDropDown(Gen_CountryClassRequest message, IDDLRequestHandler<Gen_CountryClassResponse> outputPort);

    }
}
