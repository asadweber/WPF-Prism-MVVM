using BDO.Core.DataAccessObjects.CommonEntities;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;

namespace BDO.Core.DataAccessObjects.CommonEntities
{
    [Serializable]
    [DataContract(Name = "S2MajorSubjectByCertificateParameter", Namespace = "http://www.KAF.com/types")]
    public class S2MajorSubjectByCertificateParameter : S2Parameters
    {
        private long? _certificateID;

        [DataMember]
        public long? CertificateID { get => _certificateID; set => _certificateID = value; }



    }
}
