using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_trainingcentreEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_trainingcentreEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _trainingcentreid;
        protected string _trainingcentrename;
        protected string _trainingcentrenameeng;
        protected string _remarks;
        protected string _migrationinfo;
        protected string _migrationtable;
        protected string _migrationtext;
                
        
        [DataMember]
        public long ? trainingcentreid
        {
            get { return _trainingcentreid; }
            set { _trainingcentreid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(100)]
        [Display(Name = "trainingcentrename", ResourceType = typeof(CLL.LLClasses.Models._gen_trainingcentre))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_trainingcentre), ErrorMessageResourceName = "trainingcentrenameRequired")]
        public string trainingcentrename
        {
            get { return _trainingcentrename; }
            set { _trainingcentrename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(100)]
        [Display(Name = "trainingcentrenameeng", ResourceType = typeof(CLL.LLClasses.Models._gen_trainingcentre))]
        public string trainingcentrenameeng
        {
            get { return _trainingcentrenameeng; }
            set { _trainingcentrenameeng = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._gen_trainingcentre))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "migrationinfo", ResourceType = typeof(CLL.LLClasses.Models._gen_trainingcentre))]
        public string migrationinfo
        {
            get { return _migrationinfo; }
            set { _migrationinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "migrationtable", ResourceType = typeof(CLL.LLClasses.Models._gen_trainingcentre))]
        public string migrationtable
        {
            get { return _migrationtable; }
            set { _migrationtable = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "migrationtext", ResourceType = typeof(CLL.LLClasses.Models._gen_trainingcentre))]
        public string migrationtext
        {
            get { return _migrationtext; }
            set { _migrationtext = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public gen_trainingcentreEntity():base()
        {
        }
        
        public gen_trainingcentreEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_trainingcentreEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("TrainingCentreID"))) _trainingcentreid = reader.GetInt64(reader.GetOrdinal("TrainingCentreID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TrainingCentreName"))) _trainingcentrename = reader.GetString(reader.GetOrdinal("TrainingCentreName"));
                if (!reader.IsDBNull(reader.GetOrdinal("TrainingCentreNameEng"))) _trainingcentrenameeng = reader.GetString(reader.GetOrdinal("TrainingCentreNameEng"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                if (!reader.IsDBNull(reader.GetOrdinal("MigrationInfo"))) _migrationinfo = reader.GetString(reader.GetOrdinal("MigrationInfo"));
                if (!reader.IsDBNull(reader.GetOrdinal("MigrationTable"))) _migrationtable = reader.GetString(reader.GetOrdinal("MigrationTable"));
                if (!reader.IsDBNull(reader.GetOrdinal("MigrationText"))) _migrationtext = reader.GetString(reader.GetOrdinal("MigrationText"));
                CurrentState = EntityState.Unchanged;
            }
        }


        protected void LoadFromReader(IDataReader reader, bool IsListViewShow)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("TrainingCentreID"))) _trainingcentreid = reader.GetInt64(reader.GetOrdinal("TrainingCentreID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TrainingCentreName"))) _trainingcentrename = reader.GetString(reader.GetOrdinal("TrainingCentreName"));
                if (!reader.IsDBNull(reader.GetOrdinal("TrainingCentreNameEng"))) _trainingcentrenameeng = reader.GetString(reader.GetOrdinal("TrainingCentreNameEng"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                if (!reader.IsDBNull(reader.GetOrdinal("MigrationInfo"))) _migrationinfo = reader.GetString(reader.GetOrdinal("MigrationInfo"));
                if (!reader.IsDBNull(reader.GetOrdinal("MigrationTable"))) _migrationtable = reader.GetString(reader.GetOrdinal("MigrationTable"));
                if (!reader.IsDBNull(reader.GetOrdinal("MigrationText"))) _migrationtext = reader.GetString(reader.GetOrdinal("MigrationText"));
                CurrentState = EntityState.Unchanged;
            }
        }
        
        #endregion
        
        
            
    }
}
