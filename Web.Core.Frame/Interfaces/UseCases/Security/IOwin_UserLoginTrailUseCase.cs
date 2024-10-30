using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IOwin_UserLoginTrailUseCase : IUseCaseRequestHandler<Owin_UserLoginTrailRequest, Owin_UserLoginTrailResponse>
    {
        Task<bool> Save(Owin_UserLoginTrailRequest message, ICRUDRequestHandler<Owin_UserLoginTrailResponse> outputPort);

        Task<bool> Update(Owin_UserLoginTrailRequest message, ICRUDRequestHandler<Owin_UserLoginTrailResponse> outputPort);

        Task<bool> Delete(Owin_UserLoginTrailRequest message, ICRUDRequestHandler<Owin_UserLoginTrailResponse> outputPort);


        Task<bool> GetSingle(Owin_UserLoginTrailRequest message, ICRUDRequestHandler<Owin_UserLoginTrailResponse> outputPort);

        Task<bool> GetAll(Owin_UserLoginTrailRequest message, ICRUDRequestHandler<Owin_UserLoginTrailResponse> outputPort);


        Task<bool> GetAllPaged(Owin_UserLoginTrailRequest message, ICRUDRequestHandler<Owin_UserLoginTrailResponse> outputPort);

        Task<bool> GetListView(Owin_UserLoginTrailRequest message, ICRUDRequestHandler<Owin_UserLoginTrailResponse> outputPort);
    }
}
