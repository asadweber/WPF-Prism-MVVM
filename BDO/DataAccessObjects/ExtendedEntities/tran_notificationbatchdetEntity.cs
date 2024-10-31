using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class tran_notificationbatchdetEntity
    {

        protected bool? _sendsms;
        protected bool? _senddigitalidnotification;
        protected bool? _sendemail;

        [DataMember]
        [Display(Name = "sendsms", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatch))]
        public bool? sendsms
        {
            get { return _sendsms; }
            set { _sendsms = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "senddigitalidnotification", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatch))]
        public bool? senddigitalidnotification
        {
            get { return _senddigitalidnotification; }
            set { _senddigitalidnotification = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "sendemail", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationbatch))]
        public bool? sendemail
        {
            get { return _sendemail; }
            set { _sendemail = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? BatchID { get; set; }

        protected void LoadFromReader(IDataReader reader, int e)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationBatchDetID"))) _notificationbatchdetid = reader.GetInt64(reader.GetOrdinal("NotificationBatchDetID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationBatchID"))) _notificationbatchid = reader.GetInt64(reader.GetOrdinal("NotificationBatchID"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("SendSMS"))) _sendsms = reader.GetBoolean(reader.GetOrdinal("SendSMS"));
                if (!reader.IsDBNull(reader.GetOrdinal("SendDigitalIDNotification"))) _senddigitalidnotification = reader.GetBoolean(reader.GetOrdinal("SendDigitalIDNotification"));
                if (!reader.IsDBNull(reader.GetOrdinal("SendEmail"))) _sendemail = reader.GetBoolean(reader.GetOrdinal("SendEmail"));
                CurrentState = EntityState.Unchanged;
            }
        }

    }
}