using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKNS_ApiMigrateDataInfoUseCase : IUseCaseRequestHandler<KNS_ApiMigrateDataInfoRequest, KNS_ApiMigrateDataInfoResponse>
    {
        Task<bool> SaveAPIData(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort);
            
    }
}
