using AppConfig.ConfigDAAC;
using DAC.Core.DataAccessObjects.General;
using IDAC.Core.IDataAccessObjects.General;
using IDAC.Core.IDataAccessObjects.Security;
using IDAC.Core.IDataAccessObjects.Security.ExtendedPartial;
using System.Diagnostics;

namespace DAC.Core.CoreFactory
{
	public abstract partial class BaseDataAccessFactory
	{

		#region Instance Variables
		private Context _context;
		#endregion

		#region Property
		protected virtual Context CurrentContext
		{
			[DebuggerStepThrough()]
			get
			{
				if (_context == null)
				{
					_context = new Context();
				}
				return _context;
			}
		}

		#endregion

		#region Constructer
		[DebuggerStepThrough()]
		public BaseDataAccessFactory(Context context)
		{
			_context = context;
		}

		public BaseDataAccessFactory() : base()
		{

		}

		#endregion

		#region Static Methods

		[DebuggerStepThrough()]
		public static BaseDataAccessFactory Create(Context context)
		{
			//BaseDataAccessFactory dataAccessFactory = new DataAccessFactory(context);
			return (BaseDataAccessFactory)new DataAccessFactory(context);
		}
		#endregion

		#region Factory Methods 


		#endregion


		#region Extended
		#region IKAFUserSecurityDataAccess
		public abstract IKAFUserSecurityDataAccess CreateKAFUserSecurityDataAccess();
        #endregion IKAFUserSecurityDataAccess
        #endregion

        #region Factory Methods 
        #region gen_applicanttables
        public abstract Igen_applicanttablesDataAccessObjects Creategen_applicanttablesDataAccess();
        #endregion gen_applicanttables

        #region cnf_fileconfigname
        public abstract Icnf_fileconfignameDataAccessObjects Createcnf_fileconfignameDataAccess();
        #endregion cnf_fileconfigname

        #region cnf_filerequired
        public abstract Icnf_filerequiredDataAccessObjects Createcnf_filerequiredDataAccess();
		#endregion cnf_filerequired


		#region cnf_notificationconfig
		public abstract Icnf_notificationconfigDataAccessObjects Createcnf_notificationconfigDataAccess();
		#endregion cnf_notificationconfig


		#region cnf_notificationconfigdetl
		public abstract Icnf_notificationconfigdetlDataAccessObjects Createcnf_notificationconfigdetlDataAccess();
		#endregion cnf_notificationconfigdetl


		#region cnf_notificationtemplet
		public abstract Icnf_notificationtempletDataAccessObjects Createcnf_notificationtempletDataAccess();
		#endregion cnf_notificationtemplet


		#region cnf_smsactivationcode
		public abstract Icnf_smsactivationcodeDataAccessObjects Createcnf_smsactivationcodeDataAccess();
		#endregion cnf_smsactivationcode


		#region cnf_smsactivationtransection
		public abstract Icnf_smsactivationtransectionDataAccessObjects Createcnf_smsactivationtransectionDataAccess();
		#endregion cnf_smsactivationtransection


		#region cnf_studentmenuskip
		public abstract Icnf_studentmenuskipDataAccessObjects Createcnf_studentmenuskipDataAccess();
		#endregion cnf_studentmenuskip


		#region cnf_studentmenuskipdetail
		public abstract Icnf_studentmenuskipdetailDataAccessObjects Createcnf_studentmenuskipdetailDataAccess();
		#endregion cnf_studentmenuskipdetail


		#region gen_batch
		public abstract Igen_batchDataAccessObjects Creategen_batchDataAccess();
		#endregion gen_batch

		#region gen_econtactlist
		public abstract Igen_econtactlistDataAccessObjects Creategen_econtactlistDataAccess();
		#endregion gen_econtactlist
		#region gen_batchcandidatecertificate
		public abstract Igen_batchcandidatecertificateDataAccessObjects Creategen_batchcandidatecertificateDataAccess();
		#endregion gen_batchcandidatecertificate


		#region gen_batchcandidatereqfile
		public abstract Igen_batchcandidatereqfileDataAccessObjects Creategen_batchcandidatereqfileDataAccess();
		#endregion gen_batchcandidatereqfile


		#region gen_batchcandidatetypemap
		public abstract Igen_batchcandidatetypemapDataAccessObjects Creategen_batchcandidatetypemapDataAccess();
		#endregion gen_batchcandidatetypemap


