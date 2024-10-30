using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_Gen_ReasonUseCase : IUseCaseRequestHandler<Kns_Gen_ReasonRequest, Kns_Gen_ReasonResponse>
    {
        Task<bool> Save(Kns_Gen_ReasonRequest message, ICRUDRequestHandler<Kns_Gen_ReasonResponse> outputPort);

        Task<bool> Update(Kns_Gen_ReasonRequest message, ICRUDRequestHandler<Kns_Gen_ReasonResponse> outputPort);

        Task<bool> Delete(Kns_Gen_ReasonRequest message, ICRUDRequestHandler<Kns_Gen_ReasonResponse> outputPort);


        Task<bool> GetSingle(Kns_Gen_ReasonRequest message, ICRUDRequestHandler<Kns_Gen_ReasonResponse> outputPort);

        Task<bool> GetAll(Kns_Gen_ReasonRequest message, ICRUDRequestHandler<Kns_Gen_ReasonResponse> outputPort);


        Task<bool> GetAllPaged(Kns_Gen_ReasonRequest message, ICRUDRequestHandler<Kns_Gen_ReasonResponse> outputPort);

        Task<bool> GetListView(Kns_Gen_ReasonRequest message, ICRUDRequestHandler<Kns_Gen_ReasonResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Kns_Gen_ReasonRequest message, IDDLRequestHandler<Kns_Gen_ReasonResponse> outputPort);
    
    }
}
