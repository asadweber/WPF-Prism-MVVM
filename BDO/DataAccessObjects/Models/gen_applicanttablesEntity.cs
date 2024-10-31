using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_applicanttablesEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_applicanttablesEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _applicanttableid;
        protected string _applicanttablename;
        protected string _tabledescription;
        protected string _tableactionname;
        protected long ? _dataorder;
                
        
        [DataMember]
        public long ? applicanttableid
        {
            get { return _applicanttableid; }
            set { _applicanttableid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "applicanttablename", ResourceType = typeof(CLL.LLClasses.Models._gen_applicanttables))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_applicanttables), ErrorMessageResourceName = "applicanttablenameRequired")]
        public string applicanttablename
        {
            get { return _applicanttablename; }
            set { _applicanttablename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(350)]
        [Display(Name = "tabledescription", ResourceType = typeof(CLL.LLClasses.Models._gen_applicanttables))]
        public string tabledescription
        {
            get { return _tabledescription; }
            set { _tabledescription = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        public string tableactionname
        {
            get { return _tableactionname; }
            set { _tableactionname = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "dataorder", ResourceType = typeof(CLL.LLClasses.Models._gen_applicanttables))]
        public long ? dataorder
        {
            get { return _dataorder; }
            set { _dataorder = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public gen_applicanttablesEntity():base()
        {
        }
        
        public gen_applicanttablesEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_applicanttablesEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicantTableID"))) _applicanttableid = reader.GetInt64(reader.GetOrdinal("ApplicantTableID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicantTableName"))) _applicanttablename = reader.GetString(reader.GetOrdinal("ApplicantTableName"));
                if (!reader.IsDBNull(reader.GetOrdinal("TableDescription"))) _tabledescription = reader.GetString(reader.GetOrdinal("TableDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("TableActionName"))) _tableactionname = reader.GetString(reader.GetOrdinal("TableActionName"));
                if (!reader.IsDBNull(reader.GetOrdinal("DataOrder"))) _dataorder = reader.GetInt64(reader.GetOrdinal("DataOrder"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicantTableID"))) _applicanttableid = reader.GetInt64(reader.GetOrdinal("ApplicantTableID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicantTableName"))) _applicanttablename = reader.GetString(reader.GetOrdinal("ApplicantTableName"));
                if (!reader.IsDBNull(reader.GetOrdinal("TableDescription"))) _tabledescription = reader.GetString(reader.GetOrdinal("TableDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("TableActionName"))) _tableactionname = reader.GetString(reader.GetOrdinal("TableActionName"));
                if (!reader.IsDBNull(reader.GetOrdinal("DataOrder"))) _dataorder = reader.GetInt64(reader.GetOrdinal("DataOrder"));
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
