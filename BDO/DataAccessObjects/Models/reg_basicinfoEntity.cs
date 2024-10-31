using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "reg_basicinfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class reg_basicinfoEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _basicinfoid;
        protected string _civilid;
        protected string _passportno;
        protected string _fullname;
        protected string _name1;
        protected string _name2;
        protected string _name3;
        protected string _name4;
        protected string _name5;
        protected DateTime ? _dob;
        protected long ? _birthcountryid;
        protected long ? _gender;
        protected string _mob1;
        protected string _mob2;
        protected string _mob3;
        protected string _telephone1;
        protected string _telephone2;
        protected string _telephone3;
        protected string _email;
        protected long ? _preaddcountryid;
        protected long ? _preaddgovernid;
        protected string _preaddgovernarate;
        protected long ? _preaddcityid;
        protected string _preaddcity;
        protected string _preaddstreet;
        protected string _preaddblock;
        protected string _preaddhousingno;
        protected string _preaddhousingflatno;
        protected string _preaddress;
        protected string _prepaci;
        protected string _pres_latitude;
        protected string _pres_longitude;
        protected long ? _peraddcountryid;
        protected long ? _peraddgovernid;
        protected long ? _peraddcityid;
        protected string _peraddstreet;
        protected string _peraddblock;
        protected string _peraddhousingno;
        protected string _peraddhousingflatno;
        protected string _perpaci;
        protected string _peraddress;
        protected string _perm_latitude;
        protected string _perm_longitude;
        protected long ? _maritalstatus;
        protected string _nationalid;
        protected DateTime ? _nationaldate;
        protected long ? _countrynationalityid;
        protected long ? _countryclassid;
        protected long ? _residenttypeid;
        protected long ? _bloodgroupid;
        protected long ? _relogionid;
        protected string _filepath;
        protected string _filename;
        protected string _filetype;
        protected string _extension;
        protected string _comment;
        protected Guid ? _userid;
        protected string _remarks;
        protected string _updateinfo;
        protected long ? _tranformactionid;
                
        
        [DataMember]
        public long ? basicinfoid
        {
            get { return _basicinfoid; }
            set { _basicinfoid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(12)]
        [Display(Name = "civilid", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo), ErrorMessageResourceName = "civilidRequired")]
        public string civilid
        {
            get { return _civilid; }
            set { _civilid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "passportno", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string passportno
        {
            get { return _passportno; }
            set { _passportno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "fullname", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo), ErrorMessageResourceName = "fullnameRequired")]
        public string fullname
        {
            get { return _fullname; }
            set { _fullname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "name1", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo), ErrorMessageResourceName = "name1Required")]
        public string name1
        {
            get { return _name1; }
            set { _name1 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "name2", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo), ErrorMessageResourceName = "name2Required")]
        public string name2
        {
            get { return _name2; }
            set { _name2 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "name3", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string name3
        {
            get { return _name3; }
            set { _name3 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "name4", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string name4
        {
            get { return _name4; }
            set { _name4 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "name5", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string name5
        {
            get { return _name5; }
            set { _name5 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "dob", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo), ErrorMessageResourceName = "dobRequired")]
        public DateTime ? dob
        {
            get { return _dob; }
            set { _dob = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "birthcountryid", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public long ? birthcountryid
        {
            get { return _birthcountryid; }
            set { _birthcountryid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "gender", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public long ? gender
        {
            get { return _gender; }
            set { _gender = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(8)]
        [Display(Name = "mob1", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo), ErrorMessageResourceName = "mob1Required")]
        public string mob1
        {
            get { return _mob1; }
            set { _mob1 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(8)]
        [Display(Name = "mob2", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string mob2
        {
            get { return _mob2; }
            set { _mob2 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "mob3", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string mob3
        {
            get { return _mob3; }
            set { _mob3 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "telephone1", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string telephone1
        {
            get { return _telephone1; }
            set { _telephone1 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "telephone2", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string telephone2
        {
            get { return _telephone2; }
            set { _telephone2 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "telephone3", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string telephone3
        {
            get { return _telephone3; }
            set { _telephone3 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "email", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string email
        {
            get { return _email; }
            set { _email = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "preaddcountryid", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public long ? preaddcountryid
        {
            get { return _preaddcountryid; }
            set { _preaddcountryid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "preaddgovernid", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public long ? preaddgovernid
        {
            get { return _preaddgovernid; }
            set { _preaddgovernid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(255)]
        [Display(Name = "preaddgovernarate", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string preaddgovernarate
        {
            get { return _preaddgovernarate; }
            set { _preaddgovernarate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "preaddcityid", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public long ? preaddcityid
        {
            get { return _preaddcityid; }
            set { _preaddcityid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(255)]
        [Display(Name = "preaddcity", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string preaddcity
        {
            get { return _preaddcity; }
            set { _preaddcity = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "preaddstreet", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string preaddstreet
        {
            get { return _preaddstreet; }
            set { _preaddstreet = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "preaddblock", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string preaddblock
        {
            get { return _preaddblock; }
            set { _preaddblock = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "preaddhousingno", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string preaddhousingno
        {
            get { return _preaddhousingno; }
            set { _preaddhousingno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "preaddhousingflatno", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string preaddhousingflatno
        {
            get { return _preaddhousingflatno; }
            set { _preaddhousingflatno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(350)]
        [Display(Name = "preaddress", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string preaddress
        {
            get { return _preaddress; }
            set { _preaddress = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "prepaci", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string prepaci
        {
            get { return _prepaci; }
            set { _prepaci = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "pres_latitude", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string pres_latitude
        {
            get { return _pres_latitude; }
            set { _pres_latitude = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "pres_longitude", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string pres_longitude
        {
            get { return _pres_longitude; }
            set { _pres_longitude = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "peraddcountryid", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public long ? peraddcountryid
        {
            get { return _peraddcountryid; }
            set { _peraddcountryid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "peraddgovernid", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public long ? peraddgovernid
        {
            get { return _peraddgovernid; }
            set { _peraddgovernid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "peraddcityid", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public long ? peraddcityid
        {
            get { return _peraddcityid; }
            set { _peraddcityid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "peraddstreet", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string peraddstreet
        {
            get { return _peraddstreet; }
            set { _peraddstreet = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "peraddblock", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string peraddblock
        {
            get { return _peraddblock; }
            set { _peraddblock = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "peraddhousingno", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string peraddhousingno
        {
            get { return _peraddhousingno; }
            set { _peraddhousingno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "peraddhousingflatno", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string peraddhousingflatno
        {
            get { return _peraddhousingflatno; }
            set { _peraddhousingflatno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "perpaci", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string perpaci
        {
            get { return _perpaci; }
            set { _perpaci = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(350)]
        [Display(Name = "peraddress", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string peraddress
        {
            get { return _peraddress; }
            set { _peraddress = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(350)]
        [Display(Name = "perm_latitude", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string perm_latitude
        {
            get { return _perm_latitude; }
            set { _perm_latitude = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(350)]
        [Display(Name = "perm_longitude", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string perm_longitude
        {
            get { return _perm_longitude; }
            set { _perm_longitude = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "maritalstatus", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo), ErrorMessageResourceName = "maritalstatusRequired")]
        public long ? maritalstatus
        {
            get { return _maritalstatus; }
            set { _maritalstatus = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "nationalid", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string nationalid
        {
            get { return _nationalid; }
            set { _nationalid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "nationaldate", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public DateTime ? nationaldate
        {
            get { return _nationaldate; }
            set { _nationaldate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "countrynationalityid", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public long ? countrynationalityid
        {
            get { return _countrynationalityid; }
            set { _countrynationalityid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "countryclassid", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public long ? countryclassid
        {
            get { return _countryclassid; }
            set { _countryclassid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "residenttypeid", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public long ? residenttypeid
        {
            get { return _residenttypeid; }
            set { _residenttypeid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "bloodgroupid", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public long ? bloodgroupid
        {
            get { return _bloodgroupid; }
            set { _bloodgroupid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "relogionid", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public long ? relogionid
        {
            get { return _relogionid; }
            set { _relogionid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "filepath", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string filepath
        {
            get { return _filepath; }
            set { _filepath = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "filename", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string filename
        {
            get { return _filename; }
            set { _filename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "filetype", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string filetype
        {
            get { return _filetype; }
            set { _filetype = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "extension", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string extension
        {
            get { return _extension; }
            set { _extension = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "comment", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string comment
        {
            get { return _comment; }
            set { _comment = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "userid", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public Guid ? userid
        {
            get { return _userid; }
            set { _userid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._reg_basicinfo))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public reg_basicinfoEntity():base()
        {
        }
        
        public reg_basicinfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public reg_basicinfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }

        public reg_basicinfoEntity(IDataReader reader, int e)
        {
            this.LoadFromReader(reader, e);
        }



        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _civilid = reader.GetString(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportNo"))) _passportno = reader.GetString(reader.GetOrdinal("PassportNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name1"))) _name1 = reader.GetString(reader.GetOrdinal("Name1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name2"))) _name2 = reader.GetString(reader.GetOrdinal("Name2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name3"))) _name3 = reader.GetString(reader.GetOrdinal("Name3"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name4"))) _name4 = reader.GetString(reader.GetOrdinal("Name4"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name5"))) _name5 = reader.GetString(reader.GetOrdinal("Name5"));
                if (!reader.IsDBNull(reader.GetOrdinal("DOB"))) _dob = reader.GetDateTime(reader.GetOrdinal("DOB"));
                if (!reader.IsDBNull(reader.GetOrdinal("BirthCountryID"))) _birthcountryid = reader.GetInt64(reader.GetOrdinal("BirthCountryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Gender"))) _gender = reader.GetInt64(reader.GetOrdinal("Gender"));
                if (!reader.IsDBNull(reader.GetOrdinal("Mob1"))) _mob1 = reader.GetString(reader.GetOrdinal("Mob1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Mob2"))) _mob2 = reader.GetString(reader.GetOrdinal("Mob2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Mob3"))) _mob3 = reader.GetString(reader.GetOrdinal("Mob3"));
                if (!reader.IsDBNull(reader.GetOrdinal("Telephone1"))) _telephone1 = reader.GetString(reader.GetOrdinal("Telephone1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Telephone2"))) _telephone2 = reader.GetString(reader.GetOrdinal("Telephone2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Telephone3"))) _telephone3 = reader.GetString(reader.GetOrdinal("Telephone3"));
                if (!reader.IsDBNull(reader.GetOrdinal("Email"))) _email = reader.GetString(reader.GetOrdinal("Email"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddCountryID"))) _preaddcountryid = reader.GetInt64(reader.GetOrdinal("PreAddCountryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddGovernID"))) _preaddgovernid = reader.GetInt64(reader.GetOrdinal("PreAddGovernID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddGovernarate"))) _preaddgovernarate = reader.GetString(reader.GetOrdinal("PreAddGovernarate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddCityID"))) _preaddcityid = reader.GetInt64(reader.GetOrdinal("PreAddCityID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddCity"))) _preaddcity = reader.GetString(reader.GetOrdinal("PreAddCity"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddStreet"))) _preaddstreet = reader.GetString(reader.GetOrdinal("PreAddStreet"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddBlock"))) _preaddblock = reader.GetString(reader.GetOrdinal("PreAddBlock"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddHousingNo"))) _preaddhousingno = reader.GetString(reader.GetOrdinal("PreAddHousingNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddHousingFlatNo"))) _preaddhousingflatno = reader.GetString(reader.GetOrdinal("PreAddHousingFlatNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddress"))) _preaddress = reader.GetString(reader.GetOrdinal("PreAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("PrePaci"))) _prepaci = reader.GetString(reader.GetOrdinal("PrePaci"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("MaritalStatus"))) _maritalstatus = reader.GetInt64(reader.GetOrdinal("MaritalStatus"));
                if (!reader.IsDBNull(reader.GetOrdinal("NationalID"))) _nationalid = reader.GetString(reader.GetOrdinal("NationalID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NationalDate"))) _nationaldate = reader.GetDateTime(reader.GetOrdinal("NationalDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("CountryNationalityID"))) _countrynationalityid = reader.GetInt64(reader.GetOrdinal("CountryNationalityID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CountryClassID"))) _countryclassid = reader.GetInt64(reader.GetOrdinal("CountryClassID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ResidentTypeID"))) _residenttypeid = reader.GetInt64(reader.GetOrdinal("ResidentTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BloodGroupID"))) _bloodgroupid = reader.GetInt64(reader.GetOrdinal("BloodGroupID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RelogionID"))) _relogionid = reader.GetInt64(reader.GetOrdinal("RelogionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FilePath"))) _filepath = reader.GetString(reader.GetOrdinal("FilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileName"))) _filename = reader.GetString(reader.GetOrdinal("FileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileType"))) _filetype = reader.GetString(reader.GetOrdinal("FileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("Extension"))) _extension = reader.GetString(reader.GetOrdinal("Extension"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserID"))) _userid = reader.GetGuid(reader.GetOrdinal("UserID"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _civilid = reader.GetString(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportNo"))) _passportno = reader.GetString(reader.GetOrdinal("PassportNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name1"))) _name1 = reader.GetString(reader.GetOrdinal("Name1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name2"))) _name2 = reader.GetString(reader.GetOrdinal("Name2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name3"))) _name3 = reader.GetString(reader.GetOrdinal("Name3"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name4"))) _name4 = reader.GetString(reader.GetOrdinal("Name4"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name5"))) _name5 = reader.GetString(reader.GetOrdinal("Name5"));
                if (!reader.IsDBNull(reader.GetOrdinal("DOB"))) _dob = reader.GetDateTime(reader.GetOrdinal("DOB"));
                if (!reader.IsDBNull(reader.GetOrdinal("BirthCountryID"))) _birthcountryid = reader.GetInt64(reader.GetOrdinal("BirthCountryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Gender"))) _gender = reader.GetInt64(reader.GetOrdinal("Gender"));
                if (!reader.IsDBNull(reader.GetOrdinal("Mob1"))) _mob1 = reader.GetString(reader.GetOrdinal("Mob1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Mob2"))) _mob2 = reader.GetString(reader.GetOrdinal("Mob2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Mob3"))) _mob3 = reader.GetString(reader.GetOrdinal("Mob3"));
                if (!reader.IsDBNull(reader.GetOrdinal("Telephone1"))) _telephone1 = reader.GetString(reader.GetOrdinal("Telephone1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Telephone2"))) _telephone2 = reader.GetString(reader.GetOrdinal("Telephone2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Telephone3"))) _telephone3 = reader.GetString(reader.GetOrdinal("Telephone3"));
                if (!reader.IsDBNull(reader.GetOrdinal("Email"))) _email = reader.GetString(reader.GetOrdinal("Email"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddCountryID"))) _preaddcountryid = reader.GetInt64(reader.GetOrdinal("PreAddCountryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddGovernID"))) _preaddgovernid = reader.GetInt64(reader.GetOrdinal("PreAddGovernID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddGovernarate"))) _preaddgovernarate = reader.GetString(reader.GetOrdinal("PreAddGovernarate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddCityID"))) _preaddcityid = reader.GetInt64(reader.GetOrdinal("PreAddCityID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddCity"))) _preaddcity = reader.GetString(reader.GetOrdinal("PreAddCity"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddStreet"))) _preaddstreet = reader.GetString(reader.GetOrdinal("PreAddStreet"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddBlock"))) _preaddblock = reader.GetString(reader.GetOrdinal("PreAddBlock"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddHousingNo"))) _preaddhousingno = reader.GetString(reader.GetOrdinal("PreAddHousingNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddHousingFlatNo"))) _preaddhousingflatno = reader.GetString(reader.GetOrdinal("PreAddHousingFlatNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreAddress"))) _preaddress = reader.GetString(reader.GetOrdinal("PreAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("PrePaci"))) _prepaci = reader.GetString(reader.GetOrdinal("PrePaci"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("MaritalStatus"))) _maritalstatus = reader.GetInt64(reader.GetOrdinal("MaritalStatus"));
                if (!reader.IsDBNull(reader.GetOrdinal("NationalID"))) _nationalid = reader.GetString(reader.GetOrdinal("NationalID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NationalDate"))) _nationaldate = reader.GetDateTime(reader.GetOrdinal("NationalDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("CountryNationalityID"))) _countrynationalityid = reader.GetInt64(reader.GetOrdinal("CountryNationalityID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CountryClassID"))) _countryclassid = reader.GetInt64(reader.GetOrdinal("CountryClassID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ResidentTypeID"))) _residenttypeid = reader.GetInt64(reader.GetOrdinal("ResidentTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BloodGroupID"))) _bloodgroupid = reader.GetInt64(reader.GetOrdinal("BloodGroupID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RelogionID"))) _relogionid = reader.GetInt64(reader.GetOrdinal("RelogionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FilePath"))) _filepath = reader.GetString(reader.GetOrdinal("FilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileName"))) _filename = reader.GetString(reader.GetOrdinal("FileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileType"))) _filetype = reader.GetString(reader.GetOrdinal("FileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("Extension"))) _extension = reader.GetString(reader.GetOrdinal("Extension"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserID"))) _userid = reader.GetGuid(reader.GetOrdinal("UserID"));
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
