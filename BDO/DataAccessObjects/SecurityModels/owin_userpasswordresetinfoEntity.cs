using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.SecurityModels
{
    [Serializable]
    [DataContract(Name = "owin_userpasswordresetinfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class owin_userpasswordresetinfoEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _serial;
        protected string _sessionid;
        protected Guid ? _userid;
        protected long ? _masteruserid;
        protected string _sessiontoken;
        protected string _username;
        protected bool ? _isactive;
                
        
        [DataMember]
        public long ? serial
        {
            get { return _serial; }
            set { _serial = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "sessionid", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_userpasswordresetinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_userpasswordresetinfo), ErrorMessageResourceName = "sessionidRequired")]
        public string sessionid
        {
            get { return _sessionid; }
            set { _sessionid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "userid", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_userpasswordresetinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_userpasswordresetinfo), ErrorMessageResourceName = "useridRequired")]
        public Guid ? userid
        {
            get { return _userid; }
            set { _userid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "masteruserid", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_userpasswordresetinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_userpasswordresetinfo), ErrorMessageResourceName = "masteruseridRequired")]
        public long ? masteruserid
        {
            get { return _masteruserid; }
            set { _masteruserid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "sessiontoken", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_userpasswordresetinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_userpasswordresetinfo), ErrorMessageResourceName = "sessiontokenRequired")]
        public string sessiontoken
        {
            get { return _sessiontoken; }
            set { _sessiontoken = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "username", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_userpasswordresetinfo))]
        public string username
        {
            get { return _username; }
            set { _username = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_userpasswordresetinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_userpasswordresetinfo), ErrorMessageResourceName = "isactiveRequired")]
        public bool ? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public owin_userpasswordresetinfoEntity():base()
        {
        }
        
        public owin_userpasswordresetinfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public owin_userpasswordresetinfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("Serial"))) _serial = reader.GetInt64(reader.GetOrdinal("Serial"));
                if (!reader.IsDBNull(reader.GetOrdinal("SessionID"))) _sessionid = reader.GetString(reader.GetOrdinal("SessionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserID"))) _userid = reader.GetGuid(reader.GetOrdinal("UserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasterUserID"))) _masteruserid = reader.GetInt64(reader.GetOrdinal("MasterUserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("SessionToken"))) _sessiontoken = reader.GetString(reader.GetOrdinal("SessionToken"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserName"))) _username = reader.GetString(reader.GetOrdinal("UserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("Serial"))) _serial = reader.GetInt64(reader.GetOrdinal("Serial"));
                if (!reader.IsDBNull(reader.GetOrdinal("SessionID"))) _sessionid = reader.GetString(reader.GetOrdinal("SessionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserID"))) _userid = reader.GetGuid(reader.GetOrdinal("UserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasterUserID"))) _masteruserid = reader.GetInt64(reader.GetOrdinal("MasterUserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("SessionToken"))) _sessiontoken = reader.GetString(reader.GetOrdinal("SessionToken"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserName"))) _username = reader.GetString(reader.GetOrdinal("UserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
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
