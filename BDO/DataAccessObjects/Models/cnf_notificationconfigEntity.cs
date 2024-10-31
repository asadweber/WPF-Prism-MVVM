using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "cnf_notificationconfigEntity", Namespace = "http://www.KAF.com/types")]
    public partial class cnf_notificationconfigEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _notificationconfigid;
        protected long ? _phaseid;
        protected long ? _statusid;
        protected string _remarks;
        
        [DataMember]
        public long ? notificationconfigid
        {
            get { return _notificationconfigid; }
            set { _notificationconfigid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "phaseid", ResourceType = typeof(CLL.LLClasses.Models._cnf_notificationconfig))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._cnf_notificationconfig), ErrorMessageResourceName = "phaseidRequired")]
        public long ? phaseid
        {
            get { return _phaseid; }
            set { _phaseid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "statusid", ResourceType = typeof(CLL.LLClasses.Models._cnf_notificationconfig))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._cnf_notificationconfig), ErrorMessageResourceName = "statusidRequired")]
        public long ? statusid
        {
            get { return _statusid; }
            set { _statusid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._cnf_notificationconfig))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        #endregion
    
        #region Constructor
    
        public cnf_notificationconfigEntity():base()
        {
        }
        
        public cnf_notificationconfigEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public cnf_notificationconfigEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }

        public cnf_notificationconfigEntity(IDataReader reader, int e)
        {
            this.LoadFromReader(reader, e);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationConfigID"))) _notificationconfigid = reader.GetInt64(reader.GetOrdinal("NotificationConfigID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PhaseID"))) _phaseid = reader.GetInt64(reader.GetOrdinal("PhaseID"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusID"))) _statusid = reader.GetInt64(reader.GetOrdinal("StatusID"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationConfigID"))) _notificationconfigid = reader.GetInt64(reader.GetOrdinal("NotificationConfigID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PhaseID"))) _phaseid = reader.GetInt64(reader.GetOrdinal("PhaseID"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusID"))) _statusid = reader.GetInt64(reader.GetOrdinal("StatusID"));
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