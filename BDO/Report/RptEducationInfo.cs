using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace BDO.Report
{
    [Serializable]
    [DataContract(Name = "RptEducationInfo", Namespace = "http://www.KAF.com/types")]
    public partial class RptEducationInfo
    
    {

        public long BasicInfoId { get; set; }
        
        public string CertificateLevel { get; set; }
        public string CertificateSubjectName { get; set; }
        public string CertificateName { get; set; }
        public string InstituteName { get; set; }
        public string EduGradeName { get; set; }
        public decimal? Points { get; set; }
        public DateTime PassYear { get; set; }
        public string CountryName { get; set; }
        public string Comment { get; set; }
    }
}
