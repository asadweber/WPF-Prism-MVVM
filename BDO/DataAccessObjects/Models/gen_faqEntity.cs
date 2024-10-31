using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_faqEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_faqEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _faqid;
        protected long ? _faqcategoryid;
        protected string _questions;
        protected string _answers;
        protected string _questionsen;
        protected string _answersen;
        protected string _tags;
        protected string _urls;
                
        
        [DataMember]
        public long ? faqid
        {
            get { return _faqid; }
            set { _faqid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "faqcategoryid", ResourceType = typeof(CLL.LLClasses.Models._gen_faq))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_faq), ErrorMessageResourceName = "faqcategoryidRequired")]
        public long ? faqcategoryid
        {
            get { return _faqcategoryid; }
            set { _faqcategoryid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "questions", ResourceType = typeof(CLL.LLClasses.Models._gen_faq))]
        public string questions
        {
            get { return _questions; }
            set { _questions = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(-1)]
        [Display(Name = "answers", ResourceType = typeof(CLL.LLClasses.Models._gen_faq))]
        public string answers
        {
            get { return _answers; }
            set { _answers = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "questionsen", ResourceType = typeof(CLL.LLClasses.Models._gen_faq))]
        public string questionsen
        {
            get { return _questionsen; }
            set { _questionsen = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(-1)]
        [Display(Name = "answersen", ResourceType = typeof(CLL.LLClasses.Models._gen_faq))]
        public string answersen
        {
            get { return _answersen; }
            set { _answersen = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(-1)]
        [Display(Name = "tags", ResourceType = typeof(CLL.LLClasses.Models._gen_faq))]
        public string tags
        {
            get { return _tags; }
            set { _tags = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(350)]
        [Display(Name = "urls", ResourceType = typeof(CLL.LLClasses.Models._gen_faq))]
        public string urls
        {
            get { return _urls; }
            set { _urls = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public gen_faqEntity():base()
        {
        }
        
        public gen_faqEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_faqEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("FAQID"))) _faqid = reader.GetInt64(reader.GetOrdinal("FAQID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FAQCategoryID"))) _faqcategoryid = reader.GetInt64(reader.GetOrdinal("FAQCategoryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Questions"))) _questions = reader.GetString(reader.GetOrdinal("Questions"));
                if (!reader.IsDBNull(reader.GetOrdinal("Answers"))) _answers = reader.GetString(reader.GetOrdinal("Answers"));
                if (!reader.IsDBNull(reader.GetOrdinal("QuestionsEn"))) _questionsen = reader.GetString(reader.GetOrdinal("QuestionsEn"));
                if (!reader.IsDBNull(reader.GetOrdinal("AnswersEn"))) _answersen = reader.GetString(reader.GetOrdinal("AnswersEn"));
                if (!reader.IsDBNull(reader.GetOrdinal("TAGS"))) _tags = reader.GetString(reader.GetOrdinal("TAGS"));
                if (!reader.IsDBNull(reader.GetOrdinal("URLS"))) _urls = reader.GetString(reader.GetOrdinal("URLS"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("FAQID"))) _faqid = reader.GetInt64(reader.GetOrdinal("FAQID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FAQCategoryID"))) _faqcategoryid = reader.GetInt64(reader.GetOrdinal("FAQCategoryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Questions"))) _questions = reader.GetString(reader.GetOrdinal("Questions"));
                if (!reader.IsDBNull(reader.GetOrdinal("Answers"))) _answers = reader.GetString(reader.GetOrdinal("Answers"));
                if (!reader.IsDBNull(reader.GetOrdinal("QuestionsEn"))) _questionsen = reader.GetString(reader.GetOrdinal("QuestionsEn"));
                if (!reader.IsDBNull(reader.GetOrdinal("AnswersEn"))) _answersen = reader.GetString(reader.GetOrdinal("AnswersEn"));
                if (!reader.IsDBNull(reader.GetOrdinal("TAGS"))) _tags = reader.GetString(reader.GetOrdinal("TAGS"));
                if (!reader.IsDBNull(reader.GetOrdinal("URLS"))) _urls = reader.GetString(reader.GetOrdinal("URLS"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
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
