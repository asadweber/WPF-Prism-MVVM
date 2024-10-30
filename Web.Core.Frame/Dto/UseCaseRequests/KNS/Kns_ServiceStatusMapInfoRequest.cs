using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Kns_ServiceStatusMapInfoRequest : IUseCaseRequest<Kns_ServiceStatusMapInfoResponse>
    {
        public kns_servicestatusmapinfoEntity Objkns_servicestatusmapinfo { get; }
        
        public Kns_ServiceStatusMapInfoRequest(kns_servicestatusmapinfoEntity objkns_servicestatusmapinfo)
        {
            Objkns_servicestatusmapinfo = objkns_servicestatusmapinfo;
        }
    }
}
