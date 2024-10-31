using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Dto.UseCaseResponses.Transaction;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseRequests.Transaction
{
    public partial class Tran_RollbackInfoRequest : IUseCaseRequest<Tran_RollbackInfoResponse>
    {
        public tran_rollbackinfoEntity Objtran_rollbackinfo { get; }

        public Tran_RollbackInfoRequest(tran_rollbackinfoEntity objtran_rollbackinfo)
        {
            Objtran_rollbackinfo = objtran_rollbackinfo;
        }
    }
}
