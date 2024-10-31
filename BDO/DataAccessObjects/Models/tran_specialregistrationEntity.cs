using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "tran_specialregistrationEntity", Namespace = "http://www.KAF.com/types")]
    public partial class tran_specialregistrationEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _specialregid;
        protected string _civilid;
        protected long ? _batchid;
        protected long ? _candidatetypeid;
        protected string _emailaddress;
        protected string _mobilenumber;
        protected bool ? _sendbysms;
        protected bool ? _sendbydigitalid;
        protected bool ? _sendbyemail;
        protected string _paciresponse;
        protected DateTime ? _validuntil;
        protected bool? _isexpired;
        protected string _remarks;
      
                
        
        [DataMember]
        public long ? specialregid
        {
            get { return _specialregid; }
            set { _specialregid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(12)]
        [Display(Name = "civilid", ResourceType = typeof(CLL.LLClasses.Models._tran_specialregistration))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_specialregistration), ErrorMessageResourceName = "civilidRequired")]
        public string civilid
        {
            get { return _civilid; }
            set { _civilid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "batchid", ResourceType = typeof(CLL.LLClasses.Models._tran_specialregistration))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_specialregistration), ErrorMessageResourceName = "batchidRequired")]
        public long ? batchid
        {
            get { return _batchid; }
            set { _batchid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "candidatetypeid", ResourceType = typeof(CLL.LLClasses.Models._tran_specialregistration))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_specialregistration), ErrorMessageResourceName = "candidatetypeidRequired")]
        public long ? candidatetypeid
        {
            get { return _candidatetypeid; }
            set { _candidatetypeid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(256)]
        [Display(Name = "emailaddress", ResourceType = typeof(CLL.LLClasses.Models._tran_specialregistration))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_specialregistration), ErrorMessageResourceName = "emailaddressRequired")]
        public string emailaddress
        {
            get { return _emailaddress; }
            set { _emailaddress = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(12)]
        [Display(Name = "mobilenumber", ResourceType = typeof(CLL.LLClasses.Models._tran_specialregistration))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_specialregistration), ErrorMessageResourceName = "mobilenumberRequired")]
        public string mobilenumber
        {
            get { return _mobilenumber; }
            set { _mobilenumber = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "sendbysms", ResourceType = typeof(CLL.LLClasses.Models._tran_specialregistration))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_specialregistration), ErrorMessageResourceName = "sendbysmsRequired")]
        public bool ? sendbysms
        {
            get { return _sendbysms; }
            set { _sendbysms = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "sendbydigitalid", ResourceType = typeof(CLL.LLClasses.Models._tran_specialregistration))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_specialregistration), ErrorMessageResourceName = "sendbydigitalidRequired")]
        public bool ? sendbydigitalid
        {
            get { return _sendbydigitalid; }
            set { _sendbydigitalid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "sendbyemail", ResourceType = typeof(CLL.LLClasses.Models._tran_specialregistration))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_specialregistration), ErrorMessageResourceName = "sendbyemailRequired")]
        public bool ? sendbyemail
        {
            get { return _sendbyemail; }
            set { _sendbyemail = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "paciresponse", ResourceType = typeof(CLL.LLClasses.Models._tran_specialregistration))]
        public string paciresponse
        {
            get { return _paciresponse; }
            set { _paciresponse = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "validuntil", ResourceType = typeof(CLL.LLClasses.Models._tran_specialregistration))]
        //[Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_specialregistration), ErrorMessageResourceName = "validuntilRequired")]
        public DateTime ? validuntil
        {
            get { return _validuntil; }
            set { _validuntil = value; this.OnChnaged(); }
        }

        [DataMember]
        public bool? isexpired
        {
            get { return _isexpired; }
            set { _isexpired = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._tran_specialregistration))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        
        
        #endregion
    
        #region Constructor
    
        public tran_specialregistrationEntity():base()
        {
        }
        
        public tran_specialregistrationEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public tran_specialregistrationEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("SpecialRegID"))) _specialregid = reader.GetInt64(reader.GetOrdinal("SpecialRegID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _civilid = reader.GetString(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchID"))) _batchid = reader.GetInt64(reader.GetOrdinal("BatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CandidateTypeId"))) _candidatetypeid = reader.GetInt64(reader.GetOrdinal("CandidateTypeId"));
                if (!reader.IsDBNull(reader.GetOrdinal("EmailAddress"))) _emailaddress = reader.GetString(reader.GetOrdinal("EmailAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNumber"))) _mobilenumber = reader.GetString(reader.GetOrdinal("MobileNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("SendBySMS"))) _sendbysms = reader.GetBoolean(reader.GetOrdinal("SendBySMS"));
                if (!reader.IsDBNull(reader.GetOrdinal("SendByDigitalID"))) _sendbydigitalid = reader.GetBoolean(reader.GetOrdinal("SendByDigitalID"));
                if (!reader.IsDBNull(reader.GetOrdinal("SendByEmail"))) _sendbyemail = reader.GetBoolean(reader.GetOrdinal("SendByEmail"));
                if (!reader.IsDBNull(reader.GetOrdinal("PaciResponse"))) _paciresponse = reader.GetString(reader.GetOrdinal("PaciResponse"));
                if (!reader.IsDBNull(reader.GetOrdinal("ValidUntil"))) _validuntil = reader.GetDateTime(reader.GetOrdinal("ValidUntil"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsExpired"))) _isexpired = reader.GetBoolean(reader.GetOrdinal("IsExpired"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("SpecialRegID"))) _specialregid = reader.GetInt64(reader.GetOrdinal("SpecialRegID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _civilid = reader.GetString(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchID"))) _batchid = reader.GetInt64(reader.GetOrdinal("BatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CandidateTypeId"))) _candidatetypeid = reader.GetInt64(reader.GetOrdinal("CandidateTypeId"));
                if (!reader.IsDBNull(reader.GetOrdinal("EmailAddress"))) _emailaddress = reader.GetString(reader.GetOrdinal("EmailAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNumber"))) _mobilenumber = reader.GetString(reader.GetOrdinal("MobileNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("SendBySMS"))) _sendbysms = reader.GetBoolean(reader.GetOrdinal("SendBySMS"));
                if (!reader.IsDBNull(reader.GetOrdinal("SendByDigitalID"))) _sendbydigitalid = reader.GetBoolean(reader.GetOrdinal("SendByDigitalID"));
                if (!reader.IsDBNull(reader.GetOrdinal("SendByEmail"))) _sendbyemail = reader.GetBoolean(reader.GetOrdinal("SendByEmail"));
                if (!reader.IsDBNull(reader.GetOrdinal("PaciResponse"))) _paciresponse = reader.GetString(reader.GetOrdinal("PaciResponse"));
                if (!reader.IsDBNull(reader.GetOrdinal("ValidUntil"))) _validuntil = reader.GetDateTime(reader.GetOrdinal("ValidUntil"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsExpired"))) _isexpired = reader.GetBoolean(reader.GetOrdinal("IsExpired"));
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
