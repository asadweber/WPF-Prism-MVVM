using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_FaqRequest : IUseCaseRequest<Gen_FaqResponse>
    {
        public gen_faqEntity Objgen_faq { get; }
        
        public Gen_FaqRequest(gen_faqEntity objgen_faq)
        {
            Objgen_faq = objgen_faq;
        }
    }
}
