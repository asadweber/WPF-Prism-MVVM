using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "reg_registrationinfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class reg_registrationinfoEntity : BaseEntity
    {
        #region Properties

        protected long? _registrationid;
        protected long? _basicinfoid;
        protected DateTime? _applicationdate;
        protected string _appliedfromip;
        protected bool? _isactive;
        protected long? _idtype;
        protected DateTime? _idissuedate;
        protected DateTime? _idexpirydate;
        protected long? _batchcandidatetypemapid;
        protected long? _batchid;
        protected long? _candidatetypeid;
        protected long? _batchcandprofessionmapid;
        protected long? _professionid;
        protected long? _batchunitlistid;
        protected long? _entitykey;
        protected bool? _isspecialregistration;
        protected bool? _isfinal;
        protected bool? _isrollbackallowed;
        protected bool? _isapplyotherbatchallowed;
        protected DateTime? _submitteddate;
        protected int? _auditresult;
        protected string? _auditcomment;
        protected DateTime? _auditdate;
        protected bool? _issecurityforwarded;
        protected bool? _issyresultexpired;
        protected bool? _issyretestapproved;
        protected bool? _ismedresultexpired;
        protected bool? _ismedretestapproved;
        protected bool? _ispsychoresultexpired;
        protected bool? _ispsychoretestapproved;
        protected bool? _centralagencysyresult;
        protected string? _centralagencysycomment;
        protected DateTime? _centralagencysyresultdate;
        protected int? _syexamresult;
        protected string? _syexamcomment;
        protected DateTime? _syexamresultdate;
        protected bool? _syprofileprint;
        protected bool? _isunitforwarded;
        protected int? _unitclearanceresult;
        protected DateTime? _unitclearanceresultDate;
        protected decimal? _unitclearancemark;
        protected string? _unitclearancecomment;
        protected bool? _ismedforwarded;
        protected int? _medexamresult;
        protected string? _medexamcomment;
        protected DateTime? _medexamresultdate;
        protected bool? _medexamformprint;
        protected int? _psychoexamresult;
        protected string? _psychoexamcomment;
        protected DateTime? _psychoexamResultDate;
        protected int? _finalexamresult;
        protected string? _finalexamcomment;
        protected DateTime? _finalexamResultDate;
        protected bool? _istrgjoinenabled;
        protected bool? _isexported;
        protected DateTime? _exporteddate;
        //protected long? _exportedby;
        protected string _remarks;
        protected string _updateinfo;
        protected long? _tranformactionid;
        private long? _specialRegID;

        [DataMember]
        [Display(Name = "registrationid", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public long? registrationid
        {
            get { return _registrationid; }
            set { _registrationid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "basicinfoid", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo), ErrorMessageResourceName = "basicinfoidRequired")]
        public long? basicinfoid
        {
            get { return _basicinfoid; }
            set { _basicinfoid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "applicationdate", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public DateTime? applicationdate
        {
            get { return _applicationdate; }
            set { _applicationdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(50)]
        [Display(Name = "appliedfromip", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public string appliedfromip
        {
            get { return _appliedfromip; }
            set { _appliedfromip = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public bool? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "idtype", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public long? idtype
        {
            get { return _idtype; }
            set { _idtype = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "idissuedate", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public DateTime? idissuedate
        {
            get { return _idissuedate; }
            set { _idissuedate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "idexpirydate", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public DateTime? idexpirydate
        {
            get { return _idexpirydate; }
            set { _idexpirydate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "batchcandidatetypemapid", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public long? batchcandidatetypemapid
        {
            get { return _batchcandidatetypemapid; }
            set { _batchcandidatetypemapid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "batchid", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public long? batchid
        {
            get { return _batchid; }
            set { _batchid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "candidatetypeid", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public long? candidatetypeid
        {
            get { return _candidatetypeid; }
            set { _candidatetypeid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "batchcandprofessionmapid", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public long? batchcandprofessionmapid
        {
            get { return _batchcandprofessionmapid; }
            set { _batchcandprofessionmapid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "professionid", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public long? professionid
        {
            get { return _professionid; }
            set { _professionid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "batchunitlistid", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public long? batchunitlistid
        {
            get { return _batchunitlistid; }
            set { _batchunitlistid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "entitykey", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public long? entitykey
        {
            get { return _entitykey; }
            set { _entitykey = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "isspecialregistration", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public bool? isspecialregistration
        {
            get { return _isspecialregistration; }
            set { _isspecialregistration = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "isfinal", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public bool? isfinal
        {
            get { return _isfinal; }
            set { _isfinal = value; this.OnChnaged(); }
        }

        [DataMember]
        public bool? isrollbackallowed
        {
            get { return _isrollbackallowed; }
            set { _isrollbackallowed = value; this.OnChnaged(); }
        }

        [DataMember]
        public bool? isapplyotherbatchallowed
        {
            get { return _isapplyotherbatchallowed; }
            set { _isapplyotherbatchallowed = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "submitteddate", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public DateTime? submitteddate
        {
            get { return _submitteddate; }
            set { _submitteddate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "auditresult", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public int? auditresult
        {
            get { return _auditresult; }
            set { _auditresult = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "auditcomment", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public string? auditcomment
        {
            get { return _auditcomment; }
            set { _auditcomment = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "auditdate", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public DateTime? auditdate
        {
            get { return _auditdate; }
            set { _auditdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "issecurityforwarded", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public bool? issecurityforwarded
        {
            get { return _issecurityforwarded; }
            set { _issecurityforwarded = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "issyresultexpired", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public bool? issyresultexpired
        {
            get { return _issyresultexpired; }
            set { _issyresultexpired = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "issyretestapproved", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public bool? issyretestapproved
        {
            get { return _issyretestapproved; }
            set { _issyretestapproved = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "ismedresultexpired", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public bool? ismedresultexpired
        {
            get { return _ismedresultexpired; }
            set { _ismedresultexpired = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "ismedretestapproved", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public bool? ismedretestapproved
        {
            get { return _ismedretestapproved; }
            set { _ismedretestapproved = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "ispsychoresultexpired", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public bool? ispsychoresultexpired
        {
            get { return _ispsychoresultexpired; }
            set { _ispsychoresultexpired = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "ispsychoretestapproved", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public bool? ispsychoretestapproved
        {
            get { return _ispsychoretestapproved; }
            set { _ispsychoretestapproved = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "centralagencysyresult", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public bool? centralagencysyresult
        {
            get { return _centralagencysyresult; }
            set { _centralagencysyresult = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "centralagencysycomment", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public string? centralagencysycomment
        {
            get { return _centralagencysycomment; }
            set { _centralagencysycomment = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "centralagencysyresultdate", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public DateTime? centralagencysyresultdate
        {
            get { return _centralagencysyresultdate; }
            set { _centralagencysyresultdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "syexamresult", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public int? syexamresult
        {
            get { return _syexamresult; }
            set { _syexamresult = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "syexamcomment", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public string? syexamcomment
        {
            get { return _syexamcomment; }
            set { _syexamcomment = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "syexamresultdate", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public DateTime? syexamresultdate
        {
            get { return _syexamresultdate; }
            set { _syexamresultdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "syprofileprint", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public bool? syprofileprint
        {
            get { return _syprofileprint; }
            set { _syprofileprint = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "isunitforwarded", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public bool? isunitforwarded
        {
            get { return _isunitforwarded; }
            set { _isunitforwarded = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "unitclearanceresult", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public int? unitclearanceresult
        {
            get { return _unitclearanceresult; }
            set { _unitclearanceresult = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "unitclearancecomment", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public string? unitclearancecomment
        {
            get { return _unitclearancecomment; }
            set { _unitclearancecomment = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "unitclearanceresultDate", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public DateTime? unitclearanceresultDate
        {
            get { return _unitclearanceresultDate; }
            set { _unitclearanceresultDate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "unitclearancemark", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public decimal? unitclearancemark
        {
            get { return _unitclearancemark; }
            set { _unitclearancemark = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "ismedforwarded", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public bool? ismedforwarded
        {
            get { return _ismedforwarded; }
            set { _ismedforwarded = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "medexamresult", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public int? medexamresult
        {
            get { return _medexamresult; }
            set { _medexamresult = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "medexamcomment", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public string? medexamcomment
        {
            get { return _medexamcomment; }
            set { _medexamcomment = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "medexamresultdate", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public DateTime? medexamresultdate
        {
            get { return _medexamresultdate; }
            set { _medexamresultdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "medexamformprint", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public bool? medexamformprint
        {
            get { return _medexamformprint; }
            set { _medexamformprint = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "psychoexamresult", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public int? psychoexamresult
        {
            get { return _psychoexamresult; }
            set { _psychoexamresult = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "psychoexamcomment", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public string? psychoexamcomment
        {
            get { return _psychoexamcomment; }
            set { _psychoexamcomment = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "psychoexamResultDate", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public DateTime? psychoexamResultDate
        {
            get { return _psychoexamResultDate; }
            set { _psychoexamResultDate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "finalexamresult", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public int? finalexamresult
        {
            get { return _finalexamresult; }
            set { _finalexamresult = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "finalexamcomment", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public string? finalexamcomment
        {
            get { return _finalexamcomment; }
            set { _finalexamcomment = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "finalexamResultDate", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public DateTime? finalexamResultDate
        {
            get { return _finalexamResultDate; }
            set { _finalexamResultDate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "istrgjoinenabled", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public bool? istrgjoinenabled
        {
            get { return _istrgjoinenabled; }
            set { _istrgjoinenabled = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "isexported", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public bool? isexported
        {
            get { return _isexported; }
            set { _isexported = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "exporteddate", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public DateTime? exporteddate
        {
            get { return _exporteddate; }
            set { _exporteddate = value; this.OnChnaged(); }
        }

        //[DataMember]
        //[Display(Name = "exportedby", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        //public long? exportedby
        //{
        //    get { return _exportedby; }
        //    set { _exportedby = value; this.OnChnaged(); }
        //}

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._reg_registrationinfo))]
        public long? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? SpecialRegID { get => _specialRegID; set => _specialRegID = value; }

        
        #endregion

        #region Constructor

        public reg_registrationinfoEntity() : base()
        {
        }

        public reg_registrationinfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        public reg_registrationinfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }

        public reg_registrationinfoEntity(IDataReader reader, int e)
        {
            this.LoadFromReader(reader, e);
        }

        public reg_registrationinfoEntity(IDataReader reader, string ext)
        {
            this.LoadFromReader(reader, ext);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) _registrationid = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicationDate"))) _applicationdate = reader.GetDateTime(reader.GetOrdinal("ApplicationDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("AppliedFromIP"))) _appliedfromip = reader.GetString(reader.GetOrdinal("AppliedFromIP"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                if (!reader.IsDBNull(reader.GetOrdinal("IDType"))) _idtype = reader.GetInt64(reader.GetOrdinal("IDType"));
                if (!reader.IsDBNull(reader.GetOrdinal("IDIssueDate"))) _idissuedate = reader.GetDateTime(reader.GetOrdinal("IDIssueDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IDExpiryDate"))) _idexpirydate = reader.GetDateTime(reader.GetOrdinal("IDExpiryDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchCandidateTypeMapID"))) _batchcandidatetypemapid = reader.GetInt64(reader.GetOrdinal("BatchCandidateTypeMapID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchID"))) _batchid = reader.GetInt64(reader.GetOrdinal("BatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchDetails"))) batchdetails = reader.GetString(reader.GetOrdinal("BatchDetails"));
                if (!reader.IsDBNull(reader.GetOrdinal("CandidateTypeID"))) _candidatetypeid = reader.GetInt64(reader.GetOrdinal("CandidateTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchCandProfessionMapID"))) _batchcandprofessionmapid = reader.GetInt64(reader.GetOrdinal("BatchCandProfessionMapID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProfessionID"))) _professionid = reader.GetInt64(reader.GetOrdinal("ProfessionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchUnitListID"))) _batchunitlistid = reader.GetInt64(reader.GetOrdinal("BatchUnitListID"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntityKey"))) _entitykey = reader.GetInt64(reader.GetOrdinal("EntityKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsSpecialRegistration"))) _isspecialregistration = reader.GetBoolean(reader.GetOrdinal("IsSpecialRegistration"));
                if (!reader.IsDBNull(reader.GetOrdinal("SpecialRegID"))) _specialRegID = reader.GetInt64(reader.GetOrdinal("SpecialRegID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsFinal"))) _isfinal = reader.GetBoolean(reader.GetOrdinal("IsFinal"));
                if (!reader.IsDBNull(reader.GetOrdinal("isRollbackAllowed"))) _isrollbackallowed = reader.GetBoolean(reader.GetOrdinal("isRollbackAllowed"));
                if (!reader.IsDBNull(reader.GetOrdinal("isApplyOtherBatchAllowed"))) _isapplyotherbatchallowed = reader.GetBoolean(reader.GetOrdinal("isApplyOtherBatchAllowed"));
                if (!reader.IsDBNull(reader.GetOrdinal("SubmittedDate"))) _submitteddate = reader.GetDateTime(reader.GetOrdinal("SubmittedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("AuditResult"))) _auditresult = reader.GetInt32(reader.GetOrdinal("AuditResult"));
                if (!reader.IsDBNull(reader.GetOrdinal("AuditComment"))) _auditcomment = reader.GetString(reader.GetOrdinal("AuditComment"));
                if (!reader.IsDBNull(reader.GetOrdinal("AuditDate"))) _auditdate = reader.GetDateTime(reader.GetOrdinal("AuditDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsSecurityForwarded"))) _issecurityforwarded = reader.GetBoolean(reader.GetOrdinal("IsSecurityForwarded"));
                if (!reader.IsDBNull(reader.GetOrdinal("isSyResultExpired"))) _issyresultexpired = reader.GetBoolean(reader.GetOrdinal("isSyResultExpired"));
                if (!reader.IsDBNull(reader.GetOrdinal("isMedResultExpired"))) _ismedresultexpired = reader.GetBoolean(reader.GetOrdinal("isMedResultExpired"));
                if (!reader.IsDBNull(reader.GetOrdinal("isPsychoResultExpired"))) _ispsychoresultexpired = reader.GetBoolean(reader.GetOrdinal("isPsychoResultExpired"));
                if (!reader.IsDBNull(reader.GetOrdinal("CentralAgencySyResult"))) _centralagencysyresult = reader.GetBoolean(reader.GetOrdinal("CentralAgencySyResult"));
                if (!reader.IsDBNull(reader.GetOrdinal("CentralAgencySyComment"))) _centralagencysycomment = reader.GetString(reader.GetOrdinal("CentralAgencySyComment"));
                if (!reader.IsDBNull(reader.GetOrdinal("CentralAgencySyResultDate"))) _centralagencysyresultdate = reader.GetDateTime(reader.GetOrdinal("CentralAgencySyResultDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("SyExamResult"))) _syexamresult = reader.GetInt32(reader.GetOrdinal("SyExamResult"));
                if (!reader.IsDBNull(reader.GetOrdinal("SyExamComment"))) _syexamcomment = reader.GetString(reader.GetOrdinal("SyExamComment"));
                if (!reader.IsDBNull(reader.GetOrdinal("SyExamResultDate"))) _syexamresultdate = reader.GetDateTime(reader.GetOrdinal("SyExamResultDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsUnitForwarded"))) _isunitforwarded = reader.GetBoolean(reader.GetOrdinal("IsUnitForwarded"));
                if (!reader.IsDBNull(reader.GetOrdinal("UnitClearanceResult"))) _unitclearanceresult = reader.GetInt32(reader.GetOrdinal("UnitClearanceResult"));
                if (!reader.IsDBNull(reader.GetOrdinal("UnitClearanceComment"))) _unitclearancecomment = reader.GetString(reader.GetOrdinal("UnitClearanceComment"));
                if (!reader.IsDBNull(reader.GetOrdinal("UnitClearanceResultDate"))) _unitclearanceresultDate = reader.GetDateTime(reader.GetOrdinal("UnitClearanceResultDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UnitClearanceMarks"))) _unitclearancemark = reader.GetDecimal(reader.GetOrdinal("UnitClearanceMarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsMedForwarded"))) _ismedforwarded = reader.GetBoolean(reader.GetOrdinal("IsMedForwarded"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedExamResult"))) _medexamresult = reader.GetInt32(reader.GetOrdinal("MedExamResult"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedExamComment"))) _medexamcomment = reader.GetString(reader.GetOrdinal("MedExamComment"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedExamResultDate"))) _medexamresultdate = reader.GetDateTime(reader.GetOrdinal("MedExamResultDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PsychoExamResult"))) _psychoexamresult = reader.GetInt32(reader.GetOrdinal("PsychoExamResult"));
                if (!reader.IsDBNull(reader.GetOrdinal("PsychoExamComment"))) _psychoexamcomment = reader.GetString(reader.GetOrdinal("PsychoExamComment"));
                if (!reader.IsDBNull(reader.GetOrdinal("PsychoExamResultDate"))) _psychoexamResultDate = reader.GetDateTime(reader.GetOrdinal("PsychoExamResultDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FinalExamResult"))) _finalexamresult = reader.GetInt32(reader.GetOrdinal("FinalExamResult"));
                if (!reader.IsDBNull(reader.GetOrdinal("FinalExamComment"))) _finalexamcomment = reader.GetString(reader.GetOrdinal("FinalExamComment"));
                if (!reader.IsDBNull(reader.GetOrdinal("FinalExamResultDate"))) _finalexamResultDate = reader.GetDateTime(reader.GetOrdinal("FinalExamResultDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("isTrgJoinEnabled"))) _istrgjoinenabled = reader.GetBoolean(reader.GetOrdinal("isTrgJoinEnabled"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) _registrationid = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicationDate"))) _applicationdate = reader.GetDateTime(reader.GetOrdinal("ApplicationDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("AppliedFromIP"))) _appliedfromip = reader.GetString(reader.GetOrdinal("AppliedFromIP"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                if (!reader.IsDBNull(reader.GetOrdinal("IDType"))) _idtype = reader.GetInt64(reader.GetOrdinal("IDType"));
                if (!reader.IsDBNull(reader.GetOrdinal("IDIssueDate"))) _idissuedate = reader.GetDateTime(reader.GetOrdinal("IDIssueDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IDExpiryDate"))) _idexpirydate = reader.GetDateTime(reader.GetOrdinal("IDExpiryDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchCandidateTypeMapID"))) _batchcandidatetypemapid = reader.GetInt64(reader.GetOrdinal("BatchCandidateTypeMapID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchID"))) _batchid = reader.GetInt64(reader.GetOrdinal("BatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CandidateTypeID"))) _candidatetypeid = reader.GetInt64(reader.GetOrdinal("CandidateTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchCandProfessionMapID"))) _batchcandprofessionmapid = reader.GetInt64(reader.GetOrdinal("BatchCandProfessionMapID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProfessionID"))) _professionid = reader.GetInt64(reader.GetOrdinal("ProfessionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchUnitListID"))) _batchunitlistid = reader.GetInt64(reader.GetOrdinal("BatchUnitListID"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntityKey"))) _entitykey = reader.GetInt64(reader.GetOrdinal("EntityKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsSpecialRegistration"))) _isspecialregistration = reader.GetBoolean(reader.GetOrdinal("IsSpecialRegistration"));
                if (!reader.IsDBNull(reader.GetOrdinal("SpecialRegID"))) _specialRegID = reader.GetInt64(reader.GetOrdinal("SpecialRegID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsFinal"))) _isfinal = reader.GetBoolean(reader.GetOrdinal("IsFinal"));
                if (!reader.IsDBNull(reader.GetOrdinal("SubmittedDate"))) _submitteddate = reader.GetDateTime(reader.GetOrdinal("SubmittedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("AuditResult"))) _auditresult = reader.GetInt32(reader.GetOrdinal("AuditResult"));
                if (!reader.IsDBNull(reader.GetOrdinal("AuditComment"))) _auditcomment = reader.GetString(reader.GetOrdinal("AuditComment"));
                if (!reader.IsDBNull(reader.GetOrdinal("AuditDate"))) _auditdate = reader.GetDateTime(reader.GetOrdinal("AuditDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsSecurityForwarded"))) _issecurityforwarded = reader.GetBoolean(reader.GetOrdinal("IsSecurityForwarded"));
                if (!reader.IsDBNull(reader.GetOrdinal("SyExamResult"))) _syexamresult = reader.GetInt32(reader.GetOrdinal("SyExamResult"));
                if (!reader.IsDBNull(reader.GetOrdinal("SyExamComment"))) _syexamcomment = reader.GetString(reader.GetOrdinal("SyExamComment"));
                if (!reader.IsDBNull(reader.GetOrdinal("SyExamResultDate"))) _syexamresultdate = reader.GetDateTime(reader.GetOrdinal("SyExamResultDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsUnitForwarded"))) _isunitforwarded = reader.GetBoolean(reader.GetOrdinal("IsUnitForwarded"));
                if (!reader.IsDBNull(reader.GetOrdinal("UnitClearanceResult"))) _unitclearanceresult = reader.GetInt32(reader.GetOrdinal("UnitClearanceResult"));
                if (!reader.IsDBNull(reader.GetOrdinal("UnitClearanceComment"))) _unitclearancecomment = reader.GetString(reader.GetOrdinal("UnitClearanceComment"));
                if (!reader.IsDBNull(reader.GetOrdinal("UnitClearanceResultDate"))) _unitclearanceresultDate = reader.GetDateTime(reader.GetOrdinal("UnitClearanceResultDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UnitClearanceMarks"))) _unitclearancemark = reader.GetDecimal(reader.GetOrdinal("UnitClearanceMarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsMedForwarded"))) _ismedforwarded = reader.GetBoolean(reader.GetOrdinal("IsMedForwarded"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedExamResult"))) _medexamresult = reader.GetInt32(reader.GetOrdinal("MedExamResult"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedExamComment"))) _medexamcomment = reader.GetString(reader.GetOrdinal("MedExamComment"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedExamResultDate"))) _medexamresultdate = reader.GetDateTime(reader.GetOrdinal("MedExamResultDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PsychoExamResult"))) _psychoexamresult = reader.GetInt32(reader.GetOrdinal("PsychoExamResult"));
                if (!reader.IsDBNull(reader.GetOrdinal("PsychoExamComment"))) _psychoexamcomment = reader.GetString(reader.GetOrdinal("PsychoExamComment"));
                if (!reader.IsDBNull(reader.GetOrdinal("PsychoExamResultDate"))) _psychoexamResultDate = reader.GetDateTime(reader.GetOrdinal("PsychoExamResultDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FinalExamResult"))) _finalexamresult = reader.GetInt32(reader.GetOrdinal("FinalExamResult"));
                if (!reader.IsDBNull(reader.GetOrdinal("FinalExamComment"))) _finalexamcomment = reader.GetString(reader.GetOrdinal("FinalExamComment"));
                if (!reader.IsDBNull(reader.GetOrdinal("FinalExamResultDate"))) _finalexamResultDate = reader.GetDateTime(reader.GetOrdinal("FinalExamResultDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("isTrgJoinEnabled"))) _istrgjoinenabled = reader.GetBoolean(reader.GetOrdinal("isTrgJoinEnabled"));
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
