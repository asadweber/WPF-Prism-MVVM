using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class gen_certificatesubjectsEntity
    {
        #region Properties
    
        protected string? _certificatename;
        
        [DataMember]
        [Display(Name = "certificateid", ResourceType = typeof(CLL.LLClasses.Models._gen_certificatesubjects))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_certificatesubjects), ErrorMessageResourceName = "certificateidRequired")]
        public string? certificatename
        {
            get { return _certificatename; }
            set { _certificatename = value; this.OnChnaged(); }
        }
        
        #endregion
    
        #region Constructor
    
        protected void LoadFromReader(IDataReader reader, int e)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateSubjectID"))) _certificatesubjectid = reader.GetInt64(reader.GetOrdinal("CertificateSubjectID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateID"))) _certificateid = reader.GetInt64(reader.GetOrdinal("CertificateID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateName"))) _certificatename = reader.GetString(reader.GetOrdinal("CertificateName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateSubjectName"))) _certificatesubjectname = reader.GetString(reader.GetOrdinal("CertificateSubjectName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Years"))) _years = reader.GetInt32(reader.GetOrdinal("Years"));
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
