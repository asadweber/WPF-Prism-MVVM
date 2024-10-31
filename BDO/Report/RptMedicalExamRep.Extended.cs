using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BDO.Report
{
    public partial class RptMedicalExamRep
    {
        public RptMedicalExamRep()
        { 
        }
        public RptMedicalExamRep(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
               
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) CivilId = reader.GetString(reader.GetOrdinal("CivilID"));
               
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) FullName = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Dob"))) Dob = reader.GetDateTime(reader.GetOrdinal("Dob"));
               
                if (!reader.IsDBNull(reader.GetOrdinal("Mob1"))) Mob1 = reader.GetString(reader.GetOrdinal("Mob1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Mob2"))) Mob2 = reader.GetString(reader.GetOrdinal("Mob2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Mob3"))) Mob3 = reader.GetString(reader.GetOrdinal("Mob3"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddGovernarate"))) PreAddGovernarate = reader.GetString(reader.GetOrdinal("PreAddGovernarate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddCity"))) PreAddCity = reader.GetString(reader.GetOrdinal("PreAddCity"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddBlock"))) PreAddBlock = reader.GetString(reader.GetOrdinal("PreAddBlock"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddStreet"))) PreAddStreet = reader.GetString(reader.GetOrdinal("PreAddStreet"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddHousingNo"))) PreAddHousingNo = reader.GetString(reader.GetOrdinal("PreAddHousingNo"));

                if (!reader.IsDBNull(reader.GetOrdinal("FullAddress"))) FullAddress = reader.GetString(reader.GetOrdinal("FullAddress"));

                if (!reader.IsDBNull(reader.GetOrdinal("Nationality"))) Nationality = reader.GetString(reader.GetOrdinal("Nationality"));
                
                
                if (!reader.IsDBNull(reader.GetOrdinal("BloodGroupName"))) BloodGroupName = reader.GetString(reader.GetOrdinal("BloodGroupName"));
               




            }
        }
    }
}
