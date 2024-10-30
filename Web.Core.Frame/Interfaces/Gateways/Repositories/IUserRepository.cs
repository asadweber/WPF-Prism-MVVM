using BDO.Core.DataAccessObjects.SecurityModels;
using System.Threading.Tasks;
using Web.Core.Frame.Dto.GatewayResponses.Repositories;

namespace Web.Core.Frame.Interfaces.Gateways.Repositories
{
    public interface IUserRepository  : IRepository<owin_userEntity>
    {
        Task<CreateUserResponse> Create(string firstName, string lastName, string email, string userName, string password);
        Task<owin_userEntity> FindByName(string userName);
        Task<bool> CheckPassword(owin_userEntity user, string password);
    }
}
