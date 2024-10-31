using BDO.Core.Base;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Core.DataAccessObjects.CommonEntities
{
    [Serializable]
    [DataContract(Name = "S2Parameters", Namespace = "http://www.KAF.com/types")]
    public class S2Parameters : BaseEntity
    {
        private int? nationalityListType;
        private bool? includeAll = false;

        [DataMember]
        public string s2SearchTerm { get; set; }
        [DataMember]
        public int? s2PageSize { get; set; }
        [DataMember]
        public int? s2PageNum { get; set; }
        [DataMember]
        public string s2Param { get; set; }
        [DataMember]
        public string s2Paramkey { get; set; }

        [DataMember]
        public string s2ParamParentkey { get; set; }

        [DataMember]
        public long? AdditionalIdKey { get; set; }
        [DataMember]
        public long? AdditionalIdKey1 { get; set; }

        [DataMember]
        public int? NationalityListType { get => nationalityListType; set => nationalityListType = value; }

        [DataMember]
        public bool? IsInculdeAll { get => includeAll; set => includeAll = value; }

    }

}
