using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BDO.Report
{
    public partial class RptEducationInfo
    {
        public RptEducationInfo()
        {
        }

        public RptEducationInfo(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {

                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoId"))) BasicInfoId = reader.GetInt64(reader.GetOrdinal("BasicInfoId"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateLevel"))) CertificateLevel = reader.GetString(reader.GetOrdinal("CertificateLevel"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateSubjectName"))) CertificateSubjectName = reader.GetString(reader.GetOrdinal("CertificateSubjectName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateName"))) CertificateName = reader.GetString(reader.GetOrdinal("CertificateName"));
                if (!reader.IsDBNull(reader.GetOrdinal("InstituteName"))) InstituteName = reader.GetString(reader.GetOrdinal("InstituteName"));
                if (!reader.IsDBNull(reader.GetOrdinal("EduGradeName"))) EduGradeName = reader.GetString(reader.GetOrdinal("EduGradeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Points"))) Points = reader.GetDecimal(reader.GetOrdinal("Points"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassYear"))) PassYear = reader.GetDateTime(reader.GetOrdinal("PassYear"));
                if (!reader.IsDBNull(reader.GetOrdinal("CountryName"))) CountryName = reader.GetString(reader.GetOrdinal("CountryName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) Comment = reader.GetString(reader.GetOrdinal("Comment"));
            }
        }
    }
}
