using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Report
{
    [Serializable]
    [DataContract (Name = "RptBatchSummary", Namespace="http://www.KAF.com/types")]
    public partial class RptBatchSummary
    {

        public long batchid { get; set; }
        public int Registered { get; set; }
        public int Submitted { get; set; }
        public int ReviewPassed { get; set; }
        public int ReviewFailed { get; set; }
        public int ReviewWaiting { get; set; }
        public int ReviewRollback { get; set; }
        public int TotalReadyForSecurity { get; set; }
        public int TotalForwardedForSecurity { get; set; }
        public int SecurityPassed { get; set; }
        public int SecurityFailed { get; set; }
        public int SecurityWaiting { get; set; }
        public int SecurityRollback { get; set; }
        public int TotalReadyForUnit { get; set; }
        public int TotalForwardedForUnit { get; set; }
        public int UnitPassed { get; set; }
        public int UnitFailed { get; set; }
        public int UnitWaiting { get; set; } 
        public int UnitRollback { get; set; }
        public int TotalReadyForMedical { get; set; }
        public int TotalForwardedForMedical { get; set; }
        public int MedicalPassed { get; set; }
        public int MedicalFailed { get; set; }
        public int MedicalWaiting { get; set; }
        public int MedicalRollback { get; set; }
        public int FinlaExamPassed { get; set; }
        public int FinlaExamFailed { get; set; }
        public int FinlaExamWaiting { get; set;}
        public int TotalWaitingForJoin { get; set; }
        public int TotalJoin { get; set; }
        public int TotalNotificationWaiting { get; set; }
        public int TotalNotificationSent { get; set; }



    }
}
