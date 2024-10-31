using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Registration;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;

namespace Web.Core.Frame.Interfaces.UseCases.Registration
{
    public partial interface IReg_RegistrationInfoUseCase : IUseCaseRequestHandler<Reg_RegistrationInfoRequest, Reg_RegistrationInfoResponse>
    {
        Task<bool> Save(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> Update(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> Delete(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);


        Task<bool> GetSingle(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> GetAll(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);


        Task<bool> GetAllPaged(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> GetListView(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);


        Task<bool> GetDataForDropDown(Reg_RegistrationInfoRequest message, IDDLRequestHandler<Reg_RegistrationInfoResponse> outputPort);

    }
}
