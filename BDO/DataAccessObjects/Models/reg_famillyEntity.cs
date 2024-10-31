using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "reg_famillyEntity", Namespace = "http://www.KAF.com/types")]
    public partial class reg_famillyEntity : BaseEntity
    {
        #region Properties

        protected long? _familyid;
        protected long? _parentid;
        protected bool? _isinkuwait;
        protected long? _basicinfoid;
        protected long? _relationshipid;
        protected long? _familygenderid;
        protected long? _familyreligionid;
        protected long? _familybloodgroupid;
        protected long? _maritalstatusid;
        protected long? _parentalstatus;
        protected long? _nationalityid;
        protected long? _classid;
        protected long? _birthcountryid;
        protected long? _prevnationalityid;
        protected DateTime? _birthdate;
        protected string _civilid;
        protected string _nationalid;
        protected string _passportnumber;
        protected string _fullname;
        protected string _name1;
        protected string _name2;
        protected string _name3;
        protected string _name4;
        protected string _name5;
        protected bool? _isservedinmilitary;
        protected bool? _isserving;
        protected long? _splmilstatus;
        protected string _militaryid;
        protected long? _companyid;
        protected string _workdesignation;
        protected string _workcompany;
        protected long? _companytype;
        protected string _companyaddress;
        protected DateTime? _enrollmentdate;
        protected string _previousjob;
        protected string _previousjobdetails;
        protected long? _preaddcountryid;
        protected long? _preaddgovernid;
        protected string _preaddgovernarate;
        protected long? _preaddcityid;
        protected string _preaddcity;
        protected string _preaddstreet;
        protected string _preaddblock;
        protected string _preaddhousingno;
        protected string _preaddhousingflatno;
        protected string _prepaci;
        protected string _preaddress;
        protected string _pres_latitude;
        protected string _pres_longitude;
        protected long? _peraddcountryid;
        protected long? _peraddgovernid;
        protected long? _peraddcityid;
        protected string _peraddstreet;
        protected string _peraddblock;
        protected string _peraddhousingno;
        protected string _peraddhousingflatno;
        protected string _perpaci;
        protected string _peraddress;
        protected string _perm_latitude;
        protected string _perm_longitude;
        protected string _email;
        protected string _mobilephone1;
        protected string _mobilephone2;
        protected string _mobilephone3;
        protected string _lanphone1;
        protected string _lanphone2;
        protected string _lanphone3;
        protected bool? _ismarried;
        protected DateTime? _familymarriagedate;
        protected string _familymarriagedocno;
        protected DateTime? _familymarriagedocdate;
        protected DateTime? _deathdate;
        protected bool? _isalive;
        protected bool? _isfatherside;
        protected bool? _ismotherside;
        protected string _filepath;
        protected string _filename;
        protected string _filetype;
        protected string _extension;
        protected DateTime? _securitycardvaliddate;
        protected string _comment;
        protected string _remarks;
        protected string _updateinfo;
        protected long? _tranformactionid;


        [DataMember]
        public long? familyid
        {
            get { return _familyid; }
            set { _familyid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "parentid", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public long? parentid
        {
            get { return _parentid; }
            set { _parentid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "isinkuwait", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_familly), ErrorMessageResourceName = "isinkuwaitRequired")]
        public bool? isinkuwait
        {
            get { return _isinkuwait; }
            set { _isinkuwait = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "basicinfoid", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_familly), ErrorMessageResourceName = "basicinfoidRequired")]
        public long? basicinfoid
        {
            get { return _basicinfoid; }
            set { _basicinfoid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "relationshipid", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_familly), ErrorMessageResourceName = "relationshipidRequired")]
        public long? relationshipid
        {
            get { return _relationshipid; }
            set { _relationshipid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "familygenderid", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public long? familygenderid
        {
            get { return _familygenderid; }
            set { _familygenderid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "familyreligionid", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public long? familyreligionid
        {
            get { return _familyreligionid; }
            set { _familyreligionid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "familybloodgroupid", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public long? familybloodgroupid
        {
            get { return _familybloodgroupid; }
            set { _familybloodgroupid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "maritalstatusid", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public long? maritalstatusid
        {
            get { return _maritalstatusid; }
            set { _maritalstatusid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "parentalstatus", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public long? parentalstatus
        {
            get { return _parentalstatus; }
            set { _parentalstatus = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "nationalityid", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public long? nationalityid
        {
            get { return _nationalityid; }
            set { _nationalityid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "classid", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public long? classid
        {
            get { return _classid; }
            set { _classid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "birthcountryid", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public long? birthcountryid
        {
            get { return _birthcountryid; }
            set { _birthcountryid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "prevnationalityid", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public long? prevnationalityid
        {
            get { return _prevnationalityid; }
            set { _prevnationalityid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "birthdate", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public DateTime? birthdate
        {
            get { return _birthdate; }
            set { _birthdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(12)]
        [Display(Name = "civilid", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string civilid
        {
            get { return _civilid; }
            set { _civilid = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(50)]
        [Display(Name = "nationalid", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string nationalid
        {
            get { return _nationalid; }
            set { _nationalid = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(50)]
        [Display(Name = "passportnumber", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string passportnumber
        {
            get { return _passportnumber; }
            set { _passportnumber = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "fullname", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string fullname
        {
            get { return _fullname; }
            set { _fullname = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "name1", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string name1
        {
            get { return _name1; }
            set { _name1 = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "name2", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string name2
        {
            get { return _name2; }
            set { _name2 = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "name3", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string name3
        {
            get { return _name3; }
            set { _name3 = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "name4", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string name4
        {
            get { return _name4; }
            set { _name4 = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "name5", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string name5
        {
            get { return _name5; }
            set { _name5 = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "isservedinmilitary", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public bool? isservedinmilitary
        {
            get { return _isservedinmilitary; }
            set { _isservedinmilitary = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "isserving", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public bool? isserving
        {
            get { return _isserving; }
            set { _isserving = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "splmilstatus", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public long? splmilstatus
        {
            get { return _splmilstatus; }
            set { _splmilstatus = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(50)]
        [Display(Name = "militaryid", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string militaryid
        {
            get { return _militaryid; }
            set { _militaryid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "companyid", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public long? companyid
        {
            get { return _companyid; }
            set { _companyid = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "workdesignation", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string workdesignation
        {
            get { return _workdesignation; }
            set { _workdesignation = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "workcompany", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string workcompany
        {
            get { return _workcompany; }
            set { _workcompany = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "companytype", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public long? companytype
        {
            get { return _companytype; }
            set { _companytype = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(350)]
        [Display(Name = "companyaddress", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string companyaddress
        {
            get { return _companyaddress; }
            set { _companyaddress = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "enrollmentdate", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public DateTime? enrollmentdate
        {
            get { return _enrollmentdate; }
            set { _enrollmentdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "previousjob", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string previousjob
        {
            get { return _previousjob; }
            set { _previousjob = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(350)]
        [Display(Name = "previousjobdetails", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string previousjobdetails
        {
            get { return _previousjobdetails; }
            set { _previousjobdetails = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "preaddcountryid", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public long? preaddcountryid
        {
            get { return _preaddcountryid; }
            set { _preaddcountryid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "preaddgovernid", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public long? preaddgovernid
        {
            get { return _preaddgovernid; }
            set { _preaddgovernid = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(200)]
        [Display(Name = "preaddgovernarate", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string preaddgovernarate
        {
            get { return _preaddgovernarate; }
            set { _preaddgovernarate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "preaddcityid", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public long? preaddcityid
        {
            get { return _preaddcityid; }
            set { _preaddcityid = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "preaddcity", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string preaddcity
        {
            get { return _preaddcity; }
            set { _preaddcity = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(50)]
        [Display(Name = "preaddstreet", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string preaddstreet
        {
            get { return _preaddstreet; }
            set { _preaddstreet = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(50)]
        [Display(Name = "preaddblock", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string preaddblock
        {
            get { return _preaddblock; }
            set { _preaddblock = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(50)]
        [Display(Name = "preaddhousingno", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string preaddhousingno
        {
            get { return _preaddhousingno; }
            set { _preaddhousingno = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "preaddhousingflatno", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string preaddhousingflatno
        {
            get { return _preaddhousingflatno; }
            set { _preaddhousingflatno = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "prepaci", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string prepaci
        {
            get { return _prepaci; }
            set { _prepaci = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(350)]
        [Display(Name = "preaddress", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string preaddress
        {
            get { return _preaddress; }
            set { _preaddress = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "pres_latitude", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string pres_latitude
        {
            get { return _pres_latitude; }
            set { _pres_latitude = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "pres_longitude", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string pres_longitude
        {
            get { return _pres_longitude; }
            set { _pres_longitude = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "peraddcountryid", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public long? peraddcountryid
        {
            get { return _peraddcountryid; }
            set { _peraddcountryid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "peraddgovernid", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public long? peraddgovernid
        {
            get { return _peraddgovernid; }
            set { _peraddgovernid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "peraddcityid", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public long? peraddcityid
        {
            get { return _peraddcityid; }
            set { _peraddcityid = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(50)]
        [Display(Name = "peraddstreet", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string peraddstreet
        {
            get { return _peraddstreet; }
            set { _peraddstreet = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(50)]
        [Display(Name = "peraddblock", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string peraddblock
        {
            get { return _peraddblock; }
            set { _peraddblock = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(50)]
        [Display(Name = "peraddhousingno", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string peraddhousingno
        {
            get { return _peraddhousingno; }
            set { _peraddhousingno = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "peraddhousingflatno", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string peraddhousingflatno
        {
            get { return _peraddhousingflatno; }
            set { _peraddhousingflatno = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "perpaci", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string perpaci
        {
            get { return _perpaci; }
            set { _perpaci = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(350)]
        [Display(Name = "peraddress", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string peraddress
        {
            get { return _peraddress; }
            set { _peraddress = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "perm_latitude", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string perm_latitude
        {
            get { return _perm_latitude; }
            set { _perm_latitude = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "perm_longitude", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string perm_longitude
        {
            get { return _perm_longitude; }
            set { _perm_longitude = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "email", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string email
        {
            get { return _email; }
            set { _email = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(8)]
        [Display(Name = "mobilephone1", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string mobilephone1
        {
            get { return _mobilephone1; }
            set { _mobilephone1 = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(50)]
        [Display(Name = "mobilephone2", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string mobilephone2
        {
            get { return _mobilephone2; }
            set { _mobilephone2 = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(50)]
        [Display(Name = "mobilephone3", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string mobilephone3
        {
            get { return _mobilephone3; }
            set { _mobilephone3 = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(15)]
        [Display(Name = "lanphone1", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string lanphone1
        {
            get { return _lanphone1; }
            set { _lanphone1 = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(50)]
        [Display(Name = "lanphone2", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string lanphone2
        {
            get { return _lanphone2; }
            set { _lanphone2 = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(50)]
        [Display(Name = "lanphone3", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string lanphone3
        {
            get { return _lanphone3; }
            set { _lanphone3 = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "ismarried", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public bool? ismarried
        {
            get { return _ismarried; }
            set { _ismarried = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "familymarriagedate", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public DateTime? familymarriagedate
        {
            get { return _familymarriagedate; }
            set { _familymarriagedate = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(50)]
        [Display(Name = "familymarriagedocno", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string familymarriagedocno
        {
            get { return _familymarriagedocno; }
            set { _familymarriagedocno = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "familymarriagedocdate", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public DateTime? familymarriagedocdate
        {
            get { return _familymarriagedocdate; }
            set { _familymarriagedocdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "deathdate", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public DateTime? deathdate
        {
            get { return _deathdate; }
            set { _deathdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "isalive", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public bool? isalive
        {
            get { return _isalive; }
            set { _isalive = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "isfatherside", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public bool? isfatherside
        {
            get { return _isfatherside; }
            set { _isfatherside = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "ismotherside", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public bool? ismotherside
        {
            get { return _ismotherside; }
            set { _ismotherside = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "filepath", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string filepath
        {
            get { return _filepath; }
            set { _filepath = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "filename", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string filename
        {
            get { return _filename; }
            set { _filename = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "filetype", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string filetype
        {
            get { return _filetype; }
            set { _filetype = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "extension", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string extension
        {
            get { return _extension; }
            set { _extension = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "securitycardvaliddate", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public DateTime? securitycardvaliddate
        {
            get { return _securitycardvaliddate; }
            set { _securitycardvaliddate = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "comment", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string comment
        {
            get { return _comment; }
            set { _comment = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public long? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }


        #endregion

        #region Constructor

        public reg_famillyEntity() : base()
        {
        }

        public reg_famillyEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        public reg_famillyEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }

        public reg_famillyEntity(IDataReader reader, string ext)
        {
            this.LoadFromReader(reader, ext);
        }


        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyID"))) _familyid = reader.GetInt64(reader.GetOrdinal("FamilyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ParentID"))) _parentid = reader.GetInt64(reader.GetOrdinal("ParentID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsInKuwait"))) _isinkuwait = reader.GetBoolean(reader.GetOrdinal("IsInKuwait"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RelationshipID"))) _relationshipid = reader.GetInt64(reader.GetOrdinal("RelationshipID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyGenderID"))) _familygenderid = reader.GetInt64(reader.GetOrdinal("FamilyGenderID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyReligionID"))) _familyreligionid = reader.GetInt64(reader.GetOrdinal("FamilyReligionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyBloodGroupID"))) _familybloodgroupid = reader.GetInt64(reader.GetOrdinal("FamilyBloodGroupID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MaritalStatusID"))) _maritalstatusid = reader.GetInt64(reader.GetOrdinal("MaritalStatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ParentalStatus"))) _parentalstatus = reader.GetInt64(reader.GetOrdinal("ParentalStatus"));
                if (!reader.IsDBNull(reader.GetOrdinal("NationalityID"))) _nationalityid = reader.GetInt64(reader.GetOrdinal("NationalityID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ClassID"))) _classid = reader.GetInt64(reader.GetOrdinal("ClassID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BirthCountryID"))) _birthcountryid = reader.GetInt64(reader.GetOrdinal("BirthCountryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PrevNationalityID"))) _prevnationalityid = reader.GetInt64(reader.GetOrdinal("PrevNationalityID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BirthDate"))) _birthdate = reader.GetDateTime(reader.GetOrdinal("BirthDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _civilid = reader.GetString(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NationalID"))) _nationalid = reader.GetString(reader.GetOrdinal("NationalID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportNumber"))) _passportnumber = reader.GetString(reader.GetOrdinal("PassportNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name1"))) _name1 = reader.GetString(reader.GetOrdinal("Name1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name2"))) _name2 = reader.GetString(reader.GetOrdinal("Name2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name3"))) _name3 = reader.GetString(reader.GetOrdinal("Name3"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name4"))) _name4 = reader.GetString(reader.GetOrdinal("Name4"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name5"))) _name5 = reader.GetString(reader.GetOrdinal("Name5"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsServedInMilitary"))) _isservedinmilitary = reader.GetBoolean(reader.GetOrdinal("IsServedInMilitary"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsServing"))) _isserving = reader.GetBoolean(reader.GetOrdinal("IsServing"));
                if (!reader.IsDBNull(reader.GetOrdinal("SplMilStatus"))) _splmilstatus = reader.GetInt64(reader.GetOrdinal("SplMilStatus"));
                if (!reader.IsDBNull(reader.GetOrdinal("MilitaryID"))) _militaryid = reader.GetString(reader.GetOrdinal("MilitaryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyID"))) _companyid = reader.GetInt64(reader.GetOrdinal("CompanyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("WorkDesignation"))) _workdesignation = reader.GetString(reader.GetOrdinal("WorkDesignation"));
                if (!reader.IsDBNull(reader.GetOrdinal("WorkCompany"))) _workcompany = reader.GetString(reader.GetOrdinal("WorkCompany"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyType"))) _companytype = reader.GetInt64(reader.GetOrdinal("CompanyType"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyAddress"))) _companyaddress = reader.GetString(reader.GetOrdinal("CompanyAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("EnrollmentDate"))) _enrollmentdate = reader.GetDateTime(reader.GetOrdinal("EnrollmentDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreviousJob"))) _previousjob = reader.GetString(reader.GetOrdinal("PreviousJob"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreviousJobDetails"))) _previousjobdetails = reader.GetString(reader.GetOrdinal("PreviousJobDetails"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddCountryID"))) _preaddcountryid = reader.GetInt64(reader.GetOrdinal("PreAddCountryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddGovernID"))) _preaddgovernid = reader.GetInt64(reader.GetOrdinal("PreAddGovernID"));
                if (!reader.IsDBNull(reader.GetOrdinal("preaddgovernarate"))) _preaddgovernarate = reader.GetString(reader.GetOrdinal("preaddgovernarate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddCityID"))) _preaddcityid = reader.GetInt64(reader.GetOrdinal("PreAddCityID"));
                if (!reader.IsDBNull(reader.GetOrdinal("preaddcity"))) _preaddcity = reader.GetString(reader.GetOrdinal("preaddcity"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddStreet"))) _preaddstreet = reader.GetString(reader.GetOrdinal("PreAddStreet"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddBlock"))) _preaddblock = reader.GetString(reader.GetOrdinal("PreAddBlock"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddHousingNo"))) _preaddhousingno = reader.GetString(reader.GetOrdinal("PreAddHousingNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddHousingFlatNo"))) _preaddhousingflatno = reader.GetString(reader.GetOrdinal("PreAddHousingFlatNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("PrePaci"))) _prepaci = reader.GetString(reader.GetOrdinal("PrePaci"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddress"))) _preaddress = reader.GetString(reader.GetOrdinal("PreAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("Pres_Latitude"))) _pres_latitude = reader.GetString(reader.GetOrdinal("Pres_Latitude"));
                if (!reader.IsDBNull(reader.GetOrdinal("Pres_Longitude"))) _pres_longitude = reader.GetString(reader.GetOrdinal("Pres_Longitude"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerAddCountryID"))) _peraddcountryid = reader.GetInt64(reader.GetOrdinal("PerAddCountryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerAddGovernID"))) _peraddgovernid = reader.GetInt64(reader.GetOrdinal("PerAddGovernID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerAddCityID"))) _peraddcityid = reader.GetInt64(reader.GetOrdinal("PerAddCityID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerAddStreet"))) _peraddstreet = reader.GetString(reader.GetOrdinal("PerAddStreet"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerAddBlock"))) _peraddblock = reader.GetString(reader.GetOrdinal("PerAddBlock"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerAddHousingNo"))) _peraddhousingno = reader.GetString(reader.GetOrdinal("PerAddHousingNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerAddHousingFlatNo"))) _peraddhousingflatno = reader.GetString(reader.GetOrdinal("PerAddHousingFlatNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerPaci"))) _perpaci = reader.GetString(reader.GetOrdinal("PerPaci"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerAddress"))) _peraddress = reader.GetString(reader.GetOrdinal("PerAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("Perm_Latitude"))) _perm_latitude = reader.GetString(reader.GetOrdinal("Perm_Latitude"));
                if (!reader.IsDBNull(reader.GetOrdinal("Perm_Longitude"))) _perm_longitude = reader.GetString(reader.GetOrdinal("Perm_Longitude"));
                if (!reader.IsDBNull(reader.GetOrdinal("Email"))) _email = reader.GetString(reader.GetOrdinal("Email"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobilePhone1"))) _mobilephone1 = reader.GetString(reader.GetOrdinal("MobilePhone1"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobilePhone2"))) _mobilephone2 = reader.GetString(reader.GetOrdinal("MobilePhone2"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobilePhone3"))) _mobilephone3 = reader.GetString(reader.GetOrdinal("MobilePhone3"));
                if (!reader.IsDBNull(reader.GetOrdinal("LanPhone1"))) _lanphone1 = reader.GetString(reader.GetOrdinal("LanPhone1"));
                if (!reader.IsDBNull(reader.GetOrdinal("LanPhone2"))) _lanphone2 = reader.GetString(reader.GetOrdinal("LanPhone2"));
                if (!reader.IsDBNull(reader.GetOrdinal("LanPhone3"))) _lanphone3 = reader.GetString(reader.GetOrdinal("LanPhone3"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsMarried"))) _ismarried = reader.GetBoolean(reader.GetOrdinal("IsMarried"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyMarriageDate"))) _familymarriagedate = reader.GetDateTime(reader.GetOrdinal("FamilyMarriageDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyMarriageDocNo"))) _familymarriagedocno = reader.GetString(reader.GetOrdinal("FamilyMarriageDocNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyMarriageDocDate"))) _familymarriagedocdate = reader.GetDateTime(reader.GetOrdinal("FamilyMarriageDocDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("DeathDate"))) _deathdate = reader.GetDateTime(reader.GetOrdinal("DeathDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsAlive"))) _isalive = reader.GetBoolean(reader.GetOrdinal("IsAlive"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsFatherSide"))) _isfatherside = reader.GetBoolean(reader.GetOrdinal("IsFatherSide"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsMotherSide"))) _ismotherside = reader.GetBoolean(reader.GetOrdinal("IsMotherSide"));
                if (!reader.IsDBNull(reader.GetOrdinal("FilePath"))) _filepath = reader.GetString(reader.GetOrdinal("FilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileName"))) _filename = reader.GetString(reader.GetOrdinal("FileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileType"))) _filetype = reader.GetString(reader.GetOrdinal("FileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("Extension"))) _extension = reader.GetString(reader.GetOrdinal("Extension"));
                if (!reader.IsDBNull(reader.GetOrdinal("SecurityCardValidDate"))) _securitycardvaliddate = reader.GetDateTime(reader.GetOrdinal("SecurityCardValidDate"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyID"))) _familyid = reader.GetInt64(reader.GetOrdinal("FamilyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ParentID"))) _parentid = reader.GetInt64(reader.GetOrdinal("ParentID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsInKuwait"))) _isinkuwait = reader.GetBoolean(reader.GetOrdinal("IsInKuwait"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RelationshipID"))) _relationshipid = reader.GetInt64(reader.GetOrdinal("RelationshipID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyGenderID"))) _familygenderid = reader.GetInt64(reader.GetOrdinal("FamilyGenderID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyReligionID"))) _familyreligionid = reader.GetInt64(reader.GetOrdinal("FamilyReligionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyBloodGroupID"))) _familybloodgroupid = reader.GetInt64(reader.GetOrdinal("FamilyBloodGroupID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MaritalStatusID"))) _maritalstatusid = reader.GetInt64(reader.GetOrdinal("MaritalStatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ParentalStatus"))) _parentalstatus = reader.GetInt64(reader.GetOrdinal("ParentalStatus"));
                if (!reader.IsDBNull(reader.GetOrdinal("NationalityID"))) _nationalityid = reader.GetInt64(reader.GetOrdinal("NationalityID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ClassID"))) _classid = reader.GetInt64(reader.GetOrdinal("ClassID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BirthCountryID"))) _birthcountryid = reader.GetInt64(reader.GetOrdinal("BirthCountryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PrevNationalityID"))) _prevnationalityid = reader.GetInt64(reader.GetOrdinal("PrevNationalityID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BirthDate"))) _birthdate = reader.GetDateTime(reader.GetOrdinal("BirthDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _civilid = reader.GetString(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NationalID"))) _nationalid = reader.GetString(reader.GetOrdinal("NationalID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportNumber"))) _passportnumber = reader.GetString(reader.GetOrdinal("PassportNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name1"))) _name1 = reader.GetString(reader.GetOrdinal("Name1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name2"))) _name2 = reader.GetString(reader.GetOrdinal("Name2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name3"))) _name3 = reader.GetString(reader.GetOrdinal("Name3"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name4"))) _name4 = reader.GetString(reader.GetOrdinal("Name4"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name5"))) _name5 = reader.GetString(reader.GetOrdinal("Name5"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsServedInMilitary"))) _isservedinmilitary = reader.GetBoolean(reader.GetOrdinal("IsServedInMilitary"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsServing"))) _isserving = reader.GetBoolean(reader.GetOrdinal("IsServing"));
                if (!reader.IsDBNull(reader.GetOrdinal("SplMilStatus"))) _splmilstatus = reader.GetInt64(reader.GetOrdinal("SplMilStatus"));
                if (!reader.IsDBNull(reader.GetOrdinal("MilitaryID"))) _militaryid = reader.GetString(reader.GetOrdinal("MilitaryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyID"))) _companyid = reader.GetInt64(reader.GetOrdinal("CompanyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("WorkDesignation"))) _workdesignation = reader.GetString(reader.GetOrdinal("WorkDesignation"));
                if (!reader.IsDBNull(reader.GetOrdinal("WorkCompany"))) _workcompany = reader.GetString(reader.GetOrdinal("WorkCompany"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyType"))) _companytype = reader.GetInt64(reader.GetOrdinal("CompanyType"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyAddress"))) _companyaddress = reader.GetString(reader.GetOrdinal("CompanyAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("EnrollmentDate"))) _enrollmentdate = reader.GetDateTime(reader.GetOrdinal("EnrollmentDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreviousJob"))) _previousjob = reader.GetString(reader.GetOrdinal("PreviousJob"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreviousJobDetails"))) _previousjobdetails = reader.GetString(reader.GetOrdinal("PreviousJobDetails"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddCountryID"))) _preaddcountryid = reader.GetInt64(reader.GetOrdinal("PreAddCountryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddGovernID"))) _preaddgovernid = reader.GetInt64(reader.GetOrdinal("PreAddGovernID"));
                if (!reader.IsDBNull(reader.GetOrdinal("preaddgovernarate"))) _preaddgovernarate = reader.GetString(reader.GetOrdinal("preaddgovernarate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddCityID"))) _preaddcityid = reader.GetInt64(reader.GetOrdinal("PreAddCityID"));
                if (!reader.IsDBNull(reader.GetOrdinal("preaddcity"))) _preaddcity = reader.GetString(reader.GetOrdinal("preaddcity"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddStreet"))) _preaddstreet = reader.GetString(reader.GetOrdinal("PreAddStreet"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddBlock"))) _preaddblock = reader.GetString(reader.GetOrdinal("PreAddBlock"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddHousingNo"))) _preaddhousingno = reader.GetString(reader.GetOrdinal("PreAddHousingNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddHousingFlatNo"))) _preaddhousingflatno = reader.GetString(reader.GetOrdinal("PreAddHousingFlatNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("PrePaci"))) _prepaci = reader.GetString(reader.GetOrdinal("PrePaci"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddress"))) _preaddress = reader.GetString(reader.GetOrdinal("PreAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("Pres_Latitude"))) _pres_latitude = reader.GetString(reader.GetOrdinal("Pres_Latitude"));
                if (!reader.IsDBNull(reader.GetOrdinal("Pres_Longitude"))) _pres_longitude = reader.GetString(reader.GetOrdinal("Pres_Longitude"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerAddCountryID"))) _peraddcountryid = reader.GetInt64(reader.GetOrdinal("PerAddCountryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerAddGovernID"))) _peraddgovernid = reader.GetInt64(reader.GetOrdinal("PerAddGovernID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerAddCityID"))) _peraddcityid = reader.GetInt64(reader.GetOrdinal("PerAddCityID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerAddStreet"))) _peraddstreet = reader.GetString(reader.GetOrdinal("PerAddStreet"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerAddBlock"))) _peraddblock = reader.GetString(reader.GetOrdinal("PerAddBlock"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerAddHousingNo"))) _peraddhousingno = reader.GetString(reader.GetOrdinal("PerAddHousingNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerAddHousingFlatNo"))) _peraddhousingflatno = reader.GetString(reader.GetOrdinal("PerAddHousingFlatNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerPaci"))) _perpaci = reader.GetString(reader.GetOrdinal("PerPaci"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerAddress"))) _peraddress = reader.GetString(reader.GetOrdinal("PerAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("Perm_Latitude"))) _perm_latitude = reader.GetString(reader.GetOrdinal("Perm_Latitude"));
                if (!reader.IsDBNull(reader.GetOrdinal("Perm_Longitude"))) _perm_longitude = reader.GetString(reader.GetOrdinal("Perm_Longitude"));
                if (!reader.IsDBNull(reader.GetOrdinal("Email"))) _email = reader.GetString(reader.GetOrdinal("Email"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobilePhone1"))) _mobilephone1 = reader.GetString(reader.GetOrdinal("MobilePhone1"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobilePhone2"))) _mobilephone2 = reader.GetString(reader.GetOrdinal("MobilePhone2"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobilePhone3"))) _mobilephone3 = reader.GetString(reader.GetOrdinal("MobilePhone3"));
                if (!reader.IsDBNull(reader.GetOrdinal("LanPhone1"))) _lanphone1 = reader.GetString(reader.GetOrdinal("LanPhone1"));
                if (!reader.IsDBNull(reader.GetOrdinal("LanPhone2"))) _lanphone2 = reader.GetString(reader.GetOrdinal("LanPhone2"));
                if (!reader.IsDBNull(reader.GetOrdinal("LanPhone3"))) _lanphone3 = reader.GetString(reader.GetOrdinal("LanPhone3"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsMarried"))) _ismarried = reader.GetBoolean(reader.GetOrdinal("IsMarried"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyMarriageDate"))) _familymarriagedate = reader.GetDateTime(reader.GetOrdinal("FamilyMarriageDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyMarriageDocNo"))) _familymarriagedocno = reader.GetString(reader.GetOrdinal("FamilyMarriageDocNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyMarriageDocDate"))) _familymarriagedocdate = reader.GetDateTime(reader.GetOrdinal("FamilyMarriageDocDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("DeathDate"))) _deathdate = reader.GetDateTime(reader.GetOrdinal("DeathDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsAlive"))) _isalive = reader.GetBoolean(reader.GetOrdinal("IsAlive"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsFatherSide"))) _isfatherside = reader.GetBoolean(reader.GetOrdinal("IsFatherSide"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsMotherSide"))) _ismotherside = reader.GetBoolean(reader.GetOrdinal("IsMotherSide"));
                if (!reader.IsDBNull(reader.GetOrdinal("FilePath"))) _filepath = reader.GetString(reader.GetOrdinal("FilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileName"))) _filename = reader.GetString(reader.GetOrdinal("FileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileType"))) _filetype = reader.GetString(reader.GetOrdinal("FileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("Extension"))) _extension = reader.GetString(reader.GetOrdinal("Extension"));
                if (!reader.IsDBNull(reader.GetOrdinal("SecurityCardValidDate"))) _securitycardvaliddate = reader.GetDateTime(reader.GetOrdinal("SecurityCardValidDate"));
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
