
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
    public sealed partial class reg_educationinfoFacadeObjects
    {
		
       async Task<long> Ireg_educationinfoFacadeObjects.AddExt(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_educationinfoDataAccess().AddExt(reg_educationinfo, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_educationinfoFacade.Addreg_educationinfo"));
            }
		}
       
		async Task<IList<reg_educationinfoEntity>> Ireg_educationinfoFacadeObjects.GetAllExt(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_educationinfoDataAccess().GetAllExt(reg_educationinfo, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_educationinfoEntity> Ireg_educationinfoFacade.GetAllreg_educationinfo"));
            }
		}

        async Task<IList<reg_educationinfoEntity>> Ireg_educationinfoFacadeObjects.GetAllByBasicInfoID(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_educationinfoDataAccess().GetAllByBasicInfoID(reg_educationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_educationinfoEntity> Ireg_educationinfoFacade.GAPgListViewreg_educationinfo"));
            }
        }

        async Task<reg_educationinfoEntity> Ireg_educationinfoFacadeObjects.GetSingleById(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_educationinfoDataAccess().GetSingleById(reg_educationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_educationinfoEntity Ireg_educationinfoFacade.GetSinglereg_educationinfo"));
            }
        }


        async Task<long> Ireg_educationinfoFacadeObjects.AddOrUpdate(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_educationinfoDataAccess().AddOrUpdate(reg_educationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_educationinfoFacade.Addreg_educationinfo"));
            }
        }

        async Task<long> Ireg_educationinfoFacadeObjects.ApllicantReviewEducationInfoSaveorUpdate(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_educationinfoDataAccess().ApllicantReviewEducationInfoSaveorUpdate(reg_educationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_educationinfoFacade.ApllicantReviewEducationInfoSaveorUpdatereg_educationinfo"));
            }
        }

        async Task<long> Ireg_educationinfoFacadeObjects.DeleteWithAttachment(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_educationinfoDataAccess().DeleteWithAttachment(reg_educationinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_educationinfoFacade.Deletereg_educationinfo"));
            }
        }


    }
}