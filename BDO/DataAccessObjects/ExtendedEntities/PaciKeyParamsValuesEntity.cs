using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.DataAccessObjects.ExtendedEntities
{
    [Serializable]
    [DataContract(Name = "PaciKeyParamsValuesEntity", Namespace = "http://www.KAF.com/types")]

    public class PaciKeyParamsValuesEntity
    {
        [DataMember]
        public string ResponseCode { get; set; }
        [DataMember]
        public string CivilID { get; set; }
        [DataMember]
        public string WebSessionID { get; set; }
        [DataMember]
        public string SignalRConnectionID { get; set; }
        [DataMember]
        public long SignInRequestID { get; set; }
        [DataMember]
        public bool IsQRAuth { get; set; }
    }
}
