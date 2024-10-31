using BDO.Core.DataAccessObjects.CommonEntities;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;

namespace BDO.Core.DataAccessObjects.CommonEntities
{
    [Serializable]
    [DataContract(Name = "S2CertificateLevelWiseCertificateParameter", Namespace = "http://www.KAF.com/types")]
    public class S2CertificateLevelWiseCertificateParameter: S2Parameters
    {
        [DataMember]
        public long CertificateLevelID { get; set; }

    }
}
