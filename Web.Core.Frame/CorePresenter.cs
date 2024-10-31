using Autofac;
using Web.Core.Frame.Presenters;
using Web.Core.Frame.Presenters.Configuration;
using Web.Core.Frame.Presenters.Registration;
using Web.Core.Frame.Presenters.Transaction;

namespace Web.Core.Frame
{
    public partial class CorePresenter : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Auth_Presenter>().InstancePerLifetimeScope();

            builder.RegisterType<HomePresenter>().InstancePerLifetimeScope();

            builder.RegisterType<Owin_FormActionPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Owin_LastWorkingPagePresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Owin_RolePermissionPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Owin_RolePresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Owin_UserClaimsPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Owin_UserLoginTrailPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Owin_UserPasswordResetInfoPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Owin_UserPrefferencesSettingsPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Owin_UserPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Owin_UserRolePresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Owin_UserRolesPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Owin_UserStatusChangeHistoryPresenter>().InstancePerLifetimeScope();

            builder.RegisterType<ExchangeRefreshTokenPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<LoginPresenter>().InstancePerLifetimeScope();

            builder.RegisterType<RegisterUserPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<PreRegistrationPresenter>().InstancePerLifetimeScope();

			builder.RegisterType<Reg_BasicInfoPresenter>().InstancePerLifetimeScope();
			builder.RegisterType<Reg_EducationInfoPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Reg_FamillyPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Reg_RegistrationInfoPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Reg_NonKuwaityStatusPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Reg_DataCheckedPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Reg_StudentFileStoragePresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Reg_EmergencyContactInfoPresenter>().InstancePerLifetimeScope();

            builder.RegisterType<Gen_CountryPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_CountryClassPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_ResidentTypePresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_EducationGradePresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_MaritalStatusPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_BloodGroupPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_ReligionPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_NonKuwaityStatusPresenter>().InstancePerLifetimeScope();

            builder.RegisterType<Gen_InstituteInfoPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_CountryCityPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_BatchPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_BatchPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_BatchCandidateCertificatePresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_BatchUnitListPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_BatchCandidateTypeMapPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_BatchCandProfessionPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_BatchCandidateReqFilePresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_CandidateTypePresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_CertificatePresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_CertificateLevelPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_CertificateTypePresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_CertificateSubjectsPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_CountryPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_CompaniesPresenter>().InstancePerLifetimeScope(); 
            builder.RegisterType<Gen_CompanyTypePresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_CivilWorkPlacesPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_FAQCategoryPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_FaqPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_GeneralHealthPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_GeneralLookPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_ImageGallaryCategoryPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_ImageGallaryPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_LanguagesPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_NewsCategoryPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_NewsPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_ProfessionPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_ProfessionGroupPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_PhasesPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_ServicesTypePresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_ServicesPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_StatusPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_UsefulLinkCategoryPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_UsefulLinkPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_ServiceStatusPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_EContactListPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_TrainingCentrePresenter>().InstancePerLifetimeScope();

			builder.RegisterType<Stp_OrganizationPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Stp_OrganizationEntityPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Stp_OrganizationEntityTypePresenter>().InstancePerLifetimeScope();

            builder.RegisterType<Cnf_FileConfigNamePresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Cnf_FileRequiredPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Cnf_NotificationConfigPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Cnf_NotificationConfigDetlPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Cnf_NotificationTempletPresenter>().InstancePerLifetimeScope();

            builder.RegisterType<Tran_NotificationBatchPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Tran_NotificationBatchDetPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Tran_NotificationFilePresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Tran_NotificationFileDetPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Tran_SpecialRegistrationPresenter>().InstancePerLifetimeScope();
			builder.RegisterType<Tran_ApplicantPhasesPresenter>().InstancePerLifetimeScope();
			builder.RegisterType<Tran_RollbackInfoPresenter>().InstancePerLifetimeScope();
			builder.RegisterType<Tran_SyExamNotificationPresenter>().InstancePerLifetimeScope();
			builder.RegisterType<Tran_MedExamNotificationPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Tran_FinalExamNotificationPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Tran_TrainingJoinNotificationPresenter>().InstancePerLifetimeScope();

            builder.RegisterType<VCApplicantReviewPresenter>().InstancePerLifetimeScope();
        }
    }
}

