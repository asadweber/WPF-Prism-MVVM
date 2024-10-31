using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_servicestatusEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_servicestatusEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _servicestatusid;
        protected string _servicestatusar;
        protected string _servicestatusen;
        protected string _descriptionar;
        protected string _descriptionen;
        protected bool ? _isactive;
                
        
        [DataMember]
        public long ? servicestatusid
        {
            get { return _servicestatusid; }
            set { _servicestatusid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "servicestatusar", ResourceType = typeof(CLL.LLClasses.Models._gen_servicestatus))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_servicestatus), ErrorMessageResourceName = "servicestatusarRequired")]
        public string servicestatusar
        {
            get { return _servicestatusar; }
            set { _servicestatusar = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "servicestatusen", ResourceType = typeof(CLL.LLClasses.Models._gen_servicestatus))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_servicestatus), ErrorMessageResourceName = "servicestatusenRequired")]
        public string servicestatusen
        {
            get { return _servicestatusen; }
            set { _servicestatusen = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(-1)]
        [Display(Name = "descriptionar", ResourceType = typeof(CLL.LLClasses.Models._gen_servicestatus))]
        public string descriptionar
        {
            get { return _descriptionar; }
            set { _descriptionar = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(-1)]
        [Display(Name = "descriptionen", ResourceType = typeof(CLL.LLClasses.Models._gen_servicestatus))]
        public string descriptionen
        {
            get { return _descriptionen; }
            set { _descriptionen = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._gen_servicestatus))]
        public bool ? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public gen_servicestatusEntity():base()
        {
        }
        
        public gen_servicestatusEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_servicestatusEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceStatusID"))) _servicestatusid = reader.GetInt64(reader.GetOrdinal("ServiceStatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceStatusAR"))) _servicestatusar = reader.GetString(reader.GetOrdinal("ServiceStatusAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceStatusEN"))) _servicestatusen = reader.GetString(reader.GetOrdinal("ServiceStatusEN"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceStatusID"))) _servicestatusid = reader.GetInt64(reader.GetOrdinal("ServiceStatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceStatusAR"))) _servicestatusar = reader.GetString(reader.GetOrdinal("ServiceStatusAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceStatusEN"))) _servicestatusen = reader.GetString(reader.GetOrdinal("ServiceStatusEN"));
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
