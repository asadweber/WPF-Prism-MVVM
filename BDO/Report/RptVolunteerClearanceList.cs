using System;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Report
{
    [Serializable]
    [DataContract(Name = "RptVolunteerClearanceList", Namespace = "http://www.KAF.com/types")]

    public partial class RptVolunteerClearanceList
    {
        public long BatchNo { get; set; }
        public long BatchID { get; set; }
        public string CivilID { get; set; }
        public string FullName { get; set; }
        public string Mob1 { get; set; }
        public string CandidateTypeName { get; set; }
        public string nationality { get; set; }

        public string ProfessionName { get; set; }

        public int ReadyForSecurity { get; set; }
        public int IsSecurityForwarded { get; set; }
        public DateTime? SecForwardDate { get; set; }

        public int ReadyForUnit { get; set; }
        public int IsUnitForwarded { get; set; }
        public DateTime? UnitForwardDate { get; set; }

        public int ReadyForMedical { get; set; }
        public int IsMedForwarded { get; set; }
        public DateTime? MedForwardDate { get; set; }
        
        



    }
}
