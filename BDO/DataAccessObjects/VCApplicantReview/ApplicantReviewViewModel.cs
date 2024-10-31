using BDO.Core.Base;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using BDO.DataAccessObjects.ExtendedEntities;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;

namespace BDO.DataAccessObjects.VCApplicantReview
{
    [Serializable]
    [DataContract(Name = "ApplicantReviewViewModel", Namespace = "http://www.KAF.com/types")]

    public class ApplicantReviewViewModel : BaseEntity
    {
        private List<reg_studentfilestorageEntity> documents;
        private reg_studentfilestorageEntity document;

        private List<cnf_filerequiredEntity> requiredfilelist;

        [DataMember]
        public owin_userEntity OwinUser { get; set; }

        [DataMember]
        public reg_registrationinfoEntity RegistrationInfo { get; set; }

        [DataMember]
        public List<reg_datacheckedEntity> RegDataChecked { get; set; }

        [DataMember]
        public reg_datacheckedEntity regDataCheckedEntity { get; set; }

        [DataMember]
        public reg_basicinfoEntity BasicInfo { get; set; }

        [DataMember]
        public reg_registrationinfoEntity CurrentRegistration { get; set; }

        [DataMember]
        public reg_educationinfoEntity EducationInfo { get; set; }

        [DataMember]
        public List<reg_educationinfoEntity> EducationInfoList { get; set; }

        [DataMember]
        public reg_famillyEntity FatherInfo { get; set; }

        [DataMember]
        public reg_famillyEntity MotherInfo { get; set; }

        [DataMember]
        public reg_famillyEntity famillyEntity { get; set; }

        [DataMember]
        public List<reg_famillyEntity> WifeList { get; set; }

        [DataMember]
        public reg_emergencycontactinfoEntity EmergencyContactInfo { get; set; }

        [DataMember]
        public List<reg_emergencycontactinfoEntity> EmergencyContactList { get; set; }

        public IOptions<ApplicationGlobalSettings> _applicationGlobalSettings { get; set; }

        [DataMember]
        public KAFPaciServiceSettings PaciServiceSettings { get; set; }

        [DataMember]
        public List<reg_studentfilestorageEntity> Documents { get => documents; set => documents = value; }

        [DataMember]
        public reg_studentfilestorageEntity Document { get => document; set => document = value; }

        [DataMember]
        public List<cnf_filerequiredEntity> RequiredFileList { get => requiredfilelist; set => requiredfilelist = value; }

        [DataMember]
        public long? BatchId { get; set; }
    }
}
