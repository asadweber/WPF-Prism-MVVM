using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Registration;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;

namespace Web.Core.Frame.Interfaces.UseCases.Registration
{
    public partial interface IReg_EmergencyContactInfoUseCase : IUseCaseRequestHandler<Reg_EmergencyContactInfoRequest, Reg_EmergencyContactInfoResponse>
    {
        Task<bool> Save(Reg_EmergencyContactInfoRequest message, ICRUDRequestHandler<Reg_EmergencyContactInfoResponse> outputPort);

        Task<bool> Update(Reg_EmergencyContactInfoRequest message, ICRUDRequestHandler<Reg_EmergencyContactInfoResponse> outputPort);

        Task<bool> Delete(Reg_EmergencyContactInfoRequest message, ICRUDRequestHandler<Reg_EmergencyContactInfoResponse> outputPort);


        Task<bool> GetSingle(Reg_EmergencyContactInfoRequest message, ICRUDRequestHandler<Reg_EmergencyContactInfoResponse> outputPort);

        Task<bool> GetAll(Reg_EmergencyContactInfoRequest message, ICRUDRequestHandler<Reg_EmergencyContactInfoResponse> outputPort);


        Task<bool> GetAllPaged(Reg_EmergencyContactInfoRequest message, ICRUDRequestHandler<Reg_EmergencyContactInfoResponse> outputPort);

        Task<bool> GetListView(Reg_EmergencyContactInfoRequest message, ICRUDRequestHandler<Reg_EmergencyContactInfoResponse> outputPort);


        Task<bool> GetDataForDropDown(Reg_EmergencyContactInfoRequest message, IDDLRequestHandler<Reg_EmergencyContactInfoResponse> outputPort);

    }
}
