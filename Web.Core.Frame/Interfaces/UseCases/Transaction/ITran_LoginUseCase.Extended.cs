using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Transaction;
using Web.Core.Frame.Dto.UseCaseResponses.Transaction;

namespace Web.Core.Frame.Interfaces.UseCases.Transaction
{
    public partial interface ITran_LoginUseCase : IUseCaseRequestHandler<Tran_LoginRequest, Tran_LoginResponse>
    {


    }
}
