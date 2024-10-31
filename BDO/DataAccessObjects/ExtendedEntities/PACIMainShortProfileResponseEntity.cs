using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;

namespace BDO.DataAccessObjects.ExtendedEntities
{
    [Serializable]
    [DataContract(Name = "PACIMainShortProfileResponseDataEntity", Namespace = "http://www.11.com/types")]
    public class PACIMainShortProfileResponseDataEntity
    {
        [DataMember]
        public string arFullName { get; set; }
        [DataMember]
        public string enFullName { get; set; }
        [DataMember]
        public string mobile { get; set; }
        [DataMember]
        public string email { get; set; }
        [DataMember]
        public int statusCode { get; set; }
        [DataMember]
        public string disclaimer { get; set; }
        [DataMember]
        public string remainingHits { get; set; }
        [DataMember]
        public DateTime timeStamp { get; set; }
        [DataMember]
        public string message { get; set; }
        [DataMember]
        public int environment { get; set; }
    }

    [Serializable]
    [DataContract(Name = "PACIMainShortProfileResponseEntity", Namespace = "http://www.11.com/types")]
    public class PACIMainShortProfileResponseEntity
    {
        [DataMember]
        public PACIMainShortProfileResponseDataEntity data { get; set; }
        [DataMember]
        public int recordsTotal { get; set; }
        [DataMember]
        public int recordsFiltered { get; set; }
    }

   
}
