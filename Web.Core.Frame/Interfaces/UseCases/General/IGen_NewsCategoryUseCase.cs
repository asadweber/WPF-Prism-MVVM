using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_NewsCategoryUseCase : IUseCaseRequestHandler<Gen_NewsCategoryRequest, Gen_NewsCategoryResponse>
    {
        Task<bool> Save(Gen_NewsCategoryRequest message, ICRUDRequestHandler<Gen_NewsCategoryResponse> outputPort);

        Task<bool> Update(Gen_NewsCategoryRequest message, ICRUDRequestHandler<Gen_NewsCategoryResponse> outputPort);

        Task<bool> Delete(Gen_NewsCategoryRequest message, ICRUDRequestHandler<Gen_NewsCategoryResponse> outputPort);


        Task<bool> GetSingle(Gen_NewsCategoryRequest message, ICRUDRequestHandler<Gen_NewsCategoryResponse> outputPort);

        Task<bool> GetAll(Gen_NewsCategoryRequest message, ICRUDRequestHandler<Gen_NewsCategoryResponse> outputPort);


        Task<bool> GetAllPaged(Gen_NewsCategoryRequest message, ICRUDRequestHandler<Gen_NewsCategoryResponse> outputPort);

        Task<bool> GetListView(Gen_NewsCategoryRequest message, ICRUDRequestHandler<Gen_NewsCategoryResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Gen_NewsCategoryRequest message, IDDLRequestHandler<Gen_NewsCategoryResponse> outputPort);
    
    }
}
