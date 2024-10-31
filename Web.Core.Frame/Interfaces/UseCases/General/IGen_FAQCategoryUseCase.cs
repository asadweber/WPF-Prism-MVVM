using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_FAQCategoryUseCase : IUseCaseRequestHandler<Gen_FAQCategoryRequest, Gen_FAQCategoryResponse>
    {
        Task<bool> Save(Gen_FAQCategoryRequest message, ICRUDRequestHandler<Gen_FAQCategoryResponse> outputPort);

        Task<bool> Update(Gen_FAQCategoryRequest message, ICRUDRequestHandler<Gen_FAQCategoryResponse> outputPort);

        Task<bool> Delete(Gen_FAQCategoryRequest message, ICRUDRequestHandler<Gen_FAQCategoryResponse> outputPort);


        Task<bool> GetSingle(Gen_FAQCategoryRequest message, ICRUDRequestHandler<Gen_FAQCategoryResponse> outputPort);

        Task<bool> GetAll(Gen_FAQCategoryRequest message, ICRUDRequestHandler<Gen_FAQCategoryResponse> outputPort);


        Task<bool> GetAllPaged(Gen_FAQCategoryRequest message, ICRUDRequestHandler<Gen_FAQCategoryResponse> outputPort);

        Task<bool> GetListView(Gen_FAQCategoryRequest message, ICRUDRequestHandler<Gen_FAQCategoryResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Gen_FAQCategoryRequest message, IDDLRequestHandler<Gen_FAQCategoryResponse> outputPort);
    
    }
}
