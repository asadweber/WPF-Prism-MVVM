using System;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Report
{
    [Serializable]
    [DataContract(Name = "RptVolunteerCertificate", Namespace = "http://www.KAF.com/types")]

    public partial class RptVolunteerCertificate
    {
        public long BatchNo { get; set; }
       
        public string CivilID { get; set; }
        public string FullName { get; set; }
        public string Mob1 { get; set; }
        public string CertificateName { get; set; }
        public string EducationMajorName { get; set; }

        public DateTime? PassYear { get; set; }
        public DateTime? ApplicationDate { get; set; }

        public string PhaseName { get; set; }






    }
}
