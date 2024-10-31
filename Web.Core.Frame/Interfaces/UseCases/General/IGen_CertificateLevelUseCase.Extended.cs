using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_CertificateLevelUseCase : IUseCaseRequestHandler<Gen_CertificateLevelRequest, Gen_CertificateLevelResponse>
    {
        		Task<bool> GetCertificateLevelDataForDropDown(Gen_CertificateLevelRequest message, IDDLRequestHandler<Gen_CertificateLevelResponse> outputPort);

    }
}
