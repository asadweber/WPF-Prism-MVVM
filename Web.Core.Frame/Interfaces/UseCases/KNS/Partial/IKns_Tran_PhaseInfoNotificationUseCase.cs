using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_Tran_PhaseInfoNotificationUseCase : IUseCaseRequestHandler<Kns_Tran_PhaseInfoNotificationRequest, Kns_Tran_PhaseInfoNotificationResponse>
    {
       
        Task<bool> GetAllNotificationByBasicId(Kns_Tran_PhaseInfoNotificationRequest message, ICRUDRequestHandler<Kns_Tran_PhaseInfoNotificationResponse> outputPort);


       
        
            
    }
}
