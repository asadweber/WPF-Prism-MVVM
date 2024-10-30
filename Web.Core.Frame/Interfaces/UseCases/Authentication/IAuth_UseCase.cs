using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests;
using Web.Core.Frame.Dto.UseCaseResponses;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public interface IAuth_UseCase : IUseCaseRequestHandler<Auth_Request, Auth_Response>
    {
        Task<bool> LoginWebRequest(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort); 
        Task<bool> ForgetPasswordRequest(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort);
        Task<bool> PasswordRequestAuthTokenValidated(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort);
        Task<bool> ResetPassword(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort);

        Task<bool> ChangePassword(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort);


        //
        Task<bool> GetFrontUserCivilIDValidated(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort);
        Task<bool> WebFrontCivilIdValidateUsingPaciAPI(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort);
        Task<bool> GetQRCodeFromPACIToAuthenticate(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort);
        Task<bool> LoginWebFrontPACIRequest(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort);
		Task<bool> CivilIdValidateFromCDUsingPaciAPI(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort);

        Task<bool> LoginWebFrontWithPassword(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort);


		Task<bool> SyncProfileAuthRequestByCivilId(Auth_Request message, IOutputPort_Auth<Auth_Response> outputPort);




	}
}
