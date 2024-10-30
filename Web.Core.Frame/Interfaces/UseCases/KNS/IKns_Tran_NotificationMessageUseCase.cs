using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_Tran_NotificationMessageUseCase : IUseCaseRequestHandler<Kns_Tran_NotificationMessageRequest, Kns_Tran_NotificationMessageResponse>
    {
        Task<bool> Save(Kns_Tran_NotificationMessageRequest message, ICRUDRequestHandler<Kns_Tran_NotificationMessageResponse> outputPort);

        Task<bool> Update(Kns_Tran_NotificationMessageRequest message, ICRUDRequestHandler<Kns_Tran_NotificationMessageResponse> outputPort);

        Task<bool> Delete(Kns_Tran_NotificationMessageRequest message, ICRUDRequestHandler<Kns_Tran_NotificationMessageResponse> outputPort);


        Task<bool> GetSingle(Kns_Tran_NotificationMessageRequest message, ICRUDRequestHandler<Kns_Tran_NotificationMessageResponse> outputPort);

        Task<bool> GetAll(Kns_Tran_NotificationMessageRequest message, ICRUDRequestHandler<Kns_Tran_NotificationMessageResponse> outputPort);


        Task<bool> GetAllPaged(Kns_Tran_NotificationMessageRequest message, ICRUDRequestHandler<Kns_Tran_NotificationMessageResponse> outputPort);

        Task<bool> GetListView(Kns_Tran_NotificationMessageRequest message, ICRUDRequestHandler<Kns_Tran_NotificationMessageResponse> outputPort);
        
        
            
    }
}
