using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Tran_RecievePaciDataInfoRequest : IUseCaseRequest<Tran_RecievePaciDataInfoResponse>
    {
        public tran_recievepacidatainfoEntity Objtran_recievepacidatainfo { get; }
        
        public Tran_RecievePaciDataInfoRequest(tran_recievepacidatainfoEntity objtran_recievepacidatainfo)
        {
            Objtran_recievepacidatainfo = objtran_recievepacidatainfo;
        }
    }
}
