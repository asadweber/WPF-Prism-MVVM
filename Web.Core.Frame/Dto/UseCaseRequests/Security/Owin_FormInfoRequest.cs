using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Owin_FormInfoRequest : IUseCaseRequest<Owin_FormInfoResponse>
    {
        public owin_forminfoEntity Objowin_forminfo { get; }
        
        public Owin_FormInfoRequest(owin_forminfoEntity objowin_forminfo)
        {
            Objowin_forminfo = objowin_forminfo;
        }
    }
}
