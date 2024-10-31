using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface ITran_NotificationFileDetUseCase : IUseCaseRequestHandler<Tran_NotificationFileDetRequest, Tran_NotificationFileDetResponse>
    {
        Task<bool> Save(Tran_NotificationFileDetRequest message, ICRUDRequestHandler<Tran_NotificationFileDetResponse> outputPort);

        Task<bool> Update(Tran_NotificationFileDetRequest message, ICRUDRequestHandler<Tran_NotificationFileDetResponse> outputPort);

        Task<bool> Delete(Tran_NotificationFileDetRequest message, ICRUDRequestHandler<Tran_NotificationFileDetResponse> outputPort);


        Task<bool> GetSingle(Tran_NotificationFileDetRequest message, ICRUDRequestHandler<Tran_NotificationFileDetResponse> outputPort);

        Task<bool> GetAll(Tran_NotificationFileDetRequest message, ICRUDRequestHandler<Tran_NotificationFileDetResponse> outputPort);


        Task<bool> GetAllPaged(Tran_NotificationFileDetRequest message, ICRUDRequestHandler<Tran_NotificationFileDetResponse> outputPort);

        Task<bool> GetListView(Tran_NotificationFileDetRequest message, ICRUDRequestHandler<Tran_NotificationFileDetResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Tran_NotificationFileDetRequest message, IDDLRequestHandler<Tran_NotificationFileDetResponse> outputPort);
    
    }
}
