
using KAF.Service.Proxy.Clients;

namespace KAF.UI.Service.Interface
{
    public interface IUserService
    {
        AccessToken CurrentUser { get; set; }
    }

}
