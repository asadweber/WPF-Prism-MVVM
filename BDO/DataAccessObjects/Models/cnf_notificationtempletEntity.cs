using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "cnf_notificationtempletEntity", Namespace = "http://www.KAF.com/types")]
    public partial class cnf_notificationtempletEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _notificationtemplateid;
        protected long ? _templettypeid;
        protected string _templateshortname;
        protected string _templatemsg;
        protected string _tempaltesubject;
        protected string _comment;
        protected string _remarks;
        
        [DataMember]
        [Display(Name = "notificationtemplateid", ResourceType = typeof(CLL.LLClasses.Models._cnf_notificationtemplet))]
        public long ? notificationtemplateid
        {
            get { return _notificationtemplateid; }
            set { _notificationtemplateid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "templettypeid", ResourceType = typeof(CLL.LLClasses.Models._cnf_notificationtemplet))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._cnf_notificationtemplet), ErrorMessageResourceName = "templettypeidRequired")]
        public long ? templettypeid
        {
            get { return _templettypeid; }
            set { _templettypeid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "templateshortname", ResourceType = typeof(CLL.LLClasses.Models._cnf_notificationtemplet))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._cnf_notificationtemplet), ErrorMessageResourceName = "templateshortnameRequired")]
        public string templateshortname
        {
            get { return _templateshortname; }
            set { _templateshortname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(4000)]
        [Display(Name = "templatemsg", ResourceType = typeof(CLL.LLClasses.Models._cnf_notificationtemplet))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._cnf_notificationtemplet), ErrorMessageResourceName = "templatemsgRequired")]
        public string templatemsg
        {
            get { return _templatemsg; }
            set { _templatemsg = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(500)]
        [Display(Name = "tempaltesubject", ResourceType = typeof(CLL.LLClasses.Models._cnf_notificationtemplet))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._cnf_notificationtemplet), ErrorMessageResourceName = "tempaltesubjectRequired")]
        public string tempaltesubject
        {
            get { return _tempaltesubject; }
            set { _tempaltesubject = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "comment", ResourceType = typeof(CLL.LLClasses.Models._cnf_notificationtemplet))]
        public string comment
        {
            get { return _comment; }
            set { _comment = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._cnf_notificationtemplet))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        #endregion
    
        #region Constructor
    
        public cnf_notificationtempletEntity():base()
        {
        }
        
        public cnf_notificationtempletEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public cnf_notificationtempletEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }

        public cnf_notificationtempletEntity(IDataReader reader, int e)
        {
            this.LoadFromReader(reader, e);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationTemplateID"))) _notificationtemplateid = reader.GetInt64(reader.GetOrdinal("NotificationTemplateID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TempletTypeID"))) _templettypeid = reader.GetInt64(reader.GetOrdinal("TempletTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TemplateShortName"))) _templateshortname = reader.GetString(reader.GetOrdinal("TemplateShortName"));
                if (!reader.IsDBNull(reader.GetOrdinal("TemplateMSG"))) _templatemsg = reader.GetString(reader.GetOrdinal("TemplateMSG"));
                if (!reader.IsDBNull(reader.GetOrdinal("TempalteSubject"))) _tempaltesubject = reader.GetString(reader.GetOrdinal("TempalteSubject"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationTemplateID"))) _notificationtemplateid = reader.GetInt64(reader.GetOrdinal("NotificationTemplateID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TempletTypeID"))) _templettypeid = reader.GetInt64(reader.GetOrdinal("TempletTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TemplateShortName"))) _templateshortname = reader.GetString(reader.GetOrdinal("TemplateShortName"));
                if (!reader.IsDBNull(reader.GetOrdinal("TemplateMSG"))) _templatemsg = reader.GetString(reader.GetOrdinal("TemplateMSG"));
                if (!reader.IsDBNull(reader.GetOrdinal("TempalteSubject"))) _tempaltesubject = reader.GetString(reader.GetOrdinal("TempalteSubject"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
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