using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public class HomeRequest : IUseCaseRequest<HomeResponse>
    {
        public owin_userEntity Objowin_userentity { get; }
        
        public HomeRequest(owin_userEntity objowin_userentity)
        {
            Objowin_userentity = objowin_userentity;
        }


    }
}
