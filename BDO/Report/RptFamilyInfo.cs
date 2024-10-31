using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;

namespace BDO.Report
{
    [Serializable]
    [DataContract(Name = "RptFamilyInfo", Namespace = "http://www.KAF.com/types")]
    public partial class RptFamilyInfo
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
        public string MilitaryID { get; set; }
        public bool? IsInKuwait { get; set; }
        public long? SplMilStatus { get; set; }
        public string BloodGroupName { get; set; }
        public string WorkCompany { get; set; }
        public string PassportNumber { get; set; }
        public string ReligionName { get; set; }
        public bool? IsServedInMilitary { get; set; }
        public bool? IsServing { get; set; }
        public string ClassName { get; set; }
        public DateTime? DeathDate { get; set; }
        public bool? IsAlive { get; set; }
        public long FamilyID { get; set; }
        public string FullName { get; set;}
        public string CompanyAddress { get; set; }
        public bool? IsMarried { get; set; }
        public DateTime? FamilyMarriageDate { get; set; }
        public DateTime? FamilyMarriageDocDate { get; set; }
        public string FamilyMarriageDocNo { get; set; }
        public bool? IsFatherSide { get; set; }
        public long? RelationShipID { get; set; }

    }
}
