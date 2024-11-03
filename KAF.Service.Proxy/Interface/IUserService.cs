

using KAF.Service.Proxy.Client;

namespace KAF.UI.Service.Interface
{
    public interface IUserService
    {
        AccessToken CurrentUser { get; set; }
    }

}
