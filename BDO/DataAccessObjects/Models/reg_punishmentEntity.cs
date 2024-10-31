using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "reg_punishmentEntity", Namespace = "http://www.KAF.com/types")]
    public partial class reg_punishmentEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _punishmentid;
        protected long ? _basicinfoid;
        protected string _punishmentreason;
        protected string _punishmentdetails;
        protected DateTime ? _punishmentdate;
        protected DateTime ? _punishmenttodate;
        protected string _comment;
        protected string _remarks;
        protected string _updateinfo;
        protected long ? _tranformactionid;
                
        
        [DataMember]
        public long ? punishmentid
        {
            get { return _punishmentid; }
            set { _punishmentid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "basicinfoid", ResourceType = typeof(CLL.LLClasses.Models._reg_punishment))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_punishment), ErrorMessageResourceName = "basicinfoidRequired")]
        public long ? basicinfoid
        {
            get { return _basicinfoid; }
            set { _basicinfoid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "punishmentreason", ResourceType = typeof(CLL.LLClasses.Models._reg_punishment))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_punishment), ErrorMessageResourceName = "punishmentreasonRequired")]
        public string punishmentreason
        {
            get { return _punishmentreason; }
            set { _punishmentreason = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "punishmentdetails", ResourceType = typeof(CLL.LLClasses.Models._reg_punishment))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_punishment), ErrorMessageResourceName = "punishmentdetailsRequired")]
        public string punishmentdetails
        {
            get { return _punishmentdetails; }
            set { _punishmentdetails = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "punishmentdate", ResourceType = typeof(CLL.LLClasses.Models._reg_punishment))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_punishment), ErrorMessageResourceName = "punishmentdateRequired")]
        public DateTime ? punishmentdate
        {
            get { return _punishmentdate; }
            set { _punishmentdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "punishmenttodate", ResourceType = typeof(CLL.LLClasses.Models._reg_punishment))]
        public DateTime ? punishmenttodate
        {
            get { return _punishmenttodate; }
            set { _punishmenttodate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "comment", ResourceType = typeof(CLL.LLClasses.Models._reg_punishment))]
        public string comment
        {
            get { return _comment; }
            set { _comment = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._reg_punishment))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._reg_punishment))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._reg_punishment))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public reg_punishmentEntity():base()
        {
        }
        
        public reg_punishmentEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public reg_punishmentEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("PunishmentID"))) _punishmentid = reader.GetInt64(reader.GetOrdinal("PunishmentID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PunishmentReason"))) _punishmentreason = reader.GetString(reader.GetOrdinal("PunishmentReason"));
                if (!reader.IsDBNull(reader.GetOrdinal("PunishmentDetails"))) _punishmentdetails = reader.GetString(reader.GetOrdinal("PunishmentDetails"));
                if (!reader.IsDBNull(reader.GetOrdinal("PunishmentDate"))) _punishmentdate = reader.GetDateTime(reader.GetOrdinal("PunishmentDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PunishmentToDate"))) _punishmenttodate = reader.GetDateTime(reader.GetOrdinal("PunishmentToDate"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("PunishmentID"))) _punishmentid = reader.GetInt64(reader.GetOrdinal("PunishmentID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PunishmentReason"))) _punishmentreason = reader.GetString(reader.GetOrdinal("PunishmentReason"));
                if (!reader.IsDBNull(reader.GetOrdinal("PunishmentDetails"))) _punishmentdetails = reader.GetString(reader.GetOrdinal("PunishmentDetails"));
                if (!reader.IsDBNull(reader.GetOrdinal("PunishmentDate"))) _punishmentdate = reader.GetDateTime(reader.GetOrdinal("PunishmentDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PunishmentToDate"))) _punishmenttodate = reader.GetDateTime(reader.GetOrdinal("PunishmentToDate"));
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
