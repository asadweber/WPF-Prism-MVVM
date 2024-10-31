using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Transaction;
using Web.Core.Frame.Dto.UseCaseResponses.Transaction;

namespace Web.Core.Frame.Interfaces.UseCases.Transaction
{
    public partial interface ITran_ExportProfileUseCase : IUseCaseRequestHandler<Tran_ExportProfileRequest, Tran_ExportProfileResponse>
    {
        Task<bool> Save(Tran_ExportProfileRequest message, ICRUDRequestHandler<Tran_ExportProfileResponse> outputPort);

        Task<bool> Update(Tran_ExportProfileRequest message, ICRUDRequestHandler<Tran_ExportProfileResponse> outputPort);

        Task<bool> Delete(Tran_ExportProfileRequest message, ICRUDRequestHandler<Tran_ExportProfileResponse> outputPort);


        Task<bool> GetSingle(Tran_ExportProfileRequest message, ICRUDRequestHandler<Tran_ExportProfileResponse> outputPort);

        Task<bool> GetAll(Tran_ExportProfileRequest message, ICRUDRequestHandler<Tran_ExportProfileResponse> outputPort);


        Task<bool> GetAllPaged(Tran_ExportProfileRequest message, ICRUDRequestHandler<Tran_ExportProfileResponse> outputPort);

        Task<bool> GetListView(Tran_ExportProfileRequest message, ICRUDRequestHandler<Tran_ExportProfileResponse> outputPort);



    }
}
