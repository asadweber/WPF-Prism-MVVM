using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IOwin_UserClaimsUseCase : IUseCaseRequestHandler<Owin_UserClaimsRequest, Owin_UserClaimsResponse>
    {
        Task<bool> Save(Owin_UserClaimsRequest message, ICRUDRequestHandler<Owin_UserClaimsResponse> outputPort);

        Task<bool> Update(Owin_UserClaimsRequest message, ICRUDRequestHandler<Owin_UserClaimsResponse> outputPort);

        Task<bool> Delete(Owin_UserClaimsRequest message, ICRUDRequestHandler<Owin_UserClaimsResponse> outputPort);


        Task<bool> GetSingle(Owin_UserClaimsRequest message, ICRUDRequestHandler<Owin_UserClaimsResponse> outputPort);

        Task<bool> GetAll(Owin_UserClaimsRequest message, ICRUDRequestHandler<Owin_UserClaimsResponse> outputPort);


        Task<bool> GetAllPaged(Owin_UserClaimsRequest message, ICRUDRequestHandler<Owin_UserClaimsResponse> outputPort);

        Task<bool> GetListView(Owin_UserClaimsRequest message, ICRUDRequestHandler<Owin_UserClaimsResponse> outputPort);
    }
}
