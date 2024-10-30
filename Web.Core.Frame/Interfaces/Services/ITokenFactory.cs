
namespace Web.Core.Frame.Interfaces.Services
{
    public interface ITokenFactory
    {
        string GenerateToken(int size= 32);
    }
}
