using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BDO.Report
{
    public partial class RptApplicationAssesmentList
    {
        public RptApplicationAssesmentList()
        {

        }
        public RptApplicationAssesmentList(IDataReader reader)
        {
            this.loadFormLoader(reader);
        }

        protected void loadFormLoader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) RegistrationID = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) CivilID = reader.GetString(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchNo"))) BatchNo = reader.GetInt64(reader.GetOrdinal("BatchNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) FullName = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Mobile"))) Mobile = reader.GetString(reader.GetOrdinal("Mobile"));
                if (!reader.IsDBNull(reader.GetOrdinal("Nationality"))) Nationality = reader.GetString(reader.GetOrdinal("Nationality"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProfessionName"))) ProfessionName = reader.GetString(reader.GetOrdinal("ProfessionName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateName"))) CertificateName = reader.GetString(reader.GetOrdinal("CertificateName"));
            }
            }
        }
}
