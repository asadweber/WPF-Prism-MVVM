using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_FAQCategoryRequest : IUseCaseRequest<Gen_FAQCategoryResponse>
    {
        public gen_faqcategoryEntity Objgen_faqcategory { get; }
        
        public Gen_FAQCategoryRequest(gen_faqcategoryEntity objgen_faqcategory)
        {
            Objgen_faqcategory = objgen_faqcategory;
        }
    }
}
