using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_batchEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_batchEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _batchid;
        protected long ? _batchno;
        protected long ? _lowerage;
        protected long ? _maxage;
        protected long ? _candidatetype;
        protected long ? _militarytype;
        protected DateTime? _startdate;
        protected DateTime? _enddate;
        protected long ? _gender;
        protected bool ? _isactive;
        protected string _comment;
        protected string _remarks;
        
        [DataMember]
        public long ? batchid
        {
            get { return _batchid; }
            set { _batchid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "batchno", ResourceType = typeof(CLL.LLClasses.Models._gen_batch))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batch), ErrorMessageResourceName = "batchnoRequired")]
        public long ? batchno
        {
            get { return _batchno; }
            set { _batchno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "lowerage", ResourceType = typeof(CLL.LLClasses.Models._gen_batch))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batch), ErrorMessageResourceName = "lowerageRequired")]
        public long ? lowerage
        {
            get { return _lowerage; }
            set { _lowerage = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "maxage", ResourceType = typeof(CLL.LLClasses.Models._gen_batch))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batch), ErrorMessageResourceName = "maxageRequired")]
        public long ? maxage
        {
            get { return _maxage; }
            set { _maxage = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "candidatetype", ResourceType = typeof(CLL.LLClasses.Models._gen_batch))]
        public long ? candidatetype
        {
            get { return _candidatetype; }
            set { _candidatetype = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "militarytype", ResourceType = typeof(CLL.LLClasses.Models._gen_batch))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batch), ErrorMessageResourceName = "militarytypeRequired")]
        public long ? militarytype
        {
            get { return _militarytype; }
            set { _militarytype = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "startdate", ResourceType = typeof(CLL.LLClasses.Models._gen_batch))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batch), ErrorMessageResourceName = "startdateRequired")]
        public DateTime? startdate
        {
            get { return _startdate; }
            set { _startdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "enddate", ResourceType = typeof(CLL.LLClasses.Models._gen_batch))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batch), ErrorMessageResourceName = "enddateRequired")]
        public DateTime? enddate
        {
            get { return _enddate; }
            set { _enddate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "gender", ResourceType = typeof(CLL.LLClasses.Models._gen_batch))]
        public long ? gender
        {
            get { return _gender; }
            set { _gender = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._gen_batch))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batch), ErrorMessageResourceName = "isactiveRequired")]
        public bool? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(1000)]
        [Display(Name = "comment", ResourceType = typeof(CLL.LLClasses.Models._gen_batch))]
        public string comment
        {
            get { return _comment; }
            set { _comment = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._gen_batch))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public gen_batchEntity():base()
        {
        }
        
        public gen_batchEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_batchEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("BatchID"))) _batchid = reader.GetInt64(reader.GetOrdinal("BatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchNo"))) _batchno = reader.GetInt64(reader.GetOrdinal("BatchNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("LowerAge"))) _lowerage = reader.GetInt64(reader.GetOrdinal("LowerAge"));
                if (!reader.IsDBNull(reader.GetOrdinal("MaxAge"))) _maxage = reader.GetInt64(reader.GetOrdinal("MaxAge"));
                if (!reader.IsDBNull(reader.GetOrdinal("CandidateType"))) _candidatetype = reader.GetInt64(reader.GetOrdinal("CandidateType"));
                if (!reader.IsDBNull(reader.GetOrdinal("MilitaryType"))) _militarytype = reader.GetInt64(reader.GetOrdinal("MilitaryType"));
                if (!reader.IsDBNull(reader.GetOrdinal("StartDate"))) _startdate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("EndDate"))) _enddate = reader.GetDateTime(reader.GetOrdinal("EndDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("Gender"))) _gender = reader.GetInt64(reader.GetOrdinal("Gender"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("BatchID"))) _batchid = reader.GetInt64(reader.GetOrdinal("BatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchNo"))) _batchno = reader.GetInt64(reader.GetOrdinal("BatchNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("LowerAge"))) _lowerage = reader.GetInt64(reader.GetOrdinal("LowerAge"));
                if (!reader.IsDBNull(reader.GetOrdinal("MaxAge"))) _maxage = reader.GetInt64(reader.GetOrdinal("MaxAge"));
                if (!reader.IsDBNull(reader.GetOrdinal("CandidateType"))) _candidatetype = reader.GetInt64(reader.GetOrdinal("CandidateType"));
                if (!reader.IsDBNull(reader.GetOrdinal("MilitaryType"))) _militarytype = reader.GetInt64(reader.GetOrdinal("MilitaryType"));
                if (!reader.IsDBNull(reader.GetOrdinal("StartDate"))) _startdate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("EndDate"))) _enddate = reader.GetDateTime(reader.GetOrdinal("EndDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("Gender"))) _gender = reader.GetInt64(reader.GetOrdinal("Gender"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
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
