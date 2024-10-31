using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "reg_emergencycontactinfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class reg_emergencycontactinfoEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _emergencycontactid;
        protected long ? _basicinfoid;
        protected long ? _familyid;
        protected string _name1;
        protected string _name2;
        protected string _name3;
        protected string _name4;
        protected string _name5;
        protected string _fullname;
        protected string _mobile1;
        protected string _mobile2;
        protected string _telephone1;
        protected string _telephone2;
        protected string _email;
        protected string _comment;
        protected string _remarks;
        protected string _updateinfo;
        protected long ? _tranformactionid;
                
        
        [DataMember]
        public long ? emergencycontactid
        {
            get { return _emergencycontactid; }
            set { _emergencycontactid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "basicinfoid", ResourceType = typeof(CLL.LLClasses.Models._reg_emergencycontactinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_emergencycontactinfo), ErrorMessageResourceName = "basicinfoidRequired")]
        public long ? basicinfoid
        {
            get { return _basicinfoid; }
            set { _basicinfoid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familyid", ResourceType = typeof(CLL.LLClasses.Models._reg_emergencycontactinfo))]
        public long ? familyid
        {
            get { return _familyid; }
            set { _familyid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "name1", ResourceType = typeof(CLL.LLClasses.Models._reg_emergencycontactinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_emergencycontactinfo), ErrorMessageResourceName = "name1Required")]
        public string name1
        {
            get { return _name1; }
            set { _name1 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_emergencycontactinfo), ErrorMessageResourceName = "name2Required")]
        [Display(Name = "name2", ResourceType = typeof(CLL.LLClasses.Models._reg_emergencycontactinfo))]
        public string name2
        {
            get { return _name2; }
            set { _name2 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "name3", ResourceType = typeof(CLL.LLClasses.Models._reg_emergencycontactinfo))]
        public string name3
        {
            get { return _name3; }
            set { _name3 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "name4", ResourceType = typeof(CLL.LLClasses.Models._reg_emergencycontactinfo))]
        public string name4
        {
            get { return _name4; }
            set { _name4 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "name5", ResourceType = typeof(CLL.LLClasses.Models._reg_emergencycontactinfo))]
        public string name5
        {
            get { return _name5; }
            set { _name5 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "fullname", ResourceType = typeof(CLL.LLClasses.Models._reg_emergencycontactinfo))]
        public string fullname
        {
            get { return $"{name1} {name2} {name3} {name4} {name5}"; }
            set { _fullname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(10)]
        [Display(Name = "mobile1", ResourceType = typeof(CLL.LLClasses.Models._reg_emergencycontactinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_emergencycontactinfo), ErrorMessageResourceName = "mobile1Required")]
        public string mobile1
        {
            get { return _mobile1; }
            set { _mobile1 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "mobile2", ResourceType = typeof(CLL.LLClasses.Models._reg_emergencycontactinfo))]
        public string mobile2
        {
            get { return _mobile2; }
            set { _mobile2 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "telephone1", ResourceType = typeof(CLL.LLClasses.Models._reg_emergencycontactinfo))]
        public string telephone1
        {
            get { return _telephone1; }
            set { _telephone1 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "telephone2", ResourceType = typeof(CLL.LLClasses.Models._reg_emergencycontactinfo))]
        public string telephone2
        {
            get { return _telephone2; }
            set { _telephone2 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "email", ResourceType = typeof(CLL.LLClasses.Models._reg_emergencycontactinfo))]
        public string email
        {
            get { return _email; }
            set { _email = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "comment", ResourceType = typeof(CLL.LLClasses.Models._reg_emergencycontactinfo))]
        public string comment
        {
            get { return _comment; }
            set { _comment = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._reg_emergencycontactinfo))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._reg_emergencycontactinfo))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._reg_emergencycontactinfo))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public reg_emergencycontactinfoEntity():base()
        {
        }
        
        public reg_emergencycontactinfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public reg_emergencycontactinfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("EmergencyContactID"))) _emergencycontactid = reader.GetInt64(reader.GetOrdinal("EmergencyContactID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyID"))) _familyid = reader.GetInt64(reader.GetOrdinal("FamilyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name1"))) _name1 = reader.GetString(reader.GetOrdinal("Name1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name2"))) _name2 = reader.GetString(reader.GetOrdinal("Name2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name3"))) _name3 = reader.GetString(reader.GetOrdinal("Name3"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name4"))) _name4 = reader.GetString(reader.GetOrdinal("Name4"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name5"))) _name5 = reader.GetString(reader.GetOrdinal("Name5"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Mobile1"))) _mobile1 = reader.GetString(reader.GetOrdinal("Mobile1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Mobile2"))) _mobile2 = reader.GetString(reader.GetOrdinal("Mobile2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Telephone1"))) _telephone1 = reader.GetString(reader.GetOrdinal("Telephone1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Telephone2"))) _telephone2 = reader.GetString(reader.GetOrdinal("Telephone2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Email"))) _email = reader.GetString(reader.GetOrdinal("Email"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("EmergencyContactID"))) _emergencycontactid = reader.GetInt64(reader.GetOrdinal("EmergencyContactID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyID"))) _familyid = reader.GetInt64(reader.GetOrdinal("FamilyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name1"))) _name1 = reader.GetString(reader.GetOrdinal("Name1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name2"))) _name2 = reader.GetString(reader.GetOrdinal("Name2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name3"))) _name3 = reader.GetString(reader.GetOrdinal("Name3"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name4"))) _name4 = reader.GetString(reader.GetOrdinal("Name4"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name5"))) _name5 = reader.GetString(reader.GetOrdinal("Name5"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Mobile1"))) _mobile1 = reader.GetString(reader.GetOrdinal("Mobile1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Mobile2"))) _mobile2 = reader.GetString(reader.GetOrdinal("Mobile2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Telephone1"))) _telephone1 = reader.GetString(reader.GetOrdinal("Telephone1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Telephone2"))) _telephone2 = reader.GetString(reader.GetOrdinal("Telephone2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Email"))) _email = reader.GetString(reader.GetOrdinal("Email"));
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
