using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKnsTransPunishmentUseCase : IUseCaseRequestHandler<KnsTransPunishmentRequest, KnsTransPunishmentResponse>
    {
        Task<bool> Save(KnsTransPunishmentRequest message, ICRUDRequestHandler<KnsTransPunishmentResponse> outputPort);

        Task<bool> Update(KnsTransPunishmentRequest message, ICRUDRequestHandler<KnsTransPunishmentResponse> outputPort);

        Task<bool> Delete(KnsTransPunishmentRequest message, ICRUDRequestHandler<KnsTransPunishmentResponse> outputPort);


        Task<bool> GetSingle(KnsTransPunishmentRequest message, ICRUDRequestHandler<KnsTransPunishmentResponse> outputPort);

        Task<bool> GetAll(KnsTransPunishmentRequest message, ICRUDRequestHandler<KnsTransPunishmentResponse> outputPort);


        Task<bool> GetAllPaged(KnsTransPunishmentRequest message, ICRUDRequestHandler<KnsTransPunishmentResponse> outputPort);

        Task<bool> GetListView(KnsTransPunishmentRequest message, ICRUDRequestHandler<KnsTransPunishmentResponse> outputPort);
        
        
            
    }
}
