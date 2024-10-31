using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_servicestypeEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_servicestypeEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _servicetypeid;
        protected string _servicetypear;
        protected string _descriptionar;
        protected string _servicetype;
        protected string _description;
                
        
        [DataMember]
        public long ? servicetypeid
        {
            get { return _servicetypeid; }
            set { _servicetypeid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "servicetypear", ResourceType = typeof(CLL.LLClasses.Models._gen_servicestype))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_servicestype), ErrorMessageResourceName = "servicetypearRequired")]
        public string servicetypear
        {
            get { return _servicetypear; }
            set { _servicetypear = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "descriptionar", ResourceType = typeof(CLL.LLClasses.Models._gen_servicestype))]
        public string descriptionar
        {
            get { return _descriptionar; }
            set { _descriptionar = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "servicetype", ResourceType = typeof(CLL.LLClasses.Models._gen_servicestype))]
        public string servicetype
        {
            get { return _servicetype; }
            set { _servicetype = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "description", ResourceType = typeof(CLL.LLClasses.Models._gen_servicestype))]
        public string description
        {
            get { return _description; }
            set { _description = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public gen_servicestypeEntity():base()
        {
        }
        
        public gen_servicestypeEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_servicestypeEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceTypeID"))) _servicetypeid = reader.GetInt64(reader.GetOrdinal("ServiceTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceTypeAR"))) _servicetypear = reader.GetString(reader.GetOrdinal("ServiceTypeAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("DescriptionAR"))) _descriptionar = reader.GetString(reader.GetOrdinal("DescriptionAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceType"))) _servicetype = reader.GetString(reader.GetOrdinal("ServiceType"));
                if (!reader.IsDBNull(reader.GetOrdinal("Description"))) _description = reader.GetString(reader.GetOrdinal("Description"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceTypeID"))) _servicetypeid = reader.GetInt64(reader.GetOrdinal("ServiceTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceTypeAR"))) _servicetypear = reader.GetString(reader.GetOrdinal("ServiceTypeAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("DescriptionAR"))) _descriptionar = reader.GetString(reader.GetOrdinal("DescriptionAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceType"))) _servicetype = reader.GetString(reader.GetOrdinal("ServiceType"));
                if (!reader.IsDBNull(reader.GetOrdinal("Description"))) _description = reader.GetString(reader.GetOrdinal("Description"));
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
