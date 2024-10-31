using BDO.Core.Base;
using BDO.Core.DataAccessObjects.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Core.DataAccessObjects.CommonEntities
{
    public class RegInfoListForGeneralMedicalExamDtParameters : DtParameters 
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
        public DateTime? syclearancefromdate { get; set; }
        [DataMember]
        public DateTime? syclearancetodate { get; set; }
        [DataMember]
        public int? medexamresult { get; set; }
        [DataMember]
        public decimal? unitclearancemarkfrom { get; set; }
        [DataMember]
        public decimal? unitclearancemarkto { get; set; }
        [DataMember]
        public DateTime? medforwardedfromdate { get; set; }
        [DataMember]
        public DateTime? medforwardedtodate { get; set; }
        [DataMember]
        public bool? ismedforwarded { get; set; }
        [DataMember]
        public bool? notificationStatus { get; set; }
    }

}
