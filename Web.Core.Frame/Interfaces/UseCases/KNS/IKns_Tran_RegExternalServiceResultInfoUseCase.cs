using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_Tran_RegExternalServiceResultInfoUseCase : IUseCaseRequestHandler<Kns_Tran_RegExternalServiceResultInfoRequest, Kns_Tran_RegExternalServiceResultInfoResponse>
    {
        Task<bool> Save(Kns_Tran_RegExternalServiceResultInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegExternalServiceResultInfoResponse> outputPort);

        Task<bool> Update(Kns_Tran_RegExternalServiceResultInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegExternalServiceResultInfoResponse> outputPort);

        Task<bool> Delete(Kns_Tran_RegExternalServiceResultInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegExternalServiceResultInfoResponse> outputPort);


        Task<bool> GetSingle(Kns_Tran_RegExternalServiceResultInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegExternalServiceResultInfoResponse> outputPort);

        Task<bool> GetAll(Kns_Tran_RegExternalServiceResultInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegExternalServiceResultInfoResponse> outputPort);


        Task<bool> GetAllPaged(Kns_Tran_RegExternalServiceResultInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegExternalServiceResultInfoResponse> outputPort);

        Task<bool> GetListView(Kns_Tran_RegExternalServiceResultInfoRequest message, ICRUDRequestHandler<Kns_Tran_RegExternalServiceResultInfoResponse> outputPort);
        
        
            
    }
}
