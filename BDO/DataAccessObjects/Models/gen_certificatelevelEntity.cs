using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_certificatelevelEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_certificatelevelEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _certificatelevelid;
        protected string _certificatelevel;
        protected string _certificateleveleng;
        protected long ? _educationtypeid;
        protected string _remarks;
        protected int ? _displayorder;
        protected string _updateinfo;
        protected long ? _tranformactionid;
                
        
        [DataMember]
        public long ? certificatelevelid
        {
            get { return _certificatelevelid; }
            set { _certificatelevelid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(100)]
        [Display(Name = "certificatelevel", ResourceType = typeof(CLL.LLClasses.Models._gen_certificatelevel))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_certificatelevel), ErrorMessageResourceName = "certificatelevelRequired")]
        public string certificatelevel
        {
            get { return _certificatelevel; }
            set { _certificatelevel = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(100)]
        [Display(Name = "certificateleveleng", ResourceType = typeof(CLL.LLClasses.Models._gen_certificatelevel))]
        public string certificateleveleng
        {
            get { return _certificateleveleng; }
            set { _certificateleveleng = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "educationtypeid", ResourceType = typeof(CLL.LLClasses.Models._gen_certificatelevel))]
        public long ? educationtypeid
        {
            get { return _educationtypeid; }
            set { _educationtypeid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._gen_certificatelevel))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "displayorder", ResourceType = typeof(CLL.LLClasses.Models._gen_certificatelevel))]
        public int ? displayorder
        {
            get { return _displayorder; }
            set { _displayorder = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._gen_certificatelevel))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._gen_certificatelevel))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public gen_certificatelevelEntity():base()
        {
        }
        
        public gen_certificatelevelEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_certificatelevelEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateLevelID"))) _certificatelevelid = reader.GetInt64(reader.GetOrdinal("CertificateLevelID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateLevel"))) _certificatelevel = reader.GetString(reader.GetOrdinal("CertificateLevel"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateLevelEng"))) _certificateleveleng = reader.GetString(reader.GetOrdinal("CertificateLevelEng"));
                if (!reader.IsDBNull(reader.GetOrdinal("EducationTypeID"))) _educationtypeid = reader.GetInt64(reader.GetOrdinal("EducationTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("DisplayOrder"))) _displayorder = reader.GetInt32(reader.GetOrdinal("DisplayOrder"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateLevelID"))) _certificatelevelid = reader.GetInt64(reader.GetOrdinal("CertificateLevelID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateLevel"))) _certificatelevel = reader.GetString(reader.GetOrdinal("CertificateLevel"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateLevelEng"))) _certificateleveleng = reader.GetString(reader.GetOrdinal("CertificateLevelEng"));
                if (!reader.IsDBNull(reader.GetOrdinal("EducationTypeID"))) _educationtypeid = reader.GetInt64(reader.GetOrdinal("EducationTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("DisplayOrder"))) _displayorder = reader.GetInt32(reader.GetOrdinal("DisplayOrder"));
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
