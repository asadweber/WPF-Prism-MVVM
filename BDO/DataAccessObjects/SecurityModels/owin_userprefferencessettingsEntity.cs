using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.SecurityModels
{
    [Serializable]
    [DataContract(Name = "owin_userprefferencessettingsEntity", Namespace = "http://www.KAF.com/types")]
    public partial class owin_userprefferencessettingsEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _serialno;
        protected Guid ? _userid;
        protected long ? _masteruserid;
        protected long ? _appformid;
        protected int ? _prepagesize;
                
        
        [DataMember]
        public long ? serialno
        {
            get { return _serialno; }
            set { _serialno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "userid", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_userprefferencessettings))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_userprefferencessettings), ErrorMessageResourceName = "useridRequired")]
        public Guid ? userid
        {
            get { return _userid; }
            set { _userid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "masteruserid", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_userprefferencessettings))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_userprefferencessettings), ErrorMessageResourceName = "masteruseridRequired")]
        public long ? masteruserid
        {
            get { return _masteruserid; }
            set { _masteruserid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "appformid", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_userprefferencessettings))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_userprefferencessettings), ErrorMessageResourceName = "appformidRequired")]
        public long ? appformid
        {
            get { return _appformid; }
            set { _appformid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "prepagesize", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_userprefferencessettings))]
        public int ? prepagesize
        {
            get { return _prepagesize; }
            set { _prepagesize = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public owin_userprefferencessettingsEntity():base()
        {
        }
        
        public owin_userprefferencessettingsEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public owin_userprefferencessettingsEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("SerialNo"))) _serialno = reader.GetInt64(reader.GetOrdinal("SerialNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserID"))) _userid = reader.GetGuid(reader.GetOrdinal("UserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasterUserID"))) _masteruserid = reader.GetInt64(reader.GetOrdinal("MasterUserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("AppFormID"))) _appformid = reader.GetInt64(reader.GetOrdinal("AppFormID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PrePageSize"))) _prepagesize = reader.GetInt32(reader.GetOrdinal("PrePageSize"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("SerialNo"))) _serialno = reader.GetInt64(reader.GetOrdinal("SerialNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserID"))) _userid = reader.GetGuid(reader.GetOrdinal("UserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasterUserID"))) _masteruserid = reader.GetInt64(reader.GetOrdinal("MasterUserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("AppFormID"))) _appformid = reader.GetInt64(reader.GetOrdinal("AppFormID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PrePageSize"))) _prepagesize = reader.GetInt32(reader.GetOrdinal("PrePageSize"));
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
