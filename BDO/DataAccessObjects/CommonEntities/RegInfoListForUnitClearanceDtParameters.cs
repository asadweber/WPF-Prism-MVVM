using BDO.Core.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDO.Core.DataAccessObjects.CommonEntities
{
    public class RegInfoListForUnitClearanceDtParameters : DtParameters 
    {
        public string batchidstring { get; set; }
        public string? candidatetypeidstring { get; set; }
        public long? candidatetypeid { get; set; }
        public string? nationalityidstring { get; set; }
        public string? professionidstring { get; set; }
        public long? professionid { get; set; }
        public string? civilid { get; set; }
        public string? mobno { get; set; }
        public DateTime? syclearancefromdate { get; set; }
        public DateTime? syclearancetodate { get; set; }
        public int? unitclearanceresult { get; set; }
        public bool? isunitforwarded { get; set; }
        public DateTime? unitforwardedfromdate { get; set; }
        public DateTime? unitforwardedtodate { get; set; }
    }

}
