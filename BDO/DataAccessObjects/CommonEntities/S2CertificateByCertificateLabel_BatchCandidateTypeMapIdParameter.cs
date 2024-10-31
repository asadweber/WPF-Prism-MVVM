using BDO.Core.DataAccessObjects.CommonEntities;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;

namespace BDO.Core.DataAccessObjects.CommonEntities
{
    [Serializable]
    [DataContract(Name = "S2CertificateByCertificateLabel_BatchCandidateTypeMapIdParameter", Namespace = "http://www.KAF.com/types")]
    public class S2CertificateByCertificateLabel_BatchCandidateTypeMapIdParameter : S2Parameters
    {
        private long? _certificateLevelID;
        private long? _batchCandidateTypeMapID;

        [DataMember]
        public long? CertificateLevelID { get => _certificateLevelID; set => _certificateLevelID = value; }

        [DataMember]
        public long? BatchCandidateTypeMapID { get => _batchCandidateTypeMapID; set => _batchCandidateTypeMapID = value; }


    }
}
