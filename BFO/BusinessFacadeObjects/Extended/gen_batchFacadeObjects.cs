
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
    public sealed partial class gen_batchFacadeObjects
    {
		
       async Task<long> Igen_batchFacadeObjects.AddExt(gen_batchEntity gen_batch, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchDataAccess().AddExt(gen_batch, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_batchFacade.Addgen_batch"));
            }
		}
       
		async Task<IList<gen_batchEntity>> Igen_batchFacadeObjects.GetAllExt(gen_batchEntity gen_batch, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchDataAccess().GetAllExt(gen_batch, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_batchEntity> Igen_batchFacade.GetAllgen_batch"));
            }
		}


        async Task<IList<gen_batchEntity>> Igen_batchFacadeObjects.GetActiveBatch(gen_batchEntity gen_batch, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_batchDataAccess().GetActiveBatch(gen_batch, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_batchEntity> Igen_batchFacade.GetActiveBatch"));
            }
        }

        async Task<IList<gen_batchEntity>> Igen_batchFacadeObjects.GetActiveBatchDropDownForReview(gen_batchEntity gen_batch, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_batchDataAccess().GetActiveBatchDropDownForReview(gen_batch, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_batchEntity> Igen_batchFacade.GetActiveBatchDropDownForReview"));
            }
        }

        async Task<IList<gen_batchEntity>> Igen_batchFacadeObjects.GetAllBatch(gen_batchEntity gen_batch, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_batchDataAccess().GetAllBatch(gen_batch, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_batchEntity> Igen_batchFacade.GetAllBatch"));
            }
        }

        async Task<gen_batchEntity> Igen_batchFacadeObjects.GetBatchById(gen_batchEntity gen_batch, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_batchDataAccess().GetBatchById(gen_batch, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_batchEntity Igen_batchFacade.GetBatchById"));
            }
        }

        async Task<IList<gen_dropdownEntity>> Igen_batchFacadeObjects.GetMilitaryTypeWiseBatchForDropDown(gen_batchEntity gen_batch, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_batchDataAccess().GetMilitaryTypeWiseBatchForDropDown(gen_batch, cancellationToken);
            }
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_batchEntity> Igen_batchFacade.GetMilitaryTypeWiseBatchForDropDown"));
            }
        }
    }
}