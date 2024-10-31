using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using BDO.Core.Base;

namespace BDO.DataAccessObjects.ApiModels
{
    [Serializable]
    [DataContract(Name = "stp_organizationentityEntity", Namespace = "http://www.KAF.com/types")]
    public partial class stp_organizationentityEntity : BaseEntity
    {
        #region Properties
        public bool isSearch { get; set; }
        protected long? _entitykey;
        protected long? _forceid;
        protected long? _organizationkey;
        protected long? _parentkey;
        protected long? _entirytypekey;
        protected int? _entitylevel;
        protected string _seqfirstindex;
        protected string _seqfullindex;
        protected string _entitycpde;
        protected string _entityname;
        protected string _entitynameeng;
        protected string _description;
        protected bool? _isactive;
        protected bool? _isForce;
        protected bool? _isMainUnit;

        protected string _filedescription;
        protected string _filepath;
        protected string _filename;
        protected string _filetype;
        protected string _extension;
        protected Guid? _fileno;

        [DataMember]
        public long? entitykey
        {
            get { return _entitykey; }
            set { _entitykey = value; this.OnChnaged(); }
        }
        [DataMember]
        public long? forceid
        {
            get { return _forceid; }
            set { _forceid = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? organizationkey
        {
            get { return _organizationkey; }
            set { _organizationkey = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? parentkey
        {
            get { return _parentkey; }
            set { _parentkey = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? entirytypekey
        {
            get { return _entirytypekey; }
            set { _entirytypekey = value; this.OnChnaged(); }
        }

        [DataMember]
        public int? entitylevel
        {
            get { return _entitylevel; }
            set { _entitylevel = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(50)]
        public string seqfirstindex
        {
            get { return _seqfirstindex; }
            set { _seqfirstindex = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        public string seqfullindex
        {
            get { return _seqfullindex; }
            set { _seqfullindex = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        public string entitycpde
        {
            get { return _entitycpde; }
            set { _entitycpde = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        public string entityname
        {
            get { return _entityname; }
            set { _entityname = value; this.OnChnaged(); }
        }
        [DataMember]
        [MaxLength(150)]
        public string entitynameeng
        {
            get { return _entitynameeng; }
            set { _entitynameeng = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(350)]
        public string description
        {
            get { return _description; }
            set { _description = value; this.OnChnaged(); }
        }

        [DataMember]
        public bool? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }
        [DataMember]
        public bool? isForce
        {
            get { return _isForce; }
            set { _isForce = value; this.OnChnaged(); }
        }
        [DataMember]
        public bool? isMainUnit
        {
            get { return _isMainUnit; }
            set { _isMainUnit = value; this.OnChnaged(); }
        }


        [DataMember]
        [MaxLength(550)]
        public string filedescription
        {
            get { return _filedescription; }
            set { _filedescription = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        public string filepath
        {
            get { return _filepath; }
            set { _filepath = value; this.OnChnaged(); }
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
        public Guid? fileno
        {
            get { return _fileno; }
            set { _fileno = value; this.OnChnaged(); }
        }
        #endregion
    }
}
