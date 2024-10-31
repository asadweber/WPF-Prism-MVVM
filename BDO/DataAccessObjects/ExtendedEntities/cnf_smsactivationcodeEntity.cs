using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class cnf_smsactivationcodeEntity
	{
		private string _UserName;

        [DataMember]
		[Display(Name = "UserName", ResourceType = typeof(CLL.LLClasses.Models._cnf_smsactivationcode))]
		[Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._cnf_smsactivationcode), ErrorMessageResourceName = "UserNameRequired")]
		public string UserName { get => _UserName; set => _UserName = value; }
        private bool _sendBySMS = false;
        private bool _sendByDigitalId;
        private bool _sendByEmail;
        [DataMember]
        public bool SendBySMS { get => _sendBySMS; set => _sendBySMS = value; }

        [DataMember]
        public bool SendByDigitalId { get => _sendByDigitalId; set => _sendByDigitalId = value; }

        [DataMember]
        public bool SendByEmail { get => _sendByEmail; set => _sendByEmail = value; }

    }
}
