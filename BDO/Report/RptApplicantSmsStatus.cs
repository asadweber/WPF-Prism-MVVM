using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;

namespace BDO.Report
{
    [Serializable]
    [DataContract(Name = "RptApplicantSmsStatus", Namespace = "http://www.KAF.com/types")]
    public partial class RptApplicantSmsStatus
    {
        public long RegistrationID { get; set; }

        public long BatchNo { get; set; }
        public string CivilId { get; set; }
        public string mobile { get; set; }
        public bool smsSendStatus { get; set; }
        public DateTime? smsSendDate { get; set; }
        public bool emailSendStatus { get; set; }
        public DateTime? emailSentDate { get; set; }

        public bool paciSendStatus { get; set; }
        public DateTime? paciSendDate { get; set; }
             public DateTime? InterviewDate { get; set; }

    }
}