		#region gen_batchcandprofession
		public abstract Igen_batchcandprofessionDataAccessObjects Creategen_batchcandprofessionDataAccess();
		#endregion gen_batchcandprofession


		#region gen_batchunitlist
		public abstract Igen_batchunitlistDataAccessObjects Creategen_batchunitlistDataAccess();
		#endregion gen_batchunitlist


		#region gen_bloodgroup
		public abstract Igen_bloodgroupDataAccessObjects Creategen_bloodgroupDataAccess();
		#endregion gen_bloodgroup


		#region gen_candidatetype
		public abstract Igen_candidatetypeDataAccessObjects Creategen_candidatetypeDataAccess();
		#endregion gen_candidatetype


		#region gen_certificate
		public abstract Igen_certificateDataAccessObjects Creategen_certificateDataAccess();
		#endregion gen_certificate


		#region gen_certificatelevel
		public abstract Igen_certificatelevelDataAccessObjects Creategen_certificatelevelDataAccess();
		#endregion gen_certificatelevel


		#region gen_certificatesubjects
		public abstract Igen_certificatesubjectsDataAccessObjects Creategen_certificatesubjectsDataAccess();
		#endregion gen_certificatesubjects


		#region gen_certificatetype
		public abstract Igen_certificatetypeDataAccessObjects Creategen_certificatetypeDataAccess();
		#endregion gen_certificatetype


		#region gen_civilworkplaces
		public abstract Igen_civilworkplacesDataAccessObjects Creategen_civilworkplacesDataAccess();
		#endregion gen_civilworkplaces


		#region gen_companies
		public abstract Igen_companiesDataAccessObjects Creategen_companiesDataAccess();
		#endregion gen_companies


		#region gen_companytype
		public abstract Igen_companytypeDataAccessObjects Creategen_companytypeDataAccess();
		#endregion gen_companytype


		#region gen_country
		public abstract Igen_countryDataAccessObjects Creategen_countryDataAccess();
		#endregion gen_country


		#region gen_countrycity
		public abstract Igen_countrycityDataAccessObjects Creategen_countrycityDataAccess();
		#endregion gen_countrycity


		#region gen_countryclass
		public abstract Igen_countryclassDataAccessObjects Creategen_countryclassDataAccess();
		#endregion gen_countryclass


		#region gen_educationgrade
		public abstract Igen_educationgradeDataAccessObjects Creategen_educationgradeDataAccess();
		#endregion gen_educationgrade


		#region gen_educationmajor
		public abstract Igen_educationmajorDataAccessObjects Creategen_educationmajorDataAccess();
		#endregion gen_educationmajor


		#region gen_educationshift
		public abstract Igen_educationshiftDataAccessObjects Creategen_educationshiftDataAccess();
		#endregion gen_educationshift


		#region gen_faq
		public abstract Igen_faqDataAccessObjects Creategen_faqDataAccess();
		#endregion gen_faq


		#region gen_faqcategory
		public abstract Igen_faqcategoryDataAccessObjects Creategen_faqcategoryDataAccess();
		#endregion gen_faqcategory


		#region gen_gender
		public abstract Igen_genderDataAccessObjects Creategen_genderDataAccess();
		#endregion gen_gender


		#region gen_generalhealth
		public abstract Igen_generalhealthDataAccessObjects Creategen_generalhealthDataAccess();
		#endregion gen_generalhealth


		#region gen_generallook
		public abstract Igen_generallookDataAccessObjects Creategen_generallookDataAccess();
		#endregion gen_generallook


		#region gen_imagegallary
		public abstract Igen_imagegallaryDataAccessObjects Creategen_imagegallaryDataAccess();
		#endregion gen_imagegallary


		#region gen_imagegallarycategory
		public abstract Igen_imagegallarycategoryDataAccessObjects Creategen_imagegallarycategoryDataAccess();
		#endregion gen_imagegallarycategory


		#region gen_instituteinfo
		public abstract Igen_instituteinfoDataAccessObjects Creategen_instituteinfoDataAccess();
		#endregion gen_instituteinfo


		#region gen_languages
		public abstract Igen_languagesDataAccessObjects Creategen_languagesDataAccess();
		#endregion gen_languages


		#region gen_maritalstatus
		public abstract Igen_maritalstatusDataAccessObjects Creategen_maritalstatusDataAccess();
		#endregion gen_maritalstatus

