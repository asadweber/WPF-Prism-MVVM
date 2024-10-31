using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_ResidentTypeRequest : IUseCaseRequest<Gen_ResidentTypeResponse>
    {
        public gen_residenttypeEntity Objgen_residenttype { get; }
        
        public Gen_ResidentTypeRequest(gen_residenttypeEntity objgen_residenttype)
        {
            Objgen_residenttype = objgen_residenttype;
        }
    }
}
