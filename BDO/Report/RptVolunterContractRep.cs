using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;

namespace BDO.Report
{
    [Serializable]
    [DataContract(Name = "RptVolunterContractRep", Namespace = "http://www.KAF.com/types")]
    public partial class RptVolunterContractRep
    {
        public long VolunteerNo { get; set; }
        public string FullName { get; set; }
        public string ReqNo { get; set; }
        public string CivilID { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string CertificateName { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? JoinDate { get; set; }
        public string AddrsGover { get; set; }
        public string AddrsArea { get; set; }
        public string AddrsBlock { get; set; }
        public string AddrsStreet { get; set; }
        public string AddrsHouse { get; set; }
        public string Nationality { get; set; }


        public string ProfessionName { get; set; }
        public long V_DAY { get; set; }



    }
}
