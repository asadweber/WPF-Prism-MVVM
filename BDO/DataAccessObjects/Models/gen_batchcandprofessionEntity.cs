using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_batchcandprofessionEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_batchcandprofessionEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _batchcandprofessionmapid;
        protected long ? _batchcandidatetypemapid;
        protected long ? _professionid;
        protected long ? _noofregistration;
        protected bool ? _isactive;
        protected string _comment;
        protected string _remarks;
        
        [DataMember]
        public long ? batchcandprofessionmapid
        {
            get { return _batchcandprofessionmapid; }
            set { _batchcandprofessionmapid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "batchcandidatetypemapid", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandprofession))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batchcandprofession), ErrorMessageResourceName = "batchcandidatetypemapidRequired")]
        public long ? batchcandidatetypemapid
        {
            get { return _batchcandidatetypemapid; }
            set { _batchcandidatetypemapid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "professionid", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandprofession))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batchcandprofession), ErrorMessageResourceName = "professionidRequired")]
        public long ? professionid
        {
            get { return _professionid; }
            set { _professionid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "noofregistration", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandprofession))]
        public long ? noofregistration
        {
            get { return _noofregistration; }
            set { _noofregistration = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandprofession))]
        public bool ? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(1000)]
        [Display(Name = "comment", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandprofession))]
        public string comment
        {
            get { return _comment; }
            set { _comment = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandprofession))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        #endregion
    
        #region Constructor
    
        public gen_batchcandprofessionEntity():base()
        {
        }
        
        public gen_batchcandprofessionEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_batchcandprofessionEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }

        public gen_batchcandprofessionEntity(IDataReader reader, int e)
        {
            this.LoadFromReader(reader, e);
        }

        public gen_batchcandprofessionEntity(IDataReader reader, string ext)
        {
            this.LoadFromReader(reader, "ext");
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("BatchCandProfessionMapID"))) _batchcandprofessionmapid = reader.GetInt64(reader.GetOrdinal("BatchCandProfessionMapID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchCandidateTypeMapID"))) _batchcandidatetypemapid = reader.GetInt64(reader.GetOrdinal("BatchCandidateTypeMapID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProfessionID"))) _professionid = reader.GetInt64(reader.GetOrdinal("ProfessionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NoOfRegistration"))) _noofregistration = reader.GetInt64(reader.GetOrdinal("NoOfRegistration"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("BatchCandProfessionMapID"))) _batchcandprofessionmapid = reader.GetInt64(reader.GetOrdinal("BatchCandProfessionMapID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchCandidateTypeMapID"))) _batchcandidatetypemapid = reader.GetInt64(reader.GetOrdinal("BatchCandidateTypeMapID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProfessionID"))) _professionid = reader.GetInt64(reader.GetOrdinal("ProfessionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NoOfRegistration"))) _noofregistration = reader.GetInt64(reader.GetOrdinal("NoOfRegistration"));
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
