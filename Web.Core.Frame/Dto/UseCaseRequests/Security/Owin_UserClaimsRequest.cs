using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Owin_UserClaimsRequest : IUseCaseRequest<Owin_UserClaimsResponse>
    {
        public owin_userclaimsEntity Objowin_userclaims { get; }
        
        public Owin_UserClaimsRequest(owin_userclaimsEntity objowin_userclaims)
        {
            Objowin_userclaims = objowin_userclaims;
        }
    }
}
