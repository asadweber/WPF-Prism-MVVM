using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Configuration;
using Web.Core.Frame.Dto.UseCaseResponses.Configuration;

namespace Web.Core.Frame.Interfaces.UseCases.Configuration
{
    public partial interface ICnf_FileRequiredUseCase : IUseCaseRequestHandler<Cnf_FileRequiredRequest, Cnf_FileRequiredResponse>
    {
        Task<bool> GetListViewExt(Cnf_FileRequiredRequest message, ICRUDRequestHandler<Cnf_FileRequiredResponse> outputPort);

        Task<bool> CnfFileRequiredSaveList(Cnf_FileRequiredRequest message, ICRUDRequestHandler<Cnf_FileRequiredResponse> outputPort);

        Task<bool> CnfFileRequiredDeleteList(Cnf_FileRequiredRequest message, ICRUDRequestHandler<Cnf_FileRequiredResponse> outputPort);
    }
}
