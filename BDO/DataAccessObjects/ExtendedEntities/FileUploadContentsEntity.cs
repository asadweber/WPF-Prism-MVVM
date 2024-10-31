using BDO.Core.Base;
using KAF.BusinessDataObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.DataAccessObjects.ExtendedEntities
{
    [Serializable]
    [DataContract(Name = "FileUploadContentsEntity", Namespace = "http://www.KAF.com/types")]
    public partial class FileUploadContentsEntity : BaseEntity
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
        public string filepath
        {
            get { return _filepath; }
            set { _filepath = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        public string userfilename
        {
            get { return _userfilename; }
            set { _userfilename = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        public string filename
        {
            get { return _filename; }
            set { _filename = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        public string filetype
        {
            get { return _filetype; }
            set { _filetype = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        public string extension
        {
            get { return _extension; }
            set { _extension = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(50)]
        public string filesize
        {
            get { return _filesize; }
            set { _filesize = value; this.OnChnaged(); }
        }

        [DataMember]
        //[MaxLength(500)]
        public string comment
        {
            get { return _comment; }
            set { _comment = value; this.OnChnaged(); }
        }


        #endregion

        #region Constructor

        public FileUploadContentsEntity() : base()
        {
        }

        
        #endregion
    }
}
