using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BDO.Report
{
    public partial class RptBatchSummaryRpt
    {
        public RptBatchSummaryRpt()
        {

        }


        public RptBatchSummaryRpt(IDataReader reader)
        {
            this.loadFormReader(reader);
        }

        protected void loadFormReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!reader.IsDBNull(reader.GetOrdinal("PhaseID"))) PhaseID = reader.GetInt64(reader.GetOrdinal("PhaseID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PhaseName"))) PhaseName = reader.GetString(reader.GetOrdinal("PhaseName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) Comment = reader.GetString(reader.GetOrdinal("Comment"));
                if (!reader.IsDBNull(reader.GetOrdinal("PhaseWiseCount"))) PhaseWiseCount = reader.GetInt32(reader.GetOrdinal("PhaseWiseCount"));
               



            }

        }


    }
}
