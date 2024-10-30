using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Kns_Gen_EducationGradeRequest : IUseCaseRequest<Kns_Gen_EducationGradeResponse>
    {
        public kns_gen_educationgradeEntity Objkns_gen_educationgrade { get; }
        
        public Kns_Gen_EducationGradeRequest(kns_gen_educationgradeEntity objkns_gen_educationgrade)
        {
            Objkns_gen_educationgrade = objkns_gen_educationgrade;
        }
    }
}
