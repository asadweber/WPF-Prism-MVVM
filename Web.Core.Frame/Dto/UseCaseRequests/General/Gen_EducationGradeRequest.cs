using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_EducationGradeRequest : IUseCaseRequest<Gen_EducationGradeResponse>
    {
        public gen_educationgradeEntity Objgen_educationgrade { get; }
        
        public Gen_EducationGradeRequest(gen_educationgradeEntity objgen_educationgrade)
        {
            Objgen_educationgrade = objgen_educationgrade;
        }
    }
}