		#region gen_news
		public abstract Igen_newsDataAccessObjects Creategen_newsDataAccess();
		#endregion gen_news



		#region gen_newscategory
		public abstract Igen_newscategoryDataAccessObjects Creategen_newscategoryDataAccess();
		#endregion gen_newscategory

		#region gen_newsgallery
		public abstract Igen_newsgalleryDataAccessObjects Creategen_newsgalleryDataAccess();
		#endregion gen_newsgallery

		#region gen_nonkuwaitystatus
		public abstract Igen_nonkuwaitystatusDataAccessObjects Creategen_nonkuwaitystatusDataAccess();
		#endregion gen_nonkuwaitystatus


		#region gen_phases
		public abstract Igen_phasesDataAccessObjects Creategen_phasesDataAccess();
		#endregion gen_phases


		#region gen_profession
		public abstract Igen_professionDataAccessObjects Creategen_professionDataAccess();
		#endregion gen_profession


		#region gen_professiongroup
		public abstract Igen_professiongroupDataAccessObjects Creategen_professiongroupDataAccess();
		#endregion gen_professiongroup


		#region gen_rank
		public abstract Igen_rankDataAccessObjects Creategen_rankDataAccess();
		#endregion gen_rank


		#region gen_relationship
		public abstract Igen_relationshipDataAccessObjects Creategen_relationshipDataAccess();
		#endregion gen_relationship


		#region gen_religion
		public abstract Igen_religionDataAccessObjects Creategen_religionDataAccess();
		#endregion gen_religion
		#region gen_residenttype
		public abstract Igen_residenttypeDataAccessObjects Creategen_residenttypeDataAccess();
		#endregion gen_residenttype


		#region gen_serviceinfo
		public abstract Igen_serviceinfoDataAccessObjects Creategen_serviceinfoDataAccess();
		#endregion gen_serviceinfo


		#region gen_services
		public abstract Igen_servicesDataAccessObjects Creategen_servicesDataAccess();
		#endregion gen_services


		#region gen_servicestatus
		public abstract Igen_servicestatusDataAccessObjects Creategen_servicestatusDataAccess();
		#endregion gen_servicestatus


		#region gen_servicestype
		public abstract Igen_servicestypeDataAccessObjects Creategen_servicestypeDataAccess();
		#endregion gen_servicestype


		#region gen_skillproficiency
		public abstract Igen_skillproficiencyDataAccessObjects Creategen_skillproficiencyDataAccess();
		#endregion gen_skillproficiency


		#region gen_status
		public abstract Igen_statusDataAccessObjects Creategen_statusDataAccess();
        #endregion gen_status

        #region gen_trainingcentre
        public abstract Igen_trainingcentreDataAccessObjects Creategen_trainingcentreDataAccess();
        #endregion gen_trainingcentre

        #region gen_usefullink
        public abstract Igen_usefullinkDataAccessObjects Creategen_usefullinkDataAccess();
		#endregion gen_usefullink


		#region gen_usefullinkcategory
		public abstract Igen_usefullinkcategoryDataAccessObjects Creategen_usefullinkcategoryDataAccess();
		#endregion gen_usefullinkcategory


		#region owin_formaction
		public abstract Iowin_formactionDataAccessObjects Createowin_formactionDataAccess();
		#endregion owin_formaction


		#region owin_forminfo
		public abstract Iowin_forminfoDataAccessObjects Createowin_forminfoDataAccess();
		#endregion owin_forminfo


		#region owin_lastworkingpage
		public abstract Iowin_lastworkingpageDataAccessObjects Createowin_lastworkingpageDataAccess();
		#endregion owin_lastworkingpage


		#region owin_role
		public abstract Iowin_roleDataAccessObjects Createowin_roleDataAccess();
		#endregion owin_role


		#region owin_rolepermission
		public abstract Iowin_rolepermissionDataAccessObjects Createowin_rolepermissionDataAccess();
		#endregion owin_rolepermission


		#region owin_user
		public abstract Iowin_userDataAccessObjects Createowin_userDataAccess();
		#endregion owin_user


		#region owin_userclaims
		public abstract Iowin_userclaimsDataAccessObjects Createowin_userclaimsDataAccess();
		#endregion owin_userclaims


		#region owin_userlogintrail
		public abstract Iowin_userlogintrailDataAccessObjects Createowin_userlogintrailDataAccess();
		#endregion owin_userlogintrail


