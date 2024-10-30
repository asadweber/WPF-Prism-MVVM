using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Kns_Gen_CertificateSubjectsRequest : IUseCaseRequest<Kns_Gen_CertificateSubjectsResponse>
    {
        public kns_gen_certificatesubjectsEntity Objkns_gen_certificatesubjects { get; }
        
        public Kns_Gen_CertificateSubjectsRequest(kns_gen_certificatesubjectsEntity objkns_gen_certificatesubjects)
        {
            Objkns_gen_certificatesubjects = objkns_gen_certificatesubjects;
        }
    }
}
