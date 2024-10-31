using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_EducationShiftRequest : IUseCaseRequest<Gen_EducationShiftResponse>
    {
        public gen_educationshiftEntity Objgen_educationshift { get; }
        
        public Gen_EducationShiftRequest(gen_educationshiftEntity objgen_educationshift)
        {
            Objgen_educationshift = objgen_educationshift;
        }
    }
}
