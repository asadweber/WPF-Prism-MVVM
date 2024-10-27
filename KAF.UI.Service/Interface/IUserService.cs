using KAF.UI.Common.Model;

namespace KAF.UI.Service.Interface
{
    public interface IUserService
    {
        User CurrentUser { get; set; }
    }

}
