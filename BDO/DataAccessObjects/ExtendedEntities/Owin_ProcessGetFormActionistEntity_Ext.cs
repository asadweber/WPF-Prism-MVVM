using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Core.DataAccessObjects.ExtendedEntities
{
    [Serializable]
    [DataContract(Name = "Owin_ProcessGetFormActionistEntity_Ext", Namespace = "http://www.KAF.com/types")]

    public class Owin_ProcessGetFormActionistEntity_Ext
    {
        //protected Int64? _MenuID;
        //protected String _MenuName;
        protected Int64? _ParentID;
        protected Int64 _AppFormID;
        protected String _FormName;
        protected String _FormNameAR;
        protected String _URL;
        protected Int32? _Sequence;
        protected Int64? _FormActionID;
        protected String _ActionName;
        protected Boolean? _IsView;
        protected Int64? _RolePremissionID;
        protected Int64? _RoleID;
        protected String _RoleName;
        protected Boolean? _Status;
        protected Int64? _MasterUserID;
        protected String _Ex_Nvarchar1;
        protected String _Ex_Nvarchar2;
        protected Boolean? _isvisibleinmenu;

        protected String _EventName;
        protected String _DisplayNameAr;
        protected String _DisplayName;

        protected Int64? _ProfileTypeForModule;
        [DataMember]
        public Int64? ProfileTypeForModule
        {
            get { return _ProfileTypeForModule; }
            set { _ProfileTypeForModule = value; }
        }

        [DataMember]
        public Int64? ParentID
        {
            get { return _ParentID; }
            set { _ParentID = value; }
        }
        [DataMember]
        public Int64 AppFormID
        {
            get { return _AppFormID; }
            set { _AppFormID = value; }
        }
        [DataMember]
        public String FormName
        {
            get { return _FormName; }
            set { _FormName = value; }
        }
        [DataMember]
        public String FormNameAR
        {
            get { return _FormNameAR; }
            set { _FormNameAR = value; }
        }
        [DataMember]
        public String URL
        {
            get { return _URL; }
            set { _URL = value; }
        }
        [DataMember]
        public Int32? Sequence
        {
            get { return _Sequence; }
            set { _Sequence = value; }
        }
        [DataMember]
        public Int64? FormActionID
        {
            get { return _FormActionID; }
            set { _FormActionID = value; }
        }
        [DataMember]
        public String ActionName
        {
            get { return _ActionName; }
            set { _ActionName = value; }
        }

        [DataMember]
        public Boolean? IsView
        {
            get { return _IsView; }
            set { _IsView = value; }
        }

        [DataMember]
        public Boolean? IsVisibleInMenu
        {
            get { return _isvisibleinmenu; }
            set { _isvisibleinmenu = value; }
        }

        [DataMember]
        public Int64? RolePremissionID
        {
            get { return _RolePremissionID; }
            set { _RolePremissionID = value; }
        }

        [DataMember]
        public Boolean? Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        [DataMember]
        public Int64? MasterUserID
        {
            get { return _MasterUserID; }
            set { _MasterUserID = value; }
        }
        [DataMember]
        public String Ex_Nvarchar1
        {
            get { return _Ex_Nvarchar1; }
            set { _Ex_Nvarchar1 = value; }
        }
        [DataMember]
        public String Ex_Nvarchar2
        {
            get { return _Ex_Nvarchar2; }
            set { _Ex_Nvarchar2 = value; }
        }


        [DataMember]
        public String EventName
        {
            get { return _EventName; }
            set { _EventName = value; }
        }
        [DataMember]
        public String DisplayNameAr
        {
            get { return _DisplayNameAr; }
            set { _DisplayNameAr = value; }
        }
        [DataMember]
        public String DisplayName
        {
            get { return _DisplayName; }
            set { _DisplayName = value; }
        }


        public Owin_ProcessGetFormActionistEntity_Ext() : base()
        {

        }

        public Owin_ProcessGetFormActionistEntity_Ext(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        protected void LoadFromReader(IDataReader reader)
        {

            if (!reader.IsDBNull(reader.GetOrdinal("ParentID"))) _ParentID = reader.GetInt64(reader.GetOrdinal("ParentID"));
            if (!reader.IsDBNull(reader.GetOrdinal("AppFormID"))) _AppFormID = reader.GetInt64(reader.GetOrdinal("AppFormID"));
            if (!reader.IsDBNull(reader.GetOrdinal("FormName"))) _FormName = reader.GetString(reader.GetOrdinal("FormName"));
            if (!reader.IsDBNull(reader.GetOrdinal("FormNameAR"))) _FormNameAR = reader.GetString(reader.GetOrdinal("FormNameAR"));
            if (!reader.IsDBNull(reader.GetOrdinal("URL"))) _URL = reader.GetString(reader.GetOrdinal("URL"));
            if (!reader.IsDBNull(reader.GetOrdinal("Sequence"))) _Sequence = reader.GetInt32(reader.GetOrdinal("Sequence"));
            if (!reader.IsDBNull(reader.GetOrdinal("FormActionID"))) _FormActionID = reader.GetInt64(reader.GetOrdinal("FormActionID"));
            if (!reader.IsDBNull(reader.GetOrdinal("ActionName"))) _ActionName = reader.GetString(reader.GetOrdinal("ActionName"));
            if (!reader.IsDBNull(reader.GetOrdinal("IsView"))) _IsView = reader.GetBoolean(reader.GetOrdinal("IsView"));
            if (!reader.IsDBNull(reader.GetOrdinal("IsVisibleInMenu"))) _isvisibleinmenu = reader.GetBoolean(reader.GetOrdinal("IsVisibleInMenu"));

            //if (!reader.IsDBNull(reader.GetOrdinal("RolePremissionID"))) _RolePremissionID = reader.GetInt64(reader.GetOrdinal("RolePremissionID"));
            //if (!reader.IsDBNull(reader.GetOrdinal("RoleID"))) _FormActionID = reader.GetInt64(reader.GetOrdinal("RoleID"));
            //if (!reader.IsDBNull(reader.GetOrdinal("RoleName"))) _RoleName = reader.GetString(reader.GetOrdinal("RoleName"));
            if (!reader.IsDBNull(reader.GetOrdinal("Status"))) _Status = reader.GetBoolean(reader.GetOrdinal("Status"));
            if (!reader.IsDBNull(reader.GetOrdinal("Ex_Nvarchar1"))) _Ex_Nvarchar1 = reader.GetString(reader.GetOrdinal("Ex_Nvarchar1"));

            if (!reader.IsDBNull(reader.GetOrdinal("EventName"))) _EventName = reader.GetString(reader.GetOrdinal("EventName"));
            if (!reader.IsDBNull(reader.GetOrdinal("DisplayName"))) _DisplayName = reader.GetString(reader.GetOrdinal("DisplayName"));
            if (!reader.IsDBNull(reader.GetOrdinal("DisplayNameAr"))) _DisplayNameAr = reader.GetString(reader.GetOrdinal("DisplayNameAr"));
        }

        public Owin_ProcessGetFormActionistEntity_Ext(IDataReader reader, int i)
        {
            this.LoadFromReader(reader, i);
        }

        protected void LoadFromReader(IDataReader reader, int i)
        {

            if (!reader.IsDBNull(reader.GetOrdinal("AppFormID"))) _AppFormID = reader.GetInt64(reader.GetOrdinal("AppFormID"));
            if (!reader.IsDBNull(reader.GetOrdinal("FormActionID"))) _FormActionID = reader.GetInt64(reader.GetOrdinal("FormActionID"));
            if (!reader.IsDBNull(reader.GetOrdinal("ActionName"))) _ActionName = reader.GetString(reader.GetOrdinal("ActionName"));
            if (!reader.IsDBNull(reader.GetOrdinal("ProfileTypeForModule"))) _ProfileTypeForModule = reader.GetInt64(reader.GetOrdinal("ProfileTypeForModule"));
        }
    }
}
