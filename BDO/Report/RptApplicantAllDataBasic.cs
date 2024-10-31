using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;

namespace BDO.Report
{
    [Serializable]
    [DataContract(Name = "RptApplicantAllDataBasic", Namespace = "http://www.KAF.com/types")]
    public partial class RptApplicantAllDataBasic
    {
        public long RegistrationID { get; set; }
        public string CivilID { get; set; }
        public string FullName { get; set; }
        public DateTime? DOB { get; set; }
       
        public string ProfessionName { get; set; }

        public string CandidateTypeName { get; set; }
        public string Nationality { get; set; }
        public string ClassName { get; set; }
        public string BloodGroupName { get; set; }

        public string MaritalStatus { get; set; }
        public string BirthCountry { get; set; }
        public long? BatchNo { get; set; }


    }
}
