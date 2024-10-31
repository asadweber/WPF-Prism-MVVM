

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.DataAccessObjects.VCApplicantReview;
using BDO.Report;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Ireg_registrationinfoFacadeObjects 
    {
        [OperationContract]
        Task<long> AddExt(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
         
        [OperationContract]
        Task<IList<reg_registrationinfoEntity>> GetAllExt(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<reg_registrationinfoEntity>> GetFinallySubmittedRegInfoListView(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<reg_registrationinfoEntity>> GetFinallySubmittedRegInfoListForReview(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<reg_registrationinfoEntity>> GetRegInfoListForVolunteerSecurityClearance(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<reg_registrationinfoEntity>> GetRegInfoListForSecurityExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<reg_registrationinfoEntity>> GetRegInfoListForCentralAgencySy(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<reg_registrationinfoEntity>> GetRegInfoListForSecurityReTestApproval(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<reg_registrationinfoEntity>> GetRegInfoListForVolunteerUnitClearance(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<reg_registrationinfoEntity>> GetRegInfoListForUnitClearance(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<reg_registrationinfoEntity>> GetRegInfoListForVolunteerMedicalClearance(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<reg_registrationinfoEntity>> GetRegInfoListForGeneralMedicalExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<reg_registrationinfoEntity>> GetRegInfoListForPsychologyExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<reg_registrationinfoEntity>> GetRegInfoListForFinalExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<IList<reg_registrationinfoEntity>> GetRegInfoListForTrainingJoin(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<ApplicantReviewViewModel> GetApplicantDetailsByRegistrationIDForReview(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> ApplicantReviewAuditResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> ForwardSecurityExamination(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> GroupForwardSecurityExamination(List<reg_registrationinfoEntity> reg_registrationinfoList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> ApproveSecurityExaminationReTest(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> GroupApproveSecurityExaminationReTest(List<reg_registrationinfoEntity> reg_registrationinfoList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SecurityExaminationResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> CentralAgencySyResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> ForwardUnitClearance(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> GroupForwardUnitClearance(List<reg_registrationinfoEntity> reg_registrationinfoList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> UnitClearanceResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> ForwardMedicalClearance(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> GroupForwardMedicalClearance(List<reg_registrationinfoEntity> reg_registrationinfoList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> GeneralMedicalExaminationResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> PsychologyExaminationResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> FinalExaminationResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> TrainingJoinResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<reg_registrationinfoEntity> GetSingleRegistrationInfoforSecurityExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<reg_registrationinfoEntity> GetSingleRegistrationInfoforUnitClearance(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<reg_registrationinfoEntity> GetSingleRegistrationInfoforGeneralMedicalExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<reg_registrationinfoEntity> GetSingleRegistrationInfoforPsychologyExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<reg_registrationinfoEntity> GetSingleRegistrationInfoforFinalExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<reg_registrationinfoEntity> GetSingleRegistrationInfoforTrainingJoin(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<ProfileReportEntity> getApplicationList(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<ProfileReportEntity> getApplicationStatus(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<ProfileReportEntity> getApplicationAssessmentList(reg_registrationinfoEntity reg_Registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<ProfileReportEntity> getApplicantAudit(reg_registrationinfoEntity reg_Registrationinfo, CancellationToken cancellationToken);
        [OperationContract]
        Task<ProfileReportEntity> getApplicantAllDataBasic(reg_registrationinfoEntity reg_Registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<ProfileReportEntity> getApplicantSmsStatus(reg_registrationinfoEntity reg_Registrationinfo, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<ProfileReportEntity> getMedicalExamForm(reg_registrationinfoEntity reg_Registrationinfo, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<ProfileReportEntity> getMedicalExamReport(reg_registrationinfoEntity reg_Registrationinfo, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<ProfileReportEntity> getVolunteerTestExtForm(reg_registrationinfoEntity reg_Registrationinfo, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<ProfileReportEntity> getBatchSummaryRpt(reg_registrationinfoEntity reg_Registrationinfo, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<ProfileReportEntity> getBatchSummaryDetail(reg_registrationinfoEntity reg_Registrationinfo, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<ProfileReportEntity> getVolunteerClearance(reg_registrationinfoEntity reg_Registrationinfo, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<ProfileReportEntity> getVolunteerExamLog(reg_registrationinfoEntity reg_Registrationinfo, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<ProfileReportEntity> getVolunteerCertificateInfo(reg_registrationinfoEntity reg_Registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> UpdateSyPrintProfile(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> UpdateMedExamFormPrint(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
        Task<ProfileReportEntity> getMedExaSmsStatus(reg_registrationinfoEntity reg_Registrationinfo, CancellationToken cancellationToken);
        
        Task<ProfileReportEntity> getFinalExaSmsStatus(reg_registrationinfoEntity reg_Registrationinfo, CancellationToken cancellationToken);
        Task<ProfileReportEntity> getTrainingJoinSmsStatus(reg_registrationinfoEntity reg_Registrationinfo, CancellationToken cancellationToken);
        Task<ProfileReportEntity> getVolunteerContract(reg_registrationinfoEntity reg_Registrationinfo, CancellationToken cancellationToken);
    }
}
