using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_BatchUnitListUseCase : IUseCaseRequestHandler<Gen_BatchUnitListRequest, Gen_BatchUnitListResponse>
    {
        Task<bool> Save(Gen_BatchUnitListRequest message, ICRUDRequestHandler<Gen_BatchUnitListResponse> outputPort);

        Task<bool> Update(Gen_BatchUnitListRequest message, ICRUDRequestHandler<Gen_BatchUnitListResponse> outputPort);

        Task<bool> Delete(Gen_BatchUnitListRequest message, ICRUDRequestHandler<Gen_BatchUnitListResponse> outputPort);


        Task<bool> GetSingle(Gen_BatchUnitListRequest message, ICRUDRequestHandler<Gen_BatchUnitListResponse> outputPort);

        Task<bool> GetAll(Gen_BatchUnitListRequest message, ICRUDRequestHandler<Gen_BatchUnitListResponse> outputPort);


        Task<bool> GetAllPaged(Gen_BatchUnitListRequest message, ICRUDRequestHandler<Gen_BatchUnitListResponse> outputPort);

        Task<bool> GetListView(Gen_BatchUnitListRequest message, ICRUDRequestHandler<Gen_BatchUnitListResponse> outputPort);
        
        
            
    }
}
