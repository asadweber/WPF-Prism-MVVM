using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "tran_applicantphasesEntity", Namespace = "http://www.GW2.com/types")]
    public partial class tran_applicantphasesEntity : BaseEntity
    {
        #region Properties

        protected long? _applicantphaseid;
        protected long? _parentid;
        protected long? _basicinfoid;
        protected long? _registrationid;
        protected long? _batchid;
        protected long? _phaseid;
        protected long? _statusid;
        protected DateTime? _submitteddate;
        protected Guid? _submittedby;
        protected string _remarks;
        protected string _updateinfo;
        protected long? _tranformactionid;


        [DataMember]
        public long? applicantphaseid
        {
            get { return _applicantphaseid; }
            set { _applicantphaseid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "parentid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicantphases))]
        public long? parentid
        {
            get { return _parentid; }
            set { _parentid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "basicinfoid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicantphases))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicantphases), ErrorMessageResourceName = "basicinfoidRequired")]
        public long? basicinfoid
        {
            get { return _basicinfoid; }
            set { _basicinfoid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "registrationid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicantphases))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicantphases), ErrorMessageResourceName = "registrationidRequired")]
        public long? registrationid
        {
            get { return _registrationid; }
            set { _registrationid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "batchid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicantphases))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicantphases), ErrorMessageResourceName = "batchidRequired")]
        public long? batchid
        {
            get { return _batchid; }
            set { _batchid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "phaseid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicantphases))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicantphases), ErrorMessageResourceName = "phaseidRequired")]
        public long? phaseid
        {
            get { return _phaseid; }
            set { _phaseid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "statusid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicantphases))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicantphases), ErrorMessageResourceName = "statusidRequired")]
        public long? statusid
        {
            get { return _statusid; }
            set { _statusid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "submitteddate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicantphases))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicantphases), ErrorMessageResourceName = "submitteddateRequired")]
        public DateTime? submitteddate
        {
            get { return _submitteddate; }
            set { _submitteddate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "submittedby", ResourceType = typeof(CLL.LLClasses.Models._tran_applicantphases))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicantphases), ErrorMessageResourceName = "submittedbyRequired")]
        public Guid? submittedby
        {
            get { return _submittedby; }
            set { _submittedby = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._tran_applicantphases))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._tran_applicantphases))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicantphases))]
        public long? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }


        #endregion

        #region Constructor

        public tran_applicantphasesEntity() : base()
        {
        }

        public tran_applicantphasesEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        public tran_applicantphasesEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }



        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicantPhaseID"))) _applicantphaseid = reader.GetInt64(reader.GetOrdinal("ApplicantPhaseID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ParentID"))) _parentid = reader.GetInt64(reader.GetOrdinal("ParentID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) _registrationid = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchID"))) _batchid = reader.GetInt64(reader.GetOrdinal("BatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PhaseID"))) _phaseid = reader.GetInt64(reader.GetOrdinal("PhaseID"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusID"))) _statusid = reader.GetInt64(reader.GetOrdinal("StatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("SubmittedDate"))) _submitteddate = reader.GetDateTime(reader.GetOrdinal("SubmittedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("SubmittedBy"))) _submittedby = reader.GetGuid(reader.GetOrdinal("SubmittedBy"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicantPhaseID"))) _applicantphaseid = reader.GetInt64(reader.GetOrdinal("ApplicantPhaseID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ParentID"))) _parentid = reader.GetInt64(reader.GetOrdinal("ParentID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) _registrationid = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchID"))) _batchid = reader.GetInt64(reader.GetOrdinal("BatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PhaseID"))) _phaseid = reader.GetInt64(reader.GetOrdinal("PhaseID"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusID"))) _statusid = reader.GetInt64(reader.GetOrdinal("StatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("SubmittedDate"))) _submitteddate = reader.GetDateTime(reader.GetOrdinal("SubmittedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("SubmittedBy"))) _submittedby = reader.GetGuid(reader.GetOrdinal("SubmittedBy"));
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
