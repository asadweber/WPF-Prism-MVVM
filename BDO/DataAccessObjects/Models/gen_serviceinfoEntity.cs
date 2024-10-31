using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_serviceinfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_serviceinfoEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _serviceid;
        protected string _servicear;
        protected string _serviceen;
        protected string _descriptionar;
        protected string _descriptionen;
        protected bool ? _isactive;
                
        
        [DataMember]
        public long ? serviceid
        {
            get { return _serviceid; }
            set { _serviceid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "servicear", ResourceType = typeof(CLL.LLClasses.Models._gen_serviceinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_serviceinfo), ErrorMessageResourceName = "servicearRequired")]
        public string servicear
        {
            get { return _servicear; }
            set { _servicear = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "serviceen", ResourceType = typeof(CLL.LLClasses.Models._gen_serviceinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_serviceinfo), ErrorMessageResourceName = "serviceenRequired")]
        public string serviceen
        {
            get { return _serviceen; }
            set { _serviceen = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(-1)]
        [Display(Name = "descriptionar", ResourceType = typeof(CLL.LLClasses.Models._gen_serviceinfo))]
        public string descriptionar
        {
            get { return _descriptionar; }
            set { _descriptionar = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(-1)]
        [Display(Name = "descriptionen", ResourceType = typeof(CLL.LLClasses.Models._gen_serviceinfo))]
        public string descriptionen
        {
            get { return _descriptionen; }
            set { _descriptionen = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._gen_serviceinfo))]
        public bool ? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public gen_serviceinfoEntity():base()
        {
        }
        
        public gen_serviceinfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_serviceinfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceID"))) _serviceid = reader.GetInt64(reader.GetOrdinal("ServiceID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceAR"))) _servicear = reader.GetString(reader.GetOrdinal("ServiceAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceEN"))) _serviceen = reader.GetString(reader.GetOrdinal("ServiceEN"));
                if (!reader.IsDBNull(reader.GetOrdinal("DescriptionAR"))) _descriptionar = reader.GetString(reader.GetOrdinal("DescriptionAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("DescriptionEN"))) _descriptionen = reader.GetString(reader.GetOrdinal("DescriptionEN"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceAR"))) _servicear = reader.GetString(reader.GetOrdinal("ServiceAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceEN"))) _serviceen = reader.GetString(reader.GetOrdinal("ServiceEN"));
                if (!reader.IsDBNull(reader.GetOrdinal("DescriptionAR"))) _descriptionar = reader.GetString(reader.GetOrdinal("DescriptionAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("DescriptionEN"))) _descriptionen = reader.GetString(reader.GetOrdinal("DescriptionEN"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
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
