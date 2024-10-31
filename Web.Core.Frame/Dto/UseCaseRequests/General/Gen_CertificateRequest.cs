using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_CertificateRequest : IUseCaseRequest<Gen_CertificateResponse>
    {
        public gen_certificateEntity Objgen_certificate { get; }
        
        public Gen_CertificateRequest(gen_certificateEntity objgen_certificate)
        {
            Objgen_certificate = objgen_certificate;
        }
    }
}
