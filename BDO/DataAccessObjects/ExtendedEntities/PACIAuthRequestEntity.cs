using BDO.Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Core.DataAccessObjects.ExtendedEntities
{
    [Serializable]
    [DataContract(Name = "PACIAuthRequestEntity", Namespace = "http://www.KAF.com/types")]
    public class PACIAuthRequestEntity : BaseEntity
    {
        [DataMember]
        public string civilid { get; set; }
        [DataMember]
        public string servicename { get; set; }
        [DataMember]
        [StringLength(int.MaxValue)]
        public string ServiceDescriptionEN { get; set; }
        [DataMember]
        [StringLength(int.MaxValue)]
        public string ServiceDescriptionAR { get; set; }


        [DataMember]
        [StringLength(int.MaxValue)]
        public string AuthenticationReasonEn { get; set; }
        [DataMember]
        [StringLength(int.MaxValue)]
        public string AuthenticationReasonAr { get; set; }


        [DataMember]
        public string CallingUrl { get; set; }
        [DataMember]
        public string KeyParam { get; set; }
        [DataMember]
        public string SignalRContextName { get; set; }
        [DataMember]
        public string SignalRMethodName { get; set; }


        [DataMember]
        public string mobilenumber { get; set; }


        [DataMember]
        public bool coreornocore { get; set; }


        [DataMember]
        public string HUBCnnectionId { get; set; }
        [DataMember]
        public string HUBSessionid { get; set; }
    }
}
