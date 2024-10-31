using BDO.Core.DataAccessObjects.SecurityModels;
using System.Linq;
using System.Threading.Tasks;
using Web.Core.Frame.CustomIdentityManagers;
using Web.Core.Frame.Dto.UseCaseRequests;
using Web.Core.Frame.Dto.UseCaseResponses;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.Interfaces.Gateways.Repositories;
using Web.Core.Frame.Interfaces.UseCases;

namespace Web.Core.Frame.UseCases
{
    public sealed class RegisterUserUseCase : IRegisterUserUseCase
    {
        private readonly ApplicationUserManager<owin_userEntity> _userManager;

        public RegisterUserUseCase(ApplicationUserManager<owin_userEntity> userManager)
        {
            _userManager = userManager;
        }

        public async Task<bool> Handle(RegisterUserRequest message, IOutputPort<RegisterUserResponse> outputPort)
        {
            var response = await _userManager.CreateAsync(new owin_userEntity() {});
            //outputPort.Handle(response.Success ? new RegisterUserResponse(response.Id, true) : new RegisterUserResponse(response.Errors.Select(e => e.Description)));
            return true;// response.Success;
        }
    }
}
