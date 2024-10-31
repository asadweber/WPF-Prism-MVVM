using BDO.Core.Base;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Core.DataAccessObjects.CommonEntities
{
    [Serializable]
    [DataContract(Name = "S2BatchFilterParameters", Namespace = "http://www.KAF.com/types")]
    public class S2BatchFilterParameters : S2Parameters
    {
        private long? currentApplybatch;
        private long? _ProfileBasicId;

        [DataMember]
        public long? CurrentApplybatch { get => currentApplybatch; set => currentApplybatch = value; }

        [DataMember]
        public long? ProfileBasicId { get => _ProfileBasicId; set => _ProfileBasicId = value; }
    }

}
