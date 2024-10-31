
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
    public sealed partial class gen_rankFacadeObjects
    {
		
       async Task<long> Igen_rankFacadeObjects.AddExt(gen_rankEntity gen_rank, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_rankDataAccess().AddExt(gen_rank, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_rankFacade.Addgen_rank"));
            }
		}
       
		async Task<IList<gen_rankEntity>> Igen_rankFacadeObjects.GetAllExt(gen_rankEntity gen_rank, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_rankDataAccess().GetAllExt(gen_rank, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_rankEntity> Igen_rankFacade.GetAllgen_rank"));
            }
		}
        
	}
}