using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BDO.Report
{
    public partial class RptRegistrationInfo
    {
        public RptRegistrationInfo() { }
        public RptRegistrationInfo(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) BasicInfoId = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CandidateTypeID"))) CandidateTypeId = reader.GetInt64(reader.GetOrdinal("CandidateTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Idtype"))) Idtype = reader.GetInt64(reader.GetOrdinal("Idtype"));
                if (!reader.IsDBNull(reader.GetOrdinal("IdexpiryDate"))) IdexpiryDate = reader.GetDateTime(reader.GetOrdinal("IdexpiryDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IdissueDate"))) IdissueDate = reader.GetDateTime(reader.GetOrdinal("IdissueDate"));

                if (!reader.IsDBNull(reader.GetOrdinal("CandidateTypeName"))) CandidateTypeName = reader.GetString(reader.GetOrdinal("CandidateTypeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProfessionName"))) ProfessionName = reader.GetString(reader.GetOrdinal("ProfessionName"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchNo"))) BatchNo = reader.GetInt64(reader.GetOrdinal("BatchNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicationDate"))) ApplicationDate = reader.GetDateTime(reader.GetOrdinal("ApplicationDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchDetails"))) BatchDetails = reader.GetString(reader.GetOrdinal("BatchDetails"));


            }
        }
    }
}
