using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BDO.Report
{
    public partial class RptVolunteerCertificate

    {
        public RptVolunteerCertificate()
        {

        }

        public RptVolunteerCertificate(IDataReader reader)
        {
            this.loadFormLoader(reader);
        }
        protected void loadFormLoader(IDataReader reader)
        {

            if (reader != null && !reader.IsClosed)
            {


                if (!reader.IsDBNull(reader.GetOrdinal("BatchNo"))) BatchNo = reader.GetInt64(reader.GetOrdinal("BatchNo"));
               
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) CivilID = reader.GetString(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) FullName = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Mob1"))) Mob1 = reader.GetString(reader.GetOrdinal("Mob1"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateName"))) CertificateName = reader.GetString(reader.GetOrdinal("CertificateName"));
                if (!reader.IsDBNull(reader.GetOrdinal("EducationMajorName"))) EducationMajorName = reader.GetString(reader.GetOrdinal("EducationMajorName"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassYear"))) PassYear = reader.GetDateTime(reader.GetOrdinal("PassYear"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicationDate"))) ApplicationDate = reader.GetDateTime(reader.GetOrdinal("ApplicationDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PhaseName"))) PhaseName = reader.GetString(reader.GetOrdinal("PhaseName"));







            }
        }


    }
}
