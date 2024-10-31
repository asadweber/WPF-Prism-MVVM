using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class gen_batchEntity 
    {

        private long? currentApplybatch;
        private long? _ProfileBasicId;

        [DataMember]
        public long? CurrentApplybatch { get => currentApplybatch; set => currentApplybatch = value; }

        [DataMember]
        public long? ProfileBasicId { get => _ProfileBasicId; set => _ProfileBasicId = value; }

        [DataMember] 
        public string BatchDetails { get; set; }

        [DataMember]
        public long? candidatetypeid { get; set; }

        public void BatchDetailsFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!reader.IsDBNull(reader.GetOrdinal("BatchDetails"))) BatchDetails = reader.GetString(reader.GetOrdinal("BatchDetails"));
            }
        }

    }
}