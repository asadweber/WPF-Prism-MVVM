using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface ITran_MedExamNotificationUseCase : IUseCaseRequestHandler<Tran_MedExamNotificationRequest, Tran_MedExamNotificationResponse>
    {
        Task<bool> Save(Tran_MedExamNotificationRequest message, ICRUDRequestHandler<Tran_MedExamNotificationResponse> outputPort);

        Task<bool> Update(Tran_MedExamNotificationRequest message, ICRUDRequestHandler<Tran_MedExamNotificationResponse> outputPort);

        Task<bool> Delete(Tran_MedExamNotificationRequest message, ICRUDRequestHandler<Tran_MedExamNotificationResponse> outputPort);


        Task<bool> GetSingle(Tran_MedExamNotificationRequest message, ICRUDRequestHandler<Tran_MedExamNotificationResponse> outputPort);

        Task<bool> GetAll(Tran_MedExamNotificationRequest message, ICRUDRequestHandler<Tran_MedExamNotificationResponse> outputPort);


        Task<bool> GetAllPaged(Tran_MedExamNotificationRequest message, ICRUDRequestHandler<Tran_MedExamNotificationResponse> outputPort);

        Task<bool> GetListView(Tran_MedExamNotificationRequest message, ICRUDRequestHandler<Tran_MedExamNotificationResponse> outputPort);
        
        
            
    }
}
