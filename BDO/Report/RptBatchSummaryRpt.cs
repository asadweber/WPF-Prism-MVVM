using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Report
{
    [Serializable]
    [DataContract (Name = "RptBatchSummaryRpt", Namespace="http://www.KAF.com/types")]
    public partial class RptBatchSummaryRpt
    {

        public long PhaseID { get; set; }
        public string PhaseName { get; set; }
        public string Comment { get; set; }
        public long PhaseWiseCount { get; set; }
       
        

    }
}
