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
    public partial class reg_basicinfoEntity : BaseEntity
    {



        #region Properties

        protected string? _basicinfoidstring;
        protected long? _registrationid;
        protected long? _applicantphaseid;
        protected long? _applicantstatusid;
        private List<reg_studentfilestorageEntity> _documentList;
        private long? batchInfoId;
        private string saveAction;
        private List<reg_studentfilestorageEntity> civilIdDocumentList;

        public long? ApplicantTableID { get; set; }

        [DataMember]
        public List<reg_studentfilestorageEntity> DocumentList { get => _documentList; set => _documentList = value; }


        [DataMember]
        public List<reg_studentfilestorageEntity> CivilIdDocumentList { get => civilIdDocumentList; set => civilIdDocumentList = value; }


        [DataMember]
        public string? basicinfoidstring
        {
            get { return _basicinfoidstring; }
            set { _basicinfoidstring = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? registrationid
        {
            get { return _registrationid; }
            set { _registrationid = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? applicantphaseid
        {
            get { return _applicantphaseid; }
            set { _applicantphaseid = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? applicantstatusid
        {
            get { return _applicantstatusid; }
            set { _applicantstatusid = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? BatchID { get => batchInfoId; set => batchInfoId = value; }

        [DataMember]
        public string SaveAction { get => saveAction; set => saveAction = value; }


        private long? _previousMaritialStatus;

		[DataMember]
		public long? previousMaritialStatus { get => _previousMaritialStatus; set => _previousMaritialStatus = value; }

		#endregion

		protected void LoadFromReader(IDataReader reader, int e)
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
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) _registrationid = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchID"))) batchInfoId = reader.GetInt64(reader.GetOrdinal("BatchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PhaseID"))) _applicantphaseid = reader.GetInt64(reader.GetOrdinal("PhaseID"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusID"))) _applicantstatusid = reader.GetInt64(reader.GetOrdinal("StatusID"));
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
    }
}
