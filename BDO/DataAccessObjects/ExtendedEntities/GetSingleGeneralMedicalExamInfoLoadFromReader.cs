using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using static BDO.Core.Base.BaseEntity;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class GetSingleGeneralMedicalExamInfoLoadFromReader : reg_registrationinfoEntity
    {
        public GetSingleGeneralMedicalExamInfoLoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) _registrationid = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchID"))) _batchid = reader.GetInt64(reader.GetOrdinal("BatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchNo"))) _batchno = reader.GetInt64(reader.GetOrdinal("BatchNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("CandidateTypeName"))) candidatetypename = reader.GetString(reader.GetOrdinal("CandidateTypeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProfessionName"))) professionname = reader.GetString(reader.GetOrdinal("ProfessionName"));
                if (!reader.IsDBNull(reader.GetOrdinal("PhaseID"))) phaseid = reader.GetInt64(reader.GetOrdinal("PhaseID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _civilid = reader.GetString(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CountryNationality"))) _nationality = reader.GetString(reader.GetOrdinal("CountryNationality"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNo"))) _mobno = reader.GetString(reader.GetOrdinal("MobileNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("CountryBirth"))) _birthcountryname = reader.GetString(reader.GetOrdinal("CountryBirth"));
                if (!reader.IsDBNull(reader.GetOrdinal("Gender"))) _gender = reader.GetInt64(reader.GetOrdinal("Gender"));
                if (!reader.IsDBNull(reader.GetOrdinal("Email"))) email = reader.GetString(reader.GetOrdinal("Email"));
                if (!reader.IsDBNull(reader.GetOrdinal("MaritalStatus"))) _maritalstatus = reader.GetString(reader.GetOrdinal("MaritalStatus"));
                if (!reader.IsDBNull(reader.GetOrdinal("BloodGroupName"))) _bloodgroup = reader.GetString(reader.GetOrdinal("BloodGroupName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReligionName"))) _religionname = reader.GetString(reader.GetOrdinal("ReligionName"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedExamResult"))) _medexamresult = reader.GetInt32(reader.GetOrdinal("MedExamResult"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedExamComment"))) _medexamcomment = reader.GetString(reader.GetOrdinal("MedExamComment"));
                if (!reader.IsDBNull(reader.GetOrdinal("PsychoExamResult"))) _psychoexamresult = reader.GetInt32(reader.GetOrdinal("PsychoExamResult"));
                if (!reader.IsDBNull(reader.GetOrdinal("PsychoExamComment"))) _psychoexamcomment = reader.GetString(reader.GetOrdinal("PsychoExamComment"));
                CurrentState = EntityState.Unchanged;
            }
        }

    }
}