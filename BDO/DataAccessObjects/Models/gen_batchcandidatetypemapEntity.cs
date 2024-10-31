using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_batchcandidatetypemapEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_batchcandidatetypemapEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _batchcandidatetypemapid;
        protected long ? _batchid;
        protected long ? _candidatetypeid;
        //protected DateTime ? _startdate;
        //protected DateTime ? _enddate;
        protected string _comment;
        protected string _remarks;
                
        
        [DataMember]
        public long ? batchcandidatetypemapid
        {
            get { return _batchcandidatetypemapid; }
            set { _batchcandidatetypemapid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "batchid", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatetypemap))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatetypemap), ErrorMessageResourceName = "batchidRequired")]
        public long? batchid
        {
            get { return _batchid; }
            set { _batchid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "candidatetypeid", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatetypemap))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatetypemap), ErrorMessageResourceName = "candidatetypeidRequired")]
        public long? candidatetypeid
        {
            get { return _candidatetypeid; }
            set { _candidatetypeid = value; this.OnChnaged(); }
        }
        
        //[DataMember]
        //[Display(Name = "startdate", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatetypemap))]
        //[Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatetypemap), ErrorMessageResourceName = "startdateRequired")]
        //public DateTime? startdate
        //{
        //    get { return _startdate; }
        //    set { _startdate = value; this.OnChnaged(); }
        //}
        
        //[DataMember]
        //[Display(Name = "enddate", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatetypemap))]
        //[Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatetypemap), ErrorMessageResourceName = "enddateRequired")]
        //public DateTime? enddate
        //{
        //    get { return _enddate; }
        //    set { _enddate = value; this.OnChnaged(); }
        //}
        
        [DataMember]
        [MaxLength(1000)]
        [Display(Name = "comment", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatetypemap))]
        public string comment
        {
            get { return _comment; }
            set { _comment = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatetypemap))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        #endregion
    
        #region Constructor
    
        public gen_batchcandidatetypemapEntity():base()
        {
        }
        
        public gen_batchcandidatetypemapEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_batchcandidatetypemapEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }

        public gen_batchcandidatetypemapEntity(IDataReader reader, int e)
        {
            this.LoadFromReader(reader, e);
        }


        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("BatchCandidateTypeMapID"))) _batchcandidatetypemapid = reader.GetInt64(reader.GetOrdinal("BatchCandidateTypeMapID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchID"))) _batchid = reader.GetInt64(reader.GetOrdinal("BatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CandidateTypeID"))) _candidatetypeid = reader.GetInt64(reader.GetOrdinal("CandidateTypeID"));
                //if (!reader.IsDBNull(reader.GetOrdinal("StartDate"))) _startdate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                //if (!reader.IsDBNull(reader.GetOrdinal("EndDate"))) _enddate = reader.GetDateTime(reader.GetOrdinal("EndDate"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("BatchCandidateTypeMapID"))) _batchcandidatetypemapid = reader.GetInt64(reader.GetOrdinal("BatchCandidateTypeMapID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchID"))) _batchid = reader.GetInt64(reader.GetOrdinal("BatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CandidateTypeID"))) _candidatetypeid = reader.GetInt64(reader.GetOrdinal("CandidateTypeID"));
                //if (!reader.IsDBNull(reader.GetOrdinal("StartDate"))) _startdate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                //if (!reader.IsDBNull(reader.GetOrdinal("EndDate"))) _enddate = reader.GetDateTime(reader.GetOrdinal("EndDate"));
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
