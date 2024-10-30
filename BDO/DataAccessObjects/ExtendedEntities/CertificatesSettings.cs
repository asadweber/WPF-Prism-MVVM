using System;
using System.Runtime.Serialization;

namespace BDO.Core.DataAccessObjects.ExtendedEntities
{
    [Serializable]
    [DataContract(Name = "CertificatesSettings", Namespace = "http://www.KAF.com/types")]


    public class CertificatesSettings
    {
        public string FriendlyName { get; set; }
        public string ThumbPrint { get; set; }
        public string ServiceProviderId { get; set; }
        public string PACIServiceURL { get; set; }
        public string PACIServicePort { get; set; }
        public string KAFWebAPI { get; set; }
    }
}
