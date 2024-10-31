using BDO.Core.Base;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using BDO.DataAccessObjects.ExtendedEntities;
using CLL.LLClasses.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;

namespace BDO.DataAccessObjects.VCRegistration
{
    [Serializable]
    [DataContract(Name = "RegistrationViewModel", Namespace = "http://www.KAF.com/types")]
    public class RegistrationViewModel : BaseEntity, IValidatableObject
    {
        private bool isAllowToRollbak = true;
        private bool isApplyAnotherBatchAllowed = true;

        private List<reg_studentfilestorageEntity> documents;
        private reg_studentfilestorageEntity document;

        private List<cnf_filerequiredEntity> requiredfilelist;

        [DataMember]
        public owin_userEntity OwinUser { get; set; }

        [DataMember]
        public reg_basicinfoEntity BasicInfo { get; set; }

        [DataMember]
        public reg_registrationinfoEntity CurrentRegistration { get; set; }

        [DataMember]
        public reg_educationinfoEntity EducationInfo { get; set; }

        [DataMember]
        public List<reg_educationinfoEntity> EducationInfoList { get; set; }

        [DataMember]
        public List<reg_famillyEntity> WifeList { get; set; }


        [DataMember]
        public reg_famillyEntity FatherInfo { get; set; }

        [DataMember]
        public reg_famillyEntity MotherInfo { get; set; }

        [DataMember]
        public reg_famillyEntity BrotherInfo { get; set; }

        [DataMember]
        public reg_famillyEntity SisterInfo { get; set; }

        [DataMember]
        public reg_famillyEntity PaternalUncleInfo { get; set; }

        [DataMember]
        public reg_famillyEntity PaternalAuntyInfo { get; set; }

        [DataMember]
        public reg_famillyEntity MaternalUncleInfo { get; set; }

        [DataMember]
        public reg_famillyEntity MaternalAuntyInfo { get; set; }

        [DataMember]
        public reg_famillyEntity famillyEntity { get; set; }


        [DataMember]
        public List<reg_famillyEntity> FamillyList { get; set; }

        [DataMember]
        public reg_emergencycontactinfoEntity EmergencyContactInfo { get; set; }

        [DataMember]
        public List<reg_emergencycontactinfoEntity> EmergencyContactList { get; set; }

        [DataMember]
        public long? MilitaryType { get; set; }

        [DataMember]
        public long? BatchCandidateTypeMapId { get; set; }

        [DataMember]
        public long? BatchId { get; set; }
        public IOptions<ApplicationGlobalSettings> _applicationGlobalSettings { get; set; }

        [DataMember]
        public bool IsAllowToRollbak { get => isAllowToRollbak; set => isAllowToRollbak = value; }

        [DataMember]
        public bool IsApplyAnotherBatchAllowed { get => isApplyAnotherBatchAllowed; set => isApplyAnotherBatchAllowed = value; }

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {

            if (CurrentRegistration != null)
            {
                if (MilitaryType == (long)MilitaryTypeEnum.Professionals && !CurrentRegistration.professionid.HasValue)
                {
                    yield return new ValidationResult(CLL.LLClasses.Models._reg_registrationinfo.professionselectmessage, new[] { $"{nameof(CurrentRegistration)}.{nameof(CurrentRegistration.professionid)}" });
                }

                if (CurrentRegistration.candidatetypeid == (long)CandidateTypeEnum.Other_Nationality && !BasicInfo.residenttypeid.HasValue)
                {
                    yield return new ValidationResult($"Please Select ResidentType", new[] { $"{nameof(BasicInfo)}.{nameof(BasicInfo.residenttypeid)}" });
                }
            }

        }

        [DataMember]
        public KAFPaciServiceSettings PaciServiceSettings { get; set; }

        [DataMember]
        public List<reg_studentfilestorageEntity> Documents { get => documents; set => documents = value; }

        [DataMember]
        public reg_studentfilestorageEntity Document { get => document; set => document = value; }

        [DataMember]
        public List<cnf_filerequiredEntity> RequiredFileList { get => requiredfilelist; set => requiredfilelist = value; }

        [DataMember]
        public tran_notificationbatchdetEntity NotificationBatchDetail { get; set; }

        [DataMember]
        public List<tran_notificationbatchdetEntity> NotificationBatchDetailList { get; set; }

        [DataMember]
        public tran_auditresultEntity AuditResult { get; set; }

        [DataMember]
        public List<tran_volunteersyclearanceEntity> VolSyClearanceList { get; set; }

        [DataMember]
        public tran_syexamresultEntity SyExamResult { get; set; }

        [DataMember]
        public List<tran_syexamnotificationEntity> SyExamNotificationList { get; set; }

        [DataMember]
        public List<tran_volunteerunitclearanceEntity> VolUnitClearanceList { get; set; }

        [DataMember]
        public tran_unitclearanceresultEntity UnitClearanceResult { get; set; }

        [DataMember]
        public List<tran_volunteermedclearanceEntity> VolMedClearanceList { get; set; }

        [DataMember]
        public tran_medexamresultEntity MedExamResult { get; set; }

        [DataMember]
        public List<tran_medexamnotificationEntity> MedExamNotificationList { get; set; }

        [DataMember]
        public tran_psychoexamresultEntity PsychoExamResult { get; set; }

        [DataMember]
        public tran_finalexamresultEntity FinalExamResult { get; set; }

        [DataMember]
        public tran_trainingjoinEntity TrgJoin { get; set; }

        [DataMember]
        public tran_specialregistrationEntity SpecialRegistration { get; set; }

        [DataMember]
        public tran_applyanotherbatchEntity AppyAnotherBatch { get; set; }

        [DataMember]
        public List<tran_applyanotherbatchEntity> AppyAnotherBatchList { get; set; }
    }
}


