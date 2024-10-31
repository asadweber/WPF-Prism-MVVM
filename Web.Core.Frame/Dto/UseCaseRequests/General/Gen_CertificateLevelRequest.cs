using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_CertificateLevelRequest : IUseCaseRequest<Gen_CertificateLevelResponse>
    {
        public gen_certificatelevelEntity Objgen_certificatelevel { get; }
        
        public Gen_CertificateLevelRequest(gen_certificatelevelEntity objgen_certificatelevel)
        {
            Objgen_certificatelevel = objgen_certificatelevel;
        }
    }
}
