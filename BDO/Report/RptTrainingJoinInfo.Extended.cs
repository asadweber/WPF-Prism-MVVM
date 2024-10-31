using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BDO.Report
{
    public partial class RptTrainingJoinInfo
    {
        public RptTrainingJoinInfo()
        {
        }

        public RptTrainingJoinInfo(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) BasicInfoId = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilId"))) CivilId = reader.GetString(reader.GetOrdinal("CivilId"));
               
                if (!reader.IsDBNull(reader.GetOrdinal("JoinDate"))) JoinDate = reader.GetDateTime(reader.GetOrdinal("JoinDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("VolunteerNo"))) VolunteerNo = reader.GetInt64(reader.GetOrdinal("VolunteerNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("TrainingCentreName"))) TrainingCentreName = reader.GetString(reader.GetOrdinal("TrainingCentreName"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchNo"))) BatchNo = reader.GetInt64(reader.GetOrdinal("BatchNo"));
            }
        }
    }
}
