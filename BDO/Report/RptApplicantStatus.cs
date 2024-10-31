using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;

namespace BDO.Report
{
    [Serializable]
    [DataContract(Name = "RptApplicantStatus", Namespace = "http://www.KAF.com/types")]
    public partial class RptApplicantStatus
    {


        public long RegistrationID { get; set; }
        public string CivilID { get; set; }
        public long BatchNo { get; set; }
        public string FullName { get; set; }
        public string CandidateTypeName { get; set; }
        public string ProfessionName { get; set; }
        public string PhaseName { get; set; }
        public string StatusName { get; set; }
        public string reviewComment { get; set; }
        public DateTime? reviewDate { get; set; }
        public string submittedBy { get; set; }
        public DateTime? submittedDate { get; set; }
        public string PhaseEnteredBy { get; set; }
        public DateTime? PhaseEnteredDate { get; set; }
        public DateTime? ApplicationDate { get; set; }
       




    }
}
