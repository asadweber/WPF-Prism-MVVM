using System;
using System.Data;
using System.Runtime.Serialization;

namespace BDO.Core.DataAccessObjects.ExtendedEntities
{
    [Serializable]
    [DataContract(Name = "MenuEntity", Namespace = "http://www.KAF.com/types")]


    public class MenuEntity
    {
        [DataMember]
        public long FormActionID { get; set; }
        [DataMember]
        public long? ParentID { get; set; }
        [DataMember]
        public string ActionName { get; set; }
        [DataMember]
        public string DisplayNameAr { get; set; }
        [DataMember]
        public string DisplayName { get; set; }
        [DataMember]
        public string ActionType { get; set; }

        [DataMember]
        public bool? IsView { get; set; }

        [DataMember]
        public bool? IsAPI { get; set; }

        [DataMember]
        public bool? IsShowOnMenu { get; set; }
        [DataMember]
        public string ClassIcon { get; set; }

        [DataMember]
        public bool? IsItem { get; set; }
        [DataMember]
        public string EventName { get; set; }
        [DataMember]
        public int? Sequence  { get; set; }


        public MenuEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!reader.IsDBNull(reader.GetOrdinal("FormActionID"))) FormActionID = reader.GetInt64(reader.GetOrdinal("FormActionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ParentID"))) ParentID = reader.GetInt64(reader.GetOrdinal("ParentID"));

                if (!reader.IsDBNull(reader.GetOrdinal("ActionName"))) ActionName = reader.GetString(reader.GetOrdinal("ActionName"));
                if (!reader.IsDBNull(reader.GetOrdinal("DisplayNameAr"))) DisplayNameAr = reader.GetString(reader.GetOrdinal("DisplayNameAr"));
                if (!reader.IsDBNull(reader.GetOrdinal("DisplayName"))) DisplayName = reader.GetString(reader.GetOrdinal("DisplayName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ActionType"))) ActionType = reader.GetString(reader.GetOrdinal("ActionType"));

                if (!reader.IsDBNull(reader.GetOrdinal("IsView"))) IsView = reader.GetBoolean(reader.GetOrdinal("IsView"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsAPI"))) IsAPI = reader.GetBoolean(reader.GetOrdinal("IsAPI"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsShowOnMenu"))) IsShowOnMenu = reader.GetBoolean(reader.GetOrdinal("IsShowOnMenu"));
                if (!reader.IsDBNull(reader.GetOrdinal("ClassIcon"))) ClassIcon = reader.GetString(reader.GetOrdinal("ClassIcon"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsItem"))) IsItem = reader.GetBoolean(reader.GetOrdinal("IsItem"));
                if (!reader.IsDBNull(reader.GetOrdinal("EventName"))) EventName = reader.GetString(reader.GetOrdinal("EventName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Sequence"))) Sequence = reader.GetInt32(reader.GetOrdinal("Sequence"));
            }
        }
    }
}
