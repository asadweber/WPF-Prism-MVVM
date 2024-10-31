using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "tran_notificationfileEntity", Namespace = "http://www.KAF.com/types")]
    public partial class tran_notificationfileEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _filerequestid;
        protected Guid ? _fileguid;
        protected string ? _applicationid;
        protected string _physicalfilename;
        protected string _userfilename;
        protected string _filetype;
        protected string _fileextension;
        protected long ? _filesize;
        protected string _messagesubject;
        protected string _messagebody;
        protected string _messagesubjectar;
        protected string _messagebodyar;
        protected string _messagebodyemail;
        protected string _messagebodyemailar;
        protected bool ? _sendsms;
        protected bool ? _senddigitalidnotification;
        protected bool ? _sendemail;
        protected string ? _fileid;
        protected DateTime ? _fileuploaddate;
        protected bool ? _fileuploadresult;
        protected string _comment;
                
        
        [DataMember]
        public long ? filerequestid
        {
            get { return _filerequestid; }
            set { _filerequestid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "fileguid", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationfile))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_notificationfile), ErrorMessageResourceName = "fileguidRequired")]
        public Guid ? fileguid
        {
            get { return _fileguid; }
            set { _fileguid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "applicationid", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationfile))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_notificationfile), ErrorMessageResourceName = "applicationidRequired")]
        public string ? applicationid
        {
            get { return _applicationid; }
            set { _applicationid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "physicalfilename", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationfile))]
        public string physicalfilename
        {
            get { return _physicalfilename; }
            set { _physicalfilename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "userfilename", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationfile))]
        public string userfilename
        {
            get { return _userfilename; }
            set { _userfilename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "filetype", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationfile))]
        public string filetype
        {
            get { return _filetype; }
            set { _filetype = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(10)]
        [Display(Name = "fileextension", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationfile))]
        public string fileextension
        {
            get { return _fileextension; }
            set { _fileextension = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "filesize", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationfile))]
        public long ? filesize
        {
            get { return _filesize; }
            set { _filesize = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "messagesubject", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationfile))]
        public string messagesubject
        {
            get { return _messagesubject; }
            set { _messagesubject = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(-1)]
        [Display(Name = "messagebody", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationfile))]
        public string messagebody
        {
            get { return _messagebody; }
            set { _messagebody = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "messagesubjectar", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationfile))]
        public string messagesubjectar
        {
            get { return _messagesubjectar; }
            set { _messagesubjectar = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(-1)]
        [Display(Name = "messagebodyar", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationfile))]
        public string messagebodyar
        {
            get { return _messagebodyar; }
            set { _messagebodyar = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(-1)]
        [Display(Name = "messagebodyemail", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationfile))]
        public string messagebodyemail
        {
            get { return _messagebodyemail; }
            set { _messagebodyemail = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(-1)]
        [Display(Name = "messagebodyemailar", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationfile))]
        public string messagebodyemailar
        {
            get { return _messagebodyemailar; }
            set { _messagebodyemailar = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "sendsms", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationfile))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_notificationfile), ErrorMessageResourceName = "sendsmsRequired")]
        public bool ? sendsms
        {
            get { return _sendsms; }
            set { _sendsms = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "senddigitalidnotification", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationfile))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_notificationfile), ErrorMessageResourceName = "senddigitalidnotificationRequired")]
        public bool ? senddigitalidnotification
        {
            get { return _senddigitalidnotification; }
            set { _senddigitalidnotification = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "sendemail", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationfile))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_notificationfile), ErrorMessageResourceName = "sendemailRequired")]
        public bool ? sendemail
        {
            get { return _sendemail; }
            set { _sendemail = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "fileid", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationfile))]
        public string ? fileid
        {
            get { return _fileid; }
            set { _fileid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "fileuploaddate", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationfile))]
        public DateTime ? fileuploaddate
        {
            get { return _fileuploaddate; }
            set { _fileuploaddate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "fileuploadresult", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationfile))]
        public bool ? fileuploadresult
        {
            get { return _fileuploadresult; }
            set { _fileuploadresult = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(500)]
        [Display(Name = "comment", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationfile))]
        public string comment
        {
            get { return _comment; }
            set { _comment = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public tran_notificationfileEntity():base()
        {
        }
        
        public tran_notificationfileEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public tran_notificationfileEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("FileRequestID"))) _filerequestid = reader.GetInt64(reader.GetOrdinal("FileRequestID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileGUID"))) _fileguid = reader.GetGuid(reader.GetOrdinal("FileGUID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicationID"))) _applicationid = reader.GetString(reader.GetOrdinal("ApplicationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PhysicalFileName"))) _physicalfilename = reader.GetString(reader.GetOrdinal("PhysicalFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserFileName"))) _userfilename = reader.GetString(reader.GetOrdinal("UserFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileType"))) _filetype = reader.GetString(reader.GetOrdinal("FileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileExtension"))) _fileextension = reader.GetString(reader.GetOrdinal("FileExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileSize"))) _filesize = reader.GetInt64(reader.GetOrdinal("FileSize"));
                if (!reader.IsDBNull(reader.GetOrdinal("MessageSubject"))) _messagesubject = reader.GetString(reader.GetOrdinal("MessageSubject"));
                if (!reader.IsDBNull(reader.GetOrdinal("MessageBody"))) _messagebody = reader.GetString(reader.GetOrdinal("MessageBody"));
                if (!reader.IsDBNull(reader.GetOrdinal("MessageSubjectAR"))) _messagesubjectar = reader.GetString(reader.GetOrdinal("MessageSubjectAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("MessageBodyAR"))) _messagebodyar = reader.GetString(reader.GetOrdinal("MessageBodyAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("MessageBodyEmail"))) _messagebodyemail = reader.GetString(reader.GetOrdinal("MessageBodyEmail"));
                if (!reader.IsDBNull(reader.GetOrdinal("MessageBodyEmailAR"))) _messagebodyemailar = reader.GetString(reader.GetOrdinal("MessageBodyEmailAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("SendSMS"))) _sendsms = reader.GetBoolean(reader.GetOrdinal("SendSMS"));
                if (!reader.IsDBNull(reader.GetOrdinal("SendDigitalIDNotification"))) _senddigitalidnotification = reader.GetBoolean(reader.GetOrdinal("SendDigitalIDNotification"));
                if (!reader.IsDBNull(reader.GetOrdinal("SendEmail"))) _sendemail = reader.GetBoolean(reader.GetOrdinal("SendEmail"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileID"))) _fileid = reader.GetString(reader.GetOrdinal("FileID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileUploadDate"))) _fileuploaddate = reader.GetDateTime(reader.GetOrdinal("FileUploadDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileUploadResult"))) _fileuploadresult = reader.GetBoolean(reader.GetOrdinal("FileUploadResult"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("FileRequestID"))) _filerequestid = reader.GetInt64(reader.GetOrdinal("FileRequestID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileGUID"))) _fileguid = reader.GetGuid(reader.GetOrdinal("FileGUID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicationID"))) _applicationid = reader.GetString(reader.GetOrdinal("ApplicationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PhysicalFileName"))) _physicalfilename = reader.GetString(reader.GetOrdinal("PhysicalFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserFileName"))) _userfilename = reader.GetString(reader.GetOrdinal("UserFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileType"))) _filetype = reader.GetString(reader.GetOrdinal("FileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileExtension"))) _fileextension = reader.GetString(reader.GetOrdinal("FileExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileSize"))) _filesize = reader.GetInt64(reader.GetOrdinal("FileSize"));
                if (!reader.IsDBNull(reader.GetOrdinal("MessageSubject"))) _messagesubject = reader.GetString(reader.GetOrdinal("MessageSubject"));
                if (!reader.IsDBNull(reader.GetOrdinal("MessageBody"))) _messagebody = reader.GetString(reader.GetOrdinal("MessageBody"));
                if (!reader.IsDBNull(reader.GetOrdinal("MessageSubjectAR"))) _messagesubjectar = reader.GetString(reader.GetOrdinal("MessageSubjectAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("MessageBodyAR"))) _messagebodyar = reader.GetString(reader.GetOrdinal("MessageBodyAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("MessageBodyEmail"))) _messagebodyemail = reader.GetString(reader.GetOrdinal("MessageBodyEmail"));
                if (!reader.IsDBNull(reader.GetOrdinal("MessageBodyEmailAR"))) _messagebodyemailar = reader.GetString(reader.GetOrdinal("MessageBodyEmailAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("SendSMS"))) _sendsms = reader.GetBoolean(reader.GetOrdinal("SendSMS"));
                if (!reader.IsDBNull(reader.GetOrdinal("SendDigitalIDNotification"))) _senddigitalidnotification = reader.GetBoolean(reader.GetOrdinal("SendDigitalIDNotification"));
                if (!reader.IsDBNull(reader.GetOrdinal("SendEmail"))) _sendemail = reader.GetBoolean(reader.GetOrdinal("SendEmail"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileID"))) _fileid = reader.GetString(reader.GetOrdinal("FileID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileUploadDate"))) _fileuploaddate = reader.GetDateTime(reader.GetOrdinal("FileUploadDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileUploadResult"))) _fileuploadresult = reader.GetBoolean(reader.GetOrdinal("FileUploadResult"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
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
