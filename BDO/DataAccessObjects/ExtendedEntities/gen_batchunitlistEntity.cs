using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
  
    public partial class gen_batchunitlistEntity : BaseEntity
    {
        #region Properties
    
        protected string ? _batchnumber;
        protected string ? _entityname;
        
        [DataMember]
        [Display(Name = "batchno", ResourceType = typeof(CLL.LLClasses.Models._gen_batchunitlist))]
        public string ? batchnumber
        {
            get { return _batchnumber; }
            set { _batchnumber = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "entitykey", ResourceType = typeof(CLL.LLClasses.Models._gen_batchunitlist))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_batchunitlist), ErrorMessageResourceName = "entitykeyRequired")]
        public string ? entityname
        {
            get { return _entityname; }
            set { _entityname = value; this.OnChnaged(); }
        }
        
        #endregion
    
        #region Constructor
    
        protected void LoadFromReader(IDataReader reader, int e)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("BatchUnitListID"))) _batchunitlistid = reader.GetInt64(reader.GetOrdinal("BatchUnitListID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchID"))) _batchid = reader.GetInt64(reader.GetOrdinal("BatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchNumber"))) _batchnumber = reader.GetString(reader.GetOrdinal("BatchNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntityKey"))) _entitykey = reader.GetInt64(reader.GetOrdinal("EntityKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntitytName"))) _entityname = reader.GetString(reader.GetOrdinal("EntitytName"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }

        #endregion
        
    }
}
