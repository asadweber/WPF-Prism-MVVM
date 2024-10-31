using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "tran_unitclearanceresultEntity", Namespace = "http://www.KAF.com/types")]
    public partial class tran_unitclearanceresultEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _unitclearanceresultid;
        protected long ? _basicinfoid;
        protected long ? _registrationid;
        protected int ? _unitclearanceresult;
        protected string _unitclearancecomment;
        protected DateTime ? _unitclearanceresultdate;
        protected decimal ? _unitclearancemarks;
        protected string _remarks;
        protected bool ? _issoftdeleted;
        protected string _updateinfo;
        protected long ? _tranformactionid;
                
        
        [DataMember]
        public long ? unitclearanceresultid
        {
            get { return _unitclearanceresultid; }
            set { _unitclearanceresultid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "basicinfoid", ResourceType = typeof(CLL.LLClasses.Models._tran_unitclearanceresult))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_unitclearanceresult), ErrorMessageResourceName = "basicinfoidRequired")]
        public long ? basicinfoid
        {
            get { return _basicinfoid; }
            set { _basicinfoid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "registrationid", ResourceType = typeof(CLL.LLClasses.Models._tran_unitclearanceresult))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_unitclearanceresult), ErrorMessageResourceName = "registrationidRequired")]
        public long ? registrationid
        {
            get { return _registrationid; }
            set { _registrationid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "unitclearanceresult", ResourceType = typeof(CLL.LLClasses.Models._tran_unitclearanceresult))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_unitclearanceresult), ErrorMessageResourceName = "unitclearanceresultRequired")]
        public int ? unitclearanceresult
        {
            get { return _unitclearanceresult; }
            set { _unitclearanceresult = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "unitclearancecomment", ResourceType = typeof(CLL.LLClasses.Models._tran_unitclearanceresult))]
        public string unitclearancecomment
        {
            get { return _unitclearancecomment; }
            set { _unitclearancecomment = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "unitclearanceresultdate", ResourceType = typeof(CLL.LLClasses.Models._tran_unitclearanceresult))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_unitclearanceresult), ErrorMessageResourceName = "unitclearanceresultdateRequired")]
        public DateTime ? unitclearanceresultdate
        {
            get { return _unitclearanceresultdate; }
            set { _unitclearanceresultdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "unitclearancemarks", ResourceType = typeof(CLL.LLClasses.Models._tran_unitclearanceresult))]
        public decimal ? unitclearancemarks
        {
            get { return _unitclearancemarks; }
            set { _unitclearancemarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._tran_unitclearanceresult))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "issoftdeleted", ResourceType = typeof(CLL.LLClasses.Models._tran_unitclearanceresult))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_unitclearanceresult), ErrorMessageResourceName = "issoftdeletedRequired")]
        public bool ? issoftdeleted
        {
            get { return _issoftdeleted; }
            set { _issoftdeleted = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._tran_unitclearanceresult))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._tran_unitclearanceresult))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public tran_unitclearanceresultEntity():base()
        {
        }
        
        public tran_unitclearanceresultEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public tran_unitclearanceresultEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("UnitClearanceResultID"))) _unitclearanceresultid = reader.GetInt64(reader.GetOrdinal("UnitClearanceResultID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) _registrationid = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UnitClearanceResult"))) _unitclearanceresult = reader.GetInt32(reader.GetOrdinal("UnitClearanceResult"));
                if (!reader.IsDBNull(reader.GetOrdinal("UnitClearanceComment"))) _unitclearancecomment = reader.GetString(reader.GetOrdinal("UnitClearanceComment"));
                if (!reader.IsDBNull(reader.GetOrdinal("UnitClearanceResultDate"))) _unitclearanceresultdate = reader.GetDateTime(reader.GetOrdinal("UnitClearanceResultDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UnitClearanceMarks"))) _unitclearancemarks = reader.GetDecimal(reader.GetOrdinal("UnitClearanceMarks"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("UnitClearanceResultID"))) _unitclearanceresultid = reader.GetInt64(reader.GetOrdinal("UnitClearanceResultID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) _registrationid = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UnitClearanceResult"))) _unitclearanceresult = reader.GetInt32(reader.GetOrdinal("UnitClearanceResult"));
                if (!reader.IsDBNull(reader.GetOrdinal("UnitClearanceComment"))) _unitclearancecomment = reader.GetString(reader.GetOrdinal("UnitClearanceComment"));
                if (!reader.IsDBNull(reader.GetOrdinal("UnitClearanceResultDate"))) _unitclearanceresultdate = reader.GetDateTime(reader.GetOrdinal("UnitClearanceResultDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UnitClearanceMarks"))) _unitclearancemarks = reader.GetDecimal(reader.GetOrdinal("UnitClearanceMarks"));
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
