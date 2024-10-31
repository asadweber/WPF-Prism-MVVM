using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using IDAC.Core.IDataAccessObjects.General;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.Base;
using BDO.DataAccessObjects.VCApplicantReview;
using BDO.Report;

namespace IDAC.Core.IDataAccessObjects.General
{
    public partial interface Ireg_registrationinfoDataAccessObjects
    {

        Task<long> AddExt(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<IList<reg_registrationinfoEntity>> GetAllExt(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<IList<reg_registrationinfoEntity>> GetFinallySubmittedRegInfoListView(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<IList<reg_registrationinfoEntity>> GetFinallySubmittedRegInfoListForReview(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<IList<reg_registrationinfoEntity>> GetRegInfoListForVolunteerSecurityClearance(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<IList<reg_registrationinfoEntity>> GetRegInfoListForSecurityExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<IList<reg_registrationinfoEntity>> GetRegInfoListForCentralAgencySy(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<IList<reg_registrationinfoEntity>> GetRegInfoListForSecurityReTestApproval(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<IList<reg_registrationinfoEntity>> GetRegInfoListForVolunteerUnitClearance(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<IList<reg_registrationinfoEntity>> GetRegInfoListForUnitClearance(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<IList<reg_registrationinfoEntity>> GetRegInfoListForVolunteerMedicalClearance(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<IList<reg_registrationinfoEntity>> GetRegInfoListForGeneralMedicalExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<IList<reg_registrationinfoEntity>> GetRegInfoListForPsychologyExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<IList<reg_registrationinfoEntity>> GetRegInfoListForFinalExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<IList<reg_registrationinfoEntity>> GetRegInfoListForTrainingJoin(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<ApplicantReviewViewModel> GetApplicantDetailsByRegistrationIDForReview(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<long> ApplicantReviewAuditResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<long> ForwardSecurityExamination(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<long> GroupForwardSecurityExamination(List<reg_registrationinfoEntity> reg_registrationinfoList, CancellationToken cancellationToken);

        Task<long> ApproveSecurityExaminationReTest(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<long> GroupApproveSecurityExaminationReTest(List<reg_registrationinfoEntity> reg_registrationinfoList, CancellationToken cancellationToken);

        Task<long> SecurityExaminationResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<long> CentralAgencySyResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<long> ForwardUnitClearance(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
        
        Task<long> GroupForwardUnitClearance(List<reg_registrationinfoEntity> reg_registrationinfoList, CancellationToken cancellationToken);

        Task<long> UnitClearanceResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<long> ForwardMedicalClearance(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<long> GroupForwardMedicalClearance(List<reg_registrationinfoEntity> reg_registrationinfoList, CancellationToken cancellationToken);

        Task<long> GeneralMedicalExaminationResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<long> PsychologyExaminationResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<long> FinalExaminationResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<long> TrainingJoinResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<reg_registrationinfoEntity> GetSingleRegistrationInfoforSecurityExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<reg_registrationinfoEntity> GetSingleRegistrationInfoforUnitClearance(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<reg_registrationinfoEntity> GetSingleRegistrationInfoforGeneralMedicalExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<reg_registrationinfoEntity> GetSingleRegistrationInfoforPsychologyExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<reg_registrationinfoEntity> GetSingleRegistrationInfoforFinalExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<reg_registrationinfoEntity> GetSingleRegistrationInfoforTrainingJoin(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<ProfileReportEntity> getApplicationList(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<ProfileReportEntity> getApplicationStatus(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<ProfileReportEntity> getApplicationAssessmentList(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<ProfileReportEntity> getApplicantAudit(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
        
        Task<ProfileReportEntity> getApplicantAllDataBasic(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
        
        Task<ProfileReportEntity> getApplicantSmsStatus(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
        
        Task<ProfileReportEntity> getMedicalExamForm(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
        
        Task<ProfileReportEntity> getMedicalExamReport(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
        
        Task<ProfileReportEntity> getVolunteerTestExtForm(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);

        Task<ProfileReportEntity> getBatchSummaryRpt(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
        
        Task<ProfileReportEntity> getBatchSummaryDetail(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
        
        Task<ProfileReportEntity> getVolunteerClearance(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
        
        Task<ProfileReportEntity> getVolunteerExamLog(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
        
        Task<ProfileReportEntity> getVolunteerCertificateInfo(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
        
        Task<long> UpdateSyPrintProfile(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
        
        Task<long> UpdateMedExamFormPrint(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
        Task<ProfileReportEntity> getMedExaSmsStatus(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
        Task<ProfileReportEntity> getFinalExaSmsStatus(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
        Task<ProfileReportEntity> getTrainingJoinSmsStatus(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
        Task<ProfileReportEntity> getVolunteerContract(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
    }
}