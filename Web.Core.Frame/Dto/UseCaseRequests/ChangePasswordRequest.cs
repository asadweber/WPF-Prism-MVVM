using Web.Core.Frame.CustomIdentityManagers;
using Web.Core.Frame.Dto.UseCaseResponses;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseRequests
{ 
    public class ChangePasswordRequest : IUseCaseRequest<ChangePasswordResponse>
    {
        public string UserName { get; }
        public string Password { get; }
        public string Newpassword { get; }
        public string ConfirmNewpassword { get; }

        public ChangePasswordRequest(string userName, string password, string newpassword, string confirmnewpassword)
        {
            UserName = userName;
            Password = password;
            Newpassword = newpassword;
            ConfirmNewpassword = confirmnewpassword;
        }
    }
}
