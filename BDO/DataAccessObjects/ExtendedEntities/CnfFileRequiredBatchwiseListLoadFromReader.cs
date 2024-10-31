using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using static BDO.Core.Base.BaseEntity;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class CnfFileRequiredBatchwiseListLoadFromReader : cnf_filerequiredEntity
    {
        public CnfFileRequiredBatchwiseListLoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("FileConfigID"))) _fileconfigid = reader.GetInt64(reader.GetOrdinal("FileConfigID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchID"))) _batchid = reader.GetInt64(reader.GetOrdinal("BatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileConfigNameID"))) _fileconfignameid = reader.GetInt64(reader.GetOrdinal("FileConfigNameID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileConfigName"))) _fileconfigname = reader.GetString(reader.GetOrdinal("FileConfigName"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsRequired"))) _isrequired = reader.GetBoolean(reader.GetOrdinal("IsRequired"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsPrintRequired"))) _isprintrequired = reader.GetBoolean(reader.GetOrdinal("IsPrintRequired"));
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

    }
}