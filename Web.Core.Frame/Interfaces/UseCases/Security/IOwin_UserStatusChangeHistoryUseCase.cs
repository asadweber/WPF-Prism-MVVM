using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IOwin_UserStatusChangeHistoryUseCase : IUseCaseRequestHandler<Owin_UserStatusChangeHistoryRequest, Owin_UserStatusChangeHistoryResponse>
    {
        Task<bool> Save(Owin_UserStatusChangeHistoryRequest message, ICRUDRequestHandler<Owin_UserStatusChangeHistoryResponse> outputPort);

        Task<bool> Update(Owin_UserStatusChangeHistoryRequest message, ICRUDRequestHandler<Owin_UserStatusChangeHistoryResponse> outputPort);

        Task<bool> Delete(Owin_UserStatusChangeHistoryRequest message, ICRUDRequestHandler<Owin_UserStatusChangeHistoryResponse> outputPort);


        Task<bool> GetSingle(Owin_UserStatusChangeHistoryRequest message, ICRUDRequestHandler<Owin_UserStatusChangeHistoryResponse> outputPort);

        Task<bool> GetAll(Owin_UserStatusChangeHistoryRequest message, ICRUDRequestHandler<Owin_UserStatusChangeHistoryResponse> outputPort);


        Task<bool> GetAllPaged(Owin_UserStatusChangeHistoryRequest message, ICRUDRequestHandler<Owin_UserStatusChangeHistoryResponse> outputPort);

        Task<bool> GetListView(Owin_UserStatusChangeHistoryRequest message, ICRUDRequestHandler<Owin_UserStatusChangeHistoryResponse> outputPort);
    }
}
