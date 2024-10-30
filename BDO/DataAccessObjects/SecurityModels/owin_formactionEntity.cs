using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.SecurityModels
{
    [Serializable]
    [DataContract(Name = "owin_formactionEntity", Namespace = "http://www.KAF.com/types")]
    public partial class owin_formactionEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _formactionid;
        protected long ? _parentid;
        protected string _actionname;
        protected string _displaynamear;
        protected string _displayname;
        protected string _actiontype;
        protected bool ? _isview;
        protected bool ? _isapi;
        protected bool ? _isshowonmenu;
        protected string _classicon;
        protected bool ? _isitem;
        protected string _eventname;
        protected int ? _sequence;
                
        
        [DataMember]
        public long ? formactionid
        {
            get { return _formactionid; }
            set { _formactionid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "parentid", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_formaction))]
        public long ? parentid
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
        [Display(Name = "displaynamear", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_formaction))]
        public string displaynamear
        {
            get { return _displaynamear; }
            set { _displaynamear = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "displayname", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_formaction))]
        public string displayname
        {
            get { return _displayname; }
            set { _displayname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "actiontype", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_formaction))]
        public string actiontype
        {
            get { return _actiontype; }
            set { _actiontype = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isview", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_formaction))]
        public bool ? isview
        {
            get { return _isview; }
            set { _isview = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isapi", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_formaction))]
        public bool ? isapi
        {
            get { return _isapi; }
            set { _isapi = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isshowonmenu", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_formaction))]
        public bool ? isshowonmenu
        {
            get { return _isshowonmenu; }
            set { _isshowonmenu = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "classicon", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_formaction))]
        public string classicon
        {
            get { return _classicon; }
            set { _classicon = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isitem", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_formaction))]
        public bool ? isitem
        {
            get { return _isitem; }
            set { _isitem = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "eventname", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_formaction))]
        public string eventname
        {
            get { return _eventname; }
            set { _eventname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "sequence", ResourceType = typeof(CLL.LLClasses.SecurityModels._owin_formaction))]
        public int ? sequence
        {
            get { return _sequence; }
            set { _sequence = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public owin_formactionEntity():base()
        {
        }
        
        public owin_formactionEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public owin_formactionEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
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
                if (!reader.IsDBNull(reader.GetOrdinal("ClassIcon"))) _classicon = reader.GetString(reader.GetOrdinal("ClassIcon"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsItem"))) _isitem = reader.GetBoolean(reader.GetOrdinal("IsItem"));
                if (!reader.IsDBNull(reader.GetOrdinal("EventName"))) _eventname = reader.GetString(reader.GetOrdinal("EventName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Sequence"))) _sequence = reader.GetInt32(reader.GetOrdinal("Sequence"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("FormActionID"))) _formactionid = reader.GetInt64(reader.GetOrdinal("FormActionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ParentID"))) _parentid = reader.GetInt64(reader.GetOrdinal("ParentID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ActionName"))) _actionname = reader.GetString(reader.GetOrdinal("ActionName"));
                if (!reader.IsDBNull(reader.GetOrdinal("DisplayNameAr"))) _displaynamear = reader.GetString(reader.GetOrdinal("DisplayNameAr"));
                if (!reader.IsDBNull(reader.GetOrdinal("DisplayName"))) _displayname = reader.GetString(reader.GetOrdinal("DisplayName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ActionType"))) _actiontype = reader.GetString(reader.GetOrdinal("ActionType"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsView"))) _isview = reader.GetBoolean(reader.GetOrdinal("IsView"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsAPI"))) _isapi = reader.GetBoolean(reader.GetOrdinal("IsAPI"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsShowOnMenu"))) _isshowonmenu = reader.GetBoolean(reader.GetOrdinal("IsShowOnMenu"));
                if (!reader.IsDBNull(reader.GetOrdinal("ClassIcon"))) _classicon = reader.GetString(reader.GetOrdinal("ClassIcon"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsItem"))) _isitem = reader.GetBoolean(reader.GetOrdinal("IsItem"));
                if (!reader.IsDBNull(reader.GetOrdinal("EventName"))) _eventname = reader.GetString(reader.GetOrdinal("EventName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Sequence"))) _sequence = reader.GetInt32(reader.GetOrdinal("Sequence"));
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
