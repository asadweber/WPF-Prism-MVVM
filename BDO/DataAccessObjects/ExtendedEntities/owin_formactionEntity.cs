using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;

namespace BDO.Core.DataAccessObjects.SecurityModels
{

    public partial class owin_formactionEntity
    {
        #region Properties

        protected long? _roleid;
        protected bool? _status;

        [DataMember]
        [Display(Name = "roleid", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_rolepermission))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_rolepermission), ErrorMessageResourceName = "roleidRequired")]
        public long? roleid
        {
            get { return _roleid; }
            set { _roleid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "status", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_rolepermission))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.SecurityModels._owin_rolepermission), ErrorMessageResourceName = "statusRequired")]
        public bool? status
        {
            get { return _status; }
            set { _status = value; this.OnChnaged(); }
        }

        public long? masteruserid { get; set; }

        public owin_formactionEntity(IDataReader reader, bool IsListViewShow, bool custom)
        {
            this.LoadFromReader(reader, IsListViewShow, custom);
        }

        protected void LoadFromReader(IDataReader reader, bool IsListViewShow, bool custom)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("FormActionID"))) _formactionid = reader.GetInt64(reader.GetOrdinal("FormActionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ParentID"))) _parentid = reader.GetInt64(reader.GetOrdinal("ParentID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ActionName"))) _actionname = reader.GetString(reader.GetOrdinal("ActionName"));
                if (!reader.IsDBNull(reader.GetOrdinal("DisplayNameAr"))) _displaynamear = reader.GetString(reader.GetOrdinal("DisplayNameAr"));
                if (!reader.IsDBNull(reader.GetOrdinal("DisplayName"))) _displayname = reader.GetString(reader.GetOrdinal("DisplayName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ActionType"))) _actiontype = reader.GetString(reader.GetOrdinal("ActionType"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsView"))) _isview = reader.GetBoolean(reader.GetOrdinal("IsView"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsAPI"))) _isapi = reader.GetBoolean(reader.GetOrdinal("IsAPI"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsShowOnMenu"))) _isshowonmenu = reader.GetBoolean(reader.GetOrdinal("IsShowOnMenu"));
                //if (!reader.IsDBNull(reader.GetOrdinal("ClassIcon"))) _classicon = reader.GetString(reader.GetOrdinal("ClassIcon"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsItem"))) _isitem = reader.GetBoolean(reader.GetOrdinal("IsItem"));
                if (!reader.IsDBNull(reader.GetOrdinal("EventName"))) _eventname = reader.GetString(reader.GetOrdinal("EventName"));
                if (!reader.IsDBNull(reader.GetOrdinal("RoleID"))) _roleid = reader.GetInt64(reader.GetOrdinal("RoleID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Status"))) _status = reader.GetBoolean(reader.GetOrdinal("Status"));

                CurrentState = EntityState.Unchanged;
            }
        }

        #endregion
    }
}
