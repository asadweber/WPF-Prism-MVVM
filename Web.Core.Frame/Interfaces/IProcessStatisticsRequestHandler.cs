using System.Threading.Tasks;

namespace Web.Core.Frame.Interfaces
{
    public interface IProcessStatisticsRequestHandler<in TUseCaseResponse>
    {
        
        void GetStatistics(TUseCaseResponse response);


    }
}
