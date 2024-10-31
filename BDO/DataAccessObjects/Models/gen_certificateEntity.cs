using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_certificateEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_certificateEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _certificateid;
        protected string _certificatename;
        protected long ? _educationlevel;
        protected long ? _certificatelevelid;
        protected long ? _certificatetypeid;
        protected bool ? _ispercentage;
        protected string _comment;
        protected string _remarks;
        
        [DataMember]
        public long ? certificateid
        {
            get { return _certificateid; }
            set { _certificateid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "certificatename", ResourceType = typeof(CLL.LLClasses.Models._gen_certificate))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_certificate), ErrorMessageResourceName = "certificatenameRequired")]
        public string certificatename
        {
            get { return _certificatename; }
            set { _certificatename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "educationlevel", ResourceType = typeof(CLL.LLClasses.Models._gen_certificate))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_certificate), ErrorMessageResourceName = "educationlevelRequired")]
        public long ? educationlevel
        {
            get { return _educationlevel; }
            set { _educationlevel = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "certificatelevelid", ResourceType = typeof(CLL.LLClasses.Models._gen_certificate))]
        public long ? certificatelevelid
        {
            get { return _certificatelevelid; }
            set { _certificatelevelid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "certificatetypeid", ResourceType = typeof(CLL.LLClasses.Models._gen_certificate))]
        public long ? certificatetypeid
        {
            get { return _certificatetypeid; }
            set { _certificatetypeid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "ispercentage", ResourceType = typeof(CLL.LLClasses.Models._gen_certificate))]
        public bool ? ispercentage
        {
            get { return _ispercentage; }
            set { _ispercentage = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "comment", ResourceType = typeof(CLL.LLClasses.Models._gen_certificate))]
        public string comment
        {
            get { return _comment; }
            set { _comment = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._gen_certificate))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        #endregion
    
        #region Constructor
    
        public gen_certificateEntity():base()
        {
        }
        
        public gen_certificateEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_certificateEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }

        public gen_certificateEntity(IDataReader reader, int e)
        {
            this.LoadFromReader(reader, e);
        }

        public gen_certificateEntity(IDataReader reader, string ext)
        {
            this.LoadFromReader(reader, ext);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateID"))) _certificateid = reader.GetInt64(reader.GetOrdinal("CertificateID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateName"))) _certificatename = reader.GetString(reader.GetOrdinal("CertificateName"));
                if (!reader.IsDBNull(reader.GetOrdinal("EducationLevel"))) _educationlevel = reader.GetInt64(reader.GetOrdinal("EducationLevel"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateLevelID"))) _certificatelevelid = reader.GetInt64(reader.GetOrdinal("CertificateLevelID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateTypeID"))) _certificatetypeid = reader.GetInt64(reader.GetOrdinal("CertificateTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsPercentage"))) _ispercentage = reader.GetBoolean(reader.GetOrdinal("IsPercentage"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateID"))) _certificateid = reader.GetInt64(reader.GetOrdinal("CertificateID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateName"))) _certificatename = reader.GetString(reader.GetOrdinal("CertificateName"));
                if (!reader.IsDBNull(reader.GetOrdinal("EducationLevel"))) _educationlevel = reader.GetInt64(reader.GetOrdinal("EducationLevel"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateLevelID"))) _certificatelevelid = reader.GetInt64(reader.GetOrdinal("CertificateLevelID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateTypeID"))) _certificatetypeid = reader.GetInt64(reader.GetOrdinal("CertificateTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsPercentage"))) _ispercentage = reader.GetBoolean(reader.GetOrdinal("IsPercentage"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
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
