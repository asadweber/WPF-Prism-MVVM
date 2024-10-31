using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BDO.Report
{
    public partial class RptVolunteerClearanceList

    {
        public RptVolunteerClearanceList() { 
        
        }

        public RptVolunteerClearanceList(IDataReader reader)
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
                if (!reader.IsDBNull(reader.GetOrdinal("ProfessionName"))) ProfessionName = reader.GetString(reader.GetOrdinal("ProfessionName"));

                if (!reader.IsDBNull(reader.GetOrdinal("ReadyForSecurity"))) ReadyForSecurity = reader.GetInt32(reader.GetOrdinal("ReadyForSecurity"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsSecurityForwarded"))) IsSecurityForwarded = reader.GetInt32(reader.GetOrdinal("IsSecurityForwarded"));
                if (!reader.IsDBNull(reader.GetOrdinal("SecForwardDate"))) SecForwardDate = reader.GetDateTime(reader.GetOrdinal("SecForwardDate"));

                if (!reader.IsDBNull(reader.GetOrdinal("ReadyForUnit"))) ReadyForUnit = reader.GetInt32(reader.GetOrdinal("ReadyForUnit"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsUnitForwarded"))) IsUnitForwarded = reader.GetInt32(reader.GetOrdinal("IsUnitForwarded"));
                if (!reader.IsDBNull(reader.GetOrdinal("UnitForwardDate"))) UnitForwardDate = reader.GetDateTime(reader.GetOrdinal("UnitForwardDate"));

                if (!reader.IsDBNull(reader.GetOrdinal("ReadyForMedical"))) ReadyForMedical = reader.GetInt32(reader.GetOrdinal("ReadyForMedical"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsMedForwarded"))) IsMedForwarded = reader.GetInt32(reader.GetOrdinal("IsMedForwarded"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedForwardDate"))) MedForwardDate = reader.GetDateTime(reader.GetOrdinal("MedForwardDate"));


                
               


            }
        }


    }
}
