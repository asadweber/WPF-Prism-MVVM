using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases.Security
{
    public partial interface IOwin_FormInfoUseCase : IUseCaseRequestHandler<Owin_FormInfoRequest, Owin_FormInfoResponse>
    {
        Task<bool> Save(Owin_FormInfoRequest message, ICRUDRequestHandler<Owin_FormInfoResponse> outputPort);

        Task<bool> Update(Owin_FormInfoRequest message, ICRUDRequestHandler<Owin_FormInfoResponse> outputPort);

        Task<bool> Delete(Owin_FormInfoRequest message, ICRUDRequestHandler<Owin_FormInfoResponse> outputPort);


        Task<bool> GetSingle(Owin_FormInfoRequest message, ICRUDRequestHandler<Owin_FormInfoResponse> outputPort);

        Task<bool> GetAll(Owin_FormInfoRequest message, ICRUDRequestHandler<Owin_FormInfoResponse> outputPort);


        Task<bool> GetAllPaged(Owin_FormInfoRequest message, ICRUDRequestHandler<Owin_FormInfoResponse> outputPort);

        Task<bool> GetListView(Owin_FormInfoRequest message, ICRUDRequestHandler<Owin_FormInfoResponse> outputPort);


        Task<bool> GetDataForDropDown(Owin_FormInfoRequest message, IDDLRequestHandler<Owin_FormInfoResponse> outputPort);

    }
}
