using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Owin_UserStatusChangeHistoryRequest : IUseCaseRequest<Owin_UserStatusChangeHistoryResponse>
    {
        public owin_userstatuschangehistoryEntity Objowin_userstatuschangehistory { get; }
        
        public Owin_UserStatusChangeHistoryRequest(owin_userstatuschangehistoryEntity objowin_userstatuschangehistory)
        {
            Objowin_userstatuschangehistory = objowin_userstatuschangehistory;
        }
    }
}
