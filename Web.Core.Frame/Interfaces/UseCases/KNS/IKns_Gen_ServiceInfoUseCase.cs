using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_Gen_ServiceInfoUseCase : IUseCaseRequestHandler<Kns_Gen_ServiceInfoRequest, Kns_Gen_ServiceInfoResponse>
    {
        Task<bool> Save(Kns_Gen_ServiceInfoRequest message, ICRUDRequestHandler<Kns_Gen_ServiceInfoResponse> outputPort);

        Task<bool> Update(Kns_Gen_ServiceInfoRequest message, ICRUDRequestHandler<Kns_Gen_ServiceInfoResponse> outputPort);

        Task<bool> Delete(Kns_Gen_ServiceInfoRequest message, ICRUDRequestHandler<Kns_Gen_ServiceInfoResponse> outputPort);


        Task<bool> GetSingle(Kns_Gen_ServiceInfoRequest message, ICRUDRequestHandler<Kns_Gen_ServiceInfoResponse> outputPort);

        Task<bool> GetAll(Kns_Gen_ServiceInfoRequest message, ICRUDRequestHandler<Kns_Gen_ServiceInfoResponse> outputPort);


        Task<bool> GetAllPaged(Kns_Gen_ServiceInfoRequest message, ICRUDRequestHandler<Kns_Gen_ServiceInfoResponse> outputPort);

        Task<bool> GetListView(Kns_Gen_ServiceInfoRequest message, ICRUDRequestHandler<Kns_Gen_ServiceInfoResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Kns_Gen_ServiceInfoRequest message, IDDLRequestHandler<Kns_Gen_ServiceInfoResponse> outputPort);
    
    }
}
