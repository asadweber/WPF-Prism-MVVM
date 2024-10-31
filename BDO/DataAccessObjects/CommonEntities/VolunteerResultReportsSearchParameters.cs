using BDO.Core.Base;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Core.DataAccessObjects.CommonEntities
{
    [Serializable]
    [DataContract(Name = "VolunteerResultReportsSearchParameters", Namespace = "http://www.KAF.com/types")]
    public class VolunteerResultReportsSearchParameters : BaseEntity
    {
        [DataMember]
        public long? reportparam { get; set; }
        [DataMember]
         public long? batchid { get; set; }
      //  public string? batchidstring { get; set; }
        [DataMember]
        public DateTime? fromdate { get; set; }
        [DataMember]
        public DateTime? todate { get; set; }
        [DataMember]
        public DateTime? auditedfromdate { get; set; }
        [DataMember]
        public DateTime? auditedtodate { get; set; }
        [DataMember]
        public long? natselect { get; set; }
        [DataMember]
        public long? certificatelevelid { get; set; }
        [DataMember]
        public long? result { get; set; }
        [DataMember]
        public long? countrycityid { get; set; }
        [DataMember]
        public long? candidatetypeid { get; set; }
        [DataMember]
        public string? professionidstring { get; set; }


    }
}
