using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Owin_UserLoginTrailRequest : IUseCaseRequest<Owin_UserLoginTrailResponse>
    {
        public owin_userlogintrailEntity Objowin_userlogintrail { get; }
        
        public Owin_UserLoginTrailRequest(owin_userlogintrailEntity objowin_userlogintrail)
        {
            Objowin_userlogintrail = objowin_userlogintrail;
        }
    }
}
