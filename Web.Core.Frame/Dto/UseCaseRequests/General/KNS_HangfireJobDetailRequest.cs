using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class KNS_HangfireJobDetailRequest : IUseCaseRequest<KNS_HangfireJobDetailResponse>
    {
        public kns_hangfirejobdetailEntity Objkns_hangfirejobdetail { get; }
        
        public KNS_HangfireJobDetailRequest(kns_hangfirejobdetailEntity objkns_hangfirejobdetail)
        {
            Objkns_hangfirejobdetail = objkns_hangfirejobdetail;
        }
    }
}
