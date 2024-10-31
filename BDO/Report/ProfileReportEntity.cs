using BDO.Core.DataAccessObjects.Models;
using CLL.LLClasses.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;

namespace BDO.Report
{
    [Serializable]
    [DataContract(Name = "ProfileReportEntity", Namespace = "http://www.KAF.com/types")]
    public class ProfileReportEntity
    {
        public List<RptBasicInfo> BasicProfile { get; set; }
        public List<RptRegistrationInfo> RegistrationInfo { get; set; }
        public List<RptfatherInfo> FatherInfo { get; set; }
       // public List<reg_famillyEntity> FatherInfo { get; set; }
        //public List<RptFamilyInfo> MotherInfo { get; set; }
        //public List<RptFamilyInfo> WifeInfo { get; set; }
        //public List<RptFamilyInfo> BrotherInfo { get; set; }
       // public List<RptFamilyInfo> SisterInfo { get; set; }
        public List<reg_famillyEntity> SpouseInfo { get; set; }
       
       // public List<reg_famillyEntity> SisterInfo { get; set; }
       // public List<RptFamilyInfo> PaternalUncle { get; set; }
       // public List<RptFamilyInfo> PaternalAunty { get; set; }
       // public List<RptFamilyInfo> MaternalUncle { get; set; }
        public List<RptFamilyInfo> FamilyInfo { get; set; }
       // public List<RptFamilyInfo> MaternalAunty { get; set; }
        public List<RptEmergencyContactInfo> EmergencyContact { get; set; }
       // public List<reg_educationinfoEntity> EducationInfo { get; set; }
        public List<RptEducationInfo> EducationInformation { get; set; }
        public List<RptApplicationList> ApplicationLists { get; set; }
        public List<RptApplicantStatus> ApplicationStatus { get; set; }

        public List<RptApplicationAssesmentList> ApplicationAssesmentList { get; set; }

        public List<RptApplicantAudit> ApplicantAudit { get; set; }

        public List<RptApplicantSmsStatus> ApplicantSmsEmailSendList { get; set; }
        public List<RptApplicantSmsStatus> MedExamSmsEmailSendList { get; set; }
        public List<RptApplicantSmsStatus> FinalExamSmsEmailSendList { get; set; }
        public List<RptApplicantSmsStatus> TrainingJoinSmsEmailSendList { get; set; }

        public List<RptApplicantAllDataBasic> ApplicantAllDataBasic { get; set; }

        public List<RptMedicalResultInfo> MedicalInformation { get; set; }
        public List<RptPsychoExamResultInfo> PsychoExamInformation { get; set; }

        public List<RptMedicalExamForm> MedicalExamForm { get; set; }
        public List<RptMedicalExamForm> UnitClearanceInformation { get; set; }

        public List<RptPsychoExamResultInfo> ExamResultInformation { get; set; }
        public List<RptPsychoExamResultInfo> AuditResultInformation { get; set; }

        public List<RptTrainingJoinInfo> TrainingJoinInformation { get; set; }
        public List<RptVolunteerTextExtForm> VolunteerTextExtForm { get; set; }
        public List<RptBatchSummaryRpt> BatchSummaryRpt { get; set; }
        public List<RptBatchSummary> BatchSummaryDetail { get; set; }

        public List<RptMedicalExamRep> MedicalExamReport { get; set; }
        public List<RptVolunteerClearanceList> VolunteerClearanceList { get; set; }

        public List<RptVolunteerExamLogList> VolunteerExamLogList { get; set; }
        public List<RptVolunteerCertificate> VolunteerCertificateInfo { get; set; }

        public List<RptVolunterContractRep> VolunteerContractInfo { get; set; }


    }
}
