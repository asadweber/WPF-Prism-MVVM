using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "stp_organizationentityEntity", Namespace = "http://www.KAF.com/types")]
    public partial class stp_organizationentityEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _entitykey;
        protected long ? _organizationkey;
        protected long ? _parentkey;
        protected long ? _entirytypekey;
        protected int ? _entitylevel;
        protected string _seqfirstindex;
        protected string _seqfullindex;
        protected string _entitycpde;
        protected string _entitytname;
        protected string _description;
        protected bool ? _isactive;
        protected string _updateinfo;
        protected long ? _tranformactionid;
                
        
        [DataMember]
        public long ? entitykey
        {
            get { return _entitykey; }
            set { _entitykey = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "organizationkey", ResourceType = typeof(CLL.LLClasses.Models._stp_organizationentity))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._stp_organizationentity), ErrorMessageResourceName = "organizationkeyRequired")]
        public long ? organizationkey
        {
            get { return _organizationkey; }
            set { _organizationkey = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "parentkey", ResourceType = typeof(CLL.LLClasses.Models._stp_organizationentity))]
        public long ? parentkey
        {
            get { return _parentkey; }
            set { _parentkey = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "entirytypekey", ResourceType = typeof(CLL.LLClasses.Models._stp_organizationentity))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._stp_organizationentity), ErrorMessageResourceName = "entirytypekeyRequired")]
        public long ? entirytypekey
        {
            get { return _entirytypekey; }
            set { _entirytypekey = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "entitylevel", ResourceType = typeof(CLL.LLClasses.Models._stp_organizationentity))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._stp_organizationentity), ErrorMessageResourceName = "entitylevelRequired")]
        public int ? entitylevel
        {
            get { return _entitylevel; }
            set { _entitylevel = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "seqfirstindex", ResourceType = typeof(CLL.LLClasses.Models._stp_organizationentity))]
        public string seqfirstindex
        {
            get { return _seqfirstindex; }
            set { _seqfirstindex = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "seqfullindex", ResourceType = typeof(CLL.LLClasses.Models._stp_organizationentity))]
        public string seqfullindex
        {
            get { return _seqfullindex; }
            set { _seqfullindex = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "entitycpde", ResourceType = typeof(CLL.LLClasses.Models._stp_organizationentity))]
        public string entitycpde
        {
            get { return _entitycpde; }
            set { _entitycpde = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "entitytname", ResourceType = typeof(CLL.LLClasses.Models._stp_organizationentity))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._stp_organizationentity), ErrorMessageResourceName = "entitytnameRequired")]
        public string entitytname
        {
            get { return _entitytname; }
            set { _entitytname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(350)]
        [Display(Name = "description", ResourceType = typeof(CLL.LLClasses.Models._stp_organizationentity))]
        public string description
        {
            get { return _description; }
            set { _description = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._stp_organizationentity))]
        public bool ? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._stp_organizationentity))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._stp_organizationentity))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public stp_organizationentityEntity():base()
        {
        }
        
        public stp_organizationentityEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public stp_organizationentityEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("EntityKey"))) _entitykey = reader.GetInt64(reader.GetOrdinal("EntityKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrganizationKey"))) _organizationkey = reader.GetInt64(reader.GetOrdinal("OrganizationKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("ParentKey"))) _parentkey = reader.GetInt64(reader.GetOrdinal("ParentKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntiryTypeKey"))) _entirytypekey = reader.GetInt64(reader.GetOrdinal("EntiryTypeKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntityLevel"))) _entitylevel = reader.GetInt32(reader.GetOrdinal("EntityLevel"));
                if (!reader.IsDBNull(reader.GetOrdinal("SeqFirstIndex"))) _seqfirstindex = reader.GetString(reader.GetOrdinal("SeqFirstIndex"));
                if (!reader.IsDBNull(reader.GetOrdinal("SeqFullIndex"))) _seqfullindex = reader.GetString(reader.GetOrdinal("SeqFullIndex"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntityCpde"))) _entitycpde = reader.GetString(reader.GetOrdinal("EntityCpde"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntitytName"))) _entitytname = reader.GetString(reader.GetOrdinal("EntitytName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Description"))) _description = reader.GetString(reader.GetOrdinal("Description"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("EntityKey"))) _entitykey = reader.GetInt64(reader.GetOrdinal("EntityKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrganizationKey"))) _organizationkey = reader.GetInt64(reader.GetOrdinal("OrganizationKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("ParentKey"))) _parentkey = reader.GetInt64(reader.GetOrdinal("ParentKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntiryTypeKey"))) _entirytypekey = reader.GetInt64(reader.GetOrdinal("EntiryTypeKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntityLevel"))) _entitylevel = reader.GetInt32(reader.GetOrdinal("EntityLevel"));
                if (!reader.IsDBNull(reader.GetOrdinal("SeqFirstIndex"))) _seqfirstindex = reader.GetString(reader.GetOrdinal("SeqFirstIndex"));
                if (!reader.IsDBNull(reader.GetOrdinal("SeqFullIndex"))) _seqfullindex = reader.GetString(reader.GetOrdinal("SeqFullIndex"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntityCpde"))) _entitycpde = reader.GetString(reader.GetOrdinal("EntityCpde"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntitytName"))) _entitytname = reader.GetString(reader.GetOrdinal("EntitytName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Description"))) _description = reader.GetString(reader.GetOrdinal("Description"));
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
