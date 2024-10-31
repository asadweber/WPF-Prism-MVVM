using AppConfig.ConfigDAAC;
using DAC.Core.DataAccessObjects.General;
using DAC.Core.DataAccessObjects.Security;
using DAC.Core.DataAccessObjects.Security.ExtendedPartial;
using IDAC.Core.IDataAccessObjects.General;
using IDAC.Core.IDataAccessObjects.Security;
using IDAC.Core.IDataAccessObjects.Security.ExtendedPartial;
using System.Diagnostics;

namespace DAC.Core.CoreFactory
{
	[DebuggerStepThrough()]
	public partial class DataAccessFactory : BaseDataAccessFactory
	{
		#region Constructor
		public DataAccessFactory(Context context)
			: base(context)
		{
		}

		public DataAccessFactory()
			: base()
		{
		}
		#endregion

		#region Factory Methods 


		#endregion Factory Methods 

		#region Extended 
		#region SecKAFUserSecurityDataAccess
		[DebuggerStepThrough()]
		public override IKAFUserSecurityDataAccess CreateKAFUserSecurityDataAccess()
		{
			string type = typeof(KAFUserSecurityDataAccess).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new KAFUserSecurityDataAccess(CurrentContext);
			}
			return (IKAFUserSecurityDataAccess)CurrentContext[type];
		}
        #endregion SecKAFUserSecurityDataAccess
        #endregion

        #region Factory Methods 

        #region cnf_fileconfigname
        [DebuggerStepThrough()]
        public override Icnf_fileconfignameDataAccessObjects Createcnf_fileconfignameDataAccess()
        {
            string type = typeof(cnf_fileconfignameDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new cnf_fileconfignameDataAccessObjects(CurrentContext);
            }
            return (Icnf_fileconfignameDataAccessObjects)CurrentContext[type];
        }
        #endregion cnf_fileconfigname

        #region cnf_filerequired
        [DebuggerStepThrough()]
		public override Icnf_filerequiredDataAccessObjects Createcnf_filerequiredDataAccess()
		{
			string type = typeof(cnf_filerequiredDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new cnf_filerequiredDataAccessObjects(CurrentContext);
			}
			return (Icnf_filerequiredDataAccessObjects)CurrentContext[type];
		}
		#endregion cnf_filerequired


		#region cnf_notificationconfig
		[DebuggerStepThrough()]
		public override Icnf_notificationconfigDataAccessObjects Createcnf_notificationconfigDataAccess()
		{
			string type = typeof(cnf_notificationconfigDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new cnf_notificationconfigDataAccessObjects(CurrentContext);
			}
			return (Icnf_notificationconfigDataAccessObjects)CurrentContext[type];
		}
        #endregion cnf_notificationconfig


