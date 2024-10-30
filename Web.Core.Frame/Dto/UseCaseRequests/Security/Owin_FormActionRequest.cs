using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Owin_FormActionRequest : IUseCaseRequest<Owin_FormActionResponse>
    {
        public owin_formactionEntity Objowin_formaction { get; }
        
        public Owin_FormActionRequest(owin_formactionEntity objowin_formaction)
        {
            Objowin_formaction = objowin_formaction;
        }
    }
}
