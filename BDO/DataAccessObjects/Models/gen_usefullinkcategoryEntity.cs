using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_usefullinkcategoryEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_usefullinkcategoryEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _usefullinkcategoryid;
        protected string _usefullinkcategory;
        protected string _usefullinkcategoryar;
        protected string _usefullinkcategorydescription;
        protected string _usefullinkcategorydescriptionar;
                
        
        [DataMember]
        public long ? usefullinkcategoryid
        {
            get { return _usefullinkcategoryid; }
            set { _usefullinkcategoryid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "usefullinkcategory", ResourceType = typeof(CLL.LLClasses.Models._gen_usefullinkcategory))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_usefullinkcategory), ErrorMessageResourceName = "usefullinkcategoryRequired")]
        public string usefullinkcategory
        {
            get { return _usefullinkcategory; }
            set { _usefullinkcategory = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "usefullinkcategoryar", ResourceType = typeof(CLL.LLClasses.Models._gen_usefullinkcategory))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_usefullinkcategory), ErrorMessageResourceName = "usefullinkcategoryarRequired")]
        public string usefullinkcategoryar
        {
            get { return _usefullinkcategoryar; }
            set { _usefullinkcategoryar = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "usefullinkcategorydescription", ResourceType = typeof(CLL.LLClasses.Models._gen_usefullinkcategory))]
        public string usefullinkcategorydescription
        {
            get { return _usefullinkcategorydescription; }
            set { _usefullinkcategorydescription = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "usefullinkcategorydescriptionar", ResourceType = typeof(CLL.LLClasses.Models._gen_usefullinkcategory))]
        public string usefullinkcategorydescriptionar
        {
            get { return _usefullinkcategorydescriptionar; }
            set { _usefullinkcategorydescriptionar = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public gen_usefullinkcategoryEntity():base()
        {
        }
        
        public gen_usefullinkcategoryEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_usefullinkcategoryEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("UsefulLinkCategoryID"))) _usefullinkcategoryid = reader.GetInt64(reader.GetOrdinal("UsefulLinkCategoryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UsefulLinkCategory"))) _usefullinkcategory = reader.GetString(reader.GetOrdinal("UsefulLinkCategory"));
                if (!reader.IsDBNull(reader.GetOrdinal("UsefulLinkCategoryAR"))) _usefullinkcategoryar = reader.GetString(reader.GetOrdinal("UsefulLinkCategoryAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("UsefulLinkCategoryDescription"))) _usefullinkcategorydescription = reader.GetString(reader.GetOrdinal("UsefulLinkCategoryDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("UsefulLinkCategoryDescriptionAR"))) _usefullinkcategorydescriptionar = reader.GetString(reader.GetOrdinal("UsefulLinkCategoryDescriptionAR"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("UsefulLinkCategoryID"))) _usefullinkcategoryid = reader.GetInt64(reader.GetOrdinal("UsefulLinkCategoryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UsefulLinkCategory"))) _usefullinkcategory = reader.GetString(reader.GetOrdinal("UsefulLinkCategory"));
                if (!reader.IsDBNull(reader.GetOrdinal("UsefulLinkCategoryAR"))) _usefullinkcategoryar = reader.GetString(reader.GetOrdinal("UsefulLinkCategoryAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("UsefulLinkCategoryDescription"))) _usefullinkcategorydescription = reader.GetString(reader.GetOrdinal("UsefulLinkCategoryDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("UsefulLinkCategoryDescriptionAR"))) _usefullinkcategorydescriptionar = reader.GetString(reader.GetOrdinal("UsefulLinkCategoryDescriptionAR"));
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
