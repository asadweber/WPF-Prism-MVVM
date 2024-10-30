using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Kns_Tran_RegExternalServiceResultInfoRequest : IUseCaseRequest<Kns_Tran_RegExternalServiceResultInfoResponse>
    {
        public kns_tran_regexternalserviceresultinfoEntity Objkns_tran_regexternalserviceresultinfo { get; }
        
        public Kns_Tran_RegExternalServiceResultInfoRequest(kns_tran_regexternalserviceresultinfoEntity objkns_tran_regexternalserviceresultinfo)
        {
            Objkns_tran_regexternalserviceresultinfo = objkns_tran_regexternalserviceresultinfo;
        }
    }
}
