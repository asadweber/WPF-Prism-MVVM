using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_NewsCategoryRequest : IUseCaseRequest<Gen_NewsCategoryResponse>
    {
        public gen_newscategoryEntity Objgen_newscategory { get; }
        
        public Gen_NewsCategoryRequest(gen_newscategoryEntity objgen_newscategory)
        {
            Objgen_newscategory = objgen_newscategory;
        }
    }
}
