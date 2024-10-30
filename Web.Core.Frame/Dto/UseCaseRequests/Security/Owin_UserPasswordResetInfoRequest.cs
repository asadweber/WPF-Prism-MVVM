using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Owin_UserPasswordResetInfoRequest : IUseCaseRequest<Owin_UserPasswordResetInfoResponse>
    {
        public owin_userpasswordresetinfoEntity Objowin_userpasswordresetinfo { get; }
        
        public Owin_UserPasswordResetInfoRequest(owin_userpasswordresetinfoEntity objowin_userpasswordresetinfo)
        {
            Objowin_userpasswordresetinfo = objowin_userpasswordresetinfo;
        }
    }
}
