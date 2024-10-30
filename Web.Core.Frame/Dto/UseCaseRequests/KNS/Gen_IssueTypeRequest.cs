using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_IssueTypeRequest : IUseCaseRequest<Gen_IssueTypeResponse>
    {
        public gen_issuetypeEntity Objgen_issuetype { get; }
        
        public Gen_IssueTypeRequest(gen_issuetypeEntity objgen_issuetype)
        {
            Objgen_issuetype = objgen_issuetype;
        }
    }
}
