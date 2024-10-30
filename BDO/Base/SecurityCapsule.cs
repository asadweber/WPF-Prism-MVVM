using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Core.Base
{
    [Serializable]
    [DataContract(Name = "SecurityCapsule", Namespace = "http://www.MOI.com/types")]
    public class SecurityCapsule
    {
        protected string _createdbyusername;
        protected string _updatedbyusername;
        protected Guid? _userid;
        protected long? _ts;
        protected long? _masteruserid;

        protected DateTime? _createddate;
        protected DateTime? _updateddate;

        protected string _macaddress;
        protected string _ipaddress;
        protected string _username;
        protected string _controllername;
        protected string _actioname;
        protected DateTime? _actiondate;
        protected string _pageurl;
        protected string _hitfrom;
        protected string _sessionid;
        protected string _email;
        protected string _usertoken;

        protected string _transid;
        protected string _note;
        protected bool? _isauthenticated;


        [DataMember]
        public long? masteruserid
        {
            get { return _masteruserid; }
            set { _masteruserid = value; }
        }
        [DataMember]
        public bool? isauthenticated
        {
            get { return _isauthenticated; }
            set { _isauthenticated = value; }
        }

        [DataMember]
        public string note
        {
            get { return _note; }
            set { _note = value; }
        }

        [DataMember]
        public string transid
        {
            get { return _transid; }
            set { _transid = value; }
        }


        [DataMember]
        public Guid? userid
        {
            get { return _userid; }
            set { _userid = value; }
        }

        [DataMember]
        public long? ts
        {
            get { return _ts; }
            set { _ts = value; }
        }

        [DataMember]
        public DateTime? updateddate
        {
            get { return _updateddate; }
            set { _updateddate = value; }
        }

        [DataMember]
        public DateTime? createddate
        {
            get { return _createddate; }
            set { _createddate = value; }
        }

        [DataMember]
        public string updatedbyusername
        {
            get { return _updatedbyusername; }
            set { _updatedbyusername = value; }
        }

        [DataMember]
        public string createdbyusername
        {
            get { return _createdbyusername; }
            set { _createdbyusername = value; }
        }
        [DataMember]
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        [DataMember]
        public string sessionid
        {
            get { return _sessionid; }
            set { _sessionid = value; }
        }


        [DataMember]
        public string hitfrom
        {
            get { return _hitfrom; }
            set { _hitfrom = value; }
        }
        [DataMember]
        public string pageurl
        {
            get { return _pageurl; }
            set { _pageurl = value; }
        }
        [DataMember]
        public string controllername
        {
            get { return _controllername; }
            set { _controllername = value; }
        }
        [DataMember]
        public string username
        {
            get { return _username; }
            set { _username = value; }
        }
        [DataMember]
        public string macaddress
        {
            get { return _macaddress; }
            set { _macaddress = value; }
        }
        [DataMember]
        public string ipaddress
        {
            get { return _ipaddress; }
            set { _ipaddress = value; }
        }
        [DataMember]
        public string actioname
        {
            get { return _actioname; }
            set { _actioname = value; }
        }

        [DataMember]
        public string usertoken
        {
            get { return _usertoken; }
            set { _usertoken = value; }
        }


        protected DateTime? _tokenValidFromTime;
        protected DateTime? _tokenValidToTime;

        [DataMember]
        public DateTime? tokenValidFromTime
        {
            get { return _tokenValidFromTime; }
            set { _tokenValidFromTime = value; }
        }

        [DataMember]
        public DateTime? tokenValidToTime
        {
            get { return _tokenValidToTime; }
            set { _tokenValidToTime = value; }
        }

    }
}
