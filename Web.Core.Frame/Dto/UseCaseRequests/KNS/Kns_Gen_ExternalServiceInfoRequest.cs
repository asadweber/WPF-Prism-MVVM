using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Kns_Gen_ExternalServiceInfoRequest : IUseCaseRequest<Kns_Gen_ExternalServiceInfoResponse>
    {
        public kns_gen_externalserviceinfoEntity Objkns_gen_externalserviceinfo { get; }
        
        public Kns_Gen_ExternalServiceInfoRequest(kns_gen_externalserviceinfoEntity objkns_gen_externalserviceinfo)
        {
            Objkns_gen_externalserviceinfo = objkns_gen_externalserviceinfo;
        }
    }
}
