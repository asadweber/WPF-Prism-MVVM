using System;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Report
{
    [Serializable]
    [DataContract(Name = "RptApplicationList", Namespace = "http://www.KAF.com/types")]

    public partial class RptApplicationList
    {
        public long BasicInfoID { get; set; }
        public long RegistrationID { get; set; }
        
        public long BatchNo { get; set; }
        public long BatchID { get; set; }
        
        public long CandidateTypeID { get; set; }
        public string CandidateTypeName { get; set; }
        public string FullName { get; set; }
        public long professionId { get; set; }
        public string ProfessionName { get; set; }
        public string PhaseName { get; set; }
        public long PhaseID { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public long NationalityId { get; set; }
        public string CountryName { get; set; }
        public string CivilID { get; set; }
        public string StatusName { get; set; }
        public string mob1 { get; set; }



    }
}
