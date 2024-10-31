using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_CountryRequest : IUseCaseRequest<Gen_CountryResponse>
    {
        public gen_countryEntity Objgen_country { get; }
        
        public Gen_CountryRequest(gen_countryEntity objgen_country)
        {
            Objgen_country = objgen_country;
        }
    }
}
