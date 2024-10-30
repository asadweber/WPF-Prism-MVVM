using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.SecurityModels
{
    [Serializable]
    [DataContract(Name = "owin_userstatuschangehistoryEntity", Namespace = "http://www.KAF.com/types")]
    public partial class owin_userstatuschangehistoryEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _serial;
        protected Guid ? _userid;
        protected long ? _masteruserid;
        protected bool ? _statuschanged;
        protected string _statusremark;
        protected string _comment;
        protected string _extrafld;
                
        
        [DataMember]
        public long ? serial
        {
            get { return _serial; }
            set { _serial = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "userid", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_userstatuschangehistory))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_userstatuschangehistory), ErrorMessageResourceName = "useridRequired")]
        public Guid ? userid
        {
            get { return _userid; }
            set { _userid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "masteruserid", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_userstatuschangehistory))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_userstatuschangehistory), ErrorMessageResourceName = "masteruseridRequired")]
        public long ? masteruserid
        {
            get { return _masteruserid; }
            set { _masteruserid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "statuschanged", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_userstatuschangehistory))]
        public bool ? statuschanged
        {
            get { return _statuschanged; }
            set { _statuschanged = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "statusremark", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_userstatuschangehistory))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_userstatuschangehistory), ErrorMessageResourceName = "statusremarkRequired")]
        public string statusremark
        {
            get { return _statusremark; }
            set { _statusremark = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(450)]
        [Display(Name = "comment", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_userstatuschangehistory))]
        public string comment
        {
            get { return _comment; }
            set { _comment = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(500)]
        [Display(Name = "extrafld", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_userstatuschangehistory))]
        public string extrafld
        {
            get { return _extrafld; }
            set { _extrafld = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public owin_userstatuschangehistoryEntity():base()
        {
        }
        
        public owin_userstatuschangehistoryEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public owin_userstatuschangehistoryEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("Serial"))) _serial = reader.GetInt64(reader.GetOrdinal("Serial"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserID"))) _userid = reader.GetGuid(reader.GetOrdinal("UserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasterUserID"))) _masteruserid = reader.GetInt64(reader.GetOrdinal("MasterUserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusChanged"))) _statuschanged = reader.GetBoolean(reader.GetOrdinal("StatusChanged"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusRemark"))) _statusremark = reader.GetString(reader.GetOrdinal("StatusRemark"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
                if (!reader.IsDBNull(reader.GetOrdinal("ExtraFLD"))) _extrafld = reader.GetString(reader.GetOrdinal("ExtraFLD"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("UserID"))) _userid = reader.GetGuid(reader.GetOrdinal("UserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasterUserID"))) _masteruserid = reader.GetInt64(reader.GetOrdinal("MasterUserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusChanged"))) _statuschanged = reader.GetBoolean(reader.GetOrdinal("StatusChanged"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusRemark"))) _statusremark = reader.GetString(reader.GetOrdinal("StatusRemark"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
                if (!reader.IsDBNull(reader.GetOrdinal("ExtraFLD"))) _extrafld = reader.GetString(reader.GetOrdinal("ExtraFLD"));
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
