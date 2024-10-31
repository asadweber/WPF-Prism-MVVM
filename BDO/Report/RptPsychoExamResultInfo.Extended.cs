using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BDO.Report
{
    public partial class RptPsychoExamResultInfo
    {
        public RptPsychoExamResultInfo()
        {
        }

        public RptPsychoExamResultInfo(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)


            {
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) CivilID = reader.GetString(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ExamResultID"))) ExamResultID = reader.GetInt64(reader.GetOrdinal("ExamResultID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoId"))) BasicInfoId = reader.GetInt64(reader.GetOrdinal("BasicInfoId"));
                if (!reader.IsDBNull(reader.GetOrdinal("ExamResult"))) ExamResult = reader.GetInt64(reader.GetOrdinal("ExamResult"));
                if (!reader.IsDBNull(reader.GetOrdinal("ExamComment"))) ExamComment = reader.GetString(reader.GetOrdinal("ExamComment"));

                if (!reader.IsDBNull(reader.GetOrdinal("ExamResultDate"))) ExamResultDate = reader.GetDateTime(reader.GetOrdinal("ExamResultDate"));

                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) Remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("Examtype"))) examtype = reader.GetInt32(reader.GetOrdinal("Examtype"));
            }
        }
    }
}
