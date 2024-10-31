using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_NewsGalleryUseCase : IUseCaseRequestHandler<Gen_NewsGalleryRequest, Gen_NewsGalleryResponse>
    {
        Task<bool> Save(Gen_NewsGalleryRequest message, ICRUDRequestHandler<Gen_NewsGalleryResponse> outputPort);

        Task<bool> Update(Gen_NewsGalleryRequest message, ICRUDRequestHandler<Gen_NewsGalleryResponse> outputPort);

        Task<bool> Delete(Gen_NewsGalleryRequest message, ICRUDRequestHandler<Gen_NewsGalleryResponse> outputPort);


        Task<bool> GetSingle(Gen_NewsGalleryRequest message, ICRUDRequestHandler<Gen_NewsGalleryResponse> outputPort);

        Task<bool> GetAll(Gen_NewsGalleryRequest message, ICRUDRequestHandler<Gen_NewsGalleryResponse> outputPort);


        Task<bool> GetAllPaged(Gen_NewsGalleryRequest message, ICRUDRequestHandler<Gen_NewsGalleryResponse> outputPort);

        Task<bool> GetListView(Gen_NewsGalleryRequest message, ICRUDRequestHandler<Gen_NewsGalleryResponse> outputPort);
        
        
            
    }
}
