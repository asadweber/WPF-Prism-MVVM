using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_companiesEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_companiesEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _companyid;
        protected string _companyname;
        protected long ? _companytypeid;
        protected string _comment;
        protected string _remarks;
        
        [DataMember]
        public long ? companyid
        {
            get { return _companyid; }
            set { _companyid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "companyname", ResourceType = typeof(CLL.LLClasses.Models._gen_companies))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_companies), ErrorMessageResourceName = "companynameRequired")]
        public string companyname
        {
            get { return _companyname; }
            set { _companyname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "companytypeid", ResourceType = typeof(CLL.LLClasses.Models._gen_companies))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_companies), ErrorMessageResourceName = "companytypeidRequired")]
        public long ? companytypeid
        {
            get { return _companytypeid; }
            set { _companytypeid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "comment", ResourceType = typeof(CLL.LLClasses.Models._gen_companies))]
        public string comment
        {
            get { return _comment; }
            set { _comment = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._gen_companies))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        #endregion
    
        #region Constructor
    
        public gen_companiesEntity():base()
        {
        }
        
        public gen_companiesEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_companiesEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }

        public gen_companiesEntity(IDataReader reader, int e)
        {
            this.LoadFromReader(reader, e);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyID"))) _companyid = reader.GetInt64(reader.GetOrdinal("CompanyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyName"))) _companyname = reader.GetString(reader.GetOrdinal("CompanyName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyTypeID"))) _companytypeid = reader.GetInt64(reader.GetOrdinal("CompanyTypeID"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyID"))) _companyid = reader.GetInt64(reader.GetOrdinal("CompanyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyName"))) _companyname = reader.GetString(reader.GetOrdinal("CompanyName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyTypeID"))) _companytypeid = reader.GetInt64(reader.GetOrdinal("CompanyTypeID"));
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
