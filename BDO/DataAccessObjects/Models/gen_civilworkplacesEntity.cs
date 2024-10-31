using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_civilworkplacesEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_civilworkplacesEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _civilworkplacesid;
        protected long ? _parentid;
        protected string _workplacename;
        protected string _workplacenameeng;
        protected long ? _governorateid;
        protected long ? _areaid;
        protected string _block;
        protected string _address;
        protected string _remarks;
        
        [DataMember]
        public long ? civilworkplacesid
        {
            get { return _civilworkplacesid; }
            set { _civilworkplacesid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "parentid", ResourceType = typeof(CLL.LLClasses.Models._gen_civilworkplaces))]
        public long ? parentid
        {
            get { return _parentid; }
            set { _parentid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(100)]
        [Display(Name = "workplacename", ResourceType = typeof(CLL.LLClasses.Models._gen_civilworkplaces))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_civilworkplaces), ErrorMessageResourceName = "workplacenameRequired")]
        public string workplacename
        {
            get { return _workplacename; }
            set { _workplacename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(100)]
        [Display(Name = "workplacenameeng", ResourceType = typeof(CLL.LLClasses.Models._gen_civilworkplaces))]
        public string workplacenameeng
        {
            get { return _workplacenameeng; }
            set { _workplacenameeng = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "governorateid", ResourceType = typeof(CLL.LLClasses.Models._gen_civilworkplaces))]
        public long ? governorateid
        {
            get { return _governorateid; }
            set { _governorateid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "areaid", ResourceType = typeof(CLL.LLClasses.Models._gen_civilworkplaces))]
        public long ? areaid
        {
            get { return _areaid; }
            set { _areaid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(350)]
        [Display(Name = "block", ResourceType = typeof(CLL.LLClasses.Models._gen_civilworkplaces))]
        public string block
        {
            get { return _block; }
            set { _block = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "address", ResourceType = typeof(CLL.LLClasses.Models._gen_civilworkplaces))]
        public string address
        {
            get { return _address; }
            set { _address = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._gen_civilworkplaces))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        #endregion
    
        #region Constructor
    
        public gen_civilworkplacesEntity():base()
        {
        }
        
        public gen_civilworkplacesEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_civilworkplacesEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }

        public gen_civilworkplacesEntity(IDataReader reader, int e)
        {
            this.LoadFromReader(reader, e);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("CivilWorkPlacesID"))) _civilworkplacesid = reader.GetInt64(reader.GetOrdinal("CivilWorkPlacesID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ParentID"))) _parentid = reader.GetInt64(reader.GetOrdinal("ParentID"));
                if (!reader.IsDBNull(reader.GetOrdinal("WorkPlaceName"))) _workplacename = reader.GetString(reader.GetOrdinal("WorkPlaceName"));
                if (!reader.IsDBNull(reader.GetOrdinal("WorkPlaceNameEng"))) _workplacenameeng = reader.GetString(reader.GetOrdinal("WorkPlaceNameEng"));
                if (!reader.IsDBNull(reader.GetOrdinal("GovernorateID"))) _governorateid = reader.GetInt64(reader.GetOrdinal("GovernorateID"));
                if (!reader.IsDBNull(reader.GetOrdinal("AreaID"))) _areaid = reader.GetInt64(reader.GetOrdinal("AreaID"));
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


        protected void LoadFromReader(IDataReader reader, bool IsListViewShow)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("CivilWorkPlacesID"))) _civilworkplacesid = reader.GetInt64(reader.GetOrdinal("CivilWorkPlacesID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ParentID"))) _parentid = reader.GetInt64(reader.GetOrdinal("ParentID"));
                if (!reader.IsDBNull(reader.GetOrdinal("WorkPlaceName"))) _workplacename = reader.GetString(reader.GetOrdinal("WorkPlaceName"));
                if (!reader.IsDBNull(reader.GetOrdinal("WorkPlaceNameEng"))) _workplacenameeng = reader.GetString(reader.GetOrdinal("WorkPlaceNameEng"));
                if (!reader.IsDBNull(reader.GetOrdinal("GovernorateID"))) _governorateid = reader.GetInt64(reader.GetOrdinal("GovernorateID"));
                if (!reader.IsDBNull(reader.GetOrdinal("AreaID"))) _areaid = reader.GetInt64(reader.GetOrdinal("AreaID"));
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
