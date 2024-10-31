using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BDO.Report
{
    public partial class RptVolunteerExamLogList

    {
        public RptVolunteerExamLogList()
        {

        }

        public RptVolunteerExamLogList(IDataReader reader)
        {
            this.loadFormLoader(reader);
        }
        protected void loadFormLoader(IDataReader reader)
        {

            if (reader != null && !reader.IsClosed)
            {


                if (!reader.IsDBNull(reader.GetOrdinal("BatchNo"))) BatchNo = reader.GetInt64(reader.GetOrdinal("BatchNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchID"))) BatchID = reader.GetInt64(reader.GetOrdinal("BatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) CivilID = reader.GetString(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) FullName = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Mob1"))) Mob1 = reader.GetString(reader.GetOrdinal("Mob1"));
                if (!reader.IsDBNull(reader.GetOrdinal("CandidateTypeName"))) CandidateTypeName = reader.GetString(reader.GetOrdinal("CandidateTypeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("nationality"))) nationality = reader.GetString(reader.GetOrdinal("nationality"));
               

                if (!reader.IsDBNull(reader.GetOrdinal("Ready"))) Ready = reader.GetInt32(reader.GetOrdinal("Ready"));
                if (!reader.IsDBNull(reader.GetOrdinal("Forwarded"))) Forwarded = reader.GetInt32(reader.GetOrdinal("Forwarded"));
                if (!reader.IsDBNull(reader.GetOrdinal("ForwardDate"))) ForwardDate = reader.GetDateTime(reader.GetOrdinal("ForwardDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ResultDate"))) ResultDate = reader.GetDateTime(reader.GetOrdinal("ResultDate"));

                if (!reader.IsDBNull(reader.GetOrdinal("Result"))) Result = reader.GetInt32(reader.GetOrdinal("Result"));
                if (!reader.IsDBNull(reader.GetOrdinal("dayscount"))) dayscount = reader.GetInt32(reader.GetOrdinal("dayscount"));
               





            }
        }


    }
}
