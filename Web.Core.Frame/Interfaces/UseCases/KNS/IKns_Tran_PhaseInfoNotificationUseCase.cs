using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_Tran_PhaseInfoNotificationUseCase : IUseCaseRequestHandler<Kns_Tran_PhaseInfoNotificationRequest, Kns_Tran_PhaseInfoNotificationResponse>
    {
        Task<bool> Save(Kns_Tran_PhaseInfoNotificationRequest message, ICRUDRequestHandler<Kns_Tran_PhaseInfoNotificationResponse> outputPort);

        Task<bool> Update(Kns_Tran_PhaseInfoNotificationRequest message, ICRUDRequestHandler<Kns_Tran_PhaseInfoNotificationResponse> outputPort);

        Task<bool> Delete(Kns_Tran_PhaseInfoNotificationRequest message, ICRUDRequestHandler<Kns_Tran_PhaseInfoNotificationResponse> outputPort);


        Task<bool> GetSingle(Kns_Tran_PhaseInfoNotificationRequest message, ICRUDRequestHandler<Kns_Tran_PhaseInfoNotificationResponse> outputPort);

        Task<bool> GetAll(Kns_Tran_PhaseInfoNotificationRequest message, ICRUDRequestHandler<Kns_Tran_PhaseInfoNotificationResponse> outputPort);


        Task<bool> GetAllPaged(Kns_Tran_PhaseInfoNotificationRequest message, ICRUDRequestHandler<Kns_Tran_PhaseInfoNotificationResponse> outputPort);

        Task<bool> GetListView(Kns_Tran_PhaseInfoNotificationRequest message, ICRUDRequestHandler<Kns_Tran_PhaseInfoNotificationResponse> outputPort);
        
        
            
    }
}
