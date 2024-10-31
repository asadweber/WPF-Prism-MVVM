using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_NewsGalleryRequest : IUseCaseRequest<Gen_NewsGalleryResponse>
    {
        public gen_newsgalleryEntity Objgen_newsgallery { get; }
        
        public Gen_NewsGalleryRequest(gen_newsgalleryEntity objgen_newsgallery)
        {
            Objgen_newsgallery = objgen_newsgallery;
        }
    }
}
