using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Transaction;
using Web.Core.Frame.Dto.UseCaseResponses.Transaction;

namespace Web.Core.Frame.Interfaces.UseCases.Transaction
{
    public partial interface ITran_NotificationBatchUseCase : IUseCaseRequestHandler<Tran_NotificationBatchRequest, Tran_NotificationBatchResponse>
    {

        Task<bool> SaveNotificationBatchWithProfileList(Tran_NotificationBatchRequest message, ICRUDRequestHandler<Tran_NotificationBatchResponse> outputPort);

    }
}
