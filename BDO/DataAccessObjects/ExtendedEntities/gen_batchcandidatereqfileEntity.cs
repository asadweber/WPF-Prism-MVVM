using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class gen_batchcandidatereqfileEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _batchid;
        protected string ? _batchno;
        protected long ? _candidatetypeid;
        protected string ? _candidatetypename;
        protected string ? _fileconfigname;

        
        [DataMember]
        [Display(Name = "batchid", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatereqfile))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatereqfile), ErrorMessageResourceName = "batchidRequired")]
        public long ? batchid
        {
            get { return _batchid; }
            set { _batchid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "batchid", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatereqfile))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatereqfile), ErrorMessageResourceName = "batchidRequired")]
        public string? batchno
        {
            get { return _batchno; }
            set { _batchno = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "candidatetypeid", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatereqfile))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatereqfile), ErrorMessageResourceName = "candidatetypeidRequired")]
        public long? candidatetypeid
        {
            get { return _candidatetypeid; }
            set { _candidatetypeid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "candidatetypeid", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatereqfile))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatereqfile), ErrorMessageResourceName = "candidatetypeidRequired")]
        public string? candidatetypename
        {
            get { return _candidatetypename; }
            set { _candidatetypename = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "fileconfigid", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatereqfile))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatereqfile), ErrorMessageResourceName = "fileconfigidRequired")]
        public string ? fileconfigname
        {
            get { return _fileconfigname; }
            set { _fileconfigname = value; this.OnChnaged(); }
        }

        #endregion

        #region Constructor
        protected void LoadFromReader(IDataReader reader, int e)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("BatchCandReqFileID"))) _batchcandreqfileid = reader.GetInt64(reader.GetOrdinal("BatchCandReqFileID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchCandidateTypeMapID"))) _batchcandidatetypemapid = reader.GetInt64(reader.GetOrdinal("BatchCandidateTypeMapID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchID"))) _batchid = reader.GetInt64(reader.GetOrdinal("BatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchNo"))) _batchno = reader.GetString(reader.GetOrdinal("BatchNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("CandidateTypeID"))) _candidatetypeid = reader.GetInt64(reader.GetOrdinal("CandidateTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CandidateTypeName"))) _candidatetypename = reader.GetString(reader.GetOrdinal("CandidateTypeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileConfigID"))) _fileconfigid = reader.GetInt64(reader.GetOrdinal("FileConfigID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileConfigName"))) _fileconfigname = reader.GetString(reader.GetOrdinal("FileConfigName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Description"))) _description = reader.GetString(reader.GetOrdinal("Description"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsRequired"))) _isrequired = reader.GetBoolean(reader.GetOrdinal("IsRequired"));
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