		#region owin_userpasswordresetinfo
		public abstract Iowin_userpasswordresetinfoDataAccessObjects Createowin_userpasswordresetinfoDataAccess();
		#endregion owin_userpasswordresetinfo


		#region owin_userprefferencessettings
		public abstract Iowin_userprefferencessettingsDataAccessObjects Createowin_userprefferencessettingsDataAccess();
		#endregion owin_userprefferencessettings


		#region owin_userrole
		public abstract Iowin_userroleDataAccessObjects Createowin_userroleDataAccess();
		#endregion owin_userrole


		#region owin_userroles
		public abstract Iowin_userrolesDataAccessObjects Createowin_userrolesDataAccess();
		#endregion owin_userroles


		#region owin_userstatuschangehistory
		public abstract Iowin_userstatuschangehistoryDataAccessObjects Createowin_userstatuschangehistoryDataAccess();
		#endregion owin_userstatuschangehistory


		#region reg_basicinfo
		public abstract Ireg_basicinfoDataAccessObjects Createreg_basicinfoDataAccess();
        #endregion reg_basicinfo

        #region reg_datachecked
        public abstract Ireg_datacheckedDataAccessObjects Createreg_datacheckedDataAccess();
        #endregion reg_datachecked

        #region reg_educationinfo
        public abstract Ireg_educationinfoDataAccessObjects Createreg_educationinfoDataAccess();
		#endregion reg_educationinfo


		#region reg_emergencycontactinfo
		public abstract Ireg_emergencycontactinfoDataAccessObjects Createreg_emergencycontactinfoDataAccess();
		#endregion reg_emergencycontactinfo


		#region reg_familly
		public abstract Ireg_famillyDataAccessObjects Createreg_famillyDataAccess();
		#endregion reg_familly


		#region reg_hobbies
		public abstract Ireg_hobbiesDataAccessObjects Createreg_hobbiesDataAccess();
		#endregion reg_hobbies


		#region reg_language
		public abstract Ireg_languageDataAccessObjects Createreg_languageDataAccess();
		#endregion reg_language


		#region reg_nonkuwaitystatus
		public abstract Ireg_nonkuwaitystatusDataAccessObjects Createreg_nonkuwaitystatusDataAccess();
		#endregion reg_nonkuwaitystatus


		#region reg_previousexperiance
		public abstract Ireg_previousexperianceDataAccessObjects Createreg_previousexperianceDataAccess();
		#endregion reg_previousexperiance


		#region reg_punishment
		public abstract Ireg_punishmentDataAccessObjects Createreg_punishmentDataAccess();
		#endregion reg_punishment


		#region reg_registrationinfo
		public abstract Ireg_registrationinfoDataAccessObjects Createreg_registrationinfoDataAccess();
		#endregion reg_registrationinfo


		#region reg_relativesworkinginmod
		public abstract Ireg_relativesworkinginmodDataAccessObjects Createreg_relativesworkinginmodDataAccess();
		#endregion reg_relativesworkinginmod


		#region reg_studentfilestorage
		public abstract Ireg_studentfilestorageDataAccessObjects Createreg_studentfilestorageDataAccess();
		#endregion reg_studentfilestorage


		#region stp_organization
		public abstract Istp_organizationDataAccessObjects Createstp_organizationDataAccess();
		#endregion stp_organization


		#region stp_organizationentity
		public abstract Istp_organizationentityDataAccessObjects Createstp_organizationentityDataAccess();
		#endregion stp_organizationentity


		#region stp_organizationentitytype
		public abstract Istp_organizationentitytypeDataAccessObjects Createstp_organizationentitytypeDataAccess();
        #endregion stp_organizationentitytype

        #region tran_applicantbatchchange
        public abstract Itran_applicantbatchchangeDataAccessObjects Createtran_applicantbatchchangeDataAccess();
        #endregion tran_applicantbatchchange

        #region tran_applicantphases
        public abstract Itran_applicantphasesDataAccessObjects Createtran_applicantphasesDataAccess();
        #endregion tran_applicantphases

        #region tran_applicantresultexpire
        public abstract Itran_applicantresultexpireDataAccessObjects Createtran_applicantresultexpireDataAccess();
        #endregion tran_applicantresultexpire

        #region tran_applicantretestapproval
        public abstract Itran_applicantretestapprovalDataAccessObjects Createtran_applicantretestapprovalDataAccess();
        #endregion tran_applicantretestapproval

