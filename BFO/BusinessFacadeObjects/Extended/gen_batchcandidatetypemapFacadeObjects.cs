
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
    public sealed partial class gen_batchcandidatetypemapFacadeObjects
    {
		
       async Task<long> Igen_batchcandidatetypemapFacadeObjects.AddExt(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandidatetypemapDataAccess().AddExt(gen_batchcandidatetypemap, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_batchcandidatetypemapFacade.Addgen_batchcandidatetypemap"));
            }
		}
       
		async Task<IList<gen_batchcandidatetypemapEntity>> Igen_batchcandidatetypemapFacadeObjects.GetAllExt(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandidatetypemapDataAccess().GetAllExt(gen_batchcandidatetypemap, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_batchcandidatetypemapEntity> Igen_batchcandidatetypemapFacade.GetAllgen_batchcandidatetypemap"));
            }
		}

        async Task<IList<gen_batchcandidatetypemapEntity>> Igen_batchcandidatetypemapFacadeObjects.GAPgListViewExt(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_batchcandidatetypemapDataAccess().GAPgListViewExt(gen_batchcandidatetypemap, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_batchcandidatetypemapEntity> Igen_batchcandidatetypemapFacade.GAPgListViewExtgen_batchcandidatetypemap"));
            }
        }

        async Task<IList<gen_dropdownEntity>> Igen_batchcandidatetypemapFacadeObjects.GetDataForDropDownExt(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_batchcandidatetypemapDataAccess().GetDataForDropDownExt(gen_batchcandidatetypemap, cancellationToken);
            }
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_batchcandidatetypemapEntity> Igen_batchcandidatetypemapFacade.GetDataForDropDownExt"));
            }
        }

        async Task<gen_batchcandidatetypemapEntity> Igen_batchcandidatetypemapFacadeObjects.GetSingleByBatchCandidateTypeID(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_batchcandidatetypemapDataAccess().GetSingleByBatchCandidateTypeID(gen_batchcandidatetypemap, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_batchcandidatetypemapEntity Igen_batchcandidatetypemapFacade.GetSingleByBatchCandidateTypeID"));
            }
        }

    }
}