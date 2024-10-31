using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Report
{
    [Serializable]
    [DataContract (Name = "RptWifeInfo", Namespace="http://www.KAF.com/types")]
    public partial class RptWifeInfo
    {

        public long BasicInfoID { get; set; }
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
        public bool? IsInKuwait { get; set; } 
        public string BloodGroupName { get; set; }
        public string PassportNumber { get; set; }
        public string ReligionName { get; set; }
        public string ClassName { get; set; }
        public DateTime? DeathDate { get; set; }
        public bool? IsAlive { get; set; }
        public long FamilyID { get; set; }
        public DateTime? FamilyMarriageDate { get; set;}
        public DateTime? FamilyMarriageDocDate { get; set;}
        public string FamilyMarriageDocNo { get; set;}

    }
}
