using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Transaction;
using Web.Core.Frame.Dto.UseCaseResponses.Transaction;

namespace Web.Core.Frame.Interfaces.UseCases.Transaction
{
    public partial interface ITran_NotificationBatchUseCase : IUseCaseRequestHandler<Tran_NotificationBatchRequest, Tran_NotificationBatchResponse>
    {
        Task<bool> Save(Tran_NotificationBatchRequest message, ICRUDRequestHandler<Tran_NotificationBatchResponse> outputPort);

        Task<bool> Update(Tran_NotificationBatchRequest message, ICRUDRequestHandler<Tran_NotificationBatchResponse> outputPort);

        Task<bool> Delete(Tran_NotificationBatchRequest message, ICRUDRequestHandler<Tran_NotificationBatchResponse> outputPort);


        Task<bool> GetSingle(Tran_NotificationBatchRequest message, ICRUDRequestHandler<Tran_NotificationBatchResponse> outputPort);

        Task<bool> GetAll(Tran_NotificationBatchRequest message, ICRUDRequestHandler<Tran_NotificationBatchResponse> outputPort);


        Task<bool> GetAllPaged(Tran_NotificationBatchRequest message, ICRUDRequestHandler<Tran_NotificationBatchResponse> outputPort);

        Task<bool> GetListView(Tran_NotificationBatchRequest message, ICRUDRequestHandler<Tran_NotificationBatchResponse> outputPort);


        Task<bool> GetDataForDropDown(Tran_NotificationBatchRequest message, IDDLRequestHandler<Tran_NotificationBatchResponse> outputPort);

    }
}
