using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace BDO.Report
{
    [Serializable]
    [DataContract(Name = "RptMedicalExamForm", Namespace = "http://www.KAF.com/types")]
    public partial class RptMedicalExamForm

    {
        public long volunteerNo { get; set; }
        public long BatchNo { get; set; }
        

       
        
        public string FullName { get; set; }
        
       
        public string CertificateName { get; set; }
        public string Mob1 { get; set; }

    }
}
