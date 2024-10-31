using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_CivilWorkPlacesUseCase : IUseCaseRequestHandler<Gen_CivilWorkPlacesRequest, Gen_CivilWorkPlacesResponse>
    {
        Task<bool> GetSingleExt(Gen_CivilWorkPlacesRequest message, ICRUDRequestHandler<Gen_CivilWorkPlacesResponse> outputPort);
    }
}
