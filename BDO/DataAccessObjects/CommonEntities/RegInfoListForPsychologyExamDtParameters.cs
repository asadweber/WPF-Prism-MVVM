using BDO.Core.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDO.Core.DataAccessObjects.CommonEntities
{
    public class RegInfoListForPsychologyExamDtParameters : DtParameters 
    {
        public string batchidstring { get; set; }
        public string? candidatetypeidstring { get; set; }
        public long ? candidatetypeid { get; set; }
        public string? nationalityidstring { get; set; }
        public string? professionidstring { get; set; }
        public long ? professionid { get; set; }
        public string? civilid { get; set; }
        public string? mobno { get; set; }
        public DateTime? medforwardedfromdate { get; set; }
        public DateTime? medforwardedtodate { get; set; }
        public int? psychoexamresult { get; set; }
    }

}
