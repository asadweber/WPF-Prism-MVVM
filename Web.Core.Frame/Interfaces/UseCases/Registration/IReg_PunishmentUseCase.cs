using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Registration;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;

namespace Web.Core.Frame.Interfaces.UseCases.Registration
{
    public partial interface IReg_PunishmentUseCase : IUseCaseRequestHandler<Reg_PunishmentRequest, Reg_PunishmentResponse>
    {
        Task<bool> Save(Reg_PunishmentRequest message, ICRUDRequestHandler<Reg_PunishmentResponse> outputPort);

        Task<bool> Update(Reg_PunishmentRequest message, ICRUDRequestHandler<Reg_PunishmentResponse> outputPort);

        Task<bool> Delete(Reg_PunishmentRequest message, ICRUDRequestHandler<Reg_PunishmentResponse> outputPort);


        Task<bool> GetSingle(Reg_PunishmentRequest message, ICRUDRequestHandler<Reg_PunishmentResponse> outputPort);

        Task<bool> GetAll(Reg_PunishmentRequest message, ICRUDRequestHandler<Reg_PunishmentResponse> outputPort);


        Task<bool> GetAllPaged(Reg_PunishmentRequest message, ICRUDRequestHandler<Reg_PunishmentResponse> outputPort);

        Task<bool> GetListView(Reg_PunishmentRequest message, ICRUDRequestHandler<Reg_PunishmentResponse> outputPort);



    }
}
