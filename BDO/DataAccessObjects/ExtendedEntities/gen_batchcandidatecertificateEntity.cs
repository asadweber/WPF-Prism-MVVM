using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class gen_batchcandidatecertificateEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _batchid;
        protected string? _batchno;
        protected long ? _candidatetypeid;
        protected string? _candidatetypename;
        protected string? _certificatelevel;
        protected string? _certificatename;
        protected string? _certificateids;

        [DataMember]
        [Display(Name = "batchid", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatecertificate))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatecertificate), ErrorMessageResourceName = "batchidRequired")]
        public long ? batchid
        {
            get { return _batchid; }
            set { _batchid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "batchid", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatecertificate))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatecertificate), ErrorMessageResourceName = "batchidRequired")]
        public string? batchno
        {
            get { return _batchno; }
            set { _batchno = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "candidatetypeid", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatecertificate))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatecertificate), ErrorMessageResourceName = "candidatetypeidRequired")]
        public long ? candidatetypeid
        {
            get { return _candidatetypeid; }
            set { _candidatetypeid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "candidatetypeid", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatecertificate))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatecertificate), ErrorMessageResourceName = "candidatetypeidRequired")]
        public string? candidatetypename
        {
            get { return _candidatetypename; }
            set { _candidatetypename = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "certificatelevelid", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatecertificate))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatecertificate), ErrorMessageResourceName = "certificatelevelidRequired")]
        public string? certificatelevel
        {
            get { return _certificatelevel; }
            set { _certificatelevel = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "certificateid", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatecertificate))]
        public string? certificatename
        {
            get { return _certificatename; }
            set { _certificatename = value; this.OnChnaged(); }
        }

        [DataMember]
        public string? certificateids
        {
            get { return _certificateids; }
            set { _certificateids = value; this.OnChnaged(); }
        }
        #endregion


        #region Constructor

        protected void LoadFromReader(IDataReader reader, int e)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("BatchCandidateTypeMapID"))) _batchcandidatetypemapid = reader.GetInt64(reader.GetOrdinal("BatchCandidateTypeMapID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchID"))) _batchid = reader.GetInt64(reader.GetOrdinal("BatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchNo"))) _batchno = reader.GetString(reader.GetOrdinal("BatchNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("CandidateTypeID"))) _candidatetypeid = reader.GetInt64(reader.GetOrdinal("CandidateTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CandidateTypeName"))) _candidatetypename = reader.GetString(reader.GetOrdinal("CandidateTypeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateID"))) _certificateids = reader.GetString(reader.GetOrdinal("CertificateID"));
                CurrentState = EntityState.Unchanged;
            }
        }

        protected void LoadFromReader(IDataReader reader, string ext)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("BatchCandidateTypeMapID"))) _batchcandidatetypemapid = reader.GetInt64(reader.GetOrdinal("BatchCandidateTypeMapID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchID"))) _batchid = reader.GetInt64(reader.GetOrdinal("BatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchNo"))) _batchno = reader.GetString(reader.GetOrdinal("BatchNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("CandidateTypeID"))) _candidatetypeid = reader.GetInt64(reader.GetOrdinal("CandidateTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CandidateTypeName"))) _candidatetypename = reader.GetString(reader.GetOrdinal("CandidateTypeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateID"))) _certificateids = reader.GetString(reader.GetOrdinal("CertificateID"));
                CurrentState = EntityState.Unchanged;
            }
        }
        #endregion

    }
}