        #region gen_applicanttables
        [DebuggerStepThrough()]
        public override Igen_applicanttablesDataAccessObjects Creategen_applicanttablesDataAccess()
        {
            string type = typeof(gen_applicanttablesDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_applicanttablesDataAccessObjects(CurrentContext);
            }
            return (Igen_applicanttablesDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_applicanttables


        #region cnf_notificationconfigdetl
        [DebuggerStepThrough()]
		public override Icnf_notificationconfigdetlDataAccessObjects Createcnf_notificationconfigdetlDataAccess()
		{
			string type = typeof(cnf_notificationconfigdetlDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new cnf_notificationconfigdetlDataAccessObjects(CurrentContext);
			}
			return (Icnf_notificationconfigdetlDataAccessObjects)CurrentContext[type];
		}
		#endregion cnf_notificationconfigdetl


		#region gen_econtactlist
		[DebuggerStepThrough()]
		public override Igen_econtactlistDataAccessObjects Creategen_econtactlistDataAccess()
		{
			string type = typeof(gen_econtactlistDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_econtactlistDataAccessObjects(CurrentContext);
			}
			return (Igen_econtactlistDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_econtactlist

		#region cnf_notificationtemplet
		[DebuggerStepThrough()]
		public override Icnf_notificationtempletDataAccessObjects Createcnf_notificationtempletDataAccess()
		{
			string type = typeof(cnf_notificationtempletDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new cnf_notificationtempletDataAccessObjects(CurrentContext);
			}
			return (Icnf_notificationtempletDataAccessObjects)CurrentContext[type];
		}
		#endregion cnf_notificationtemplet


		#region cnf_smsactivationcode
		[DebuggerStepThrough()]
		public override Icnf_smsactivationcodeDataAccessObjects Createcnf_smsactivationcodeDataAccess()
		{
			string type = typeof(cnf_smsactivationcodeDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new cnf_smsactivationcodeDataAccessObjects(CurrentContext);
			}
			return (Icnf_smsactivationcodeDataAccessObjects)CurrentContext[type];
		}
		#endregion cnf_smsactivationcode


		#region cnf_smsactivationtransection
		[DebuggerStepThrough()]
		public override Icnf_smsactivationtransectionDataAccessObjects Createcnf_smsactivationtransectionDataAccess()
		{
			string type = typeof(cnf_smsactivationtransectionDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new cnf_smsactivationtransectionDataAccessObjects(CurrentContext);
			}
			return (Icnf_smsactivationtransectionDataAccessObjects)CurrentContext[type];
		}
		#endregion cnf_smsactivationtransection


		#region cnf_studentmenuskip
		[DebuggerStepThrough()]
		public override Icnf_studentmenuskipDataAccessObjects Createcnf_studentmenuskipDataAccess()
		{
			string type = typeof(cnf_studentmenuskipDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new cnf_studentmenuskipDataAccessObjects(CurrentContext);
			}
			return (Icnf_studentmenuskipDataAccessObjects)CurrentContext[type];
		}
		#endregion cnf_studentmenuskip


		#region cnf_studentmenuskipdetail
		[DebuggerStepThrough()]
		public override Icnf_studentmenuskipdetailDataAccessObjects Createcnf_studentmenuskipdetailDataAccess()
		{
			string type = typeof(cnf_studentmenuskipdetailDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new cnf_studentmenuskipdetailDataAccessObjects(CurrentContext);
			}
			return (Icnf_studentmenuskipdetailDataAccessObjects)CurrentContext[type];
		}
		#endregion cnf_studentmenuskipdetail


		#region gen_batch
		[DebuggerStepThrough()]
		public override Igen_batchDataAccessObjects Creategen_batchDataAccess()
		{
			string type = typeof(gen_batchDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_batchDataAccessObjects(CurrentContext);
			}
			return (Igen_batchDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_batch


		#region gen_batchcandidatecertificate
		[DebuggerStepThrough()]
		public override Igen_batchcandidatecertificateDataAccessObjects Creategen_batchcandidatecertificateDataAccess()
		{
			string type = typeof(gen_batchcandidatecertificateDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_batchcandidatecertificateDataAccessObjects(CurrentContext);
			}
			return (Igen_batchcandidatecertificateDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_batchcandidatecertificate


		#region gen_batchcandidatereqfile
		[DebuggerStepThrough()]
		public override Igen_batchcandidatereqfileDataAccessObjects Creategen_batchcandidatereqfileDataAccess()
		{
			string type = typeof(gen_batchcandidatereqfileDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_batchcandidatereqfileDataAccessObjects(CurrentContext);
			}
			return (Igen_batchcandidatereqfileDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_batchcandidatereqfile


		#region gen_batchcandidatetypemap
		[DebuggerStepThrough()]
		public override Igen_batchcandidatetypemapDataAccessObjects Creategen_batchcandidatetypemapDataAccess()
		{
			string type = typeof(gen_batchcandidatetypemapDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_batchcandidatetypemapDataAccessObjects(CurrentContext);
			}
			return (Igen_batchcandidatetypemapDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_batchcandidatetypemap


		#region gen_batchcandprofession
		[DebuggerStepThrough()]
		public override Igen_batchcandprofessionDataAccessObjects Creategen_batchcandprofessionDataAccess()
		{
			string type = typeof(gen_batchcandprofessionDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_batchcandprofessionDataAccessObjects(CurrentContext);
			}
			return (Igen_batchcandprofessionDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_batchcandprofession


		#region gen_batchunitlist
		[DebuggerStepThrough()]
		public override Igen_batchunitlistDataAccessObjects Creategen_batchunitlistDataAccess()
		{
			string type = typeof(gen_batchunitlistDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_batchunitlistDataAccessObjects(CurrentContext);
			}
			return (Igen_batchunitlistDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_batchunitlist


		#region gen_bloodgroup
		[DebuggerStepThrough()]
		public override Igen_bloodgroupDataAccessObjects Creategen_bloodgroupDataAccess()
		{
			string type = typeof(gen_bloodgroupDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_bloodgroupDataAccessObjects(CurrentContext);
			}
			return (Igen_bloodgroupDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_bloodgroup


		#region gen_candidatetype
		[DebuggerStepThrough()]
		public override Igen_candidatetypeDataAccessObjects Creategen_candidatetypeDataAccess()
		{
			string type = typeof(gen_candidatetypeDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_candidatetypeDataAccessObjects(CurrentContext);
			}
			return (Igen_candidatetypeDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_candidatetype


		#region gen_certificate
		[DebuggerStepThrough()]
		public override Igen_certificateDataAccessObjects Creategen_certificateDataAccess()
		{
			string type = typeof(gen_certificateDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_certificateDataAccessObjects(CurrentContext);
			}
			return (Igen_certificateDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_certificate


		#region gen_certificatelevel
		[DebuggerStepThrough()]
		public override Igen_certificatelevelDataAccessObjects Creategen_certificatelevelDataAccess()
		{
			string type = typeof(gen_certificatelevelDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_certificatelevelDataAccessObjects(CurrentContext);
			}
			return (Igen_certificatelevelDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_certificatelevel


		#region gen_certificatesubjects
		[DebuggerStepThrough()]
		public override Igen_certificatesubjectsDataAccessObjects Creategen_certificatesubjectsDataAccess()
		{
			string type = typeof(gen_certificatesubjectsDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_certificatesubjectsDataAccessObjects(CurrentContext);
			}
			return (Igen_certificatesubjectsDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_certificatesubjects


		#region gen_certificatetype
		[DebuggerStepThrough()]
		public override Igen_certificatetypeDataAccessObjects Creategen_certificatetypeDataAccess()
		{
			string type = typeof(gen_certificatetypeDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_certificatetypeDataAccessObjects(CurrentContext);
			}
			return (Igen_certificatetypeDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_certificatetype


		#region gen_civilworkplaces
		[DebuggerStepThrough()]
		public override Igen_civilworkplacesDataAccessObjects Creategen_civilworkplacesDataAccess()
		{
			string type = typeof(gen_civilworkplacesDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_civilworkplacesDataAccessObjects(CurrentContext);
			}
			return (Igen_civilworkplacesDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_civilworkplaces


		#region gen_companies
		[DebuggerStepThrough()]
		public override Igen_companiesDataAccessObjects Creategen_companiesDataAccess()
		{
			string type = typeof(gen_companiesDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_companiesDataAccessObjects(CurrentContext);
			}
			return (Igen_companiesDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_companies


		#region gen_companytype
		[DebuggerStepThrough()]
		public override Igen_companytypeDataAccessObjects Creategen_companytypeDataAccess()
		{
			string type = typeof(gen_companytypeDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_companytypeDataAccessObjects(CurrentContext);
			}
			return (Igen_companytypeDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_companytype


		#region gen_country
		[DebuggerStepThrough()]
		public override Igen_countryDataAccessObjects Creategen_countryDataAccess()
		{
			string type = typeof(gen_countryDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_countryDataAccessObjects(CurrentContext);
			}
			return (Igen_countryDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_country


		#region gen_countrycity
		[DebuggerStepThrough()]
		public override Igen_countrycityDataAccessObjects Creategen_countrycityDataAccess()
		{
			string type = typeof(gen_countrycityDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_countrycityDataAccessObjects(CurrentContext);
			}
			return (Igen_countrycityDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_countrycity


		#region gen_countryclass
		[DebuggerStepThrough()]
		public override Igen_countryclassDataAccessObjects Creategen_countryclassDataAccess()
		{
			string type = typeof(gen_countryclassDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_countryclassDataAccessObjects(CurrentContext);
			}
			return (Igen_countryclassDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_countryclass


		#region gen_educationgrade
		[DebuggerStepThrough()]
		public override Igen_educationgradeDataAccessObjects Creategen_educationgradeDataAccess()
		{
			string type = typeof(gen_educationgradeDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_educationgradeDataAccessObjects(CurrentContext);
			}
			return (Igen_educationgradeDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_educationgrade


		#region gen_educationmajor
		[DebuggerStepThrough()]
		public override Igen_educationmajorDataAccessObjects Creategen_educationmajorDataAccess()
		{
			string type = typeof(gen_educationmajorDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_educationmajorDataAccessObjects(CurrentContext);
			}
			return (Igen_educationmajorDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_educationmajor


		#region gen_educationshift
		[DebuggerStepThrough()]
		public override Igen_educationshiftDataAccessObjects Creategen_educationshiftDataAccess()
		{
			string type = typeof(gen_educationshiftDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_educationshiftDataAccessObjects(CurrentContext);
			}
			return (Igen_educationshiftDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_educationshift


		#region gen_faq
		[DebuggerStepThrough()]
		public override Igen_faqDataAccessObjects Creategen_faqDataAccess()
		{
			string type = typeof(gen_faqDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_faqDataAccessObjects(CurrentContext);
			}
			return (Igen_faqDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_faq


		#region gen_faqcategory
		[DebuggerStepThrough()]
		public override Igen_faqcategoryDataAccessObjects Creategen_faqcategoryDataAccess()
		{
			string type = typeof(gen_faqcategoryDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_faqcategoryDataAccessObjects(CurrentContext);
			}
			return (Igen_faqcategoryDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_faqcategory


		#region gen_gender
		[DebuggerStepThrough()]
		public override Igen_genderDataAccessObjects Creategen_genderDataAccess()
		{
			string type = typeof(gen_genderDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_genderDataAccessObjects(CurrentContext);
			}
			return (Igen_genderDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_gender


		#region gen_generalhealth
		[DebuggerStepThrough()]
		public override Igen_generalhealthDataAccessObjects Creategen_generalhealthDataAccess()
		{
			string type = typeof(gen_generalhealthDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_generalhealthDataAccessObjects(CurrentContext);
			}
			return (Igen_generalhealthDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_generalhealth


		#region gen_generallook
		[DebuggerStepThrough()]
		public override Igen_generallookDataAccessObjects Creategen_generallookDataAccess()
		{
			string type = typeof(gen_generallookDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_generallookDataAccessObjects(CurrentContext);
			}
			return (Igen_generallookDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_generallook


		#region gen_imagegallary
		[DebuggerStepThrough()]
		public override Igen_imagegallaryDataAccessObjects Creategen_imagegallaryDataAccess()
		{
			string type = typeof(gen_imagegallaryDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_imagegallaryDataAccessObjects(CurrentContext);
			}
			return (Igen_imagegallaryDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_imagegallary


		#region gen_imagegallarycategory
		[DebuggerStepThrough()]
		public override Igen_imagegallarycategoryDataAccessObjects Creategen_imagegallarycategoryDataAccess()
		{
			string type = typeof(gen_imagegallarycategoryDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_imagegallarycategoryDataAccessObjects(CurrentContext);
			}
			return (Igen_imagegallarycategoryDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_imagegallarycategory


		#region gen_instituteinfo
		[DebuggerStepThrough()]
		public override Igen_instituteinfoDataAccessObjects Creategen_instituteinfoDataAccess()
		{
			string type = typeof(gen_instituteinfoDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_instituteinfoDataAccessObjects(CurrentContext);
			}
			return (Igen_instituteinfoDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_instituteinfo


		#region gen_languages
		[DebuggerStepThrough()]
		public override Igen_languagesDataAccessObjects Creategen_languagesDataAccess()
		{
			string type = typeof(gen_languagesDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_languagesDataAccessObjects(CurrentContext);
			}
			return (Igen_languagesDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_languages


		#region gen_maritalstatus
		[DebuggerStepThrough()]
		public override Igen_maritalstatusDataAccessObjects Creategen_maritalstatusDataAccess()
		{
			string type = typeof(gen_maritalstatusDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_maritalstatusDataAccessObjects(CurrentContext);
			}
			return (Igen_maritalstatusDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_maritalstatus



		#region gen_news
		[DebuggerStepThrough()]
		public override Igen_newsDataAccessObjects Creategen_newsDataAccess()
		{
			string type = typeof(gen_newsDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_newsDataAccessObjects(CurrentContext);
			}
			return (Igen_newsDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_news



		#region gen_newscategory
		[DebuggerStepThrough()]
		public override Igen_newscategoryDataAccessObjects Creategen_newscategoryDataAccess()
		{
			string type = typeof(gen_newscategoryDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_newscategoryDataAccessObjects(CurrentContext);
			}
			return (Igen_newscategoryDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_newscategory

		#region gen_newsgallery
		[DebuggerStepThrough()]
		public override Igen_newsgalleryDataAccessObjects Creategen_newsgalleryDataAccess()
		{
			string type = typeof(gen_newsgalleryDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_newsgalleryDataAccessObjects(CurrentContext);
			}
			return (Igen_newsgalleryDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_newsgallery

		#region gen_nonkuwaitystatus
		[DebuggerStepThrough()]
		public override Igen_nonkuwaitystatusDataAccessObjects Creategen_nonkuwaitystatusDataAccess()
		{
			string type = typeof(gen_nonkuwaitystatusDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_nonkuwaitystatusDataAccessObjects(CurrentContext);
			}
			return (Igen_nonkuwaitystatusDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_nonkuwaitystatus


		#region gen_phases
		[DebuggerStepThrough()]
		public override Igen_phasesDataAccessObjects Creategen_phasesDataAccess()
		{
			string type = typeof(gen_phasesDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_phasesDataAccessObjects(CurrentContext);
			}
			return (Igen_phasesDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_phases


		#region gen_profession
		[DebuggerStepThrough()]
		public override Igen_professionDataAccessObjects Creategen_professionDataAccess()
		{
			string type = typeof(gen_professionDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_professionDataAccessObjects(CurrentContext);
			}
			return (Igen_professionDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_profession


		#region gen_professiongroup
		[DebuggerStepThrough()]
		public override Igen_professiongroupDataAccessObjects Creategen_professiongroupDataAccess()
		{
			string type = typeof(gen_professiongroupDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_professiongroupDataAccessObjects(CurrentContext);
			}
			return (Igen_professiongroupDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_professiongroup


		#region gen_rank
		[DebuggerStepThrough()]
		public override Igen_rankDataAccessObjects Creategen_rankDataAccess()
		{
			string type = typeof(gen_rankDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_rankDataAccessObjects(CurrentContext);
			}
			return (Igen_rankDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_rank


		#region gen_relationship
		[DebuggerStepThrough()]
		public override Igen_relationshipDataAccessObjects Creategen_relationshipDataAccess()
		{
			string type = typeof(gen_relationshipDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_relationshipDataAccessObjects(CurrentContext);
			}
			return (Igen_relationshipDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_relationship


		#region gen_religion
		[DebuggerStepThrough()]
		public override Igen_religionDataAccessObjects Creategen_religionDataAccess()
		{
			string type = typeof(gen_religionDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_religionDataAccessObjects(CurrentContext);
			}
			return (Igen_religionDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_religion

		#region gen_residenttype
		[DebuggerStepThrough()]
		public override Igen_residenttypeDataAccessObjects Creategen_residenttypeDataAccess()
		{
			string type = typeof(gen_residenttypeDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_residenttypeDataAccessObjects(CurrentContext);
			}
			return (Igen_residenttypeDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_residenttype


		#region gen_serviceinfo
		[DebuggerStepThrough()]
		public override Igen_serviceinfoDataAccessObjects Creategen_serviceinfoDataAccess()
		{
			string type = typeof(gen_serviceinfoDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_serviceinfoDataAccessObjects(CurrentContext);
			}
			return (Igen_serviceinfoDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_serviceinfo


		#region gen_services
		[DebuggerStepThrough()]
		public override Igen_servicesDataAccessObjects Creategen_servicesDataAccess()
		{
			string type = typeof(gen_servicesDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_servicesDataAccessObjects(CurrentContext);
			}
			return (Igen_servicesDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_services


		#region gen_servicestatus
		[DebuggerStepThrough()]
		public override Igen_servicestatusDataAccessObjects Creategen_servicestatusDataAccess()
		{
			string type = typeof(gen_servicestatusDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_servicestatusDataAccessObjects(CurrentContext);
			}
			return (Igen_servicestatusDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_servicestatus


		#region gen_servicestype
		[DebuggerStepThrough()]
		public override Igen_servicestypeDataAccessObjects Creategen_servicestypeDataAccess()
		{
			string type = typeof(gen_servicestypeDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_servicestypeDataAccessObjects(CurrentContext);
			}
			return (Igen_servicestypeDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_servicestype


		#region gen_skillproficiency
		[DebuggerStepThrough()]
		public override Igen_skillproficiencyDataAccessObjects Creategen_skillproficiencyDataAccess()
		{
			string type = typeof(gen_skillproficiencyDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_skillproficiencyDataAccessObjects(CurrentContext);
			}
			return (Igen_skillproficiencyDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_skillproficiency


		#region gen_status
		[DebuggerStepThrough()]
		public override Igen_statusDataAccessObjects Creategen_statusDataAccess()
		{
			string type = typeof(gen_statusDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_statusDataAccessObjects(CurrentContext);
			}
			return (Igen_statusDataAccessObjects)CurrentContext[type];
		}
        #endregion gen_status

        #region gen_trainingcentre
        [DebuggerStepThrough()]
        public override Igen_trainingcentreDataAccessObjects Creategen_trainingcentreDataAccess()
        {
            string type = typeof(gen_trainingcentreDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_trainingcentreDataAccessObjects(CurrentContext);
            }
            return (Igen_trainingcentreDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_trainingcentre

        #region gen_usefullink
        [DebuggerStepThrough()]
		public override Igen_usefullinkDataAccessObjects Creategen_usefullinkDataAccess()
		{
			string type = typeof(gen_usefullinkDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_usefullinkDataAccessObjects(CurrentContext);
			}
			return (Igen_usefullinkDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_usefullink


		#region gen_usefullinkcategory
		[DebuggerStepThrough()]
		public override Igen_usefullinkcategoryDataAccessObjects Creategen_usefullinkcategoryDataAccess()
		{
			string type = typeof(gen_usefullinkcategoryDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new gen_usefullinkcategoryDataAccessObjects(CurrentContext);
			}
			return (Igen_usefullinkcategoryDataAccessObjects)CurrentContext[type];
		}
		#endregion gen_usefullinkcategory


		#region owin_formaction
		[DebuggerStepThrough()]
		public override Iowin_formactionDataAccessObjects Createowin_formactionDataAccess()
		{
			string type = typeof(owin_formactionDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new owin_formactionDataAccessObjects(CurrentContext);
			}
			return (Iowin_formactionDataAccessObjects)CurrentContext[type];
		}
		#endregion owin_formaction


		#region owin_forminfo
		[DebuggerStepThrough()]
		public override Iowin_forminfoDataAccessObjects Createowin_forminfoDataAccess()
		{
			string type = typeof(owin_forminfoDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new owin_forminfoDataAccessObjects(CurrentContext);
			}
			return (Iowin_forminfoDataAccessObjects)CurrentContext[type];
		}
		#endregion owin_forminfo


		#region owin_lastworkingpage
		[DebuggerStepThrough()]
		public override Iowin_lastworkingpageDataAccessObjects Createowin_lastworkingpageDataAccess()
		{
			string type = typeof(owin_lastworkingpageDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new owin_lastworkingpageDataAccessObjects(CurrentContext);
			}
			return (Iowin_lastworkingpageDataAccessObjects)CurrentContext[type];
		}
		#endregion owin_lastworkingpage


		#region owin_role
		[DebuggerStepThrough()]
		public override Iowin_roleDataAccessObjects Createowin_roleDataAccess()
		{
			string type = typeof(owin_roleDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new owin_roleDataAccessObjects(CurrentContext);
			}
			return (Iowin_roleDataAccessObjects)CurrentContext[type];
		}
		#endregion owin_role


		#region owin_rolepermission
		[DebuggerStepThrough()]
		public override Iowin_rolepermissionDataAccessObjects Createowin_rolepermissionDataAccess()
		{
			string type = typeof(owin_rolepermissionDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new owin_rolepermissionDataAccessObjects(CurrentContext);
			}
			return (Iowin_rolepermissionDataAccessObjects)CurrentContext[type];
		}
		#endregion owin_rolepermission


		#region owin_user
		[DebuggerStepThrough()]
		public override Iowin_userDataAccessObjects Createowin_userDataAccess()
		{
			string type = typeof(owin_userDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new owin_userDataAccessObjects(CurrentContext);
			}
			return (Iowin_userDataAccessObjects)CurrentContext[type];
		}
		#endregion owin_user


		#region owin_userclaims
		[DebuggerStepThrough()]
		public override Iowin_userclaimsDataAccessObjects Createowin_userclaimsDataAccess()
		{
			string type = typeof(owin_userclaimsDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new owin_userclaimsDataAccessObjects(CurrentContext);
			}
			return (Iowin_userclaimsDataAccessObjects)CurrentContext[type];
		}
		#endregion owin_userclaims


		#region owin_userlogintrail
		[DebuggerStepThrough()]
		public override Iowin_userlogintrailDataAccessObjects Createowin_userlogintrailDataAccess()
		{
			string type = typeof(owin_userlogintrailDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new owin_userlogintrailDataAccessObjects(CurrentContext);
			}
			return (Iowin_userlogintrailDataAccessObjects)CurrentContext[type];
		}
		#endregion owin_userlogintrail


		#region owin_userpasswordresetinfo
		[DebuggerStepThrough()]
		public override Iowin_userpasswordresetinfoDataAccessObjects Createowin_userpasswordresetinfoDataAccess()
		{
			string type = typeof(owin_userpasswordresetinfoDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new owin_userpasswordresetinfoDataAccessObjects(CurrentContext);
			}
			return (Iowin_userpasswordresetinfoDataAccessObjects)CurrentContext[type];
		}
		#endregion owin_userpasswordresetinfo


		#region owin_userprefferencessettings
		[DebuggerStepThrough()]
		public override Iowin_userprefferencessettingsDataAccessObjects Createowin_userprefferencessettingsDataAccess()
		{
			string type = typeof(owin_userprefferencessettingsDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new owin_userprefferencessettingsDataAccessObjects(CurrentContext);
			}
			return (Iowin_userprefferencessettingsDataAccessObjects)CurrentContext[type];
		}
		#endregion owin_userprefferencessettings


		#region owin_userrole
		[DebuggerStepThrough()]
		public override Iowin_userroleDataAccessObjects Createowin_userroleDataAccess()
		{
			string type = typeof(owin_userroleDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new owin_userroleDataAccessObjects(CurrentContext);
			}
			return (Iowin_userroleDataAccessObjects)CurrentContext[type];
		}
		#endregion owin_userrole


		#region owin_userroles
		[DebuggerStepThrough()]
		public override Iowin_userrolesDataAccessObjects Createowin_userrolesDataAccess()
		{
			string type = typeof(owin_userrolesDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new owin_userrolesDataAccessObjects(CurrentContext);
			}
			return (Iowin_userrolesDataAccessObjects)CurrentContext[type];
		}
		#endregion owin_userroles


		#region owin_userstatuschangehistory
		[DebuggerStepThrough()]
		public override Iowin_userstatuschangehistoryDataAccessObjects Createowin_userstatuschangehistoryDataAccess()
		{
			string type = typeof(owin_userstatuschangehistoryDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new owin_userstatuschangehistoryDataAccessObjects(CurrentContext);
			}
			return (Iowin_userstatuschangehistoryDataAccessObjects)CurrentContext[type];
		}
		#endregion owin_userstatuschangehistory


		#region reg_basicinfo
		[DebuggerStepThrough()]
		public override Ireg_basicinfoDataAccessObjects Createreg_basicinfoDataAccess()
		{
			string type = typeof(reg_basicinfoDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new reg_basicinfoDataAccessObjects(CurrentContext);
			}
			return (Ireg_basicinfoDataAccessObjects)CurrentContext[type];
		}
		#endregion reg_basicinfo


		#region reg_educationinfo
		[DebuggerStepThrough()]
		public override Ireg_educationinfoDataAccessObjects Createreg_educationinfoDataAccess()
		{
			string type = typeof(reg_educationinfoDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new reg_educationinfoDataAccessObjects(CurrentContext);
			}
			return (Ireg_educationinfoDataAccessObjects)CurrentContext[type];
		}
		#endregion reg_educationinfo


		#region reg_emergencycontactinfo
		[DebuggerStepThrough()]
		public override Ireg_emergencycontactinfoDataAccessObjects Createreg_emergencycontactinfoDataAccess()
		{
			string type = typeof(reg_emergencycontactinfoDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new reg_emergencycontactinfoDataAccessObjects(CurrentContext);
			}
			return (Ireg_emergencycontactinfoDataAccessObjects)CurrentContext[type];
		}
        #endregion reg_emergencycontactinfo

        #region reg_datachecked
        [DebuggerStepThrough()]
        public override Ireg_datacheckedDataAccessObjects Createreg_datacheckedDataAccess()
        {
            string type = typeof(reg_datacheckedDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new reg_datacheckedDataAccessObjects(CurrentContext);
            }
            return (Ireg_datacheckedDataAccessObjects)CurrentContext[type];
        }
        #endregion reg_datachecked

        #region reg_familly
        [DebuggerStepThrough()]
		public override Ireg_famillyDataAccessObjects Createreg_famillyDataAccess()
		{
			string type = typeof(reg_famillyDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new reg_famillyDataAccessObjects(CurrentContext);
			}
			return (Ireg_famillyDataAccessObjects)CurrentContext[type];
		}
		#endregion reg_familly


		#region reg_hobbies
		[DebuggerStepThrough()]
		public override Ireg_hobbiesDataAccessObjects Createreg_hobbiesDataAccess()
		{
			string type = typeof(reg_hobbiesDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new reg_hobbiesDataAccessObjects(CurrentContext);
			}
			return (Ireg_hobbiesDataAccessObjects)CurrentContext[type];
		}
		#endregion reg_hobbies


		#region reg_language
		[DebuggerStepThrough()]
		public override Ireg_languageDataAccessObjects Createreg_languageDataAccess()
		{
			string type = typeof(reg_languageDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new reg_languageDataAccessObjects(CurrentContext);
			}
			return (Ireg_languageDataAccessObjects)CurrentContext[type];
		}
		#endregion reg_language


		#region reg_nonkuwaitystatus
		[DebuggerStepThrough()]
		public override Ireg_nonkuwaitystatusDataAccessObjects Createreg_nonkuwaitystatusDataAccess()
		{
			string type = typeof(reg_nonkuwaitystatusDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new reg_nonkuwaitystatusDataAccessObjects(CurrentContext);
			}
			return (Ireg_nonkuwaitystatusDataAccessObjects)CurrentContext[type];
		}
		#endregion reg_nonkuwaitystatus


		#region reg_previousexperiance
		[DebuggerStepThrough()]
		public override Ireg_previousexperianceDataAccessObjects Createreg_previousexperianceDataAccess()
		{
			string type = typeof(reg_previousexperianceDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new reg_previousexperianceDataAccessObjects(CurrentContext);
			}
			return (Ireg_previousexperianceDataAccessObjects)CurrentContext[type];
		}
		#endregion reg_previousexperiance


		#region reg_punishment
		[DebuggerStepThrough()]
		public override Ireg_punishmentDataAccessObjects Createreg_punishmentDataAccess()
		{
			string type = typeof(reg_punishmentDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new reg_punishmentDataAccessObjects(CurrentContext);
			}
			return (Ireg_punishmentDataAccessObjects)CurrentContext[type];
		}
		#endregion reg_punishment


		#region reg_registrationinfo
		[DebuggerStepThrough()]
		public override Ireg_registrationinfoDataAccessObjects Createreg_registrationinfoDataAccess()
		{
			string type = typeof(reg_registrationinfoDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new reg_registrationinfoDataAccessObjects(CurrentContext);
			}
			return (Ireg_registrationinfoDataAccessObjects)CurrentContext[type];
		}
		#endregion reg_registrationinfo


		#region reg_relativesworkinginmod
		[DebuggerStepThrough()]
		public override Ireg_relativesworkinginmodDataAccessObjects Createreg_relativesworkinginmodDataAccess()
		{
			string type = typeof(reg_relativesworkinginmodDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new reg_relativesworkinginmodDataAccessObjects(CurrentContext);
			}
			return (Ireg_relativesworkinginmodDataAccessObjects)CurrentContext[type];
		}
		#endregion reg_relativesworkinginmod


		#region reg_studentfilestorage
		[DebuggerStepThrough()]
		public override Ireg_studentfilestorageDataAccessObjects Createreg_studentfilestorageDataAccess()
		{
			string type = typeof(reg_studentfilestorageDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new reg_studentfilestorageDataAccessObjects(CurrentContext);
			}
			return (Ireg_studentfilestorageDataAccessObjects)CurrentContext[type];
		}
		#endregion reg_studentfilestorage


		#region stp_organization
		[DebuggerStepThrough()]
		public override Istp_organizationDataAccessObjects Createstp_organizationDataAccess()
		{
			string type = typeof(stp_organizationDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new stp_organizationDataAccessObjects(CurrentContext);
			}
			return (Istp_organizationDataAccessObjects)CurrentContext[type];
		}
		#endregion stp_organization


		#region stp_organizationentity
		[DebuggerStepThrough()]
		public override Istp_organizationentityDataAccessObjects Createstp_organizationentityDataAccess()
		{
			string type = typeof(stp_organizationentityDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new stp_organizationentityDataAccessObjects(CurrentContext);
			}
			return (Istp_organizationentityDataAccessObjects)CurrentContext[type];
		}
		#endregion stp_organizationentity


		#region stp_organizationentitytype
		[DebuggerStepThrough()]
		public override Istp_organizationentitytypeDataAccessObjects Createstp_organizationentitytypeDataAccess()
		{
			string type = typeof(stp_organizationentitytypeDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new stp_organizationentitytypeDataAccessObjects(CurrentContext);
			}
			return (Istp_organizationentitytypeDataAccessObjects)CurrentContext[type];
		}
        #endregion stp_organizationentitytype

        #region tran_applicantbatchchange
        [DebuggerStepThrough()]
        public override Itran_applicantbatchchangeDataAccessObjects Createtran_applicantbatchchangeDataAccess()
        {
            string type = typeof(tran_applicantbatchchangeDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new tran_applicantbatchchangeDataAccessObjects(CurrentContext);
            }
            return (Itran_applicantbatchchangeDataAccessObjects)CurrentContext[type];
        }
        #endregion tran_applicantbatchchange

        #region tran_applicantphases
        [DebuggerStepThrough()]
		public override Itran_applicantphasesDataAccessObjects Createtran_applicantphasesDataAccess()
		{
			string type = typeof(tran_applicantphasesDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new tran_applicantphasesDataAccessObjects(CurrentContext);
			}
			return (Itran_applicantphasesDataAccessObjects)CurrentContext[type];
		}
        #endregion tran_applicantphases

        #region tran_applicantresultexpire
        [DebuggerStepThrough()]
        public override Itran_applicantresultexpireDataAccessObjects Createtran_applicantresultexpireDataAccess()
        {
            string type = typeof(tran_applicantresultexpireDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new tran_applicantresultexpireDataAccessObjects(CurrentContext);
            }
            return (Itran_applicantresultexpireDataAccessObjects)CurrentContext[type];
        }
        #endregion tran_applicantresultexpire

        #region tran_applicantretestapproval
        [DebuggerStepThrough()]
        public override Itran_applicantretestapprovalDataAccessObjects Createtran_applicantretestapprovalDataAccess()
        {
            string type = typeof(tran_applicantretestapprovalDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new tran_applicantretestapprovalDataAccessObjects(CurrentContext);
            }
            return (Itran_applicantretestapprovalDataAccessObjects)CurrentContext[type];
        }
        #endregion tran_applicantretestapproval

        #region tran_applyanotherbatch
        [DebuggerStepThrough()]
        public override Itran_applyanotherbatchDataAccessObjects Createtran_applyanotherbatchDataAccess()
        {
            string type = typeof(tran_applyanotherbatchDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new tran_applyanotherbatchDataAccessObjects(CurrentContext);
            }
            return (Itran_applyanotherbatchDataAccessObjects)CurrentContext[type];
        }
        #endregion tran_applyanotherbatch

        #region tran_auditresult
        [DebuggerStepThrough()]
        public override Itran_auditresultDataAccessObjects Createtran_auditresultDataAccess()
        {
            string type = typeof(tran_auditresultDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new tran_auditresultDataAccessObjects(CurrentContext);
            }
            return (Itran_auditresultDataAccessObjects)CurrentContext[type];
        }
        #endregion tran_auditresult

        #region tran_centralagencysyresult
        [DebuggerStepThrough()]
        public override Itran_centralagencysyresultDataAccessObjects Createtran_centralagencysyresultDataAccess()
        {
            string type = typeof(tran_centralagencysyresultDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new tran_centralagencysyresultDataAccessObjects(CurrentContext);
            }
            return (Itran_centralagencysyresultDataAccessObjects)CurrentContext[type];
        }
        #endregion tran_centralagencysyresult

        #region tran_exportprofile
        [DebuggerStepThrough()]
		public override Itran_exportprofileDataAccessObjects Createtran_exportprofileDataAccess()
		{
			string type = typeof(tran_exportprofileDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new tran_exportprofileDataAccessObjects(CurrentContext);
			}
			return (Itran_exportprofileDataAccessObjects)CurrentContext[type];
		}
        #endregion tran_exportprofile

        #region tran_finalexamresult
        [DebuggerStepThrough()]
        public override Itran_finalexamresultDataAccessObjects Createtran_finalexamresultDataAccess()
        {
            string type = typeof(tran_finalexamresultDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new tran_finalexamresultDataAccessObjects(CurrentContext);
            }
            return (Itran_finalexamresultDataAccessObjects)CurrentContext[type];
        }
        #endregion tran_finalexamresult

        #region tran_finalexamnotification
        [DebuggerStepThrough()]
        public override Itran_finalexamnotificationDataAccessObjects Createtran_finalexamnotificationDataAccess()
        {
            string type = typeof(tran_finalexamnotificationDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new tran_finalexamnotificationDataAccessObjects(CurrentContext);
            }
            return (tran_finalexamnotificationDataAccessObjects)CurrentContext[type];
        }
        #endregion tran_medexamnotification

        #region tran_login
        [DebuggerStepThrough()]
		public override Itran_loginDataAccessObjects Createtran_loginDataAccess()
		{
			string type = typeof(tran_loginDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new tran_loginDataAccessObjects(CurrentContext);
			}
			return (Itran_loginDataAccessObjects)CurrentContext[type];
		}
        #endregion tran_login

        #region tran_medexamnotification
        [DebuggerStepThrough()]
        public override Itran_medexamnotificationDataAccessObjects Createtran_medexamnotificationDataAccess()
        {
            string type = typeof(tran_medexamnotificationDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new tran_medexamnotificationDataAccessObjects(CurrentContext);
            }
            return (Itran_medexamnotificationDataAccessObjects)CurrentContext[type];
        }
        #endregion tran_medexamnotification

        #region tran_medexamresult
        [DebuggerStepThrough()]
        public override Itran_medexamresultDataAccessObjects Createtran_medexamresultDataAccess()
        {
            string type = typeof(tran_medexamresultDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new tran_medexamresultDataAccessObjects(CurrentContext);
            }
            return (Itran_medexamresultDataAccessObjects)CurrentContext[type];
        }
        #endregion tran_medexamresult

        #region tran_notificationbatch
        [DebuggerStepThrough()]
		public override Itran_notificationbatchDataAccessObjects Createtran_notificationbatchDataAccess()
		{
			string type = typeof(tran_notificationbatchDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new tran_notificationbatchDataAccessObjects(CurrentContext);
			}
			return (Itran_notificationbatchDataAccessObjects)CurrentContext[type];
		}
		#endregion tran_notificationbatch


		#region tran_notificationbatchdet
		[DebuggerStepThrough()]
		public override Itran_notificationbatchdetDataAccessObjects Createtran_notificationbatchdetDataAccess()
		{
			string type = typeof(tran_notificationbatchdetDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new tran_notificationbatchdetDataAccessObjects(CurrentContext);
			}
			return (Itran_notificationbatchdetDataAccessObjects)CurrentContext[type];
		}
        #endregion tran_notificationbatchdet

        #region tran_notificationfile
        [DebuggerStepThrough()]
        public override Itran_notificationfileDataAccessObjects Createtran_notificationfileDataAccess()
        {
            string type = typeof(tran_notificationfileDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new tran_notificationfileDataAccessObjects(CurrentContext);
            }
            return (Itran_notificationfileDataAccessObjects)CurrentContext[type];
        }
        #endregion tran_notificationfile


        #region tran_notificationfiledet
        [DebuggerStepThrough()]
        public override Itran_notificationfiledetDataAccessObjects Createtran_notificationfiledetDataAccess()
        {
            string type = typeof(tran_notificationfiledetDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new tran_notificationfiledetDataAccessObjects(CurrentContext);
            }
            return (Itran_notificationfiledetDataAccessObjects)CurrentContext[type];
        }
        #endregion tran_notificationbatchdet

        #region tran_psychoexamresult
        [DebuggerStepThrough()]
        public override Itran_psychoexamresultDataAccessObjects Createtran_psychoexamresultDataAccess()
        {
            string type = typeof(tran_psychoexamresultDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new tran_psychoexamresultDataAccessObjects(CurrentContext);
            }
            return (Itran_psychoexamresultDataAccessObjects)CurrentContext[type];
        }
        #endregion tran_psychoexamresult

        #region tran_rollbackinfo
        [DebuggerStepThrough()]
		public override Itran_rollbackinfoDataAccessObjects Createtran_rollbackinfoDataAccess()
		{
			string type = typeof(tran_rollbackinfoDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new tran_rollbackinfoDataAccessObjects(CurrentContext);
			}
			return (Itran_rollbackinfoDataAccessObjects)CurrentContext[type];
		}
		#endregion tran_rollbackinfo


		#region tran_specialregistration
		[DebuggerStepThrough()]
		public override Itran_specialregistrationDataAccessObjects Createtran_specialregistrationDataAccess()
		{
			string type = typeof(tran_specialregistrationDataAccessObjects).ToString();
			if (!CurrentContext.Contains(type))
			{
				CurrentContext[type] = new tran_specialregistrationDataAccessObjects(CurrentContext);
			}
			return (Itran_specialregistrationDataAccessObjects)CurrentContext[type];
		}
        #endregion tran_specialregistration

        #region tran_syexamnotification
        [DebuggerStepThrough()]
        public override Itran_syexamnotificationDataAccessObjects Createtran_syexamnotificationDataAccess()
        {
            string type = typeof(tran_syexamnotificationDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new tran_syexamnotificationDataAccessObjects(CurrentContext);
            }
            return (Itran_syexamnotificationDataAccessObjects)CurrentContext[type];
        }
        #endregion tran_syexamnotification

        #region tran_syexamresult
        [DebuggerStepThrough()]
        public override Itran_syexamresultDataAccessObjects Createtran_syexamresultDataAccess()
        {
            string type = typeof(tran_syexamresultDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new tran_syexamresultDataAccessObjects(CurrentContext);
            }
            return (Itran_syexamresultDataAccessObjects)CurrentContext[type];
        }
        #endregion tran_syexamresult

        #region tran_trainingjoin
        [DebuggerStepThrough()]
        public override Itran_trainingjoinDataAccessObjects Createtran_trainingjoinDataAccess()
        {
            string type = typeof(tran_trainingjoinDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new tran_trainingjoinDataAccessObjects(CurrentContext);
            }
            return (Itran_trainingjoinDataAccessObjects)CurrentContext[type];
        }
        #endregion tran_trainingjoin

        #region tran_trainingjoinnotification
        [DebuggerStepThrough()]
        public override Itran_trainingjoinnotificationDataAccessObjects Createtran_trainingjoinnotificationDataAccess()
        {
            string type = typeof(tran_trainingjoinnotificationDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new tran_trainingjoinnotificationDataAccessObjects(CurrentContext);
            }
            return (Itran_trainingjoinnotificationDataAccessObjects)CurrentContext[type];
        }
        #endregion tran_medexamnotification

        #region tran_unitclearanceresult
        [DebuggerStepThrough()]
        public override Itran_unitclearanceresultDataAccessObjects Createtran_unitclearanceresultDataAccess()
        {
            string type = typeof(tran_unitclearanceresultDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new tran_unitclearanceresultDataAccessObjects(CurrentContext);
            }
            return (Itran_unitclearanceresultDataAccessObjects)CurrentContext[type];
        }
        #endregion tran_unitclearanceresult

        #region tran_volunteermedclearance
        [DebuggerStepThrough()]
        public override Itran_volunteermedclearanceDataAccessObjects Createtran_volunteermedclearanceDataAccess()
        {
            string type = typeof(tran_volunteermedclearanceDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new tran_volunteermedclearanceDataAccessObjects(CurrentContext);
            }
            return (Itran_volunteermedclearanceDataAccessObjects)CurrentContext[type];
        }
        #endregion tran_volunteermedclearance


        #region tran_volunteersyclearance
        [DebuggerStepThrough()]
        public override Itran_volunteersyclearanceDataAccessObjects Createtran_volunteersyclearanceDataAccess()
        {
            string type = typeof(tran_volunteersyclearanceDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new tran_volunteersyclearanceDataAccessObjects(CurrentContext);
            }
            return (Itran_volunteersyclearanceDataAccessObjects)CurrentContext[type];
        }
        #endregion tran_volunteersyclearance


        #region tran_volunteerunitclearance
        [DebuggerStepThrough()]
        public override Itran_volunteerunitclearanceDataAccessObjects Createtran_volunteerunitclearanceDataAccess()
        {
            string type = typeof(tran_volunteerunitclearanceDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new tran_volunteerunitclearanceDataAccessObjects(CurrentContext);
            }
            return (Itran_volunteerunitclearanceDataAccessObjects)CurrentContext[type];
        }
        #endregion tran_volunteerunitclearance

        #endregion Factory Methods 

    }
}
