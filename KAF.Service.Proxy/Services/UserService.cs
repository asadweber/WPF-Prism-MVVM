using KAF.Service.Proxy.Clients;
using KAF.UI.Service.Interface;

namespace KAF.UI.Service.Services
{
    public class UserService : IUserService
    {
        public AccessToken CurrentUser { get; set; }
    }
}
