﻿using BDO.Core.DataAccessObjects.CommonEntities;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;

namespace BDO.Core.DataAccessObjects.CommonEntities
{
    [Serializable]
    [DataContract(Name = "S2BatchCandidateTypeCertificateDataParameter", Namespace = "http://www.KAF.com/types")]
    public class S2BatchCandidateTypeCertificateDataParameter : S2Parameters
    {
        [DataMember]
        public long? BatchId { get; set; }

        [DataMember]
        public long? CandidateTypeId { get; set; }

        [DataMember]
        public long? BatchCandidateTypeMapID { get; set; }

        [DataMember]
        public string BatchIdString { get; set; }
    }
}
