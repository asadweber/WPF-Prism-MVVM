using BDO.Core.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;

namespace BDO.DataAccessObjects.ExtendedEntities
{
    [Serializable]
    [DataContract(Name = "GetHRShortProfileEntity", Namespace = "http://www.dsfaf.com/types")]
    public class GetHRShortProfileEntity : BaseEntity
    {
        [DataMember]
        public long? hrbasicid { get; set; }
        [DataMember]
        public long? militaryno { get; set; }
        [DataMember]
        public long? militarytype { get; set; }
        [DataMember]
        public string officertype { get; set; }
        [DataMember]
        public string rankname { get; set; }
        [DataMember]
        public string milcourseprefix { get; set; }
        [DataMember]
        public string fullname { get; set; }
        [DataMember]
        public DateTime? birthdate { get; set; }
        [DataMember]
        public long? civilid { get; set; }
        [DataMember]
        public DateTime? joindate { get; set; }
        [DataMember]
        public long? senno { get; set; }
        [DataMember]
        public Guid userid { get; set; }
        [DataMember]
        public long? rankid { get; set; }
        [DataMember]
        public long? currentunitid { get; set; }
        [DataMember]
        public string currentunit { get; set; }
        [DataMember]
        public string passportno { get; set; }
        [DataMember]
        public string photo { get; set; }
        [DataMember]
        public string orglogo { get; set; }
        [DataMember]
        public long? entitykey { get; set; }
        [DataMember]
        public string mainunit { get; set; }
        [DataMember]
        public string nationality { get; set; }
        [DataMember]
        public string ademail { get; set; }
        [DataMember]
        public string samaccount { get; set; }
        [DataMember]
        public string email { get; set; }
        [DataMember]
        public string entitycode { get; set; }
        [DataMember]
        public string mobileno { get; set; }

        public GetHRShortProfileEntity()
        {
        }

        public GetHRShortProfileEntity(IDataReader ireader)
        {
            //LoadFromReader(ireader);
            LoadFromReaderREF(ireader);
        }

        protected void LoadFromReaderREF(IDataReader reader)
        {
            //SqlDataReader reader = (SqlDataReader)ireader;
            if (reader != null && !reader.IsClosed)
            {
                if (!reader.IsDBNull(reader.GetOrdinal("HRBasicID"))) hrbasicid = reader.GetInt64(reader.GetOrdinal("HRBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MilitaryNo"))) militaryno = reader.GetInt64(reader.GetOrdinal("MilitaryNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("MilitaryType"))) militarytype = reader.GetInt64(reader.GetOrdinal("MilitaryType"));
                if (!reader.IsDBNull(reader.GetOrdinal("OfficerType"))) officertype = reader.GetString(reader.GetOrdinal("OfficerType"));
                if (!reader.IsDBNull(reader.GetOrdinal("RankName"))) rankname = reader.GetString(reader.GetOrdinal("RankName"));
                if (!reader.IsDBNull(reader.GetOrdinal("MilCoursePrefix"))) milcourseprefix = reader.GetString(reader.GetOrdinal("MilCoursePrefix"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("BirthDate"))) birthdate = reader.GetDateTime(reader.GetOrdinal("BirthDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) civilid = reader.GetInt64(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("JoinDate"))) joindate = reader.GetDateTime(reader.GetOrdinal("JoinDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("SenNo"))) senno = reader.GetInt64(reader.GetOrdinal("SenNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserID"))) userid = reader.GetGuid(reader.GetOrdinal("UserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RankID"))) rankid = reader.GetInt64(reader.GetOrdinal("RankID"));
                if (!reader.IsDBNull(reader.GetOrdinal("currentunitid"))) currentunitid = reader.GetInt64(reader.GetOrdinal("currentunitid"));
                if (!reader.IsDBNull(reader.GetOrdinal("currentunit"))) currentunit = reader.GetString(reader.GetOrdinal("currentunit"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportNo"))) passportno = reader.GetString(reader.GetOrdinal("PassportNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("Photo"))) photo = reader.GetString(reader.GetOrdinal("Photo"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrgLogo"))) orglogo = reader.GetString(reader.GetOrdinal("OrgLogo"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntityKey"))) entitykey = reader.GetInt64(reader.GetOrdinal("EntityKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("MainUnit"))) mainunit = reader.GetString(reader.GetOrdinal("MainUnit"));
                if (!reader.IsDBNull(reader.GetOrdinal("Nationality"))) nationality = reader.GetString(reader.GetOrdinal("Nationality"));
                if (!reader.IsDBNull(reader.GetOrdinal("ADEmail"))) ademail = reader.GetString(reader.GetOrdinal("ADEmail"));
                if (!reader.IsDBNull(reader.GetOrdinal("Samaccount"))) samaccount = reader.GetString(reader.GetOrdinal("Samaccount"));
                if (!reader.IsDBNull(reader.GetOrdinal("Email"))) email = reader.GetString(reader.GetOrdinal("Email"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntityCode"))) entitycode = reader.GetString(reader.GetOrdinal("EntityCode"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNo"))) mobileno = reader.GetString(reader.GetOrdinal("MobileNo"));
            }
        }



    }
}
