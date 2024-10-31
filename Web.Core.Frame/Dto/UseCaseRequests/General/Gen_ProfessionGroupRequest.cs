using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_ProfessionGroupRequest : IUseCaseRequest<Gen_ProfessionGroupResponse>
    {
        public gen_professiongroupEntity Objgen_professiongroup { get; }
        
        public Gen_ProfessionGroupRequest(gen_professiongroupEntity objgen_professiongroup)
        {
            Objgen_professiongroup = objgen_professiongroup;
        }
    }
}
