using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "tran_applicantretestapprovalEntity", Namespace = "http://www.KAF.com/types")]
    public partial class tran_applicantretestapprovalEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _retestapprovalid;
        protected long ? _basicinfoid;
        protected long ? _registrationid;
        protected long ? _resulttypeid;
        protected string ? _clearanceby;
        protected DateTime ? _clearancedate;
        protected string _remarks;
        protected long ? _statusid;
        protected string _updateinfo;
        protected long ? _tranformactionid;
                
        
        [DataMember]
        public long ? retestapprovalid
        {
            get { return _retestapprovalid; }
            set { _retestapprovalid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "basicinfoid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicantretestapproval))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicantretestapproval), ErrorMessageResourceName = "basicinfoidRequired")]
        public long ? basicinfoid
        {
            get { return _basicinfoid; }
            set { _basicinfoid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "registrationid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicantretestapproval))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicantretestapproval), ErrorMessageResourceName = "registrationidRequired")]
        public long ? registrationid
        {
            get { return _registrationid; }
            set { _registrationid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "resulttypeid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicantretestapproval))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicantretestapproval), ErrorMessageResourceName = "resulttypeidRequired")]
        public long ? resulttypeid
        {
            get { return _resulttypeid; }
            set { _resulttypeid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "clearanceby", ResourceType = typeof(CLL.LLClasses.Models._tran_applicantretestapproval))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicantretestapproval), ErrorMessageResourceName = "clearancebyRequired")]
        public string ? clearanceby
        {
            get { return _clearanceby; }
            set { _clearanceby = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "clearancedate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicantretestapproval))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicantretestapproval), ErrorMessageResourceName = "clearancedateRequired")]
        public DateTime ? clearancedate
        {
            get { return _clearancedate; }
            set { _clearancedate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._tran_applicantretestapproval))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "statusid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicantretestapproval))]
        public long ? statusid
        {
            get { return _statusid; }
            set { _statusid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._tran_applicantretestapproval))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicantretestapproval))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public tran_applicantretestapprovalEntity():base()
        {
        }
        
        public tran_applicantretestapprovalEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public tran_applicantretestapprovalEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("ReTestApprovalID"))) _retestapprovalid = reader.GetInt64(reader.GetOrdinal("ReTestApprovalID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) _registrationid = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ResultTypeID"))) _resulttypeid = reader.GetInt64(reader.GetOrdinal("ResultTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ClearanceBy"))) _clearanceby = reader.GetString(reader.GetOrdinal("ClearanceBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ClearanceDate"))) _clearancedate = reader.GetDateTime(reader.GetOrdinal("ClearanceDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusID"))) _statusid = reader.GetInt64(reader.GetOrdinal("StatusID"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("ReTestApprovalID"))) _retestapprovalid = reader.GetInt64(reader.GetOrdinal("ReTestApprovalID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) _registrationid = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ResultTypeID"))) _resulttypeid = reader.GetInt64(reader.GetOrdinal("ResultTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ClearanceBy"))) _clearanceby = reader.GetString(reader.GetOrdinal("ClearanceBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ClearanceDate"))) _clearancedate = reader.GetDateTime(reader.GetOrdinal("ClearanceDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusID"))) _statusid = reader.GetInt64(reader.GetOrdinal("StatusID"));
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
