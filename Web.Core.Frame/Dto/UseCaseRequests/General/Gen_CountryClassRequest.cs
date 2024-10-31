using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_CountryClassRequest : IUseCaseRequest<Gen_CountryClassResponse>
    {
        public gen_countryclassEntity Objgen_countryclass { get; }
        
        public Gen_CountryClassRequest(gen_countryclassEntity objgen_countryclass)
        {
            Objgen_countryclass = objgen_countryclass;
        }
    }
}
