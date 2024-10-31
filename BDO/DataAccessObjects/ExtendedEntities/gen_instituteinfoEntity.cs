using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class gen_instituteinfoEntity : BaseEntity
    {
        #region Properties
    
        protected string _countryname;
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "countryid", ResourceType = typeof(CLL.LLClasses.Models._gen_instituteinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_instituteinfo), ErrorMessageResourceName = "countryidRequired")]
        public string countryname
        {
            get { return _countryname; }
            set { _countryname = value; this.OnChnaged(); }
        }
        
        #endregion
    
        #region Constructor
    
        protected void LoadFromReader(IDataReader reader, int e)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("InstituteID"))) _instituteid = reader.GetInt64(reader.GetOrdinal("InstituteID"));
                if (!reader.IsDBNull(reader.GetOrdinal("InstituteName"))) _institutename = reader.GetString(reader.GetOrdinal("InstituteName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CountryID"))) _countryid = reader.GetInt64(reader.GetOrdinal("CountryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CountryName"))) _countryname = reader.GetString(reader.GetOrdinal("CountryName"));
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