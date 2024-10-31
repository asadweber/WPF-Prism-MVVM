using System;
using System.Collections.Generic;
using System.Text;

namespace BDO.Core.DataAccessObjects.ExtendedEntities
{
    public class SendStatusSettings
    {
        public string ToCivilID { get; set; }
        public string ToPhoneNumber { get; set; }
        public int TimeFromHour { get; set; }
        public int TimeFromMin { get; set; }
        public int TimeFromSec { get; set; }
        public int TimeToHour { get; set; }
        public int TimeToMin { get; set; }
        public int TimeToSec { get; set; }
    }
}
