﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BDO.Report
{
    [Serializable]
    [DataContract(Name = "RptMedicalExamRep", Namespace = "http://www.KAF.com/types")]
   
    public partial class RptMedicalExamRep
    {
       
        public string CivilId { get; set; }
       
        public string FullName { get; set; }
        public DateTime Dob { get; set; }
       
        public string Mob1 { get; set; }
        public string Mob2 { get; set; }
        public string Mob3 { get; set; }
        public string PreAddGovernarate { get; set; }
        public string PreAddCity { get; set; }
        public string PreAddBlock { get; set; }
        public string PreAddStreet { get; set; }
        public string PreAddHousingNo { get; set; }
        
        public string FullAddress { get; set; }
       
        [DataMember]
        public string Nationality { get; set; }
       
        public string BloodGroupName { get; set; }
        public byte[] volPhoto { get; set; }
        

    }
}