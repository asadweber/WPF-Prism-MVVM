using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BDO.Report
{
    public partial class RptMedicalExamForm
    {
        public RptMedicalExamForm()
        {
        }

        public RptMedicalExamForm(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!reader.IsDBNull(reader.GetOrdinal("volunteerNo"))) volunteerNo = reader.GetInt64(reader.GetOrdinal("volunteerNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchNo"))) BatchNo = reader.GetInt64(reader.GetOrdinal("BatchNo"));
               
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) FullName = reader.GetString(reader.GetOrdinal("FullName"));

                if (!reader.IsDBNull(reader.GetOrdinal("CertificateName"))) CertificateName = reader.GetString(reader.GetOrdinal("CertificateName"));

                if (!reader.IsDBNull(reader.GetOrdinal("Mob1"))) Mob1 = reader.GetString(reader.GetOrdinal("Mob1"));
            }
        }
    }
}
