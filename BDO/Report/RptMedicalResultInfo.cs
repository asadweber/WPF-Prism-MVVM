using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace BDO.Report
{
    [Serializable]
    [DataContract(Name = "RptMedicalResultInfo", Namespace = "http://www.KAF.com/types")]
    public partial class RptMedicalResultInfo

    {
        public long MedExamResultID { get; set; }
        public long BasicInfoId { get; set; }
        

        public int MedExamResult { get; set; }
        
        public string MedExamComment { get; set; }
        
        public DateTime MedExamResultDate { get; set; }
        public string Remarks { get; set; }
       
    }
}
