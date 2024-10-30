using BDO.Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace BDO.Core.DataAccessObjects.CommonEntities
{
    
    public class DtParameters : BaseEntity
    {
        private long? _civilId;
        private int? _requestStatus;

        public long? MasterID { get; set; }
        public int Draw { get; set; }
        public DtColumn[] Columns { get; set; }
        public DtOrder[] Order { get; set; }
        public int Start { get; set; }
        public int Length { get; set; }
        public DtSearch Search { get; set; }
        public string SortOrder => Columns != null && Order != null && Order.Length > 0 ? (Columns[Order[0].Column].Data + (Order[0].Dir == DtOrderDir.Desc ? " " + Order[0].Dir : " Asc")) : null;
        public IEnumerable<string> AdditionalValues { get; set; }

        public long? CivilId { get => _civilId; set => _civilId = value; }
        public long? BatchId { get; set; }

        public int? RequestStatus { get => _requestStatus; set => _requestStatus = value; }
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

