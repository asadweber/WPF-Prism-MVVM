using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_Gen_ReasonTypeUseCase : IUseCaseRequestHandler<Kns_Gen_ReasonTypeRequest, Kns_Gen_ReasonTypeResponse>
    {
        Task<bool> Save(Kns_Gen_ReasonTypeRequest message, ICRUDRequestHandler<Kns_Gen_ReasonTypeResponse> outputPort);

        Task<bool> Update(Kns_Gen_ReasonTypeRequest message, ICRUDRequestHandler<Kns_Gen_ReasonTypeResponse> outputPort);

        Task<bool> Delete(Kns_Gen_ReasonTypeRequest message, ICRUDRequestHandler<Kns_Gen_ReasonTypeResponse> outputPort);


        Task<bool> GetSingle(Kns_Gen_ReasonTypeRequest message, ICRUDRequestHandler<Kns_Gen_ReasonTypeResponse> outputPort);

        Task<bool> GetAll(Kns_Gen_ReasonTypeRequest message, ICRUDRequestHandler<Kns_Gen_ReasonTypeResponse> outputPort);


        Task<bool> GetAllPaged(Kns_Gen_ReasonTypeRequest message, ICRUDRequestHandler<Kns_Gen_ReasonTypeResponse> outputPort);

        Task<bool> GetListView(Kns_Gen_ReasonTypeRequest message, ICRUDRequestHandler<Kns_Gen_ReasonTypeResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Kns_Gen_ReasonTypeRequest message, IDDLRequestHandler<Kns_Gen_ReasonTypeResponse> outputPort);
    
    }
}
