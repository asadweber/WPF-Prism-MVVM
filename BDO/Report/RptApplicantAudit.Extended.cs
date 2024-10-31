using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BDO.Report
{
    public partial class RptApplicantAudit
    {
        public RptApplicantAudit()
        {

        }

        public RptApplicantAudit(IDataReader reader)
        {
            this.loadFormLoader(reader);
        }

        protected void loadFormLoader(IDataReader reader)
        {
            if (reader!=null && !reader.IsClosed)
            {
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) RegistrationID = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicationDate"))) ApplicationDate = reader.GetDateTime(reader.GetOrdinal("ApplicationDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoSerial"))) BasicInfoSerial = reader.GetInt64(reader.GetOrdinal("BasicInfoSerial"));
                if (!reader.IsDBNull(reader.GetOrdinal("Nationality"))) Nationality = reader.GetString(reader.GetOrdinal("Nationality"));
                if (!reader.IsDBNull(reader.GetOrdinal("FinalEligibleRank"))) eligibleRank = reader.GetString(reader.GetOrdinal("FinalEligibleRank"));
                if (!reader.IsDBNull(reader.GetOrdinal("CandidateTypeName"))) CandidateTypeName = reader.GetString(reader.GetOrdinal("CandidateTypeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProfessionName"))) ProfessionName = reader.GetString(reader.GetOrdinal("ProfessionName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) FullName = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CandidateType"))) CandidateType = reader.GetString(reader.GetOrdinal("CandidateType"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) CivilID = reader.GetString(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BirthCountry"))) BirthCountry = reader.GetString(reader.GetOrdinal("BirthCountry"));
                if (!reader.IsDBNull(reader.GetOrdinal("DOB"))) dob = reader.GetDateTime(reader.GetOrdinal("DOB"));
                if (!reader.IsDBNull(reader.GetOrdinal("AreaName"))) AreaName = reader.GetString(reader.GetOrdinal("AreaName"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddBlock"))) PreAddBlock= reader.GetString(reader.GetOrdinal("PreAddBlock"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddStreet"))) PreAddStreet = reader.GetString(reader.GetOrdinal("PreAddStreet"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddHousingNo"))) PreAddHousingNo = reader.GetString(reader.GetOrdinal("PreAddHousingNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("Mob1"))) Mob1 = reader.GetString(reader.GetOrdinal("Mob1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Mob2"))) Mob2 = reader.GetString(reader.GetOrdinal("Mob2"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateName"))) CertificateName = reader.GetString(reader.GetOrdinal("CertificateName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateSubjectName"))) CertificateSubjectName = reader.GetString(reader.GetOrdinal("CertificateSubjectName"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsStudying"))) IsStudying = reader.GetBoolean(reader.GetOrdinal("IsStudying"));
                if (!reader.IsDBNull(reader.GetOrdinal("MotherFullName"))) MotherFullName = reader.GetString(reader.GetOrdinal("MotherFullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("MotherNationality"))) MotherNationality = reader.GetString(reader.GetOrdinal("MotherNationality"));
                if (!reader.IsDBNull(reader.GetOrdinal("MotherNationalityClass"))) MotherNationalityClass = reader.GetString(reader.GetOrdinal("MotherNationalityClass"));
                if (!reader.IsDBNull(reader.GetOrdinal("FatherStatus"))) FatherStatus = reader.GetString(reader.GetOrdinal("FatherStatus"));
                if (!reader.IsDBNull(reader.GetOrdinal("FatherJob"))) FatherJob = reader.GetString(reader.GetOrdinal("FatherJob"));

                if (!reader.IsDBNull(reader.GetOrdinal("MaritalStatus"))) MaritalStatus = reader.GetString(reader.GetOrdinal("MaritalStatus"));
            }
        }
    }
}
