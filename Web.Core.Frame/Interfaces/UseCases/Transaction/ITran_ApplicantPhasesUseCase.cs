using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Transaction;
using Web.Core.Frame.Dto.UseCaseResponses.Transaction;

namespace Web.Core.Frame.Interfaces.UseCases.Transaction
{
    public partial interface ITran_ApplicantPhasesUseCase : IUseCaseRequestHandler<Tran_ApplicantPhasesRequest, Tran_ApplicantPhasesResponse>
    {
        Task<bool> Save(Tran_ApplicantPhasesRequest message, ICRUDRequestHandler<Tran_ApplicantPhasesResponse> outputPort);

        Task<bool> Update(Tran_ApplicantPhasesRequest message, ICRUDRequestHandler<Tran_ApplicantPhasesResponse> outputPort);

        Task<bool> Delete(Tran_ApplicantPhasesRequest message, ICRUDRequestHandler<Tran_ApplicantPhasesResponse> outputPort);


        Task<bool> GetSingle(Tran_ApplicantPhasesRequest message, ICRUDRequestHandler<Tran_ApplicantPhasesResponse> outputPort);

        Task<bool> GetAll(Tran_ApplicantPhasesRequest message, ICRUDRequestHandler<Tran_ApplicantPhasesResponse> outputPort);


        Task<bool> GetAllPaged(Tran_ApplicantPhasesRequest message, ICRUDRequestHandler<Tran_ApplicantPhasesResponse> outputPort);

        Task<bool> GetListView(Tran_ApplicantPhasesRequest message, ICRUDRequestHandler<Tran_ApplicantPhasesResponse> outputPort);


        Task<bool> GetDataForDropDown(Tran_ApplicantPhasesRequest message, IDDLRequestHandler<Tran_ApplicantPhasesResponse> outputPort);

    }
}
