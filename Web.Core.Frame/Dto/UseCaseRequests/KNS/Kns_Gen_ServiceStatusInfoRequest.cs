using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Kns_Gen_ServiceStatusInfoRequest : IUseCaseRequest<Kns_Gen_ServiceStatusInfoResponse>
    {
        public kns_gen_servicestatusinfoEntity Objkns_gen_servicestatusinfo { get; }
        
        public Kns_Gen_ServiceStatusInfoRequest(kns_gen_servicestatusinfoEntity objkns_gen_servicestatusinfo)
        {
            Objkns_gen_servicestatusinfo = objkns_gen_servicestatusinfo;
        }
    }
}
