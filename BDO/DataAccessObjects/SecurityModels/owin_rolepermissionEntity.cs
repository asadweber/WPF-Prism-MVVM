using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.SecurityModels
{
    [Serializable]
    [DataContract(Name = "owin_rolepermissionEntity", Namespace = "http://www.KAF.com/types")]
    public partial class owin_rolepermissionEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _rolepremissionid;
        protected long ? _roleid;
        protected long ? _formactionid;
        protected bool ? _status;
                
        
        [DataMember]
        public long ? rolepremissionid
        {
            get { return _rolepremissionid; }
            set { _rolepremissionid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "roleid", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_rolepermission))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_rolepermission), ErrorMessageResourceName = "roleidRequired")]
        public long ? roleid
        {
            get { return _roleid; }
            set { _roleid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "formactionid", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_rolepermission))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_rolepermission), ErrorMessageResourceName = "formactionidRequired")]
        public long ? formactionid
        {
            get { return _formactionid; }
            set { _formactionid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "status", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_rolepermission))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_rolepermission), ErrorMessageResourceName = "statusRequired")]
        public bool ? status
        {
            get { return _status; }
            set { _status = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public owin_rolepermissionEntity():base()
        {
        }
        
        public owin_rolepermissionEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public owin_rolepermissionEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("RolePremissionID"))) _rolepremissionid = reader.GetInt64(reader.GetOrdinal("RolePremissionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RoleID"))) _roleid = reader.GetInt64(reader.GetOrdinal("RoleID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FormActionID"))) _formactionid = reader.GetInt64(reader.GetOrdinal("FormActionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Status"))) _status = reader.GetBoolean(reader.GetOrdinal("Status"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("RolePremissionID"))) _rolepremissionid = reader.GetInt64(reader.GetOrdinal("RolePremissionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RoleID"))) _roleid = reader.GetInt64(reader.GetOrdinal("RoleID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FormActionID"))) _formactionid = reader.GetInt64(reader.GetOrdinal("FormActionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Status"))) _status = reader.GetBoolean(reader.GetOrdinal("Status"));
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
