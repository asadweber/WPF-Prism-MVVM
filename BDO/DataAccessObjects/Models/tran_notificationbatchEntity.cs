using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "tran_notificationbatchEntity", Namespace = "http://www.KAF.com/types")]
    public partial class tran_notificationbatchEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _notificationbatchid;
        protected string ? _batchid;
        protected long ? _typeid;
        protected string _description;
        protected string _remarks;
        protected long ? _phaseid;
        protected long ? _statusid;
        protected int ? _numberofapplicant;
        protected DateTime ? _scheduledfor;
        protected DateTime ? _interviewdate;
        protected bool? _sendsms;
        protected bool? _senddigitalidnotification;
        protected bool? _sendemail;
        protected string _notificationstatus;
        protected string _comment;
        protected Guid? _fileid;
        protected DateTime ? _fileuploaddate;
        protected bool ? _fileuploadresult;
        
        [DataMember]
        public long ? notificationbatchid
        {
            get { return _notificationbatchid; }
            set { _notificationbatchid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "batchid", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatch))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatch), ErrorMessageResourceName = "batchidRequired")]
        public string ? batchid
        {
            get { return _batchid; }
            set { _batchid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "typeid", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatch))]
        public long ? typeid
        {
            get { return _typeid; }
            set { _typeid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(350)]
        [Display(Name = "description", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatch))]
        public string description
        {
            get { return _description; }
            set { _description = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(350)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatch))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "phaseid", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatch))]
        public long ? phaseid
        {
            get { return _phaseid; }
            set { _phaseid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "statusid", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatch))]
        public long ? statusid
        {
            get { return _statusid; }
            set { _statusid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "numberofapplicant", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatch))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatch), ErrorMessageResourceName = "numberofapplicantRequired")]
        public int ? numberofapplicant
        {
            get { return _numberofapplicant; }
            set { _numberofapplicant = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "interviewdate", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatch))]
        public DateTime ? interviewdate
        {
            get { return _interviewdate; }
            set { _interviewdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "sendsms", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatch))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatch), ErrorMessageResourceName = "sendsmsRequired")]
        public bool? sendsms
        {
            get { return _sendsms; }
            set { _sendsms = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "senddigitalidnotification", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatch))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatch), ErrorMessageResourceName = "senddigitalidnotificationRequired")]
        public bool? senddigitalidnotification
        {
            get { return _senddigitalidnotification; }
            set { _senddigitalidnotification = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "sendemail", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatch))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatch), ErrorMessageResourceName = "sendemailRequired")]
        public bool? sendemail
        {
            get { return _sendemail; }
            set { _sendemail = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(50)]
        [Display(Name = "notificationstatus", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatch))]
        public string notificationstatus
        {
            get { return _notificationstatus; }
            set { _notificationstatus = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "comment", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatch))]
        public string comment
        {
            get { return _comment; }
            set { _comment = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        public Guid? fileid
        {
            get { return _fileid; }
            set { _fileid = value; this.OnChnaged(); }
        }

        [DataMember]
        public DateTime ? fileuploaddate
        {
            get { return _fileuploaddate; }
            set { _fileuploaddate = value; this.OnChnaged(); }
        }

        [DataMember]
        public bool ? fileuploadresult
        {
            get { return _fileuploadresult; }
            set { _fileuploadresult = value; this.OnChnaged(); }
        }

        #endregion

        #region Constructor

        public tran_notificationbatchEntity():base()
        {
        }
        
        public tran_notificationbatchEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public tran_notificationbatchEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationBatchID"))) _notificationbatchid = reader.GetInt64(reader.GetOrdinal("NotificationBatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchID"))) _batchid = reader.GetString(reader.GetOrdinal("BatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TypeID"))) _typeid = reader.GetInt64(reader.GetOrdinal("TypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Description"))) _description = reader.GetString(reader.GetOrdinal("Description"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("PhaseID"))) _phaseid = reader.GetInt64(reader.GetOrdinal("PhaseID"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusID"))) _statusid = reader.GetInt64(reader.GetOrdinal("StatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NumberofApplicant"))) _numberofapplicant = reader.GetInt32(reader.GetOrdinal("NumberofApplicant"));
                if (!reader.IsDBNull(reader.GetOrdinal("InterviewDate"))) _interviewdate = reader.GetDateTime(reader.GetOrdinal("InterviewDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("SendSMS"))) _sendsms = reader.GetBoolean(reader.GetOrdinal("SendSMS"));
                if (!reader.IsDBNull(reader.GetOrdinal("SendDigitalIDNotification"))) _senddigitalidnotification = reader.GetBoolean(reader.GetOrdinal("SendDigitalIDNotification"));
                if (!reader.IsDBNull(reader.GetOrdinal("SendEmail"))) _sendemail = reader.GetBoolean(reader.GetOrdinal("SendEmail"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationStatus"))) _notificationstatus = reader.GetString(reader.GetOrdinal("NotificationStatus"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileID"))) _fileid = reader.GetGuid(reader.GetOrdinal("FileID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileUploadDate"))) _fileuploaddate = reader.GetDateTime(reader.GetOrdinal("FileUploadDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileUploadResult"))) _fileuploadresult = reader.GetBoolean(reader.GetOrdinal("FileUploadResult"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationBatchID"))) _notificationbatchid = reader.GetInt64(reader.GetOrdinal("NotificationBatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchID"))) _batchid = reader.GetString(reader.GetOrdinal("BatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TypeID"))) _typeid = reader.GetInt64(reader.GetOrdinal("TypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Description"))) _description = reader.GetString(reader.GetOrdinal("Description"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("PhaseID"))) _phaseid = reader.GetInt64(reader.GetOrdinal("PhaseID"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusID"))) _statusid = reader.GetInt64(reader.GetOrdinal("StatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NumberofApplicant"))) _numberofapplicant = reader.GetInt32(reader.GetOrdinal("NumberofApplicant"));
                if (!reader.IsDBNull(reader.GetOrdinal("InterviewDate"))) _interviewdate = reader.GetDateTime(reader.GetOrdinal("InterviewDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("SendSMS"))) _sendsms = reader.GetBoolean(reader.GetOrdinal("SendSMS"));
                if (!reader.IsDBNull(reader.GetOrdinal("SendDigitalIDNotification"))) _senddigitalidnotification = reader.GetBoolean(reader.GetOrdinal("SendDigitalIDNotification"));
                if (!reader.IsDBNull(reader.GetOrdinal("SendEmail"))) _sendemail = reader.GetBoolean(reader.GetOrdinal("SendEmail"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationStatus"))) _notificationstatus = reader.GetString(reader.GetOrdinal("NotificationStatus"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileID"))) _fileid = reader.GetGuid(reader.GetOrdinal("FileID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileUploadDate"))) _fileuploaddate = reader.GetDateTime(reader.GetOrdinal("FileUploadDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileUploadResult"))) _fileuploadresult = reader.GetBoolean(reader.GetOrdinal("FileUploadResult"));
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
