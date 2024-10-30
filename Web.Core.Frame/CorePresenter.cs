using Autofac;
using CLL.LLClasses.Models;
using Web.Core.Frame.Interfaces.Services;
using Web.Core.Frame.Interfaces.UseCases;
using Web.Core.Frame.Presenters;
using Web.Core.Frame.UseCases;

namespace Web.Core.Frame
{
    public partial class CorePresenter : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Auth_Presenter>().InstancePerLifetimeScope();

            builder.RegisterType<HomePresenter>().InstancePerLifetimeScope();



            builder.RegisterType<Gen_FAQCategoryPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_FaqPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_ImageGallaryCategoryPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_ImageGallaryPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_NewsCategoryPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_NewsPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_ServicesTypePresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_ServicesPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_UsefulLinkCategoryPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_UsefulLinkPresenter>().InstancePerLifetimeScope();




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


            builder.RegisterType<Kns_BatchPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_BatchDetailPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_BatchOrderPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_Gen_CertificatePresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_Gen_CertificateSubjectsPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_Gen_DecisionTypePresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_Gen_EducationGradePresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_Gen_ExternalServiceInfoPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_Gen_ReasonPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_Gen_ReasonTypePresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_StatusChangeRequestPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_StatusChangeRequestResolutionPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_Tran_RegEducationInfoPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_Tran_RegExternalServiceResultInfoPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_Tran_RegFamilyInfoPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_Tran_RegImergencyContactInfoPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_Tran_RegistrationProfilePresenter>().InstancePerLifetimeScope();


            builder.RegisterType<RegisterUserExportImportPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_ImportFromPaciExcelPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_BloodGroupPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_CountryPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_GenderPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_GovCityPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_RelationshipPresenter>().InstancePerLifetimeScope();




            builder.RegisterType<Kns_Gen_ServiceInfoPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_Gen_ServiceStatusInfoPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<KNS_ApiMigrateDataInfoPresenter>().InstancePerLifetimeScope();

            builder.RegisterType<Kns_ServiceStatusMapInfoPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_MaritalStatusPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_PhasesPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_Tran_PhaseInfoPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_Tran_PhaseInfoNotificationPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_PhaseStatusPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_MedicalPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_IssueTypePresenter>().InstancePerLifetimeScope();
            builder.RegisterType<KnsTransPunishmentPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Kns_Tran_NotificationMessagePresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_Search_ParametersPresenter>().InstancePerLifetimeScope();
            builder.RegisterType<Gen_Search_ParametersPresenter>().InstancePerLifetimeScope();

			builder.RegisterType<KNS_HangfireJobDetailPresenter>().InstancePerLifetimeScope();
			builder.RegisterType<Kns_Tran_PhaseInfo_NotificationCountPresenter>().InstancePerLifetimeScope();




		}
	}
}
