using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IOwin_LastWorkingPageUseCase : IUseCaseRequestHandler<Owin_LastWorkingPageRequest, Owin_LastWorkingPageResponse>
    {
        Task<bool> Save(Owin_LastWorkingPageRequest message, ICRUDRequestHandler<Owin_LastWorkingPageResponse> outputPort);

        Task<bool> Update(Owin_LastWorkingPageRequest message, ICRUDRequestHandler<Owin_LastWorkingPageResponse> outputPort);

        Task<bool> Delete(Owin_LastWorkingPageRequest message, ICRUDRequestHandler<Owin_LastWorkingPageResponse> outputPort);


        Task<bool> GetSingle(Owin_LastWorkingPageRequest message, ICRUDRequestHandler<Owin_LastWorkingPageResponse> outputPort);

        Task<bool> GetAll(Owin_LastWorkingPageRequest message, ICRUDRequestHandler<Owin_LastWorkingPageResponse> outputPort);


        Task<bool> GetAllPaged(Owin_LastWorkingPageRequest message, ICRUDRequestHandler<Owin_LastWorkingPageResponse> outputPort);

        Task<bool> GetListView(Owin_LastWorkingPageRequest message, ICRUDRequestHandler<Owin_LastWorkingPageResponse> outputPort);
    }
}
