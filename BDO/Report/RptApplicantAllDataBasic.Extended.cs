using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BDO.Report
{
    public partial class RptApplicantAllDataBasic
    {
        public RptApplicantAllDataBasic()
        {


        }

        public RptApplicantAllDataBasic(IDataReader reader)
        {
            this.loadFormLoader(reader);

        }

        protected void loadFormLoader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {

                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) RegistrationID = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) CivilID = reader.GetString(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) FullName = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("DOB"))) DOB = reader.GetDateTime(reader.GetOrdinal("DOB"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProfessionName"))) ProfessionName = reader.GetString(reader.GetOrdinal("ProfessionName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CandidateTypeName"))) CandidateTypeName = reader.GetString(reader.GetOrdinal("CandidateTypeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProfessionName"))) ProfessionName = reader.GetString(reader.GetOrdinal("ProfessionName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Nationality"))) Nationality = reader.GetString(reader.GetOrdinal("Nationality"));
                if (!reader.IsDBNull(reader.GetOrdinal("ClassName"))) ClassName = reader.GetString(reader.GetOrdinal("ClassName"));
                if (!reader.IsDBNull(reader.GetOrdinal("BloodGroupName"))) BloodGroupName = reader.GetString(reader.GetOrdinal("BloodGroupName"));
                if (!reader.IsDBNull(reader.GetOrdinal("MaritalStatus"))) MaritalStatus = reader.GetString(reader.GetOrdinal("MaritalStatus"));
                if (!reader.IsDBNull(reader.GetOrdinal("BirthCountry"))) BirthCountry = reader.GetString(reader.GetOrdinal("BirthCountry"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchNo"))) BatchNo = reader.GetInt64(reader.GetOrdinal("BatchNo"));


            }
        }
    }
}
