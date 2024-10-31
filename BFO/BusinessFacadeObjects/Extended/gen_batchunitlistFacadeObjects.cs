
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
    public sealed partial class gen_batchunitlistFacadeObjects
    {
		
       async Task<long> Igen_batchunitlistFacadeObjects.AddExt(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchunitlistDataAccess().AddExt(gen_batchunitlist, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_batchunitlistFacade.Addgen_batchunitlist"));
            }
		}
       
		async Task<IList<gen_batchunitlistEntity>> Igen_batchunitlistFacadeObjects.GetAllExt(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchunitlistDataAccess().GetAllExt(gen_batchunitlist, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_batchunitlistEntity> Igen_batchunitlistFacade.GetAllgen_batchunitlist"));
            }
		}

        async Task<IList<gen_batchunitlistEntity>> Igen_batchunitlistFacadeObjects.GAPgListViewExt(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_batchunitlistDataAccess().GAPgListViewExt(gen_batchunitlist, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_batchunitlistEntity> Igen_batchunitlistFacade.GAPgListViewExtgen_batchunitlist"));
            }
        }

    }
}