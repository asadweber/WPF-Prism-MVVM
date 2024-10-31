using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Registration;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;

namespace Web.Core.Frame.Interfaces.UseCases.Registration
{
    public partial interface IReg_DataCheckedUseCase : IUseCaseRequestHandler<Reg_DataCheckedRequest, Reg_DataCheckedResponse>
    {

        Task<bool> GetRegDataCheckedByBasicinfoRegistrationID(Reg_DataCheckedRequest message, ICRUDRequestHandler<Reg_DataCheckedResponse> outputPort);

    }
}
