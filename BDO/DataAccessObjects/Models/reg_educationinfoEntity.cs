using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "reg_educationinfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class reg_educationinfoEntity : BaseEntity
    {
        #region Properties

        protected long? _educationid;
        protected long? _basicinfoid;
        protected long? _batchcandcertificateid;
        protected long? _certificatelevelid;
        protected long? _certificateid;
        protected long? _certificatesubjectid;
        protected long? _educationshiftid;
        protected long? _edugradeid;
        protected long? _edumajorid;
        protected long? _instituteid;
        protected long? _countryid;
        protected DateTime? _passyear;
        protected bool? _ispercentage;
        protected decimal? _points;
        protected string? _grade;
        protected string _institutename;
        protected bool? _isstudying;
        protected long? _newinstituteid;
        protected string _semestername;
        protected string _filepath;
        protected string _filename;
        protected string _filetype;
        protected string _extension;
        protected string _comment;
        protected string _remarks;
        protected string _updateinfo;
        protected long? _tranformactionid;


        [DataMember]
        public long? educationid
        {
            get { return _educationid; }
            set { _educationid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "basicinfoid", ResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo), ErrorMessageResourceName = "basicinfoidRequired")]
        public long? basicinfoid
        {
            get { return _basicinfoid; }
            set { _basicinfoid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "batchcandcertificateid", ResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo))]
        public long? batchcandcertificateid
        {
            get { return _batchcandcertificateid; }
            set { _batchcandcertificateid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "certificatelevelid", ResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo), ErrorMessageResourceName = "certificatelevelidRequired")]
        public long? certificatelevelid
        {
            get { return _certificatelevelid; }
            set { _certificatelevelid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "certificateid", ResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo), ErrorMessageResourceName = "certificateidRequired")]
        public long? certificateid
        {
            get { return _certificateid; }
            set { _certificateid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "certificatesubjectid", ResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo))]
        public long? certificatesubjectid
        {
            get { return _certificatesubjectid; }
            set { _certificatesubjectid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "educationshiftid", ResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo))]
        public long? educationshiftid
        {
            get { return _educationshiftid; }
            set { _educationshiftid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "edugradeid", ResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo))]
        public long? edugradeid
        {
            get { return _edugradeid; }
            set { _edugradeid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "edumajorid", ResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo))]
        public long? edumajorid
        {
            get { return _edumajorid; }
            set { _edumajorid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "instituteid", ResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo))]
        public long? instituteid
        {
            get { return _instituteid; }
            set { _instituteid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "countryid", ResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo))]
        public long? countryid
        {
            get { return _countryid; }
            set { _countryid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "passyear", ResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo))]
        public DateTime? passyear
        {
            get { return _passyear; }
            set { _passyear = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "ispercentage", ResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo))]
        public bool? ispercentage
        {
            get { return _ispercentage; }
            set { _ispercentage = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "points", ResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo))]
        public decimal? points
        {
            get { return _points; }
            set { _points = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(50)]
        [Display(Name = "grade", ResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo))]
        public string? grade
        {
            get { return _grade; }
            set { _grade = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "institutename", ResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo))]
        public string institutename
        {
            get { return _institutename; }
            set { _institutename = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "isstudying", ResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo))]
        public bool? isstudying
        {
            get { return _isstudying; }
            set { _isstudying = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "newinstituteid", ResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo))]
        public long? newinstituteid
        {
            get { return _newinstituteid; }
            set { _newinstituteid = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "semestername", ResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo))]
        public string semestername
        {
            get { return _semestername; }
            set { _semestername = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "filepath", ResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo))]
        public string filepath
        {
            get { return _filepath; }
            set { _filepath = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "filename", ResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo))]
        public string filename
        {
            get { return _filename; }
            set { _filename = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "filetype", ResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo))]
        public string filetype
        {
            get { return _filetype; }
            set { _filetype = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "extension", ResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo))]
        public string extension
        {
            get { return _extension; }
            set { _extension = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "comment", ResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo))]
        public string comment
        {
            get { return _comment; }
            set { _comment = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._reg_educationinfo))]
        public long? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }


        #endregion

        #region Constructor

        public reg_educationinfoEntity() : base()
        {
        }

        public reg_educationinfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        public reg_educationinfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }



        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("EducationID"))) _educationid = reader.GetInt64(reader.GetOrdinal("EducationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchCandCertificateID"))) _batchcandcertificateid = reader.GetInt64(reader.GetOrdinal("BatchCandCertificateID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateLevelID"))) _certificatelevelid = reader.GetInt64(reader.GetOrdinal("CertificateLevelID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateID"))) _certificateid = reader.GetInt64(reader.GetOrdinal("CertificateID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateSubjectID"))) _certificatesubjectid = reader.GetInt64(reader.GetOrdinal("CertificateSubjectID"));
                if (!reader.IsDBNull(reader.GetOrdinal("EducationShiftID"))) _educationshiftid = reader.GetInt64(reader.GetOrdinal("EducationShiftID"));
                if (!reader.IsDBNull(reader.GetOrdinal("EduGradeID"))) _edugradeid = reader.GetInt64(reader.GetOrdinal("EduGradeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("EduMajorID"))) _edumajorid = reader.GetInt64(reader.GetOrdinal("EduMajorID"));
                if (!reader.IsDBNull(reader.GetOrdinal("InstituteID"))) _instituteid = reader.GetInt64(reader.GetOrdinal("InstituteID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CountryID"))) _countryid = reader.GetInt64(reader.GetOrdinal("CountryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassYear"))) _passyear = reader.GetDateTime(reader.GetOrdinal("PassYear"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsPercentage"))) _ispercentage = reader.GetBoolean(reader.GetOrdinal("IsPercentage"));
                if (!reader.IsDBNull(reader.GetOrdinal("Points"))) _points = reader.GetDecimal(reader.GetOrdinal("Points"));
                if (!reader.IsDBNull(reader.GetOrdinal("Grade"))) _grade = reader.GetString(reader.GetOrdinal("Grade"));
                if (!reader.IsDBNull(reader.GetOrdinal("InstituteName"))) _institutename = reader.GetString(reader.GetOrdinal("InstituteName"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsStudying"))) _isstudying = reader.GetBoolean(reader.GetOrdinal("IsStudying"));
                if (!reader.IsDBNull(reader.GetOrdinal("NewInstituteID"))) _newinstituteid = reader.GetInt64(reader.GetOrdinal("NewInstituteID"));
                if (!reader.IsDBNull(reader.GetOrdinal("SemesterName"))) _semestername = reader.GetString(reader.GetOrdinal("SemesterName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FilePath"))) _filepath = reader.GetString(reader.GetOrdinal("FilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileName"))) _filename = reader.GetString(reader.GetOrdinal("FileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileType"))) _filetype = reader.GetString(reader.GetOrdinal("FileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("Extension"))) _extension = reader.GetString(reader.GetOrdinal("Extension"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("EducationID"))) _educationid = reader.GetInt64(reader.GetOrdinal("EducationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchCandCertificateID"))) _batchcandcertificateid = reader.GetInt64(reader.GetOrdinal("BatchCandCertificateID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateLevelID"))) _certificatelevelid = reader.GetInt64(reader.GetOrdinal("CertificateLevelID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateID"))) _certificateid = reader.GetInt64(reader.GetOrdinal("CertificateID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateSubjectID"))) _certificatesubjectid = reader.GetInt64(reader.GetOrdinal("CertificateSubjectID"));
                if (!reader.IsDBNull(reader.GetOrdinal("EducationShiftID"))) _educationshiftid = reader.GetInt64(reader.GetOrdinal("EducationShiftID"));
                if (!reader.IsDBNull(reader.GetOrdinal("EduGradeID"))) _edugradeid = reader.GetInt64(reader.GetOrdinal("EduGradeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("EduMajorID"))) _edumajorid = reader.GetInt64(reader.GetOrdinal("EduMajorID"));
                if (!reader.IsDBNull(reader.GetOrdinal("InstituteID"))) _instituteid = reader.GetInt64(reader.GetOrdinal("InstituteID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CountryID"))) _countryid = reader.GetInt64(reader.GetOrdinal("CountryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassYear"))) _passyear = reader.GetDateTime(reader.GetOrdinal("PassYear"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsPercentage"))) _ispercentage = reader.GetBoolean(reader.GetOrdinal("IsPercentage"));
                if (!reader.IsDBNull(reader.GetOrdinal("Points"))) _points = reader.GetDecimal(reader.GetOrdinal("Points"));
                if (!reader.IsDBNull(reader.GetOrdinal("Grade"))) _grade = reader.GetString(reader.GetOrdinal("Grade"));
                if (!reader.IsDBNull(reader.GetOrdinal("InstituteName"))) _institutename = reader.GetString(reader.GetOrdinal("InstituteName"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsStudying"))) _isstudying = reader.GetBoolean(reader.GetOrdinal("IsStudying"));
                if (!reader.IsDBNull(reader.GetOrdinal("NewInstituteID"))) _newinstituteid = reader.GetInt64(reader.GetOrdinal("NewInstituteID"));
                if (!reader.IsDBNull(reader.GetOrdinal("SemesterName"))) _semestername = reader.GetString(reader.GetOrdinal("SemesterName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FilePath"))) _filepath = reader.GetString(reader.GetOrdinal("FilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileName"))) _filename = reader.GetString(reader.GetOrdinal("FileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileType"))) _filetype = reader.GetString(reader.GetOrdinal("FileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("Extension"))) _extension = reader.GetString(reader.GetOrdinal("Extension"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
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
