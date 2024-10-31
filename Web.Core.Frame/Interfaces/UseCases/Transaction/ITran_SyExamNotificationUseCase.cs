using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface ITran_SyExamNotificationUseCase : IUseCaseRequestHandler<Tran_SyExamNotificationRequest, Tran_SyExamNotificationResponse>
    {
        Task<bool> Save(Tran_SyExamNotificationRequest message, ICRUDRequestHandler<Tran_SyExamNotificationResponse> outputPort);

        Task<bool> Update(Tran_SyExamNotificationRequest message, ICRUDRequestHandler<Tran_SyExamNotificationResponse> outputPort);

        Task<bool> Delete(Tran_SyExamNotificationRequest message, ICRUDRequestHandler<Tran_SyExamNotificationResponse> outputPort);


        Task<bool> GetSingle(Tran_SyExamNotificationRequest message, ICRUDRequestHandler<Tran_SyExamNotificationResponse> outputPort);

        Task<bool> GetAll(Tran_SyExamNotificationRequest message, ICRUDRequestHandler<Tran_SyExamNotificationResponse> outputPort);


        Task<bool> GetAllPaged(Tran_SyExamNotificationRequest message, ICRUDRequestHandler<Tran_SyExamNotificationResponse> outputPort);

        Task<bool> GetListView(Tran_SyExamNotificationRequest message, ICRUDRequestHandler<Tran_SyExamNotificationResponse> outputPort);
        
        
            
    }
}
