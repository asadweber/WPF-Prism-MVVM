using BDO.Core.Base;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Core.DataAccessObjects.CommonEntities
{
    public class RegInfoListForTrainingJoinDtParameters : DtParameters 
    {
        [DataMember]
        public string batchidstring { get; set; }
        [DataMember]
        public string? candidatetypeidstring { get; set; }
        [DataMember]
        public long ? candidatetypeid { get; set; }
        [DataMember]
        public string? nationalityidstring { get; set; }
        [DataMember]
        public string? professionidstring { get; set; }
        [DataMember]
        public long ? professionid { get; set; }
        [DataMember]
        public string? civilid { get; set; }
        [DataMember]
        public string? mobno { get; set; }  
        [DataMember]
        public DateTime? finalexamresultfromdate { get; set; }
        [DataMember]
        public DateTime? finalexamresulttodate { get; set; }
        [DataMember]
        public bool? notificationStatus { get; set; }
    }

}
