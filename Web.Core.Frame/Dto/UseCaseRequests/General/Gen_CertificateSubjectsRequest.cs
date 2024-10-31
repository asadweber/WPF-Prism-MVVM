using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_CertificateSubjectsRequest : IUseCaseRequest<Gen_CertificateSubjectsResponse>
    {
        public gen_certificatesubjectsEntity Objgen_certificatesubjects { get; }
        
        public Gen_CertificateSubjectsRequest(gen_certificatesubjectsEntity objgen_certificatesubjects)
        {
            Objgen_certificatesubjects = objgen_certificatesubjects;
        }
    }
}
