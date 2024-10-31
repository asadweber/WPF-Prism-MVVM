using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using static BDO.Core.Base.BaseEntity;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class SyReTestApprovalListLoadFromReader : reg_registrationinfoEntity
    {
        public SyReTestApprovalListLoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) _registrationid = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchID"))) _batchid = reader.GetInt64(reader.GetOrdinal("BatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchNo"))) _batchno = reader.GetInt64(reader.GetOrdinal("BatchNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("CandidateTypeID"))) _candidatetypeid = reader.GetInt64(reader.GetOrdinal("CandidateTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CandidateTypeName"))) candidatetypename = reader.GetString(reader.GetOrdinal("CandidateTypeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProfessionName"))) professionname = reader.GetString(reader.GetOrdinal("ProfessionName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _civilid = reader.GetString(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CountryNationality"))) _nationality = reader.GetString(reader.GetOrdinal("CountryNationality"));
                if (!reader.IsDBNull(reader.GetOrdinal("PhoneNo"))) _mobno = reader.GetString(reader.GetOrdinal("PhoneNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("AuditResult"))) _auditresult = reader.GetInt32(reader.GetOrdinal("AuditResult"));
                if (!reader.IsDBNull(reader.GetOrdinal("AuditDate"))) _submitteddate = reader.GetDateTime(reader.GetOrdinal("AuditDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("isSyReTestApproved"))) _issyretestapproved = reader.GetBoolean(reader.GetOrdinal("isSyReTestApproved"));
                if (!reader.IsDBNull(reader.GetOrdinal("ResultDate"))) _resultdate = reader.GetDateTime(reader.GetOrdinal("ResultDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ResultExpiryDate"))) _resultexpirydate = reader.GetDateTime(reader.GetOrdinal("ResultExpiryDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ClearanceBy"))) _approvedby = reader.GetString(reader.GetOrdinal("ClearanceBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ClearanceDate"))) _approvaldate = reader.GetDateTime(reader.GetOrdinal("ClearanceDate"));
                CurrentState = EntityState.Unchanged;
            }
        }

    }
}