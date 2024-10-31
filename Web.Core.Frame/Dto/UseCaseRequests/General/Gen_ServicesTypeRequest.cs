using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_ServicesTypeRequest : IUseCaseRequest<Gen_ServicesTypeResponse>
    {
        public gen_servicestypeEntity Objgen_servicestype { get; }
        
        public Gen_ServicesTypeRequest(gen_servicestypeEntity objgen_servicestype)
        {
            Objgen_servicestype = objgen_servicestype;
        }
    }
}
