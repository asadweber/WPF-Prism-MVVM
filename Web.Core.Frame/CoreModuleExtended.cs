using Autofac;
using Web.Core.Frame.Interfaces.UseCases;
using Web.Core.Frame.Interfaces.UseCases.Configuration;
using Web.Core.Frame.Interfaces.UseCases.Registration;
using Web.Core.Frame.Interfaces.UseCases.Transaction;
using Web.Core.Frame.UseCases;
using Web.Core.Frame.UseCases.Configuration;
using Web.Core.Frame.UseCases.Registration;
using Web.Core.Frame.UseCases.Transaction;

namespace Web.Core.Frame
{
    public partial class CoreModuleExtended : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<HomeUseCase>().As<IHomeUseCase>().InstancePerLifetimeScope();

            //Owin User : Start
            builder.RegisterType<Owin_FormActionUseCase>().As<IOwin_FormActionUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Owin_LastWorkingPageUseCase>().As<IOwin_LastWorkingPageUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Owin_RoleUseCase>().As<IOwin_RoleUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Owin_RolePermissionUseCase>().As<IOwin_RolePermissionUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Owin_UserUseCase>().As<IOwin_UserUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Owin_UserClaimsUseCase>().As<IOwin_UserClaimsUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Owin_UserLoginTrailUseCase>().As<IOwin_UserLoginTrailUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Owin_UserPasswordResetInfoUseCase>().As<IOwin_UserPasswordResetInfoUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Owin_UserPrefferencesSettingsUseCase>().As<IOwin_UserPrefferencesSettingsUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Owin_UserRoleUseCase>().As<IOwin_UserRoleUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Owin_UserRolesUseCase>().As<IOwin_UserRolesUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Owin_UserStatusChangeHistoryUseCase>().As<IOwin_UserStatusChangeHistoryUseCase>().InstancePerLifetimeScope();

            builder.RegisterType<Auth_UseCase>().As<IAuth_UseCase>().InstancePerLifetimeScope();

            //Configuration : Start
            builder.RegisterType<Cnf_FileConfigNameUseCase>().As<ICnf_FileConfigNameUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Cnf_FileRequiredUseCase>().As<ICnf_FileRequiredUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Cnf_NotificationConfigUseCase>().As<ICnf_NotificationConfigUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Cnf_NotificationConfigDetlUseCase>().As<ICnf_NotificationConfigDetlUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Cnf_NotificationTempletUseCase>().As<ICnf_NotificationTempletUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Cnf_SMSActivationCodeUseCase>().As<ICnf_SMSActivationCodeUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Cnf_SMSActivationTransectionUseCase>().As<ICnf_SMSActivationTransectionUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Cnf_StudentMenuSkipUseCase>().As<ICnf_StudentMenuSkipUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Cnf_StudentMenuSkipDetailUseCase>().As<ICnf_StudentMenuSkipDetailUseCase>().InstancePerLifetimeScope();

            //General : Start
            builder.RegisterType<Gen_ResidentTypeUseCase>().As<IGen_ResidentTypeUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_BatchUseCase>().As<IGen_BatchUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_BatchCandidateCertificateUseCase>().As<IGen_BatchCandidateCertificateUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_BatchCandidateReqFileUseCase>().As<IGen_BatchCandidateReqFileUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_BatchCandidateTypeMapUseCase>().As<IGen_BatchCandidateTypeMapUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_BatchCandProfessionUseCase>().As<IGen_BatchCandProfessionUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_BatchUnitListUseCase>().As<IGen_BatchUnitListUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_BloodGroupUseCase>().As<IGen_BloodGroupUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_CandidateTypeUseCase>().As<IGen_CandidateTypeUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_CertificateUseCase>().As<IGen_CertificateUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_CertificateLevelUseCase>().As<IGen_CertificateLevelUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_CertificateSubjectsUseCase>().As<IGen_CertificateSubjectsUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_CertificateTypeUseCase>().As<IGen_CertificateTypeUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_CivilWorkPlacesUseCase>().As<IGen_CivilWorkPlacesUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_CompaniesUseCase>().As<IGen_CompaniesUseCase>().InstancePerLifetimeScope();
			builder.RegisterType<Gen_EContactListUseCase>().As<IGen_EContactListUseCase>().InstancePerLifetimeScope();
			builder.RegisterType<Gen_CompanyTypeUseCase>().As<IGen_CompanyTypeUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_CountryUseCase>().As<IGen_CountryUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_CountryCityUseCase>().As<IGen_CountryCityUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_CountryClassUseCase>().As<IGen_CountryClassUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_EducationGradeUseCase>().As<IGen_EducationGradeUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_EducationMajorUseCase>().As<IGen_EducationMajorUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_EducationShiftUseCase>().As<IGen_EducationShiftUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_FaqUseCase>().As<IGen_FaqUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_FAQCategoryUseCase>().As<IGen_FAQCategoryUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_GenderUseCase>().As<IGen_GenderUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_GeneralHealthUseCase>().As<IGen_GeneralHealthUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_GeneralLookUseCase>().As<IGen_GeneralLookUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_ImageGallaryUseCase>().As<IGen_ImageGallaryUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_ImageGallaryCategoryUseCase>().As<IGen_ImageGallaryCategoryUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_InstituteInfoUseCase>().As<IGen_InstituteInfoUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_LanguagesUseCase>().As<IGen_LanguagesUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_MaritalStatusUseCase>().As<IGen_MaritalStatusUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_NewsCategoryUseCase>().As<IGen_NewsCategoryUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_NewsUseCase>().As<IGen_NewsUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_NewsGalleryUseCase>().As<IGen_NewsGalleryUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_NonKuwaityStatusUseCase>().As<IGen_NonKuwaityStatusUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_PhasesUseCase>().As<IGen_PhasesUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_ProfessionUseCase>().As<IGen_ProfessionUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_ProfessionGroupUseCase>().As<IGen_ProfessionGroupUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_RankUseCase>().As<IGen_RankUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_RelationshipUseCase>().As<IGen_RelationshipUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_ReligionUseCase>().As<IGen_ReligionUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_ServiceInfoUseCase>().As<IGen_ServiceInfoUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_ServicesUseCase>().As<IGen_ServicesUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_ServiceStatusUseCase>().As<IGen_ServiceStatusUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_ServicesTypeUseCase>().As<IGen_ServicesTypeUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_SkillProficiencyUseCase>().As<IGen_SkillProficiencyUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_StatusUseCase>().As<IGen_StatusUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_TrainingCentreUseCase>().As<IGen_TrainingCentreUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_UsefulLinkUseCase>().As<IGen_UsefulLinkUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_UsefulLinkCategoryUseCase>().As<IGen_UsefulLinkCategoryUseCase>().InstancePerLifetimeScope();
            //General: End

