using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Transaction;
using Web.Core.Frame.Dto.UseCaseResponses.Transaction;

namespace Web.Core.Frame.Interfaces.UseCases.Transaction
{
    public partial interface ITran_NotificationBatchDetUseCase : IUseCaseRequestHandler<Tran_NotificationBatchDetRequest, Tran_NotificationBatchDetResponse>
    {
        Task<bool> Save(Tran_NotificationBatchDetRequest message, ICRUDRequestHandler<Tran_NotificationBatchDetResponse> outputPort);

        Task<bool> Update(Tran_NotificationBatchDetRequest message, ICRUDRequestHandler<Tran_NotificationBatchDetResponse> outputPort);

        Task<bool> Delete(Tran_NotificationBatchDetRequest message, ICRUDRequestHandler<Tran_NotificationBatchDetResponse> outputPort);


        Task<bool> GetSingle(Tran_NotificationBatchDetRequest message, ICRUDRequestHandler<Tran_NotificationBatchDetResponse> outputPort);

        Task<bool> GetAll(Tran_NotificationBatchDetRequest message, ICRUDRequestHandler<Tran_NotificationBatchDetResponse> outputPort);


        Task<bool> GetAllPaged(Tran_NotificationBatchDetRequest message, ICRUDRequestHandler<Tran_NotificationBatchDetResponse> outputPort);

        Task<bool> GetListView(Tran_NotificationBatchDetRequest message, ICRUDRequestHandler<Tran_NotificationBatchDetResponse> outputPort);


        Task<bool> GetDataForDropDown(Tran_NotificationBatchDetRequest message, IDDLRequestHandler<Tran_NotificationBatchDetResponse> outputPort);

    }
}
