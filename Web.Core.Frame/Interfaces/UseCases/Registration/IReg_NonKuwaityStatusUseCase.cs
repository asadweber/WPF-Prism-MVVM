using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Registration;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;

namespace Web.Core.Frame.Interfaces.UseCases.Registration
{
    public partial interface IReg_NonKuwaityStatusUseCase : IUseCaseRequestHandler<Reg_NonKuwaityStatusRequest, Reg_NonKuwaityStatusResponse>
    {
        Task<bool> Save(Reg_NonKuwaityStatusRequest message, ICRUDRequestHandler<Reg_NonKuwaityStatusResponse> outputPort);

        Task<bool> Update(Reg_NonKuwaityStatusRequest message, ICRUDRequestHandler<Reg_NonKuwaityStatusResponse> outputPort);

        Task<bool> Delete(Reg_NonKuwaityStatusRequest message, ICRUDRequestHandler<Reg_NonKuwaityStatusResponse> outputPort);


        Task<bool> GetSingle(Reg_NonKuwaityStatusRequest message, ICRUDRequestHandler<Reg_NonKuwaityStatusResponse> outputPort);

        Task<bool> GetAll(Reg_NonKuwaityStatusRequest message, ICRUDRequestHandler<Reg_NonKuwaityStatusResponse> outputPort);


        Task<bool> GetAllPaged(Reg_NonKuwaityStatusRequest message, ICRUDRequestHandler<Reg_NonKuwaityStatusResponse> outputPort);

        Task<bool> GetListView(Reg_NonKuwaityStatusRequest message, ICRUDRequestHandler<Reg_NonKuwaityStatusResponse> outputPort);



    }
}
