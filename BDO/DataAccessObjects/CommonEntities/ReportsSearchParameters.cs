using BDO.Core.Base;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Core.DataAccessObjects.CommonEntities
{
    [Serializable]
    [DataContract(Name = "S2Parameters", Namespace = "http://www.KAF.com/types")]
    public class ReportsSearchParameters : BaseEntity
    {
        [DataMember]
        public long? batchid { get; set; }
        [DataMember]
        public string? batchidstring { get; set; }
        [DataMember]
        public string? batchName { get; set; }
        [DataMember]
        public long? candidatetypeid { get; set; }
        [DataMember]
        public string? professionidstring { get; set; }
        [DataMember]
        public DateTime? fromdate { get; set; }
        [DataMember]
        public DateTime? todate { get; set; }
        [DataMember]
        public string? civilid { get; set; }
        [DataMember]
        public DateTime? smssentdate { get; set; }
        [DataMember]
        public DateTime? interviewdate { get; set; }
        [DataMember]
        public bool? notificationstatus { get; set; }
    }

}
