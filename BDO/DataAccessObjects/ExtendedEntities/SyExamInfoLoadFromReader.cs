using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using static BDO.Core.Base.BaseEntity;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class SyExamInfoLoadFromReader : reg_registrationinfoEntity
    {
        public SyExamInfoLoadFromReader(IDataReader reader)
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
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _civilid = reader.GetString(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CountryNationality"))) _nationality = reader.GetString(reader.GetOrdinal("CountryNationality"));
                if (!reader.IsDBNull(reader.GetOrdinal("PhoneNo"))) _mobno = reader.GetString(reader.GetOrdinal("PhoneNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("AuditDate"))) _submitteddate = reader.GetDateTime(reader.GetOrdinal("AuditDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("SyForwardedDate"))) _syforwardeddate = reader.GetDateTime(reader.GetOrdinal("SyForwardedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("CentralAgencySyResult"))) _centralagencysyresult = reader.GetBoolean(reader.GetOrdinal("CentralAgencySyResult"));
                if (!reader.IsDBNull(reader.GetOrdinal("SyExamResult"))) _syexamresult = reader.GetInt32(reader.GetOrdinal("SyExamResult"));
                if (!reader.IsDBNull(reader.GetOrdinal("SyProfilePrint"))) _syprofileprint = reader.GetBoolean(reader.GetOrdinal("SyProfilePrint"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsUnitForwarded"))) _isunitforwarded = reader.GetBoolean(reader.GetOrdinal("IsUnitForwarded"));
                if (!reader.IsDBNull(reader.GetOrdinal("UnitClearanceResult"))) _unitclearanceresult = reader.GetInt32(reader.GetOrdinal("UnitClearanceResult"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsMedForwarded"))) _ismedforwarded = reader.GetBoolean(reader.GetOrdinal("IsMedForwarded"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedExamResult"))) _medexamresult = reader.GetInt32(reader.GetOrdinal("MedExamResult"));
                if (!reader.IsDBNull(reader.GetOrdinal("PsychoExamResult"))) _psychoexamresult = reader.GetInt32(reader.GetOrdinal("PsychoExamResult"));
                //if (!reader.IsDBNull(reader.GetOrdinal("SendByDate"))) _notificationsendbydate = reader.GetString(reader.GetOrdinal("SendByDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationCount"))) _noofnotification = reader.GetInt64(reader.GetOrdinal("NotificationCount"));
                if (!reader.IsDBNull(reader.GetOrdinal("isSyResultExpired"))) _issyresultexpired = reader.GetBoolean(reader.GetOrdinal("isSyResultExpired"));
                if (!reader.IsDBNull(reader.GetOrdinal("isSyReTestApproved"))) _issyretestapproved = reader.GetBoolean(reader.GetOrdinal("isSyReTestApproved"));
                CurrentState = EntityState.Unchanged;
            }
        }

    }
}