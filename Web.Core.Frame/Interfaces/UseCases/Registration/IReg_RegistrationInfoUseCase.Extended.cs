using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Registration;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases.Registration
{
    public partial interface IReg_RegistrationInfoUseCase : IUseCaseRequestHandler<Reg_RegistrationInfoRequest, Reg_RegistrationInfoResponse>
    {

        Task<bool> GetFinallySubmittedRegInfoListView(Reg_RegistrationInfoRequest message, IReg_RegistrationInfoHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> GetFinallySubmittedRegInfoListForReview(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> GetRegInfoListForVolunteerSecurityClearance(Reg_RegistrationInfoRequest message, IReg_RegistrationInfoHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> GetRegInfoListDTForVolunteerSecurityClearance(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> GetRegInfoListForCentralAgencySy(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> GetRegInfoListForSecurityExam(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> GetRegInfoListDTForSecurityReTestApproval(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> GetRegInfoListForSecurityReTestApproval(Reg_RegistrationInfoRequest message, IReg_RegistrationInfoHandler<Reg_RegistrationInfoResponse> outputPort);
        Task<bool> GetRegInfoListForVolunteerUnitClearance(Reg_RegistrationInfoRequest message, IReg_RegistrationInfoHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> GetRegInfoListDTForVolunteerUnitClearance(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> GetRegInfoListForUnitClearance(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> GetRegInfoListForVolunteerMedicalClearance(Reg_RegistrationInfoRequest message, IReg_RegistrationInfoHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> GetRegInfoListDTForVolunteerMedicalClearance(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> GetRegInfoListForGeneralMedicalExam(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> GetRegInfoListForPsychologyExam(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> GetRegInfoListForFinalExam(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> GetRegInfoListForTrainingJoin(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> ApplicantReviewAuditResultUpdate(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> ForwardSecurityExamination(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> GroupForwardSecurityExamination(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> ApproveSecurityExaminationReTest(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> GroupApproveSecurityExaminationReTest(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> SecurityExaminationResultUpdate(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> CentralAgencySyResultUpdate(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> ForwardUnitClearance(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);
        
        Task<bool> GroupForwardUnitClearance(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> UnitClearanceResultUpdate(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> ForwardMedicalClearance(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> GroupForwardMedicalClearance(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> GeneralMedicalExaminationResultUpdate(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> PsychologyExaminationResultUpdate(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> FinalExaminationResultUpdate(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> TrainingJoinResultUpdate(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> GetSingleRegistrationInfoforSecurityExam(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> GetSingleRegistrationInfoforUnitClearance(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> GetSingleRegistrationInfoforGeneralMedicalExam(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> GetSingleRegistrationInfoforPsychologyExam(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> GetSingleRegistrationInfoforFinalExam(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> GetSingleRegistrationInfoforTrainingJoin(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> UpdateSyPrintProfile(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);

        Task<bool> UpdateMedExamFormPrint(Reg_RegistrationInfoRequest message, ICRUDRequestHandler<Reg_RegistrationInfoResponse> outputPort);
    }
}
