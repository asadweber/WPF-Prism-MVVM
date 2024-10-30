using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_UsefulLinkCategoryUseCase : IUseCaseRequestHandler<Gen_UsefulLinkCategoryRequest, Gen_UsefulLinkCategoryResponse>
    {
        Task<bool> Save(Gen_UsefulLinkCategoryRequest message, ICRUDRequestHandler<Gen_UsefulLinkCategoryResponse> outputPort);

        Task<bool> Update(Gen_UsefulLinkCategoryRequest message, ICRUDRequestHandler<Gen_UsefulLinkCategoryResponse> outputPort);

        Task<bool> Delete(Gen_UsefulLinkCategoryRequest message, ICRUDRequestHandler<Gen_UsefulLinkCategoryResponse> outputPort);


        Task<bool> GetSingle(Gen_UsefulLinkCategoryRequest message, ICRUDRequestHandler<Gen_UsefulLinkCategoryResponse> outputPort);

        Task<bool> GetAll(Gen_UsefulLinkCategoryRequest message, ICRUDRequestHandler<Gen_UsefulLinkCategoryResponse> outputPort);


        Task<bool> GetAllPaged(Gen_UsefulLinkCategoryRequest message, ICRUDRequestHandler<Gen_UsefulLinkCategoryResponse> outputPort);

        Task<bool> GetListView(Gen_UsefulLinkCategoryRequest message, ICRUDRequestHandler<Gen_UsefulLinkCategoryResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Gen_UsefulLinkCategoryRequest message, IDDLRequestHandler<Gen_UsefulLinkCategoryResponse> outputPort);
    
    }
}
