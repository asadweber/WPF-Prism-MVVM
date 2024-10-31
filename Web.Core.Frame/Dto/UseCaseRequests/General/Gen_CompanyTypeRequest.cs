using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_CompanyTypeRequest : IUseCaseRequest<Gen_CompanyTypeResponse>
    {
        public gen_companytypeEntity Objgen_companytype { get; }
        
        public Gen_CompanyTypeRequest(gen_companytypeEntity objgen_companytype)
        {
            Objgen_companytype = objgen_companytype;
        }
    }
}
