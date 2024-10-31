using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_ImageGallaryUseCase : IUseCaseRequestHandler<Gen_ImageGallaryRequest, Gen_ImageGallaryResponse>
    {
        Task<bool> Save(Gen_ImageGallaryRequest message, ICRUDRequestHandler<Gen_ImageGallaryResponse> outputPort);

        Task<bool> Update(Gen_ImageGallaryRequest message, ICRUDRequestHandler<Gen_ImageGallaryResponse> outputPort);

        Task<bool> Delete(Gen_ImageGallaryRequest message, ICRUDRequestHandler<Gen_ImageGallaryResponse> outputPort);


        Task<bool> GetSingle(Gen_ImageGallaryRequest message, ICRUDRequestHandler<Gen_ImageGallaryResponse> outputPort);

        Task<bool> GetAll(Gen_ImageGallaryRequest message, ICRUDRequestHandler<Gen_ImageGallaryResponse> outputPort);


        Task<bool> GetAllPaged(Gen_ImageGallaryRequest message, ICRUDRequestHandler<Gen_ImageGallaryResponse> outputPort);

        Task<bool> GetListView(Gen_ImageGallaryRequest message, ICRUDRequestHandler<Gen_ImageGallaryResponse> outputPort);
        
        
            
    }
}
