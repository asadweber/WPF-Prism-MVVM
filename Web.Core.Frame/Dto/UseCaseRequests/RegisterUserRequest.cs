using BDO.Core.DataAccessObjects.Models;
using Web.Core.Frame.Dto.UseCaseResponses;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseRequests
{
    public class RegisterUserRequest : IUseCaseRequest<RegisterUserResponse>
    {
        public KnsUserRegistrationEntity knsUserRegistrationEntity { get; }



        public string FirstName { get; }
        public string LastName { get; }
        public string Email { get; }
        public string UserName { get; }
        public string Password { get; }

        public RegisterUserRequest(string firstName, string lastName, string email, string userName, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            UserName = userName;
            Password = password;
        }
        public RegisterUserRequest(KnsUserRegistrationEntity knsUserRegistrationEntity)
        {
            this.knsUserRegistrationEntity = knsUserRegistrationEntity;
        }

     


    }
}
