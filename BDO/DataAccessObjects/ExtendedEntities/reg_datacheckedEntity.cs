using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    public partial class reg_datacheckedEntity : BaseEntity
    {
        #region Properties

        protected string _applicanttablename;
        protected string _applicanttabledescription;
        protected string _applicanttableactionname;
        protected string _applicantinformation;
        protected string _reviewedbyusername;


        [DataMember]
        [Display(Name = "applicanttablename", ResourceType = typeof(CLL.LLClasses.Models._applicant_review))]
        public string applicanttablename
        {
            get { return _applicanttablename; }
            set { _applicanttablename = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "applicanttabledescription", ResourceType = typeof(CLL.LLClasses.Models._applicant_review))]
        public string applicanttabledescription
        {
            get { return _applicanttabledescription; }
            set { _applicanttabledescription = value; this.OnChnaged(); }
        }

        [DataMember]
        public string applicanttableactionname
        {
            get { return _applicanttableactionname; }
            set { _applicanttableactionname = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "applicantinformation", ResourceType = typeof(CLL.LLClasses.Models._applicant_review))]
        public string applicantinformation
        {
            get { return _applicantinformation; }
            set { _applicantinformation = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "reviewedbyusername", ResourceType = typeof(CLL.LLClasses.Models._applicant_review))]
        public string reviewedbyusername
        {
            get { return _reviewedbyusername; }
            set { _reviewedbyusername = value; this.OnChnaged(); }
        }

        [DataMember]
        public bool? isMarried { get; set; }

        #endregion


        #region Constructor

        protected void LoadFromReader(IDataReader reader, int e)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoViewID"))) _basicinfoviewid = reader.GetInt64(reader.GetOrdinal("BasicInfoViewID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) _registrationid = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicantTableID"))) _applicanttableid = reader.GetInt64(reader.GetOrdinal("ApplicantTableID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicantTableName"))) _applicanttablename = reader.GetString(reader.GetOrdinal("ApplicantTableName"));
                if (!reader.IsDBNull(reader.GetOrdinal("TableDescription"))) _applicanttabledescription = reader.GetString(reader.GetOrdinal("TableDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("TableActionName"))) _applicanttableactionname = reader.GetString(reader.GetOrdinal("TableActionName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedByID"))) _reviewedbyid = reader.GetGuid(reader.GetOrdinal("ReviewedByID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedBy"))) _reviewedbyusername = reader.GetString(reader.GetOrdinal("ReviewedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ViewedDate"))) _vieweddate = reader.GetDateTime(reader.GetOrdinal("ViewedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsChecked"))) _ischecked = reader.GetBoolean(reader.GetOrdinal("IsChecked"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
                CurrentState = EntityState.Unchanged;
            }
        }
        
        #endregion
            
    }
}