using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "reg_datacheckedEntity", Namespace = "http://www.KAF.com/types")]
    public partial class reg_datacheckedEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _basicinfoviewid;
        protected long ? _basicinfoid;
        protected long ? _registrationid;
        protected long ? _applicanttableid;
        protected Guid ? _reviewedbyid;
        protected DateTime ? _vieweddate;
        protected bool ? _ischecked;
        protected bool ? _isactive;
        protected string _comment;
                
        
        [DataMember]
        [Display(Name = "basicinfoviewid", ResourceType = typeof(CLL.LLClasses.Models._reg_datachecked))]
        public long ? basicinfoviewid
        {
            get { return _basicinfoviewid; }
            set { _basicinfoviewid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "basicinfoid", ResourceType = typeof(CLL.LLClasses.Models._reg_datachecked))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_datachecked), ErrorMessageResourceName = "basicinfoidRequired")]
        public long ? basicinfoid
        {
            get { return _basicinfoid; }
            set { _basicinfoid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "registrationid", ResourceType = typeof(CLL.LLClasses.Models._reg_datachecked))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_datachecked), ErrorMessageResourceName = "registrationidRequired")]
        public long ? registrationid
        {
            get { return _registrationid; }
            set { _registrationid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "applicanttableid", ResourceType = typeof(CLL.LLClasses.Models._reg_datachecked))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_datachecked), ErrorMessageResourceName = "applicanttableidRequired")]
        public long ? applicanttableid
        {
            get { return _applicanttableid; }
            set { _applicanttableid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "reviewedbyid", ResourceType = typeof(CLL.LLClasses.Models._reg_datachecked))]
        public Guid ? reviewedbyid
        {
            get { return _reviewedbyid; }
            set { _reviewedbyid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "vieweddate", ResourceType = typeof(CLL.LLClasses.Models._reg_datachecked))]
        public DateTime ? vieweddate
        {
            get { return _vieweddate; }
            set { _vieweddate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "ischecked", ResourceType = typeof(CLL.LLClasses.Models._reg_datachecked))]
        public bool ? ischecked
        {
            get { return _ischecked; }
            set { _ischecked = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._reg_datachecked))]
        public bool ? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "comment", ResourceType = typeof(CLL.LLClasses.Models._reg_datachecked))]
        public string comment
        {
            get { return _comment; }
            set { _comment = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public reg_datacheckedEntity():base()
        {
        }
        
        public reg_datacheckedEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public reg_datacheckedEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }

        public reg_datacheckedEntity(IDataReader reader, int e)
        {
            this.LoadFromReader(reader, e);
        }



        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoViewID"))) _basicinfoviewid = reader.GetInt64(reader.GetOrdinal("BasicInfoViewID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) _registrationid = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicantTableID"))) _applicanttableid = reader.GetInt64(reader.GetOrdinal("ApplicantTableID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedByID"))) _reviewedbyid = reader.GetGuid(reader.GetOrdinal("ReviewedByID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ViewedDate"))) _vieweddate = reader.GetDateTime(reader.GetOrdinal("ViewedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsChecked"))) _ischecked = reader.GetBoolean(reader.GetOrdinal("IsChecked"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoViewID"))) _basicinfoviewid = reader.GetInt64(reader.GetOrdinal("BasicInfoViewID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) _registrationid = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicantTableID"))) _applicanttableid = reader.GetInt64(reader.GetOrdinal("ApplicantTableID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedByID"))) _reviewedbyid = reader.GetGuid(reader.GetOrdinal("ReviewedByID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ViewedDate"))) _vieweddate = reader.GetDateTime(reader.GetOrdinal("ViewedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsChecked"))) _ischecked = reader.GetBoolean(reader.GetOrdinal("IsChecked"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
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
