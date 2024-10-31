using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class tran_notificationbatchEntity : BaseEntity
    {
        protected long? _notificationtemplateid;
        protected string _templatemsg;
        protected DateTime? _notificationdate;
        protected DateTime? _notificationtime;
        protected DateTime? _notificationdatetime;
        protected string? _basicinfoids;
        protected bool? _smsnotification;
        protected bool? _pacinotification;
        protected bool? _emailnotification;
        protected string _batchidstring;

        [DataMember]
        [Display(Name = "notificationtemplateid", ResourceType = typeof(CLL.LLClasses.Models._cnf_notificationtemplet))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._cnf_notificationtemplet), ErrorMessageResourceName = "templatemsgRequired")]
        public long? notificationtemplateid
        {
            get { return _notificationtemplateid; }
            set { _notificationtemplateid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "templatemsg", ResourceType = typeof(CLL.LLClasses.Models._cnf_notificationtemplet))]
        public string templatemsg
        {
            get { return _templatemsg; }
            set { _templatemsg = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "notificationdate", ResourceType = typeof(CLL.LLClasses.Models._applicant_notification))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._applicant_notification), ErrorMessageResourceName = "notificationdateRequired")]
        public DateTime? notificationdate
        {
            get { return _notificationdate; }
            set { _notificationdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "notificationtime", ResourceType = typeof(CLL.LLClasses.Models._applicant_notification))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._applicant_notification), ErrorMessageResourceName = "notificationtimeRequired")]
        public DateTime? notificationtime
        {
            get { return _notificationtime; }
            set { _notificationtime = value; this.OnChnaged(); }
        }

        [DataMember]
        public DateTime? notificationdatetime
        {
            get { return _notificationdatetime; }
            set { _notificationdatetime = value; this.OnChnaged(); }
        }

        [DataMember]
        public string? basicinfoids
        {
            get { return _basicinfoids; }
            set { _basicinfoids = value; this.OnChnaged(); }
        }

        [DataMember]
        public string batchidstring
        {
            get { return _batchidstring; }
            set { _batchidstring = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "smsnotification", ResourceType = typeof(CLL.LLClasses.Models._applicant_notification))]
        public bool? smsnotification
        {
            get { return _smsnotification; }
            set { _smsnotification = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "pacinotification", ResourceType = typeof(CLL.LLClasses.Models._applicant_notification))]
        public bool? pacinotification
        {
            get { return _pacinotification; }
            set { _pacinotification = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "emailnotification", ResourceType = typeof(CLL.LLClasses.Models._applicant_notification))]
        public bool? emailnotification
        {
            get { return _emailnotification; }
            set { _emailnotification = value; this.OnChnaged(); }
        }

        [DataMember]
        public List<tran_notificationbatchdetEntity> NotificationBatchDetList { get; set; }

    }
}
