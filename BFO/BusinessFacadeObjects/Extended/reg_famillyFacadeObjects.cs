
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
    public sealed partial class reg_famillyFacadeObjects
    {
        async Task<reg_famillyEntity> Ireg_famillyFacadeObjects.GetSingleByIdWithDocument(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_famillyDataAccess().GetSingleByIdWithDocument(reg_familly, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_famillyEntity Ireg_famillyFacade.GetSinglereg_familly"));
            }
        }
        async Task<long> Ireg_famillyFacadeObjects.AddExt(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_famillyDataAccess().AddExt(reg_familly, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_famillyFacade.Addreg_familly"));
            }
		}
       
		async Task<IList<reg_famillyEntity>> Ireg_famillyFacadeObjects.GetAllExt(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_famillyDataAccess().GetAllExt(reg_familly, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_famillyEntity> Ireg_famillyFacade.GetAllreg_familly"));
            }
		}
        async Task<long> Ireg_famillyFacadeObjects.SaveUpdate(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_famillyDataAccess().SaveUpdateExt(reg_familly, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_famillyFacade.Updatereg_familly"));
            }
        }

        async Task<long> Ireg_famillyFacadeObjects.ApplicantReviewSaveUpdate(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_famillyDataAccess().ApplicantReviewSaveUpdate(reg_familly, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_famillyFacade.ApplicantReviewSaveUpdatereg_familly"));
            }
        }

        //async Task<IList<reg_famillyEntity>> Ireg_famillyFacadeObjects.CheckHasSpouce(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
        //{
        //    try
        //    {
        //        return await DataAccessFactory.Createreg_famillyDataAccess().CheckHasSpouce(reg_familly, cancellationToken);
        //    }

        //    catch (Exception ex)
        //    {
        //        throw GetFacadeException(ex, SourceOfException("IList<reg_famillyEntity> Ireg_famillyFacade.GetAllByPagesreg_familly"));
        //    }
        //}
        async Task<IList<reg_famillyEntity>> Ireg_famillyFacadeObjects.GetAllSpouseByPage(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_famillyDataAccess().GetAllSpouseByPage(reg_familly, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_famillyEntity> Ireg_famillyFacade.GetAllByPagesreg_familly"));
            }
        }

        async Task<long> Ireg_famillyFacadeObjects.DeleteByFamilityId(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_famillyDataAccess().DeleteByFamilityId(reg_familly, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_famillyFacade.Deletereg_familly"));
            }
        }

        async Task<IList<reg_famillyEntity>> Ireg_famillyFacadeObjects.GetFamilyMembersByRelationshipType(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createreg_famillyDataAccess().GetFamilyMembersByRelationshipType(reg_familly, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_famillyEntity> Ireg_famillyFacade.GetAllByPagesreg_familly"));
            }
        }

        //async Task<reg_famillyEntity> Ireg_famillyFacadeObjects.GetFamiliyMemberByRelationType(BDO.Core.DataAccessObjects.Models.reg_famillyEntity reg_familly, System.Threading.CancellationToken cancellationToken)
        //{
        //    try
        //    {
        //        return await DataAccessFactory.Createreg_famillyDataAccess().GetFamiliyMemberByRelationType(reg_familly, cancellationToken);
        //    }

        //    catch (Exception ex)
        //    {
        //        throw GetFacadeException(ex, SourceOfException("reg_famillyEntity Ireg_famillyFacade.GetSinglereg_familly"));
        //    }
        //}
    }
}