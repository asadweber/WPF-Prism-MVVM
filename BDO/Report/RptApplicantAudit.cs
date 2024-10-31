using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;

namespace BDO.Report
{
    [Serializable]
    [DataContract(Name = "RptApplicantAudit", Namespace = "http://www.KAF.com/types")]
    public partial class RptApplicantAudit


    {


        public long RegistrationID { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public long BasicInfoSerial { get; set; }
        public string Nationality { get; set; }
        
        public string eligibleRank { get; set; }
        public string CandidateTypeName { get; set; }
        public string ProfessionName { get; set; }
        public string FullName { get; set; }
        public string CandidateType { get; set; }
        public string CivilID { get; set; }
        public string BirthCountry { get; set; }
        public DateTime? dob { get; set; }
        public string AreaName { get; set; }

        public string PreAddBlock { get; set; }
        public string PreAddStreet { get; set; }
        public string PreAddHousingNo { get; set; }
        public string Mob1 { get; set; }
        public string Mob2 { get; set; }

        public string CertificateName { get; set; }
        public string CertificateSubjectName { get; set; }
        public Boolean IsStudying { get; set; }
        public string MotherFullName { get; set; }

        public string MotherNationality { get; set; }
        public string MotherNationalityClass { get; set; }
        public string FatherStatus { get; set; }
        public string FatherJob { get; set; }
        public string MaritalStatus { get; set; }
    }






}
