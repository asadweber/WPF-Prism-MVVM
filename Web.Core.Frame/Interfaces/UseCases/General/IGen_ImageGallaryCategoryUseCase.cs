using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_ImageGallaryCategoryUseCase : IUseCaseRequestHandler<Gen_ImageGallaryCategoryRequest, Gen_ImageGallaryCategoryResponse>
    {
        Task<bool> Save(Gen_ImageGallaryCategoryRequest message, ICRUDRequestHandler<Gen_ImageGallaryCategoryResponse> outputPort);

        Task<bool> Update(Gen_ImageGallaryCategoryRequest message, ICRUDRequestHandler<Gen_ImageGallaryCategoryResponse> outputPort);

        Task<bool> Delete(Gen_ImageGallaryCategoryRequest message, ICRUDRequestHandler<Gen_ImageGallaryCategoryResponse> outputPort);


        Task<bool> GetSingle(Gen_ImageGallaryCategoryRequest message, ICRUDRequestHandler<Gen_ImageGallaryCategoryResponse> outputPort);

        Task<bool> GetAll(Gen_ImageGallaryCategoryRequest message, ICRUDRequestHandler<Gen_ImageGallaryCategoryResponse> outputPort);


        Task<bool> GetAllPaged(Gen_ImageGallaryCategoryRequest message, ICRUDRequestHandler<Gen_ImageGallaryCategoryResponse> outputPort);

        Task<bool> GetListView(Gen_ImageGallaryCategoryRequest message, ICRUDRequestHandler<Gen_ImageGallaryCategoryResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Gen_ImageGallaryCategoryRequest message, IDDLRequestHandler<Gen_ImageGallaryCategoryResponse> outputPort);
    
    }
}
