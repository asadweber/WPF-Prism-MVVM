using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "reg_nonkuwaitystatusEntity", Namespace = "http://www.KAF.com/types")]
    public partial class reg_nonkuwaitystatusEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _regnonkuwaitystatusid;
        protected long ? _nonkuwaitystatusid;
        protected string _civilid;
        protected long ? _basicinfoid;
        protected long ? _familyid;
        protected string _comment;
        protected string _remarks;
        protected string _updateinfo;
        protected long ? _tranformactionid;
                
        
        [DataMember]
        public long ? regnonkuwaitystatusid
        {
            get { return _regnonkuwaitystatusid; }
            set { _regnonkuwaitystatusid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "nonkuwaitystatusid", ResourceType = typeof(CLL.LLClasses.Models._reg_nonkuwaitystatus))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_nonkuwaitystatus), ErrorMessageResourceName = "nonkuwaitystatusidRequired")]
        public long ? nonkuwaitystatusid
        {
            get { return _nonkuwaitystatusid; }
            set { _nonkuwaitystatusid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "civilid", ResourceType = typeof(CLL.LLClasses.Models._reg_nonkuwaitystatus))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_nonkuwaitystatus), ErrorMessageResourceName = "civilidRequired")]
        public string civilid
        {
            get { return _civilid; }
            set { _civilid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "basicinfoid", ResourceType = typeof(CLL.LLClasses.Models._reg_nonkuwaitystatus))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_nonkuwaitystatus), ErrorMessageResourceName = "basicinfoidRequired")]
        public long ? basicinfoid
        {
            get { return _basicinfoid; }
            set { _basicinfoid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familyid", ResourceType = typeof(CLL.LLClasses.Models._reg_nonkuwaitystatus))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_nonkuwaitystatus), ErrorMessageResourceName = "familyidRequired")]
        public long ? familyid
        {
            get { return _familyid; }
            set { _familyid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "comment", ResourceType = typeof(CLL.LLClasses.Models._reg_nonkuwaitystatus))]
        public string comment
        {
            get { return _comment; }
            set { _comment = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._reg_nonkuwaitystatus))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._reg_nonkuwaitystatus))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._reg_nonkuwaitystatus))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public reg_nonkuwaitystatusEntity():base()
        {
        }
        
        public reg_nonkuwaitystatusEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public reg_nonkuwaitystatusEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("RegNonKuwaityStatusID"))) _regnonkuwaitystatusid = reader.GetInt64(reader.GetOrdinal("RegNonKuwaityStatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NonKuwaityStatusID"))) _nonkuwaitystatusid = reader.GetInt64(reader.GetOrdinal("NonKuwaityStatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _civilid = reader.GetString(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyID"))) _familyid = reader.GetInt64(reader.GetOrdinal("FamilyID"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("RegNonKuwaityStatusID"))) _regnonkuwaitystatusid = reader.GetInt64(reader.GetOrdinal("RegNonKuwaityStatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NonKuwaityStatusID"))) _nonkuwaitystatusid = reader.GetInt64(reader.GetOrdinal("NonKuwaityStatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _civilid = reader.GetString(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyID"))) _familyid = reader.GetInt64(reader.GetOrdinal("FamilyID"));
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
