using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_BatchUseCase : IUseCaseRequestHandler<Kns_BatchRequest, Kns_BatchResponse>
    {
        Task<bool> Save(Kns_BatchRequest message, ICRUDRequestHandler<Kns_BatchResponse> outputPort);

        Task<bool> Update(Kns_BatchRequest message, ICRUDRequestHandler<Kns_BatchResponse> outputPort);

        Task<bool> Delete(Kns_BatchRequest message, ICRUDRequestHandler<Kns_BatchResponse> outputPort);

        Task<bool> GetSingle(Kns_BatchRequest message, ICRUDRequestHandler<Kns_BatchResponse> outputPort);

        Task<bool> GetAll(Kns_BatchRequest message, ICRUDRequestHandler<Kns_BatchResponse> outputPort);

        Task<bool> GetAllPaged(Kns_BatchRequest message, ICRUDRequestHandler<Kns_BatchResponse> outputPort);

        Task<bool> GetListView(Kns_BatchRequest message, ICRUDRequestHandler<Kns_BatchResponse> outputPort);
        
        Task<bool> GetDataForDropDown(Kns_BatchRequest message, IDDLRequestHandler<Kns_BatchResponse> outputPort);
    
    }
}
