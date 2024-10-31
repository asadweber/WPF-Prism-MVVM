using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_ServiceStatusRequest : IUseCaseRequest<Gen_ServiceStatusResponse>
    {
        public gen_servicestatusEntity Objgen_servicestatus { get; }
        
        public Gen_ServiceStatusRequest(gen_servicestatusEntity objgen_servicestatus)
        {
            Objgen_servicestatus = objgen_servicestatus;
        }
    }
}