        #region tran_applyanotherbatch
        public abstract Itran_applyanotherbatchDataAccessObjects Createtran_applyanotherbatchDataAccess();
        #endregion tran_applyanotherbatch

        #region tran_auditresult
        public abstract Itran_auditresultDataAccessObjects Createtran_auditresultDataAccess();
        #endregion tran_auditresult

        #region tran_centralagencysyresult
        public abstract Itran_centralagencysyresultDataAccessObjects Createtran_centralagencysyresultDataAccess();
        #endregion tran_centralagencysyresult

        #region tran_exportprofile
        public abstract Itran_exportprofileDataAccessObjects Createtran_exportprofileDataAccess();
        #endregion tran_exportprofile

        #region tran_finalexamresult
        public abstract Itran_finalexamresultDataAccessObjects Createtran_finalexamresultDataAccess();
		#endregion tran_finalexamresult

		#region tran_medexamnotification
		public abstract Itran_finalexamnotificationDataAccessObjects Createtran_finalexamnotificationDataAccess();
        #endregion tran_medexamnotification

        #region tran_login
        public abstract Itran_loginDataAccessObjects Createtran_loginDataAccess();
        #endregion tran_login

        #region tran_medexamnotification
        public abstract Itran_medexamnotificationDataAccessObjects Createtran_medexamnotificationDataAccess();
        #endregion tran_medexamnotification

        #region tran_medexamresult
        public abstract Itran_medexamresultDataAccessObjects Createtran_medexamresultDataAccess();
        #endregion tran_medexamresult

        #region tran_notificationbatch
        public abstract Itran_notificationbatchDataAccessObjects Createtran_notificationbatchDataAccess();
		#endregion tran_notificationbatch

		#region tran_notificationbatchdet
		public abstract Itran_notificationbatchdetDataAccessObjects Createtran_notificationbatchdetDataAccess();
        #endregion tran_notificationbatchdet

        #region tran_notificationfile
        public abstract Itran_notificationfileDataAccessObjects Createtran_notificationfileDataAccess();
        #endregion tran_notificationbatch

        #region tran_notificationfiledet
        public abstract Itran_notificationfiledetDataAccessObjects Createtran_notificationfiledetDataAccess();
        #endregion tran_notificationfiledet

        #region tran_psychoexamresult
        public abstract Itran_psychoexamresultDataAccessObjects Createtran_psychoexamresultDataAccess();
        #endregion tran_psychoexamresult

        #region tran_rollbackinfo
        public abstract Itran_rollbackinfoDataAccessObjects Createtran_rollbackinfoDataAccess();
		#endregion tran_rollbackinfo

		#region tran_specialregistration
		public abstract Itran_specialregistrationDataAccessObjects Createtran_specialregistrationDataAccess();
        #endregion tran_specialregistration

        #region tran_syexamnotification
        public abstract Itran_syexamnotificationDataAccessObjects Createtran_syexamnotificationDataAccess();
        #endregion tran_syexamnotification

        #region tran_syexamresult
        public abstract Itran_syexamresultDataAccessObjects Createtran_syexamresultDataAccess();
        #endregion tran_syexamresult

        #region tran_trainingjoin
        public abstract Itran_trainingjoinDataAccessObjects Createtran_trainingjoinDataAccess();
        #endregion tran_trainingjoin

        #region tran_trainingjoinnotification
        public abstract Itran_trainingjoinnotificationDataAccessObjects Createtran_trainingjoinnotificationDataAccess();
        #endregion tran_trainingjoinnotification

        #region tran_unitclearanceresult
        public abstract Itran_unitclearanceresultDataAccessObjects Createtran_unitclearanceresultDataAccess();
        #endregion tran_unitclearanceresult

        #region tran_volunteermedclearance
        public abstract Itran_volunteermedclearanceDataAccessObjects Createtran_volunteermedclearanceDataAccess();
        #endregion tran_volunteermedclearance


        #region tran_volunteersyclearance
        public abstract Itran_volunteersyclearanceDataAccessObjects Createtran_volunteersyclearanceDataAccess();
        #endregion tran_volunteersyclearance


        #region tran_volunteerunitclearance
        public abstract Itran_volunteerunitclearanceDataAccessObjects Createtran_volunteerunitclearanceDataAccess();
        #endregion tran_volunteerunitclearance

        #endregion
    }
}
