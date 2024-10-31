using BDO.Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class reg_studentfilestorageEntity : BaseEntity
    {
        private string _base64file;
        private string fullFtpFilePath;
        private string _fileconfigname;
        private bool _isrequired;
        private bool _isprintrequired;
        private string _remarks;
        private string _rownumber;
        private int _countrow;

        [DataMember]
        public string base64file { get => _base64file; set => _base64file = value; }

        [DataMember]
        public string FullFtpFilePath { get => fullFtpFilePath; set => fullFtpFilePath = value; }

        [DataMember]
        [Display(Name = "fileconfigname", ResourceType = typeof(CLL.LLClasses.Models._cnf_filerequired))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._cnf_filerequired), ErrorMessageResourceName = "fileconfignameRequired")]
        public string fileconfigname
        {
            get { return _fileconfigname; }
            set { _fileconfigname = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "isrequired", ResourceType = typeof(CLL.LLClasses.Models._cnf_filerequired))]
        public bool isrequired
        {
            get { return _isrequired; }
            set { _isrequired = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "isprintrequired", ResourceType = typeof(CLL.LLClasses.Models._cnf_filerequired))]
        public bool isprintrequired
        {
            get { return _isprintrequired; }
            set { _isprintrequired = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._cnf_filerequired))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }

        [DataMember]
        public string rownumber { get => _rownumber; set => _rownumber = value; }

        [DataMember]
        public int countrow { get => _countrow; set => _countrow = value; }

        [DataMember]
        public long? BatchID { get; set; }

        [DataMember]
        public string? inputfilename { get; set; }

        protected void LoadFromReader(IDataReader reader, int e)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule(); 
                if (!reader.IsDBNull(reader.GetOrdinal("BasicFileID"))) _basicfileid = reader.GetInt64(reader.GetOrdinal("BasicFileID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileConfigNameID"))) _fileconfignameid = reader.GetInt64(reader.GetOrdinal("FileConfigNameID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FolderContentId"))) _foldercontentid = reader.GetString(reader.GetOrdinal("FolderContentId"));
                if (!reader.IsDBNull(reader.GetOrdinal("PkColumnID"))) _pkcolumnid = reader.GetInt64(reader.GetOrdinal("PkColumnID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PkColumnName"))) _foldercontentid = reader.GetString(reader.GetOrdinal("PkColumnName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserFileName"))) _userfilename = reader.GetString(reader.GetOrdinal("UserFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FilePath"))) _filepath = reader.GetString(reader.GetOrdinal("FilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileName"))) _filename = reader.GetString(reader.GetOrdinal("FileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileType"))) _filetype = reader.GetString(reader.GetOrdinal("FileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileSize"))) _filetype = reader.GetString(reader.GetOrdinal("FileSize"));
                if (!reader.IsDBNull(reader.GetOrdinal("Extension"))) _extension = reader.GetString(reader.GetOrdinal("Extension"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
                //if (!reader.IsDBNull(reader.GetOrdinal("FileConfigName"))) _fileconfigname = reader.GetString(reader.GetOrdinal("FileConfigName"));
                CurrentState = EntityState.Unchanged;
            }
        }

        protected void LoadFromReader(IDataReader reader, string ext)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("BasicFileID"))) _basicfileid = reader.GetInt64(reader.GetOrdinal("BasicFileID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileConfigNameID"))) _fileconfignameid = reader.GetInt64(reader.GetOrdinal("FileConfigNameID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileConfigName"))) _fileconfigname = reader.GetString(reader.GetOrdinal("FileConfigName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FolderContentId"))) _foldercontentid = reader.GetString(reader.GetOrdinal("FolderContentId"));
                if (!reader.IsDBNull(reader.GetOrdinal("PkColumnID"))) _pkcolumnid = reader.GetInt64(reader.GetOrdinal("PkColumnID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PkColumnName"))) _foldercontentid = reader.GetString(reader.GetOrdinal("PkColumnName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserFileName"))) _userfilename = reader.GetString(reader.GetOrdinal("UserFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FilePath"))) _filepath = reader.GetString(reader.GetOrdinal("FilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileName"))) _filename = reader.GetString(reader.GetOrdinal("FileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileType"))) _filetype = reader.GetString(reader.GetOrdinal("FileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileSize"))) _filetype = reader.GetString(reader.GetOrdinal("FileSize"));
                if (!reader.IsDBNull(reader.GetOrdinal("Extension"))) _extension = reader.GetString(reader.GetOrdinal("Extension"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
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
    }
}
