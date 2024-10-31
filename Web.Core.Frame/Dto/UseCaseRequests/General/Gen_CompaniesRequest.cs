using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_CompaniesRequest : IUseCaseRequest<Gen_CompaniesResponse>
    {
        public gen_companiesEntity Objgen_companies { get; }
        
        public Gen_CompaniesRequest(gen_companiesEntity objgen_companies)
        {
            Objgen_companies = objgen_companies;
        }
    }
}
