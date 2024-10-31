using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BDO.Report
{
    public partial class RptApplicantStatus
    {

        public RptApplicantStatus()
        {

        }
        public RptApplicantStatus(IDataReader reader) {
            this.loadFormLoader(reader);
        }
        protected void loadFormLoader(IDataReader reader)
        {
            if (reader!=null && !reader.IsClosed)
            {
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) RegistrationID = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) CivilID = reader.GetString(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchNo"))) BatchNo = reader.GetInt64(reader.GetOrdinal("BatchNo"));
                
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) FullName = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CandidateTypeName"))) CandidateTypeName = reader.GetString(reader.GetOrdinal("CandidateTypeName"));

                if (!reader.IsDBNull(reader.GetOrdinal("ProfessionName"))) ProfessionName = reader.GetString(reader.GetOrdinal("ProfessionName"));
                if (!reader.IsDBNull(reader.GetOrdinal("DisplayPhaseName"))) PhaseName = reader.GetString(reader.GetOrdinal("DisplayPhaseName"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusName"))) StatusName = reader.GetString(reader.GetOrdinal("StatusName"));
                if (!reader.IsDBNull(reader.GetOrdinal("reviewComment"))) reviewComment = reader.GetString(reader.GetOrdinal("reviewComment"));
                if (!reader.IsDBNull(reader.GetOrdinal("reviewDate"))) reviewDate = reader.GetDateTime(reader.GetOrdinal("reviewDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("submittedBy"))) submittedBy = reader.GetString(reader.GetOrdinal("submittedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("submittedDate"))) submittedDate = reader.GetDateTime(reader.GetOrdinal("submittedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PhaseEnteredBy"))) PhaseEnteredBy = reader.GetString(reader.GetOrdinal("PhaseEnteredBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("PhaseEnteredDate"))) PhaseEnteredDate = reader.GetDateTime(reader.GetOrdinal("PhaseEnteredDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicationDate"))) ApplicationDate = reader.GetDateTime(reader.GetOrdinal("ApplicationDate"));
                







            }
        }
    }
}
