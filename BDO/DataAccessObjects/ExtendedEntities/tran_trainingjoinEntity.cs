using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    public partial class tran_trainingjoinEntity
    {
        protected string? _trgcentrename;
        protected string? _joiningbatchdetails;
                
        [DataMember]
        public string? trgcentrename
        {
            get { return _trgcentrename; }
            set { _trgcentrename = value; this.OnChnaged(); }
        }

        [DataMember]
        public string? joiningbatchdetails
        {
            get { return _joiningbatchdetails; }
            set { _joiningbatchdetails = value; this.OnChnaged(); }
        }

        protected void LoadFromReader(IDataReader reader, int e)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("TrgJoinID"))) _trgjoinid = reader.GetInt64(reader.GetOrdinal("TrgJoinID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) _registrationid = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TrgCentreID"))) _trgcentreid = reader.GetInt64(reader.GetOrdinal("TrgCentreID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TrainingCentreName"))) _trgcentrename = reader.GetString(reader.GetOrdinal("TrainingCentreName"));
                if (!reader.IsDBNull(reader.GetOrdinal("JoinDate"))) _joindate = reader.GetDateTime(reader.GetOrdinal("JoinDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("VolunteerNo"))) _volunteerno = reader.GetInt64(reader.GetOrdinal("VolunteerNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("GroupNo"))) _groupno = reader.GetString(reader.GetOrdinal("GroupNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("JoiningBatchID"))) _joiningbatchid = reader.GetInt64(reader.GetOrdinal("JoiningBatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("JoiningBatchDetails"))) _joiningbatchdetails = reader.GetString(reader.GetOrdinal("JoiningBatchDetails"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrderNo"))) _orderno = reader.GetString(reader.GetOrdinal("OrderNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrderDate"))) _orderdate = reader.GetDateTime(reader.GetOrdinal("OrderDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsSoftDeleted"))) _issoftdeleted = reader.GetBoolean(reader.GetOrdinal("IsSoftDeleted"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdateInfo"))) _updateinfo = reader.GetString(reader.GetOrdinal("UpdateInfo"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TranFormActionID"))) _tranformactionid = reader.GetInt64(reader.GetOrdinal("TranFormActionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }

    }
}