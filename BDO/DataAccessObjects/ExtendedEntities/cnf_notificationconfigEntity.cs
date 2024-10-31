using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class cnf_notificationconfigEntity : BaseEntity
    {
        #region Properties
    
        protected string ? _phasename;
        protected string ? _statusname;
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "phaseid", ResourceType = typeof(CLL.LLClasses.Models._cnf_notificationconfig))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._cnf_notificationconfig), ErrorMessageResourceName = "phaseidRequired")]
        public string phasename
        {
            get { return _phasename; }
            set { _phasename = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "statusid", ResourceType = typeof(CLL.LLClasses.Models._cnf_notificationconfig))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._cnf_notificationconfig), ErrorMessageResourceName = "statusidRequired")]
        public string statusname
        {
            get { return _statusname; }
            set { _statusname = value; this.OnChnaged(); }
        }

        #endregion

        #region Constructor
        
        protected void LoadFromReader(IDataReader reader, int e)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationConfigID"))) _notificationconfigid = reader.GetInt64(reader.GetOrdinal("NotificationConfigID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PhaseID"))) _phaseid = reader.GetInt64(reader.GetOrdinal("PhaseID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PhaseName"))) _phasename = reader.GetString(reader.GetOrdinal("PhaseName"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusID"))) _statusid = reader.GetInt64(reader.GetOrdinal("StatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusName"))) _statusname = reader.GetString(reader.GetOrdinal("StatusName"));
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