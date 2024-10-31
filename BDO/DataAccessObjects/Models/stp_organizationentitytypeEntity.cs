using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "stp_organizationentitytypeEntity", Namespace = "http://www.KAF.com/types")]
    public partial class stp_organizationentitytypeEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _entirytypekey;
        protected long ? _organizationkey;
        protected string _entirytypecode;
        protected string _entirytype;
        protected string _description;
        protected int ? _entitylevel;
        protected bool ? _isactive;
        protected string _updateinfo;
        protected long ? _tranformactionid;
                
        
        [DataMember]
        public long ? entirytypekey
        {
            get { return _entirytypekey; }
            set { _entirytypekey = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "organizationkey", ResourceType = typeof(CLL.LLClasses.Models._stp_organizationentitytype))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._stp_organizationentitytype), ErrorMessageResourceName = "organizationkeyRequired")]
        public long ? organizationkey
        {
            get { return _organizationkey; }
            set { _organizationkey = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "entirytypecode", ResourceType = typeof(CLL.LLClasses.Models._stp_organizationentitytype))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._stp_organizationentitytype), ErrorMessageResourceName = "entirytypecodeRequired")]
        public string entirytypecode
        {
            get { return _entirytypecode; }
            set { _entirytypecode = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "entirytype", ResourceType = typeof(CLL.LLClasses.Models._stp_organizationentitytype))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._stp_organizationentitytype), ErrorMessageResourceName = "entirytypeRequired")]
        public string entirytype
        {
            get { return _entirytype; }
            set { _entirytype = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(350)]
        [Display(Name = "description", ResourceType = typeof(CLL.LLClasses.Models._stp_organizationentitytype))]
        public string description
        {
            get { return _description; }
            set { _description = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "entitylevel", ResourceType = typeof(CLL.LLClasses.Models._stp_organizationentitytype))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._stp_organizationentitytype), ErrorMessageResourceName = "entitylevelRequired")]
        public int ? entitylevel
        {
            get { return _entitylevel; }
            set { _entitylevel = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._stp_organizationentitytype))]
        public bool ? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._stp_organizationentitytype))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._stp_organizationentitytype))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public stp_organizationentitytypeEntity():base()
        {
        }
        
        public stp_organizationentitytypeEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public stp_organizationentitytypeEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("EntiryTypeKey"))) _entirytypekey = reader.GetInt64(reader.GetOrdinal("EntiryTypeKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrganizationKey"))) _organizationkey = reader.GetInt64(reader.GetOrdinal("OrganizationKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntiryTypeCode"))) _entirytypecode = reader.GetString(reader.GetOrdinal("EntiryTypeCode"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntiryType"))) _entirytype = reader.GetString(reader.GetOrdinal("EntiryType"));
                if (!reader.IsDBNull(reader.GetOrdinal("Description"))) _description = reader.GetString(reader.GetOrdinal("Description"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntityLevel"))) _entitylevel = reader.GetInt32(reader.GetOrdinal("EntityLevel"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("EntiryTypeKey"))) _entirytypekey = reader.GetInt64(reader.GetOrdinal("EntiryTypeKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrganizationKey"))) _organizationkey = reader.GetInt64(reader.GetOrdinal("OrganizationKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntiryTypeCode"))) _entirytypecode = reader.GetString(reader.GetOrdinal("EntiryTypeCode"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntiryType"))) _entirytype = reader.GetString(reader.GetOrdinal("EntiryType"));
                if (!reader.IsDBNull(reader.GetOrdinal("Description"))) _description = reader.GetString(reader.GetOrdinal("Description"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntityLevel"))) _entitylevel = reader.GetInt32(reader.GetOrdinal("EntityLevel"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
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
