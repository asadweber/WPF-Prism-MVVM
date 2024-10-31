using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class cnf_notificationconfigdetlEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _phaseid;
        protected string ? _phasename;
        protected long ? _statusid;
        protected string ? _statusname;
        protected string? _templateshortname;

        [DataMember]
        [Display(Name = "phaseid", ResourceType = typeof(CLL.LLClasses.Models._cnf_notificationconfigdetl))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._cnf_notificationconfigdetl), ErrorMessageResourceName = "phaseidRequired")]
        public long? phaseid
        {
            get { return _phaseid; }
            set { _phaseid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "phaseid", ResourceType = typeof(CLL.LLClasses.Models._cnf_notificationconfigdetl))]
        public string? phasename
        {
            get { return _phasename; }
            set { _phasename = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "statusid", ResourceType = typeof(CLL.LLClasses.Models._cnf_notificationconfigdetl))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._cnf_notificationconfigdetl), ErrorMessageResourceName = "statusidRequired")]
        public long? statusid
        {
            get { return _statusid; }
            set { _statusid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "phaseid", ResourceType = typeof(CLL.LLClasses.Models._cnf_notificationconfigdetl))]
        public string? statusname
        {
            get { return _statusname; }
            set { _statusname = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "templateshortname", ResourceType = typeof(CLL.LLClasses.Models._cnf_notificationconfigdetl))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._cnf_notificationconfigdetl), ErrorMessageResourceName = "notificationtemplateidRequired")]
        public string? templateshortname
        {
            get { return _templateshortname; }
            set { _templateshortname = value; this.OnChnaged(); }
        }

        #endregion

        #region Constructor

        protected void LoadFromReader(IDataReader reader, int e)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationConfigDetlID"))) _notificationconfigdetlid = reader.GetInt64(reader.GetOrdinal("NotificationConfigDetlID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationConfigID"))) _notificationconfigid = reader.GetInt64(reader.GetOrdinal("NotificationConfigID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PhaseID"))) _phaseid = reader.GetInt64(reader.GetOrdinal("PhaseID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PhaseName"))) _phasename = reader.GetString(reader.GetOrdinal("PhaseName"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusID"))) _statusid = reader.GetInt64(reader.GetOrdinal("StatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusName"))) _statusname = reader.GetString(reader.GetOrdinal("StatusName"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationTypeID"))) _notificationtypeid = reader.GetInt64(reader.GetOrdinal("NotificationTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationTemplateID"))) _notificationtemplateid = reader.GetInt64(reader.GetOrdinal("NotificationTemplateID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TemplateShortName"))) _templateshortname = reader.GetString(reader.GetOrdinal("TemplateShortName"));
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

        protected void LoadFromReader(IDataReader reader, string ext)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationConfigDetlID"))) _notificationconfigdetlid = reader.GetInt64(reader.GetOrdinal("NotificationConfigDetlID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationConfigID"))) _notificationconfigid = reader.GetInt64(reader.GetOrdinal("NotificationConfigID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PhaseID"))) _phaseid = reader.GetInt64(reader.GetOrdinal("PhaseID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PhaseName"))) _phasename = reader.GetString(reader.GetOrdinal("PhaseName"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusID"))) _statusid = reader.GetInt64(reader.GetOrdinal("StatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusName"))) _statusname = reader.GetString(reader.GetOrdinal("StatusName"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationTypeID"))) _notificationtypeid = reader.GetInt64(reader.GetOrdinal("NotificationTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationTemplateID"))) _notificationtemplateid = reader.GetInt64(reader.GetOrdinal("NotificationTemplateID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TemplateShortName"))) _templateshortname = reader.GetString(reader.GetOrdinal("TemplateShortName"));
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