using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Transaction;
using Web.Core.Frame.Dto.UseCaseResponses.Transaction;

namespace Web.Core.Frame.Interfaces.UseCases.Transaction
{
    public partial interface ITran_RollbackInfoUseCase : IUseCaseRequestHandler<Tran_RollbackInfoRequest, Tran_RollbackInfoResponse>
    {
        Task<bool> Save(Tran_RollbackInfoRequest message, ICRUDRequestHandler<Tran_RollbackInfoResponse> outputPort);

        Task<bool> Update(Tran_RollbackInfoRequest message, ICRUDRequestHandler<Tran_RollbackInfoResponse> outputPort);

        Task<bool> Delete(Tran_RollbackInfoRequest message, ICRUDRequestHandler<Tran_RollbackInfoResponse> outputPort);


        Task<bool> GetSingle(Tran_RollbackInfoRequest message, ICRUDRequestHandler<Tran_RollbackInfoResponse> outputPort);

        Task<bool> GetAll(Tran_RollbackInfoRequest message, ICRUDRequestHandler<Tran_RollbackInfoResponse> outputPort);


        Task<bool> GetAllPaged(Tran_RollbackInfoRequest message, ICRUDRequestHandler<Tran_RollbackInfoResponse> outputPort);

        Task<bool> GetListView(Tran_RollbackInfoRequest message, ICRUDRequestHandler<Tran_RollbackInfoResponse> outputPort);



    }
}
