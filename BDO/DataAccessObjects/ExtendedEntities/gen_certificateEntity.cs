using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class gen_certificateEntity : BaseEntity
    {
        #region Properties

        protected string? _certificatelevel;
        protected string? _certificatetype;
        private long? _BatchID;
        private string _BatchIDString;
        private long? _batchCandidateTypeMapID;
        private long? batchCandCertificateID;
        private long? _CandidateTypeID;

        [DataMember]
        [Display(Name = "certificatelevelid", ResourceType = typeof(CLL.LLClasses.Models._gen_certificate))]
        public string? certificatelevel
        {
            get { return _certificatelevel; }
            set { _certificatelevel = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "certificatetypeid", ResourceType = typeof(CLL.LLClasses.Models._gen_certificate))]
        public string? certificatetype
        {
            get { return _certificatetype; }
            set { _certificatetype = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? BatchID { get; set; }

        [DataMember]
        public string BatchIDString { get; set; }

        [DataMember]
        public long? BatchCandidateTypeMapID { get => _batchCandidateTypeMapID; set => _batchCandidateTypeMapID = value; }

        [DataMember]
        public long? BatchCandCertificateID { get => batchCandCertificateID; set => batchCandCertificateID = value; }

        [DataMember]
        public long? CandidateTypeID { get; set; }

        #endregion

        #region Constructor

        protected void LoadFromReader(IDataReader reader, int e)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateID"))) _certificateid = reader.GetInt64(reader.GetOrdinal("CertificateID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateName"))) _certificatename = reader.GetString(reader.GetOrdinal("CertificateName"));
                if (!reader.IsDBNull(reader.GetOrdinal("EducationLevel"))) _educationlevel = reader.GetInt64(reader.GetOrdinal("EducationLevel"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateLevelID"))) _certificatelevelid = reader.GetInt64(reader.GetOrdinal("CertificateLevelID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateLevel"))) _certificatelevel = reader.GetString(reader.GetOrdinal("CertificateLevel"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateTypeID"))) _certificatetypeid = reader.GetInt64(reader.GetOrdinal("CertificateTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateType"))) _certificatetype = reader.GetString(reader.GetOrdinal("CertificateType"));
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

        protected void LoadFromReader(IDataReader reader, string ext)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateID"))) _certificateid = reader.GetInt64(reader.GetOrdinal("CertificateID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateName"))) _certificatename = reader.GetString(reader.GetOrdinal("CertificateName"));
                CurrentState = EntityState.Unchanged;
            }
        }

        #endregion



    }
}
