using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;

namespace BDO.Report
{
    [Serializable]
    [DataContract(Name = "RptApplicationAssesmentList", Namespace = "http://www.KAF.com/types")]
    public partial class RptApplicationAssesmentList
    {
        public long RegistrationID { get; set; }
        public string CivilID { get; set; }
        public long BatchNo { get; set; }
        public string FullName { get; set; }
        public string Mobile { get; set; }
        public string Nationality { get; set; }
        public string ProfessionName { get; set; }
        public string CertificateName { get; set; }

    }
}
