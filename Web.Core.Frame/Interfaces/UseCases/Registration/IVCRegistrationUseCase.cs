using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Registration;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases.Registration
{
    public partial interface IVCRegistrationUseCase : IUseCaseRequestHandler<VCRegistrationRequest, VCRegistrationResponse>
    {
        Task<bool> ValidateMobileNumber(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> ValidateEmailAddress(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> ValidateCivilIdPolicy(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> ValidateAgefromCivilId(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> ValidateAgefromCivilIdAdmin(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> ValidateCivilIdPolicyForSpecialRegistration(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> CreateRegistrationUser(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> CreateSpecialRegistrationUser(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> SavePreRegistration(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> SubmitFinalRegistration(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> AccountVarification(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
		Task<bool> ReSentVarificationCode(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
		Task<bool> GetRegistrationByCivilId(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
		Task<bool> GetRegistrationDetailsByCivilId(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
		Task<bool> GetRegistrationByCivilIdForDelete(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> RollbackFinalSubmit(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> GetRegistrationProfileDataWithDetailByBasicId(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> GetRegisteredApplicantCurrentBatchDataByBasicId(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> RegisterAnotherBatchSave(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> SaveDocument(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> getApplicationList(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> getApplicationStatus(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> getApplicationAssessmentList(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> getApplicantAudit(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> getApplicantAllDataBasic(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> getApplicantSmsStatus(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> getMedicalExamForm(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> getMedicalExamReport(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> getVolunteerTestExtForm(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> GetRegistrationByCivilIdforLogin(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> ApplicantRequiredDataValidation(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> getBatchSummaryRpt(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> getBatchSummaryDetail(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> getVolunteerClearance(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> getVolunteerExamLog(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> getVolunteerCertificateInfo(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> getMedExaSmsStatus(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> getFinalExaSmsStatus(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> getTrainingJoinSmsStatus(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);
        Task<bool> getVolunteerContract(VCRegistrationRequest message, IPreRegistrationRequestHandler<VCRegistrationResponse> outputPort);

    }
}
