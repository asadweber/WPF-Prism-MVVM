using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using static BDO.Core.Base.BaseEntity;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class ApplicantReviewRegInfoLoadFromReader : reg_registrationinfoEntity
    {
        public ApplicantReviewRegInfoLoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) _registrationid = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _civilid = reader.GetString(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PhoneNo"))) _mobno = reader.GetString(reader.GetOrdinal("PhoneNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("MaritalStatus"))) maritalstatusid = reader.GetInt64(reader.GetOrdinal("MaritalStatus"));
                if (!reader.IsDBNull(reader.GetOrdinal("Nationality"))) nationality = reader.GetString(reader.GetOrdinal("Nationality"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchDetails"))) batchdetails = reader.GetString(reader.GetOrdinal("BatchDetails"));
                if (!reader.IsDBNull(reader.GetOrdinal("CandidateTypeName"))) candidatetypename = reader.GetString(reader.GetOrdinal("CandidateTypeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProfessionName"))) professionname = reader.GetString(reader.GetOrdinal("ProfessionName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Email"))) email = reader.GetString(reader.GetOrdinal("Email"));
                if (!reader.IsDBNull(reader.GetOrdinal("AuditResult"))) auditresult = reader.GetInt32(reader.GetOrdinal("AuditResult"));
                if (!reader.IsDBNull(reader.GetOrdinal("AuditComment"))) auditcomment = reader.GetString(reader.GetOrdinal("AuditComment"));
                CurrentState = EntityState.Unchanged;
            }
        }

    }
}