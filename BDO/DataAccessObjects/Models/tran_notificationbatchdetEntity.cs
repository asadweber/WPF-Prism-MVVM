using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "tran_notificationbatchdetEntity", Namespace = "http://www.KAF.com/types")]
    public partial class tran_notificationbatchdetEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _notificationbatchdetid;
        protected long ? _notificationbatchid;
        //protected long ? _parentnotificationbatchdetid;
        protected long ? _basicinfoid;
        protected long ? _registrationid;
        protected long ? _applicantphaseid;
        protected long ? _notificationtypeid;
        protected long ? _notificationtemplateid;
        protected string _sentmsg;
        protected DateTime ? _senddate;
        protected string _sendresponse;
        protected long ? _sendstatus;
        protected string _comment;
        protected string _remarks;
        protected string _updateinfo;
        protected long ? _tranformactionid;
                
        
        [DataMember]
        public long ? notificationbatchdetid
        {
            get { return _notificationbatchdetid; }
            set { _notificationbatchdetid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "notificationbatchid", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatchdet))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatchdet), ErrorMessageResourceName = "notificationbatchidRequired")]
        public long ? notificationbatchid
        {
            get { return _notificationbatchid; }
            set { _notificationbatchid = value; this.OnChnaged(); }
        }
        
        //[DataMember]
        //[Display(Name = "parentnotificationbatchdetid", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatchdet))]
        //public long ? parentnotificationbatchdetid
        //{
        //    get { return _parentnotificationbatchdetid; }
        //    set { _parentnotificationbatchdetid = value; this.OnChnaged(); }
        //}
        
        [DataMember]
        [Display(Name = "basicinfoid", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatchdet))]
        public long ? basicinfoid
        {
            get { return _basicinfoid; }
            set { _basicinfoid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "registrationid", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatchdet))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatchdet), ErrorMessageResourceName = "registrationidRequired")]
        public long ? registrationid
        {
            get { return _registrationid; }
            set { _registrationid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "applicantphaseid", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatchdet))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatchdet), ErrorMessageResourceName = "applicantphaseidRequired")]
        public long ? applicantphaseid
        {
            get { return _applicantphaseid; }
            set { _applicantphaseid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "notificationtypeid", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatchdet))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatchdet), ErrorMessageResourceName = "notificationtypeidRequired")]
        public long ? notificationtypeid
        {
            get { return _notificationtypeid; }
            set { _notificationtypeid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "notificationtemplateid", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatchdet))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatchdet), ErrorMessageResourceName = "notificationtemplateidRequired")]
        public long ? notificationtemplateid
        {
            get { return _notificationtemplateid; }
            set { _notificationtemplateid = value; this.OnChnaged(); }
        }
        
     
        
        [DataMember]
        [MaxLength(4000)]
        [Display(Name = "sentmsg", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatchdet))]
        public string sentmsg
        {
            get { return _sentmsg; }
            set { _sentmsg = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "senddate", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatchdet))]
        public DateTime ? senddate
        {
            get { return _senddate; }
            set { _senddate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(350)]
        [Display(Name = "sendresponse", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatchdet))]
        public string sendresponse
        {
            get { return _sendresponse; }
            set { _sendresponse = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "sendstatus", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatchdet))]
        public long ? sendstatus
        {
            get { return _sendstatus; }
            set { _sendstatus = value; this.OnChnaged(); }
        }
        
        
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "comment", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatchdet))]
        public string comment
        {
            get { return _comment; }
            set { _comment = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatchdet))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatchdet))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatchdet))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
        
        public tran_notificationbatchdetEntity():base()
        {
        }
        
        public tran_notificationbatchdetEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public tran_notificationbatchdetEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }

        public tran_notificationbatchdetEntity(IDataReader reader, int e)
        {
            this.LoadFromReader(reader, e);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationBatchDetID"))) _notificationbatchdetid = reader.GetInt64(reader.GetOrdinal("NotificationBatchDetID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationBatchID"))) _notificationbatchid = reader.GetInt64(reader.GetOrdinal("NotificationBatchID"));
                //if (!reader.IsDBNull(reader.GetOrdinal("ParentNotificationBatchDetID"))) _parentnotificationbatchdetid = reader.GetInt64(reader.GetOrdinal("ParentNotificationBatchDetID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) _registrationid = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicantPhaseID"))) _applicantphaseid = reader.GetInt64(reader.GetOrdinal("ApplicantPhaseID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationTypeID"))) _notificationtypeid = reader.GetInt64(reader.GetOrdinal("NotificationTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationTemplateID"))) _notificationtemplateid = reader.GetInt64(reader.GetOrdinal("NotificationTemplateID"));
                if (!reader.IsDBNull(reader.GetOrdinal("SentMsg"))) _sentmsg = reader.GetString(reader.GetOrdinal("SentMsg"));
                if (!reader.IsDBNull(reader.GetOrdinal("SendDate"))) _senddate = reader.GetDateTime(reader.GetOrdinal("SendDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("SendResponse"))) _sendresponse = reader.GetString(reader.GetOrdinal("SendResponse"));
                if (!reader.IsDBNull(reader.GetOrdinal("SendStatus"))) _sendstatus = reader.GetInt64(reader.GetOrdinal("SendStatus"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationBatchDetID"))) _notificationbatchdetid = reader.GetInt64(reader.GetOrdinal("NotificationBatchDetID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationBatchID"))) _notificationbatchid = reader.GetInt64(reader.GetOrdinal("NotificationBatchID"));
               // if (!reader.IsDBNull(reader.GetOrdinal("ParentNotificationBatchDetID"))) _parentnotificationbatchdetid = reader.GetInt64(reader.GetOrdinal("ParentNotificationBatchDetID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) _registrationid = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicantPhaseID"))) _applicantphaseid = reader.GetInt64(reader.GetOrdinal("ApplicantPhaseID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationTypeID"))) _notificationtypeid = reader.GetInt64(reader.GetOrdinal("NotificationTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationTemplateID"))) _notificationtemplateid = reader.GetInt64(reader.GetOrdinal("NotificationTemplateID"));
                if (!reader.IsDBNull(reader.GetOrdinal("SentMsg"))) _sentmsg = reader.GetString(reader.GetOrdinal("SentMsg"));
                if (!reader.IsDBNull(reader.GetOrdinal("SendDate"))) _senddate = reader.GetDateTime(reader.GetOrdinal("SendDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("SendResponse"))) _sendresponse = reader.GetString(reader.GetOrdinal("SendResponse"));
                if (!reader.IsDBNull(reader.GetOrdinal("SendStatus"))) _sendstatus = reader.GetInt64(reader.GetOrdinal("SendStatus"));
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
