using System;
using System.Runtime.Serialization;
using System.Data;

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using System.Collections.Generic;
using System.Linq;
using BDO.Core.Base;
using BDO.Core.DataAccessObjects.HRDomainModel;

namespace BDO.Core.DataAccessObjects.SecurityModels
{

    [Serializable]
    [DataContract(Name = "owin_userEntity", Namespace = "http://www.KAF.com/types")]
    public partial class owin_userEntity : BaseEntity
    {

        #region Properties

        protected Guid? _userid;
        protected Guid? _applicationid;
        protected long? _masteruserid;
        protected string _username;
        protected string? _fullname;
        protected string _emailaddress;
        protected string _loweredusername;
        protected string _mobilenumber;
        protected string? _tempmob;
        protected bool? _mobnoverified;
        protected string _userprofilephoto;
        protected bool? _isanonymous;
        protected bool? _ischildenable;
        protected string _masprivatekey;
        protected string _maspublickey;
        protected long? _pkeyex;
        protected string _password;
        protected string _passwordsalt;
        protected string _passwordkey;
        protected string _passwordvector;
        protected string _mobilepin;
        protected string _passwordquestion;
        protected string _passwordanswer;
        protected bool? _approved;
        protected bool? _locked;
        protected DateTime? _lastlogindate;
        protected DateTime? _lastpasschangeddate;
        protected DateTime? _lastlockoutdate;
        protected int? _failedpasswordattemptcount;
        protected string _comment;
        protected DateTime? _lastactivitydate;
        protected bool? _isreviewed;
        protected long? _reviewedby;
        protected string _reviewedbyusername;
        protected DateTime? _revieweddate;
        protected bool? _isapproved;
        protected long? _approvedby;
        protected string _approvedbyusername;
        protected DateTime? _approveddate;
        protected bool? _isemailconfirmed;
        protected DateTime? _emailconfirmationbyuserdate;
        protected bool? _twofactorenable;
        protected bool? _ismobilenumberconfirmed;
        protected DateTime? _mobilenumberconfirmedbyuserdate;



        protected string _profileJson;
        protected string _apitokenJson;
        protected long? _webuseronly;
        protected long? _roleid;


        [DataMember]
        public string profileJson
        {
            get { return _profileJson; }
            set { _profileJson = value; }
        }
        [DataMember]
        public string apitokenJson
        {
            get { return _apitokenJson; }
            set { _apitokenJson = value; }
        }

        protected string _securitystamp;
        protected string _concurrencystamp;
        [DataMember]
        public string securitystamp
        {
            get { return _securitystamp; }
            set { _securitystamp = value; }
        }

        [DataMember]
        public string concurrencystamp
        {
            get { return _concurrencystamp; }
            set { _concurrencystamp = value; }
        }

