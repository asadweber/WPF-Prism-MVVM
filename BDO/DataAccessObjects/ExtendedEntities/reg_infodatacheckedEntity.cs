using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using KAF.BusinessDataObjects;
using BDO.DataAccessObjects.ExtendedEntities;
using CLL.LLClasses.Models;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class Reg_ApplicantDataCheckedEntity : BaseEntity
    {
        #region Properties
        protected long? _basicinfoid;
        protected long? _basicinfocount;
        protected long? _educationinfocount;
        protected long? _fatherinfocount;
        protected long? _motherinfocount;
        protected long? _wifeinfocount;
        protected long? _brotherinfocount;
        protected long? _sisterinfocount;
        protected long? _uncleinfocount;
        protected long? _auntyinfocount;
        protected long? _maternaluncleinfocount;
        protected long? _maternalauntyinfocount;
        protected long? _emmergencyinfocount;
        protected bool? _documentinfo;
        protected bool? _documentinforequired;
        protected bool? _documentinfostatus;

        [DataMember]
        public long? basicinfoid
        {
            get { return _basicinfoid; }
            set { _basicinfoid = value; this.OnChnaged(); }
        }
        [DataMember]
        public long? basicinfocount
        {
            get { return _basicinfocount; }
            set { _basicinfocount = value; this.OnChnaged(); }
        }
        [DataMember]
        public long? educationinfocount
        {
            get { return _educationinfocount; }
            set { _educationinfocount = value; this.OnChnaged(); }
        }
        [DataMember]
        public long? fatherinfocount
        {
            get { return _fatherinfocount; }
            set { _fatherinfocount = value; this.OnChnaged(); }
        }


        [DataMember]
        public long? motherinfocount
        {
            get { return _motherinfocount; }
            set { _motherinfocount = value; this.OnChnaged(); }
        }


        [DataMember]
        public long? wifeinfocount
        {
            get { return _wifeinfocount; }
            set { _wifeinfocount = value; this.OnChnaged(); }
        }
        [DataMember]
        public long? brotherinfocount
        {
            get { return _brotherinfocount; }
            set { _brotherinfocount = value; this.OnChnaged(); }
        }
        [DataMember]
        public long? sisterinfocount
        {
            get { return _sisterinfocount; }
            set { _sisterinfocount = value; this.OnChnaged(); }
        }
        [DataMember]
        public long? uncleinfocount
        {
            get { return _uncleinfocount; }
            set { _uncleinfocount = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? auntyinfocount
        {
            get { return _auntyinfocount; }
            set { _auntyinfocount = value; this.OnChnaged(); }
        }
        [DataMember]
        public long? maternaluncleinfocount
        {
            get { return _maternaluncleinfocount; }
            set { _maternaluncleinfocount = value; this.OnChnaged(); }
        }
        [DataMember]
        public long? maternalauntyinfocount
        {
            get { return _maternalauntyinfocount; }
            set { _maternalauntyinfocount = value; this.OnChnaged(); }
        }
        [DataMember]
        public long? emmergencyinfocount
        {
            get { return _emmergencyinfocount; }
            set { _emmergencyinfocount = value; this.OnChnaged(); }
        }
        [DataMember]
        public bool? documentinfo
        {
            get { return _documentinfo; }
            set { _documentinfo = value; this.OnChnaged(); }
        }
        [DataMember]
        public bool? documentinforequired
        {
            get { return _documentinforequired; }
            set { _documentinforequired = value; this.OnChnaged(); }
        }
        [DataMember]
        public bool? documentinfostatus
        {
            get { return _documentinfostatus; }
            set { _documentinfostatus = value; this.OnChnaged(); }
        }
        #endregion

        public Reg_ApplicantDataCheckedEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        public Reg_ApplicantDataCheckedEntity()
        {
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("basicinfoid"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("basicinfoid"));
                if (!reader.IsDBNull(reader.GetOrdinal("basicinfocount"))) _basicinfocount = reader.GetInt64(reader.GetOrdinal("basicinfocount"));
                if (!reader.IsDBNull(reader.GetOrdinal("educationinfocount"))) _educationinfocount = reader.GetInt64(reader.GetOrdinal("educationinfocount"));
                if (!reader.IsDBNull(reader.GetOrdinal("fatherinfocount"))) _fatherinfocount = reader.GetInt64(reader.GetOrdinal("fatherinfocount"));
                if (!reader.IsDBNull(reader.GetOrdinal("motherinfocount"))) _motherinfocount = reader.GetInt64(reader.GetOrdinal("motherinfocount"));
                if (!reader.IsDBNull(reader.GetOrdinal("wifeinfocount"))) _wifeinfocount = reader.GetInt64(reader.GetOrdinal("wifeinfocount"));
                if (!reader.IsDBNull(reader.GetOrdinal("brotherinfocount"))) _brotherinfocount = reader.GetInt64(reader.GetOrdinal("brotherinfocount"));
                if (!reader.IsDBNull(reader.GetOrdinal("sisterinfocount"))) _sisterinfocount = reader.GetInt64(reader.GetOrdinal("sisterinfocount"));
                if (!reader.IsDBNull(reader.GetOrdinal("uncleinfocount"))) _uncleinfocount = reader.GetInt64(reader.GetOrdinal("uncleinfocount"));
                if (!reader.IsDBNull(reader.GetOrdinal("auntyinfocount"))) _auntyinfocount = reader.GetInt64(reader.GetOrdinal("auntyinfocount"));
                if (!reader.IsDBNull(reader.GetOrdinal("maternaluncleinfocount"))) _maternaluncleinfocount = reader.GetInt64(reader.GetOrdinal("maternaluncleinfocount"));
                if (!reader.IsDBNull(reader.GetOrdinal("maternalauntyinfocount"))) _maternalauntyinfocount = reader.GetInt64(reader.GetOrdinal("maternalauntyinfocount"));
                if (!reader.IsDBNull(reader.GetOrdinal("emmergencyinfocount"))) _emmergencyinfocount = reader.GetInt64(reader.GetOrdinal("emmergencyinfocount"));
                if (!reader.IsDBNull(reader.GetOrdinal("documentinfo"))) _documentinfo = reader.GetBoolean(reader.GetOrdinal("documentinfo"));
                if (!reader.IsDBNull(reader.GetOrdinal("documentinforequired"))) _documentinforequired = reader.GetBoolean(reader.GetOrdinal("documentinforequired"));
                if (!reader.IsDBNull(reader.GetOrdinal("documentinfostatus"))) _documentinfostatus = reader.GetBoolean(reader.GetOrdinal("documentinfostatus"));
                CurrentState = EntityState.Unchanged;
            }
        }
    }
}
