﻿using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "tran_rollbackinfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class tran_rollbackinfoEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _rollbackid;
        protected long ? _basicinfoid;
        protected long ? _registrationid;
        protected long ? _type;
        protected DateTime ? _trandate;
        protected string _comment;
        protected string _remarks;
        protected string _updateinfo;
        protected long ? _tranformactionid;
                
        
        [DataMember]
        public long ? rollbackid
        {
            get { return _rollbackid; }
            set { _rollbackid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "basicinfoid", ResourceType = typeof(CLL.LLClasses.Models._tran_rollbackinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_rollbackinfo), ErrorMessageResourceName = "basicinfoidRequired")]
        public long ? basicinfoid
        {
            get { return _basicinfoid; }
            set { _basicinfoid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "registrationid", ResourceType = typeof(CLL.LLClasses.Models._tran_rollbackinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_rollbackinfo), ErrorMessageResourceName = "registrationidRequired")]
        public long ? registrationid
        {
            get { return _registrationid; }
            set { _registrationid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "type", ResourceType = typeof(CLL.LLClasses.Models._tran_rollbackinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_rollbackinfo), ErrorMessageResourceName = "typeRequired")]
        public long ? type
        {
            get { return _type; }
            set { _type = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "trandate", ResourceType = typeof(CLL.LLClasses.Models._tran_rollbackinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_rollbackinfo), ErrorMessageResourceName = "trandateRequired")]
        public DateTime ? trandate
        {
            get { return _trandate; }
            set { _trandate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "comment", ResourceType = typeof(CLL.LLClasses.Models._tran_rollbackinfo))]
        public string comment
        {
            get { return _comment; }
            set { _comment = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._tran_rollbackinfo))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._tran_rollbackinfo))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._tran_rollbackinfo))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public tran_rollbackinfoEntity():base()
        {
        }
        
        public tran_rollbackinfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public tran_rollbackinfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("RollbackID"))) _rollbackid = reader.GetInt64(reader.GetOrdinal("RollbackID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) _registrationid = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Type"))) _type = reader.GetInt64(reader.GetOrdinal("Type"));
                if (!reader.IsDBNull(reader.GetOrdinal("TranDate"))) _trandate = reader.GetDateTime(reader.GetOrdinal("TranDate"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("RollbackID"))) _rollbackid = reader.GetInt64(reader.GetOrdinal("RollbackID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) _registrationid = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Type"))) _type = reader.GetInt64(reader.GetOrdinal("Type"));
                if (!reader.IsDBNull(reader.GetOrdinal("TranDate"))) _trandate = reader.GetDateTime(reader.GetOrdinal("TranDate"));
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
