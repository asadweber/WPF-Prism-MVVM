using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_GeneralLookRequest : IUseCaseRequest<Gen_GeneralLookResponse>
    {
        public gen_generallookEntity Objgen_generallook { get; }
        
        public Gen_GeneralLookRequest(gen_generallookEntity objgen_generallook)
        {
            Objgen_generallook = objgen_generallook;
        }
    }
}
