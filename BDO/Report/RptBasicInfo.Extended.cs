using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BDO.Report
{
    public partial class RptBasicInfo
    {
        public RptBasicInfo()
        { 
        }
        public RptBasicInfo(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoId"))) BasicInfoId = reader.GetInt64(reader.GetOrdinal("BasicInfoId"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) CivilId = reader.GetString(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportNo"))) PassportNo = reader.GetString(reader.GetOrdinal("PassportNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) FullName = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Dob"))) Dob = reader.GetDateTime(reader.GetOrdinal("Dob"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name1"))) Name1 = reader.GetString(reader.GetOrdinal("Name1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name2"))) Name2 = reader.GetString(reader.GetOrdinal("Name2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name3"))) Name3 = reader.GetString(reader.GetOrdinal("Name3"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name4"))) Name4 = reader.GetString(reader.GetOrdinal("Name4"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name5"))) Name5 = reader.GetString(reader.GetOrdinal("Name5"));
                if (!reader.IsDBNull(reader.GetOrdinal("Gender"))) Gender = reader.GetInt64(reader.GetOrdinal("Gender"));
                if (!reader.IsDBNull(reader.GetOrdinal("Mob1"))) Mob1 = reader.GetString(reader.GetOrdinal("Mob1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Mob2"))) Mob2 = reader.GetString(reader.GetOrdinal("Mob2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Mob3"))) Mob3 = reader.GetString(reader.GetOrdinal("Mob3"));

                if (!reader.IsDBNull(reader.GetOrdinal("Telephone1"))) Telephone1 = reader.GetString(reader.GetOrdinal("Telephone1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Telephone2"))) Telephone2 = reader.GetString(reader.GetOrdinal("Telephone2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Telephone3"))) Telephone3 = reader.GetString(reader.GetOrdinal("Telephone3"));
                if (!reader.IsDBNull(reader.GetOrdinal("Email"))) Email = reader.GetString(reader.GetOrdinal("Email"));
                
                if (!reader.IsDBNull(reader.GetOrdinal("Nationality"))) Nationality = reader.GetString(reader.GetOrdinal("Nationality"));
                
                if (!reader.IsDBNull(reader.GetOrdinal("ClassName"))) ClassName = reader.GetString(reader.GetOrdinal("ClassName"));
                if (!reader.IsDBNull(reader.GetOrdinal("BloodGroupName"))) BloodGroupName = reader.GetString(reader.GetOrdinal("BloodGroupName"));
                if (!reader.IsDBNull(reader.GetOrdinal("MaritalStatus"))) MaritalStatus = reader.GetString(reader.GetOrdinal("MaritalStatus"));
                if (!reader.IsDBNull(reader.GetOrdinal("BirthCountryId"))) BirthCountryId = reader.GetInt64(reader.GetOrdinal("BirthCountryId"));
                if (!reader.IsDBNull(reader.GetOrdinal("BirthCountry"))) BirthCountry = reader.GetString(reader.GetOrdinal("BirthCountry"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReligionName"))) ReligionName = reader.GetString(reader.GetOrdinal("ReligionName"));

                if (!reader.IsDBNull(reader.GetOrdinal("PreAddCountryId"))) PreAddCountryId = reader.GetInt64(reader.GetOrdinal("PreAddCountryId"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddGovernId"))) PreAddGovernId = reader.GetInt64(reader.GetOrdinal("PreAddGovernId"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddGovernarate"))) PreAddGovernarate = reader.GetString(reader.GetOrdinal("PreAddGovernarate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddCityId"))) PreAddCityId = reader.GetInt64(reader.GetOrdinal("PreAddCityId"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddCity"))) PreAddCity = reader.GetString(reader.GetOrdinal("PreAddCity"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddStreet"))) PreAddStreet = reader.GetString(reader.GetOrdinal("PreAddStreet"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddBlock"))) PreAddBlock = reader.GetString(reader.GetOrdinal("PreAddBlock"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddHousingNo"))) PreAddHousingNo = reader.GetString(reader.GetOrdinal("PreAddHousingNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddHousingFlatNo"))) PreAddHousingFlatNo = reader.GetString(reader.GetOrdinal("PreAddHousingFlatNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddress"))) PreAddress = reader.GetString(reader.GetOrdinal("PreAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("PrePaci"))) PrePaci = reader.GetString(reader.GetOrdinal("PrePaci"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerPaci"))) PerPaci = reader.GetString(reader.GetOrdinal("PerPaci"));
                if (!reader.IsDBNull(reader.GetOrdinal("PresentCountry"))) PresentCountry = reader.GetString(reader.GetOrdinal("PresentCountry"));



            }
        }
    }
}
