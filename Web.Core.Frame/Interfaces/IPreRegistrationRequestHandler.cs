using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces
{
    public interface IPreRegistrationRequestHandler<in TUseCaseResponse>
    {
        void ValidationPolicy(TUseCaseResponse response);
        void SavePreRegistration(TUseCaseResponse response);
		void SaveVarification(TUseCaseResponse response);
        void GetSingleById(VCRegistrationResponse response);
        void GetReportProfile(VCRegistrationResponse response);
        void GetProfileDataCheckStatus(VCRegistrationResponse response);
        void SaveDocument(VCRegistrationResponse response);
        void AccountActivation(VCRegistrationResponse response);
    }
}
