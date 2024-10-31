using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_CertificateTypeRequest : IUseCaseRequest<Gen_CertificateTypeResponse>
    {
        public gen_certificatetypeEntity Objgen_certificatetype { get; }
        
        public Gen_CertificateTypeRequest(gen_certificatetypeEntity objgen_certificatetype)
        {
            Objgen_certificatetype = objgen_certificatetype;
        }
    }
}
