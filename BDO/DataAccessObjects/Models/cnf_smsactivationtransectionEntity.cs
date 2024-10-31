using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "cnf_smsactivationtransectionEntity", Namespace = "http://www.KAF.com/types")]
    public partial class cnf_smsactivationtransectionEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _smstransectioncodeid;
        protected long ? _smscodeid;
        protected long ? _providedcode;
        protected bool ? _issuccess;
        protected string _comment;
        protected string _remarks;
        protected string _updateinfo;
        protected long ? _tranformactionid;
                
        
        [DataMember]
        public long ? smstransectioncodeid
        {
            get { return _smstransectioncodeid; }
            set { _smstransectioncodeid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "smscodeid", ResourceType = typeof(CLL.LLClasses.Models._cnf_smsactivationtransection))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._cnf_smsactivationtransection), ErrorMessageResourceName = "smscodeidRequired")]
        public long ? smscodeid
        {
            get { return _smscodeid; }
            set { _smscodeid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "providedcode", ResourceType = typeof(CLL.LLClasses.Models._cnf_smsactivationtransection))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._cnf_smsactivationtransection), ErrorMessageResourceName = "providedcodeRequired")]
        public long ? providedcode
        {
            get { return _providedcode; }
            set { _providedcode = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "issuccess", ResourceType = typeof(CLL.LLClasses.Models._cnf_smsactivationtransection))]
        public bool ? issuccess
        {
            get { return _issuccess; }
            set { _issuccess = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(1000)]
        [Display(Name = "comment", ResourceType = typeof(CLL.LLClasses.Models._cnf_smsactivationtransection))]
        public string comment
        {
            get { return _comment; }
            set { _comment = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._cnf_smsactivationtransection))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._cnf_smsactivationtransection))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._cnf_smsactivationtransection))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public cnf_smsactivationtransectionEntity():base()
        {
        }
        
        public cnf_smsactivationtransectionEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public cnf_smsactivationtransectionEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("SMSTransectionCodeID"))) _smstransectioncodeid = reader.GetInt64(reader.GetOrdinal("SMSTransectionCodeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("SMSCodeID"))) _smscodeid = reader.GetInt64(reader.GetOrdinal("SMSCodeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProvidedCode"))) _providedcode = reader.GetInt64(reader.GetOrdinal("ProvidedCode"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsSuccess"))) _issuccess = reader.GetBoolean(reader.GetOrdinal("IsSuccess"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdateInfo"))) _updateinfo = reader.GetString(reader.GetOrdinal("UpdateInfo"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TranFormActionID"))) _tranformactionid = reader.GetInt64(reader.GetOrdinal("TranFormActionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }


        protected void LoadFromReader(IDataReader reader, bool IsListViewShow)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("SMSTransectionCodeID"))) _smstransectioncodeid = reader.GetInt64(reader.GetOrdinal("SMSTransectionCodeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("SMSCodeID"))) _smscodeid = reader.GetInt64(reader.GetOrdinal("SMSCodeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProvidedCode"))) _providedcode = reader.GetInt64(reader.GetOrdinal("ProvidedCode"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsSuccess"))) _issuccess = reader.GetBoolean(reader.GetOrdinal("IsSuccess"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdateInfo"))) _updateinfo = reader.GetString(reader.GetOrdinal("UpdateInfo"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TranFormActionID"))) _tranformactionid = reader.GetInt64(reader.GetOrdinal("TranFormActionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }
        
        #endregion
        
        
            
    }
}
