using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.DataAccessObjects.ExtendedEntities
{
    public class TinyURLServicesSetting
    {
        public string? tinyurlapi { get; set; }
        public string? useranme { get; set; }
        public string? password { get; set; }
        public string? remoteIpAddress { get; set; }
    }
}
