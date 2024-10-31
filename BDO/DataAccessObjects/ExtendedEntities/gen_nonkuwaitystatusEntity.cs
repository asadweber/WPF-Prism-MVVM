using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class gen_nonkuwaitystatusEntity
    {
        [DataMember]
        public bool IsChecked { get; set; }
        [DataMember]
        public long? regnonkuwaitystatusid { get; set; }
    }
}