        [DataMember]
        [Display(Name = "webuseronly", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        public long? webuseronly
        {
            get { return _webuseronly; }
            set { _webuseronly = value; this.OnChnaged(); }
        }


        [DataMember]
        [PersonalDataAttribute]
        [Display(Name = "rolename", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_role))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_role), ErrorMessageResourceName = "rolenameRequired")]
        public long? roleid
        {
            get { return _roleid; }
            set { _roleid = value; this.OnChnaged(); }
        }
        [DataMember]
        [Display(Name = "rolename", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_role))]
        public string rolename
        {
            get;
            set;
        }
        [DataMember] 
        public string ReturnUrl { get; set; }

        [Key]
        [DataMember]
        public Guid? userid
        {
            get { return _userid; }
            set { _userid = value; this.OnChnaged(); }
        }

        [DataMember]
        [PersonalDataAttribute]
        [Display(Name = "applicationid", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user), ErrorMessageResourceName = "applicationidRequired")]
        public Guid? applicationid
        {
            get { return _applicationid; }
            set { _applicationid = value; this.OnChnaged(); }
        }

        [DataMember]
        [PersonalDataAttribute]
        [Display(Name = "masteruserid", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user), ErrorMessageResourceName = "masteruseridRequired")]
        public long? masteruserid
        {
            get { return _masteruserid; }
            set { _masteruserid = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(256)]
        [PersonalDataAttribute]
        [Display(Name = "username", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user), ErrorMessageResourceName = "usernameRequired")]
        public string username
        {
            get { return _username; }
            set { _username = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(500)]
        [PersonalDataAttribute]
        [Display(Name = "fullname", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        public string? fullname
        {
            get { return _fullname; }
            set { _fullname = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [PersonalDataAttribute]
        [Display(Name = "emailaddress", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user), ErrorMessageResourceName = "emailaddressRequired")]
        public string emailaddress
        {
            get { return _emailaddress; }
            set { _emailaddress = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(256)]
        [Display(Name = "loweredusername", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user), ErrorMessageResourceName = "loweredusernameRequired")]
        public string loweredusername
        {
            get { return _loweredusername; }
            set { _loweredusername = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(16)]
        [PersonalDataAttribute]
        [Display(Name = "mobilenumber", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        public string mobilenumber
        {
            get { return _mobilenumber; }
            set { _mobilenumber = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(16)]
        [PersonalDataAttribute]
        public string? tempmob
        {
            get { return _tempmob; }
            set { _tempmob = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "isanonymous", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user), ErrorMessageResourceName = "isanonymousRequired")]
        public bool? isanonymous
        {
            get { return _isanonymous; }
            set { _isanonymous = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "userprofilephoto", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        public string userprofilephoto
        {
            get { return _userprofilephoto; }
            set { _userprofilephoto = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "ischildenable", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        public bool? ischildenable
        {
            get { return _ischildenable; }
            set { _ischildenable = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(1000)]
        [PersonalDataAttribute]
        [Display(Name = "masprivatekey", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user), ErrorMessageResourceName = "masprivatekeyRequired")]
        public string masprivatekey
        {
            get { return _masprivatekey; }
            set { _masprivatekey = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(1000)]
        [PersonalDataAttribute]
        [Display(Name = "maspublickey", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user), ErrorMessageResourceName = "maspublickeyRequired")]
        public string maspublickey
        {
            get { return _maspublickey; }
            set { _maspublickey = value; this.OnChnaged(); }
        }

        [DataMember]
        //[MaxLength(1000)]
        [PersonalDataAttribute]
        [Display(Name = "pkeyex", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user), ErrorMessageResourceName = "pkeyexRequired")]
        public long? pkeyex
        {
            get { return _pkeyex; }
            set { _pkeyex = value; this.OnChnaged(); }
        }


        [DataMember]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 6, ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user), ErrorMessageResourceName = "passwordlengthmissmatch")]
        [Display(Name = "password", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user), ErrorMessageResourceName = "passwordRequired")]
        public string password
        {
            get { return _password; }
            set { _password = value; this.OnChnaged(); }
        }

        protected string _newpassword;
        [DataMember]
        [StringLength(50, MinimumLength = 6, ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user), ErrorMessageResourceName = "newpasswordlengthmissmatch")]
        [DataType(DataType.Password)]
        //[Compare("confirmpassword", ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user), ErrorMessageResourceName = "passwordmissmatch")]
        [Display(Name = "newpassword", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user), ErrorMessageResourceName = "passwordRequired")]
        public string newpassword
        {
            get { return _newpassword; }
            set { _newpassword = value; this.OnChnaged(); }
        }

        protected string _confirmpassword;
        [DataMember]
        [StringLength(50, MinimumLength = 6, ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user), ErrorMessageResourceName = "confirmpasswordlengthmissmatch")]
        [DataType(DataType.Password)]
        [Compare("newpassword", ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user), ErrorMessageResourceName = "passwordmissmatch")]
        [Display(Name = "confirmpassword", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user), ErrorMessageResourceName = "passwordRequired")]
        public string confirmpassword
        {
            get { return _confirmpassword; }
            set { _confirmpassword = value; this.OnChnaged(); }
        }


        [DataMember]
        [MaxLength(500)]
        [DataType(DataType.Password)]
        [Display(Name = "passwordsalt", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user), ErrorMessageResourceName = "passwordRequired")]
        public string passwordsalt
        {
            get { return _passwordsalt; }
            set { _passwordsalt = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(500)]
        [DataType(DataType.Password)]
        [Display(Name = "passwordkey", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user), ErrorMessageResourceName = "passwordkeyRequired")]
        public string passwordkey
        {
            get { return _passwordkey; }
            set { _passwordkey = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(500)]
        [DataType(DataType.Password)]
        [Display(Name = "passwordvector", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user), ErrorMessageResourceName = "passwordvectorRequired")]
        public string passwordvector
        {
            get { return _passwordvector; }
            set { _passwordvector = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(16)]
        [DataType(DataType.Password)]
        [Display(Name = "mobilepin", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        public string mobilepin
        {
            get { return _mobilepin; }
            set { _mobilepin = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(256)]
        [Display(Name = "passwordquestion", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        public string passwordquestion
        {
            get { return _passwordquestion; }
            set { _passwordquestion = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(128)]
        [Display(Name = "passwordanswer", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        public string passwordanswer
        {
            get { return _passwordanswer; }
            set { _passwordanswer = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "approved", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        public bool? approved
        {
            get { return _approved; }
            set { _approved = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "locked", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        public bool? locked
        {
            get { return _locked; }
            set { _locked = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "lastlogindate", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        public DateTime? lastlogindate
        {
            get { return _lastlogindate; }
            set { _lastlogindate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "lastpasschangeddate", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        public DateTime? lastpasschangeddate
        {
            get { return _lastpasschangeddate; }
            set { _lastpasschangeddate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "lastlockoutdate", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        public DateTime? lastlockoutdate
        {
            get { return _lastlockoutdate; }
            set { _lastlockoutdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "failedpasswordattemptcount", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        public int? failedpasswordattemptcount
        {
            get { return _failedpasswordattemptcount; }
            set { _failedpasswordattemptcount = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "comment", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        public string comment
        {
            get { return _comment; }
            set { _comment = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "lastactivitydate", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        public DateTime? lastactivitydate
        {
            get { return _lastactivitydate; }
            set { _lastactivitydate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "isreviewed", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        public bool? isreviewed
        {
            get { return _isreviewed; }
            set { _isreviewed = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "reviewedby", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        public long? reviewedby
        {
            get { return _reviewedby; }
            set { _reviewedby = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "reviewedbyusername", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        public string reviewedbyusername
        {
            get { return _reviewedbyusername; }
            set { _reviewedbyusername = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "revieweddate", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        public DateTime? revieweddate
        {
            get { return _revieweddate; }
            set { _revieweddate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "isapproved", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        public bool? isapproved
        {
            get { return _isapproved; }
            set { _isapproved = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "approvedby", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        public long? approvedby
        {
            get { return _approvedby; }
            set { _approvedby = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "approvedbyusername", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        public string approvedbyusername
        {
            get { return _approvedbyusername; }
            set { _approvedbyusername = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "approveddate", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        public DateTime? approveddate
        {
            get { return _approveddate; }
            set { _approveddate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "isemailconfirmed", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        public bool? isemailconfirmed
        {
            get { return _isemailconfirmed; }
            set { _isemailconfirmed = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "emailconfirmationbyuserdate", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        public DateTime? emailconfirmationbyuserdate
        {
            get { return _emailconfirmationbyuserdate; }
            set { _emailconfirmationbyuserdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "twofactorenable", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        public bool? twofactorenable
        {
            get { return _twofactorenable; }
            set { _twofactorenable = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "ismobilenumberconfirmed", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        public bool? ismobilenumberconfirmed
        {
            get { return _ismobilenumberconfirmed; }
            set { _ismobilenumberconfirmed = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "mobilenumberconfirmedbyuserdate", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        public DateTime? mobilenumberconfirmedbyuserdate
        {
            get { return _mobilenumberconfirmedbyuserdate; }
            set { _mobilenumberconfirmedbyuserdate = value; this.OnChnaged(); }
        }



        protected string _newemailaddress;
        [DataMember]
        [MaxLength(256)]
        [Display(Name = "newemailaddress", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_user), ErrorMessageResourceName = "emailaddressRequired")]
        public string newemailaddress
        {
            get { return _newemailaddress; }
            set { _newemailaddress = value; this.OnChnaged(); }
        }
        #endregion


        #region Constructor

        public owin_userEntity() : base()
        {
        }

        public owin_userEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        public owin_userEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        public owin_userEntity(IDataReader reader, string spname)
        {
            this.LoadFromReader(reader, spname);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicationId"))) _applicationid = reader.GetGuid(reader.GetOrdinal("ApplicationId"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserId"))) _userid = reader.GetGuid(reader.GetOrdinal("UserId"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasterUserID"))) _masteruserid = reader.GetInt64(reader.GetOrdinal("MasterUserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserName"))) _username = reader.GetString(reader.GetOrdinal("UserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("EmailAddress"))) _emailaddress = reader.GetString(reader.GetOrdinal("EmailAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("LoweredUserName"))) _loweredusername = reader.GetString(reader.GetOrdinal("LoweredUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNumber"))) _mobilenumber = reader.GetString(reader.GetOrdinal("MobileNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("TempMob"))) _tempmob = reader.GetString(reader.GetOrdinal("TempMob"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserProfilePhoto"))) _userprofilephoto = reader.GetString(reader.GetOrdinal("UserProfilePhoto"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsAnonymous"))) _isanonymous = reader.GetBoolean(reader.GetOrdinal("IsAnonymous"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsChildEnable"))) _ischildenable = reader.GetBoolean(reader.GetOrdinal("IsChildEnable"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasPrivateKey"))) _masprivatekey = reader.GetString(reader.GetOrdinal("MasPrivateKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasPublicKey"))) _maspublickey = reader.GetString(reader.GetOrdinal("MasPublicKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("PKeyEX"))) _pkeyex = reader.GetInt64(reader.GetOrdinal("PKeyEX"));
                if (!reader.IsDBNull(reader.GetOrdinal("Password"))) _password = reader.GetString(reader.GetOrdinal("Password"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordSalt"))) _passwordsalt = reader.GetString(reader.GetOrdinal("PasswordSalt"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordKey"))) _passwordkey = reader.GetString(reader.GetOrdinal("PasswordKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordVector"))) _passwordvector = reader.GetString(reader.GetOrdinal("PasswordVector"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobilePIN"))) _mobilepin = reader.GetString(reader.GetOrdinal("MobilePIN"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordQuestion"))) _passwordquestion = reader.GetString(reader.GetOrdinal("PasswordQuestion"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordAnswer"))) _passwordanswer = reader.GetString(reader.GetOrdinal("PasswordAnswer"));
                if (!reader.IsDBNull(reader.GetOrdinal("Approved"))) _approved = reader.GetBoolean(reader.GetOrdinal("Approved"));
                if (!reader.IsDBNull(reader.GetOrdinal("Locked"))) _locked = reader.GetBoolean(reader.GetOrdinal("Locked"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastLoginDate"))) _lastlogindate = reader.GetDateTime(reader.GetOrdinal("LastLoginDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastPassChangedDate"))) _lastpasschangeddate = reader.GetDateTime(reader.GetOrdinal("LastPassChangedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastLockoutDate"))) _lastlockoutdate = reader.GetDateTime(reader.GetOrdinal("LastLockoutDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FailedPasswordAttemptCount"))) _failedpasswordattemptcount = reader.GetInt32(reader.GetOrdinal("FailedPasswordAttemptCount"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastActivityDate"))) _lastactivitydate = reader.GetDateTime(reader.GetOrdinal("LastActivityDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsReviewed"))) _isreviewed = reader.GetBoolean(reader.GetOrdinal("IsReviewed"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedBy"))) _reviewedby = reader.GetInt64(reader.GetOrdinal("ReviewedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedByUserName"))) _reviewedbyusername = reader.GetString(reader.GetOrdinal("ReviewedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedDate"))) _revieweddate = reader.GetDateTime(reader.GetOrdinal("ReviewedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsApproved"))) _isapproved = reader.GetBoolean(reader.GetOrdinal("IsApproved"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApprovedBy"))) _approvedby = reader.GetInt64(reader.GetOrdinal("ApprovedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApprovedByUserName"))) _approvedbyusername = reader.GetString(reader.GetOrdinal("ApprovedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApprovedDate"))) _approveddate = reader.GetDateTime(reader.GetOrdinal("ApprovedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsEmailConfirmed"))) _isemailconfirmed = reader.GetBoolean(reader.GetOrdinal("IsEmailConfirmed"));
                if (!reader.IsDBNull(reader.GetOrdinal("EmailConfirmationByUserDate"))) _emailconfirmationbyuserdate = reader.GetDateTime(reader.GetOrdinal("EmailConfirmationByUserDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("TwoFactorEnable"))) _twofactorenable = reader.GetBoolean(reader.GetOrdinal("TwoFactorEnable"));

                if (!reader.IsDBNull(reader.GetOrdinal("IsMobileNumberConfirmed"))) _ismobilenumberconfirmed = reader.GetBoolean(reader.GetOrdinal("IsMobileNumberConfirmed"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNumberConfirmedByUserDate"))) _mobilenumberconfirmedbyuserdate = reader.GetDateTime(reader.GetOrdinal("MobileNumberConfirmedByUserDate"));


                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));

                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));

                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }


        protected void LoadFromReader(IDataReader reader, bool IsListViewShow)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicationId"))) _applicationid = reader.GetGuid(reader.GetOrdinal("ApplicationId"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserId"))) _userid = reader.GetGuid(reader.GetOrdinal("UserId"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasterUserID"))) _masteruserid = reader.GetInt64(reader.GetOrdinal("MasterUserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserName"))) _username = reader.GetString(reader.GetOrdinal("UserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("EmailAddress"))) _emailaddress = reader.GetString(reader.GetOrdinal("EmailAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("LoweredUserName"))) _loweredusername = reader.GetString(reader.GetOrdinal("LoweredUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNumber"))) _mobilenumber = reader.GetString(reader.GetOrdinal("MobileNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserProfilePhoto"))) _userprofilephoto = reader.GetString(reader.GetOrdinal("UserProfilePhoto"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsAnonymous"))) _isanonymous = reader.GetBoolean(reader.GetOrdinal("IsAnonymous"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsChildEnable"))) _ischildenable = reader.GetBoolean(reader.GetOrdinal("IsChildEnable"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasPrivateKey"))) _masprivatekey = reader.GetString(reader.GetOrdinal("MasPrivateKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasPublicKey"))) _maspublickey = reader.GetString(reader.GetOrdinal("MasPublicKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("PKeyEX"))) _pkeyex = reader.GetInt64(reader.GetOrdinal("PKeyEX"));
                if (!reader.IsDBNull(reader.GetOrdinal("Password"))) _password = reader.GetString(reader.GetOrdinal("Password"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordSalt"))) _passwordsalt = reader.GetString(reader.GetOrdinal("PasswordSalt"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordKey"))) _passwordkey = reader.GetString(reader.GetOrdinal("PasswordKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordVector"))) _passwordvector = reader.GetString(reader.GetOrdinal("PasswordVector"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobilePIN"))) _mobilepin = reader.GetString(reader.GetOrdinal("MobilePIN"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordQuestion"))) _passwordquestion = reader.GetString(reader.GetOrdinal("PasswordQuestion"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordAnswer"))) _passwordanswer = reader.GetString(reader.GetOrdinal("PasswordAnswer"));
                if (!reader.IsDBNull(reader.GetOrdinal("Approved"))) _approved = reader.GetBoolean(reader.GetOrdinal("Approved"));
                if (!reader.IsDBNull(reader.GetOrdinal("Locked"))) _locked = reader.GetBoolean(reader.GetOrdinal("Locked"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastLoginDate"))) _lastlogindate = reader.GetDateTime(reader.GetOrdinal("LastLoginDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastPassChangedDate"))) _lastpasschangeddate = reader.GetDateTime(reader.GetOrdinal("LastPassChangedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastLockoutDate"))) _lastlockoutdate = reader.GetDateTime(reader.GetOrdinal("LastLockoutDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FailedPasswordAttemptCount"))) _failedpasswordattemptcount = reader.GetInt32(reader.GetOrdinal("FailedPasswordAttemptCount"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastActivityDate"))) _lastactivitydate = reader.GetDateTime(reader.GetOrdinal("LastActivityDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsReviewed"))) _isreviewed = reader.GetBoolean(reader.GetOrdinal("IsReviewed"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedBy"))) _reviewedby = reader.GetInt64(reader.GetOrdinal("ReviewedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedByUserName"))) _reviewedbyusername = reader.GetString(reader.GetOrdinal("ReviewedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedDate"))) _revieweddate = reader.GetDateTime(reader.GetOrdinal("ReviewedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsApproved"))) _isapproved = reader.GetBoolean(reader.GetOrdinal("IsApproved"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApprovedBy"))) _approvedby = reader.GetInt64(reader.GetOrdinal("ApprovedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApprovedByUserName"))) _approvedbyusername = reader.GetString(reader.GetOrdinal("ApprovedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApprovedDate"))) _approveddate = reader.GetDateTime(reader.GetOrdinal("ApprovedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsEmailConfirmed"))) _isemailconfirmed = reader.GetBoolean(reader.GetOrdinal("IsEmailConfirmed"));
                if (!reader.IsDBNull(reader.GetOrdinal("EmailConfirmationByUserDate"))) _emailconfirmationbyuserdate = reader.GetDateTime(reader.GetOrdinal("EmailConfirmationByUserDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("TwoFactorEnable"))) _twofactorenable = reader.GetBoolean(reader.GetOrdinal("TwoFactorEnable"));

                if (!reader.IsDBNull(reader.GetOrdinal("IsMobileNumberConfirmed"))) _ismobilenumberconfirmed = reader.GetBoolean(reader.GetOrdinal("IsMobileNumberConfirmed"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNumberConfirmedByUserDate"))) _mobilenumberconfirmedbyuserdate = reader.GetDateTime(reader.GetOrdinal("MobileNumberConfirmedByUserDate"));

                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));

                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));

                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));

                CurrentState = EntityState.Unchanged;
            }
        }

        protected void LoadFromReader(IDataReader reader, string spname)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicationId"))) _applicationid = reader.GetGuid(reader.GetOrdinal("ApplicationId"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserId"))) _userid = reader.GetGuid(reader.GetOrdinal("UserId"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasterUserID"))) _masteruserid = reader.GetInt64(reader.GetOrdinal("MasterUserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserName"))) _username = reader.GetString(reader.GetOrdinal("UserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("EmailAddress"))) _emailaddress = reader.GetString(reader.GetOrdinal("EmailAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("LoweredUserName"))) _loweredusername = reader.GetString(reader.GetOrdinal("LoweredUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNumber"))) _mobilenumber = reader.GetString(reader.GetOrdinal("MobileNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserProfilePhoto"))) _userprofilephoto = reader.GetString(reader.GetOrdinal("UserProfilePhoto"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsAnonymous"))) _isanonymous = reader.GetBoolean(reader.GetOrdinal("IsAnonymous"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsChildEnable"))) _ischildenable = reader.GetBoolean(reader.GetOrdinal("IsChildEnable"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasPrivateKey"))) _masprivatekey = reader.GetString(reader.GetOrdinal("MasPrivateKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasPublicKey"))) _maspublickey = reader.GetString(reader.GetOrdinal("MasPublicKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("PKeyEX"))) _pkeyex = reader.GetInt64(reader.GetOrdinal("PKeyEX"));
                if (!reader.IsDBNull(reader.GetOrdinal("Password"))) _password = reader.GetString(reader.GetOrdinal("Password"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordSalt"))) _passwordsalt = reader.GetString(reader.GetOrdinal("PasswordSalt"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordKey"))) _passwordkey = reader.GetString(reader.GetOrdinal("PasswordKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordVector"))) _passwordvector = reader.GetString(reader.GetOrdinal("PasswordVector"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobilePIN"))) _mobilepin = reader.GetString(reader.GetOrdinal("MobilePIN"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordQuestion"))) _passwordquestion = reader.GetString(reader.GetOrdinal("PasswordQuestion"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordAnswer"))) _passwordanswer = reader.GetString(reader.GetOrdinal("PasswordAnswer"));
                if (!reader.IsDBNull(reader.GetOrdinal("Approved"))) _approved = reader.GetBoolean(reader.GetOrdinal("Approved"));
                if (!reader.IsDBNull(reader.GetOrdinal("Locked"))) _locked = reader.GetBoolean(reader.GetOrdinal("Locked"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastLoginDate"))) _lastlogindate = reader.GetDateTime(reader.GetOrdinal("LastLoginDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastPassChangedDate"))) _lastpasschangeddate = reader.GetDateTime(reader.GetOrdinal("LastPassChangedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastLockoutDate"))) _lastlockoutdate = reader.GetDateTime(reader.GetOrdinal("LastLockoutDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FailedPasswordAttemptCount"))) _failedpasswordattemptcount = reader.GetInt32(reader.GetOrdinal("FailedPasswordAttemptCount"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastActivityDate"))) _lastactivitydate = reader.GetDateTime(reader.GetOrdinal("LastActivityDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsReviewed"))) _isreviewed = reader.GetBoolean(reader.GetOrdinal("IsReviewed"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedBy"))) _reviewedby = reader.GetInt64(reader.GetOrdinal("ReviewedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedByUserName"))) _reviewedbyusername = reader.GetString(reader.GetOrdinal("ReviewedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedDate"))) _revieweddate = reader.GetDateTime(reader.GetOrdinal("ReviewedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsApproved"))) _isapproved = reader.GetBoolean(reader.GetOrdinal("IsApproved"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApprovedBy"))) _approvedby = reader.GetInt64(reader.GetOrdinal("ApprovedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApprovedByUserName"))) _approvedbyusername = reader.GetString(reader.GetOrdinal("ApprovedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApprovedDate"))) _approveddate = reader.GetDateTime(reader.GetOrdinal("ApprovedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsEmailConfirmed"))) _isemailconfirmed = reader.GetBoolean(reader.GetOrdinal("IsEmailConfirmed"));
                if (!reader.IsDBNull(reader.GetOrdinal("EmailConfirmationByUserDate"))) _emailconfirmationbyuserdate = reader.GetDateTime(reader.GetOrdinal("EmailConfirmationByUserDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("TwoFactorEnable"))) _twofactorenable = reader.GetBoolean(reader.GetOrdinal("TwoFactorEnable"));

                if (!reader.IsDBNull(reader.GetOrdinal("IsMobileNumberConfirmed"))) _ismobilenumberconfirmed = reader.GetBoolean(reader.GetOrdinal("IsMobileNumberConfirmed"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNumberConfirmedByUserDate"))) _mobilenumberconfirmedbyuserdate = reader.GetDateTime(reader.GetOrdinal("MobileNumberConfirmedByUserDate"));


                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));

                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));

                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));

                if (!reader.IsDBNull(reader.GetOrdinal("RoleID"))) roleid = reader.GetInt64(reader.GetOrdinal("RoleID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RoleName"))) rolename = reader.GetString(reader.GetOrdinal("RoleName"));
                CurrentState = EntityState.Unchanged;
            }
        }

        #endregion

        protected List<owin_userclaimsEntity> _Claims;
        [DataMember]
        public List<owin_userclaimsEntity> Claims
        {
            get { return _Claims; }
            set { _Claims = value; }
        }

        public bool AllowRememberLogin { get; set; } = true;
        public bool EnableLocalLogin { get; set; } = true;

        public IEnumerable<ExternalProvider> ExternalProviders { get; set; } = Enumerable.Empty<ExternalProvider>();
        public IEnumerable<ExternalProvider> VisibleExternalProviders => ExternalProviders.Where(x => !String.IsNullOrWhiteSpace(x.DisplayName));
        public bool IsExternalLoginOnly => EnableLocalLogin == false && ExternalProviders?.Count() == 1;
        public string ExternalLoginScheme => IsExternalLoginOnly ? ExternalProviders?.SingleOrDefault()?.AuthenticationScheme : null;
        public bool IsAdmin { get; set; }
        public string DataEventRecordsRole { get; set; }
        public string SecuredFilesRole { get; set; }
        public string LogoutId { get; set; }
        public bool ShowLogoutPrompt { get; set; }
        public bool AutomaticRedirectAfterSignOut { get; set; }
        public string PostLogoutRedirectUri { get; set; }
        public string ClientName { get; set; }
        public string SignOutIframeUrl { get; set; }

        public string IdentityId { get; private set; }
        public virtual DateTimeOffset? LockoutEnd { get; set; }
        [PersonalData]
        public virtual bool TwoFactorEnabled { get; set; }
        [PersonalData]
        public virtual bool PhoneNumberConfirmed { get; set; }
        public virtual string SecurityStamp { get; set; }
        public virtual string PasswordHash { get; set; }

        public string _couserSignalRConnectionID { get; set; }


        #region SignalR context

        [DataMember]
        public string connectionID { get; set; }
        [DataMember]
        public int expiresIn { get; set; }
        [DataMember]
        public DateTime loggedInDateTime { get; set; }

        [DataMember]
        public double acc { get; set; }

        [DataMember]
        public GetMilShortInfoByBasicMilEntity? _GetMilShortInfoByBasicMilEntity { get; set; }
        #endregion



        public owin_userEntity(string firstName, string lastName, string identityId, string userName)
        {
            firstName = firstName;
            lastName = lastName;
            IdentityId = identityId;
            userName = userName;
        }

        public List<RefreshToken> _refreshTokens = new List<RefreshToken>();
        public IReadOnlyCollection<RefreshToken> RefreshTokens => _refreshTokens.AsReadOnly();
        public bool HasValidRefreshToken(string refreshToken)
        {
            return _refreshTokens.Any(rt => rt.Token == refreshToken && rt.Active);
        }

        public void AddRefreshToken(string token, Guid userId, string remoteIpAddress, double daysToExpire = 5)
        {
            _refreshTokens.Add(new RefreshToken(token, DateTime.UtcNow.AddDays(daysToExpire), userId, remoteIpAddress));
        }

        public void RemoveRefreshToken(string refreshToken)
        {
            _refreshTokens.Remove(_refreshTokens.First(t => t.Token == refreshToken));
        }

    }
}
