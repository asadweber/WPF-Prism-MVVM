using BDO.Core.DataAccessObjects.CommonEntities;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;

namespace BDO.Core.DataAccessObjects.CommonEntities
{
    [Serializable]
    [DataContract(Name = "S2CountryClassByCountryIdParameter", Namespace = "http://www.KAF.com/types")]
    public class S2CountryClassByCountryIdParameter : S2Parameters
    {
        [DataMember]
        public long CountryId { get; set; }
    }
}
