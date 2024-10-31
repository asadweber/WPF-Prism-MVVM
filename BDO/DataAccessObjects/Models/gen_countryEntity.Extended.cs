using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class gen_countryEntity
    {
        [DataMember]
        public long? CandidateTypeId { get; set; }

        [DataMember]
        public bool? HasGovernarate { get; set; }

        [DataMember]
        public int? NationalityListType { get; set; }

        [DataMember]
        public bool? IsInculdeAll { get; set; }

    }
}
