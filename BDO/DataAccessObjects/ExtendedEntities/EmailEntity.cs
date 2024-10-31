using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.DataAccessObjects.ExtendedEntities
{
    [Serializable]
    [DataContract(Name = "EmailEntity", Namespace = "http://www.KAF.com/types")]

    public class EmailEntity
    {
        public string toEmail { get; set; }
        public string phone { get; set; }

        public string ccEmail { get; set; }

        public string message { get; set; }

        public string subject { get; set; }


        public string messageen { get; set; }

        public string subjecten { get; set; }


        public List<EmailAttachmentsEntity> attachments { get; set; }
        public string civilid { get; set; }

        public string fullname { get; set; }
        public string messagesimple { get; set; }
    }

    [Serializable]
    [DataContract(Name = "EmailAttachmentsEntity", Namespace = "http://www.KAF.com/types")]
    public class EmailAttachmentsEntity
    {
        public string filesBase64 { get; set; }
        public string filename { get; set; }
        public string filepath { get; set; }


    }

}
