using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_UsefulLinkCategoryRequest : IUseCaseRequest<Gen_UsefulLinkCategoryResponse>
    {
        public gen_usefullinkcategoryEntity Objgen_usefullinkcategory { get; }
        
        public Gen_UsefulLinkCategoryRequest(gen_usefullinkcategoryEntity objgen_usefullinkcategory)
        {
            Objgen_usefullinkcategory = objgen_usefullinkcategory;
        }
    }
}
