using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_SkillProficiencyRequest : IUseCaseRequest<Gen_SkillProficiencyResponse>
    {
        public gen_skillproficiencyEntity Objgen_skillproficiency { get; }
        
        public Gen_SkillProficiencyRequest(gen_skillproficiencyEntity objgen_skillproficiency)
        {
            Objgen_skillproficiency = objgen_skillproficiency;
        }
    }
}
