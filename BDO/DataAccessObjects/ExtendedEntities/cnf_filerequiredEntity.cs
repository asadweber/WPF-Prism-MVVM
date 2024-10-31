using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;

namespace BDO.Core.DataAccessObjects.Models
{
    
    public partial class cnf_filerequiredEntity
    {
    
        protected string? _batchno;
        protected string? _fileconfigname;


        [DataMember]
        public string batchno
        {
            get { return _batchno; }
            set { _batchno = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "fileconfigname", ResourceType = typeof(CLL.LLClasses.Models._cnf_filerequired))]
        public string? fileconfigname
        {
            get { return _fileconfigname; }
            set { _fileconfigname = value; this.OnChnaged(); }
        }

        [DataMember]
        public List<cnf_filerequiredEntity> CnfFileRequiredList { get; set; }

        protected void LoadFromReader(IDataReader reader, int e)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("BatchID"))) _batchid = reader.GetInt64(reader.GetOrdinal("BatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchNo"))) _batchno = reader.GetString(reader.GetOrdinal("BatchNo"));
                CurrentState = EntityState.Unchanged;
            }
        }

    }
}