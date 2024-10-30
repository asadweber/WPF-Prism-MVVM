using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Owin_UserPrefferencesSettingsRequest : IUseCaseRequest<Owin_UserPrefferencesSettingsResponse>
    {
        public owin_userprefferencessettingsEntity Objowin_userprefferencessettings { get; }
        
        public Owin_UserPrefferencesSettingsRequest(owin_userprefferencessettingsEntity objowin_userprefferencessettings)
        {
            Objowin_userprefferencessettings = objowin_userprefferencessettings;
        }
    }
}
