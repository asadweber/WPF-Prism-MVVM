using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_batchcandidatecertificateEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_batchcandidatecertificateEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _batchcandcertificateid;
        protected long ? _batchcandidatetypemapid;
        protected long ? _certificatelevelid;
        protected long ? _certificateid;
        protected bool ? _isactive;
        protected string _remarks;
        
        [DataMember]
        public long ? batchcandcertificateid
        {
            get { return _batchcandcertificateid; }
            set { _batchcandcertificateid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "batchcandidatetypemapid", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatecertificate))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatecertificate), ErrorMessageResourceName = "batchcandidatetypemapidRequired")]
        public long ? batchcandidatetypemapid
        {
            get { return _batchcandidatetypemapid; }
            set { _batchcandidatetypemapid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "certificatelevelid", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatecertificate))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatecertificate), ErrorMessageResourceName = "certificatelevelidRequired")]
        public long ? certificatelevelid
        {
            get { return _certificatelevelid; }
            set { _certificatelevelid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "certificateid", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatecertificate))]
        public long ? certificateid
        {
            get { return _certificateid; }
            set { _certificateid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatecertificate))]
        public bool ? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatecertificate))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        #endregion
    
        #region Constructor
    
        public gen_batchcandidatecertificateEntity():base()
        {
        }
        
        public gen_batchcandidatecertificateEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_batchcandidatecertificateEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }

        public gen_batchcandidatecertificateEntity(IDataReader reader, int e)
        {
            this.LoadFromReader(reader, e);
        }

        public gen_batchcandidatecertificateEntity(IDataReader reader, string ext)
        {
            this.LoadFromReader(reader, ext);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("BatchCandCertificateID"))) _batchcandcertificateid = reader.GetInt64(reader.GetOrdinal("BatchCandCertificateID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchCandidateTypeMapID"))) _batchcandidatetypemapid = reader.GetInt64(reader.GetOrdinal("BatchCandidateTypeMapID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateLevelID"))) _certificatelevelid = reader.GetInt64(reader.GetOrdinal("CertificateLevelID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateID"))) _certificateid = reader.GetInt64(reader.GetOrdinal("CertificateID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("BatchCandCertificateID"))) _batchcandcertificateid = reader.GetInt64(reader.GetOrdinal("BatchCandCertificateID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchCandidateTypeMapID"))) _batchcandidatetypemapid = reader.GetInt64(reader.GetOrdinal("BatchCandidateTypeMapID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateLevelID"))) _certificatelevelid = reader.GetInt64(reader.GetOrdinal("CertificateLevelID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateID"))) _certificateid = reader.GetInt64(reader.GetOrdinal("CertificateID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
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
