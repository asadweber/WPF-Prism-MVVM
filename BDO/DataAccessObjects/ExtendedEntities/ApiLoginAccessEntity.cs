using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;

namespace BDO.Core.DataAccessObjects.ExtendedEntities
{
    [Serializable]
    [DataContract(Name = "ApiLoginAccessEntity", Namespace = "http://www.KAF.com/types")]

    public sealed class ApiLoginAccessEntity
    {
        [DataMember]
        public string refreshToken { get; set; }
        [DataMember]
        public string accessToken { get; set; }
        [DataMember]
        public int expiresIn { get; set; }
        [DataMember]
        public bool success { get; set; }
    }
}
