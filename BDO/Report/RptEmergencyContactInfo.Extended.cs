using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BDO.Report
{
    public partial class RptEmergencyContactInfo
    {
        public RptEmergencyContactInfo()
        {

        }

        public RptEmergencyContactInfo(IDataReader reader)
        {
            this.loadFormLoader(reader);
        }
        protected void loadFormLoader(IDataReader reader)
        {

            if (reader !=null && !reader.IsClosed)
            {

                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) BasicInfoID = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyID"))) FamilyID = reader.GetInt64(reader.GetOrdinal("FamilyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name1"))) Name1 = reader.GetString(reader.GetOrdinal("Name1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name2"))) Name2 = reader.GetString(reader.GetOrdinal("Name2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name3"))) Name3 = reader.GetString(reader.GetOrdinal("Name3"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name4"))) Name4 = reader.GetString(reader.GetOrdinal("Name4"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name5"))) Name5 = reader.GetString(reader.GetOrdinal("Name5"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) FullName = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("EmrgRelationshipName"))) EmrgRelationshipName = reader.GetString(reader.GetOrdinal("EmrgRelationshipName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Mobile1"))) Mobile1 = reader.GetString(reader.GetOrdinal("Mobile1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Mobile2"))) Mobile2 = reader.GetString(reader.GetOrdinal("Mobile2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Telephone1"))) Telephone1 = reader.GetString(reader.GetOrdinal("Telephone1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Email"))) Email = reader.GetString(reader.GetOrdinal("Email"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) Remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) Comment = reader.GetString(reader.GetOrdinal("Comment"));
            }
        }

    }
}
