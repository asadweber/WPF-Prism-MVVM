using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;

namespace BDO.Core.DataAccessObjects.Models
{
    
    
    public partial class gen_batchcandidatetypemapEntity : BaseEntity
    {
        #region Properties
    
        protected string ? _batchno;
        protected string ? _candidatetypename;

        [DataMember]
        [Display(Name = "batchid", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatetypemap))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatetypemap), ErrorMessageResourceName = "batchidRequired")]
        public string ? batchno
        {
            get { return _batchno; }
            set { _batchno = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "candidatetypeid", ResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatetypemap))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batchcandidatetypemap), ErrorMessageResourceName = "candidatetypeidRequired")]
        public string? candidatetypename
        {
            get { return _candidatetypename; }
            set { _candidatetypename = value; this.OnChnaged(); }
        }

        [DataMember]
        public string candidatetypeidsstring { get; set; }
     
        #endregion


        protected void LoadFromReader(IDataReader reader, int e)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (ColumnExists(reader, "BatchCandidateTypeMapID") && !reader.IsDBNull(reader.GetOrdinal("BatchCandidateTypeMapID"))) _batchcandidatetypemapid = reader.GetInt64(reader.GetOrdinal("BatchCandidateTypeMapID"));
                if (ColumnExists(reader, "BatchID") && !reader.IsDBNull(reader.GetOrdinal("BatchID"))) _batchid = reader.GetInt64(reader.GetOrdinal("BatchID"));
                if (ColumnExists(reader, "BatchNo") && !reader.IsDBNull(reader.GetOrdinal("BatchNo"))) _batchno = reader.GetString(reader.GetOrdinal("BatchNo"));
                if (ColumnExists(reader, "CandidateTypeID") && !reader.IsDBNull(reader.GetOrdinal("CandidateTypeID"))) _candidatetypeid = reader.GetInt64(reader.GetOrdinal("CandidateTypeID"));
                if (ColumnExists(reader, "CandidateTypeName") && !reader.IsDBNull(reader.GetOrdinal("CandidateTypeName"))) _candidatetypename = reader.GetString(reader.GetOrdinal("CandidateTypeName"));
                //ifColumnExists(reader, "BatchCandidateTypeMapID") &&  (!reader.IsDBNull(reader.GetOrdinal("StartDate"))) _startdate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                //ifColumnExists(reader, "BatchCandidateTypeMapID") &&  (!reader.IsDBNull(reader.GetOrdinal("EndDate"))) _enddate = reader.GetDateTime(reader.GetOrdinal("EndDate"));
                if (ColumnExists(reader, "Comment") && !reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
                if (ColumnExists(reader, "Remarks") && !reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (ColumnExists(reader, "TransID") && !reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (ColumnExists(reader, "CreatedByUserName") && !reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (ColumnExists(reader, "CreatedDate") && !reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (ColumnExists(reader, "UpdatedByUserName") && !reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (ColumnExists(reader, "UpdatedDate") && !reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (ColumnExists(reader, "IPAddress") && !reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (ColumnExists(reader, "TS") && !reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }

        private bool ColumnExists(IDataReader reader, string columnName)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (reader.GetName(i).Equals(columnName, StringComparison.InvariantCultureIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
