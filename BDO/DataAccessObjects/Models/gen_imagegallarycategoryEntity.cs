using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_imagegallarycategoryEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_imagegallarycategoryEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _imagegallarycategoryid;
        protected string _imagegallarycategory;
        protected string _descriptions;
                
        
        [DataMember]
        public long ? imagegallarycategoryid
        {
            get { return _imagegallarycategoryid; }
            set { _imagegallarycategoryid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "imagegallarycategory", ResourceType = typeof(CLL.LLClasses.Models._gen_imagegallarycategory))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_imagegallarycategory), ErrorMessageResourceName = "imagegallarycategoryRequired")]
        public string imagegallarycategory
        {
            get { return _imagegallarycategory; }
            set { _imagegallarycategory = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "descriptions", ResourceType = typeof(CLL.LLClasses.Models._gen_imagegallarycategory))]
        public string descriptions
        {
            get { return _descriptions; }
            set { _descriptions = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public gen_imagegallarycategoryEntity():base()
        {
        }
        
        public gen_imagegallarycategoryEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_imagegallarycategoryEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("ImageGallaryCategoryID"))) _imagegallarycategoryid = reader.GetInt64(reader.GetOrdinal("ImageGallaryCategoryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ImageGallaryCategory"))) _imagegallarycategory = reader.GetString(reader.GetOrdinal("ImageGallaryCategory"));
                if (!reader.IsDBNull(reader.GetOrdinal("Descriptions"))) _descriptions = reader.GetString(reader.GetOrdinal("Descriptions"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("ImageGallaryCategoryID"))) _imagegallarycategoryid = reader.GetInt64(reader.GetOrdinal("ImageGallaryCategoryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ImageGallaryCategory"))) _imagegallarycategory = reader.GetString(reader.GetOrdinal("ImageGallaryCategory"));
                if (!reader.IsDBNull(reader.GetOrdinal("Descriptions"))) _descriptions = reader.GetString(reader.GetOrdinal("Descriptions"));
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
