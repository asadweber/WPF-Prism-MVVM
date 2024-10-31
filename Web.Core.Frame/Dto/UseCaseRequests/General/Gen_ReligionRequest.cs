using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_ReligionRequest : IUseCaseRequest<Gen_ReligionResponse>
    {
        public gen_religionEntity Objgen_religion { get; }
        
        public Gen_ReligionRequest(gen_religionEntity objgen_religion)
        {
            Objgen_religion = objgen_religion;
        }
    }
}
