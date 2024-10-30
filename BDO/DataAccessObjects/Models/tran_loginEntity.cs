using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "tran_loginEntity", Namespace = "http://www.KAF.com/types")]
    public partial class tran_loginEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _serialloginid;
        protected long ? _parentserialloginid;
        protected string _samaccount;
        protected string _samemail;
        protected Guid ? _userid;
        protected DateTime ? _logindate;
        protected string _logintoken;
        protected string _refreshtoken;
        protected DateTime ? _tokenissuedate;
        protected DateTime ? _expires;
        protected string _remarks;
                
        
        [DataMember]
        public long ? serialloginid
        {
            get { return _serialloginid; }
            set { _serialloginid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "parentserialloginid", ResourceType = typeof(CLL.LLClasses.Models._tran_login))]
        public long ? parentserialloginid
        {
            get { return _parentserialloginid; }
            set { _parentserialloginid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(-1)]
        [Display(Name = "samaccount", ResourceType = typeof(CLL.LLClasses.Models._tran_login))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_login), ErrorMessageResourceName = "samaccountRequired")]
        public string samaccount
        {
            get { return _samaccount; }
            set { _samaccount = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(-1)]
        [Display(Name = "samemail", ResourceType = typeof(CLL.LLClasses.Models._tran_login))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_login), ErrorMessageResourceName = "samemailRequired")]
        public string samemail
        {
            get { return _samemail; }
            set { _samemail = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "userid", ResourceType = typeof(CLL.LLClasses.Models._tran_login))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_login), ErrorMessageResourceName = "useridRequired")]
        public Guid ? userid
        {
            get { return _userid; }
            set { _userid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "logindate", ResourceType = typeof(CLL.LLClasses.Models._tran_login))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_login), ErrorMessageResourceName = "logindateRequired")]
        public DateTime ? logindate
        {
            get { return _logindate; }
            set { _logindate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(-1)]
        [Display(Name = "logintoken", ResourceType = typeof(CLL.LLClasses.Models._tran_login))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_login), ErrorMessageResourceName = "logintokenRequired")]
        public string logintoken
        {
            get { return _logintoken; }
            set { _logintoken = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(-1)]
        [Display(Name = "refreshtoken", ResourceType = typeof(CLL.LLClasses.Models._tran_login))]
        public string refreshtoken
        {
            get { return _refreshtoken; }
            set { _refreshtoken = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tokenissuedate", ResourceType = typeof(CLL.LLClasses.Models._tran_login))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_login), ErrorMessageResourceName = "tokenissuedateRequired")]
        public DateTime ? tokenissuedate
        {
            get { return _tokenissuedate; }
            set { _tokenissuedate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "expires", ResourceType = typeof(CLL.LLClasses.Models._tran_login))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_login), ErrorMessageResourceName = "expiresRequired")]
        public DateTime ? expires
        {
            get { return _expires; }
            set { _expires = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(350)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._tran_login))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public tran_loginEntity():base()
        {
        }
        
        public tran_loginEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public tran_loginEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("SerialLoginID"))) _serialloginid = reader.GetInt64(reader.GetOrdinal("SerialLoginID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ParentSerialLoginID"))) _parentserialloginid = reader.GetInt64(reader.GetOrdinal("ParentSerialLoginID"));
                if (!reader.IsDBNull(reader.GetOrdinal("SAMAccount"))) _samaccount = reader.GetString(reader.GetOrdinal("SAMAccount"));
                if (!reader.IsDBNull(reader.GetOrdinal("SAMEmail"))) _samemail = reader.GetString(reader.GetOrdinal("SAMEmail"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserID"))) _userid = reader.GetGuid(reader.GetOrdinal("UserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("LoginDate"))) _logindate = reader.GetDateTime(reader.GetOrdinal("LoginDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("LoginToken"))) _logintoken = reader.GetString(reader.GetOrdinal("LoginToken"));
                if (!reader.IsDBNull(reader.GetOrdinal("RefreshToken"))) _refreshtoken = reader.GetString(reader.GetOrdinal("RefreshToken"));
                if (!reader.IsDBNull(reader.GetOrdinal("TokenIssueDate"))) _tokenissuedate = reader.GetDateTime(reader.GetOrdinal("TokenIssueDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("Expires"))) _expires = reader.GetDateTime(reader.GetOrdinal("Expires"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("SerialLoginID"))) _serialloginid = reader.GetInt64(reader.GetOrdinal("SerialLoginID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ParentSerialLoginID"))) _parentserialloginid = reader.GetInt64(reader.GetOrdinal("ParentSerialLoginID"));
                if (!reader.IsDBNull(reader.GetOrdinal("SAMAccount"))) _samaccount = reader.GetString(reader.GetOrdinal("SAMAccount"));
                if (!reader.IsDBNull(reader.GetOrdinal("SAMEmail"))) _samemail = reader.GetString(reader.GetOrdinal("SAMEmail"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserID"))) _userid = reader.GetGuid(reader.GetOrdinal("UserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("LoginDate"))) _logindate = reader.GetDateTime(reader.GetOrdinal("LoginDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("LoginToken"))) _logintoken = reader.GetString(reader.GetOrdinal("LoginToken"));
                if (!reader.IsDBNull(reader.GetOrdinal("RefreshToken"))) _refreshtoken = reader.GetString(reader.GetOrdinal("RefreshToken"));
                if (!reader.IsDBNull(reader.GetOrdinal("TokenIssueDate"))) _tokenissuedate = reader.GetDateTime(reader.GetOrdinal("TokenIssueDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("Expires"))) _expires = reader.GetDateTime(reader.GetOrdinal("Expires"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
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
        
        #endregion
        
        
            
    }
}
