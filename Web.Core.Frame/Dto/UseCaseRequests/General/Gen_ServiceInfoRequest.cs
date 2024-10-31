using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_ServiceInfoRequest : IUseCaseRequest<Gen_ServiceInfoResponse>
    {
        public gen_serviceinfoEntity Objgen_serviceinfo { get; }
        
        public Gen_ServiceInfoRequest(gen_serviceinfoEntity objgen_serviceinfo)
        {
            Objgen_serviceinfo = objgen_serviceinfo;
        }
    }
}
