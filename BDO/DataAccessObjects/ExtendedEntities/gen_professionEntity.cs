using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class gen_professionEntity : BaseEntity
    {
        #region Properties
    
        protected string ? _professiongroupname;
        
        [DataMember]
        [Display(Name = "professiongroupid", ResourceType = typeof(CLL.LLClasses.Models._gen_profession))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_profession), ErrorMessageResourceName = "professiongroupidRequired")]
        public string ? professiongroupname
        {
            get { return _professiongroupname; }
            set { _professiongroupname = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? BatchId { get; set; }

        [DataMember]
        public long? BatchCandidateTypeMapId { get; set; }

        [DataMember]
        public long? BatchCandProfessionMapID { get; set; }

        [DataMember]
        public string BatchIdString { get; set; }

        [DataMember]
        public long? CandidateTypeId { get; set; }

        [DataMember]
        public string? CandidateTypeIDString { get; set; }

        #endregion

        #region Constructor

        protected void LoadFromReader(IDataReader reader, int e)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("ProfessionID"))) _professionid = reader.GetInt64(reader.GetOrdinal("ProfessionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProfessionName"))) _professionname = reader.GetString(reader.GetOrdinal("ProfessionName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProfessionGroupID"))) _professiongroupid = reader.GetInt64(reader.GetOrdinal("ProfessionGroupID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProfessionGroupName"))) _professiongroupname = reader.GetString(reader.GetOrdinal("ProfessionGroupName"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("ProfessionID"))) _professionid = reader.GetInt64(reader.GetOrdinal("ProfessionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProfessionName"))) _professionname = reader.GetString(reader.GetOrdinal("ProfessionName"));
                CurrentState = EntityState.Unchanged;
            }
        }

        #endregion

    }
}
