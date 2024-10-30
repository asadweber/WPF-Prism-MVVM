using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKNS_ApiMigrateDataInfoUseCase : IUseCaseRequestHandler<KNS_ApiMigrateDataInfoRequest, KNS_ApiMigrateDataInfoResponse>
    {
        Task<bool> Save(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort);

        Task<bool> Update(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort);

        Task<bool> Delete(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort);


        Task<bool> GetSingle(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort);

        Task<bool> GetAll(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort);


        Task<bool> GetAllPaged(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort);

        Task<bool> GetListView(KNS_ApiMigrateDataInfoRequest message, ICRUDRequestHandler<KNS_ApiMigrateDataInfoResponse> outputPort);
        
        
            
    }
}
