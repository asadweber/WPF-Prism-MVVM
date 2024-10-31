using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDO.Core.Base
{
    public enum ApplicationUserRoleEnum
    {
        User = 3
    }
    public static class GlobalConstant
    {
        public const string SpecialRegistrationId = "SpecialRegistrationId";

        public const string SaveAction_PreRegistration = "PreRegistration";
        public const string SaveAction_PostRegistration = "PostRegistration";
        public const string SaveAction_RegBasicInfo = "RegBasicInfo";

        public const string ApplicantCivilID = "ApplicantCivilID";

        public const string FullProfileData = "FullProfileData";
        public const string BasicInfoId = "BasicInfoId";
        public const string EducationId = "EducationId";
        public const string FamilyID = "FamilyID";
        public const string RegistrationID = "RegistrationID";
        public const string FatherFamilyID = "FatherFamilyID";
        public const string FatherWifeFamilyID = "FatherWifeFamilyID";

        public const string MotherFamilyID = "MotherFamilyID";
        public const string MotherHusbandFamilyID = "MotherHusbandFamilyID";

        public const string BrotherFamilyID = "BrotherFamilyID";
        public const string BrotherWifeFamilyID = "BrotherWifeFamilyID";
        public const string SisterFamilyID = "SisterFamilyID";

        public const string SisterHusbandFamilyID = "SisterHusbandFamilyID";

        public const string PaternalUncleFamilyID = "PaternalUncleFamilyID";
        public const string PaternalUncleWifeFamilyID = "PaternalUncleWifeFamilyID";

        public const string PaternalAuntyFamilyID = "PaternalAuntyFamilyID";
        public const string PaternalAuntyHusbandFamilyID = "PaternalAuntyHusbandFamilyID";

        public const string MaternalUncleFamilyID = "MaternalUncleFamilyID";
        public const string MaternalUncleWifeFamilyID = "MaternalUncleWifeFamilyID";


        public const string MaternalAuntyFamilyID = "MaternalAuntyFamilyID";
        public const string MaternalAuntyHusbandFamilyID = "MaternalAuntyHusbandFamilyID";

        public const string ProfileSpouseFamilyID = "ProfileSpouseFamilyID";

        public const string CandidateTypeID = "CandidateTypeID";
        public const string TrainingJoinID = "TrainingJoinID";
    }

    public enum FileConfig
    {
        PersonalDocument = 1,
        EducationalCertificate = 2,
        FatherDocument = 3,
        MotherDocument = 4,
        WifeDocument = 5,
        PersonalCivilid = 6,
        SyExam = 99990,
        UnitClearance = 99991,
        MedExam = 99992,
        PsychoExam = 99993,
        FinalExam = 99994,
        TrainingJoin = 99995
    }

    public static class FileConfigName
    {
        public const string OtherFileType = "Other";
    }


    public enum CandidateTypeEnum
    {
        Kuwaiti = 1,
        Son_of_Kuwaiti_mother = 2,
        Approved_1965 = 3,
        Sone_of_Soldier = 4,
        Other_Nationality = 5,

    }

    public enum CountryEnum
    {
        Kuwaiti = 1,
        Illegal_Resident = 9999,

    }

    public enum MilitaryTypeEnum
    {
        WarrantOfficer = 1, Soldier = 2, Professionals = 3
    }
    public enum MaritalStatusEnum
    {
        Unmarried = 1,
        Married = 2,
        Widowed = 3,
        Divorced = 4,
    }
    public enum GenderEnum
    {
        Male = 1,
        Female = 2,

    }
    public enum RelationshipEnum
    {
        Father = 1,
        Mother = 2,
        Brother = 3,
        Sister = 4,
        Wife = 5,
        PaternalBrother = 6,
        MaternalBrother = 7,
        Spouse = 8,
        PaternalSister = 9,
        MaternalSister = 10,
        PaternalUncle = 11,
        PaternalAunty = 12,
        MaternalUncle = 13,
        MaternalAunty = 14,

    }

    public enum ApplicantStatusEnum
    {
        New = 1,
        Passed = 2,
        Failed = 3,
        Hold = 4,
        Rollback = 5,
        Completed = 6,
        Absent = 7,
        Incomplete = 8,
        Agree = 9,
        NotAgree = 10,
        Fit = 11,
        Unfit = 12,
        ReTest = 13
    }
    public enum ApplicantPhasesEnum
    {
        Registered = 1,
        FinalSubmitted = 2,
        Audit = 3,
        SecurityCheck = 4,
        UnitCheck = 5,
        MedicalCheck = 6,
        FinalExam = 7,
        TrainingJoined = 8
    }
    public enum RollbackByEnum
    {
        User = 1,
        Admin = 2,
    }

    public enum ApplicantTableEnum
    {
        Reg_BasicInfo = 1,
        Reg_EducationInfo = 2,
        Reg_Familly_Father = 3,
        Reg_Familly_Mother = 5,
        Reg_Familly_Brother = 6,
        Reg_Familly_Sister = 7,
        Reg_Familly_Wife = 8,
        Reg_Familly_Uncle = 11,
        Reg_Familly_Aunty = 13,
        Reg_Familly_MoUncle = 14,
        Reg_Familly_MoAunty = 15,
        Reg_ImergencyContactInfo = 9,
        Reg_StudentFileStorage = 16
    }

    public enum AuditResultEnum
    {
        Waiting = 0,
        Passed = 1,
        Failed = 2,
        Rollback = 3
    }

    public enum SyClearanceResultEnum
    {
        Forward = 1,
        Rollback = 2
    }

    public enum ReTestResultTypeEnum
    {
        Security = 1,
        Medical = 2,
        Psychology = 3
    }

    public enum SyExamResultEnum
    {
        Waiting = 0,
        Agree = 1,
        NotAgree = 2,
        Hold = 3,
        Rollback = 4,
        ReTest = 5
    }

    public enum VolunteerUnitClearanceResultEnum
    {
        Forward = 1,
        Rollback = 2
    }

    public enum UnitClearanceResultEnum
    {
        Waiting = 0,
        Passed = 1,
        Failed = 2,
        Rollback = 3
    }

    public enum VolunteerMedClearanceResultEnum
    {
        Forward = 1,
        Rollback = 2
    }

    public enum MedExamResultEnum
    {
        Waiting = 0,
        Fit = 1,
        Unfit = 2,
        Hold = 3,
        Absent = 4,
        Incomplete = 5,
        Rollback = 6
    }

    public enum PsychoExamResultEnum
    {
        Waiting = 0,
        Fit = 1,
        Unfit = 2,
        Hold = 3,
        Absent = 4,
        Incomplete = 5
    }

    public enum FinalExamResultEnum
    {
        Waiting = 0,
        Passed = 1,
        Failed = 2
    }

    public enum NationalityListType
    {
        IncludeAll = 1,
        IncludeOnlyKuwait = 2,
        IncludeExceptKuwait = 3,
        IncludeExceptKuwaitIllegalResident = 4
    }

    public enum MedExamNotificationType
    {
        Medical = 1,
        Psychology = 2
    }

}