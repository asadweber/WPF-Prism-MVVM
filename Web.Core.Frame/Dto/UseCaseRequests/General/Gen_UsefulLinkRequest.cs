using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_UsefulLinkRequest : IUseCaseRequest<Gen_UsefulLinkResponse>
    {
        public gen_usefullinkEntity Objgen_usefullink { get; }
        
        public Gen_UsefulLinkRequest(gen_usefullinkEntity objgen_usefullink)
        {
            Objgen_usefullink = objgen_usefullink;
        }
    }
}
