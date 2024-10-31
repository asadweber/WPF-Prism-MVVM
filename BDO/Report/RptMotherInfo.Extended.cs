using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BDO.Report
{

    public partial class RptMotherInfo
    {
       
        public RptMotherInfo()
        {

        }
        public RptMotherInfo(IDataReader reader)
        {
         this.loadFormReader(reader);   
        }
        protected void loadFormReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoId"))) BasicInfoId = reader.GetInt64(reader.GetOrdinal("BasicInfoId"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) CivilID = reader.GetString(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name1"))) Name1 = reader.GetString(reader.GetOrdinal("Name1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name2"))) Name2 = reader.GetString(reader.GetOrdinal("Name2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name3"))) Name3 = reader.GetString(reader.GetOrdinal("Name3"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name4"))) Name4 = reader.GetString(reader.GetOrdinal("Name4"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name5"))) Name5 = reader.GetString(reader.GetOrdinal("Name5"));
                if (!reader.IsDBNull(reader.GetOrdinal("BirthDate"))) BirthDate = reader.GetDateTime(reader.GetOrdinal("BirthDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobilePhone1"))) MobilePhone1 = reader.GetString(reader.GetOrdinal("MobilePhone1"));
                if (!reader.IsDBNull(reader.GetOrdinal("LanPhone1"))) LanPhone1 = reader.GetString(reader.GetOrdinal("LanPhone1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Email"))) Email = reader.GetString(reader.GetOrdinal("Email"));
                if (!reader.IsDBNull(reader.GetOrdinal("BirthcountryName"))) BirthcountryName = reader.GetString(reader.GetOrdinal("BirthcountryName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Nationality"))) Nationality = reader.GetString(reader.GetOrdinal("Nationality"));
                if (!reader.IsDBNull(reader.GetOrdinal("BloodGroupName"))) BloodGroupName = reader.GetString(reader.GetOrdinal("BloodGroupName"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportNumber"))) PassportNumber = reader.GetString(reader.GetOrdinal("PassportNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReligionName"))) ReligionName = reader.GetString(reader.GetOrdinal("ReligionName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyID"))) FamilyID = reader.GetInt64(reader.GetOrdinal("FamilyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsInKuwait"))) IsInKuwait = reader.GetBoolean(reader.GetOrdinal("IsInKuwait"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsAlive"))) IsAlive = reader.GetBoolean(reader.GetOrdinal("IsAlive"));

            }
        }
            }

}

