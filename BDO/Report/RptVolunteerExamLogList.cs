using System;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Report
{
    [Serializable]
    [DataContract(Name = "RptVolunteerExamLogList", Namespace = "http://www.KAF.com/types")]

    public partial class RptVolunteerExamLogList
    {
        public long BatchNo { get; set; }
        public long BatchID { get; set; }
        public string CivilID { get; set; }
        public string FullName { get; set; }
        public string Mob1 { get; set; }
        public string CandidateTypeName { get; set; }
        public string nationality { get; set; }

        public int Ready { get; set; }
        public int Forwarded { get; set; }
        public DateTime? ForwardDate { get; set; }

       
        public DateTime? ResultDate { get; set; }

        public int Result { get; set; }
        public int dayscount { get; set; }
        
        
        



    }
}
