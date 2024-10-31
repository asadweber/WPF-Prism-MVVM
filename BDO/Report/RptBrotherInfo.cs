using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Report
{
    [Serializable]
    [DataContract(Name = "RptBrotherInfo", Namespace= "http://www.KAF.com/types")]
    public partial class RptBrotherInfo
    {
        public long BasicInfoID { get; set; }
        public string CivilID { get; set; }
        public string fullname { get; set; }
      public string BloodGroupName { get; set; }
        public string PassportNumber { get; set; }
        public string WorkCompany { get; set; }
        public string Nationality { get; set; }
        public bool? IsInKuwait { get; set; }
        public bool? IsFatherSide { get; set; }
        public long FamilyID { get; set; }
        public bool? IsMarried { get; set; }


    }
}
