

namespace Web.Core.Frame.Interfaces
{
    public interface IOutputPort_Auth<in Auth_Response>
    {
        void Error(Auth_Response response);
        void Login(Auth_Response response);
        void ForgetPassword(Auth_Response response);

        void ForgetPasswordAjax(Auth_Response response);

        void PasswordResetAuthTokenValidatedAjax(Auth_Response response);
    }
}
