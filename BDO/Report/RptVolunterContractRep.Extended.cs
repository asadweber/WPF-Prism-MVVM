using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BDO.Report
{
    public partial class RptVolunterContractRep
    {
        public RptVolunterContractRep()
        {


        }

        public RptVolunterContractRep(IDataReader reader)
        {
            this.loadFormLoader(reader);

        }

        protected void loadFormLoader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {

                if (!reader.IsDBNull(reader.GetOrdinal("VolunteerNo"))) VolunteerNo = reader.GetInt64(reader.GetOrdinal("VolunteerNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) FullName = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReqNo"))) ReqNo = reader.GetString(reader.GetOrdinal("ReqNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) CivilID = reader.GetString(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name1"))) Name1 = reader.GetString(reader.GetOrdinal("Name1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name2"))) Name2 = reader.GetString(reader.GetOrdinal("Name2"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateName"))) CertificateName = reader.GetString(reader.GetOrdinal("CertificateName"));
                if (!reader.IsDBNull(reader.GetOrdinal("BirthDate"))) BirthDate = reader.GetDateTime(reader.GetOrdinal("BirthDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("JoinDate"))) JoinDate = reader.GetDateTime(reader.GetOrdinal("JoinDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("AddrsGover"))) AddrsGover = reader.GetString(reader.GetOrdinal("AddrsGover"));
                if (!reader.IsDBNull(reader.GetOrdinal("AddrsArea"))) AddrsArea = reader.GetString(reader.GetOrdinal("AddrsArea"));
                if (!reader.IsDBNull(reader.GetOrdinal("AddrsBlock"))) AddrsBlock = reader.GetString(reader.GetOrdinal("AddrsBlock"));
                if (!reader.IsDBNull(reader.GetOrdinal("AddrsStreet"))) AddrsStreet = reader.GetString(reader.GetOrdinal("AddrsStreet"));
                if (!reader.IsDBNull(reader.GetOrdinal("AddrsHouse"))) AddrsHouse = reader.GetString(reader.GetOrdinal("AddrsHouse"));
                if (!reader.IsDBNull(reader.GetOrdinal("Nationality"))) Nationality = reader.GetString(reader.GetOrdinal("Nationality"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProfessionName"))) ProfessionName = reader.GetString(reader.GetOrdinal("ProfessionName"));
                if (!reader.IsDBNull(reader.GetOrdinal("V_DAY"))) V_DAY = reader.GetInt64(reader.GetOrdinal("V_DAY"));
               

            }
        }
    }
}
