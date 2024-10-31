﻿using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "cnf_smsactivationcodeEntity", Namespace = "http://www.KAF.com/types")]
    public partial class cnf_smsactivationcodeEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _smscodeid;
        protected long ? _basicinfoid;
        protected Guid? _userid;
        protected DateTime ? _generatedate;
        protected long ? _smscodetype;
        protected long ? _smscode;
        protected bool ? _isactive;
        protected DateTime ? _sucessdate;
        protected bool ? _smsstatus;
        protected DateTime ? _smssenddate;
        protected string _smsresponse;
        protected string _comment;
        protected string _remarks;
        protected string _updateinfo;
        protected long ? _tranformactionid;
                
        
        [DataMember]
        public long ? smscodeid
        {
            get { return _smscodeid; }
            set { _smscodeid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "basicinfoid", ResourceType = typeof(CLL.LLClasses.Models._cnf_smsactivationcode))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._cnf_smsactivationcode), ErrorMessageResourceName = "basicinfoidRequired")]
        
        public long ? basicinfoid
        {
            get { return _basicinfoid; }
            set { _basicinfoid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "userid", ResourceType = typeof(CLL.LLClasses.Models._cnf_smsactivationcode))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._cnf_smsactivationcode), ErrorMessageResourceName = "useridRequired")]

        public Guid? userid
        {
            get { return _userid; }
            set { _userid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "generatedate", ResourceType = typeof(CLL.LLClasses.Models._cnf_smsactivationcode))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._cnf_smsactivationcode), ErrorMessageResourceName = "generatedateRequired")]
        public DateTime ? generatedate
        {
            get { return _generatedate; }
            set { _generatedate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "smscodetype", ResourceType = typeof(CLL.LLClasses.Models._cnf_smsactivationcode))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._cnf_smsactivationcode), ErrorMessageResourceName = "smscodetypeRequired")]
        public long ? smscodetype
        {
            get { return _smscodetype; }
            set { _smscodetype = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "smscode", ResourceType = typeof(CLL.LLClasses.Models._cnf_smsactivationcode))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._cnf_smsactivationcode), ErrorMessageResourceName = "smscodeRequired")]		
		public long ? smscode
        {
            get { return _smscode; }
            set { _smscode = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._cnf_smsactivationcode))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._cnf_smsactivationcode), ErrorMessageResourceName = "isactiveRequired")]
        public bool ? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "sucessdate", ResourceType = typeof(CLL.LLClasses.Models._cnf_smsactivationcode))]
        public DateTime ? sucessdate
        {
            get { return _sucessdate; }
            set { _sucessdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "smsstatus", ResourceType = typeof(CLL.LLClasses.Models._cnf_smsactivationcode))]
        public bool ? smsstatus
        {
            get { return _smsstatus; }
            set { _smsstatus = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "smssenddate", ResourceType = typeof(CLL.LLClasses.Models._cnf_smsactivationcode))]
        public DateTime ? smssenddate
        {
            get { return _smssenddate; }
            set { _smssenddate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(500)]
        [Display(Name = "smsresponse", ResourceType = typeof(CLL.LLClasses.Models._cnf_smsactivationcode))]
        public string smsresponse
        {
            get { return _smsresponse; }
            set { _smsresponse = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(1000)]
        [Display(Name = "comment", ResourceType = typeof(CLL.LLClasses.Models._cnf_smsactivationcode))]
        public string comment
        {
            get { return _comment; }
            set { _comment = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._cnf_smsactivationcode))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._cnf_smsactivationcode))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._cnf_smsactivationcode))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public cnf_smsactivationcodeEntity():base()
        {
        }
        
        public cnf_smsactivationcodeEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public cnf_smsactivationcodeEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("SMSCodeID"))) _smscodeid = reader.GetInt64(reader.GetOrdinal("SMSCodeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserID"))) _userid = reader.GetGuid(reader.GetOrdinal("UserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("GenerateDate"))) _generatedate = reader.GetDateTime(reader.GetOrdinal("GenerateDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("SmsCodeType"))) _smscodetype = reader.GetInt64(reader.GetOrdinal("SmsCodeType"));
                if (!reader.IsDBNull(reader.GetOrdinal("SmsCode"))) _smscode = reader.GetInt64(reader.GetOrdinal("SmsCode"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                if (!reader.IsDBNull(reader.GetOrdinal("SucessDate"))) _sucessdate = reader.GetDateTime(reader.GetOrdinal("SucessDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("smsStatus"))) _smsstatus = reader.GetBoolean(reader.GetOrdinal("smsStatus"));
                if (!reader.IsDBNull(reader.GetOrdinal("SmsSendDate"))) _smssenddate = reader.GetDateTime(reader.GetOrdinal("SmsSendDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("SmsResponse"))) _smsresponse = reader.GetString(reader.GetOrdinal("SmsResponse"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("SMSCodeID"))) _smscodeid = reader.GetInt64(reader.GetOrdinal("SMSCodeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserID"))) _userid = reader.GetGuid(reader.GetOrdinal("UserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("GenerateDate"))) _generatedate = reader.GetDateTime(reader.GetOrdinal("GenerateDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("SmsCodeType"))) _smscodetype = reader.GetInt64(reader.GetOrdinal("SmsCodeType"));
                if (!reader.IsDBNull(reader.GetOrdinal("SmsCode"))) _smscode = reader.GetInt64(reader.GetOrdinal("SmsCode"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                if (!reader.IsDBNull(reader.GetOrdinal("SucessDate"))) _sucessdate = reader.GetDateTime(reader.GetOrdinal("SucessDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("smsStatus"))) _smsstatus = reader.GetBoolean(reader.GetOrdinal("smsStatus"));
                if (!reader.IsDBNull(reader.GetOrdinal("SmsSendDate"))) _smssenddate = reader.GetDateTime(reader.GetOrdinal("SmsSendDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("SmsResponse"))) _smsresponse = reader.GetString(reader.GetOrdinal("SmsResponse"));
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
