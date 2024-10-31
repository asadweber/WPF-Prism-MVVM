using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_genderEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_genderEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _genderid;
        protected string _gender;
        protected string _gendereng;
        protected long ? _priority;
        protected string _remarks;
        protected string _updateinfo;
        protected long ? _tranformactionid;
                
        
        [DataMember]
        public long ? genderid
        {
            get { return _genderid; }
            set { _genderid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(30)]
        [Display(Name = "gender", ResourceType = typeof(CLL.LLClasses.Models._gen_gender))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_gender), ErrorMessageResourceName = "genderRequired")]
        public string gender
        {
            get { return _gender; }
            set { _gender = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(30)]
        [Display(Name = "gendereng", ResourceType = typeof(CLL.LLClasses.Models._gen_gender))]
        public string gendereng
        {
            get { return _gendereng; }
            set { _gendereng = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "priority", ResourceType = typeof(CLL.LLClasses.Models._gen_gender))]
        public long ? priority
        {
            get { return _priority; }
            set { _priority = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._gen_gender))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._gen_gender))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._gen_gender))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public gen_genderEntity():base()
        {
        }
        
        public gen_genderEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_genderEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("GenderID"))) _genderid = reader.GetInt64(reader.GetOrdinal("GenderID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Gender"))) _gender = reader.GetString(reader.GetOrdinal("Gender"));
                if (!reader.IsDBNull(reader.GetOrdinal("GenderEng"))) _gendereng = reader.GetString(reader.GetOrdinal("GenderEng"));
                if (!reader.IsDBNull(reader.GetOrdinal("Priority"))) _priority = reader.GetInt64(reader.GetOrdinal("Priority"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("GenderID"))) _genderid = reader.GetInt64(reader.GetOrdinal("GenderID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Gender"))) _gender = reader.GetString(reader.GetOrdinal("Gender"));
                if (!reader.IsDBNull(reader.GetOrdinal("GenderEng"))) _gendereng = reader.GetString(reader.GetOrdinal("GenderEng"));
                if (!reader.IsDBNull(reader.GetOrdinal("Priority"))) _priority = reader.GetInt64(reader.GetOrdinal("Priority"));
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
