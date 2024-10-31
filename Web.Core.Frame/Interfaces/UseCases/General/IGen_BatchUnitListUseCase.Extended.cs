using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_BatchUnitListUseCase : IUseCaseRequestHandler<Gen_BatchUnitListRequest, Gen_BatchUnitListResponse>
    {
        Task<bool> GetListViewExt(Gen_BatchUnitListRequest message, ICRUDRequestHandler<Gen_BatchUnitListResponse> outputPort);
    }
}
