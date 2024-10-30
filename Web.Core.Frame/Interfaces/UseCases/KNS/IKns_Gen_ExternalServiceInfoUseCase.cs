using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_Gen_ExternalServiceInfoUseCase : IUseCaseRequestHandler<Kns_Gen_ExternalServiceInfoRequest, Kns_Gen_ExternalServiceInfoResponse>
    {
        Task<bool> Save(Kns_Gen_ExternalServiceInfoRequest message, ICRUDRequestHandler<Kns_Gen_ExternalServiceInfoResponse> outputPort);

        Task<bool> Update(Kns_Gen_ExternalServiceInfoRequest message, ICRUDRequestHandler<Kns_Gen_ExternalServiceInfoResponse> outputPort);

        Task<bool> Delete(Kns_Gen_ExternalServiceInfoRequest message, ICRUDRequestHandler<Kns_Gen_ExternalServiceInfoResponse> outputPort);


        Task<bool> GetSingle(Kns_Gen_ExternalServiceInfoRequest message, ICRUDRequestHandler<Kns_Gen_ExternalServiceInfoResponse> outputPort);

        Task<bool> GetAll(Kns_Gen_ExternalServiceInfoRequest message, ICRUDRequestHandler<Kns_Gen_ExternalServiceInfoResponse> outputPort);


        Task<bool> GetAllPaged(Kns_Gen_ExternalServiceInfoRequest message, ICRUDRequestHandler<Kns_Gen_ExternalServiceInfoResponse> outputPort);

        Task<bool> GetListView(Kns_Gen_ExternalServiceInfoRequest message, ICRUDRequestHandler<Kns_Gen_ExternalServiceInfoResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Kns_Gen_ExternalServiceInfoRequest message, IDDLRequestHandler<Kns_Gen_ExternalServiceInfoResponse> outputPort);
    
    }
}
