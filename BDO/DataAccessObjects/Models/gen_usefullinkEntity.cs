using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_usefullinkEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_usefullinkEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _usefullinkid;
        protected long ? _usefullinkcategoryid;
        protected string _usefullink;
        protected string _usefullinkar;
        protected string _servicelogopath;
        protected string _usefullinkurl;
        protected bool ? _openinnewtab;
        protected string _usefullinkdescription;
        protected string _usefullinkdescriptionar;
                
        
        [DataMember]
        public long ? usefullinkid
        {
            get { return _usefullinkid; }
            set { _usefullinkid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "usefullinkcategoryid", ResourceType = typeof(CLL.LLClasses.Models._gen_usefullink))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_usefullink), ErrorMessageResourceName = "usefullinkcategoryidRequired")]
        public long ? usefullinkcategoryid
        {
            get { return _usefullinkcategoryid; }
            set { _usefullinkcategoryid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "usefullink", ResourceType = typeof(CLL.LLClasses.Models._gen_usefullink))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_usefullink), ErrorMessageResourceName = "usefullinkRequired")]
        public string usefullink
        {
            get { return _usefullink; }
            set { _usefullink = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "usefullinkar", ResourceType = typeof(CLL.LLClasses.Models._gen_usefullink))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_usefullink), ErrorMessageResourceName = "usefullinkarRequired")]
        public string usefullinkar
        {
            get { return _usefullinkar; }
            set { _usefullinkar = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "servicelogopath", ResourceType = typeof(CLL.LLClasses.Models._gen_usefullink))]
        public string servicelogopath
        {
            get { return _servicelogopath; }
            set { _servicelogopath = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "usefullinkurl", ResourceType = typeof(CLL.LLClasses.Models._gen_usefullink))]
        public string usefullinkurl
        {
            get { return _usefullinkurl; }
            set { _usefullinkurl = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "openinnewtab", ResourceType = typeof(CLL.LLClasses.Models._gen_usefullink))]
        public bool ? openinnewtab
        {
            get { return _openinnewtab; }
            set { _openinnewtab = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "usefullinkdescription", ResourceType = typeof(CLL.LLClasses.Models._gen_usefullink))]
        public string usefullinkdescription
        {
            get { return _usefullinkdescription; }
            set { _usefullinkdescription = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "usefullinkdescriptionar", ResourceType = typeof(CLL.LLClasses.Models._gen_usefullink))]
        public string usefullinkdescriptionar
        {
            get { return _usefullinkdescriptionar; }
            set { _usefullinkdescriptionar = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public gen_usefullinkEntity():base()
        {
        }
        
        public gen_usefullinkEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_usefullinkEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("UsefulLinkID"))) _usefullinkid = reader.GetInt64(reader.GetOrdinal("UsefulLinkID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UsefulLinkCategoryID"))) _usefullinkcategoryid = reader.GetInt64(reader.GetOrdinal("UsefulLinkCategoryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UsefulLink"))) _usefullink = reader.GetString(reader.GetOrdinal("UsefulLink"));
                if (!reader.IsDBNull(reader.GetOrdinal("UsefulLinkAR"))) _usefullinkar = reader.GetString(reader.GetOrdinal("UsefulLinkAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceLogoPath"))) _servicelogopath = reader.GetString(reader.GetOrdinal("ServiceLogoPath"));
                if (!reader.IsDBNull(reader.GetOrdinal("UsefulLinkURL"))) _usefullinkurl = reader.GetString(reader.GetOrdinal("UsefulLinkURL"));
                if (!reader.IsDBNull(reader.GetOrdinal("OpenInNewTab"))) _openinnewtab = reader.GetBoolean(reader.GetOrdinal("OpenInNewTab"));
                if (!reader.IsDBNull(reader.GetOrdinal("UsefulLinkDescription"))) _usefullinkdescription = reader.GetString(reader.GetOrdinal("UsefulLinkDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("UsefulLinkDescriptionAR"))) _usefullinkdescriptionar = reader.GetString(reader.GetOrdinal("UsefulLinkDescriptionAR"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("UsefulLinkID"))) _usefullinkid = reader.GetInt64(reader.GetOrdinal("UsefulLinkID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UsefulLinkCategoryID"))) _usefullinkcategoryid = reader.GetInt64(reader.GetOrdinal("UsefulLinkCategoryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UsefulLink"))) _usefullink = reader.GetString(reader.GetOrdinal("UsefulLink"));
                if (!reader.IsDBNull(reader.GetOrdinal("UsefulLinkAR"))) _usefullinkar = reader.GetString(reader.GetOrdinal("UsefulLinkAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceLogoPath"))) _servicelogopath = reader.GetString(reader.GetOrdinal("ServiceLogoPath"));
                if (!reader.IsDBNull(reader.GetOrdinal("UsefulLinkURL"))) _usefullinkurl = reader.GetString(reader.GetOrdinal("UsefulLinkURL"));
                if (!reader.IsDBNull(reader.GetOrdinal("OpenInNewTab"))) _openinnewtab = reader.GetBoolean(reader.GetOrdinal("OpenInNewTab"));
                if (!reader.IsDBNull(reader.GetOrdinal("UsefulLinkDescription"))) _usefullinkdescription = reader.GetString(reader.GetOrdinal("UsefulLinkDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("UsefulLinkDescriptionAR"))) _usefullinkdescriptionar = reader.GetString(reader.GetOrdinal("UsefulLinkDescriptionAR"));
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
