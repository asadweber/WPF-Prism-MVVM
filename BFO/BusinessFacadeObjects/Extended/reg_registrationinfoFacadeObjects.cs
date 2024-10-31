
using AppConfig.ConfigDAAC;
using BDO.Core.Base;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.DataAccessObjects.VCApplicantReview;
using BDO.Report;
using BFO.Base;
using DAC.Core.CoreFactory;
using IBFO.Core.IBusinessFacadeObjects.General;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;


namespace BFO.Core.BusinessFacadeObjects.General
{
    public sealed partial class reg_registrationinfoFacadeObjects
    {
		
       async Task<long> Ireg_registrationinfoFacadeObjects.AddExt(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_registrationinfoDataAccess().AddExt(reg_registrationinfo, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_registrationinfoFacade.Addreg_registrationinfo"));
            }
		}
       
		async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoFacadeObjects.GetAllExt(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_registrationinfoDataAccess().GetAllExt(reg_registrationinfo, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_registrationinfoEntity> Ireg_registrationinfoFacade.GetAllreg_registrationinfo"));
            }
		}

        async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoFacadeObjects.GetFinallySubmittedRegInfoListView(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().GetFinallySubmittedRegInfoListView(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_registrationinfoEntity> Ireg_registrationinfoFacade.GAPgListViewFinallySubmittedreg_registrationinfo"));
            }
        }

        async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoFacadeObjects.GetFinallySubmittedRegInfoListForReview(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().GetFinallySubmittedRegInfoListForReview(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_registrationinfoEntity> Ireg_registrationinfoFacade.GetFinallySubmittedRegInfoListForReviewreg_registrationinfo"));
            }
        }

        async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoFacadeObjects.GetRegInfoListForVolunteerSecurityClearance(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().GetRegInfoListForVolunteerSecurityClearance(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_registrationinfoEntity> Ireg_registrationinfoFacade.GetRegInfoListForVolunteerSecurityClearance"));
            }
        }

        async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoFacadeObjects.GetRegInfoListForCentralAgencySy(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().GetRegInfoListForCentralAgencySy(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_registrationinfoEntity> Ireg_registrationinfoFacade.GetRegInfoListForCentralAgencySy"));
            }
        }

        async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoFacadeObjects.GetRegInfoListForSecurityExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().GetRegInfoListForSecurityExam(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_registrationinfoEntity> Ireg_registrationinfoFacade.GetRegInfoListForSecurityExam"));
            }
        }

        async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoFacadeObjects.GetRegInfoListForSecurityReTestApproval(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().GetRegInfoListForSecurityReTestApproval(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_registrationinfoEntity> Ireg_registrationinfoFacade.GetRegInfoListForSecurityReTestApproval"));
            }
        }

        async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoFacadeObjects.GetRegInfoListForVolunteerUnitClearance(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().GetRegInfoListForVolunteerUnitClearance(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_registrationinfoEntity> Ireg_registrationinfoFacade.GetRegInfoListForVolunteerUnitClearance"));
            }
        }

        async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoFacadeObjects.GetRegInfoListForUnitClearance(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().GetRegInfoListForUnitClearance(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_registrationinfoEntity> Ireg_registrationinfoFacade.GetRegInfoListForUnitClearance"));
            }
        }

        async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoFacadeObjects.GetRegInfoListForVolunteerMedicalClearance(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().GetRegInfoListForVolunteerMedicalClearance(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_registrationinfoEntity> Ireg_registrationinfoFacade.GetRegInfoListForVolunteerMedicalClearance"));
            }
        }

