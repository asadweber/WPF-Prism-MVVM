using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_CertificateUseCase : IUseCaseRequestHandler<Gen_CertificateRequest, Gen_CertificateResponse>
    {
        Task<bool> GetCertificatebyCertificateLevel(Gen_CertificateRequest message, IDDLRequestHandler<Gen_CertificateResponse> outputPort);
        
        Task<bool> GetListViewExt(Gen_CertificateRequest message, ICRUDRequestHandler<Gen_CertificateResponse> outputPort);

        //For Web Admin
        Task<bool> GetBatchCandidateTypeWiseCertificateDropDown(Gen_CertificateRequest message, IDDLRequestHandler<Gen_CertificateResponse> outputPort);
    }
}
