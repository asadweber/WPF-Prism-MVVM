using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKnsTransPunishmentUseCase 
    {
        Task<bool> GetAllReport(KnsTransPunishmentRequest message, ICRUDRequestHandler<KnsTransPunishmentResponse> outputPort);
		Task<bool> GetAllExt(KnsTransPunishmentRequest message, ICRUDRequestHandler<KnsTransPunishmentResponse> outputPort);

		Task<bool> CancelPunishment(KnsTransPunishmentRequest message, ICRUDRequestHandler<KnsTransPunishmentResponse> outputPort);

	}
}
