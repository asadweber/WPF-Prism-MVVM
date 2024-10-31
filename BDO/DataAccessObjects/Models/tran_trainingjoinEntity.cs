using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "tran_trainingjoinEntity", Namespace = "http://www.KAF.com/types")]
    public partial class tran_trainingjoinEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _trgjoinid;
        protected long ? _basicinfoid;
        protected long ? _registrationid;
        protected long ? _trgcentreid;
        protected DateTime ? _joindate;
        protected long? _volunteerno;
        protected string? _groupno;
        protected long ? _joiningbatchid;
        protected string? _orderno;
        protected DateTime? _orderdate;
        protected string _remarks;
        protected bool ? _issoftdeleted;
        protected string _updateinfo;
        protected long ? _tranformactionid;
                
        
        [DataMember]
        public long ? trgjoinid
        {
            get { return _trgjoinid; }
            set { _trgjoinid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "basicinfoid", ResourceType = typeof(CLL.LLClasses.Models._tran_trainingjoin))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_trainingjoin), ErrorMessageResourceName = "basicinfoidRequired")]
        public long ? basicinfoid
        {
            get { return _basicinfoid; }
            set { _basicinfoid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "registrationid", ResourceType = typeof(CLL.LLClasses.Models._tran_trainingjoin))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_trainingjoin), ErrorMessageResourceName = "registrationidRequired")]
        public long ? registrationid
        {
            get { return _registrationid; }
            set { _registrationid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "trgcentreid", ResourceType = typeof(CLL.LLClasses.Models._tran_trainingjoin))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_trainingjoin), ErrorMessageResourceName = "trgcentreidRequired")]
        public long ? trgcentreid
        {
            get { return _trgcentreid; }
            set { _trgcentreid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "joindate", ResourceType = typeof(CLL.LLClasses.Models._tran_trainingjoin))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_trainingjoin), ErrorMessageResourceName = "joindateRequired")]
        public DateTime ? joindate
        {
            get { return _joindate; }
            set { _joindate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "volunteerno", ResourceType = typeof(CLL.LLClasses.Models._tran_trainingjoin))]
        public long? volunteerno
        {
            get { return _volunteerno; }
            set { _volunteerno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "groupno", ResourceType = typeof(CLL.LLClasses.Models._tran_trainingjoin))]
        public string? groupno
        {
            get { return _groupno; }
            set { _groupno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "joiningbatchid", ResourceType = typeof(CLL.LLClasses.Models._tran_trainingjoin))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_trainingjoin), ErrorMessageResourceName = "joiningbatchidRequired")]
        public long ? joiningbatchid
        {
            get { return _joiningbatchid; }
            set { _joiningbatchid = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(100)]
        [Display(Name = "orderno", ResourceType = typeof(CLL.LLClasses.Models._tran_trainingjoin))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_trainingjoin), ErrorMessageResourceName = "ordernoRequired")]
        public string? orderno
        {
            get { return _orderno; }
            set { _orderno = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "orderdate", ResourceType = typeof(CLL.LLClasses.Models._tran_trainingjoin))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_trainingjoin), ErrorMessageResourceName = "orderdateRequired")]
        public DateTime? orderdate
        {
            get { return _orderdate; }
            set { _orderdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._tran_trainingjoin))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "issoftdeleted", ResourceType = typeof(CLL.LLClasses.Models._tran_trainingjoin))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_trainingjoin), ErrorMessageResourceName = "issoftdeletedRequired")]
        public bool ? issoftdeleted
        {
            get { return _issoftdeleted; }
            set { _issoftdeleted = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._tran_trainingjoin))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._tran_trainingjoin))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public tran_trainingjoinEntity():base()
        {
        }
        
        public tran_trainingjoinEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public tran_trainingjoinEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }

        public tran_trainingjoinEntity(IDataReader reader, int e)
        {
            this.LoadFromReader(reader, e);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("TrgJoinID"))) _trgjoinid = reader.GetInt64(reader.GetOrdinal("TrgJoinID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) _registrationid = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TrgCentreID"))) _trgcentreid = reader.GetInt64(reader.GetOrdinal("TrgCentreID"));
                if (!reader.IsDBNull(reader.GetOrdinal("JoinDate"))) _joindate = reader.GetDateTime(reader.GetOrdinal("JoinDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("VolunteerNo"))) _volunteerno = reader.GetInt64(reader.GetOrdinal("VolunteerNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("GroupNo"))) _groupno = reader.GetString(reader.GetOrdinal("GroupNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("JoiningBatchID"))) _joiningbatchid = reader.GetInt64(reader.GetOrdinal("JoiningBatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrderNo"))) _orderno = reader.GetString(reader.GetOrdinal("OrderNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrderDate"))) _orderdate = reader.GetDateTime(reader.GetOrdinal("OrderDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsSoftDeleted"))) _issoftdeleted = reader.GetBoolean(reader.GetOrdinal("IsSoftDeleted"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("TrgJoinID"))) _trgjoinid = reader.GetInt64(reader.GetOrdinal("TrgJoinID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) _registrationid = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TrgCentreID"))) _trgcentreid = reader.GetInt64(reader.GetOrdinal("TrgCentreID"));
                if (!reader.IsDBNull(reader.GetOrdinal("JoinDate"))) _joindate = reader.GetDateTime(reader.GetOrdinal("JoinDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("VolunteerNo"))) _volunteerno = reader.GetInt64(reader.GetOrdinal("VolunteerNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("GroupNo"))) _groupno = reader.GetString(reader.GetOrdinal("GroupNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("JoiningBatchID"))) _joiningbatchid = reader.GetInt64(reader.GetOrdinal("JoiningBatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrderNo"))) _orderno = reader.GetString(reader.GetOrdinal("OrderNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrderDate"))) _orderdate = reader.GetDateTime(reader.GetOrdinal("OrderDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsSoftDeleted"))) _issoftdeleted = reader.GetBoolean(reader.GetOrdinal("IsSoftDeleted"));
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
