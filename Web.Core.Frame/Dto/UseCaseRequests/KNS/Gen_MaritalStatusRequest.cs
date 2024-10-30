using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_MaritalStatusRequest : IUseCaseRequest<Gen_MaritalStatusResponse>
    {
        public gen_maritalstatusEntity Objgen_maritalstatus { get; }

        public Gen_MaritalStatusRequest(gen_maritalstatusEntity objgen_maritalstatus)
        {
            Objgen_maritalstatus = objgen_maritalstatus;
        }
    }
}
