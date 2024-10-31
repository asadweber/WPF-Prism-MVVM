using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class gen_civilworkplacesEntity : BaseEntity
    {
        #region Properties
    
        protected string _governorate;
        protected string _area;
        
        [DataMember]
        [MaxLength(100)]
        [Display(Name = "governorateid", ResourceType = typeof(CLL.LLClasses.Models._gen_civilworkplaces))]
        public string governorate
        {
            get { return _governorate; }
            set { _governorate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(100)]
        [Display(Name = "areaid", ResourceType = typeof(CLL.LLClasses.Models._gen_civilworkplaces))]
        public string area
        {
            get { return _area; }
            set { _area = value; this.OnChnaged(); }
        }
        
        #endregion
    
        #region Constructor
    
        protected void LoadFromReader(IDataReader reader, int e)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("CivilWorkPlacesID"))) _civilworkplacesid = reader.GetInt64(reader.GetOrdinal("CivilWorkPlacesID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ParentID"))) _parentid = reader.GetInt64(reader.GetOrdinal("ParentID"));
                if (!reader.IsDBNull(reader.GetOrdinal("WorkPlaceName"))) _workplacename = reader.GetString(reader.GetOrdinal("WorkPlaceName"));
                if (!reader.IsDBNull(reader.GetOrdinal("WorkPlaceNameEng"))) _workplacenameeng = reader.GetString(reader.GetOrdinal("WorkPlaceNameEng"));
                if (!reader.IsDBNull(reader.GetOrdinal("GovernorateID"))) _governorateid = reader.GetInt64(reader.GetOrdinal("GovernorateID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Governorate"))) _governorate = reader.GetString(reader.GetOrdinal("Governorate"));
                if (!reader.IsDBNull(reader.GetOrdinal("AreaID"))) _areaid = reader.GetInt64(reader.GetOrdinal("AreaID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Area"))) _area = reader.GetString(reader.GetOrdinal("Area"));
                if (!reader.IsDBNull(reader.GetOrdinal("Block"))) _block = reader.GetString(reader.GetOrdinal("Block"));
                if (!reader.IsDBNull(reader.GetOrdinal("Address"))) _address = reader.GetString(reader.GetOrdinal("Address"));
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
