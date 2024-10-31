using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace BDO.Report
{
    [Serializable]
    [DataContract(Name = "RptVolunteerTextExtForm", Namespace = "http://www.KAF.com/types")]
    public partial class RptVolunteerTextExtForm

    {
        public long volunteerNo { get; set; }
        public long BatchNo { get; set; }
        

       
        
        public string FullName { get; set; }
        
       
        public string CertificateName { get; set; }
        public string Mob1 { get; set; }
        public DateTime DOB { get; set; }       
        public int ageYear { get; set; }
        public int ageYearMonths { get; set; }
        public string CountryName { get; set; }


    }
}
