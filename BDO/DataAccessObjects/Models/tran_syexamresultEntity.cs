using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "tran_syexamresultEntity", Namespace = "http://www.KAF.com/types")]
    public partial class tran_syexamresultEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _syexamresultid;
        protected long ? _basicinfoid;
        protected long ? _registrationid;
        protected int ? _syexamresult;
        protected string _syexamcomment;
        protected DateTime ? _syexamresultdate;
        protected string _remarks;
        protected bool ? _issoftdeleted;
        protected string _updateinfo;
        protected long ? _tranformactionid;
                
        
        [DataMember]
        public long ? syexamresultid
        {
            get { return _syexamresultid; }
            set { _syexamresultid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "basicinfoid", ResourceType = typeof(CLL.LLClasses.Models._tran_syexamresult))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_syexamresult), ErrorMessageResourceName = "basicinfoidRequired")]
        public long ? basicinfoid
        {
            get { return _basicinfoid; }
            set { _basicinfoid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "registrationid", ResourceType = typeof(CLL.LLClasses.Models._tran_syexamresult))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_syexamresult), ErrorMessageResourceName = "registrationidRequired")]
        public long ? registrationid
        {
            get { return _registrationid; }
            set { _registrationid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "syexamresult", ResourceType = typeof(CLL.LLClasses.Models._tran_syexamresult))]
        public int ? syexamresult
        {
            get { return _syexamresult; }
            set { _syexamresult = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "syexamcomment", ResourceType = typeof(CLL.LLClasses.Models._tran_syexamresult))]
        public string syexamcomment
        {
            get { return _syexamcomment; }
            set { _syexamcomment = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "syexamresultdate", ResourceType = typeof(CLL.LLClasses.Models._tran_syexamresult))]
        public DateTime ? syexamresultdate
        {
            get { return _syexamresultdate; }
            set { _syexamresultdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._tran_syexamresult))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "issoftdeleted", ResourceType = typeof(CLL.LLClasses.Models._tran_syexamresult))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_syexamresult), ErrorMessageResourceName = "issoftdeletedRequired")]
        public bool ? issoftdeleted
        {
            get { return _issoftdeleted; }
            set { _issoftdeleted = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._tran_syexamresult))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._tran_syexamresult))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public tran_syexamresultEntity():base()
        {
        }
        
        public tran_syexamresultEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public tran_syexamresultEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("SyExamResultID"))) _syexamresultid = reader.GetInt64(reader.GetOrdinal("SyExamResultID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) _registrationid = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("SyExamResult"))) _syexamresult = reader.GetInt32(reader.GetOrdinal("SyExamResult"));
                if (!reader.IsDBNull(reader.GetOrdinal("SyExamComment"))) _syexamcomment = reader.GetString(reader.GetOrdinal("SyExamComment"));
                if (!reader.IsDBNull(reader.GetOrdinal("SyExamResultDate"))) _syexamresultdate = reader.GetDateTime(reader.GetOrdinal("SyExamResultDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsSoftDeleted"))) _issoftdeleted = reader.GetBoolean(reader.GetOrdinal("IsSoftDeleted"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("SyExamResultID"))) _syexamresultid = reader.GetInt64(reader.GetOrdinal("SyExamResultID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) _registrationid = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("SyExamResult"))) _syexamresult = reader.GetInt32(reader.GetOrdinal("SyExamResult"));
                if (!reader.IsDBNull(reader.GetOrdinal("SyExamComment"))) _syexamcomment = reader.GetString(reader.GetOrdinal("SyExamComment"));
                if (!reader.IsDBNull(reader.GetOrdinal("SyExamResultDate"))) _syexamresultdate = reader.GetDateTime(reader.GetOrdinal("SyExamResultDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsSoftDeleted"))) _issoftdeleted = reader.GetBoolean(reader.GetOrdinal("IsSoftDeleted"));
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
