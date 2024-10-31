using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "cnf_filerequiredEntity", Namespace = "http://www.KAF.com/types")]
    public partial class cnf_filerequiredEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _fileconfigid;
        protected long? _batchid;
        protected long? _fileconfignameid;
        protected bool _isrequired;
        protected bool ? _isprintrequired;
        protected string _remarks;
                
        
        [DataMember]
        public long ? fileconfigid
        {
            get { return _fileconfigid; }
            set { _fileconfigid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "batchid", ResourceType = typeof(CLL.LLClasses.Models._cnf_filerequired))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._cnf_filerequired), ErrorMessageResourceName = "batchidRequired")]
        public long? batchid
        {
            get { return _batchid; }
            set { _batchid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "fileconfigname", ResourceType = typeof(CLL.LLClasses.Models._cnf_filerequired))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._cnf_filerequired), ErrorMessageResourceName = "fileconfignameRequired")]
        public long? fileconfignameid
        {
            get { return _fileconfignameid; }
            set { _fileconfignameid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "isrequired", ResourceType = typeof(CLL.LLClasses.Models._cnf_filerequired))]
        public bool isrequired
        {
            get { return _isrequired; }
            set { _isrequired = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isprintrequired", ResourceType = typeof(CLL.LLClasses.Models._cnf_filerequired))]
        public bool ? isprintrequired
        {
            get { return _isprintrequired; }
            set { _isprintrequired = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._cnf_filerequired))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        #endregion
    
        #region Constructor
    
        public cnf_filerequiredEntity():base()
        {
        }
        
        public cnf_filerequiredEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public cnf_filerequiredEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }

        public cnf_filerequiredEntity(IDataReader reader, int e)
        {
            this.LoadFromReader(reader, e);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("FileConfigID"))) _fileconfigid = reader.GetInt64(reader.GetOrdinal("FileConfigID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchID"))) _batchid = reader.GetInt64(reader.GetOrdinal("BatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileConfigNameID"))) _fileconfignameid = reader.GetInt64(reader.GetOrdinal("FileConfigNameID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsRequired"))) _isrequired = reader.GetBoolean(reader.GetOrdinal("IsRequired"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsPrintRequired"))) _isprintrequired = reader.GetBoolean(reader.GetOrdinal("IsPrintRequired"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("FileConfigID"))) _fileconfigid = reader.GetInt64(reader.GetOrdinal("FileConfigID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchID"))) _batchid = reader.GetInt64(reader.GetOrdinal("BatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileConfigNameID"))) _fileconfignameid = reader.GetInt64(reader.GetOrdinal("FileConfigNameID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsRequired"))) _isrequired = reader.GetBoolean(reader.GetOrdinal("IsRequired"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsPrintRequired"))) _isprintrequired = reader.GetBoolean(reader.GetOrdinal("IsPrintRequired"));
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