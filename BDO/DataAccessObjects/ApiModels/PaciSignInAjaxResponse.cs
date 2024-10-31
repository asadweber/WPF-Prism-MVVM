using BDO.Core.Base;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;

namespace BDO.DataAccessObjects.ApiModels
{
    [Serializable]
    [DataContract(Name = "SignInAjaxResponse", Namespace = "http://www.KAF.com/types")]
    public partial class SignInAjaxResponse
    {
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SignInResponseExtende data { get; set; }
    }
    [Serializable]
    [DataContract(Name = "SignInResponseExtende", Namespace = "http://www.KAF.com/types")]
    public class SignInResponseExtende : BaseEntity
    {
        public SignInResponseExtende() : base()
        {
        }
        private long civilId;
        private string result;
        private long paciSigninRequestInfoSerial;

        [Newtonsoft.Json.JsonProperty("civilID", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [DataMember]
        public long CivilId { get => civilId; set => civilId = value; }

        [Newtonsoft.Json.JsonProperty("result", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [DataMember]
        public string Result { get => result; set => result = value; }
        [Newtonsoft.Json.JsonProperty("tran_pacisigninrequestinfoSerial", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [DataMember]
        public long PaciSigninRequestInfoSerial { get => paciSigninRequestInfoSerial; set => paciSigninRequestInfoSerial = value; }
        [DataMember]
        public string KeyParam { get; set; }
    }
}


