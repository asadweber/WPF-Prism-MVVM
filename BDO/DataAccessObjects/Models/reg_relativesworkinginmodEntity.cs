using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "reg_relativesworkinginmodEntity", Namespace = "http://www.KAF.com/types")]
    public partial class reg_relativesworkinginmodEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _regrelativesid;
        protected long ? _basicinfoid;
        protected long ? _imergencycontactid;
        protected long ? _relativemilorempno;
        protected long ? _relativeentitykey;
        protected string _relativeworkdesignation;
        protected string _relativecivilid;
        protected string _relativemobile1;
        protected string _remarks;
        protected string _updateinfo;
        protected long ? _tranformactionid;
                
        
        [DataMember]
        public long ? regrelativesid
        {
            get { return _regrelativesid; }
            set { _regrelativesid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "basicinfoid", ResourceType = typeof(CLL.LLClasses.Models._reg_relativesworkinginmod))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_relativesworkinginmod), ErrorMessageResourceName = "basicinfoidRequired")]
        public long ? basicinfoid
        {
            get { return _basicinfoid; }
            set { _basicinfoid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "imergencycontactid", ResourceType = typeof(CLL.LLClasses.Models._reg_relativesworkinginmod))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_relativesworkinginmod), ErrorMessageResourceName = "imergencycontactidRequired")]
        public long ? imergencycontactid
        {
            get { return _imergencycontactid; }
            set { _imergencycontactid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "relativemilorempno", ResourceType = typeof(CLL.LLClasses.Models._reg_relativesworkinginmod))]
        public long ? relativemilorempno
        {
            get { return _relativemilorempno; }
            set { _relativemilorempno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "relativeentitykey", ResourceType = typeof(CLL.LLClasses.Models._reg_relativesworkinginmod))]
        public long ? relativeentitykey
        {
            get { return _relativeentitykey; }
            set { _relativeentitykey = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "relativeworkdesignation", ResourceType = typeof(CLL.LLClasses.Models._reg_relativesworkinginmod))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_relativesworkinginmod), ErrorMessageResourceName = "relativeworkdesignationRequired")]
        public string relativeworkdesignation
        {
            get { return _relativeworkdesignation; }
            set { _relativeworkdesignation = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "relativecivilid", ResourceType = typeof(CLL.LLClasses.Models._reg_relativesworkinginmod))]
        public string relativecivilid
        {
            get { return _relativecivilid; }
            set { _relativecivilid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(15)]
        [Display(Name = "relativemobile1", ResourceType = typeof(CLL.LLClasses.Models._reg_relativesworkinginmod))]
        public string relativemobile1
        {
            get { return _relativemobile1; }
            set { _relativemobile1 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._reg_relativesworkinginmod))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._reg_relativesworkinginmod))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._reg_relativesworkinginmod))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public reg_relativesworkinginmodEntity():base()
        {
        }
        
        public reg_relativesworkinginmodEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public reg_relativesworkinginmodEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("RegRelativesID"))) _regrelativesid = reader.GetInt64(reader.GetOrdinal("RegRelativesID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ImergencyContactID"))) _imergencycontactid = reader.GetInt64(reader.GetOrdinal("ImergencyContactID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RelativeMilOrEmpNo"))) _relativemilorempno = reader.GetInt64(reader.GetOrdinal("RelativeMilOrEmpNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("RelativeEntityKey"))) _relativeentitykey = reader.GetInt64(reader.GetOrdinal("RelativeEntityKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("RelativeWorkDesignation"))) _relativeworkdesignation = reader.GetString(reader.GetOrdinal("RelativeWorkDesignation"));
                if (!reader.IsDBNull(reader.GetOrdinal("RelativeCivilID"))) _relativecivilid = reader.GetString(reader.GetOrdinal("RelativeCivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RelativeMobile1"))) _relativemobile1 = reader.GetString(reader.GetOrdinal("RelativeMobile1"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("RegRelativesID"))) _regrelativesid = reader.GetInt64(reader.GetOrdinal("RegRelativesID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ImergencyContactID"))) _imergencycontactid = reader.GetInt64(reader.GetOrdinal("ImergencyContactID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RelativeMilOrEmpNo"))) _relativemilorempno = reader.GetInt64(reader.GetOrdinal("RelativeMilOrEmpNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("RelativeEntityKey"))) _relativeentitykey = reader.GetInt64(reader.GetOrdinal("RelativeEntityKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("RelativeWorkDesignation"))) _relativeworkdesignation = reader.GetString(reader.GetOrdinal("RelativeWorkDesignation"));
                if (!reader.IsDBNull(reader.GetOrdinal("RelativeCivilID"))) _relativecivilid = reader.GetString(reader.GetOrdinal("RelativeCivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RelativeMobile1"))) _relativemobile1 = reader.GetString(reader.GetOrdinal("RelativeMobile1"));
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
