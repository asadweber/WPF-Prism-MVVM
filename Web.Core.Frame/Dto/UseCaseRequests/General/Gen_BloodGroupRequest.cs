using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_BloodGroupRequest : IUseCaseRequest<Gen_BloodGroupResponse>
    {
        public gen_bloodgroupEntity Objgen_bloodgroup { get; }
        
        public Gen_BloodGroupRequest(gen_bloodgroupEntity objgen_bloodgroup)
        {
            Objgen_bloodgroup = objgen_bloodgroup;
        }
    }
}
