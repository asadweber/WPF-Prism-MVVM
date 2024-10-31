using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface ITran_TrainingJoinNotificationUseCase : IUseCaseRequestHandler<Tran_TrainingJoinNotificationRequest, Tran_TrainingJoinNotificationResponse>
    {
        Task<bool> Save(Tran_TrainingJoinNotificationRequest message, ICRUDRequestHandler<Tran_TrainingJoinNotificationResponse> outputPort);

        Task<bool> Update(Tran_TrainingJoinNotificationRequest message, ICRUDRequestHandler<Tran_TrainingJoinNotificationResponse> outputPort);

        Task<bool> Delete(Tran_TrainingJoinNotificationRequest message, ICRUDRequestHandler<Tran_TrainingJoinNotificationResponse> outputPort);


        Task<bool> GetSingle(Tran_TrainingJoinNotificationRequest message, ICRUDRequestHandler<Tran_TrainingJoinNotificationResponse> outputPort);

        Task<bool> GetAll(Tran_TrainingJoinNotificationRequest message, ICRUDRequestHandler<Tran_TrainingJoinNotificationResponse> outputPort);


        Task<bool> GetAllPaged(Tran_TrainingJoinNotificationRequest message, ICRUDRequestHandler<Tran_TrainingJoinNotificationResponse> outputPort);

        Task<bool> GetListView(Tran_TrainingJoinNotificationRequest message, ICRUDRequestHandler<Tran_TrainingJoinNotificationResponse> outputPort);



    }
}
