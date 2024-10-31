using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_skillproficiencyEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_skillproficiencyEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _skillproficiencyid;
        protected string _skillname;
        protected int ? _skillvalue;
        protected string _comment;
        protected string _remarks;
        protected string _updateinfo;
        protected long ? _tranformactionid;
        protected long ? _oracleid;
                
        
        [DataMember]
        public long ? skillproficiencyid
        {
            get { return _skillproficiencyid; }
            set { _skillproficiencyid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "skillname", ResourceType = typeof(CLL.LLClasses.Models._gen_skillproficiency))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_skillproficiency), ErrorMessageResourceName = "skillnameRequired")]
        public string skillname
        {
            get { return _skillname; }
            set { _skillname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "skillvalue", ResourceType = typeof(CLL.LLClasses.Models._gen_skillproficiency))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_skillproficiency), ErrorMessageResourceName = "skillvalueRequired")]
        public int ? skillvalue
        {
            get { return _skillvalue; }
            set { _skillvalue = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "comment", ResourceType = typeof(CLL.LLClasses.Models._gen_skillproficiency))]
        public string comment
        {
            get { return _comment; }
            set { _comment = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._gen_skillproficiency))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._gen_skillproficiency))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._gen_skillproficiency))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "oracleid", ResourceType = typeof(CLL.LLClasses.Models._gen_skillproficiency))]
        public long ? oracleid
        {
            get { return _oracleid; }
            set { _oracleid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public gen_skillproficiencyEntity():base()
        {
        }
        
        public gen_skillproficiencyEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_skillproficiencyEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("SkillProficiencyID"))) _skillproficiencyid = reader.GetInt64(reader.GetOrdinal("SkillProficiencyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("SkillName"))) _skillname = reader.GetString(reader.GetOrdinal("SkillName"));
                if (!reader.IsDBNull(reader.GetOrdinal("SkillValue"))) _skillvalue = reader.GetInt32(reader.GetOrdinal("SkillValue"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("OracleID"))) _oracleid = reader.GetInt64(reader.GetOrdinal("OracleID"));
                CurrentState = EntityState.Unchanged;
            }
        }


        protected void LoadFromReader(IDataReader reader, bool IsListViewShow)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("SkillProficiencyID"))) _skillproficiencyid = reader.GetInt64(reader.GetOrdinal("SkillProficiencyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("SkillName"))) _skillname = reader.GetString(reader.GetOrdinal("SkillName"));
                if (!reader.IsDBNull(reader.GetOrdinal("SkillValue"))) _skillvalue = reader.GetInt32(reader.GetOrdinal("SkillValue"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("OracleID"))) _oracleid = reader.GetInt64(reader.GetOrdinal("OracleID"));
                CurrentState = EntityState.Unchanged;
            }
        }
        
        #endregion
        
        
            
    }
}
