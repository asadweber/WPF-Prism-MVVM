using BDO.Core.Base;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.DataAccessObjects.CommonEntities
{
    [Serializable]
    [DataContract(Name = "VolunteerExamLogReportsSearchParameters", Namespace = "http://www.KAF.com/types")]
    public class VolunteerExamLogReportsSearchParameters : BaseEntity
    {
        [DataMember]
        public long batchid { get; set; }
        [DataMember]
        public string? batchidstring { get; set; }
        [DataMember]
        public long? candidatetypeid { get; set; }
        [DataMember]
        public string? candidatetypeidstring { get; set; }
        [DataMember]
        public long? professionid { get; set; }
        [DataMember]
        public string? professionidstring { get; set; }
        [DataMember]
        public long? countryid { get; set; }
        [DataMember]
        public string? countryidstring { get; set; }
        [DataMember]
        public long? examtypeid { get; set; }
        [DataMember]
        public string? civilid { get; set; }
    }
}
