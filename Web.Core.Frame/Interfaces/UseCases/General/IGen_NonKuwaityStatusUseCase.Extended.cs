using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_NonKuwaityStatusUseCase : IUseCaseRequestHandler<Gen_NonKuwaityStatusRequest, Gen_NonKuwaityStatusResponse>
    {
        Task<bool> GetAllByGroup(Gen_NonKuwaityStatusRequest message, ICRUDRequestHandler<Gen_NonKuwaityStatusResponse> outputPort);

    }
}
