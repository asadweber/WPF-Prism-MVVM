using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_BatchOrderUseCase : IUseCaseRequestHandler<Kns_BatchOrderRequest, Kns_BatchOrderResponse>
    {
        Task<bool> Save(Kns_BatchOrderRequest message, ICRUDRequestHandler<Kns_BatchOrderResponse> outputPort);

        Task<bool> Update(Kns_BatchOrderRequest message, ICRUDRequestHandler<Kns_BatchOrderResponse> outputPort);

        Task<bool> Delete(Kns_BatchOrderRequest message, ICRUDRequestHandler<Kns_BatchOrderResponse> outputPort);


        Task<bool> GetSingle(Kns_BatchOrderRequest message, ICRUDRequestHandler<Kns_BatchOrderResponse> outputPort);

        Task<bool> GetAll(Kns_BatchOrderRequest message, ICRUDRequestHandler<Kns_BatchOrderResponse> outputPort);


        Task<bool> GetAllPaged(Kns_BatchOrderRequest message, ICRUDRequestHandler<Kns_BatchOrderResponse> outputPort);

        Task<bool> GetListView(Kns_BatchOrderRequest message, ICRUDRequestHandler<Kns_BatchOrderResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Kns_BatchOrderRequest message, IDDLRequestHandler<Kns_BatchOrderResponse> outputPort);
    
    }
}