        async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoFacadeObjects.GetRegInfoListForGeneralMedicalExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().GetRegInfoListForGeneralMedicalExam(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_registrationinfoEntity> Ireg_registrationinfoFacade.GetRegInfoListForGeneralMedicalExam"));
            }
        }

        async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoFacadeObjects.GetRegInfoListForPsychologyExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().GetRegInfoListForPsychologyExam(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_registrationinfoEntity> Ireg_registrationinfoFacade.GetRegInfoListForPsychologyExam"));
            }
        }

        async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoFacadeObjects.GetRegInfoListForFinalExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().GetRegInfoListForFinalExam(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_registrationinfoEntity> Ireg_registrationinfoFacade.GetRegInfoListForFinalExam"));
            }
        }

        async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoFacadeObjects.GetRegInfoListForTrainingJoin(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().GetRegInfoListForTrainingJoin(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_registrationinfoEntity> Ireg_registrationinfoFacade.GetRegInfoListForTrainingJoin"));
            }
        }

        async Task<ApplicantReviewViewModel> Ireg_registrationinfoFacadeObjects.GetApplicantDetailsByRegistrationIDForReview(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().GetApplicantDetailsByRegistrationIDForReview(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_registrationinfoEntity Ireg_registrationinfoFacade.GetApplicantDetailsByRegistrationIDForReviewreg_registrationinfo"));
            }
        }

        async Task<long> Ireg_registrationinfoFacadeObjects.ApplicantReviewAuditResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().ApplicantReviewAuditResultUpdate(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_registrationinfoFacade.ApplicantReviewAuditResultUpdate"));
            }
        }

        async Task<long> Ireg_registrationinfoFacadeObjects.ForwardSecurityExamination(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().ForwardSecurityExamination(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_registrationinfoFacade.ForwardSecurityExamination"));
            }
        }

        async Task<long> Ireg_registrationinfoFacadeObjects.GroupForwardSecurityExamination(List<reg_registrationinfoEntity> reg_registrationinfoList, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().GroupForwardSecurityExamination(reg_registrationinfoList, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_registrationinfoFacade.GroupForwardSecurityExamination"));
            }
        }

        async Task<long> Ireg_registrationinfoFacadeObjects.ApproveSecurityExaminationReTest(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().ApproveSecurityExaminationReTest(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_registrationinfoFacade.ApproveSecurityExaminationReTest"));
            }
        }

        async Task<long> Ireg_registrationinfoFacadeObjects.GroupApproveSecurityExaminationReTest(List<reg_registrationinfoEntity> reg_registrationinfoList, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().GroupApproveSecurityExaminationReTest(reg_registrationinfoList, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_registrationinfoFacade.GroupApproveSecurityExaminationReTest"));
            }
        }

        async Task<long> Ireg_registrationinfoFacadeObjects.SecurityExaminationResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().SecurityExaminationResultUpdate(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_registrationinfoFacade.SecurityExaminationResultUpdate"));
            }
        }

        async Task<long> Ireg_registrationinfoFacadeObjects.CentralAgencySyResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().CentralAgencySyResultUpdate(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_registrationinfoFacade.CentralAgencySyResultUpdate"));
            }
        }

        async Task<long> Ireg_registrationinfoFacadeObjects.ForwardUnitClearance(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().ForwardUnitClearance(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_registrationinfoFacade.ForwardUnitClearance"));
            }
        }

        async Task<long> Ireg_registrationinfoFacadeObjects.GroupForwardUnitClearance(List<reg_registrationinfoEntity> reg_registrationinfoList, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().GroupForwardUnitClearance(reg_registrationinfoList, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_registrationinfoFacade.GroupForwardUnitClearance"));
            }
        }

        async Task<long> Ireg_registrationinfoFacadeObjects.UnitClearanceResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().UnitClearanceResultUpdate(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_registrationinfoFacade.UnitClearanceResultUpdate"));
            }
        }

        async Task<long> Ireg_registrationinfoFacadeObjects.ForwardMedicalClearance(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().ForwardMedicalClearance(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_registrationinfoFacade.ForwardMedicalClearance"));
            }
        }

        async Task<long> Ireg_registrationinfoFacadeObjects.GroupForwardMedicalClearance(List<reg_registrationinfoEntity> reg_registrationinfoList, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().GroupForwardMedicalClearance(reg_registrationinfoList, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_registrationinfoFacade.GroupForwardMedicalClearance"));
            }
        }

        async Task<long> Ireg_registrationinfoFacadeObjects.GeneralMedicalExaminationResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().GeneralMedicalExaminationResultUpdate(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_registrationinfoFacade.GeneralMedicalExaminationResultUpdate"));
            }
        }

        async Task<long> Ireg_registrationinfoFacadeObjects.PsychologyExaminationResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().PsychologyExaminationResultUpdate(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_registrationinfoFacade.PsychologyExaminationResultUpdate"));
            }
        }

        async Task<long> Ireg_registrationinfoFacadeObjects.FinalExaminationResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().FinalExaminationResultUpdate(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_registrationinfoFacade.FinalExaminationResultUpdate"));
            }
        }

        async Task<long> Ireg_registrationinfoFacadeObjects.TrainingJoinResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().TrainingJoinResultUpdate(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_registrationinfoFacade.TrainingJoinResultUpdate"));
            }
        }

        async Task<reg_registrationinfoEntity> Ireg_registrationinfoFacadeObjects.GetSingleRegistrationInfoforSecurityExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().GetSingleRegistrationInfoforSecurityExam(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_registrationinfoEntity Ireg_registrationinfoFacade.GetSingleRegistrationInfoforSecurityExam"));
            }
        }

        async Task<reg_registrationinfoEntity> Ireg_registrationinfoFacadeObjects.GetSingleRegistrationInfoforUnitClearance(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().GetSingleRegistrationInfoforUnitClearance(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_registrationinfoEntity Ireg_registrationinfoFacade.GetSingleRegistrationInfoforUnitClearance"));
            }
        }

        async Task<reg_registrationinfoEntity> Ireg_registrationinfoFacadeObjects.GetSingleRegistrationInfoforGeneralMedicalExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().GetSingleRegistrationInfoforGeneralMedicalExam(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_registrationinfoEntity Ireg_registrationinfoFacade.GetSingleRegistrationInfoforGeneralMedicalExam"));
            }
        }

        async Task<reg_registrationinfoEntity> Ireg_registrationinfoFacadeObjects.GetSingleRegistrationInfoforPsychologyExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().GetSingleRegistrationInfoforPsychologyExam(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_registrationinfoEntity Ireg_registrationinfoFacade.GetSingleRegistrationInfoforPsychologyExam"));
            }
        }

        async Task<reg_registrationinfoEntity> Ireg_registrationinfoFacadeObjects.GetSingleRegistrationInfoforFinalExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().GetSingleRegistrationInfoforFinalExam(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_registrationinfoEntity Ireg_registrationinfoFacade.GetSingleRegistrationInfoforFinalExam"));
            }
        }

        async Task<reg_registrationinfoEntity> Ireg_registrationinfoFacadeObjects.GetSingleRegistrationInfoforTrainingJoin(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().GetSingleRegistrationInfoforTrainingJoin(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_registrationinfoEntity Ireg_registrationinfoFacade.GetSingleRegistrationInfoforTrainingJoin"));
            }
        }

        async Task<ProfileReportEntity> Ireg_registrationinfoFacadeObjects.getApplicationList(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().getApplicationList(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_registrationinfoEntity Ireg_registrationinfoFacade.GetSingleRegistrationInfoforSecurityExam"));
            }
        }

        async Task<ProfileReportEntity> Ireg_registrationinfoFacadeObjects.getApplicationStatus(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().getApplicationStatus(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_registrationinfoEntity Ireg_registrationinfoFacade.GetSingleRegistrationInfoforSecurityExam"));
            }
        }


        
            async Task<ProfileReportEntity> Ireg_registrationinfoFacadeObjects.getApplicationAssessmentList(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().getApplicationAssessmentList(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_registrationinfoEntity Ireg_registrationinfoFacade.GetSingleRegistrationInfoforSecurityExam"));
            }
        }



        async Task<ProfileReportEntity> Ireg_registrationinfoFacadeObjects.getApplicantAudit(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().getApplicantAudit(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_registrationinfoEntity Ireg_registrationinfoFacade.GetSingleRegistrationInfoforSecurityExam"));
            }
        }

        async Task<ProfileReportEntity> Ireg_registrationinfoFacadeObjects.getApplicantAllDataBasic(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().getApplicantAllDataBasic(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_registrationinfoEntity Ireg_registrationinfoFacade.GetSingleRegistrationInfoforSecurityExam"));
            }
        }


        async Task<ProfileReportEntity> Ireg_registrationinfoFacadeObjects.getApplicantSmsStatus(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().getApplicantSmsStatus(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_registrationinfoEntity Ireg_registrationinfoFacade.GetSingleRegistrationInfoforSecurityExam"));
            }
        }

        async Task<ProfileReportEntity> Ireg_registrationinfoFacadeObjects.getMedicalExamForm(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().getMedicalExamForm(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_registrationinfoEntity Ireg_registrationinfoFacade.GetSingleRegistrationInfoforSecurityExam"));
            }
        }

        async Task<ProfileReportEntity> Ireg_registrationinfoFacadeObjects.getMedicalExamReport(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().getMedicalExamReport(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_registrationinfoEntity Ireg_registrationinfoFacade.GetSingleRegistrationInfoforSecurityExam"));
            }
        }


        async Task<ProfileReportEntity> Ireg_registrationinfoFacadeObjects.getVolunteerTestExtForm(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().getVolunteerTestExtForm(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_registrationinfoEntity Ireg_registrationinfoFacade.GetSingleRegistrationInfoforSecurityExam"));
            }
        }


        async Task<ProfileReportEntity> Ireg_registrationinfoFacadeObjects.getBatchSummaryRpt(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().getBatchSummaryRpt(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_registrationinfoEntity Ireg_registrationinfoFacade.GetSingleRegistrationInfoforSecurityExam"));
            }
        }

        async Task<ProfileReportEntity> Ireg_registrationinfoFacadeObjects.getBatchSummaryDetail(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().getBatchSummaryDetail(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_registrationinfoEntity Ireg_registrationinfoFacade.GetSingleRegistrationInfoforSecurityExam"));
            }
        }

        async Task<ProfileReportEntity> Ireg_registrationinfoFacadeObjects.getVolunteerClearance(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().getVolunteerClearance(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_registrationinfoEntity Ireg_registrationinfoFacade.GetSingleRegistrationInfoforSecurityExam"));
            }
        }

        async Task<ProfileReportEntity> Ireg_registrationinfoFacadeObjects.getVolunteerExamLog(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().getVolunteerExamLog(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_registrationinfoEntity Ireg_registrationinfoFacade.GetSingleRegistrationInfoforSecurityExam"));
            }
        }

        async Task<ProfileReportEntity> Ireg_registrationinfoFacadeObjects.getVolunteerCertificateInfo(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().getVolunteerCertificateInfo(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_registrationinfoEntity Ireg_registrationinfoFacade.GetSingleRegistrationInfoforSecurityExam"));
            }
        }

        async Task<long> Ireg_registrationinfoFacadeObjects.UpdateSyPrintProfile(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().UpdateSyPrintProfile(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_registrationinfoFacade.UpdateSyPrintProfile"));
            }
        }

        async Task<long> Ireg_registrationinfoFacadeObjects.UpdateMedExamFormPrint(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().UpdateMedExamFormPrint(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_registrationinfoFacade.UpdateMedExamFormPrint"));
            }
        }

        //async Task<ProfileReportEntity> Ireg_registrationinfoFacadeObjects.getMedExaSmsStatus(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        //{
        //    try
        //    {
        //        return await DataAccessFactory.Createreg_registrationinfoDataAccess().getMedicalExamForm(reg_registrationinfo, cancellationToken);
        //    }

        //    catch (Exception ex)
        //    {
        //        throw GetFacadeException(ex, SourceOfException("reg_registrationinfoEntity Ireg_registrationinfoFacade.GetSingleRegistrationInfoforSecurityExam"));
        //    }
        //}

        async Task<ProfileReportEntity> Ireg_registrationinfoFacadeObjects.getMedExaSmsStatus(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().getMedExaSmsStatus(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_registrationinfoEntity Ireg_registrationinfoFacade.GetSingleRegistrationInfoforSecurityExam"));
            }
        }

        async Task<ProfileReportEntity> Ireg_registrationinfoFacadeObjects.getFinalExaSmsStatus(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().getFinalExaSmsStatus(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_registrationinfoEntity Ireg_registrationinfoFacade.GetSingleRegistrationInfoforSecurityExam"));
            }
        }

        async Task<ProfileReportEntity> Ireg_registrationinfoFacadeObjects.getTrainingJoinSmsStatus(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().getTrainingJoinSmsStatus(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_registrationinfoEntity Ireg_registrationinfoFacade.GetSingleRegistrationInfoforSecurityExam"));
            }
        }



        async Task<ProfileReportEntity> Ireg_registrationinfoFacadeObjects.getVolunteerContract(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().getVolunteerContract(reg_registrationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_registrationinfoEntity Ireg_registrationinfoFacade.GetSingleRegistrationInfoforSecurityExam"));
            }
        }


    }
}