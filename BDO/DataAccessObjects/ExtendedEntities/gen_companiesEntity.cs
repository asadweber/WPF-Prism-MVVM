using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class gen_companiesEntity : BaseEntity
    {
        #region Properties
    
        protected string ? _companytypename;
        
        [DataMember]
        [Display(Name = "companytypeid", ResourceType = typeof(CLL.LLClasses.Models._gen_companies))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_companies), ErrorMessageResourceName = "companytypeidRequired")]
        public string ? companytypename
        {
            get { return _companytypename; }
            set { _companytypename = value; this.OnChnaged(); }
        }
        
        #endregion
    
        #region Constructor
        
        protected void LoadFromReader(IDataReader reader, int e)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyID"))) _companyid = reader.GetInt64(reader.GetOrdinal("CompanyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyName"))) _companyname = reader.GetString(reader.GetOrdinal("CompanyName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyTypeID"))) _companytypeid = reader.GetInt64(reader.GetOrdinal("CompanyTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyTypeName"))) _companytypename = reader.GetString(reader.GetOrdinal("CompanyTypeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
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
