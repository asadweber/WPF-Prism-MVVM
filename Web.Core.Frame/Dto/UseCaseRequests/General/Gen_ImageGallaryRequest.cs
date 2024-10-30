using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_ImageGallaryRequest : IUseCaseRequest<Gen_ImageGallaryResponse>
    {
        public gen_imagegallaryEntity Objgen_imagegallary { get; }
        
        public Gen_ImageGallaryRequest(gen_imagegallaryEntity objgen_imagegallary)
        {
            Objgen_imagegallary = objgen_imagegallary;
        }
    }
}
