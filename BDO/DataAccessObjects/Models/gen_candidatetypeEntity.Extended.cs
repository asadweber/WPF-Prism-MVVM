using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class gen_candidatetypeEntity : BaseEntity
    {

        [DataMember]
        public long? BatchId { get; set; }

        [DataMember]
        public string BatchIdString { get; set; }

        [DataMember]
        public long? BatchCandidateTypeMapId { get; set; }


        public void LoadBatchCandidateTypeMapInfo(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!reader.IsDBNull(reader.GetOrdinal("BatchCandidateTypeMapID"))) BatchCandidateTypeMapId = reader.GetInt64(reader.GetOrdinal("BatchCandidateTypeMapID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchID"))) BatchId = reader.GetInt64(reader.GetOrdinal("BatchID"));

                CurrentState = EntityState.Unchanged;
            }
        }

        protected void LoadFromReader(IDataReader reader, int e)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("CandidateTypeID"))) _candidatetypeid = reader.GetInt64(reader.GetOrdinal("CandidateTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CandidateTypeName"))) _candidatetypename = reader.GetString(reader.GetOrdinal("CandidateTypeName"));
                CurrentState = EntityState.Unchanged;
            }
        }

    }
}
