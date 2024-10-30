using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Kns_Gen_CertificateRequest : IUseCaseRequest<Kns_Gen_CertificateResponse>
    {
        public kns_gen_certificateEntity Objkns_gen_certificate { get; }
        
        public Kns_Gen_CertificateRequest(kns_gen_certificateEntity objkns_gen_certificate)
        {
            Objkns_gen_certificate = objkns_gen_certificate;
        }
    }
}
