using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;

namespace BDO.Report
{
    [Serializable]
    [DataContract(Name = "RptMotherInfo", Namespace = "http://www.KAF.com/types")]
    public partial class RptMotherInfo
    {
        public long BasicInfoId { get; set; }
        public string CivilID { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }
        public string Name4 { get; set; }
        public string Name5 { get; set; }
        public DateTime? BirthDate { get; set; }
        public string MobilePhone1 { get; set; }
        public string LanPhone1 { get; set; }
        public string Email { get; set; }
        public string BirthcountryName { get; set; }
        public string Nationality { get; set; }
        public string BloodGroupName { get; set; }
        public string PassportNumber { get; set; }
        public string ReligionName { get; set; }
       public long FamilyID { get; set; }
        public bool? IsInKuwait { get; set; }
        public bool? IsAlive { get; set; }

    }
}
