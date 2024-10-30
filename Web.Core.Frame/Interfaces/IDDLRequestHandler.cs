using System.Threading.Tasks;

namespace Web.Core.Frame.Interfaces
{
    public interface IDDLRequestHandler<in TUseCaseResponse>
    {
        void GetDropDown(TUseCaseResponse response);
    }
}
