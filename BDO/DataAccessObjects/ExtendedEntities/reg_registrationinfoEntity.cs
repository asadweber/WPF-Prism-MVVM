using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using static BDO.Core.Base.BaseEntity;
using System.Collections.Generic;
using System.Web.WebPages;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class reg_registrationinfoEntity
    {
        #region Properties

        protected string? _nationalityid;
        protected string? _nationality;
        protected long? _certificateid;
        protected string? _civilid;
        protected string? _mobno;
        protected DateTime? _registrationfromdate;
        protected DateTime? _registrationtodate;
        protected DateTime? _submittedfromdate;
        protected DateTime? _submittedtodate;
        protected DateTime? _reviewfromdate;
        protected DateTime? _reviewtodate;
        protected DateTime? _syclearancefromdate;
        protected DateTime? _syclearancetodate;
        protected DateTime? _syclearancedate;
        protected DateTime? _syforwardedfromdate;
        protected DateTime? _syforwardedtodate;
        protected DateTime? _syforwardeddate;
        protected DateTime? _resultexpirefromdate;
        protected DateTime? _resultexpiretodate;
        protected DateTime? _resultdate;
        protected DateTime? _resultexpirydate;
        protected string? _approvedby;
        protected DateTime? _approvaldate;
        protected DateTime? _unitforwardedfromdate;
        protected DateTime? _unitforwardedtodate;
        protected DateTime? _unitforwardeddate;
        protected DateTime? _medforwardedfromdate;
        protected DateTime? _medforwardedtodate;
        protected DateTime? _medforwardeddate;
        protected DateTime? _medresultfromdate;
        protected DateTime? _medresulttodate;
        protected DateTime? _finalexamresultfromdate;
        protected DateTime? _finalexamresulttodate;
        protected long? _maxage;
        protected long? _minage;
        protected long? _maxnoofapplicant;
        protected string? _fullname;
        protected string _batchidstring;
        protected string _notificationsendbydate;
        protected long? _noofnotification;
        protected long? _batchno;
        protected DateTime? _interviewfromdate;
        protected DateTime? _interviewtodate;
        protected DateTime? _interviewdate;
        protected DateTime? _smsSendDate;
        protected bool? _notificationStatus;
        protected string? _birthcountryname;
        protected long? _gender;
        protected string? _email;
        protected string? _maritalstatus;
        protected string? _bloodgroup;
        protected string? _religionname;
        protected long? _phaseid;

        [DataMember]
        private List<reg_studentfilestorageEntity> _documentList;

        [DataMember]
        protected bool _isregisteranotherbatch = false;

        [DataMember]
        [Display(Name = "nationalityid", ResourceType = typeof(CLL.LLClasses.Models._applicant_notification))]
        public string? nationalityid
        {
            get { return _nationalityid; }
            set { _nationalityid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "nationality", ResourceType = typeof(CLL.LLClasses.Models._applicant_notification))]
        public string? nationality
        {
            get { return _nationality; }
            set { _nationality = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "certificateid", ResourceType = typeof(CLL.LLClasses.Models._applicant_notification))]
        public long? certificateid
        {
            get { return _certificateid; }
            set { _certificateid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "civilid", ResourceType = typeof(CLL.LLClasses.Models._applicant_notification))]
        public string? civilid
        {
            get { return _civilid; }
            set { _civilid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "mobno", ResourceType = typeof(CLL.LLClasses.Models._applicant_notification))]
        public string? mobno
        {
            get { return _mobno; }
            set { _mobno = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "registrationfromdate", ResourceType = typeof(CLL.LLClasses.Models._applicant_notification))]
        public DateTime? registrationfromdate
        {
            get { return _registrationfromdate; }
            set { _registrationfromdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "registrationtodate", ResourceType = typeof(CLL.LLClasses.Models._applicant_notification))]
        public DateTime? registrationtodate
        {
            get { return _registrationtodate; }
            set { _registrationtodate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "submittedfromdate", ResourceType = typeof(CLL.LLClasses.Models._applicant_notification))]
        public DateTime? submittedfromdate
        {
            get { return _submittedfromdate; }
            set { _submittedfromdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "submittedtodate", ResourceType = typeof(CLL.LLClasses.Models._applicant_notification))]
        public DateTime? submittedtodate
        {
            get { return _submittedtodate; }
            set { _submittedtodate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "reviewfromdate", ResourceType = typeof(CLL.LLClasses.Models._tran_volunteersyclearance))]
        public DateTime? reviewfromdate
        {
            get { return _reviewfromdate; }
            set { _reviewfromdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "reviewtodate", ResourceType = typeof(CLL.LLClasses.Models._tran_volunteersyclearance))]
        public DateTime? reviewtodate
        {
            get { return _reviewtodate; }
            set { _reviewtodate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "syclearancefromdate", ResourceType = typeof(CLL.LLClasses.Models._tran_volunteerunitclearance))]
        public DateTime? syclearancefromdate
        {
            get { return _syclearancefromdate; }
            set { _syclearancefromdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "syclearancetodate", ResourceType = typeof(CLL.LLClasses.Models._tran_volunteerunitclearance))]
        public DateTime? syclearancetodate
        {
            get { return _syclearancetodate; }
            set { _syclearancetodate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "syclearancedate", ResourceType = typeof(CLL.LLClasses.Models._tran_volunteerunitclearance))]
        public DateTime? syclearancedate
        {
            get { return _syclearancedate; }
            set { _syclearancedate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "syforwardedfromdate", ResourceType = typeof(CLL.LLClasses.Models._tran_volunteersyclearance))]
        public DateTime? syforwardedfromdate
        {
            get { return _syforwardedfromdate; }
            set { _syforwardedfromdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "syforwardedtodate", ResourceType = typeof(CLL.LLClasses.Models._tran_volunteersyclearance))]
        public DateTime? syforwardedtodate
        {
            get { return _syforwardedtodate; }
            set { _syforwardedtodate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "syforwardeddate", ResourceType = typeof(CLL.LLClasses.Models._tran_volunteersyclearance))]
        public DateTime? syforwardeddate
        {
            get { return _syforwardeddate; }
            set { _syforwardeddate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "resultexpirefromdate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicantresultexpire))]
        public DateTime? resultexpirefromdate
        {
            get { return _resultexpirefromdate; }
            set { _resultexpirefromdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "resultexpiretodate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicantresultexpire))]
        public DateTime? resultexpiretodate
        {
            get { return _resultexpiretodate; }
            set { _resultexpiretodate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "resultdate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicantresultexpire))]
        public DateTime? resultdate
        {
            get { return _resultdate; }
            set { _resultdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "resultexpirydate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicantresultexpire))]
        public DateTime? resultexpirydate
        {
            get { return _resultexpirydate; }
            set { _resultexpirydate = value; this.OnChnaged(); }
        }

        [DataMember]
        public string? approvedby
        {
            get { return _approvedby; }
            set { _approvedby = value; this.OnChnaged(); }
        }

        [DataMember]
        public DateTime? approvaldate
        {
            get { return _approvaldate; }
            set { _approvaldate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "unitforwardedfromdate", ResourceType = typeof(CLL.LLClasses.Models._tran_volunteerunitclearance))]
        public DateTime? unitforwardedfromdate
        {
            get { return _unitforwardedfromdate; }
            set { _unitforwardedfromdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "unitforwardedtodate", ResourceType = typeof(CLL.LLClasses.Models._tran_volunteerunitclearance))]
        public DateTime? unitforwardedtodate
        {
            get { return _unitforwardedtodate; }
            set { _unitforwardedtodate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "unitforwardeddate", ResourceType = typeof(CLL.LLClasses.Models._tran_volunteerunitclearance))]
        public DateTime? unitforwardeddate
        {
            get { return _unitforwardeddate; }
            set { _unitforwardeddate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "medforwardedfromdate", ResourceType = typeof(CLL.LLClasses.Models._tran_volunteermedclearance))]
        public DateTime? medforwardedfromdate
        {
            get { return _medforwardedfromdate; }
            set { _medforwardedfromdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "medforwardedtodate", ResourceType = typeof(CLL.LLClasses.Models._tran_volunteermedclearance))]
        public DateTime? medforwardedtodate
        {
            get { return _medforwardedtodate; }
            set { _medforwardedtodate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "medforwardeddate", ResourceType = typeof(CLL.LLClasses.Models._tran_volunteermedclearance))]
        public DateTime? medforwardeddate
        {
            get { return _medforwardeddate; }
            set { _medforwardeddate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "medresultfromdate", ResourceType = typeof(CLL.LLClasses.Models._tran_medexamresult))]
        public DateTime? medresultfromdate
        {
            get { return _medresultfromdate; }
            set { _medresultfromdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "medresulttodate", ResourceType = typeof(CLL.LLClasses.Models._tran_medexamresult))]
        public DateTime? medresulttodate
        {
            get { return _medresulttodate; }
            set { _medresulttodate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "finalexamresultfromdate", ResourceType = typeof(CLL.LLClasses.Models._tran_finalexamresult))]
        public DateTime? finalexamresultfromdate
        {
            get { return _finalexamresultfromdate; }
            set { _finalexamresultfromdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "finalexamresulttodate", ResourceType = typeof(CLL.LLClasses.Models._tran_finalexamresult))]
        public DateTime? finalexamresulttodate
        {
            get { return _finalexamresulttodate; }
            set { _finalexamresulttodate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "maxage", ResourceType = typeof(CLL.LLClasses.Models._applicant_notification))]
        public long? maxage
        {
            get { return _maxage; }
            set { _maxage = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "minage", ResourceType = typeof(CLL.LLClasses.Models._applicant_notification))]
        public long? minage
        {
            get { return _minage; }
            set { _minage = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "maxnoofapplicant", ResourceType = typeof(CLL.LLClasses.Models._applicant_notification))]
        public long? maxnoofapplicant
        {
            get { return _maxnoofapplicant; }
            set { _maxnoofapplicant = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "fullname", ResourceType = typeof(CLL.LLClasses.Models._applicant_notification))]
        public string? fullname
        {
            get { return _fullname; }
            set { _fullname = value; this.OnChnaged(); }
        }

        [DataMember]
        public string batchidstring { get; set; }

        [DataMember]
        public long?  clearancetypeid { get; set; }
        [DataMember]
        public long? clearancestatusid { get; set; }
        




        [DataMember]
        public string notificationsendbydate
        {
            get { return _notificationsendbydate; }
            set { _notificationsendbydate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "noofnotification", ResourceType = typeof(CLL.LLClasses.Models._applicant_notification))]
        public long? noofnotification
        {
            get { return _noofnotification; }
            set { _noofnotification = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "batchno", ResourceType = typeof(CLL.LLClasses.Models._applicant_notification))]
        public long? batchno
        {
            get { return _batchno; }
            set { _batchno = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "interviewfromdate", ResourceType = typeof(CLL.LLClasses.Models._applicant_review))]
        public DateTime? interviewfromdate
        {
            get { return _interviewfromdate; }
            set { _interviewfromdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "interviewtodate", ResourceType = typeof(CLL.LLClasses.Models._applicant_review))]
        public DateTime? interviewtodate
        {
            get { return _interviewtodate; }
            set { _interviewtodate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "interviewdate", ResourceType = typeof(CLL.LLClasses.Models._applicant_review))]
        public DateTime? interviewdate
        {
            get { return _interviewdate; }
            set { _interviewdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "smsSendDate", ResourceType = typeof(CLL.LLClasses.Models._applicant_review))]
        public DateTime? smsSendDate
        {
            get { return _smsSendDate; }
            set { _smsSendDate = value; this.OnChnaged(); }
        }

        public bool? notificationStatus { get; set; }

        [DataMember]
        [Display(Name = "email", ResourceType = typeof(CLL.LLClasses.Models._applicant_review))]
        public string email { get; set; }


        [DataMember]
        [Display(Name = "birthcountryname", ResourceType = typeof(CLL.LLClasses.Models._applicant_review))]
        public string birthcountryname
        {
            get { return _birthcountryname; }
            set { _birthcountryname = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "gender", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public long? gender
        {
            get { return _gender; }
            set { _gender = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "maritalstatus", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string? maritalstatus
        {
            get { return _maritalstatus; }
            set { _maritalstatus = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "bloodgroup", ResourceType = typeof(CLL.LLClasses.Models._applicant_review))]
        public string? bloodgroup
        {
            get { return _bloodgroup; }
            set { _bloodgroup = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "religionname", ResourceType = typeof(CLL.LLClasses.Models._applicant_review))]
        public string? religionname
        {
            get { return _religionname; }
            set { _religionname = value; this.OnChnaged(); }
        }

        [DataMember]
        public string batchdetails { get; set; }

        [DataMember]
        [Display(Name = "candidatetypename", ResourceType = typeof(CLL.LLClasses.Models._gen_candidatetype))]
        public string candidatetypename { get; set; }

        [DataMember]
        [Display(Name = "professionname", ResourceType = typeof(CLL.LLClasses.Models._gen_profession))]
        public string professionname { get; set; }

        [DataMember]
        public string? professionidstring { get; set; }

        [DataMember]
        public string? candidatetypeidstring { get; set; }

        [DataMember]
        public long? phaseid { get; set; }

        [DataMember]
        public long? CertificateLevelId { get; set; }
        [DataMember]
        public long? CertificateSubjectId { get; set; }

        [DataMember]
        public long? statusid { get; set; }

        [DataMember]
        public long? maritalstatusid { get; set; }

        [DataMember]
        public bool isregisteranotherbatch
        {
            get { return _isregisteranotherbatch; }
            set { _isregisteranotherbatch = value; }
        }

        [DataMember]
        public List<reg_studentfilestorageEntity> DocumentList { get => _documentList; set => _documentList = value; }

        [DataMember]
        public long? previousBatchID { get; set; }

        [DataMember]
        public int? previousAuditResult { get; set; }

        [DataMember]
        public int? previousSyExamResult { get; set; }

        [DataMember]
        public int? previousUnitClearanceResult { get; set; }

        [DataMember]
        public int? previousMedExamResult { get; set; }

        [DataMember]
        public int? previousPsychoExamResult { get; set; }

        [DataMember]
        public int? previousFinalExamResult { get; set; }

        [DataMember]
        public decimal? unitclearancemarkfrom { get; set; }

        [DataMember]
        public decimal? unitclearancemarkto { get; set; }

        //Trg Join entity start
        [DataMember]
        public long? TrgJoinID { get; set; }

        [DataMember]
        public long? TrgCentreID { get; set; }

        [DataMember]
        [Display(Name = "trgcentreid", ResourceType = typeof(CLL.LLClasses.Models._tran_trainingjoin))]
        public string? TrgCentreName { get; set; }

        [DataMember]
        [Display(Name = "joindate", ResourceType = typeof(CLL.LLClasses.Models._tran_trainingjoin))]
        public DateTime? JoinDate { get; set; }

        [DataMember]
        [Display(Name = "volunteerno", ResourceType = typeof(CLL.LLClasses.Models._tran_trainingjoin))]
        public long? VolunteerNo { get; set; }

        [DataMember]
        [Display(Name = "groupno", ResourceType = typeof(CLL.LLClasses.Models._tran_trainingjoin))]
        public string? GroupNo { get; set; }

        [DataMember]
        public long? JoiningBatchID { get; set; }

        [DataMember]
        [Display(Name = "orderno", ResourceType = typeof(CLL.LLClasses.Models._tran_trainingjoin))]
        public string? OrderNo { get; set; }

        [DataMember]
        [Display(Name = "orderdate", ResourceType = typeof(CLL.LLClasses.Models._tran_trainingjoin))]
        public DateTime? OrderDate { get; set; }

        [DataMember]
        public string? TrgJoinRemarks { get; set; }
        //Trg Join entity end

        [DataMember]
        public string? SendBy { get; set; }

        [DataMember]
        public DateTime? SendDate { get; set; }

        [DataMember]
        public string? stringStrModelPrimaryKey { get; set; }
        [DataMember]
        public string basicinfoids { get; set; }

        [DataMember]
        public List<reg_registrationinfoEntity>? RegistrationInfoList { get; set; }

        #endregion

        #region Constructor

        protected void LoadFromReader(IDataReader reader, int e)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) _registrationid = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchID"))) _batchid = reader.GetInt64(reader.GetOrdinal("BatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchNo"))) _batchno = reader.GetInt64(reader.GetOrdinal("BatchNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _civilid = reader.GetString(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CountryNationality"))) _nationality = reader.GetString(reader.GetOrdinal("CountryNationality"));
                if (!reader.IsDBNull(reader.GetOrdinal("PhoneNo"))) _mobno = reader.GetString(reader.GetOrdinal("PhoneNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("Email"))) email = reader.GetString(reader.GetOrdinal("Email"));
                if (!reader.IsDBNull(reader.GetOrdinal("SubmittedDate"))) _submitteddate = reader.GetDateTime(reader.GetOrdinal("SubmittedDate"));
                //if (!reader.IsDBNull(reader.GetOrdinal("SendByDate"))) _notificationsendbydate = reader.GetString(reader.GetOrdinal("SendByDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationCount"))) _noofnotification = reader.GetInt64(reader.GetOrdinal("NotificationCount"));
                CurrentState = EntityState.Unchanged;
            }
        }

        protected void LoadFromReader(IDataReader reader, string ext)
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
                if (!reader.IsDBNull(reader.GetOrdinal("IsExported"))) _isexported = reader.GetBoolean(reader.GetOrdinal("IsExported"));
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