using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "stp_organizationEntity", Namespace = "http://www.KAF.com/types")]
    public partial class stp_organizationEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _organizationkey;
        protected string _organizationname;
        protected string _addresslineone;
        protected string _addresslinetwo;
        protected string _phone;
        protected string _email;
        protected string _website;
        protected string _domain;
        protected string _fax;
        protected bool ? _ismailenable;
        protected string _smtphost;
        protected long ? _mailport;
        protected string _smtpusername;
        protected string _smtppassword;
        protected bool ? _mailssl;
        protected string _fromemailaddress;
        protected string _maildisplayname;
        protected bool ? _isftpenable;
        protected string _ftpaddress;
        protected string _ftpport;
        protected string _ftpusername;
        protected string _ftppassword;
        protected bool ? _isssl;
        protected string _logoimg;
        protected string _webheader;
        protected string _folderpath;
        protected string _updateinfo;
        protected long ? _tranformactionid;
                
        
        [DataMember]
        public long ? organizationkey
        {
            get { return _organizationkey; }
            set { _organizationkey = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "organizationname", ResourceType = typeof(CLL.LLClasses.Models._stp_organization))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._stp_organization), ErrorMessageResourceName = "organizationnameRequired")]
        public string organizationname
        {
            get { return _organizationname; }
            set { _organizationname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "addresslineone", ResourceType = typeof(CLL.LLClasses.Models._stp_organization))]
        public string addresslineone
        {
            get { return _addresslineone; }
            set { _addresslineone = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "addresslinetwo", ResourceType = typeof(CLL.LLClasses.Models._stp_organization))]
        public string addresslinetwo
        {
            get { return _addresslinetwo; }
            set { _addresslinetwo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "phone", ResourceType = typeof(CLL.LLClasses.Models._stp_organization))]
        public string phone
        {
            get { return _phone; }
            set { _phone = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "email", ResourceType = typeof(CLL.LLClasses.Models._stp_organization))]
        public string email
        {
            get { return _email; }
            set { _email = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "website", ResourceType = typeof(CLL.LLClasses.Models._stp_organization))]
        public string website
        {
            get { return _website; }
            set { _website = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "domain", ResourceType = typeof(CLL.LLClasses.Models._stp_organization))]
        public string domain
        {
            get { return _domain; }
            set { _domain = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "fax", ResourceType = typeof(CLL.LLClasses.Models._stp_organization))]
        public string fax
        {
            get { return _fax; }
            set { _fax = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "ismailenable", ResourceType = typeof(CLL.LLClasses.Models._stp_organization))]
        public bool ? ismailenable
        {
            get { return _ismailenable; }
            set { _ismailenable = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "smtphost", ResourceType = typeof(CLL.LLClasses.Models._stp_organization))]
        public string smtphost
        {
            get { return _smtphost; }
            set { _smtphost = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "mailport", ResourceType = typeof(CLL.LLClasses.Models._stp_organization))]
        public long ? mailport
        {
            get { return _mailport; }
            set { _mailport = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "smtpusername", ResourceType = typeof(CLL.LLClasses.Models._stp_organization))]
        public string smtpusername
        {
            get { return _smtpusername; }
            set { _smtpusername = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "smtppassword", ResourceType = typeof(CLL.LLClasses.Models._stp_organization))]
        public string smtppassword
        {
            get { return _smtppassword; }
            set { _smtppassword = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "mailssl", ResourceType = typeof(CLL.LLClasses.Models._stp_organization))]
        public bool ? mailssl
        {
            get { return _mailssl; }
            set { _mailssl = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "fromemailaddress", ResourceType = typeof(CLL.LLClasses.Models._stp_organization))]
        public string fromemailaddress
        {
            get { return _fromemailaddress; }
            set { _fromemailaddress = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "maildisplayname", ResourceType = typeof(CLL.LLClasses.Models._stp_organization))]
        public string maildisplayname
        {
            get { return _maildisplayname; }
            set { _maildisplayname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isftpenable", ResourceType = typeof(CLL.LLClasses.Models._stp_organization))]
        public bool ? isftpenable
        {
            get { return _isftpenable; }
            set { _isftpenable = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "ftpaddress", ResourceType = typeof(CLL.LLClasses.Models._stp_organization))]
        public string ftpaddress
        {
            get { return _ftpaddress; }
            set { _ftpaddress = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "ftpport", ResourceType = typeof(CLL.LLClasses.Models._stp_organization))]
        public string ftpport
        {
            get { return _ftpport; }
            set { _ftpport = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "ftpusername", ResourceType = typeof(CLL.LLClasses.Models._stp_organization))]
        public string ftpusername
        {
            get { return _ftpusername; }
            set { _ftpusername = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "ftppassword", ResourceType = typeof(CLL.LLClasses.Models._stp_organization))]
        public string ftppassword
        {
            get { return _ftppassword; }
            set { _ftppassword = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isssl", ResourceType = typeof(CLL.LLClasses.Models._stp_organization))]
        public bool ? isssl
        {
            get { return _isssl; }
            set { _isssl = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(350)]
        [Display(Name = "logoimg", ResourceType = typeof(CLL.LLClasses.Models._stp_organization))]
        public string logoimg
        {
            get { return _logoimg; }
            set { _logoimg = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(350)]
        [Display(Name = "webheader", ResourceType = typeof(CLL.LLClasses.Models._stp_organization))]
        public string webheader
        {
            get { return _webheader; }
            set { _webheader = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(350)]
        [Display(Name = "folderpath", ResourceType = typeof(CLL.LLClasses.Models._stp_organization))]
        public string folderpath
        {
            get { return _folderpath; }
            set { _folderpath = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._stp_organization))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._stp_organization))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public stp_organizationEntity():base()
        {
        }
        
        public stp_organizationEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public stp_organizationEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("OrganizationKey"))) _organizationkey = reader.GetInt64(reader.GetOrdinal("OrganizationKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrganizationName"))) _organizationname = reader.GetString(reader.GetOrdinal("OrganizationName"));
                if (!reader.IsDBNull(reader.GetOrdinal("AddressLineOne"))) _addresslineone = reader.GetString(reader.GetOrdinal("AddressLineOne"));
                if (!reader.IsDBNull(reader.GetOrdinal("AddressLineTwo"))) _addresslinetwo = reader.GetString(reader.GetOrdinal("AddressLineTwo"));
                if (!reader.IsDBNull(reader.GetOrdinal("Phone"))) _phone = reader.GetString(reader.GetOrdinal("Phone"));
                if (!reader.IsDBNull(reader.GetOrdinal("Email"))) _email = reader.GetString(reader.GetOrdinal("Email"));
                if (!reader.IsDBNull(reader.GetOrdinal("Website"))) _website = reader.GetString(reader.GetOrdinal("Website"));
                if (!reader.IsDBNull(reader.GetOrdinal("Domain"))) _domain = reader.GetString(reader.GetOrdinal("Domain"));
                if (!reader.IsDBNull(reader.GetOrdinal("Fax"))) _fax = reader.GetString(reader.GetOrdinal("Fax"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsMailEnable"))) _ismailenable = reader.GetBoolean(reader.GetOrdinal("IsMailEnable"));
                if (!reader.IsDBNull(reader.GetOrdinal("smtpHost"))) _smtphost = reader.GetString(reader.GetOrdinal("smtpHost"));
                if (!reader.IsDBNull(reader.GetOrdinal("mailPort"))) _mailport = reader.GetInt64(reader.GetOrdinal("mailPort"));
                if (!reader.IsDBNull(reader.GetOrdinal("smtpUserName"))) _smtpusername = reader.GetString(reader.GetOrdinal("smtpUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("smtpPassword"))) _smtppassword = reader.GetString(reader.GetOrdinal("smtpPassword"));
                if (!reader.IsDBNull(reader.GetOrdinal("mailSSL"))) _mailssl = reader.GetBoolean(reader.GetOrdinal("mailSSL"));
                if (!reader.IsDBNull(reader.GetOrdinal("fromemailaddress"))) _fromemailaddress = reader.GetString(reader.GetOrdinal("fromemailaddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("maildisplayName"))) _maildisplayname = reader.GetString(reader.GetOrdinal("maildisplayName"));
                if (!reader.IsDBNull(reader.GetOrdinal("isFtpEnable"))) _isftpenable = reader.GetBoolean(reader.GetOrdinal("isFtpEnable"));
                if (!reader.IsDBNull(reader.GetOrdinal("ftpAddress"))) _ftpaddress = reader.GetString(reader.GetOrdinal("ftpAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("ftpPort"))) _ftpport = reader.GetString(reader.GetOrdinal("ftpPort"));
                if (!reader.IsDBNull(reader.GetOrdinal("ftpUserName"))) _ftpusername = reader.GetString(reader.GetOrdinal("ftpUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ftpPassword"))) _ftppassword = reader.GetString(reader.GetOrdinal("ftpPassword"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsSSL"))) _isssl = reader.GetBoolean(reader.GetOrdinal("IsSSL"));
                if (!reader.IsDBNull(reader.GetOrdinal("LogoImg"))) _logoimg = reader.GetString(reader.GetOrdinal("LogoImg"));
                if (!reader.IsDBNull(reader.GetOrdinal("WebHeader"))) _webheader = reader.GetString(reader.GetOrdinal("WebHeader"));
                if (!reader.IsDBNull(reader.GetOrdinal("FolderPath"))) _folderpath = reader.GetString(reader.GetOrdinal("FolderPath"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("OrganizationKey"))) _organizationkey = reader.GetInt64(reader.GetOrdinal("OrganizationKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrganizationName"))) _organizationname = reader.GetString(reader.GetOrdinal("OrganizationName"));
                if (!reader.IsDBNull(reader.GetOrdinal("AddressLineOne"))) _addresslineone = reader.GetString(reader.GetOrdinal("AddressLineOne"));
                if (!reader.IsDBNull(reader.GetOrdinal("AddressLineTwo"))) _addresslinetwo = reader.GetString(reader.GetOrdinal("AddressLineTwo"));
                if (!reader.IsDBNull(reader.GetOrdinal("Phone"))) _phone = reader.GetString(reader.GetOrdinal("Phone"));
                if (!reader.IsDBNull(reader.GetOrdinal("Email"))) _email = reader.GetString(reader.GetOrdinal("Email"));
                if (!reader.IsDBNull(reader.GetOrdinal("Website"))) _website = reader.GetString(reader.GetOrdinal("Website"));
                if (!reader.IsDBNull(reader.GetOrdinal("Domain"))) _domain = reader.GetString(reader.GetOrdinal("Domain"));
                if (!reader.IsDBNull(reader.GetOrdinal("Fax"))) _fax = reader.GetString(reader.GetOrdinal("Fax"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsMailEnable"))) _ismailenable = reader.GetBoolean(reader.GetOrdinal("IsMailEnable"));
                if (!reader.IsDBNull(reader.GetOrdinal("smtpHost"))) _smtphost = reader.GetString(reader.GetOrdinal("smtpHost"));
                if (!reader.IsDBNull(reader.GetOrdinal("mailPort"))) _mailport = reader.GetInt64(reader.GetOrdinal("mailPort"));
                if (!reader.IsDBNull(reader.GetOrdinal("smtpUserName"))) _smtpusername = reader.GetString(reader.GetOrdinal("smtpUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("smtpPassword"))) _smtppassword = reader.GetString(reader.GetOrdinal("smtpPassword"));
                if (!reader.IsDBNull(reader.GetOrdinal("mailSSL"))) _mailssl = reader.GetBoolean(reader.GetOrdinal("mailSSL"));
                if (!reader.IsDBNull(reader.GetOrdinal("fromemailaddress"))) _fromemailaddress = reader.GetString(reader.GetOrdinal("fromemailaddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("maildisplayName"))) _maildisplayname = reader.GetString(reader.GetOrdinal("maildisplayName"));
                if (!reader.IsDBNull(reader.GetOrdinal("isFtpEnable"))) _isftpenable = reader.GetBoolean(reader.GetOrdinal("isFtpEnable"));
                if (!reader.IsDBNull(reader.GetOrdinal("ftpAddress"))) _ftpaddress = reader.GetString(reader.GetOrdinal("ftpAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("ftpPort"))) _ftpport = reader.GetString(reader.GetOrdinal("ftpPort"));
                if (!reader.IsDBNull(reader.GetOrdinal("ftpUserName"))) _ftpusername = reader.GetString(reader.GetOrdinal("ftpUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ftpPassword"))) _ftppassword = reader.GetString(reader.GetOrdinal("ftpPassword"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsSSL"))) _isssl = reader.GetBoolean(reader.GetOrdinal("IsSSL"));
                if (!reader.IsDBNull(reader.GetOrdinal("LogoImg"))) _logoimg = reader.GetString(reader.GetOrdinal("LogoImg"));
                if (!reader.IsDBNull(reader.GetOrdinal("WebHeader"))) _webheader = reader.GetString(reader.GetOrdinal("WebHeader"));
                if (!reader.IsDBNull(reader.GetOrdinal("FolderPath"))) _folderpath = reader.GetString(reader.GetOrdinal("FolderPath"));
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
