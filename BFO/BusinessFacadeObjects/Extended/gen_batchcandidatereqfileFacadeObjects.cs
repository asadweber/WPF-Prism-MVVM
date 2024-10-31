
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
    public sealed partial class gen_batchcandidatereqfileFacadeObjects
    {
		
       async Task<long> Igen_batchcandidatereqfileFacadeObjects.AddExt(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandidatereqfileDataAccess().AddExt(gen_batchcandidatereqfile, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_batchcandidatereqfileFacade.Addgen_batchcandidatereqfile"));
            }
		}
       
		async Task<IList<gen_batchcandidatereqfileEntity>> Igen_batchcandidatereqfileFacadeObjects.GetAllExt(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandidatereqfileDataAccess().GetAllExt(gen_batchcandidatereqfile, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_batchcandidatereqfileEntity> Igen_batchcandidatereqfileFacade.GetAllgen_batchcandidatereqfile"));
            }
		}

        async Task<IList<gen_batchcandidatereqfileEntity>> Igen_batchcandidatereqfileFacadeObjects.GAPgListViewExt(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_batchcandidatereqfileDataAccess().GAPgListViewExt(gen_batchcandidatereqfile, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_batchcandidatereqfileEntity> Igen_batchcandidatereqfileFacade.GAPgListViewExtgen_batchcandidatereqfile"));
            }
        }

        async Task<gen_batchcandidatereqfileEntity> Igen_batchcandidatereqfileFacadeObjects.GetSingleExt(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_batchcandidatereqfileDataAccess().GetSingleExt(gen_batchcandidatereqfile, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_batchcandidatereqfileEntity Igen_batchcandidatereqfileFacade.GetSingleExtgen_batchcandidatereqfile"));
            }
        }

    }
}