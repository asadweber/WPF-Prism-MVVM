using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Configuration;
using Web.Core.Frame.Dto.UseCaseResponses.Configuration;
using Web.Core.Frame.Presenters;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface ICnf_FileConfigNameUseCase : IUseCaseRequestHandler<Cnf_FileConfigNameRequest, Cnf_FileConfigNameResponse>
    {
        Task<bool> GetAllByBatchID(Cnf_FileConfigNameRequest message, ICRUDRequestHandler<Cnf_FileConfigNameResponse> outputPort);
    }
}
