using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "cnf_notificationconfigdetlEntity", Namespace = "http://www.KAF.com/types")]
    public partial class cnf_notificationconfigdetlEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _notificationconfigdetlid;
        protected long ? _notificationconfigid;
        protected long ? _notificationtypeid;
        protected long ? _notificationtemplateid;
        protected string _remarks;
        
        [DataMember]
        public long ? notificationconfigdetlid
        {
            get { return _notificationconfigdetlid; }
            set { _notificationconfigdetlid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "notificationconfigid", ResourceType = typeof(CLL.LLClasses.Models._cnf_notificationconfigdetl))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._cnf_notificationconfigdetl), ErrorMessageResourceName = "notificationconfigidRequired")]
        public long ? notificationconfigid
        {
            get { return _notificationconfigid; }
            set { _notificationconfigid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "notificationtypeid", ResourceType = typeof(CLL.LLClasses.Models._cnf_notificationconfigdetl))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._cnf_notificationconfigdetl), ErrorMessageResourceName = "notificationtypeidRequired")]
        public long ? notificationtypeid
        {
            get { return _notificationtypeid; }
            set { _notificationtypeid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "notificationtemplateid", ResourceType = typeof(CLL.LLClasses.Models._cnf_notificationconfigdetl))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._cnf_notificationconfigdetl), ErrorMessageResourceName = "notificationtemplateidRequired")]
        public long ? notificationtemplateid
        {
            get { return _notificationtemplateid; }
            set { _notificationtemplateid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._cnf_notificationconfigdetl))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        #endregion
    
        #region Constructor
    
        public cnf_notificationconfigdetlEntity():base()
        {
        }
        
        public cnf_notificationconfigdetlEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public cnf_notificationconfigdetlEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }

        public cnf_notificationconfigdetlEntity(IDataReader reader, int e)
        {
            this.LoadFromReader(reader, e);
        }

        public cnf_notificationconfigdetlEntity(IDataReader reader, string ext)
        {
            this.LoadFromReader(reader, ext);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationConfigDetlID"))) _notificationconfigdetlid = reader.GetInt64(reader.GetOrdinal("NotificationConfigDetlID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationConfigID"))) _notificationconfigid = reader.GetInt64(reader.GetOrdinal("NotificationConfigID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationTypeID"))) _notificationtypeid = reader.GetInt64(reader.GetOrdinal("NotificationTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationTemplateID"))) _notificationtemplateid = reader.GetInt64(reader.GetOrdinal("NotificationTemplateID"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationConfigDetlID"))) _notificationconfigdetlid = reader.GetInt64(reader.GetOrdinal("NotificationConfigDetlID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationConfigID"))) _notificationconfigid = reader.GetInt64(reader.GetOrdinal("NotificationConfigID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationTypeID"))) _notificationtypeid = reader.GetInt64(reader.GetOrdinal("NotificationTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationTemplateID"))) _notificationtemplateid = reader.GetInt64(reader.GetOrdinal("NotificationTemplateID"));
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