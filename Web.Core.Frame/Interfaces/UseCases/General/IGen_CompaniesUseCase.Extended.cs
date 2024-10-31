using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_CompaniesUseCase : IUseCaseRequestHandler<Gen_CompaniesRequest, Gen_CompaniesResponse>
    {
        Task<bool> GetListViewExt(Gen_CompaniesRequest message, ICRUDRequestHandler<Gen_CompaniesResponse> outputPort);
    }
}
