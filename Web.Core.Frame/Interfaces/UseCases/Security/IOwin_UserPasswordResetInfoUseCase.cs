using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IOwin_UserPasswordResetInfoUseCase : IUseCaseRequestHandler<Owin_UserPasswordResetInfoRequest, Owin_UserPasswordResetInfoResponse>
    {
        Task<bool> Save(Owin_UserPasswordResetInfoRequest message, ICRUDRequestHandler<Owin_UserPasswordResetInfoResponse> outputPort);

        Task<bool> Update(Owin_UserPasswordResetInfoRequest message, ICRUDRequestHandler<Owin_UserPasswordResetInfoResponse> outputPort);

        Task<bool> Delete(Owin_UserPasswordResetInfoRequest message, ICRUDRequestHandler<Owin_UserPasswordResetInfoResponse> outputPort);


        Task<bool> GetSingle(Owin_UserPasswordResetInfoRequest message, ICRUDRequestHandler<Owin_UserPasswordResetInfoResponse> outputPort);

        Task<bool> GetAll(Owin_UserPasswordResetInfoRequest message, ICRUDRequestHandler<Owin_UserPasswordResetInfoResponse> outputPort);


        Task<bool> GetAllPaged(Owin_UserPasswordResetInfoRequest message, ICRUDRequestHandler<Owin_UserPasswordResetInfoResponse> outputPort);

        Task<bool> GetListView(Owin_UserPasswordResetInfoRequest message, ICRUDRequestHandler<Owin_UserPasswordResetInfoResponse> outputPort);
    }
}
