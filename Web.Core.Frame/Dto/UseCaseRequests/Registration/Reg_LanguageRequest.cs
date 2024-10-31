using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseRequests.Registration
{
    public partial class Reg_LanguageRequest : IUseCaseRequest<Reg_LanguageResponse>
    {
        public reg_languageEntity Objreg_language { get; }

        public Reg_LanguageRequest(reg_languageEntity objreg_language)
        {
            Objreg_language = objreg_language;
        }
    }
}
