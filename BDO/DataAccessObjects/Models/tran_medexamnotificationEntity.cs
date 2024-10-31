using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "tran_medexamnotificationEntity", Namespace = "http://www.KAF.com/types")]
    public partial class tran_medexamnotificationEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _medexamnotificationid;
        protected long ? _batchid;
        protected long ? _basicinfoid;
        protected long ? _registrationid;
        protected long ? _applicantphaseid;
        protected int ? _notificationtype;
        protected string _messagesubject;
        protected string _messagebody;
        protected bool ? _smsnotification;
        protected bool ? _pacinotification;
        protected bool ? _emailnotification;
        protected DateTime ? _senddate;
        protected string _notificationstatus;
        protected Guid ? _fileid;
        protected bool ? _fileuploadresult;
        protected string _comment;
        protected string _remarks;
        protected string _updateinfo;
        protected long ? _tranformactionid;
                
        
        [DataMember]
        public long ? medexamnotificationid
        {
            get { return _medexamnotificationid; }
            set { _medexamnotificationid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "batchid", ResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification), ErrorMessageResourceName = "batchidRequired")]
        public long ? batchid
        {
            get { return _batchid; }
            set { _batchid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "basicinfoid", ResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification), ErrorMessageResourceName = "basicinfoidRequired")]
        public long ? basicinfoid
        {
            get { return _basicinfoid; }
            set { _basicinfoid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "registrationid", ResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification), ErrorMessageResourceName = "registrationidRequired")]
        public long ? registrationid
        {
            get { return _registrationid; }
            set { _registrationid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "applicantphaseid", ResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification), ErrorMessageResourceName = "applicantphaseidRequired")]
        public long ? applicantphaseid
        {
            get { return _applicantphaseid; }
            set { _applicantphaseid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "notificationtype", ResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification), ErrorMessageResourceName = "notificationtypeRequired")]
        public int ? notificationtype
        {
            get { return _notificationtype; }
            set { _notificationtype = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(500)]
        [Display(Name = "messagesubject", ResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification), ErrorMessageResourceName = "messagesubjectRequired")]
        public string messagesubject
        {
            get { return _messagesubject; }
            set { _messagesubject = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(4000)]
        [Display(Name = "messagebody", ResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification), ErrorMessageResourceName = "messagebodyRequired")]
        public string messagebody
        {
            get { return _messagebody; }
            set { _messagebody = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "smsnotification", ResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification), ErrorMessageResourceName = "smsnotificationRequired")]
        public bool ? smsnotification
        {
            get { return _smsnotification; }
            set { _smsnotification = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "pacinotification", ResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification), ErrorMessageResourceName = "pacinotificationRequired")]
        public bool ? pacinotification
        {
            get { return _pacinotification; }
            set { _pacinotification = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "emailnotification", ResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification), ErrorMessageResourceName = "emailnotificationRequired")]
        public bool ? emailnotification
        {
            get { return _emailnotification; }
            set { _emailnotification = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "senddate", ResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification), ErrorMessageResourceName = "senddateRequired")]
        public DateTime ? senddate
        {
            get { return _senddate; }
            set { _senddate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(500)]
        [Display(Name = "notificationstatus", ResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification), ErrorMessageResourceName = "notificationstatusRequired")]
        public string notificationstatus
        {
            get { return _notificationstatus; }
            set { _notificationstatus = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "fileid", ResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification), ErrorMessageResourceName = "fileidRequired")]
        public Guid ? fileid
        {
            get { return _fileid; }
            set { _fileid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "fileuploadresult", ResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification), ErrorMessageResourceName = "fileuploadresultRequired")]
        public bool ? fileuploadresult
        {
            get { return _fileuploadresult; }
            set { _fileuploadresult = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "comment", ResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification))]
        public string comment
        {
            get { return _comment; }
            set { _comment = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._tran_medexamnotification))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }

        [DataMember]
        public string basicinfoids { get; set; }



        [DataMember]
        public string civilidstring { get; set; }


        [DataMember]
        public string primarykeystring { get; set; }
        #endregion

        #region Constructor

        public tran_medexamnotificationEntity():base()
        {
        }
        
        public tran_medexamnotificationEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public tran_medexamnotificationEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("MedExamNotificationID"))) _medexamnotificationid = reader.GetInt64(reader.GetOrdinal("MedExamNotificationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchID"))) _batchid = reader.GetInt64(reader.GetOrdinal("BatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) _registrationid = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicantPhaseID"))) _applicantphaseid = reader.GetInt64(reader.GetOrdinal("ApplicantPhaseID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationType"))) _notificationtype = reader.GetInt32(reader.GetOrdinal("NotificationType"));
                if (!reader.IsDBNull(reader.GetOrdinal("MessageSubject"))) _messagesubject = reader.GetString(reader.GetOrdinal("MessageSubject"));
                if (!reader.IsDBNull(reader.GetOrdinal("MessageBody"))) _messagebody = reader.GetString(reader.GetOrdinal("MessageBody"));
                if (!reader.IsDBNull(reader.GetOrdinal("SmsNotification"))) _smsnotification = reader.GetBoolean(reader.GetOrdinal("SmsNotification"));
                if (!reader.IsDBNull(reader.GetOrdinal("PaciNotification"))) _pacinotification = reader.GetBoolean(reader.GetOrdinal("PaciNotification"));
                if (!reader.IsDBNull(reader.GetOrdinal("EmailNotification"))) _emailnotification = reader.GetBoolean(reader.GetOrdinal("EmailNotification"));
                if (!reader.IsDBNull(reader.GetOrdinal("SendDate"))) _senddate = reader.GetDateTime(reader.GetOrdinal("SendDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationStatus"))) _notificationstatus = reader.GetString(reader.GetOrdinal("NotificationStatus"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileID"))) _fileid = reader.GetGuid(reader.GetOrdinal("FileID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileUploadResult"))) _fileuploadresult = reader.GetBoolean(reader.GetOrdinal("FileUploadResult"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("MedExamNotificationID"))) _medexamnotificationid = reader.GetInt64(reader.GetOrdinal("MedExamNotificationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchID"))) _batchid = reader.GetInt64(reader.GetOrdinal("BatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) _registrationid = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicantPhaseID"))) _applicantphaseid = reader.GetInt64(reader.GetOrdinal("ApplicantPhaseID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationType"))) _notificationtype = reader.GetInt32(reader.GetOrdinal("NotificationType"));
                if (!reader.IsDBNull(reader.GetOrdinal("MessageSubject"))) _messagesubject = reader.GetString(reader.GetOrdinal("MessageSubject"));
                if (!reader.IsDBNull(reader.GetOrdinal("MessageBody"))) _messagebody = reader.GetString(reader.GetOrdinal("MessageBody"));
                if (!reader.IsDBNull(reader.GetOrdinal("SmsNotification"))) _smsnotification = reader.GetBoolean(reader.GetOrdinal("SmsNotification"));
                if (!reader.IsDBNull(reader.GetOrdinal("PaciNotification"))) _pacinotification = reader.GetBoolean(reader.GetOrdinal("PaciNotification"));
                if (!reader.IsDBNull(reader.GetOrdinal("EmailNotification"))) _emailnotification = reader.GetBoolean(reader.GetOrdinal("EmailNotification"));
                if (!reader.IsDBNull(reader.GetOrdinal("SendDate"))) _senddate = reader.GetDateTime(reader.GetOrdinal("SendDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationStatus"))) _notificationstatus = reader.GetString(reader.GetOrdinal("NotificationStatus"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileID"))) _fileid = reader.GetGuid(reader.GetOrdinal("FileID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileUploadResult"))) _fileuploadresult = reader.GetBoolean(reader.GetOrdinal("FileUploadResult"));
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
