using BDO.Core.DataAccessObjects.CommonEntities;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;

namespace BDO.Core.DataAccessObjects.CommonEntities
{
    [Serializable]
    [DataContract(Name = "S2MilitaryTypeWiseBatchParameter", Namespace = "http://www.KAF.com/types")]
    public class S2MilitaryTypeWiseBatchParameter : S2Parameters
    {
        private long? _batchid;
        private long? _candidatetypeid;

        [DataMember]
        public long? batchid { get => _batchid; set => _batchid = value; }
        
        [DataMember]
        public long? candidatetypeid { get => _candidatetypeid; set => _candidatetypeid = value; }

    }
}
