using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_faqcategoryEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_faqcategoryEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _faqcategoryid;
        protected string _faqcategory;
        protected string _faqcategoryen;
                
        
        [DataMember]
        public long ? faqcategoryid
        {
            get { return _faqcategoryid; }
            set { _faqcategoryid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(351)]
        [Display(Name = "faqcategory", ResourceType = typeof(CLL.LLClasses.Models._gen_faqcategory))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_faqcategory), ErrorMessageResourceName = "faqcategoryRequired")]
        public string faqcategory
        {
            get { return _faqcategory; }
            set { _faqcategory = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(351)]
        [Display(Name = "faqcategoryen", ResourceType = typeof(CLL.LLClasses.Models._gen_faqcategory))]
        public string faqcategoryen
        {
            get { return _faqcategoryen; }
            set { _faqcategoryen = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public gen_faqcategoryEntity():base()
        {
        }
        
        public gen_faqcategoryEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_faqcategoryEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("FAQCategoryID"))) _faqcategoryid = reader.GetInt64(reader.GetOrdinal("FAQCategoryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FAQCategory"))) _faqcategory = reader.GetString(reader.GetOrdinal("FAQCategory"));
                if (!reader.IsDBNull(reader.GetOrdinal("FAQCategoryEn"))) _faqcategoryen = reader.GetString(reader.GetOrdinal("FAQCategoryEn"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("FAQCategoryID"))) _faqcategoryid = reader.GetInt64(reader.GetOrdinal("FAQCategoryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FAQCategory"))) _faqcategory = reader.GetString(reader.GetOrdinal("FAQCategory"));
                if (!reader.IsDBNull(reader.GetOrdinal("FAQCategoryEn"))) _faqcategoryen = reader.GetString(reader.GetOrdinal("FAQCategoryEn"));
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
