using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Kns_Gen_ServiceInfoRequest : IUseCaseRequest<Kns_Gen_ServiceInfoResponse>
    {
        public kns_gen_serviceinfoEntity Objkns_gen_serviceinfo { get; }
        
        public Kns_Gen_ServiceInfoRequest(kns_gen_serviceinfoEntity objkns_gen_serviceinfo)
        {
            Objkns_gen_serviceinfo = objkns_gen_serviceinfo;
        }
    }
}
