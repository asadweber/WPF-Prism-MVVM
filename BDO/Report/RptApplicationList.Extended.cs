using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BDO.Report
{
    public partial class RptApplicationList

    {
        public RptApplicationList() { 
        
        }

        public RptApplicationList(IDataReader reader)
        {
            this.loadFormLoader(reader);
        }
        protected void loadFormLoader(IDataReader reader)
        {
            
            if (reader != null && !reader.IsClosed)
            {
                //if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) BasicInfoID = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) RegistrationID = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchNo"))) BatchNo = reader.GetInt64(reader.GetOrdinal("BatchNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchID"))) BatchID = reader.GetInt64(reader.GetOrdinal("BatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CandidateTypeID"))) CandidateTypeID = reader.GetInt64(reader.GetOrdinal("CandidateTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CandidateTypeName"))) CandidateTypeName = reader.GetString(reader.GetOrdinal("CandidateTypeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) FullName = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("professionId"))) professionId = reader.GetInt64(reader.GetOrdinal("professionId"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProfessionName"))) ProfessionName = reader.GetString(reader.GetOrdinal("ProfessionName"));
                if (!reader.IsDBNull(reader.GetOrdinal("DisplayPhaseName"))) PhaseName = reader.GetString(reader.GetOrdinal("DisplayPhaseName"));
                if (!reader.IsDBNull(reader.GetOrdinal("PhaseID"))) PhaseID = reader.GetInt64(reader.GetOrdinal("PhaseID"));
                if (!reader.IsDBNull(reader.GetOrdinal("SubmittedDate"))) SubmittedDate = reader.GetDateTime(reader.GetOrdinal("SubmittedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicationDate"))) ApplicationDate = reader.GetDateTime(reader.GetOrdinal("ApplicationDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("NationalityId"))) NationalityId = reader.GetInt64(reader.GetOrdinal("NationalityId"));
                if (!reader.IsDBNull(reader.GetOrdinal("CountryName"))) CountryName = reader.GetString(reader.GetOrdinal("CountryName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) CivilID = reader.GetString(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusName"))) StatusName = reader.GetString(reader.GetOrdinal("StatusName"));
                if (!reader.IsDBNull(reader.GetOrdinal("mob1"))) mob1 = reader.GetString(reader.GetOrdinal("mob1"));


            }
        }


    }
}
