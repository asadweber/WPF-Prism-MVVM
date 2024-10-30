using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces
{
    public interface IOwin_FormActionHandler<in Owin_FormActionRequest>
    {

        //async Task<bool> GetFormActionByRole(Owin_FormActionRequest message, ICRUDRequestHandler<Owin_FormActionResponse> outputPort);

        void GetFormActionByRole(Owin_FormActionRequest response);

    }
}
