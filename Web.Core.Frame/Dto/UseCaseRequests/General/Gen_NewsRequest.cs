using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_NewsRequest : IUseCaseRequest<Gen_NewsResponse>
    {
        public gen_newsEntity Objgen_news { get; }

        
        public Gen_NewsRequest(gen_newsEntity objgen_news)
        {
            Objgen_news = objgen_news;
        }
    }
}
