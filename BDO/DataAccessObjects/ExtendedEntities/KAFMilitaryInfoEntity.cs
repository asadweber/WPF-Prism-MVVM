using BDO.Core.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;

namespace BDO.DataAccessObjects.ExtendedEntities
{
   
    /// This object represents the properties and methods of a KAFGetMilitaryInfo.
    /// </summary>
    [Serializable]
    [DataContract(Name = "KAFMilitaryInfoEntity", Namespace = "http://www.KAF.com/types")]
    public class KAFMilitaryInfoEntity : BaseEntity
    {
        [DataMember]
        public long? hrbasicid { get; set; }
        [DataMember]
        public long? militaryno { get; set; }
        [DataMember]
        public long? civilid { get; set; }
        [DataMember]
        public string name1 { get; set; }
        [DataMember]
        public string name2 { get; set; }
        [DataMember]
        public string name3 { get; set; }
        [DataMember]
        public string name4 { get; set; }
        [DataMember]
        public string name5 { get; set; }
        [DataMember]
        public string fullname { get; set; }
        [DataMember]
        public string mobile1 { get; set; }
        [DataMember]
        public long? rankid { get; set; }
        [DataMember]
        public string rankname { get; set; }
        [DataMember]
        public long? currententitykey { get; set; }
        [DataMember]
        public string currententity { get; set; }
        [DataMember]
        public long? entitykey { get; set; }
        [DataMember]
        public string mainentity { get; set; }
        [DataMember]
        public long? milipossitiondetlid { get; set; }
        [DataMember]
        public long? milipossitionid { get; set; }
        [DataMember]
        public string possitionname { get; set; }

        public KAFMilitaryInfoEntity()
        {
        }

        public KAFMilitaryInfoEntity(IDataReader ireader)
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
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) civilid = reader.GetInt64(reader.GetOrdinal("CivilID"));
                
                if (!reader.IsDBNull(reader.GetOrdinal("Name1"))) name1 = reader.GetString(reader.GetOrdinal("Name1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name2"))) name2 = reader.GetString(reader.GetOrdinal("Name2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name3"))) name3 = reader.GetString(reader.GetOrdinal("Name3"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name4"))) name4 = reader.GetString(reader.GetOrdinal("Name4"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name5"))) name5 = reader.GetString(reader.GetOrdinal("Name5"));

                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Mobile1"))) mobile1 = reader.GetString(reader.GetOrdinal("Mobile1"));
                if (!reader.IsDBNull(reader.GetOrdinal("RankID"))) rankid = reader.GetInt64(reader.GetOrdinal("RankID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RankName"))) rankname = reader.GetString(reader.GetOrdinal("RankName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurrentEntityKey"))) currententitykey = reader.GetInt64(reader.GetOrdinal("CurrentEntityKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurrentEntity"))) currententity = reader.GetString(reader.GetOrdinal("CurrentEntity"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntityKey"))) entitykey = reader.GetInt64(reader.GetOrdinal("EntityKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("MainEntity"))) mainentity = reader.GetString(reader.GetOrdinal("MainEntity"));
                if (!reader.IsDBNull(reader.GetOrdinal("MiliPossitionDetlID"))) milipossitiondetlid = reader.GetInt64(reader.GetOrdinal("MiliPossitionDetlID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MiliPossitionID"))) milipossitionid = reader.GetInt64(reader.GetOrdinal("MiliPossitionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PossitionName"))) possitionname = reader.GetString(reader.GetOrdinal("PossitionName"));
            }
        }



    }
}
