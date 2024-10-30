using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Kns_StatusChangeRequestRequest : IUseCaseRequest<Kns_StatusChangeRequestResponse>
    {
        public kns_statuschangerequestEntity Objkns_statuschangerequest { get; }
        
        public Kns_StatusChangeRequestRequest(kns_statuschangerequestEntity objkns_statuschangerequest)
        {
            Objkns_statuschangerequest = objkns_statuschangerequest;
        }
    }
}
