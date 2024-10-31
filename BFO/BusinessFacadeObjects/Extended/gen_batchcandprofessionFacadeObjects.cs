
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
    public sealed partial class gen_batchcandprofessionFacadeObjects
    {
		
       async Task<long> Igen_batchcandprofessionFacadeObjects.AddExt(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandprofessionDataAccess().AddExt(gen_batchcandprofession, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_batchcandprofessionFacade.Addgen_batchcandprofession"));
            }
		}
       
		async Task<IList<gen_batchcandprofessionEntity>> Igen_batchcandprofessionFacadeObjects.GetAllExt(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandprofessionDataAccess().GetAllExt(gen_batchcandprofession, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_batchcandprofessionEntity> Igen_batchcandprofessionFacade.GetAllgen_batchcandprofession"));
            }
		}

        async Task<gen_batchcandprofessionEntity> Igen_batchcandprofessionFacadeObjects.GetSingleExt(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_batchcandprofessionDataAccess().GetSingleExt(gen_batchcandprofession, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_batchcandprofessionEntity Igen_batchcandprofessionFacade.GetSingleExtgen_batchcandprofession"));
            }
        }

        async Task<IList<gen_batchcandprofessionEntity>> Igen_batchcandprofessionFacadeObjects.GAPgListViewExt(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_batchcandprofessionDataAccess().GAPgListViewExt(gen_batchcandprofession, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_batchcandprofessionEntity> Igen_batchcandprofessionFacade.GAPgListViewExtgen_batchcandprofession"));
            }
        }

        async Task<gen_batchcandprofessionEntity> Igen_batchcandprofessionFacadeObjects.GetSingleByBatchCandidateTypeMapProfessionID(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_batchcandprofessionDataAccess().GetSingleByBatchCandidateTypeMapProfessionID(gen_batchcandprofession, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_batchcandprofessionEntity Igen_batchcandprofessionFacade.GetSingleByBatchCandidateTypeMapProfessionID"));
            }
        }

    }
}