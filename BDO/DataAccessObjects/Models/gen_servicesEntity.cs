using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_servicesEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_servicesEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _serviceid;
        protected long ? _servicetypeid;
        protected string _servicename;
        protected string _servicenamear;
        protected string _servicedescription;
        protected string _servicedescriptionar;
        protected string _servicelogopath;
        protected string _serviceurl;
                
        
        [DataMember]
        public long ? serviceid
        {
            get { return _serviceid; }
            set { _serviceid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "servicetypeid", ResourceType = typeof(CLL.LLClasses.Models._gen_services))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_services), ErrorMessageResourceName = "servicetypeidRequired")]
        public long ? servicetypeid
        {
            get { return _servicetypeid; }
            set { _servicetypeid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "servicename", ResourceType = typeof(CLL.LLClasses.Models._gen_services))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_services), ErrorMessageResourceName = "servicenameRequired")]
        public string servicename
        {
            get { return _servicename; }
            set { _servicename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "servicenamear", ResourceType = typeof(CLL.LLClasses.Models._gen_services))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_services), ErrorMessageResourceName = "servicenamearRequired")]
        public string servicenamear
        {
            get { return _servicenamear; }
            set { _servicenamear = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "servicedescription", ResourceType = typeof(CLL.LLClasses.Models._gen_services))]
        public string servicedescription
        {
            get { return _servicedescription; }
            set { _servicedescription = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "servicedescriptionar", ResourceType = typeof(CLL.LLClasses.Models._gen_services))]
        public string servicedescriptionar
        {
            get { return _servicedescriptionar; }
            set { _servicedescriptionar = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "servicelogopath", ResourceType = typeof(CLL.LLClasses.Models._gen_services))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_services), ErrorMessageResourceName = "servicelogopathRequired")]
        public string servicelogopath
        {
            get { return _servicelogopath; }
            set { _servicelogopath = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "serviceurl", ResourceType = typeof(CLL.LLClasses.Models._gen_services))]
        public string serviceurl
        {
            get { return _serviceurl; }
            set { _serviceurl = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public gen_servicesEntity():base()
        {
        }
        
        public gen_servicesEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_servicesEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceID"))) _serviceid = reader.GetInt64(reader.GetOrdinal("ServiceID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceTypeID"))) _servicetypeid = reader.GetInt64(reader.GetOrdinal("ServiceTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceName"))) _servicename = reader.GetString(reader.GetOrdinal("ServiceName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceNameAR"))) _servicenamear = reader.GetString(reader.GetOrdinal("ServiceNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceDescription"))) _servicedescription = reader.GetString(reader.GetOrdinal("ServiceDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceDescriptionAR"))) _servicedescriptionar = reader.GetString(reader.GetOrdinal("ServiceDescriptionAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceLogoPath"))) _servicelogopath = reader.GetString(reader.GetOrdinal("ServiceLogoPath"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceURL"))) _serviceurl = reader.GetString(reader.GetOrdinal("ServiceURL"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceID"))) _serviceid = reader.GetInt64(reader.GetOrdinal("ServiceID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceTypeID"))) _servicetypeid = reader.GetInt64(reader.GetOrdinal("ServiceTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceName"))) _servicename = reader.GetString(reader.GetOrdinal("ServiceName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceNameAR"))) _servicenamear = reader.GetString(reader.GetOrdinal("ServiceNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceDescription"))) _servicedescription = reader.GetString(reader.GetOrdinal("ServiceDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceDescriptionAR"))) _servicedescriptionar = reader.GetString(reader.GetOrdinal("ServiceDescriptionAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceLogoPath"))) _servicelogopath = reader.GetString(reader.GetOrdinal("ServiceLogoPath"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceURL"))) _serviceurl = reader.GetString(reader.GetOrdinal("ServiceURL"));
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
