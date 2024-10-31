using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_CertificateSubjectsUseCase : IUseCaseRequestHandler<Gen_CertificateSubjectsRequest, Gen_CertificateSubjectsResponse>
    {
        Task<bool> GetListViewExt(Gen_CertificateSubjectsRequest message, ICRUDRequestHandler<Gen_CertificateSubjectsResponse> outputPort);
        Task<bool> GetMajorSubjectByCertificateIdForDropdown(Gen_CertificateSubjectsRequest message, IDDLRequestHandler<Gen_CertificateSubjectsResponse> outputPort);

    }
}
