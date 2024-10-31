using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BDO.Report
{
    public partial class RptMedicalResultInfo
    {
        public RptMedicalResultInfo()
        {
        }

        public RptMedicalResultInfo(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!reader.IsDBNull(reader.GetOrdinal("MedExamResultID"))) MedExamResultID = reader.GetInt64(reader.GetOrdinal("MedExamResultID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoId"))) BasicInfoId = reader.GetInt64(reader.GetOrdinal("BasicInfoId"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedExamResult"))) MedExamResult = reader.GetInt32(reader.GetOrdinal("MedExamResult"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedExamComment"))) MedExamComment = reader.GetString(reader.GetOrdinal("MedExamComment"));
              
                if (!reader.IsDBNull(reader.GetOrdinal("MedExamResultDate"))) MedExamResultDate = reader.GetDateTime(reader.GetOrdinal("MedExamResultDate"));
              
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) Remarks = reader.GetString(reader.GetOrdinal("Remarks"));
            }
        }
    }
}
