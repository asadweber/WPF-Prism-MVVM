
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
    public sealed partial class gen_statusFacadeObjects
    {
		
       async Task<long> Igen_statusFacadeObjects.AddExt(gen_statusEntity gen_status, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_statusDataAccess().AddExt(gen_status, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_statusFacade.Addgen_status"));
            }
		}
       
		async Task<IList<gen_statusEntity>> Igen_statusFacadeObjects.GetAllExt(gen_statusEntity gen_status, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_statusDataAccess().GetAllExt(gen_status, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_statusEntity> Igen_statusFacade.GetAllgen_status"));
            }
		}
        
	}
}