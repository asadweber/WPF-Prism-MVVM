using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class gen_batchcandprofessionEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _batchid;
        protected string ? _batchno;
        protected long ? _candidatetypeid;
        protected string ? _candidatetypename;
		protected long? _professiongroupid;
		protected string ? _professionname;
        protected string? _professionids;

        
        [DataMember]
        [Display(Name = "batchid", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandprofession))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batchcandprofession), ErrorMessageResourceName = "batchidRequired")]
        public long ? batchid
        {
            get { return _batchid; }
            set { _batchid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "batchid", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandprofession))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batchcandprofession), ErrorMessageResourceName = "batchidRequired")]
        public string? batchno
        {
            get { return _batchno; }
            set { _batchno = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "candidatetypeid", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandprofession))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batchcandprofession), ErrorMessageResourceName = "candidatetypeidRequired")]
        public long? candidatetypeid
        {
            get { return _candidatetypeid; }
            set { _candidatetypeid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "candidatetypeid", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandprofession))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batchcandprofession), ErrorMessageResourceName = "candidatetypeidRequired")]
        public string? candidatetypename
        {
            get { return _candidatetypename; }
            set { _candidatetypename = value; this.OnChnaged(); }
        }

		[DataMember]
		[Display(Name = "professiongroupid", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandprofession))]
		public long? professiongroupid
		{
			get { return _professiongroupid; }
			set { _professiongroupid = value; this.OnChnaged(); }
		}

		[DataMember]
        [Display(Name = "professionid", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandprofession))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batchcandprofession), ErrorMessageResourceName = "professionidRequired")]
        public string ? professionname
        {
            get { return _professionname; }
            set { _professionname = value; this.OnChnaged(); }
        }

        [DataMember]
        public string? professionids
        {
            get { return _professionids; }
            set { _professionids = value; this.OnChnaged(); }
        }

        public List<gen_professionEntity> professionList { get; set; }

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
                if (!reader.IsDBNull(reader.GetOrdinal("ProfessionID"))) _professionids = reader.GetString(reader.GetOrdinal("ProfessionID"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("ProfessionID"))) _professionids = reader.GetString(reader.GetOrdinal("ProfessionID"));
                CurrentState = EntityState.Unchanged;
            }
        }

        #endregion



    }
}
