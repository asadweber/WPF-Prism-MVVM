using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;
namespace BDO.Report
{

    [Serializable]
    [DataContract(Name = "RptEmergencyContactInfo", Namespace = "http://www.KAF.com/types")]
    public partial class RptEmergencyContactInfo
    {

        public long BasicInfoID { get; set; }
        public long FamilyID { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }
        public string Name4 { get; set; }
        public string Name5 { get; set; }
        public string FullName { get; set; }
        public string EmrgRelationshipName { get; set; }
        public string Mobile1 { get; set; }
        public string Mobile2 { get; set; }
        public string Telephone1 { get; set; }
        public string Email { get; set; }
        public string Remarks { get; set; }
        public string Comment { get; set; }

    }
}
