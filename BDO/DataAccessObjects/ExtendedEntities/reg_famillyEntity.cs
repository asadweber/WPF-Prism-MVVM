using BDO.Core.Base;
using CLL.LLClasses.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class reg_famillyEntity
    {
        private long? registrationID;
        private List<reg_studentfilestorageEntity> documents;
        private string applicantCivilId1;
        private long? _candidatetypeid;
        private bool? _isfamilydataavailable;

        [DataMember]
        public List<reg_nonkuwaitystatusEntity> RegNonKuwaityStatusList { get; set; }

        [DataMember]
        public bool HasSpouse { get; set; }

        [DataMember]
        public reg_famillyEntity spouseInfo { get; set; }

        [DataMember]
        public List<reg_famillyEntity> FamilyMemeberSpouseList { get; set; }

        [DataMember]
        public List<reg_studentfilestorageEntity> Documents { get => documents; set => documents = value; }

        [DataMember]
        public long? RegistrationID { get => registrationID; set => registrationID = value; }

        [DataMember]
        public long? CandidateTypeID { get => _candidatetypeid; set => _candidatetypeid = value; }

        [DataMember]
        public string applicantCivilId { get => applicantCivilId1; set => applicantCivilId1 = value; }

        [DataMember]
        public long? fileConfigId { get; set; }

        [DataMember]
        public bool isReadOnly { get; set; }

        [DataMember]
        public long applicantTableID { get; set; }

        [DataMember]
        public reg_datacheckedEntity regDataCheckedEntity { get; set; }

        [DataMember]
        public string relationshipname { get; set; }

        [DataMember]
        public string? nationalityname { get; set; }

        [DataMember]
        public bool? IsFamilyDataAvailable { get => _isfamilydataavailable; set => _isfamilydataavailable = value; }

        [DataMember]
        [Display(Name = "spousename", ResourceType = typeof(CLL.LLClasses.Models._reg_familly))]
        public string? spousename { get; set; }

        protected void LoadFromReader(IDataReader reader, string ext)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyID"))) _familyid = reader.GetInt64(reader.GetOrdinal("FamilyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ParentID"))) _parentid = reader.GetInt64(reader.GetOrdinal("ParentID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsInKuwait"))) _isinkuwait = reader.GetBoolean(reader.GetOrdinal("IsInKuwait"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicInfoID"))) _basicinfoid = reader.GetInt64(reader.GetOrdinal("BasicInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RelationshipID"))) _relationshipid = reader.GetInt64(reader.GetOrdinal("RelationshipID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RelationshipName"))) relationshipname = reader.GetString(reader.GetOrdinal("RelationshipName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyGenderID"))) _familygenderid = reader.GetInt64(reader.GetOrdinal("FamilyGenderID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyReligionID"))) _familyreligionid = reader.GetInt64(reader.GetOrdinal("FamilyReligionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyBloodGroupID"))) _familybloodgroupid = reader.GetInt64(reader.GetOrdinal("FamilyBloodGroupID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MaritalStatusID"))) _maritalstatusid = reader.GetInt64(reader.GetOrdinal("MaritalStatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ParentalStatus"))) _parentalstatus = reader.GetInt64(reader.GetOrdinal("ParentalStatus"));
                if (!reader.IsDBNull(reader.GetOrdinal("NationalityID"))) _nationalityid = reader.GetInt64(reader.GetOrdinal("NationalityID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NationalityName"))) nationalityname = reader.GetString(reader.GetOrdinal("NationalityName"));
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
    }
}
