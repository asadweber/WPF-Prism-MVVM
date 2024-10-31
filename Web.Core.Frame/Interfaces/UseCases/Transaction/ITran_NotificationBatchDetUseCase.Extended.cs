using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Transaction;
using Web.Core.Frame.Dto.UseCaseResponses.Transaction;

namespace Web.Core.Frame.Interfaces.UseCases.Transaction
{
    public partial interface ITran_NotificationBatchDetUseCase
    {
        Task<bool> GetAllExt(Tran_NotificationBatchDetRequest message, ICRUDRequestHandler<Tran_NotificationBatchDetResponse> outputPort);

        Task<bool> GetAllByBasicInfoRegistrationID(Tran_NotificationBatchDetRequest message, ICRUDRequestHandler<Tran_NotificationBatchDetResponse> outputPort);
    }
}
