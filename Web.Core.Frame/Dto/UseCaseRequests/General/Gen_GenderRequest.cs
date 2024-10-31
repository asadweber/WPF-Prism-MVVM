using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_GenderRequest : IUseCaseRequest<Gen_GenderResponse>
    {
        public gen_genderEntity Objgen_gender { get; }
        
        public Gen_GenderRequest(gen_genderEntity objgen_gender)
        {
            Objgen_gender = objgen_gender;
        }
    }
}
