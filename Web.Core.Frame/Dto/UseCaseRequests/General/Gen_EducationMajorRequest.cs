using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_EducationMajorRequest : IUseCaseRequest<Gen_EducationMajorResponse>
    {
        public gen_educationmajorEntity Objgen_educationmajor { get; }
        
        public Gen_EducationMajorRequest(gen_educationmajorEntity objgen_educationmajor)
        {
            Objgen_educationmajor = objgen_educationmajor;
        }
    }
}
