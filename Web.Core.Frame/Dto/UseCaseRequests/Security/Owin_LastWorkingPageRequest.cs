using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Owin_LastWorkingPageRequest : IUseCaseRequest<Owin_LastWorkingPageResponse>
    {
        public owin_lastworkingpageEntity Objowin_lastworkingpage { get; }
        
        public Owin_LastWorkingPageRequest(owin_lastworkingpageEntity objowin_lastworkingpage)
        {
            Objowin_lastworkingpage = objowin_lastworkingpage;
        }
    }
}
