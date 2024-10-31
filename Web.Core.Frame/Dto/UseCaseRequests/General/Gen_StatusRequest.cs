using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_StatusRequest : IUseCaseRequest<Gen_StatusResponse>
    {
        public gen_statusEntity Objgen_status { get; }
        
        public Gen_StatusRequest(gen_statusEntity objgen_status)
        {
            Objgen_status = objgen_status;
        }
    }
}