            //Registration : Start
            builder.RegisterType<Reg_BasicInfoUseCase>().As<IReg_BasicInfoUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Reg_EducationInfoUseCase>().As<IReg_EducationInfoUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Reg_EmergencyContactInfoUseCase>().As<IReg_EmergencyContactInfoUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Reg_FamillyUseCase>().As<IReg_FamillyUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Reg_HobbiesUseCase>().As<IReg_HobbiesUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Reg_LanguageUseCase>().As<IReg_LanguageUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Reg_NonKuwaityStatusUseCase>().As<IReg_NonKuwaityStatusUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Reg_PreviousExperianceUseCase>().As<IReg_PreviousExperianceUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Reg_PunishmentUseCase>().As<IReg_PunishmentUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Reg_RegistrationInfoUseCase>().As<IReg_RegistrationInfoUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Reg_RelativesWorkingInMODUseCase>().As<IReg_RelativesWorkingInMODUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Reg_StudentFileStorageUseCase>().As<IReg_StudentFileStorageUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Reg_DataCheckedUseCase>().As<IReg_DataCheckedUseCase>().InstancePerLifetimeScope();
            //Registration : End

            //STP : Start
            builder.RegisterType<Stp_OrganizationUseCase>().As<IStp_OrganizationUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Stp_OrganizationEntityUseCase>().As<IStp_OrganizationEntityUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Stp_OrganizationEntityTypeUseCase>().As<IStp_OrganizationEntityTypeUseCase>().InstancePerLifetimeScope();
            //STP : End

            
            builder.RegisterType<Tran_ApplicantPhasesUseCase>().As<ITran_ApplicantPhasesUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Tran_ExportProfileUseCase>().As<ITran_ExportProfileUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Tran_LoginUseCase>().As<ITran_LoginUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Tran_NotificationBatchUseCase>().As<ITran_NotificationBatchUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Tran_NotificationBatchDetUseCase>().As<ITran_NotificationBatchDetUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Tran_NotificationFileUseCase>().As<ITran_NotificationFileUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Tran_NotificationFileDetUseCase>().As<ITran_NotificationFileDetUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Tran_RollbackInfoUseCase>().As<ITran_RollbackInfoUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Tran_SpecialRegistrationUseCase>().As<ITran_SpecialRegistrationUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Tran_SyExamNotificationUseCase>().As<ITran_SyExamNotificationUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Tran_MedExamNotificationUseCase>().As<ITran_MedExamNotificationUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Tran_FinalExamNotificationUseCase>().As<ITran_FinalExamNotificationUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Tran_TrainingJoinNotificationUseCase>().As<ITran_TrainingJoinNotificationUseCase>().InstancePerLifetimeScope();
            //Transaction : End

            //Web Front: Start
            builder.RegisterType<VCRegistrationUseCase>().As<IVCRegistrationUseCase>().InstancePerLifetimeScope();
            //Web Front: End

            //Web Admin: Start
            builder.RegisterType<VCApplicantReviewUseCase>().As<IVCApplicantReviewUseCase>().InstancePerLifetimeScope();
            //Web Admin: End
        }
    }
}
