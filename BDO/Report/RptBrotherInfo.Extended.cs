using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Xml.Linq;

namespace BDO.Report
{
    public partial class RptBrotherInfo
    {
        public RptBrotherInfo()
        {

        }
        public RptBrotherInfo(IDataReader reader) {
        this.loadFormReader(reader);
        }   

        protected void loadFormReader(IDataReader reader)
        {
            if (reader !=null && !reader.IsClosed)
            {
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) BasicInfoID = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) CivilID = reader.GetString(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("fullname"))) fullname = reader.GetString(reader.GetOrdinal("fullname"));
                if (!reader.IsDBNull(reader.GetOrdinal("BloodGroupName"))) BloodGroupName = reader.GetString(reader.GetOrdinal("BloodGroupName"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportNumber"))) PassportNumber = reader.GetString(reader.GetOrdinal("PassportNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("WorkCompany"))) WorkCompany = reader.GetString(reader.GetOrdinal("WorkCompany"));
                if (!reader.IsDBNull(reader.GetOrdinal("Nationality"))) Nationality = reader.GetString(reader.GetOrdinal("Nationality"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsInKuwait"))) IsInKuwait = reader.GetBoolean(reader.GetOrdinal("IsInKuwait"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsFatherSide"))) IsFatherSide = reader.GetBoolean(reader.GetOrdinal("IsFatherSide"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyID"))) FamilyID = reader.GetInt64(reader.GetOrdinal("FamilyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsMarried"))) IsMarried = reader.GetBoolean(reader.GetOrdinal("IsMarried"));
                
            }
        }
    }
}
