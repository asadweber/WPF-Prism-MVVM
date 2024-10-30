using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Core.DataAccessObjects.ExtendedEntities
{
    [Serializable]
    [DataContract(Name = "Owin_ProcessGetFormActionistEntity", Namespace = "http://www.KAF.com/types")]

    public class Owin_ProcessGetFormActionistEntity
    {
        protected Int64? _MenuID;
        protected String _MenuName;
        protected Int64? _ParentID;
        protected Int64? _AppFormID;
        protected String _FormName;
        protected String _FormNameAr;
        protected String _URL;
        protected Int32? _Sequence;
        protected Int64? _FormActionID;
        protected String _ActionName;
        protected Boolean? _IsView;
        protected Boolean? _Status;
        protected Int64? _MasterUserID;
        protected Int64? _RoleID;
        protected DateTime? _Ex_Date1;
        protected DateTime? _Ex_Date2;
        protected String _Ex_Nvarchar3;
        protected String _Ex_Nvarchar1;
        protected String _Ex_Nvarchar2;
        protected Int64? _Ex_Bigint1;
        protected Int64? _Ex_Bigint2;
        protected Decimal? _Ex_Decimal1;
        protected Decimal? _Ex_Decimal2;
        protected String _SortExpression;
        protected Int64? _CreatedBy;
        protected String _CreatedByUserName;
        protected Int64? _UpdatedBy;
        protected String _UpdatedByUserName;
        protected DateTime? _CreatedDate;
        protected DateTime? _UpdatedDate;
        protected Int64? _FormID;
        protected String _IPAddress;
        protected String _TransID;
        protected Int64? _UserOrganizationKey;
        protected Int64? _UserEntityKey;
        protected Int64? _Ts;




        [DataMember]
        public Int64? MenuID
        {
            get { return _MenuID; }
            set { _MenuID = value; }
        }
        [DataMember]
        public String MenuName
        {
            get { return _MenuName; }
            set { _MenuName = value; }
        }
        [DataMember]
        public Int64? ParentID
        {
            get { return _ParentID; }
            set { _ParentID = value; }
        }
        [DataMember]
        public Int64? AppFormID
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
        public String FormNameAr
        {
            get { return _FormNameAr; }
            set { _FormNameAr = value; }
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
        public Int64? RoleID
        {
            get { return _RoleID; }
            set { _RoleID = value; }
        }
        [DataMember]
        public DateTime? Ex_Date1
        {
            get { return _Ex_Date1; }
            set { _Ex_Date1 = value; }
        }
        [DataMember]
        public DateTime? Ex_Date2
        {
            get { return _Ex_Date2; }
            set { _Ex_Date2 = value; }
        }
        [DataMember]
        public String Ex_Nvarchar3
        {
            get { return _Ex_Nvarchar3; }
            set { _Ex_Nvarchar3 = value; }
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
        public Int64? Ex_Bigint1
        {
            get { return _Ex_Bigint1; }
            set { _Ex_Bigint1 = value; }
        }
        [DataMember]
        public Int64? Ex_Bigint2
        {
            get { return _Ex_Bigint2; }
            set { _Ex_Bigint2 = value; }
        }
        [DataMember]
        public Decimal? Ex_Decimal1
        {
            get { return _Ex_Decimal1; }
            set { _Ex_Decimal1 = value; }
        }
        [DataMember]
        public Decimal? Ex_Decimal2
        {
            get { return _Ex_Decimal2; }
            set { _Ex_Decimal2 = value; }
        }

        [DataMember]
        public Int64? CreatedBy
        {
            get { return _CreatedBy; }
            set { _CreatedBy = value; }
        }
        [DataMember]
        public String CreatedByUserName
        {
            get { return _CreatedByUserName; }
            set { _CreatedByUserName = value; }
        }
        [DataMember]
        public Int64? UpdatedBy
        {
            get { return _UpdatedBy; }
            set { _UpdatedBy = value; }
        }
        [DataMember]
        public String UpdatedByUserName
        {
            get { return _UpdatedByUserName; }
            set { _UpdatedByUserName = value; }
        }
        [DataMember]
        public DateTime? CreatedDate
        {
            get { return _CreatedDate; }
            set { _CreatedDate = value; }
        }
        [DataMember]
        public DateTime? UpdatedDate
        {
            get { return _UpdatedDate; }
            set { _UpdatedDate = value; }
        }
        [DataMember]
        public Int64? FormID
        {
            get { return _FormID; }
            set { _FormID = value; }
        }
        [DataMember]
        public String IPAddress
        {
            get { return _IPAddress; }
            set { _IPAddress = value; }
        }
        [DataMember]
        public String TransID
        {
            get { return _TransID; }
            set { _TransID = value; }
        }
        [DataMember]
        public Int64? UserOrganizationKey
        {
            get { return _UserOrganizationKey; }
            set { _UserOrganizationKey = value; }
        }
        [DataMember]
        public Int64? UserEntityKey
        {
            get { return _UserEntityKey; }
            set { _UserEntityKey = value; }
        }
        [DataMember]
        public Int64? Ts
        {
            get { return _Ts; }
            set { _Ts = value; }
        }

        protected String _EventName;
        protected String _DisplayNameAr;
        protected String _DisplayName;

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

        public Owin_ProcessGetFormActionistEntity() : base()
        {

        }

        public Owin_ProcessGetFormActionistEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        public Owin_ProcessGetFormActionistEntity(IDataReader reader, string spname)
        {
            this.LoadFromReader(reader, spname);
        }
        protected void LoadFromReader(IDataReader reader)
        {
            //if (!reader.IsDBNull(reader.GetOrdinal("MenuID"))) _MenuID = reader.GetInt64(reader.GetOrdinal("MenuID"));
            // if (!reader.IsDBNull(reader.GetOrdinal("MenuName"))) _MenuName = reader.GetString(reader.GetOrdinal("MenuName"));
            if (!reader.IsDBNull(reader.GetOrdinal("ParentID"))) _ParentID = reader.GetInt64(reader.GetOrdinal("ParentID"));
            if (!reader.IsDBNull(reader.GetOrdinal("AppFormID"))) _AppFormID = reader.GetInt64(reader.GetOrdinal("AppFormID"));
            if (!reader.IsDBNull(reader.GetOrdinal("FormName"))) _FormName = reader.GetString(reader.GetOrdinal("FormName"));
            if (!reader.IsDBNull(reader.GetOrdinal("FormNameAr"))) _FormNameAr = reader.GetString(reader.GetOrdinal("FormNameAr"));
            if (!reader.IsDBNull(reader.GetOrdinal("URL"))) _URL = reader.GetString(reader.GetOrdinal("URL"));
            if (!reader.IsDBNull(reader.GetOrdinal("Sequence"))) _Sequence = reader.GetInt32(reader.GetOrdinal("Sequence"));
            if (!reader.IsDBNull(reader.GetOrdinal("FormActionID"))) _FormActionID = reader.GetInt64(reader.GetOrdinal("FormActionID"));
            if (!reader.IsDBNull(reader.GetOrdinal("ActionName"))) _ActionName = reader.GetString(reader.GetOrdinal("ActionName"));
            if (!reader.IsDBNull(reader.GetOrdinal("IsView"))) _IsView = reader.GetBoolean(reader.GetOrdinal("IsView"));
            if (!reader.IsDBNull(reader.GetOrdinal("Status"))) _Status = reader.GetBoolean(reader.GetOrdinal("Status"));

            if (!reader.IsDBNull(reader.GetOrdinal("EventName"))) _EventName = reader.GetString(reader.GetOrdinal("EventName"));
            if (!reader.IsDBNull(reader.GetOrdinal("DisplayName"))) _DisplayName = reader.GetString(reader.GetOrdinal("DisplayName"));
            if (!reader.IsDBNull(reader.GetOrdinal("DisplayNameAr"))) _DisplayNameAr = reader.GetString(reader.GetOrdinal("DisplayNameAr"));
        }

        protected void LoadFromReader(IDataReader reader, string spname)
        {
            if (!reader.IsDBNull(reader.GetOrdinal("AppFormID"))) _AppFormID = reader.GetInt64(reader.GetOrdinal("AppFormID"));
            if (!reader.IsDBNull(reader.GetOrdinal("FormActionID"))) _FormActionID = reader.GetInt64(reader.GetOrdinal("FormActionID"));
            if (!reader.IsDBNull(reader.GetOrdinal("ActionName"))) _ActionName = reader.GetString(reader.GetOrdinal("ActionName"));
        }
    }
}
