using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_Tran_PhaseInfoUseCase : IUseCaseRequestHandler<Kns_Tran_PhaseInfoRequest, Kns_Tran_PhaseInfoResponse>
    {
        Task<bool> Save(Kns_Tran_PhaseInfoRequest message, ICRUDRequestHandler<Kns_Tran_PhaseInfoResponse> outputPort);

        Task<bool> Update(Kns_Tran_PhaseInfoRequest message, ICRUDRequestHandler<Kns_Tran_PhaseInfoResponse> outputPort);

        Task<bool> Delete(Kns_Tran_PhaseInfoRequest message, ICRUDRequestHandler<Kns_Tran_PhaseInfoResponse> outputPort);


        Task<bool> GetSingle(Kns_Tran_PhaseInfoRequest message, ICRUDRequestHandler<Kns_Tran_PhaseInfoResponse> outputPort);

        Task<bool> GetAll(Kns_Tran_PhaseInfoRequest message, ICRUDRequestHandler<Kns_Tran_PhaseInfoResponse> outputPort);


        Task<bool> GetAllPaged(Kns_Tran_PhaseInfoRequest message, ICRUDRequestHandler<Kns_Tran_PhaseInfoResponse> outputPort);

        Task<bool> GetListView(Kns_Tran_PhaseInfoRequest message, ICRUDRequestHandler<Kns_Tran_PhaseInfoResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Kns_Tran_PhaseInfoRequest message, IDDLRequestHandler<Kns_Tran_PhaseInfoResponse> outputPort);
    
    }
}
