using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "reg_languageEntity", Namespace = "http://www.KAF.com/types")]
    public partial class reg_languageEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _languageprofid;
        protected long ? _basicinfoid;
        protected long ? _languageid;
        protected long ? _speakingskillproficiencyid;
        protected long ? _readingskillproficiencyid;
        protected long ? _writingskillproficiencyid;
        protected string _comment;
        protected string _remarks;
        protected string _updateinfo;
        protected long ? _tranformactionid;
                
        
        [DataMember]
        public long ? languageprofid
        {
            get { return _languageprofid; }
            set { _languageprofid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "basicinfoid", ResourceType = typeof(CLL.LLClasses.Models._reg_language))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_language), ErrorMessageResourceName = "basicinfoidRequired")]
        public long ? basicinfoid
        {
            get { return _basicinfoid; }
            set { _basicinfoid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "languageid", ResourceType = typeof(CLL.LLClasses.Models._reg_language))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_language), ErrorMessageResourceName = "languageidRequired")]
        public long ? languageid
        {
            get { return _languageid; }
            set { _languageid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "speakingskillproficiencyid", ResourceType = typeof(CLL.LLClasses.Models._reg_language))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_language), ErrorMessageResourceName = "speakingskillproficiencyidRequired")]
        public long ? speakingskillproficiencyid
        {
            get { return _speakingskillproficiencyid; }
            set { _speakingskillproficiencyid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "readingskillproficiencyid", ResourceType = typeof(CLL.LLClasses.Models._reg_language))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_language), ErrorMessageResourceName = "readingskillproficiencyidRequired")]
        public long ? readingskillproficiencyid
        {
            get { return _readingskillproficiencyid; }
            set { _readingskillproficiencyid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "writingskillproficiencyid", ResourceType = typeof(CLL.LLClasses.Models._reg_language))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_language), ErrorMessageResourceName = "writingskillproficiencyidRequired")]
        public long ? writingskillproficiencyid
        {
            get { return _writingskillproficiencyid; }
            set { _writingskillproficiencyid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "comment", ResourceType = typeof(CLL.LLClasses.Models._reg_language))]
        public string comment
        {
            get { return _comment; }
            set { _comment = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._reg_language))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._reg_language))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._reg_language))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public reg_languageEntity():base()
        {
        }
        
        public reg_languageEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public reg_languageEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("LanguageProfID"))) _languageprofid = reader.GetInt64(reader.GetOrdinal("LanguageProfID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("LanguageID"))) _languageid = reader.GetInt64(reader.GetOrdinal("LanguageID"));
                if (!reader.IsDBNull(reader.GetOrdinal("SpeakingSkillProficiencyID"))) _speakingskillproficiencyid = reader.GetInt64(reader.GetOrdinal("SpeakingSkillProficiencyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReadingSkillProficiencyID"))) _readingskillproficiencyid = reader.GetInt64(reader.GetOrdinal("ReadingSkillProficiencyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("WritingSkillProficiencyID"))) _writingskillproficiencyid = reader.GetInt64(reader.GetOrdinal("WritingSkillProficiencyID"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("LanguageProfID"))) _languageprofid = reader.GetInt64(reader.GetOrdinal("LanguageProfID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("LanguageID"))) _languageid = reader.GetInt64(reader.GetOrdinal("LanguageID"));
                if (!reader.IsDBNull(reader.GetOrdinal("SpeakingSkillProficiencyID"))) _speakingskillproficiencyid = reader.GetInt64(reader.GetOrdinal("SpeakingSkillProficiencyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReadingSkillProficiencyID"))) _readingskillproficiencyid = reader.GetInt64(reader.GetOrdinal("ReadingSkillProficiencyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("WritingSkillProficiencyID"))) _writingskillproficiencyid = reader.GetInt64(reader.GetOrdinal("WritingSkillProficiencyID"));
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
