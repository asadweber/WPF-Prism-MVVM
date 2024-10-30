using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.SecurityModels
{
    [Serializable]
    [DataContract(Name = "owin_rolepermissionExtEntity", Namespace = "http://www.KAF.com/types")]
    public partial class owin_rolepermissionExtEntity : owin_rolepermissionEntity 
    {
        #region Properties
        protected string _rolename;

        protected string _displayname;
        protected string _displaynamear;
        protected long? _parentid;

        protected string _actionname;
        protected string _actiontype;

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "rolename", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_role))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_role), ErrorMessageResourceName = "rolenameRequired")]
        public string rolename
        {
            get { return _rolename; }
            set { _rolename = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "displayname", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_formaction))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_formaction), ErrorMessageResourceName = "formnameRequired")]
        public string displayname
        {
            get { return _displayname; }
            set { _displayname = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "displaynamear", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_formaction))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_formaction), ErrorMessageResourceName = "formnameRequired")]
        public string displaynamear
        {
            get { return _displaynamear; }
            set { _displaynamear = value; this.OnChnaged(); }
        }
        [DataMember]
        [Display(Name = "parentid", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_formaction))]
        public long? parentid
        {
            get { return _parentid; }
            set { _parentid = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "actionname", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_formaction))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_formaction), ErrorMessageResourceName = "actionnameRequired")]
        public string actionname
        {
            get { return _actionname; }
            set { _actionname = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "actiontype", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_formaction))]
        public string actiontype
        {
            get { return _actiontype; }
            set { _actiontype = value; this.OnChnaged(); }
        }
        #endregion

        #region Constructor

        public owin_rolepermissionExtEntity() : base()
        {
        }

        public owin_rolepermissionExtEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                //inherited
                if (!reader.IsDBNull(reader.GetOrdinal("RolePremissionID"))) _rolepremissionid = reader.GetInt64(reader.GetOrdinal("RolePremissionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RoleID"))) _roleid = reader.GetInt64(reader.GetOrdinal("RoleID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FormActionID"))) _formactionid = reader.GetInt64(reader.GetOrdinal("FormActionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Status"))) _status = reader.GetBoolean(reader.GetOrdinal("Status"));

                //from Role info
                if (!reader.IsDBNull(reader.GetOrdinal("RoleName"))) _rolename = reader.GetString(reader.GetOrdinal("RoleName"));
                //from Form info
                if (!reader.IsDBNull(reader.GetOrdinal("DisplayName"))) _displayname = reader.GetString(reader.GetOrdinal("DisplayName"));
                if (!reader.IsDBNull(reader.GetOrdinal("DisplayNameAr"))) _displaynamear = reader.GetString(reader.GetOrdinal("DisplayNameAr"));
                //if (!reader.IsDBNull(reader.GetOrdinal("ParentID"))) _parentid = reader.GetInt64(reader.GetOrdinal("ParentID"));
                //from Form action
                if (!reader.IsDBNull(reader.GetOrdinal("ActionName"))) _actionname = reader.GetString(reader.GetOrdinal("ActionName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ActionType"))) _actiontype = reader.GetString(reader.GetOrdinal("ActionType"));


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
