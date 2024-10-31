using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_certificatetypeEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_certificatetypeEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _certificatetypeid;
        protected string _certificatetype;
        protected string _certificatetypeeng;
        protected string _remarks;
        
        [DataMember]
        public long ? certificatetypeid
        {
            get { return _certificatetypeid; }
            set { _certificatetypeid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "certificatetype", ResourceType = typeof(CLL.LLClasses.Models._gen_certificatetype))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_certificatetype), ErrorMessageResourceName = "certificatetypeRequired")]
        public string certificatetype
        {
            get { return _certificatetype; }
            set { _certificatetype = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "certificatetypeeng", ResourceType = typeof(CLL.LLClasses.Models._gen_certificatetype))]
        public string certificatetypeeng
        {
            get { return _certificatetypeeng; }
            set { _certificatetypeeng = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._gen_certificatetype))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        #endregion
    
        #region Constructor
    
        public gen_certificatetypeEntity():base()
        {
        }
        
        public gen_certificatetypeEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_certificatetypeEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateTypeID"))) _certificatetypeid = reader.GetInt64(reader.GetOrdinal("CertificateTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateType"))) _certificatetype = reader.GetString(reader.GetOrdinal("CertificateType"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateTypeEng"))) _certificatetypeeng = reader.GetString(reader.GetOrdinal("CertificateTypeEng"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateTypeID"))) _certificatetypeid = reader.GetInt64(reader.GetOrdinal("CertificateTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateType"))) _certificatetype = reader.GetString(reader.GetOrdinal("CertificateType"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateTypeEng"))) _certificatetypeeng = reader.GetString(reader.GetOrdinal("CertificateTypeEng"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
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
