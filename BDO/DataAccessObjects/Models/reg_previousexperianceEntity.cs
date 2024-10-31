using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "reg_previousexperianceEntity", Namespace = "http://www.KAF.com/types")]
    public partial class reg_previousexperianceEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _prevexpid;
        protected long ? _basicinfoid;
        protected long ? _companytypeid;
        protected long ? _companyid;
        protected string _companyname;
        protected string _designation;
        protected string _description;
        protected DateTime ? _fromdate;
        protected DateTime ? _todate;
        protected string _filepath;
        protected string _filename;
        protected string _filetype;
        protected string _extension;
        protected string _comment;
        protected string _updateinfo;
        protected long ? _tranformactionid;
                
        
        [DataMember]
        public long ? prevexpid
        {
            get { return _prevexpid; }
            set { _prevexpid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "basicinfoid", ResourceType = typeof(CLL.LLClasses.Models._reg_previousexperiance))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_previousexperiance), ErrorMessageResourceName = "basicinfoidRequired")]
        public long ? basicinfoid
        {
            get { return _basicinfoid; }
            set { _basicinfoid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "companytypeid", ResourceType = typeof(CLL.LLClasses.Models._reg_previousexperiance))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_previousexperiance), ErrorMessageResourceName = "companytypeidRequired")]
        public long ? companytypeid
        {
            get { return _companytypeid; }
            set { _companytypeid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "companyid", ResourceType = typeof(CLL.LLClasses.Models._reg_previousexperiance))]
        public long ? companyid
        {
            get { return _companyid; }
            set { _companyid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "companyname", ResourceType = typeof(CLL.LLClasses.Models._reg_previousexperiance))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_previousexperiance), ErrorMessageResourceName = "companynameRequired")]
        public string companyname
        {
            get { return _companyname; }
            set { _companyname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "designation", ResourceType = typeof(CLL.LLClasses.Models._reg_previousexperiance))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_previousexperiance), ErrorMessageResourceName = "designationRequired")]
        public string designation
        {
            get { return _designation; }
            set { _designation = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "description", ResourceType = typeof(CLL.LLClasses.Models._reg_previousexperiance))]
        public string description
        {
            get { return _description; }
            set { _description = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "fromdate", ResourceType = typeof(CLL.LLClasses.Models._reg_previousexperiance))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_previousexperiance), ErrorMessageResourceName = "fromdateRequired")]
        public DateTime ? fromdate
        {
            get { return _fromdate; }
            set { _fromdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "todate", ResourceType = typeof(CLL.LLClasses.Models._reg_previousexperiance))]
        public DateTime ? todate
        {
            get { return _todate; }
            set { _todate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "filepath", ResourceType = typeof(CLL.LLClasses.Models._reg_previousexperiance))]
        public string filepath
        {
            get { return _filepath; }
            set { _filepath = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "filename", ResourceType = typeof(CLL.LLClasses.Models._reg_previousexperiance))]
        public string filename
        {
            get { return _filename; }
            set { _filename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "filetype", ResourceType = typeof(CLL.LLClasses.Models._reg_previousexperiance))]
        public string filetype
        {
            get { return _filetype; }
            set { _filetype = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "extension", ResourceType = typeof(CLL.LLClasses.Models._reg_previousexperiance))]
        public string extension
        {
            get { return _extension; }
            set { _extension = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "comment", ResourceType = typeof(CLL.LLClasses.Models._reg_previousexperiance))]
        public string comment
        {
            get { return _comment; }
            set { _comment = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._reg_previousexperiance))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._reg_previousexperiance))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public reg_previousexperianceEntity():base()
        {
        }
        
        public reg_previousexperianceEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public reg_previousexperianceEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("PrevExpID"))) _prevexpid = reader.GetInt64(reader.GetOrdinal("PrevExpID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyTypeID"))) _companytypeid = reader.GetInt64(reader.GetOrdinal("CompanyTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyID"))) _companyid = reader.GetInt64(reader.GetOrdinal("CompanyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyName"))) _companyname = reader.GetString(reader.GetOrdinal("CompanyName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Designation"))) _designation = reader.GetString(reader.GetOrdinal("Designation"));
                if (!reader.IsDBNull(reader.GetOrdinal("Description"))) _description = reader.GetString(reader.GetOrdinal("Description"));
                if (!reader.IsDBNull(reader.GetOrdinal("FromDate"))) _fromdate = reader.GetDateTime(reader.GetOrdinal("FromDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ToDate"))) _todate = reader.GetDateTime(reader.GetOrdinal("ToDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FilePath"))) _filepath = reader.GetString(reader.GetOrdinal("FilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileName"))) _filename = reader.GetString(reader.GetOrdinal("FileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileType"))) _filetype = reader.GetString(reader.GetOrdinal("FileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("Extension"))) _extension = reader.GetString(reader.GetOrdinal("Extension"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdateInfo"))) _updateinfo = reader.GetString(reader.GetOrdinal("UpdateInfo"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TranFormActionID"))) _tranformactionid = reader.GetInt64(reader.GetOrdinal("TranFormActionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }


        protected void LoadFromReader(IDataReader reader, bool IsListViewShow)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("PrevExpID"))) _prevexpid = reader.GetInt64(reader.GetOrdinal("PrevExpID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyTypeID"))) _companytypeid = reader.GetInt64(reader.GetOrdinal("CompanyTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyID"))) _companyid = reader.GetInt64(reader.GetOrdinal("CompanyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyName"))) _companyname = reader.GetString(reader.GetOrdinal("CompanyName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Designation"))) _designation = reader.GetString(reader.GetOrdinal("Designation"));
                if (!reader.IsDBNull(reader.GetOrdinal("Description"))) _description = reader.GetString(reader.GetOrdinal("Description"));
                if (!reader.IsDBNull(reader.GetOrdinal("FromDate"))) _fromdate = reader.GetDateTime(reader.GetOrdinal("FromDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ToDate"))) _todate = reader.GetDateTime(reader.GetOrdinal("ToDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FilePath"))) _filepath = reader.GetString(reader.GetOrdinal("FilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileName"))) _filename = reader.GetString(reader.GetOrdinal("FileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileType"))) _filetype = reader.GetString(reader.GetOrdinal("FileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("Extension"))) _extension = reader.GetString(reader.GetOrdinal("Extension"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdateInfo"))) _updateinfo = reader.GetString(reader.GetOrdinal("UpdateInfo"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TranFormActionID"))) _tranformactionid = reader.GetInt64(reader.GetOrdinal("TranFormActionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }
        
        #endregion
        
        
            
    }
}
