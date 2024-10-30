using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Kns_Tran_RegEducationInfoRequest : IUseCaseRequest<Kns_Tran_RegEducationInfoResponse>
    {
        public kns_tran_regeducationinfoEntity Objkns_tran_regeducationinfo { get; }
        
        public Kns_Tran_RegEducationInfoRequest(kns_tran_regeducationinfoEntity objkns_tran_regeducationinfo)
        {
            Objkns_tran_regeducationinfo = objkns_tran_regeducationinfo;
        }
    }
}
