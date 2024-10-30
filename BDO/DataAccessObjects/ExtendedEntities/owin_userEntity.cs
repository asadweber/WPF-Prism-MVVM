using BDO.Core.DataAccessObjects.CommonEntities;
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
    }

    public class dtOwinUser : DtParameters
    {
        protected string _username;
        protected string _emailaddress;
        protected string _loweredusername;
        protected string _mobilenumber;
        protected bool? _approved;
        protected bool? _locked;
        protected bool? _isreviewed;
        protected DateTime? _fromdate;
        protected DateTime? _todate;
        private long? _roleid;

        public string username
        {
            get { return _username; }
            set { _username = value; this.OnChnaged(); }
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

        public long? roleid { get => _roleid; set => _roleid = value; }
    }
}
