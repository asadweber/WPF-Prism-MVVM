using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_LanguagesRequest : IUseCaseRequest<Gen_LanguagesResponse>
    {
        public gen_languagesEntity Objgen_languages { get; }
        
        public Gen_LanguagesRequest(gen_languagesEntity objgen_languages)
        {
            Objgen_languages = objgen_languages;
        }
    }
}
