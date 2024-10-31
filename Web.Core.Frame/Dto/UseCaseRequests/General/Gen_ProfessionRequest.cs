using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_ProfessionRequest : IUseCaseRequest<Gen_ProfessionResponse>
    {
        public gen_professionEntity Objgen_profession { get; }
        
        public Gen_ProfessionRequest(gen_professionEntity objgen_profession)
        {
            Objgen_profession = objgen_profession;
        }
    }
}
