using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_NonKuwaityStatusRequest : IUseCaseRequest<Gen_NonKuwaityStatusResponse>
    {
        public gen_nonkuwaitystatusEntity Objgen_nonkuwaitystatus { get; }
        
        public Gen_NonKuwaityStatusRequest(gen_nonkuwaitystatusEntity objgen_nonkuwaitystatus)
        {
            Objgen_nonkuwaitystatus = objgen_nonkuwaitystatus;
        }
    }
}
