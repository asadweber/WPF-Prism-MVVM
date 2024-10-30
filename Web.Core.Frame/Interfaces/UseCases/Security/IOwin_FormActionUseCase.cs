using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IOwin_FormActionUseCase : IUseCaseRequestHandler<Owin_FormActionRequest, Owin_FormActionResponse>
    {
        Task<bool> Save(Owin_FormActionRequest message, ICRUDRequestHandler<Owin_FormActionResponse> outputPort);

        Task<bool> Update(Owin_FormActionRequest message, ICRUDRequestHandler<Owin_FormActionResponse> outputPort);

        Task<bool> Delete(Owin_FormActionRequest message, ICRUDRequestHandler<Owin_FormActionResponse> outputPort);


        Task<bool> GetSingle(Owin_FormActionRequest message, ICRUDRequestHandler<Owin_FormActionResponse> outputPort);

        Task<bool> GetAll(Owin_FormActionRequest message, ICRUDRequestHandler<Owin_FormActionResponse> outputPort);


        Task<bool> GetAllPaged(Owin_FormActionRequest message, ICRUDRequestHandler<Owin_FormActionResponse> outputPort);

        Task<bool> GetListView(Owin_FormActionRequest message, ICRUDRequestHandler<Owin_FormActionResponse> outputPort);
    }
}
