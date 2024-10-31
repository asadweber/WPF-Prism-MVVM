using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces
{
    public interface IReg_RegistrationInfoHandler<in Reg_RegistrationInfoRequest>
    {

        void GetListViewExt(Reg_RegistrationInfoRequest response);

    }
}
