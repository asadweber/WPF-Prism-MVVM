using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_ImageGallaryCategoryRequest : IUseCaseRequest<Gen_ImageGallaryCategoryResponse>
    {
        public gen_imagegallarycategoryEntity Objgen_imagegallarycategory { get; }
        
        public Gen_ImageGallaryCategoryRequest(gen_imagegallarycategoryEntity objgen_imagegallarycategory)
        {
            Objgen_imagegallarycategory = objgen_imagegallarycategory;
        }
    }
}
