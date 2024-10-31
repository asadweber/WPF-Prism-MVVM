using BDO.Core.Base;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Core.DataAccessObjects.CommonEntities
{
    public class DtParameters : BaseEntity
    {
        [DataMember]
        public long? MasterID { get; set; }
        [DataMember]
        public int Draw { get; set; }
        [DataMember]
        public DtColumn[] Columns { get; set; }
        [DataMember]
        public DtOrder[] Order { get; set; }
        [DataMember]
        public int Start { get; set; }
        [DataMember]
        public int Length { get; set; }
        [DataMember]
        public DtSearch Search { get; set; }
        [DataMember]
        public string SortOrder => Columns != null && Order != null && Order.Length > 0 ? (Columns[Order[0].Column].Data + (Order[0].Dir == DtOrderDir.Desc ? " " + Order[0].Dir : string.Empty)) : null;
        [DataMember]
        public IEnumerable<string> AdditionalValues { get; set; }
    }

    public class DtColumn
    {
        public string Data { get; set; }
        public string Name { get; set; }
        public bool Searchable { get; set; }
        public bool Orderable { get; set; }
        public DtSearch Search { get; set; }
    }

    public class DtOrder
    {
        public int Column { get; set; }
        public DtOrderDir Dir { get; set; }
    }

    public enum DtOrderDir
    {
        Asc,
        Desc
    }

    public class DtSearch
    {
        public string Value { get; set; }
        public bool Regex { get; set; }
    }

}
