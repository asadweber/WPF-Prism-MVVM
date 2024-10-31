using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "tran_medexamresultEntity", Namespace = "http://www.KAF.com/types")]
    public partial class tran_medexamresultEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _medexamresultid;
        protected long ? _basicinfoid;
        protected long ? _registrationid;
        protected int ? _medexamresult;
        protected string _medexamcomment;
        protected DateTime ? _medexamresultdate;
        protected string _remarks;
        protected bool ? _issoftdeleted;
        protected string _updateinfo;
        protected long ? _tranformactionid;
                
        
        [DataMember]
        public long ? medexamresultid
        {
            get { return _medexamresultid; }
            set { _medexamresultid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "basicinfoid", ResourceType = typeof(CLL.LLClasses.Models._tran_medexamresult))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_medexamresult), ErrorMessageResourceName = "basicinfoidRequired")]
        public long ? basicinfoid
        {
            get { return _basicinfoid; }
            set { _basicinfoid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "registrationid", ResourceType = typeof(CLL.LLClasses.Models._tran_medexamresult))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_medexamresult), ErrorMessageResourceName = "registrationidRequired")]
        public long ? registrationid
        {
            get { return _registrationid; }
            set { _registrationid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "medexamresult", ResourceType = typeof(CLL.LLClasses.Models._tran_medexamresult))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_medexamresult), ErrorMessageResourceName = "medexamresultRequired")]
        public int ? medexamresult
        {
            get { return _medexamresult; }
            set { _medexamresult = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "medexamcomment", ResourceType = typeof(CLL.LLClasses.Models._tran_medexamresult))]
        public string medexamcomment
        {
            get { return _medexamcomment; }
            set { _medexamcomment = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "medexamresultdate", ResourceType = typeof(CLL.LLClasses.Models._tran_medexamresult))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_medexamresult), ErrorMessageResourceName = "medexamresultdateRequired")]
        public DateTime ? medexamresultdate
        {
            get { return _medexamresultdate; }
            set { _medexamresultdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._tran_medexamresult))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "issoftdeleted", ResourceType = typeof(CLL.LLClasses.Models._tran_medexamresult))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_medexamresult), ErrorMessageResourceName = "issoftdeletedRequired")]
        public bool ? issoftdeleted
        {
            get { return _issoftdeleted; }
            set { _issoftdeleted = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._tran_medexamresult))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._tran_medexamresult))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public tran_medexamresultEntity():base()
        {
        }
        
        public tran_medexamresultEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public tran_medexamresultEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("MedExamResultID"))) _medexamresultid = reader.GetInt64(reader.GetOrdinal("MedExamResultID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) _registrationid = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedExamResult"))) _medexamresult = reader.GetInt32(reader.GetOrdinal("MedExamResult"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedExamComment"))) _medexamcomment = reader.GetString(reader.GetOrdinal("MedExamComment"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedExamResultDate"))) _medexamresultdate = reader.GetDateTime(reader.GetOrdinal("MedExamResultDate"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("MedExamResultID"))) _medexamresultid = reader.GetInt64(reader.GetOrdinal("MedExamResultID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) _registrationid = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedExamResult"))) _medexamresult = reader.GetInt32(reader.GetOrdinal("MedExamResult"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedExamComment"))) _medexamcomment = reader.GetString(reader.GetOrdinal("MedExamComment"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedExamResultDate"))) _medexamresultdate = reader.GetDateTime(reader.GetOrdinal("MedExamResultDate"));
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
