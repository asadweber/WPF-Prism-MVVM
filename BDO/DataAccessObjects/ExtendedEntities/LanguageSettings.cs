
using BDO.Core.Base;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Core.DataAccessObjects.ExtendedEntities
{
    [Serializable]
    [DataContract(Name = "LanguageSettings", Namespace = "http://www.KAF.com/types")]
    public class LanguageSettings : BaseEntity
    {
        [DataMember]
        public string culture { get; set; }
        [DataMember]
        public string returnUrl { get; set; }

    }
}
