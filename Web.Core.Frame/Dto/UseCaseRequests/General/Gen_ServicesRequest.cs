using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_ServicesRequest : IUseCaseRequest<Gen_ServicesResponse>
    {
        public gen_servicesEntity Objgen_services { get; }
        
        public Gen_ServicesRequest(gen_servicesEntity objgen_services)
        {
            Objgen_services = objgen_services;
        }
    }
}
