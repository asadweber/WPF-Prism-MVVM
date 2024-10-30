using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_ServiceStatusMapInfoUseCase : IUseCaseRequestHandler<Kns_ServiceStatusMapInfoRequest, Kns_ServiceStatusMapInfoResponse>
    {
        Task<bool> Save(Kns_ServiceStatusMapInfoRequest message, ICRUDRequestHandler<Kns_ServiceStatusMapInfoResponse> outputPort);

        Task<bool> Update(Kns_ServiceStatusMapInfoRequest message, ICRUDRequestHandler<Kns_ServiceStatusMapInfoResponse> outputPort);

        Task<bool> Delete(Kns_ServiceStatusMapInfoRequest message, ICRUDRequestHandler<Kns_ServiceStatusMapInfoResponse> outputPort);


        Task<bool> GetSingle(Kns_ServiceStatusMapInfoRequest message, ICRUDRequestHandler<Kns_ServiceStatusMapInfoResponse> outputPort);

        Task<bool> GetAll(Kns_ServiceStatusMapInfoRequest message, ICRUDRequestHandler<Kns_ServiceStatusMapInfoResponse> outputPort);


        Task<bool> GetAllPaged(Kns_ServiceStatusMapInfoRequest message, ICRUDRequestHandler<Kns_ServiceStatusMapInfoResponse> outputPort);

        Task<bool> GetListView(Kns_ServiceStatusMapInfoRequest message, ICRUDRequestHandler<Kns_ServiceStatusMapInfoResponse> outputPort);

        Task<bool> UpdateReOrder(Kns_ServiceStatusMapInfoRequest message, ICRUDRequestHandler<Kns_ServiceStatusMapInfoResponse> outputPort);


    }
}
