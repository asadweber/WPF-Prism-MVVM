using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Kns_StatusChangeRequestResolutionRequest : IUseCaseRequest<Kns_StatusChangeRequestResolutionResponse>
    {
        public kns_statuschangerequestresolutionEntity Objkns_statuschangerequestresolution { get; }
        
        public Kns_StatusChangeRequestResolutionRequest(kns_statuschangerequestresolutionEntity objkns_statuschangerequestresolution)
        {
            Objkns_statuschangerequestresolution = objkns_statuschangerequestresolution;
        }
    }
}
