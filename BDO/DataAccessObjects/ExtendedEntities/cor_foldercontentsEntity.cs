using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using BDO.Core.Base;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "cor_foldercontentsEntity", Namespace = "http://www.KAF.com/types")]
    public partial class cor_foldercontentsEntity : BaseEntity
    {
        #region Properties

        protected long? _foldercontentid;
        protected long? _folderid;
        protected long? _columnpkid;
        protected string _filepath;
        protected string _tablename;
        protected string _coulumnname;
        protected string _userfilename;
        protected string _filename;
        protected string _filetype;
        protected string _extension;
        protected string _filesize;
        protected string _comment;
        private string _actualfilename;
        private long? _fileid;
        private string _currentstate;

        [DataMember]
        public long? fileid { get => _fileid; set => _fileid = value; }

        [DataMember]
        public string actualfilename { get => _actualfilename; set => _actualfilename = value; }

        [DataMember]
        public long? columnpkid
        {
            get { return _columnpkid; }
            set { _columnpkid = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        public string tablename
        {
            get { return _tablename; }
            set { _tablename = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        public string coulumnname
        {
            get { return _coulumnname; }
            set { _coulumnname = value; this.OnChnaged(); }
        }


        [DataMember]
        public long? foldercontentid
        {
            get { return _foldercontentid; }
            set { _foldercontentid = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? folderid
        {
            get { return _folderid; }
            set { _folderid = value; this.OnChnaged(); }
        }

        [DataMember]
        //[MaxLength(500)]
        //[Display(Name = "filepath", ResourceType = typeof(KAF.MsgContainer._cor_foldercontents))]
        //[Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._cor_foldercontents), ErrorMessageResourceName = "filepathRequired")]
        public string filepath
        {
            get { return _filepath; }
            set { _filepath = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        //[Display(Name = "userfilename", ResourceType = typeof(KAF.MsgContainer._cor_foldercontents))]
        //[Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._cor_foldercontents), ErrorMessageResourceName = "userfilenameRequired")]
        public string userfilename
        {
            get { return _userfilename; }
            set { _userfilename = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        //[Display(Name = "filename", ResourceType = typeof(KAF.MsgContainer._cor_foldercontents))]
        //[Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._cor_foldercontents), ErrorMessageResourceName = "filenameRequired")]
        public string filename
        {
            get { return _filename; }
            set { _filename = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        //[Display(Name = "filetype", ResourceType = typeof(KAF.MsgContainer._cor_foldercontents))]
        //[Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._cor_foldercontents), ErrorMessageResourceName = "filetypeRequired")]
        public string filetype
        {
            get { return _filetype; }
            set { _filetype = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        //[Display(Name = "extension", ResourceType = typeof(KAF.MsgContainer._cor_foldercontents))]
        //[Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._cor_foldercontents), ErrorMessageResourceName = "extensionRequired")]
        public string extension
        {
            get { return _extension; }
            set { _extension = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(50)]
        //[Display(Name = "filesize", ResourceType = typeof(KAF.MsgContainer._cor_foldercontents))]
        public string filesize
        {
            get { return _filesize; }
            set { _filesize = value; this.OnChnaged(); }
        }

        [DataMember]
        //[MaxLength(500)]
        //[Display(Name = "comment", ResourceType = typeof(KAF.MsgContainer._cor_foldercontents))]
        public string comment
        {
            get { return _comment; }
            set { _comment = value; this.OnChnaged(); }
        }

        [DataMember]
        public string currentstate { get => _currentstate; set => _currentstate = value; }

        #endregion

        #region Constructor

        public cor_foldercontentsEntity() : base()
        {
        }

        public cor_foldercontentsEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        public cor_foldercontentsEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                //this.BaseSecurityParam = new SecurityCapsule();
                //if (!reader.IsDBNull(reader.GetOrdinal("FolderContentID"))) _foldercontentid = reader.GetInt64(reader.GetOrdinal("FolderContentID"));
                //if (!reader.IsDBNull(reader.GetOrdinal("FolderID"))) _folderid = reader.GetInt64(reader.GetOrdinal("FolderID"));
                //if (!reader.IsDBNull(reader.GetOrdinal("FilePath"))) _filepath = reader.GetString(reader.GetOrdinal("FilePath"));
                //if (!reader.IsDBNull(reader.GetOrdinal("UserFileName"))) _userfilename = reader.GetString(reader.GetOrdinal("UserFileName"));

                //if (!reader.IsDBNull(reader.GetOrdinal("ColumnPkId"))) _columnpkid = reader.GetInt64(reader.GetOrdinal("ColumnPkId"));
                //if (!reader.IsDBNull(reader.GetOrdinal("TableName"))) _tablename = reader.GetString(reader.GetOrdinal("TableName"));
                //if (!reader.IsDBNull(reader.GetOrdinal("CoulumnName"))) _coulumnname = reader.GetString(reader.GetOrdinal("CoulumnName"));

                //if (!reader.IsDBNull(reader.GetOrdinal("FileName"))) _filename = reader.GetString(reader.GetOrdinal("FileName"));
                //if (!reader.IsDBNull(reader.GetOrdinal("FileType"))) _filetype = reader.GetString(reader.GetOrdinal("FileType"));
                //if (!reader.IsDBNull(reader.GetOrdinal("Extension"))) _extension = reader.GetString(reader.GetOrdinal("Extension"));
                //if (!reader.IsDBNull(reader.GetOrdinal("FileSize"))) _filesize = reader.GetString(reader.GetOrdinal("FileSize"));
                //if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
                //if (!reader.IsDBNull(reader.GetOrdinal("Ex_Date1"))) _ex_date1 = reader.GetDateTime(reader.GetOrdinal("Ex_Date1"));
                //if (!reader.IsDBNull(reader.GetOrdinal("Ex_Date2"))) _ex_date2 = reader.GetDateTime(reader.GetOrdinal("Ex_Date2"));
                //if (!reader.IsDBNull(reader.GetOrdinal("Ex_Nvarchar1"))) _ex_nvarchar1 = reader.GetString(reader.GetOrdinal("Ex_Nvarchar1"));
                //if (!reader.IsDBNull(reader.GetOrdinal("Ex_Nvarchar2"))) _ex_nvarchar2 = reader.GetString(reader.GetOrdinal("Ex_Nvarchar2"));
                //if (!reader.IsDBNull(reader.GetOrdinal("Ex_Bigint1"))) _ex_bigint1 = reader.GetInt64(reader.GetOrdinal("Ex_Bigint1"));
                //if (!reader.IsDBNull(reader.GetOrdinal("Ex_Bigint2"))) _ex_bigint2 = reader.GetInt64(reader.GetOrdinal("Ex_Bigint2"));
                //if (!reader.IsDBNull(reader.GetOrdinal("Ex_Decimal1"))) _ex_decimal1 = reader.GetDecimal(reader.GetOrdinal("Ex_Decimal1"));
                //if (!reader.IsDBNull(reader.GetOrdinal("Ex_Decimal2"))) _ex_decimal2 = reader.GetDecimal(reader.GetOrdinal("Ex_Decimal2"));
                //if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                //if (!reader.IsDBNull(reader.GetOrdinal("UserOrganizationKey"))) this.BaseSecurityParam.userorganizationkey = reader.GetInt64(reader.GetOrdinal("UserOrganizationKey"));
                //if (!reader.IsDBNull(reader.GetOrdinal("UserEntityKey"))) this.BaseSecurityParam.userentitykey = reader.GetInt64(reader.GetOrdinal("UserEntityKey"));
                //if (!reader.IsDBNull(reader.GetOrdinal("CreatedBy"))) this.BaseSecurityParam.createdby = reader.GetInt64(reader.GetOrdinal("CreatedBy"));
                //if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) _createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                //if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                //if (!reader.IsDBNull(reader.GetOrdinal("UpdatedBy"))) this.BaseSecurityParam.updatedby = reader.GetInt64(reader.GetOrdinal("UpdatedBy"));
                //if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) _updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                //if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                //if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                //if (!reader.IsDBNull(reader.GetOrdinal("FormID"))) this.BaseSecurityParam.appformid = reader.GetInt64(reader.GetOrdinal("FormID"));
                //if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                //CurrentState = EntityState.Unchanged;
            }
        }


        protected void LoadFromReader(IDataReader reader, bool IsListViewShow)
        {
            if (reader != null && !reader.IsClosed)
            {
                //this.BaseSecurityParam = new SecurityCapsule();
                //if (!reader.IsDBNull(reader.GetOrdinal("FolderContentID"))) _foldercontentid = reader.GetInt64(reader.GetOrdinal("FolderContentID"));
                //if (!reader.IsDBNull(reader.GetOrdinal("FolderID"))) _folderid = reader.GetInt64(reader.GetOrdinal("FolderID"));
                //if (!reader.IsDBNull(reader.GetOrdinal("ColumnPkId"))) _columnpkid = reader.GetInt64(reader.GetOrdinal("ColumnPkId"));
                //if (!reader.IsDBNull(reader.GetOrdinal("TableName"))) _tablename = reader.GetString(reader.GetOrdinal("TableName"));
                //if (!reader.IsDBNull(reader.GetOrdinal("CoulumnName"))) _tablename = reader.GetString(reader.GetOrdinal("CoulumnName"));
                //if (!reader.IsDBNull(reader.GetOrdinal("FilePath"))) _filepath = reader.GetString(reader.GetOrdinal("FilePath"));
                //if (!reader.IsDBNull(reader.GetOrdinal("UserFileName"))) _userfilename = reader.GetString(reader.GetOrdinal("UserFileName"));
                //if (!reader.IsDBNull(reader.GetOrdinal("FileName"))) _filename = reader.GetString(reader.GetOrdinal("FileName"));
                //if (!reader.IsDBNull(reader.GetOrdinal("FileType"))) _filetype = reader.GetString(reader.GetOrdinal("FileType"));
                //if (!reader.IsDBNull(reader.GetOrdinal("Extension"))) _extension = reader.GetString(reader.GetOrdinal("Extension"));
                //if (!reader.IsDBNull(reader.GetOrdinal("FileSize"))) _filesize = reader.GetString(reader.GetOrdinal("FileSize"));
                //if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
                //if (!reader.IsDBNull(reader.GetOrdinal("Ex_Date1"))) _ex_date1 = reader.GetDateTime(reader.GetOrdinal("Ex_Date1"));
                //if (!reader.IsDBNull(reader.GetOrdinal("Ex_Date2"))) _ex_date2 = reader.GetDateTime(reader.GetOrdinal("Ex_Date2"));
                //if (!reader.IsDBNull(reader.GetOrdinal("Ex_Nvarchar1"))) _ex_nvarchar1 = reader.GetString(reader.GetOrdinal("Ex_Nvarchar1"));
                //if (!reader.IsDBNull(reader.GetOrdinal("Ex_Nvarchar2"))) _ex_nvarchar2 = reader.GetString(reader.GetOrdinal("Ex_Nvarchar2"));
                //if (!reader.IsDBNull(reader.GetOrdinal("Ex_Bigint1"))) _ex_bigint1 = reader.GetInt64(reader.GetOrdinal("Ex_Bigint1"));
                //if (!reader.IsDBNull(reader.GetOrdinal("Ex_Bigint2"))) _ex_bigint2 = reader.GetInt64(reader.GetOrdinal("Ex_Bigint2"));
                //if (!reader.IsDBNull(reader.GetOrdinal("Ex_Decimal1"))) _ex_decimal1 = reader.GetDecimal(reader.GetOrdinal("Ex_Decimal1"));
                //if (!reader.IsDBNull(reader.GetOrdinal("Ex_Decimal2"))) _ex_decimal2 = reader.GetDecimal(reader.GetOrdinal("Ex_Decimal2"));
                //if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                //if (!reader.IsDBNull(reader.GetOrdinal("UserOrganizationKey"))) this.BaseSecurityParam.userorganizationkey = reader.GetInt64(reader.GetOrdinal("UserOrganizationKey"));
                //if (!reader.IsDBNull(reader.GetOrdinal("UserEntityKey"))) this.BaseSecurityParam.userentitykey = reader.GetInt64(reader.GetOrdinal("UserEntityKey"));
                //if (!reader.IsDBNull(reader.GetOrdinal("CreatedBy"))) this.BaseSecurityParam.createdby = reader.GetInt64(reader.GetOrdinal("CreatedBy"));
                //if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) _createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                //if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                //if (!reader.IsDBNull(reader.GetOrdinal("UpdatedBy"))) this.BaseSecurityParam.updatedby = reader.GetInt64(reader.GetOrdinal("UpdatedBy"));
                //if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) _updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                //if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                //if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                //if (!reader.IsDBNull(reader.GetOrdinal("FormID"))) this.BaseSecurityParam.appformid = reader.GetInt64(reader.GetOrdinal("FormID"));
                //if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                //CurrentState = EntityState.Unchanged;
            }
        }
        #endregion
    }
}
