using BDO.Core.DataAccessObjects.CommonEntities;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.DataAccessObjects.ExtendedEntities;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Core.DataAccessObjects.SecurityModels
{

    public partial class owin_userEntity
    {
        protected DateTime? _fromdate;
        protected DateTime? _todate;
        private bool _sendBySMS = false;
        private bool _sendByDigitalId;
        private bool _sendByEmail;
        private string _aUPIOuser;

        [DataMember]
        [Display(Name = "fromdate", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        public DateTime? fromdate
        {
            get => _fromdate; set => _fromdate = value;
        }

        [DataMember]
        [Display(Name = "todate", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        public DateTime? todate
        {
            get => _todate; set => _todate = value;
        }


        [DataMember]
        public bool SendBySMS { get => _sendBySMS; set => _sendBySMS = value; }

        [DataMember]
        public bool SendByDigitalId { get => _sendByDigitalId; set => _sendByDigitalId = value; }

        [DataMember]
        public bool SendByEmail { get => _sendByEmail; set => _sendByEmail = value; }

        [DataMember]
        [Display(Name = "OTP", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_role))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_role), ErrorMessageResourceName = "OTPRequired")]
        public string OTP { get => _aUPIOuser; set => _aUPIOuser = value; }

        public IOptions<ApplicationGlobalSettings> _applicationGlobalSettings { get; set; }
    }

    public class dtOwinUser : DtParameters
    {
        protected string _username;
        protected long? _roleid;
        protected string _emailaddress;
        protected string _loweredusername;
        protected string _mobilenumber;
        protected bool? _approved;
        protected bool? _locked;
        protected bool? _isreviewed;
        protected DateTime? _fromdate;
        protected DateTime? _todate;

        public string username
        {
            get { return _username; }
            set { _username = value; this.OnChnaged(); }
        }
        public long? roleid
        {
            get { return _roleid; }
            set { _roleid = value; this.OnChnaged(); }
        }
        public string emailaddress
        {
            get { return _emailaddress; }
            set { _emailaddress = value; this.OnChnaged(); }
        }
        public string loweredusername
        {
            get { return _loweredusername; }
            set { _loweredusername = value; this.OnChnaged(); }
        }
        public string mobilenumber
        {
            get { return _mobilenumber; }
            set { _mobilenumber = value; this.OnChnaged(); }
        }
        public bool? approved
        {
            get { return _approved; }
            set { _approved = value; this.OnChnaged(); }
        }
        public bool? locked
        {
            get { return _locked; }
            set { _locked = value; this.OnChnaged(); }
        }
        public bool? isreviewed
        {
            get { return _isreviewed; }
            set { _isreviewed = value; this.OnChnaged(); }
        }
        public DateTime? fromdate
        {
            get => _fromdate; set => _fromdate = value;
        }
        public DateTime? todate
        {
            get => _todate; set => _todate = value;
        }
    }
}
