
using AppConfig.ConfigDAAC;
using BDO.Core.Base;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
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
    public sealed partial class reg_emergencycontactinfoFacadeObjects
    {
		
       async Task<long> Ireg_emergencycontactinfoFacadeObjects.AddExt(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_emergencycontactinfoDataAccess().AddExt(reg_emergencycontactinfo, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_emergencycontactinfoFacade.Addreg_emergencycontactinfo"));
            }
		}
       
		async Task<IList<reg_emergencycontactinfoEntity>> Ireg_emergencycontactinfoFacadeObjects.GetAllExt(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_emergencycontactinfoDataAccess().GetAllExt(reg_emergencycontactinfo, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_emergencycontactinfoEntity> Ireg_emergencycontactinfoFacade.GetAllreg_emergencycontactinfo"));
            }
		}

		async Task<long> Ireg_emergencycontactinfoFacadeObjects.AddOrUpdate(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_emergencycontactinfoDataAccess().AddOrUpdate(reg_emergencycontactinfo, cancellationToken);
			}

			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("Ireg_emergencycontactinfoFacade.Addreg_emergencycontactinfo"));
			}
		}

        async Task<long> Ireg_emergencycontactinfoFacadeObjects.ApplicantReviewAddOrUpdate(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_emergencycontactinfoDataAccess().ApplicantReviewAddOrUpdate(reg_emergencycontactinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_emergencycontactinfoFacade.ApplicantReviewAddOrUpdate"));
            }
        }


        async Task<reg_emergencycontactinfoEntity> Ireg_emergencycontactinfoFacadeObjects.GetSingleById(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_emergencycontactinfoDataAccess().GetSingleById(reg_emergencycontactinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_emergencycontactinfoEntity Ireg_emergencycontactinfoFacade.GetSinglereg_emergencycontactinfo"));
            }
        }

        async Task<long> Ireg_emergencycontactinfoFacadeObjects.DeleteRegEmgContactInfoWithRelativesWorkingInMOD(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_emergencycontactinfoDataAccess().DeleteRegEmgContactInfoWithRelativesWorkingInMOD(reg_emergencycontactinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_emergencycontactinfoFacade.Deletereg_emergencycontactinfo"));
            }
        }

    }
}