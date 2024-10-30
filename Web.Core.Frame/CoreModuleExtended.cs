using Autofac;
using CLL.LLClasses.Models;
using Web.Core.Frame.Interfaces.Services;
using Web.Core.Frame.Interfaces.UseCases;
using Web.Core.Frame.Presenters;
using Web.Core.Frame.UseCases;

namespace Web.Core.Frame
{
    public partial class CoreModuleExtended : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<HomeUseCase>().As<IHomeUseCase>().InstancePerLifetimeScope();




            builder.RegisterType<Gen_FaqUseCase>().As<IGen_FaqUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_FAQCategoryUseCase>().As<IGen_FAQCategoryUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_ImageGallaryUseCase>().As<IGen_ImageGallaryUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_ImageGallaryCategoryUseCase>().As<IGen_ImageGallaryCategoryUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_NewsCategoryUseCase>().As<IGen_NewsCategoryUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_NewsUseCase>().As<IGen_NewsUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_ServicesTypeUseCase>().As<IGen_ServicesTypeUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_ServicesUseCase>().As<IGen_ServicesUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_UsefulLinkCategoryUseCase>().As<IGen_UsefulLinkCategoryUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_UsefulLinkUseCase>().As<IGen_UsefulLinkUseCase>().InstancePerLifetimeScope();




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



            // KNS
            builder.RegisterType<Kns_BatchUseCase>().As<IKns_BatchUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_BatchDetailUseCase>().As<IKns_BatchDetailUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_BatchOrderUseCase>().As<IKns_BatchOrderUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_Gen_CertificateUseCase>().As<IKns_Gen_CertificateUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_Gen_CertificateSubjectsUseCase>().As<IKns_Gen_CertificateSubjectsUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_Gen_DecisionTypeUseCase>().As<IKns_Gen_DecisionTypeUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_Gen_EducationGradeUseCase>().As<IKns_Gen_EducationGradeUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_Gen_ExternalServiceInfoUseCase>().As<IKns_Gen_ExternalServiceInfoUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_Gen_ReasonUseCase>().As<IKns_Gen_ReasonUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_Gen_ReasonTypeUseCase>().As<IKns_Gen_ReasonTypeUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_StatusChangeRequestUseCase>().As<IKns_StatusChangeRequestUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_StatusChangeRequestResolutionUseCase>().As<IKns_StatusChangeRequestResolutionUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_Tran_RegEducationInfoUseCase>().As<IKns_Tran_RegEducationInfoUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_Tran_RegExternalServiceResultInfoUseCase>().As<IKns_Tran_RegExternalServiceResultInfoUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_Tran_RegFamilyInfoUseCase>().As<IKns_Tran_RegFamilyInfoUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_Tran_RegImergencyContactInfoUseCase>().As<IKns_Tran_RegImergencyContactInfoUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_Tran_RegistrationProfileUseCase>().As<IKns_Tran_RegistrationProfileUseCase>().InstancePerLifetimeScope();

            builder.RegisterType<RegisterUserExportImportUseCase>().As<IRegisterUserExportImportUseCase>().InstancePerLifetimeScope();

            builder.RegisterType<Kns_ImportFromPaciExcelUseCase>().As<IKns_ImportFromPaciExcelUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_BloodGroupUseCase>().As<IGen_BloodGroupUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_CountryUseCase>().As<IGen_CountryUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_GenderUseCase>().As<IGen_GenderUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_GovCityUseCase>().As<IGen_GovCityUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<KNS_ApiMigrateDataInfoUseCase>().As<IKNS_ApiMigrateDataInfoUseCase>().InstancePerLifetimeScope();

            builder.RegisterType<Kns_Gen_ServiceInfoUseCase>().As<IKns_Gen_ServiceInfoUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_Gen_ServiceStatusInfoUseCase>().As<IKns_Gen_ServiceStatusInfoUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_ServiceStatusMapInfoUseCase>().As<IKns_ServiceStatusMapInfoUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_RelationshipUseCase>().As<IGen_RelationshipUseCase>().InstancePerLifetimeScope();

            builder.RegisterType<Tran_RecievePaciDataInfoUseCase>().As<ITran_RecievePaciDataInfoUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_MaritalStatusUseCase>().As<IGen_MaritalStatusUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_PhasesUseCase>().As<IGen_PhasesUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_Tran_PhaseInfoUseCase>().As<IKns_Tran_PhaseInfoUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_Tran_PhaseInfoNotificationUseCase>().As<IKns_Tran_PhaseInfoNotificationUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_PhaseStatusUseCase>().As<IGen_PhaseStatusUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_MedicalUseCase>().As<IKns_MedicalUseCase>().InstancePerLifetimeScope();
			builder.RegisterType<Gen_IssueTypeUseCase>().As<IGen_IssueTypeUseCase>().InstancePerLifetimeScope();
			builder.RegisterType<KnsTransPunishmentUseCase>().As<IKnsTransPunishmentUseCase>().InstancePerLifetimeScope();
			builder.RegisterType<Kns_Tran_NotificationMessageUseCase>().As<IKns_Tran_NotificationMessageUseCase>().InstancePerLifetimeScope();
			builder.RegisterType<Gen_Search_ParametersUseCase>().As<IGen_Search_ParametersUseCase>().InstancePerLifetimeScope();
			builder.RegisterType<Kns_Tran_RegistrationProfileFileStorageUseCase>().As<IKns_Tran_RegistrationProfileFileStorageUseCase>().InstancePerLifetimeScope();
			builder.RegisterType<KNS_HangfireJobDetailUseCase>().As<IKNS_HangfireJobDetailUseCase>().InstancePerLifetimeScope();
			builder.RegisterType<Kns_Tran_PhaseInfo_NotificationCountUseCase>().As<IKns_Tran_PhaseInfo_NotificationCountUseCase>().InstancePerLifetimeScope();




		}
	}
}