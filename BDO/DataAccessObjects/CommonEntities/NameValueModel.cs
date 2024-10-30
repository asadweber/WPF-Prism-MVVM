using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Core.DataAccessObjects.CommonEntities
{
    public class NameValueModel
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public long? ValueID { get; set; }

    }
}
