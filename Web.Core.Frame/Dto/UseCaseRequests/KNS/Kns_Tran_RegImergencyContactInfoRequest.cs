using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Kns_Tran_RegImergencyContactInfoRequest : IUseCaseRequest<Kns_Tran_RegImergencyContactInfoResponse>
    {
        public kns_tran_regimergencycontactinfoEntity Objkns_tran_regimergencycontactinfo { get; }
        
        public Kns_Tran_RegImergencyContactInfoRequest(kns_tran_regimergencycontactinfoEntity objkns_tran_regimergencycontactinfo)
        {
            Objkns_tran_regimergencycontactinfo = objkns_tran_regimergencycontactinfo;
        }
    }
}
