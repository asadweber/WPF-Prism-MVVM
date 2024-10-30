using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{

	public partial interface IKns_Tran_PhaseInfo_NotificationCountUseCase : IUseCaseRequestHandler<Kns_Tran_PhaseInfo_NotificationCountRequest, Kns_Tran_PhaseInfo_NotificationCountResponse>
    {
        Task<bool> GetAll(Kns_Tran_PhaseInfo_NotificationCountRequest message, ICRUDRequestHandler<Kns_Tran_PhaseInfo_NotificationCountResponse> outputPort);

		Task<bool> GetListView(Kns_Tran_PhaseInfo_NotificationCountRequest message, ICRUDRequestHandler<Kns_Tran_PhaseInfo_NotificationCountResponse> outputPort);
		Task<bool> GetAllPaged(Kns_Tran_PhaseInfo_NotificationCountRequest message, ICRUDRequestHandler<Kns_Tran_PhaseInfo_NotificationCountResponse> outputPort);

    }
}
