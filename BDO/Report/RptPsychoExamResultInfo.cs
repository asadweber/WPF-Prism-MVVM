using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace BDO.Report
{
    [Serializable]
    [DataContract(Name = "RptPsychoExamResultInfo", Namespace = "http://www.KAF.com/types")]
    public partial class RptPsychoExamResultInfo

    {
        public string CivilID { get; set; }
        public long ExamResultID { get; set; }
        public long BasicInfoId { get; set; }
        

        public long ExamResult { get; set; }
        
        public string ExamComment { get; set; }
        
        public DateTime ExamResultDate { get; set; }
        public string Remarks { get; set; }
        public int examtype { get; set; }

    }
}
