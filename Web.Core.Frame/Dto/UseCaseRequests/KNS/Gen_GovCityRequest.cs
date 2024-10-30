using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_GovCityRequest : IUseCaseRequest<Gen_GovCityResponse>
    {
        public gen_govcityEntity Objgen_govcity { get; }
        
        public Gen_GovCityRequest(gen_govcityEntity objgen_govcity)
        {
            Objgen_govcity = objgen_govcity;
        }
    }
}
