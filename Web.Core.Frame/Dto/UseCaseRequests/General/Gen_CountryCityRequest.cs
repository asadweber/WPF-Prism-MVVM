using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_CountryCityRequest : IUseCaseRequest<Gen_CountryCityResponse>
    {
        public gen_countrycityEntity Objgen_countrycity { get; }
        
        public Gen_CountryCityRequest(gen_countrycityEntity objgen_countrycity)
        {
            Objgen_countrycity = objgen_countrycity;
        }
    }
}
