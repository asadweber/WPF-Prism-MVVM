using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface ITran_NotificationFileUseCase : IUseCaseRequestHandler<Tran_NotificationFileRequest, Tran_NotificationFileResponse>
    {
        Task<bool> Save(Tran_NotificationFileRequest message, ICRUDRequestHandler<Tran_NotificationFileResponse> outputPort);

        Task<bool> Update(Tran_NotificationFileRequest message, ICRUDRequestHandler<Tran_NotificationFileResponse> outputPort);

        Task<bool> Delete(Tran_NotificationFileRequest message, ICRUDRequestHandler<Tran_NotificationFileResponse> outputPort);


        Task<bool> GetSingle(Tran_NotificationFileRequest message, ICRUDRequestHandler<Tran_NotificationFileResponse> outputPort);

        Task<bool> GetAll(Tran_NotificationFileRequest message, ICRUDRequestHandler<Tran_NotificationFileResponse> outputPort);


        Task<bool> GetAllPaged(Tran_NotificationFileRequest message, ICRUDRequestHandler<Tran_NotificationFileResponse> outputPort);

        Task<bool> GetListView(Tran_NotificationFileRequest message, ICRUDRequestHandler<Tran_NotificationFileResponse> outputPort);
        
        
            
    }
}
