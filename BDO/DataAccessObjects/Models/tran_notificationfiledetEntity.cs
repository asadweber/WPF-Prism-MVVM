using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "tran_notificationfiledetEntity", Namespace = "http://www.KAF.com/types")]
    public partial class tran_notificationfiledetEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _filerequestdetid;
        protected long ? _filerequestid;
        protected string _recipientcivilid;
        protected string _recipientmobile;
        protected string _recipientemail;
        protected string _updateinfo;
        protected long ? _tranformactionid;
                
        
        [DataMember]
        public long ? filerequestdetid
        {
            get { return _filerequestdetid; }
            set { _filerequestdetid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "filerequestid", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationfiledet))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_notificationfiledet), ErrorMessageResourceName = "filerequestidRequired")]
        public long ? filerequestid
        {
            get { return _filerequestid; }
            set { _filerequestid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(12)]
        [Display(Name = "recipientcivilid", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationfiledet))]
        public string recipientcivilid
        {
            get { return _recipientcivilid; }
            set { _recipientcivilid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(8)]
        [Display(Name = "recipientmobile", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationfiledet))]
        public string recipientmobile
        {
            get { return _recipientmobile; }
            set { _recipientmobile = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(120)]
        [Display(Name = "recipientemail", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationfiledet))]
        public string recipientemail
        {
            get { return _recipientemail; }
            set { _recipientemail = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationfiledet))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._tran_notificationfiledet))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public tran_notificationfiledetEntity():base()
        {
        }
        
        public tran_notificationfiledetEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public tran_notificationfiledetEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("FileRequestDetID"))) _filerequestdetid = reader.GetInt64(reader.GetOrdinal("FileRequestDetID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileRequestID"))) _filerequestid = reader.GetInt64(reader.GetOrdinal("FileRequestID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RecipientCivilID"))) _recipientcivilid = reader.GetString(reader.GetOrdinal("RecipientCivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RecipientMobile"))) _recipientmobile = reader.GetString(reader.GetOrdinal("RecipientMobile"));
                if (!reader.IsDBNull(reader.GetOrdinal("RecipientEmail"))) _recipientemail = reader.GetString(reader.GetOrdinal("RecipientEmail"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("FileRequestDetID"))) _filerequestdetid = reader.GetInt64(reader.GetOrdinal("FileRequestDetID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileRequestID"))) _filerequestid = reader.GetInt64(reader.GetOrdinal("FileRequestID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RecipientCivilID"))) _recipientcivilid = reader.GetString(reader.GetOrdinal("RecipientCivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RecipientMobile"))) _recipientmobile = reader.GetString(reader.GetOrdinal("RecipientMobile"));
                if (!reader.IsDBNull(reader.GetOrdinal("RecipientEmail"))) _recipientemail = reader.GetString(reader.GetOrdinal("RecipientEmail"));
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
