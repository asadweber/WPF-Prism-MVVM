using BDO.Model;
using KAF.UI.Service.Interface;

namespace KAF.UI.Service.Services
{
    public class UserService : IUserService
    {
        public User CurrentUser { get; set; }
    }
}
