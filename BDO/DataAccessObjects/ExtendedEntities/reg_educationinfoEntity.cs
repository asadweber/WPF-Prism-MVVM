using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class reg_educationinfoEntity
    {
        private List<reg_studentfilestorageEntity> certificateDocuments;
        private long? registrationID;
        private string _civilId;
        private bool? _iseducationdataavailable;

        [DataMember]
        [Display(Name = "CertificateLevel", ResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo))]
        public string CertificateLevel { get; set; }
        
        [DataMember]
        [Display(Name = "CertificateName", ResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo))]
        public string CertificateName { get; set; }
        
        [DataMember]
        [Display(Name = "CertificateSubjectName", ResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo))]
        public string CertificateSubjectName { get; set; }

        [DataMember]
        public string civilid { get => _civilId; set => _civilId = value; }
        
        [DataMember]
        public long? RegistrationID { get => registrationID; set => registrationID = value; }
        
        [DataMember]
        public List<reg_studentfilestorageEntity> CertificateDocuments { get => certificateDocuments; set => certificateDocuments = value; }

        [DataMember]
        public bool? IsEducationDataAvailable { get => _iseducationdataavailable; set => _iseducationdataavailable = value; }
    }
}
