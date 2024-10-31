using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Registration;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases.Registration
{
   public partial interface IReg_EmergencyContactInfoUseCase : IUseCaseRequestHandler<Reg_EmergencyContactInfoRequest, Reg_EmergencyContactInfoResponse>
   {
        Task<bool> GetListViewByBasicId(Reg_EmergencyContactInfoRequest message, ICRUDRequestHandler<Reg_EmergencyContactInfoResponse> outputPort);
		Task<bool> SaveOrUpdate(Reg_EmergencyContactInfoRequest message, ICRUDRequestHandler<Reg_EmergencyContactInfoResponse> outputPort);
		Task<bool> ApplicantReviewSaveOrUpdate(Reg_EmergencyContactInfoRequest message, ICRUDRequestHandler<Reg_EmergencyContactInfoResponse> outputPort);
        Task<bool> GetSingleById(Reg_EmergencyContactInfoRequest message, ICRUDRequestHandler<Reg_EmergencyContactInfoResponse> outputPort);
        Task<bool> DeleteRegEmgContactInfoWithRelativesWorkingInMOD(Reg_EmergencyContactInfoRequest message, ICRUDRequestHandler<Reg_EmergencyContactInfoResponse> outputPort);

    }
}
