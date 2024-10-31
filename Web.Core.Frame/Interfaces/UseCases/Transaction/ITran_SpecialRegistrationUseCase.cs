using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Transaction;
using Web.Core.Frame.Dto.UseCaseResponses.Transaction;

namespace Web.Core.Frame.Interfaces.UseCases.Transaction
{
    public partial interface ITran_SpecialRegistrationUseCase : IUseCaseRequestHandler<Tran_SpecialRegistrationRequest, Tran_SpecialRegistrationResponse>
    {
        Task<bool> Save(Tran_SpecialRegistrationRequest message, ICRUDRequestHandler<Tran_SpecialRegistrationResponse> outputPort);

        Task<bool> Update(Tran_SpecialRegistrationRequest message, ICRUDRequestHandler<Tran_SpecialRegistrationResponse> outputPort);

        Task<bool> Delete(Tran_SpecialRegistrationRequest message, ICRUDRequestHandler<Tran_SpecialRegistrationResponse> outputPort);


        Task<bool> GetSingle(Tran_SpecialRegistrationRequest message, ICRUDRequestHandler<Tran_SpecialRegistrationResponse> outputPort);

        Task<bool> GetAll(Tran_SpecialRegistrationRequest message, ICRUDRequestHandler<Tran_SpecialRegistrationResponse> outputPort);


        Task<bool> GetAllPaged(Tran_SpecialRegistrationRequest message, ICRUDRequestHandler<Tran_SpecialRegistrationResponse> outputPort);

        Task<bool> GetListView(Tran_SpecialRegistrationRequest message, ICRUDRequestHandler<Tran_SpecialRegistrationResponse> outputPort);



    }
}
