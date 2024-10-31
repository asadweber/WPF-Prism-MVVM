
using AppConfig.ConfigDAAC;
using BDO.Core.Base;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.DataAccessObjects.VCApplicantReview;
using BDO.DataAccessObjects.VCRegistration;
using BDO.Report;
using BFO.Base;
using DAC.Core.CoreFactory;
using IBFO.Core.IBusinessFacadeObjects.General;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;


namespace BFO.Core.BusinessFacadeObjects.General
{
    public sealed partial class reg_basicinfoFacadeObjects
    {

        async Task<long> Ireg_basicinfoFacadeObjects.AddExt(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_basicinfoDataAccess().AddExt(reg_basicinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_basicinfoFacade.Addreg_basicinfo"));
            }
        }

        async Task<IList<reg_basicinfoEntity>> Ireg_basicinfoFacadeObjects.GetAllExt(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_basicinfoDataAccess().GetAllExt(reg_basicinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_basicinfoEntity> Ireg_basicinfoFacade.GetAllreg_basicinfo"));
            }
        }

        async Task<RegistrationViewModel> Ireg_basicinfoFacadeObjects.GetRegisteredApplicantProfileDataByCivilId(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_basicinfoDataAccess().GetRegisteredApplicantProfileDataByCivilId(reg_basicinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_basicinfoEntity> Ireg_basicinfoFacade.GetRegisteredApplicantProfileDataByCivilId"));
            }
        }

        async Task<RegistrationViewModel> Ireg_basicinfoFacadeObjects.GetRegistrationDetailsByCivilId(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_basicinfoDataAccess().GetRegistrationDetailsByCivilId(reg_basicinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_basicinfoEntity> Ireg_basicinfoFacade.GetRegistrationDetailsByCivilId"));
            }
        }

        async Task<RegistrationViewModel> Ireg_basicinfoFacadeObjects.GetRegisteredApplicantProfileDataByCivilIdForDelete(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_basicinfoDataAccess().GetRegisteredApplicantProfileDataByCivilIdForDelete(reg_basicinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_basicinfoEntity> Ireg_basicinfoFacade.GetRegisteredApplicantProfileDataByCivilIdForDelete"));
            }
        }

        async Task<reg_basicinfoEntity> Ireg_basicinfoFacadeObjects.ValidateMobileNumber(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_basicinfoDataAccess().ValidateMobileNumber(reg_basicinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_basicinfoEntity Ireg_basicinfoFacade.GetSinglereg_basicinfo"));
            }
        }

        async Task<reg_basicinfoEntity> Ireg_basicinfoFacadeObjects.ValidateEmailAddress(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_basicinfoDataAccess().ValidateEmailAddress(reg_basicinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_basicinfoEntity Ireg_basicinfoFacade.ValidateEmailAddress"));
            }
        }

        async Task<reg_basicinfoEntity> Ireg_basicinfoFacadeObjects.ValidateCivilIdPolicy(string CivilId, long? BatchId, System.Threading.CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_basicinfoDataAccess().ValidateCivilIdPolicy(CivilId, BatchId, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_basicinfoEntity Ireg_basicinfoFacade.ValidateCivilIdPolicy"));
            }
        }


        async Task<long> Ireg_basicinfoFacadeObjects.SavePreRegistration(RegistrationViewModel request, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_basicinfoDataAccess().SavePreRegistration(request, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_basicinfoFacade.SavePreRegistration"));
            }
        }
        async Task<long> Ireg_basicinfoFacadeObjects.SubmitFinalRegistration(RegistrationViewModel request, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_basicinfoDataAccess().SubmitFinalRegistration(request, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_basicinfoFacade.SavePreRegistration"));
            }
        }

        async Task<IList<reg_basicinfoEntity>> Ireg_basicinfoFacadeObjects.GetAllRegBasicInfoByMultipleBasicID(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_basicinfoDataAccess().GetAllRegBasicInfoByMultipleBasicID(reg_basicinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_basicinfoEntity> Ireg_basicinfoFacade.GetAllRegBasicInfoByMultipleBasicIDreg_basicinfo"));
            }
        }

        async Task<long> Ireg_basicinfoFacadeObjects.RollbackFinalSubmit(RegistrationViewModel request, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_basicinfoDataAccess().RollbackFinalSubmit(request, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_basicinfoFacade.RollbackFinalSubmit"));
            }
        }


        async Task<ProfileReportEntity> Ireg_basicinfoFacadeObjects.GetRegistrationProfileDataWithDetailByBasicId(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_basicinfoDataAccess().GetRegistrationProfileDataWithDetailByBasicId(reg_basicinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_basicinfoEntity> Ireg_basicinfoFacade.GetRegistrationProfileDataWithDetailByBasicId"));
            }
        }

        //async Task<ProfileReportEntity> Ireg_basicinfoFacadeObjects.ShowApplicantListReport(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        //{
        //    try
        //    {
        //        return await DataAccessFactory.Createreg_basicinfoDataAccess().ShowApplicantListReport(reg_basicinfo, cancellationToken);
        //    }

        //    catch (Exception ex)
        //    {
        //        throw GetFacadeException(ex, SourceOfException("IList<reg_basicinfoEntity> Ireg_basicinfoFacade.ShowApplicantListReport"));
        //    }
        //}

        async Task<ApplicantReviewViewModel> Ireg_basicinfoFacadeObjects.GetRegisteredApplicantProfileDataByBasicInfoId(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_basicinfoDataAccess().GetRegisteredApplicantProfileDataByBasicInfoId(reg_basicinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_basicinfoEntity> Ireg_basicinfoFacade.GetRegisteredApplicantProfileDataByBasicInfoId"));
            }
        }


        async Task<RegistrationViewModel> Ireg_basicinfoFacadeObjects.GetRegisteredApplicantCurrentBatchDataByBasicId(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_basicinfoDataAccess().GetRegisteredApplicantCurrentBatchDataByBasicId(reg_basicinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_basicinfoEntity> Ireg_basicinfoFacade.GetRegisteredApplicantCurrentBatchDataByBasicId"));
            }
        }


        async Task<long> Ireg_basicinfoFacadeObjects.SaveApplicantReviewBasicInfo(ApplicantReviewViewModel request, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_basicinfoDataAccess().SaveApplicantReviewBasicInfo(request, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_basicinfoFacade.SaveApplicantReviewBasicInfo"));
            }
        }


        async Task<long> Ireg_basicinfoFacadeObjects.RegisterAnotherBatchSave(RegistrationViewModel request, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_basicinfoDataAccess().RegisterAnotherBatchSave(request, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_basicinfoFacade.RegisterAnotherBatchSave"));
            }
        }

        async Task<Reg_ApplicantDataCheckedEntity> Ireg_basicinfoFacadeObjects.GetRegistrationDataInfoStatusCheck(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_basicinfoDataAccess().GetRegistrationDataInfoStatusCheck(reg_basicinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_basicinfoEntity> Ireg_basicinfoFacade.GetRegistrationDataInfoStatusCheck"));
            }
        }

        async Task<long> Ireg_basicinfoFacadeObjects.DeleteApplicantbyBasicInfoID(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_basicinfoDataAccess().DeleteApplicantbyBasicInfoID(reg_basicinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_basicinfoFacade.DeleteApplicantbyBasicInfoIDreg_basicinfo"));
            }
        }

        async Task<long> Ireg_basicinfoFacadeObjects.UpdateApplicantContactInfo(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_basicinfoDataAccess().UpdateApplicantContactInfo(reg_basicinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_basicinfoFacade.UpdateApplicantContactInfo"));
            }
        }
    }
}