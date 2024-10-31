using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using static BDO.Core.Base.BaseEntity;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class TrainingJoinInfoLoadFromReader : reg_registrationinfoEntity
    {
        public TrainingJoinInfoLoadFromReader(IDataReader reader)
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
                if (!reader.IsDBNull(reader.GetOrdinal("FinalExamResultDate"))) _finalexamResultDate = reader.GetDateTime(reader.GetOrdinal("FinalExamResultDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("isTrgJoinEnabled"))) _istrgjoinenabled = reader.GetBoolean(reader.GetOrdinal("isTrgJoinEnabled"));
                if (!reader.IsDBNull(reader.GetOrdinal("TrgJoinID"))) TrgJoinID = reader.GetInt64(reader.GetOrdinal("TrgJoinID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TrgCentreID"))) TrgCentreID = reader.GetInt64(reader.GetOrdinal("TrgCentreID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TrainingCentreName"))) TrgCentreName = reader.GetString(reader.GetOrdinal("TrainingCentreName"));
                if (!reader.IsDBNull(reader.GetOrdinal("JoinDate"))) JoinDate = reader.GetDateTime(reader.GetOrdinal("JoinDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("VolunteerNo"))) VolunteerNo = reader.GetInt64(reader.GetOrdinal("VolunteerNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrderNo"))) OrderNo = reader.GetString(reader.GetOrdinal("OrderNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrderDate"))) OrderDate = reader.GetDateTime(reader.GetOrdinal("OrderDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationCount"))) _noofnotification = reader.GetInt64(reader.GetOrdinal("NotificationCount"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsExported"))) _isexported = reader.GetBoolean(reader.GetOrdinal("IsExported"));
                if (!reader.IsDBNull(reader.GetOrdinal("ExportedDate"))) _exporteddate = reader.GetDateTime(reader.GetOrdinal("ExportedDate"));
                CurrentState = EntityState.Unchanged;
            }
        }

    }
}