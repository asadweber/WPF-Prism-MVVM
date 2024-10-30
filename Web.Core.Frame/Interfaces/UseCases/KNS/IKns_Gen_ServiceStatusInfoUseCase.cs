using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_Gen_ServiceStatusInfoUseCase : IUseCaseRequestHandler<Kns_Gen_ServiceStatusInfoRequest, Kns_Gen_ServiceStatusInfoResponse>
    {
        Task<bool> Save(Kns_Gen_ServiceStatusInfoRequest message, ICRUDRequestHandler<Kns_Gen_ServiceStatusInfoResponse> outputPort);

        Task<bool> Update(Kns_Gen_ServiceStatusInfoRequest message, ICRUDRequestHandler<Kns_Gen_ServiceStatusInfoResponse> outputPort);

        Task<bool> Delete(Kns_Gen_ServiceStatusInfoRequest message, ICRUDRequestHandler<Kns_Gen_ServiceStatusInfoResponse> outputPort);


        Task<bool> GetSingle(Kns_Gen_ServiceStatusInfoRequest message, ICRUDRequestHandler<Kns_Gen_ServiceStatusInfoResponse> outputPort);

        Task<bool> GetAll(Kns_Gen_ServiceStatusInfoRequest message, ICRUDRequestHandler<Kns_Gen_ServiceStatusInfoResponse> outputPort);


        Task<bool> GetAllPaged(Kns_Gen_ServiceStatusInfoRequest message, ICRUDRequestHandler<Kns_Gen_ServiceStatusInfoResponse> outputPort);

        Task<bool> GetListView(Kns_Gen_ServiceStatusInfoRequest message, ICRUDRequestHandler<Kns_Gen_ServiceStatusInfoResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Kns_Gen_ServiceStatusInfoRequest message, IDDLRequestHandler<Kns_Gen_ServiceStatusInfoResponse> outputPort);
    
    }
}
